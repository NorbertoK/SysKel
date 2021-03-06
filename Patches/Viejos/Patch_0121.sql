USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ImportarPadron]    Script Date: 07/14/2013 12:42:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ImportarPadron]
    @xls VARCHAR(1000) = ''
   ,@hoja VARCHAR(100)
   ,@idPlan INT
   ,@FechaSolicitudes VARCHAR(8)
   ,@idGrabador INT
AS 
    BEGIN
        SET NOCOUNT ON ;
        EXEC sp_configure 'show advanced options', 1
        RECONFIGURE

        EXEC sp_configure 'Ad Hoc Distributed Queries', 1
        RECONFIGURE
        DECLARE @FechaRegistro DATE = GETDATE()
        DECLARE @idVendedor INT
           ,@idMotivoDeBaja INT
        SELECT TOP 1
                @idVendedor = VendedorAfiliadosContrato
               ,@idMotivoDeBaja = MotivoDeBaja_Automatica
        FROM    dbo.Sistemas
        DECLARE @sql VARCHAR(1000)
        /* Crea la sentencia para importar planilla Excel */
        SET @sql = 'SELECT * FROM OPENROWSET(' + '''Microsoft.ACE.OLEDB.12.0''' + ',' + '''Excel 8.0;Database=' + @xls + '''' + ','
            + '''select [h.DNI], [h.Apellido], [h.Nombre], [h.Sexo],[h.Fecha de Nacimiento],[h.Observaciones] from [' + @hoja + '$] h''' + ')'
        /* Tabla con la misma configuración que la planilla original
           (DNI INT) */    
        CREATE TABLE #NuevoPadronProvi
            (
             DNI INT
            ,Apellido VARCHAR(50)
            ,Nombre VARCHAR(50)
            ,Sexo VARCHAR(10)
            ,[Fecha de Nacimiento] DATE
            ,Observaciones VARCHAR(MAX)
            )
        /* Tabla con el DNI como en la tabla de SQL Server */    
        CREATE TABLE #NuevoPadron
            (
             DNI VARCHAR(20)
            ,Apellido VARCHAR(50)
            ,Nombre VARCHAR(50)
            ,Sexo VARCHAR(1)
            ,[Fecha de Nacimiento] DATE
            ,Observaciones VARCHAR(MAX)
            )
        BEGIN TRANSACTION
        BEGIN TRY
			/* Importar planilla Excel */    
            INSERT  INTO #NuevoPadronProvi
                    (DNI
                    ,Apellido
                    ,Nombre
                    ,Sexo
                    ,[Fecha de Nacimiento]
                    ,Observaciones         
                    )
                    EXEC (@sql
                        )
            /* Convertir el campo DNI a String y el Sexo a 1 carácter */            
            INSERT  INTO #NuevoPadron
                    (DNI
                    ,Apellido
                    ,Nombre
                    ,Sexo
                    ,[Fecha de Nacimiento]
                    ,Observaciones
                    
                    )
                    SELECT  CAST(npp.DNI AS VARCHAR(20))
                           ,npp.Apellido
                           ,npp.Nombre
                           ,LEFT(npp.Sexo, 1)
                           ,npp.[Fecha de Nacimiento]
                           ,npp.Observaciones
                    FROM    #NuevoPadronProvi npp
            --/* Obtener el idGrupo donde hay más afiliados de ese Contrato.
            --   Si no hay ninguno, crear el grupo. */
            DECLARE @idGrupo INT
            SELECT  @idGrupo = gru.idGrupo
            FROM    (SELECT TOP 1
                            g.idGrupo idGrupo
                           ,COUNT(DISTINCT af.idAfiliado) Cantidad
                     FROM   dbo.Grupos g
                            JOIN dbo.Afiliados af ON g.idGrupo = af.idGrupo
                            JOIN dbo.Solicitudes sol ON af.idAfiliado = sol.idAfiliado
                            JOIN dbo.AfiliadosPlanes ap ON sol.idSolicitud = ap.idSolicitud
                     WHERE  g.idTipoDeCobranza = 3
                            AND ap.idPlan IN (SELECT    pl.idPlan
                                              FROM      dbo.Contratos cto
                                                        JOIN dbo.Planes pl ON cto.idContrato = pl.idContrato
                                              WHERE     cto.idContrato = (SELECT    pl.idContrato
                                                                          FROM      dbo.Planes pl
                                                                          WHERE     pl.idPlan = @idPlan
                                                                         ))
                     GROUP BY g.idGrupo
                     ORDER BY COUNT(*) DESC
                    ) gru     
            IF @idGrupo IS NULL 
                BEGIN
                    INSERT  INTO [Datos].[dbo].[Grupos]
                            ([idTipoDeCobranza], [Activo])
                    VALUES  (3, 1)
                    SET @idGrupo = SCOPE_IDENTITY()
                END
            /* Si el afiliado no existe en el padrón del Sistema, ingresarlo en el grupo predeterminado y darle de alta. */
            DECLARE @AfiliadosIngresados TABLE (idAfiliado INT) 
            DECLARE @Solicitudes TABLE (idSolicitud INT) ;
            WITH    AfiliadosNuevos(DNI, Apellido, Nombre, Sexo, FechaDeNacimiento, Observaciones)
                      AS (SELECT    np.DNI
                                   ,np.Apellido
                                   ,np.Nombre
                                   ,np.Sexo
                                   ,np.[Fecha de Nacimiento]
                                   ,np.Observaciones
                          FROM      #NuevoPadron np
                          WHERE     NOT EXISTS ( SELECT *
                                                 FROM   dbo.Afiliados af
                                                        JOIN dbo.Grupos g ON af.idGrupo = g.idGrupo
                                                        JOIN dbo.Solicitudes sol ON af.idAfiliado = sol.idAfiliado
                                                        JOIN dbo.AfiliadosPlanes ap ON sol.idSolicitud = ap.idSolicitud
                                                 WHERE  g.idTipoDeCobranza = 3
                                                        AND ap.idPlan = @idPlan
                                                        AND af.NumeroDeDocumento = np.DNI )
                         )
                INSERT  dbo.Afiliados
                        (idGrupo
                        ,Titular
                        ,Apellido
                        ,Nombre
                        ,idTipoDeDocumento
                        ,NumeroDeDocumento
                        ,Sexo
                        ,FechaDeNacimiento
                        ,Otros
                        )
                OUTPUT  INSERTED.idAfiliado
                        INTO @AfiliadosIngresados
                        SELECT  @idGrupo
                               ,0
                               ,Apellido
                               ,Nombre
                               ,(SELECT DNI
                                 FROM   dbo.Sistemas
                                )
                               ,DNI
                               ,Sexo
                               ,FechaDeNacimiento
                               ,Observaciones
                        FROM    AfiliadosNuevos
            INSERT  dbo.Solicitudes
                    (AltaBajaSusp
                    ,idAfiliado
                    ,Fecha
                    ,FechaRegistro
                    ,idVendedor
                    ,EsCambioDePlan
                    ,idGrabador
                    )
            OUTPUT  INSERTED.idSolicitud
                    INTO @Solicitudes
                    SELECT  'A'
                           ,idAfiliado
                           ,@FechaSolicitudes
                           ,@FechaRegistro
                           ,@idVendedor
                           ,0
                           ,@idGrabador
                    FROM    @AfiliadosIngresados
            INSERT  dbo.AfiliadosPlanes
                    (idSolicitud
                    ,idPlan 
                    )
                    SELECT  idSolicitud
                           ,@idPlan
                    FROM    @Solicitudes
            /* Si el afiliado existe en el Sistema con ese plan pero está de baja, darle en alta en el mismo lugar. */
            DELETE  @Solicitudes ;
            WITH    AfiliadosDeBaja(idAfiliado)
                      AS (SELECT    af.idAfiliado
                          FROM      #NuevoPadron np
                                    JOIN dbo.Afiliados af ON np.DNI = af.NumeroDeDocumento
                          WHERE     dbo.EstadoAfiliadoPlan(af.idAfiliado, @idPlan) = 'B'
                         )
                INSERT  dbo.Solicitudes
                        (AltaBajaSusp
                        ,idAfiliado
                        ,Fecha
                        ,FechaRegistro
                        ,idVendedor
                        ,EsCambioDePlan
                        ,idGrabador
                        )
                OUTPUT  INSERTED.idSolicitud
                        INTO @Solicitudes
                        SELECT  'A'
                               ,idAfiliado
                               ,@FechaSolicitudes
                               ,@FechaRegistro
                               ,@idVendedor
                               ,0
                               ,@idGrabador
                        FROM    AfiliadosDeBaja
            INSERT  dbo.AfiliadosPlanes
                    (idSolicitud
                    ,idPlan 
                    )
                    SELECT  idSolicitud
                           ,@idPlan
                    FROM    @Solicitudes
            /* Si el afiliado está en el Sistema con ese plan pero no en la planilla, darle de baja en el mismo lugar. */
            DELETE  @Solicitudes ;
            WITH    AfiliadosDarBaja(idAfiliado)
                      AS (SELECT    af.idAfiliado
                          FROM      dbo.Afiliados af
                          WHERE     dbo.EstadoAfiliadoPlan(af.idAfiliado, @idPlan) = 'A'
                                    AND af.NumeroDeDocumento NOT IN (SELECT DNI
                                                                     FROM   #NuevoPadron)
                         )
                INSERT  dbo.Solicitudes
                        (AltaBajaSusp
                        ,idAfiliado
                        ,Fecha
                        ,FechaRegistro
                        ,idTomadorDeBaja
                        ,idMotivoDeBaja
                        ,EsCambioDePlan
                        ,idGrabador
                        )
                OUTPUT  INSERTED.idSolicitud
                        INTO @Solicitudes
                        SELECT  'B'
                               ,idAfiliado
                               ,@FechaSolicitudes
                               ,@FechaRegistro
                               ,@idVendedor
                               ,@idMotivoDeBaja
                               ,0
                               ,@idGrabador
                        FROM    AfiliadosDarBaja
            INSERT  dbo.AfiliadosPlanes
                    (idSolicitud
                    ,idPlan 
                    )
                    SELECT  idSolicitud
                           ,@idPlan
                    FROM    @Solicitudes ;
            /* Actualizar los apellidos y nombres */
            WITH    AfiliadosDarBaja(idAfiliado)
                      AS (SELECT    af.idAfiliado
                          FROM      dbo.Afiliados af
                          WHERE     dbo.EstadoAfiliadoPlan(af.idAfiliado, @idPlan) = 'A'
                         )
                UPDATE  dbo.Afiliados
                SET     Apellido = np.Apellido
                       ,Nombre = np.Nombre
                       ,Sexo = np.Sexo
                       ,FechaDeNacimiento = np.[Fecha de Nacimiento]
                       ,Otros = np.Observaciones
                FROM    dbo.Afiliados af
                        JOIN #NuevoPadron np ON af.NumeroDeDocumento = np.DNI
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION
            RETURN 0
        END CATCH
        COMMIT TRANSACTION
        RETURN 1
    END

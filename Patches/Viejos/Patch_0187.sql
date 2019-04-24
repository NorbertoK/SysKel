USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ImportarPadron]    Script Date: 10/29/2013 14:17:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ImportarPadron]
    @proceso VARCHAR(255)
   ,@idPlan INT
   ,@FechaSolicitudes VARCHAR(8)
   ,@idGrabador INT
AS 
    BEGIN
        SET NOCOUNT ON ;
        DECLARE @FechaRegistro DATE = GETDATE()
        DECLARE @idVendedor INT
           ,@idMotivoDeBaja INT
        SELECT TOP 1
                @idVendedor = VendedorAfiliadosContrato
               ,@idMotivoDeBaja = MotivoDeBaja_Automatica
        FROM    dbo.Sistemas
        DECLARE @idPrepago INT
        SELECT @idPrepago = idPrepago FROM dbo.Planes WHERE idPlan = @idPlan
        BEGIN TRANSACTION
        BEGIN TRY
            /* Obtener el idGrupo donde hay más afiliados de ese Contrato.
               Si no hay ninguno, crear el grupo. */
            DECLARE @idGrupo INT
            SELECT  @idGrupo = gru.idGrupo
            FROM    ( SELECT TOP 1
                                g.idGrupo idGrupo
                               ,COUNT(DISTINCT af.idAfiliado) Cantidad
                      FROM      dbo.Grupos g
                      JOIN      dbo.Afiliados af ON g.idGrupo = af.idGrupo
                      JOIN      dbo.Solicitudes sol ON af.idAfiliado = sol.idAfiliado
                      JOIN      dbo.AfiliadosPlanes ap ON sol.idSolicitud = ap.idSolicitud
                      WHERE     g.idTipoDeCobranza = 3
                                AND ap.idPlan IN ( SELECT   pl.idPlan
                                                   FROM     dbo.Contratos cto
                                                   JOIN     dbo.Planes pl ON cto.idContrato = pl.idContrato
                                                   WHERE    cto.idContrato = ( SELECT   pl.idContrato
                                                                               FROM     dbo.Planes pl
                                                                               WHERE    pl.idPlan = @idPlan
                                                                             ) )
                      GROUP BY  g.idGrupo
                      ORDER BY  COUNT(*) DESC
                    ) gru     
            IF @idGrupo IS NULL 
                BEGIN
                    INSERT  INTO [Datos].[dbo].[Grupos]
                            ( [idTipoDeCobranza], [Activo] )
                    VALUES  ( 3, 1 )
                    SET @idGrupo = SCOPE_IDENTITY()
                END
            /* Si el afiliado no existe en el padrón del Sistema, ingresarlo en el grupo predeterminado y darle de alta. */
            DECLARE @AfiliadosIngresados TABLE
                (
                 idAfiliado INT
                ,DNI VARCHAR(12)
                ) 
            DECLARE @Solicitudes TABLE ( idSolicitud INT ) ;
            WITH    AfiliadosNuevos ( DNI, Apellido, Nombre, Sexo, FechaDeNacimiento, Observaciones, Direccion, Telefono, AfiliadoPrepago )
                      AS ( SELECT   tip.DNI
                                   ,tip.Apellido
                                   ,tip.Nombre
                                   ,tip.Sexo
                                   ,tip.FechaNac
                                   ,tip.Observaciones
                                   ,Direccion
                                   ,Telefono
                                   ,AfiliadoPrepago
                           FROM     dbo.TablaImportarPadron tip
                           WHERE    tip.proceso = @proceso
                                    AND NOT EXISTS ( SELECT *
                                                     FROM   dbo.Afiliados af
                                                     JOIN   dbo.Grupos g ON af.idGrupo = g.idGrupo
                                                     JOIN   dbo.Solicitudes sol ON af.idAfiliado = sol.idAfiliado
                                                     JOIN   dbo.AfiliadosPlanes ap ON sol.idSolicitud = ap.idSolicitud
                                                     WHERE  g.idTipoDeCobranza = 3
                                                            AND ap.idPlan = @idPlan
                                                            AND af.NumeroDeDocumento = tip.DNI )
                         )
                INSERT  dbo.Afiliados
                        ( 
                         idGrupo
                        ,Titular
                        ,Apellido
                        ,Nombre
                        ,idTipoDeDocumento
                        ,NumeroDeDocumento
                        ,Sexo
                        ,FechaDeNacimiento
                        ,Otros
                        ,idPrepago
                        ,NumeroAfiliadoPrepago
                        )
                OUTPUT  INSERTED.idAfiliado
                       ,INSERTED.NumeroDeDocumento
                        INTO @AfiliadosIngresados
                        SELECT  @idGrupo
                               ,0
                               ,Apellido
                               ,Nombre
                               ,( SELECT    DNI
                                  FROM      dbo.Sistemas
                                )
                               ,DNI
                               ,Sexo
                               ,FechaDeNacimiento
                               ,Observaciones
                               ,@idPrepago
                               ,AfiliadoPrepago
                        FROM    AfiliadosNuevos
            INSERT  dbo.Solicitudes
                    ( 
                     AltaBajaSusp
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
                    ( 
                     idSolicitud
                    ,idPlan 
                    )
                    SELECT  idSolicitud
                           ,@idPlan
                    FROM    @Solicitudes
            INSERT  dbo.Direcciones
                    ( Observaciones
                    ,idAfiliado
                    )
                    SELECT  tip.Direccion
                           ,ai.idAfiliado
                    FROM    @AfiliadosIngresados ai
                    JOIN    dbo.TablaImportarPadron tip ON ai.DNI = tip.DNI
                    WHERE   tip.proceso = @proceso
            INSERT  dbo.Telefonos
                    ( 
                     Numero
                    ,idAfiliado
                    )
                    SELECT  tip.Telefono
                           ,ai.idAfiliado
                    FROM    @AfiliadosIngresados ai
                    JOIN    dbo.TablaImportarPadron tip ON ai.DNI = tip.DNI
                    WHERE   tip.proceso = @proceso
            /* Si el afiliado existe en el Sistema con ese plan pero está de baja, darle en alta en el mismo lugar. */
            DELETE  @Solicitudes ;
            WITH    AfiliadosDeBaja ( idAfiliado )
                      AS ( SELECT   af.idAfiliado
                           FROM     dbo.TablaImportarPadron tip
                           JOIN     dbo.Afiliados af ON tip.DNI = af.NumeroDeDocumento
                           WHERE    tip.Proceso = @proceso
                                    AND dbo.EstadoAfiliadoPlan(af.idAfiliado, @idPlan) = 'B'
                         )
                INSERT  dbo.Solicitudes
                        ( 
                         AltaBajaSusp
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
                    ( 
                     idSolicitud
                    ,idPlan 
                    )
                    SELECT  idSolicitud
                           ,@idPlan
                    FROM    @Solicitudes
            /* Si el afiliado está en el Sistema con ese plan pero no en la planilla, darle de baja en el mismo lugar. */
            DELETE  @Solicitudes ;
            WITH    AfiliadosDarBaja ( idAfiliado )
                      AS ( SELECT   af.idAfiliado
                           FROM     dbo.Afiliados af
                           WHERE    dbo.EstadoAfiliadoPlan(af.idAfiliado, @idPlan) = 'A'
                                    AND af.NumeroDeDocumento NOT IN ( SELECT    DNI
                                                                      FROM      dbo.TablaImportarPadron
                                                                      WHERE     Proceso = @proceso )
                         )
                INSERT  dbo.Solicitudes
                        ( 
                         AltaBajaSusp
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
                    ( 
                     idSolicitud
                    ,idPlan 
                    )
                    SELECT  idSolicitud
                           ,@idPlan
                    FROM    @Solicitudes ;
            /* Actualizar los apellidos y nombres */
            WITH    AfiliadosDarBaja ( idAfiliado )
                      AS ( SELECT   af.idAfiliado
                           FROM     dbo.Afiliados af
                           WHERE    dbo.EstadoAfiliadoPlan(af.idAfiliado, @idPlan) = 'A'
                         )
                UPDATE  dbo.Afiliados
                SET     Apellido = tip.Apellido
                       ,Nombre = tip.Nombre
                       ,Sexo = tip.Sexo
                       ,FechaDeNacimiento = tip.[FechaNac]
                       ,Otros = tip.Observaciones
                FROM    dbo.Afiliados af
                JOIN    dbo.TablaImportarPadron tip ON af.NumeroDeDocumento = tip.DNI
                WHERE   tip.Proceso = @proceso
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION
            RETURN 0
        END CATCH
        COMMIT TRANSACTION
        RETURN 1
    END

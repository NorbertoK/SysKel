USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ImportarPadronExt]    Script Date: 08/24/2018 11:01:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Stored Procedure

ALTER PROCEDURE [dbo].[ImportarPadronExt]
    @proceso VARCHAR(255)
   ,@idPlan INT
   ,@FechaSolicitudes VARCHAR(8)
   ,@idGrabador INT
AS 
    BEGIN
        SET NOCOUNT ON;
        DECLARE @FechaRegistro DATE = GETDATE()
        DECLARE @idVendedor INT
           ,@idMotivoDeBaja INT
        SELECT TOP 1
                @idVendedor = VendedorAfiliadosContrato
               ,@idMotivoDeBaja = MotivoDeBaja_Automatica
        FROM    dbo.Sistemas
        DECLARE @idPrepago INT
        SELECT  @idPrepago = idPrepago
        FROM    dbo.Planes
        WHERE   idPlan = @idPlan
        BEGIN TRANSACTION
        BEGIN TRY
            /*Ingresar los grupos que no estén en la base de datos.*/
            
            INSERT  INTO [Datos].[dbo].[Grupos]
                    ( 
                     [idTipoDeCobranza]
                    ,[idGrabador]
                    ,[idUltimoModificador]
                    ,[Activo]
                    ,[GrupoMigracion]
                    )
                    SELECT  DISTINCT
                            3
                           ,@idGrabador
                           ,@idGrabador
                           ,1
                           ,GrupoMigracion
                    FROM    dbo.TablaImportarPadron tip
                    WHERE   Proceso = @proceso
                            AND ( SELECT    COUNT(*)
                                  FROM      dbo.Grupos
                                  WHERE     GrupoMigracion = tip.GrupoMigracion
                                ) = 0
            /*Fin de Ingresar los grupos que no estén en la base de datos.*/
        
            /* Si el afiliado no existe en el padrón del Sistema, ingresarlo y darle de alta. */
            DECLARE @AfiliadosIngresados TABLE
                (
                 idAfiliado INT
                ,DNI VARCHAR(12)
                ) 
            DECLARE @Solicitudes TABLE ( idSolicitud INT );
            WITH    AfiliadosNuevos ( DNI, Apellido, Nombre, Sexo, FechaDeNacimiento, Observaciones, Direccion, Telefono, AfiliadoPrepago, CodPost, GrupoMigracion )
                      AS ( SELECT   tip.DNI
                                   ,tip.Apellido
                                   ,tip.Nombre
                                   ,tip.Sexo
                                   ,tip.FechaNac
                                   ,tip.Observaciones
                                   ,Direccion
                                   ,Telefono
                                   ,AfiliadoPrepago
                                   ,CodPost
                                   ,GrupoMigracion
                           FROM     dbo.TablaImportarPadron tip
                           WHERE    tip.proceso = @proceso
                                    AND ( SELECT    COUNT(*)
                                          FROM      dbo.Afiliados af
                                                    JOIN dbo.Grupos g ON af.idGrupo = g.idGrupo
                                                    JOIN dbo.Solicitudes sol ON af.idAfiliado = sol.idAfiliado
                                                    JOIN dbo.AfiliadosPlanes ap ON sol.idSolicitud = ap.idSolicitud
                                          WHERE     g.idTipoDeCobranza = 3
                                                    AND ap.idPlan = @idPlan
                                                    AND af.NumeroDeDocumento = tip.DNI
                                        ) = 0
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
                        SELECT  ( SELECT    idGrupo
                                  FROM      dbo.Grupos
                                  WHERE     GrupoMigracion = AfiliadosNuevos.GrupoMigracion
                                )
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
                    ( 
                     Observaciones
                    ,idAfiliado
                    ,idLocalidad
                    )
                    SELECT  tip.Direccion
                           ,ai.idAfiliado
                           ,( SELECT TOP 1
                                        idLocalidad
                              FROM      dbo.Localidades
                              WHERE     CodigoPostal = tip.CodPost
                            )
                    FROM    @AfiliadosIngresados ai
                            JOIN dbo.TablaImportarPadron tip ON ai.DNI = tip.DNI
                    WHERE   tip.proceso = @proceso
                            AND tip.Direccion IS NOT NULL
            INSERT  dbo.Telefonos
                    ( 
                     Numero
                    ,idAfiliado
                    )
                    SELECT  tip.Telefono
                           ,ai.idAfiliado
                    FROM    @AfiliadosIngresados ai
                            JOIN dbo.TablaImportarPadron tip ON ai.DNI = tip.DNI
                    WHERE   tip.proceso = @proceso
                            AND tip.Telefono IS NOT NULL
            /* Si el afiliado existe en el Sistema con ese plan pero está de baja, darle en alta en el mismo lugar. */
            DELETE  @Solicitudes;
            WITH    AfiliadosDeBaja ( idAfiliado )
                      AS ( SELECT   af.idAfiliado
                           FROM     dbo.TablaImportarPadron tip
                                    JOIN dbo.Afiliados af ON tip.DNI = af.NumeroDeDocumento
                           WHERE    tip.Proceso = @proceso
                                    AND dbo.EstadoAfiliadoPlan(af.idAfiliado,
                                                              @idPlan) = 'B'
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
            DELETE  @Solicitudes;
            WITH    AfiliadosDarBaja ( idAfiliado )
                      AS ( SELECT   af.idAfiliado
                           FROM     dbo.Afiliados af
                           WHERE    dbo.EstadoAfiliadoPlan(af.idAfiliado,
                                                           @idPlan) = 'A'
                                    AND af.NumeroDeDocumento NOT IN (
                                    SELECT  DNI
                                    FROM    dbo.TablaImportarPadron
                                    WHERE   Proceso = @proceso )
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
                    FROM    @Solicitudes;
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION
            RETURN 0
        END CATCH
        COMMIT TRANSACTION
        RETURN 1
    END

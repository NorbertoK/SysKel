USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ImportarPadronSAE]    Script Date: 07/19/2016 19:37:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ImportarPadronSAE]
AS 
    BEGIN
        SET NOCOUNT ON;
        DECLARE @FechaRegistro DATE = GETDATE()
        DECLARE @idVendedor INT ,
            @idGrabador INT
        SELECT TOP 1
                @idVendedor = idEmpleado
        FROM    dbo.Empleados
        WHERE   Apellido = 'Migración'
        SELECT  @idGrabador = idUsuario
        FROM    dbo.Usuarios
        WHERE   Apellido = 'Migración'
        BEGIN TRANSACTION
        BEGIN TRY
            DECLARE @GruposIngresados TABLE ( idGrupo INT, Grupo INT )
            INSERT  INTO [Datos].[dbo].[Grupos]
                    ( [idTipoDeCobranza] ,
                      [idGrabador] ,
                      [idUltimoModificador] ,
                      [Activo] ,
                      [idCategoriaIVA] ,
                      [CUIT] ,
                      [GrupoMigracion]
                    )
            OUTPUT  INSERTED.idGrupo ,
                    INSERTED.GrupoMigracion
                    INTO @GruposIngresados
                    SELECT  CASE WHEN CODCOBRADOR = 305050 THEN 4
                                 ELSE 3
                            END ,
                            @idGrabador ,
                            NULL ,
                            1 ,
                            idCategoriaIVA ,
                            CUIT ,
                            Grupo
                    FROM    dbo.Afiliados$
                    WHERE   Titular = 1
            
            DECLARE @DireccionesIngresadas TABLE
                (
                  idDireccion INT ,
                  idGrupo INT
                )        
            INSERT  INTO [Datos].[dbo].[Direcciones]
                    ( [Real] ,
                      [Cobranza] ,
                      [idLocalidad] ,
                      [Observaciones] ,
                      [idGrupo]
                    )
            OUTPUT  INSERTED.idDireccion ,
                    INSERTED.idGrupo
                    INTO @DireccionesIngresadas
                    SELECT  CASE WHEN DomicilioReal IS NULL THEN 0
                                 ELSE 1
                            END ,
                            CASE WHEN DomicilioCobranza IS NOT NULL
                                      AND DomicilioCobranza = DomicilioReal
                                 THEN 1
                                 ELSE 0
                            END ,
                            1 ,
                            CASE WHEN DomicilioReal IS NOT NULL
                                 THEN DomicilioReal
                                 ELSE DomicilioCobranza
                            END ,
                            g.idGrupo
                    FROM    dbo.Afiliados$ a
                            JOIN @GruposIngresados g ON a.Grupo = g.Grupo
                    WHERE   Titular = 1
                    UNION
                    SELECT  0 ,
                            1 ,
                            1 ,
                            DomicilioCobranza ,
                            g.idGrupo
                    FROM    dbo.Afiliados$ a
                            JOIN @GruposIngresados g ON a.Grupo = g.Grupo
                    WHERE   Titular = 1
                            AND DomicilioCobranza IS NOT NULL
                            AND DomicilioReal <> DomicilioCobranza
                    
            INSERT  INTO [Datos].[dbo].[Telefonos]
                    ( [Numero] ,
                      [idDireccion]
                    )
                    SELECT  a.Telefono ,
                            d.idDireccion
                    FROM    dbo.Afiliados$ a
                            JOIN @gruposIngresados g ON a.Grupo = g.Grupo
                            JOIN @DireccionesIngresadas d ON g.idGrupo = d.idGrupo
                    WHERE   a.Telefono IS NOT NULL
            
            DECLARE @AfiliadosIngresados TABLE
                (
                  idAfiliado INT ,
                  NumeroAfiliadoPrepago VARCHAR(20)
                ) 
            INSERT  INTO [Datos].[dbo].[Afiliados]
                    ( [Apellido] ,
                      [Nombre] ,
                      [idTipoDeDocumento] ,
                      [NumeroDeDocumento] ,
                      [FechaDeNacimiento] ,
                      [Sexo] ,
                      [Titular] ,
                      [idGrupo] ,
                      [NumeroAfiliadoPrepago]
                    )
            OUTPUT  INSERTED.idAfiliado ,
                    INSERTED.NumeroAfiliadoPrepago
                    INTO @AfiliadosIngresados
                    SELECT  a.Apellido ,
                            a.Nombre ,
                            a.idTipoDeDocumento ,
                            a.NumeroDeDocumento ,
                            a.FechaDeNacimiento ,
                            a.Sexo ,
                            a.Titular ,
                            g.idGrupo ,
                            CAST(a.Grupo AS VARCHAR(15)) + '/'
                            + CAST(a.Barra AS VARCHAR(3))
                    FROM    dbo.Afiliados$ a
                            JOIN @gruposIngresados g ON a.Grupo = g.Grupo
                    
            DECLARE @Solicitudes TABLE
                (
                  idSolicitud INT ,
                  idAfiliado INT
                );
            
            INSERT  dbo.Solicitudes
                    ( AltaBajaSusp ,
                      idAfiliado ,
                      Fecha ,
                      FechaRegistro ,
                      idVendedor ,
                      EsCambioDePlan ,
                      idGrabador
                    )
            OUTPUT  INSERTED.idSolicitud ,
                    INSERTED.idAfiliado
                    INTO @Solicitudes
                    SELECT  'A' ,
                            idAfiliado ,
                            ISNULL(FechaDeIngreso, CAST('19470121' AS DATE)) ,
                            @FechaRegistro ,
                            @idVendedor ,
                            0 ,
                            @idGrabador
                    FROM    @AfiliadosIngresados ai
                            JOIN dbo.Afiliados$ a$ ON ai.NumeroAfiliadoPrepago = CAST(a$.Grupo AS VARCHAR(15))
                                                      + '/'
                                                      + CAST(a$.Barra AS VARCHAR(3))
            INSERT  dbo.AfiliadosPlanes
                    ( idSolicitud ,
                      idPlan 
                    )
                    SELECT  idSolicitud ,
                            CASE CODCOBRADOR
                              WHEN 301004 THEN 8 -- A.A.T.R.A
                              WHEN 301003 THEN 9 -- ADEP
                              WHEN 301001 THEN 10 -- A.D.I.U.N.J.U.
                              WHEN 301007 THEN 21 -- APL
                              WHEN 301085 THEN 38 -- APOC
                              WHEN 301028 THEN 11 -- A.T.S.A.
                              WHEN 305050 THEN 39 -- Sin Cargo
                              WHEN 301151 THEN 12 -- Amucdems
                              WHEN 301052 THEN 22 -- AsCivSecPa
                              WHEN 301025 THEN 13 -- Mutual Seguros
                              WHEN 301016 THEN 14 -- Judicial Provincial
                              WHEN 301039 THEN 15 -- Banco Nación 
                              WHEN 301048 THEN 16 -- C.E.D.E.M.S.
                              WHEN 302027 THEN 17 -- La Virginia
                              WHEN 301041 THEN 18 -- CIRSE
                              WHEN 301117 THEN 19 -- Odontólogos
                              WHEN 301044 THEN 20 -- Policía
                              WHEN 301009 THEN 23 -- Magistrados
                              WHEN 301008 THEN 24 -- Colegio Médico
                              WHEN 301190 THEN 25 -- Consejo General Educación
                              WHEN 301013 THEN 26 -- Jubilados y Pensionados
                              WHEN 301090 THEN 27 -- Hierros
                              WHEN 302519 THEN 28 -- International Healt Services
                              WHEN 301029 THEN 29 -- Mutual Personal Banco Provincia
                              WHEN 301168 THEN 30 -- Propaganda Médica
                              WHEN 301111 THEN 31 -- Omint c/IVA
                              WHEN 302001 THEN 32 -- Perbas
                              WHEN 301011 THEN 33 -- Caja Ahorro y Seguro
                              WHEN 301128 THEN 7 -- Relojería
                              WHEN 302024 THEN 34 -- S.O.E.E.S.I.T.J.
                              WHEN 301061 THEN 35 -- SEOM Jujuy
                              WHEN 301024 THEN 36 -- Luz y Fuerza
                              WHEN 302062 THEN 40 -- Socorro Médico Privado
                              WHEN 302026 THEN 40 -- Socorro Médico Privado
                              WHEN 300102 THEN 37 -- UNJU
                            END
                    FROM    @Solicitudes sol
                            JOIN @AfiliadosIngresados ai ON sol.idAfiliado = ai.idAfiliado
                            JOIN dbo.Afiliados$ a$ ON ai.NumeroAfiliadoPrepago = CAST(a$.Grupo AS VARCHAR(15))
                                                      + '/1'
                    WHERE   a$.Titular = 1
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION
            RETURN 0
        END CATCH
        COMMIT TRANSACTION
        RETURN 1
    END

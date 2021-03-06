USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[AgregarProgramado]    Script Date: 12/15/2013 15:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery5.sql|7|0|C:\Users\Norberto Kelijman\AppData\Local\Temp\~vsB07.sql

ALTER PROCEDURE [dbo].[AgregarProgramado]
    (
     @prestacionesString VARCHAR(MAX)
    ,@FechaYHora VARCHAR(17)
    ,@telefono VARCHAR(50)
    ,@idLocalidad_1 INT
    ,@idCalle_1 INT
    ,@Numero_1 VARCHAR(100)
    ,@Piso_1 VARCHAR(20)
    ,@Departamento_1 VARCHAR(20)
    ,@idEntreCalle1_1 INT
    ,@idEntreCalle2_1 INT
    ,@ObservacionesDireccion_1 VARCHAR(MAX)
    ,@idBarrio_1 INT
    ,@idLocalidad_2 INT
    ,@idCalle_2 INT
    ,@Numero_2 VARCHAR(100)
    ,@Piso_2 VARCHAR(20)
    ,@Departamento_2 VARCHAR(20)
    ,@idEntreCalle1_2 INT
    ,@idEntreCalle2_2 INT
    ,@ObservacionesDireccion_2 VARCHAR(MAX)
    ,@idBarrio_2 INT
    ,@HaySegundaDirección BIT
    ,@EsperaYRetorno BIT
    ,@idAfiliado INT
    ,@ApelNomb VARCHAR(100)
    ,@idTipoDeDocumento INT
    ,@NumeroDeDocumento VARCHAR(20)
    ,@Edad INT
    ,@EdadEn VARCHAR(1)
    ,@Sexo VARCHAR(1)
    ,@idPrepago INT
    ,@NumeroPrepago VARCHAR(20)
    ,@importe DECIMAL(10, 2)
    ,@Antecedentes VARCHAR(MAX)
    ,@idCobertura INT
    ,@idPractica INT
    ,@idContrato INT
    ,@idTomador INT
    ,@extraCobertura BIT
    ,@copagoSugerido MONEY
    )
AS 
    SET NOCOUNT ON
    DECLARE @numeroDePrestacion INT
    DECLARE @numeroDePrestacionChar VARCHAR(15)
    DECLARE @idPrestacion INT
    DECLARE @idDestino INT
    DECLARE @idPaciente INT
    DECLARE @idCodigo INT
    DECLARE @idTipoDeDestino INT
    IF @idCobertura = 0 
        SET @idCobertura = NULL
    IF @idPractica = 0 
        SET @idPractica = NULL
    BEGIN TRANSACTION
    BEGIN TRY
        SELECT TOP 1
                @idCodigo = CodigoPrestacionProgramada
               ,@idTipoDeDestino = TipoDeDestinoPrestacionProgramada
        FROM    dbo.Sistemas
        DECLARE @prestaciones TABLE
            (
             Agendada DATETIME
            ,Observaciones VARCHAR(MAX)
            )
        DECLARE @idoc INT
        EXEC sp_xml_preparedocument @idoc OUTPUT, @prestacionesString
        INSERT  @prestaciones
                ( 
                 Agendada
                ,Observaciones 
                )
                SELECT  *
                FROM    OPENXML (@idoc, '/dsTablaPrestaciones/tblPrestaciones',2) WITH ( Agendada DATETIME, Observaciones VARCHAR(MAX))
        EXEC sp_xml_removedocument @idoc
        DECLARE @PrestacionesIngresadas TABLE ( IdPrestación INT )
        DECLARE @PrimerosDestinosIngresados TABLE ( IdDestino INT )
        DECLARE @SegundosDestinosIngresados TABLE ( IdDestino INT )
        DECLARE @TercerosDestinosIngresados TABLE ( IdDestino INT )
        INSERT  dbo.Prestaciones
                ( 
                 Numero
                ,Tomada
                ,Agendada
                ,Terminada
                ,Telefono
                ,idCodigo
                ,idTomador
                ,ObservacionesTomador
                )
        OUTPUT  INSERTED.idPrestacion
                INTO @PrestacionesIngresadas
                SELECT  CONVERT	(VARCHAR(15), ( SELECT  UltimoNumeroDePrestacion
                                                    FROM    dbo.Parametros
                                                  ) + Row_Number() OVER ( ORDER BY prest.agendada ))
                       ,@fechaYHora
                       ,Agendada
                       ,0
                       ,@telefono
                       ,@idCodigo
                       ,@idTomador
                       ,Observaciones
                FROM    @prestaciones prest

        INSERT  dbo.Destinos
                ( 
                 idPrestacion
                ,idTipoDeDestino
                ,Orden 
                )
        OUTPUT  INSERTED.idDestino
                INTO @PrimerosDestinosIngresados
                SELECT  idPrestacion
                       ,@idTipoDeDestino
                       ,1
                FROM    @PrestacionesIngresadas
        INSERT  dbo.Direcciones
                ( 
                 idLocalidad
                ,idCalle
                ,Numero
                ,Piso
                ,Departamento
                ,idEntreCalle1
                ,idEntreCalle2
                ,Observaciones
                ,idDestino
                ,idBarrio
                )
                SELECT  CASE WHEN @idLocalidad_1 = 0 THEN NULL
                             ELSE @idLocalidad_1
                        END
                       ,CASE WHEN @idCalle_1 = 0 THEN NULL
                             ELSE @idCalle_1
                        END
                       ,@Numero_1
                       ,@Piso_1
                       ,@Departamento_1
                       ,CASE WHEN @idEntreCalle1_1 = 0 THEN NULL
                             ELSE @idEntreCalle1_1
                        END
                       ,CASE WHEN @idEntreCalle2_1 = 0 THEN NULL
                             ELSE @idEntreCalle2_1
                        END
                       ,@ObservacionesDireccion_1
                       ,idDestino
                       ,CASE WHEN @idBarrio_1 = 0 THEN NULL
                             ELSE @idBarrio_1
                        END
                FROM    @PrimerosDestinosIngresados
        IF @HaySegundaDirección = 1 
            BEGIN
                INSERT  dbo.Destinos
                        ( 
                         idPrestacion
                        ,idTipoDeDestino
                        ,Orden 
                        )
                OUTPUT  INSERTED.idDestino
                        INTO @SegundosDestinosIngresados
                        SELECT  idPrestacion
                               ,@idTipoDeDestino
                               ,2
                        FROM    @PrestacionesIngresadas
                INSERT  dbo.Direcciones
                        ( 
                         idLocalidad
                        ,idCalle
                        ,Numero
                        ,Piso
                        ,Departamento
                        ,idEntreCalle1
                        ,idEntreCalle2
                        ,Observaciones
                        ,idDestino
                        ,idBarrio
                        )
                        SELECT  CASE WHEN @idLocalidad_2 = 0 THEN NULL
                                     ELSE @idLocalidad_2
                                END
                               ,CASE WHEN @idCalle_2 = 0 THEN NULL
                                     ELSE @idCalle_2
                                END
                               ,@Numero_2
                               ,@Piso_2
                               ,@Departamento_2
                               ,CASE WHEN @idEntreCalle1_2 = 0 THEN NULL
                                     ELSE @idEntreCalle1_2
                                END
                               ,CASE WHEN @idEntreCalle2_2 = 0 THEN NULL
                                     ELSE @idEntreCalle2_2
                                END
                               ,@ObservacionesDireccion_2
                               ,idDestino
                               ,CASE WHEN @idBarrio_2 = 0 THEN NULL
                                     ELSE @idBarrio_2
                                END
                        FROM    @SegundosDestinosIngresados
            END
        IF @EsperaYRetorno = 1 
            BEGIN
                INSERT  dbo.Destinos
                        ( 
                         idPrestacion
                        ,idTipoDeDestino
                        ,Orden 
                        )
                OUTPUT  INSERTED.idDestino
                        INTO @TercerosDestinosIngresados
                        SELECT  idPrestacion
                               ,@idTipoDeDestino
                               ,3
                        FROM    @PrestacionesIngresadas
                INSERT  dbo.Direcciones
                        ( 
                         idLocalidad
                        ,idCalle
                        ,Numero
                        ,Piso
                        ,Departamento
                        ,idEntreCalle1
                        ,idEntreCalle2
                        ,Observaciones
                        ,idDestino
                        ,idBarrio
                        )
                        SELECT  CASE WHEN @idLocalidad_1 = 0 THEN NULL
                                     ELSE @idLocalidad_1
                                END
                               ,CASE WHEN @idCalle_1 = 0 THEN NULL
                                     ELSE @idCalle_1
                                END
                               ,@Numero_1
                               ,@Piso_1
                               ,@Departamento_1
                               ,CASE WHEN @idEntreCalle1_1 = 0 THEN NULL
                                     ELSE @idEntreCalle1_1
                                END
                               ,CASE WHEN @idEntreCalle2_1 = 0 THEN NULL
                                     ELSE @idEntreCalle2_1
                                END
                               ,@ObservacionesDireccion_1
                               ,idDestino
                               ,CASE WHEN @idBarrio_1 = 0 THEN NULL
                                     ELSE @idBarrio_1
                                END
                        FROM    @TercerosDestinosIngresados
            END
        INSERT  dbo.Pacientes
                ( 
                 idPrestacion
                ,idAfiliado
                ,Nombre
                ,idTipoDeDocumento
                ,NumeroDeDocumento
                ,Edad
                ,EdadEn
                ,Sexo
                ,idCobertura
                ,idPractica
                ,idContrato
                ,idPrepago
                ,NroAfiliadoPrepago
                ,Importe
                ,Antecedentes
                ,ExtraCobertura
                ,CopagoSugerido
                )
                SELECT  idPrestacion
                       ,CASE WHEN @idAfiliado = 0 THEN NULL
                             ELSE @idAfiliado
                        END
                       ,@ApelNomb
                       ,@idTipoDeDocumento
                       ,@NumeroDeDocumento
                       ,@Edad
                       ,@EdadEn
                       ,@Sexo
                       ,@idCobertura
                       ,@idPractica
                       ,CASE WHEN @idContrato = 0 THEN NULL
                             ELSE @idContrato
                        END
                       ,CASE WHEN @idPrepago = 0 THEN NULL
                             ELSE @idPrepago
                        END
                       ,@NumeroPrepago
                       ,CASE WHEN @importe = 0 THEN NULL
                             ELSE @importe
                        END
                       ,@Antecedentes
                       ,@extraCobertura
                       ,@copagoSugerido
                FROM    @PrestacionesIngresadas presting
        UPDATE  dbo.Parametros
        SET     UltimoNumeroDePrestacion = UltimoNumeroDePrestacion + ( SELECT  COUNT(*)
                                                                        FROM    @prestaciones
                                                                      )
        COMMIT TRANSACTION	
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        RETURN 0
    END CATCH
    RETURN 1

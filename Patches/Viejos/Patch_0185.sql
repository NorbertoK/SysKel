USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[AgregarPrestacion]    Script Date: 10/28/2013 14:37:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[AgregarPrestacion]
    (
     @fechaYHora VARCHAR(17)
    ,@telefono VARCHAR(50)
    ,@idLocalidad INT
    ,@idCalle INT
    ,@Numero VARCHAR(100)
    ,@Piso VARCHAR(20)
    ,@Departamento VARCHAR(20)
    ,@idEntreCalle1 INT
    ,@idEntreCalle2 INT
    ,@ObservacionesDireccion VARCHAR(MAX)
    ,@idBarrio INT
    ,@idTipoDeDestino INT
    ,@idMotivoDeLlamado1 INT
    ,@ObservacionesMotivo1 VARCHAR(100)
    ,@idMotivoDeLlamado2 INT
    ,@ObservacionesMotivo2 VARCHAR(100)
    ,@idMotivoDeLlamado3 INT
    ,@ObservacionesMotivo3 VARCHAR(100)
    ,@idMotivoDeLlamado4 INT
    ,@ObservacionesMotivo4 VARCHAR(100)
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
    ,@idCodigo INT
    ,@idCobertura INT
    ,@idPractica INT
    ,@ObservacionesPrestacion VARCHAR(MAX)
    ,@idContrato INT
    ,@idTomador INT
    ,@terminada BIT
    ,@idMotivoDeCancelacion INT
    ,@incidenteExterno VARCHAR(50)
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
    IF @idMotivoDeCancelacion = 0 
        SET @idMotivoDeCancelacion = NULL
    IF @idTipoDeDestino = 0 
        SET @idTipoDeDestino = NULL
    IF @idCodigo = 0 
        SET @idCodigo = NULL
    IF @idCobertura = 0 
        SET @idCobertura = NULL
    IF @idPractica = 0 
        SET @idPractica = NULL
    BEGIN TRANSACTION
    BEGIN TRY
        SELECT TOP 1
                @numeroDePrestacion = UltimoNumeroDePrestacion + 1
        FROM    dbo.Parametros
        SET @numeroDePrestacionChar = CAST(@numeroDePrestacion AS VARCHAR(15))
        UPDATE  dbo.Parametros
        SET     UltimoNumeroDePrestacion = @numeroDePrestacion
        INSERT  dbo.Prestaciones
                ( 
                 Numero
                ,Tomada
                ,Terminada
                ,Telefono
                ,idCodigo
                ,idTomador
                ,idMotivoDeCancelacion
						
                )
        VALUES  ( 
                 @numeroDePrestacionChar
                ,@fechaYHora
                ,@terminada
                ,@telefono
                ,@idCodigo
                ,@idTomador
                ,@idMotivoDeCancelacion
                )
        SET @idPrestacion = SCOPE_IDENTITY()

        INSERT  dbo.Destinos
                ( idPrestacion, idTipoDeDestino )
        VALUES  ( @idPrestacion, @idTipoDeDestino )
        SET @idDestino = SCOPE_IDENTITY()

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
        VALUES  ( 
                 CASE WHEN @idLocalidad = 0 THEN NULL
                      ELSE @idLocalidad
                 END
                ,CASE WHEN @idCalle = 0 THEN NULL
                      ELSE @idCalle
                 END
                ,@Numero
                ,@Piso
                ,@Departamento
                ,CASE WHEN @idEntreCalle1 = 0 THEN NULL
                      ELSE @idEntreCalle1
                 END
                ,CASE WHEN @idEntreCalle2 = 0 THEN NULL
                      ELSE @idEntreCalle2
                 END
                ,@ObservacionesDireccion
                ,@idDestino
                ,CASE WHEN @idBarrio = 0 THEN NULL
                      ELSE @idBarrio
                 END
                )

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
                ,IncidenteExterno
                ,ExtraCobertura
                ,CopagoSugerido
                )
        VALUES  ( 
                 @idPrestacion
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
                ,@incidenteExterno
                ,@extraCobertura
                ,@copagoSugerido
                )
        SET @idPaciente = SCOPE_IDENTITY()

        IF @idMotivoDeLlamado1 <> 0
            OR @ObservacionesMotivo1 <> '' 
            BEGIN
                INSERT  dbo.MotivosPacientes
                        ( 
                         idPaciente
                        ,idMotivoDeLlamado
                        ,Observaciones
                                
                        )
                VALUES  ( 
                         @idPaciente
                        ,CASE WHEN @idMotivoDeLlamado1 = 0 THEN NULL
                              ELSE @idMotivoDeLlamado1
                         END
                        ,CASE WHEN @ObservacionesMotivo1 = '' THEN NULL
                              ELSE @ObservacionesMotivo1
                         END
                        )
            END

        IF @idMotivoDeLlamado2 <> 0
            OR @ObservacionesMotivo2 <> '' 
            BEGIN
                INSERT  dbo.MotivosPacientes
                        ( 
                         idPaciente
                        ,idMotivoDeLlamado
                        ,Observaciones
                                
                        )
                VALUES  ( 
                         @idPaciente
                        ,CASE WHEN @idMotivoDeLlamado2 = 0 THEN NULL
                              ELSE @idMotivoDeLlamado2
                         END
                        ,CASE WHEN @ObservacionesMotivo2 = '' THEN NULL
                              ELSE @ObservacionesMotivo2
                         END
                        )
            END

        IF @idMotivoDeLlamado3 <> 0
            OR @ObservacionesMotivo3 <> '' 
            BEGIN
                INSERT  dbo.MotivosPacientes
                        ( 
                         idPaciente
                        ,idMotivoDeLlamado
                        ,Observaciones
                                
                        )
                VALUES  ( 
                         @idPaciente
                        ,CASE WHEN @idMotivoDeLlamado3 = 0 THEN NULL
                              ELSE @idMotivoDeLlamado3
                         END
                        ,CASE WHEN @ObservacionesMotivo3 = '' THEN NULL
                              ELSE @ObservacionesMotivo3
                         END
                        )
            END

        IF @idMotivoDeLlamado4 <> 0
            OR @ObservacionesMotivo4 <> '' 
            BEGIN
                INSERT  dbo.MotivosPacientes
                        ( 
                         idPaciente
                        ,idMotivoDeLlamado
                        ,Observaciones
                                
                        )
                VALUES  ( 
                         @idPaciente
                        ,CASE WHEN @idMotivoDeLlamado4 = 0 THEN NULL
                              ELSE @idMotivoDeLlamado4
                         END
                        ,CASE WHEN @ObservacionesMotivo4 = '' THEN NULL
                              ELSE @ObservacionesMotivo4
                         END
                        )
            END	
        COMMIT TRANSACTION	
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        RETURN 0
    END CATCH
    UPDATE  dbo.Pacientes
    SET     MotivosDeLlamado = dbo.MotivosDelPaciente(@idPaciente)
    WHERE   idPaciente = @idPaciente
    RETURN 1

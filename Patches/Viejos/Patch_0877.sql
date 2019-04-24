USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[SeleccionDePrestaciones]    Script Date: 02/22/2018 20:07:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[SeleccionDePrestaciones]
    (
      @proceso VARCHAR(255) OUTPUT ,
      @desde VARCHAR(8) ,
      @hasta VARCHAR(8) ,
      @desdeHora VARCHAR(5) ,
      @hastaHora VARCHAR(5) ,
      @verCanceladas INT ,
      @nroPrestacion VARCHAR(20) ,
      @idCobertura INT ,
      @idTipoDeDestino INT ,
      @idRubro INT ,
      @idCodigo INT ,
      @idCliente INT ,
      @idContrato INT ,
      @idEntidadDeCobranza INT ,
      @paciente VARCHAR(100) ,
      @hC VARCHAR(20) ,
      @idLocalidad INT ,
      @idCalle INT ,
      @telefono VARCHAR(20) ,
      @idMovil INT ,
      @tiempoDeLlegada INT ,
      @idMedico INT ,
      @idParamedico INT ,
      @idChofer INT ,
      @idMotivo INT ,
      @idDiagnostico INT ,
      @idMedicamento INT ,
      @internacion INT ,
      @idLugar INT ,
      @idTomador INT ,
      @idDespachador INT ,
      @cuentaPacientes INT
    )
AS 
    SET NOCOUNT ON;
    DECLARE @sql NVARCHAR(MAX)
    DECLARE @parametros NVARCHAR(MAX)
    SET @proceso = CONVERT(VARCHAR(255), NEWID())
    SET @sql = 'SELECT '
    IF @cuentaPacientes = 0 
        SET @sql = @sql + 'DISTINCT '
    SET @sql = @sql
        + '@proceso, prest.idPrestacion FROM dbo.Prestaciones prest LEFT JOIN dbo.Codigos ON prest.idCodigo = Codigos.idCodigo '
    IF @cuentaPacientes = 1 
        SET @sql = @sql
            + 'JOIN dbo.Pacientes pac on prest.idPrestacion = pac.idPrestacion '
    SET @sql = @sql
        + 'WHERE  CASE WHEN prest.Agendada IS NULL THEN prest.Tomada ELSE prest.Agendada END >= @desde AND CASE WHEN prest.Agendada IS NULL THEN prest.Tomada ELSE prest.Agendada END < dateadd(dd,1,@hasta)'
    IF @desdeHora != @hastaHora 
        BEGIN
            IF @hastaHora > @desdeHora 
                SET @sql = @sql
                    + ' AND CASE WHEN prest.Agendada IS NULL THEN CONVERT(TIME, prest.Tomada) ELSE CONVERT(TIME, prest.Agendada) END >= @desdeHora AND CASE WHEN prest.Agendada IS NULL THEN CONVERT(TIME, prest.Tomada) ELSE CONVERT(TIME, prest.Agendada) END < @hastaHora'
            ELSE 
                SET @sql = @sql
                    + ' AND (((CASE WHEN prest.Agendada IS NULL THEN CONVERT(TIME, prest.Tomada) ELSE CONVERT(TIME, prest.Agendada) END >= @desdeHora AND CASE WHEN prest.Agendada IS NULL THEN CONVERT(TIME, prest.Tomada) ELSE CONVERT(TIME, prest.Agendada) END <= ''23:59:59.9999999'')) OR ((CASE WHEN prest.Agendada IS NULL THEN CONVERT(TIME, prest.Tomada) ELSE CONVERT(TIME, prest.Agendada) END >= ''00:00'' AND CASE WHEN prest.Agendada IS NULL THEN CONVERT(TIME, prest.Tomada) ELSE CONVERT(TIME, prest.Agendada) END < @hastaHora)))'
        END    
    IF @verCanceladas = 0 
        SET @sql = @sql + ' AND prest.idMotivoDeCancelacion is null'
    IF @verCanceladas = 2 
        SET @sql = @sql + ' AND prest.idMotivoDeCancelacion is not null'    
    IF @nroPrestacion <> '' 
        SET @sql = @sql + ' AND prest.Numero = @nroPrestacion'
    IF @idCobertura > 0 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Pacientes WHERE idPrestacion = prest.idPrestacion AND idCobertura = @idCobertura)'
    IF @idCliente > 0 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Pacientes pac JOIN dbo.Contratos cto ON cto.idContrato = pac.idContrato WHERE pac.idPrestacion = prest.idPrestacion AND cto.idCliente = @idCliente)'
    IF @idContrato > 0 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Pacientes WHERE idPrestacion = prest.idPrestacion AND idContrato = @idContrato)'
    IF @idTipoDeDestino > 0 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Pacientes WHERE idPrestacion = prest.idPrestacion AND idContrato = @idContrato)'    
    IF @idRubro > 0 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Pacientes pac JOIN dbo.Contratos cto ON cto.idContrato = pac.idContrato JOIN dbo.Clientes cli on cli.idCliente = cto.idCliente WHERE pac.idPrestacion = prest.idPrestacion AND cli.idTipoDeCliente = @idRubro)'
    IF @idCodigo > 0 
        SET @sql = @sql + ' AND prest.idCodigo = @idCodigo'
    IF @idEntidadDeCobranza > 0 
        SET @sql = @sql
            + ' AND (EXISTS (SELECT * FROM dbo.Pacientes pac JOIN dbo.Contratos cto ON cto.idContrato = pac.idContrato JOIN dbo.Clientes cli on cli.idCliente = cto.idCliente WHERE pac.idPrestacion = prest.idPrestacion AND cli.idEntidadDeCobranza = @idEntidadDeCobranza) OR EXISTS (SELECT * FROM dbo.Pacientes pac JOIN dbo.Afiliados af ON af.idAfiliado = pac.idAfiliado JOIN dbo.Grupos g on g.idGrupo = af.idGrupo WHERE pac.idPrestacion = prest.idPrestacion AND g.idEntidadDeCobranza = @idEntidadDeCobranza))'
    IF @paciente <> '' 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Pacientes pac WHERE pac.idPrestacion = prest.idPrestacion AND pac.Nombre = @paciente)'
    IF @hC <> '' 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Pacientes pac WHERE pac.idPrestacion = prest.idPrestacion AND pac.HC = @HC)'
    IF @idLocalidad > 0 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Direcciones WHERE idDestino = prest.PrimerDestino AND idLocalidad = @idLocalidad)'
    IF @idCalle > 0 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Destinos dest WHERE dest.idDestino = prest.PrimerDestino AND dest.idTipoDeDestino = @idTipoDeDestino)'
    IF @telefono <> '' 
        BEGIN
            SET @telefono = dbo.SoloNumeros(@telefono)
            SET @sql = @sql + ' AND prest.Telefono = @telefono'
        END
    IF @idMovil > 0 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Destinos d JOIN dbo.DestinosRecursos dr ON dr.idDestino = d.idDestino WHERE d.idPrestacion = prest.idPrestacion AND dr.idMovil = @idMovil)'
    IF @tiempoDeLlegada = 1 
        SET @sql = @sql + ' AND prest.EnTiempo = 1'
    IF @tiempoDeLlegada = 2 
        SET @sql = @sql + ' AND prest.EnTiempo = 0'
    IF @idMedico > 0 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Destinos d JOIN dbo.DestinosRecursos dr ON dr.idDestino = d.idDestino WHERE d.idPrestacion = prest.idPrestacion AND (dr.idMedico1 = @idMedico OR dr.idMedico2 = @idMedico))'
    IF @idParamedico > 0 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Destinos d JOIN dbo.DestinosRecursos dr ON dr.idDestino = d.idDestino WHERE d.idPrestacion = prest.idPrestacion AND (dr.idParamedico1 = @idParamedico OR dr.idParamedico2 = @idParamedico))'
    IF @idChofer > 0 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Destinos d JOIN dbo.DestinosRecursos dr ON dr.idDestino = d.idDestino WHERE d.idPrestacion = prest.idPrestacion AND (dr.idChofer1 = @idChofer OR dr.idChofer2 = @idChofer))'
    IF @idMotivo > 0 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Pacientes pac JOIN dbo.MotivosPacientes mot ON mot.idPaciente = pac.idPaciente WHERE pac.idPrestacion = prest.idPrestacion AND mot.idMotivoDeLlamado = @idMotivo)'
    IF @idDiagnostico > 0 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Pacientes pac JOIN dbo.DiagnosticosPacientes diag ON diag.idPaciente = pac.idPaciente WHERE pac.idPrestacion = prest.idPrestacion AND diag.idDiagnostico = @idDiagnostico)'
    IF @idMedicamento > 0 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Pacientes pac JOIN dbo.MedicamentosPacientes med ON med.idPaciente = pac.idPaciente WHERE pac.idPrestacion = prest.idPrestacion AND med.idMedicamento = @idMedicamento)'
    IF @internacion = 1 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Destinos dest WHERE dest.idPrestacion = prest.idPrestacion AND dest.idTipoDeDestino = (SELECT TOP 1 Internacion FROM dbo.Sistemas))'
    IF @internacion = 2 
        SET @sql = @sql
            + ' AND NOT EXISTS (SELECT * FROM dbo.Destinos dest WHERE dest.idPrestacion = prest.idPrestacion AND dest.idTipoDeDestino = (SELECT TOP 1 Internacion FROM dbo.Sistemas))'
    IF @idLugar > 0 
        SET @sql = @sql
            + ' AND NOT EXISTS (SELECT * FROM dbo.Destinos dest WHERE dest.idPrestacion = prest.idPrestacion AND dest.idTipoDeDestino = (SELECT TOP 1 Internacion FROM dbo.Sistemas) AND dest.idLugar = @idLugar)'
    IF @idTomador > 0 
        SET @sql = @sql + ' AND prest.idTomador = @idTomador'
    IF @idDespachador > 0 
        SET @sql = @sql
            + ' AND EXISTS (SELECT * FROM dbo.Destinos d JOIN dbo.DestinosRecursos dr ON dr.idDestino = d.idDestino WHERE d.idPrestacion = prest.idPrestacion AND dr.idDespachador = @idDespachador)'
    SET @parametros = ' @proceso VarChar(255),
					  @desde VARCHAR(8) ,
					  @hasta VARCHAR(8) ,
					  @desdeHora VARCHAR(5) ,
					  @hastaHora VARCHAR(5) ,
					  @verCanceladas INT ,
					  @nroPrestacion VARCHAR(20) ,
					  @idCobertura INT ,
					  @idTipoDeDestino INT ,
					  @idRubro INT ,
					  @idCodigo INT ,
					  @idCliente INT ,
					  @idContrato INT ,
					  @idEntidadDeCobranza INT ,
					  @paciente VARCHAR(100) ,
					  @hC VARCHAR(20) ,
					  @idLocalidad INT ,
					  @idCalle INT ,
					  @telefono VARCHAR(20) ,
					  @idMovil INT ,
					  @tiempoDeLlegada INT ,
					  @idMedico INT ,
					  @idParamedico INT ,
					  @idChofer INT ,
					  @idMotivo INT ,
					  @idDiagnostico INT ,
					  @idMedicamento INT ,
					  @internacion INT ,
					  @idLugar INT ,
					  @idTomador INT ,
					  @idDespachador INT ,
					  @cuentaPacientes INT'
    INSERT  dbo.Ids
            ( Proceso ,
              Id 
            )
            EXEC sp_executesql @sql, @parametros, @proceso, @desde, @hasta,
                @desdeHora, @hastaHora, @verCanceladas, @nroPrestacion,
                @idCobertura, @idTipoDeDestino, @idRubro, @idCodigo,
                @idCliente, @idContrato, @idEntidadDeCobranza, @paciente, @hC,
                @idLocalidad, @idCalle, @telefono, @idMovil, @tiempoDeLlegada,
                @idMedico, @idParamedico, @idChofer, @idMotivo, @idDiagnostico,
                @idMedicamento, @internacion, @idLugar, @idTomador,
                @idDespachador, @cuentaPacientes



USE [Datos]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[AgregarPrestacion]
		@fechaYHora = N'20150820 21:09:59',
		@telefono = N'4243647',
		@idLocalidad = 1,
		@idCalle = 0,
		@numero = '',
		@piso = '',
		@departamento = '',
		@idEntreCalle1 = 0,
		@idEntreCalle2 = 0,
		@ObservacionesDireccion = N'Pje El Tala 176 ',
		@idBarrio = 0,
		@idTipoDeDestino = 1,
		@idMotivoDeLlamado1 = 77,
		@observacionesMotivo1 = '',
		@idMotivoDeLlamado2 = 0,
		@observacionesMotivo2 = '',
		@idMotivoDeLlamado3 = 0,
		@observacionesMotivo3 = '',
		@idMotivoDeLlamado4 = 0,
		@observacionesMotivo4 = '',
		@idAfiliado = 10971,
		@ApelNomb = N'Farias Gomez , Luciano',
		@idTipoDeDocumento = 0,
		@NumeroDeDocumento = N'46323787',
		@Edad = 10,
		@EdadEn = N'A',
		@Sexo = N'M',
		@idPrepago = 0,
		@NumeroPrepago = N'10163440/4',
		@importe = 0,
		@antecedentes = '',
		@idCodigo = 2,
		@idCobertura = 9,
		@idPractica = 1,
		@observacionesPrestacion = '',
		@idContrato = 234,
		@idTomador = 5,
		@terminada = 0,
		@idMotivoDeCancelacion = 0,
		@incidenteExterno = '',
		@extraCobertura = 0,
		@copagoSugerido = 0

SELECT	'Return Value' = @return_value

GO

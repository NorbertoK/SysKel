USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[FechaEgresoCaja]    Script Date: 03/18/2013 22:23:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[FechaEgresoCaja] 
(
	@idValorRemesa int
)
RETURNS DateTime
AS
BEGIN
	DECLARE @Result DateTime
	DECLARE @EntregadoIdTransferencia int
	DECLARE @EntregadoIdRetiro int
	DECLARE @IdPagoEfectivo int
	SELECT	@EntregadoIdTransferencia = EntregadoIdTransferencia,
			@EntregadoIdRetiro = EntregadoIdRetiro,
			@IdPagoEfectivo = IdPagoEfectivo
	FROM dbo.ValoresRemesas
	WHERE idValorRemesa = @idValorRemesa
	SELECT @Result = 
		CASE
			WHEN @EntregadoIdTransferencia is null THEN 
				CASE
					WHEN @EntregadoIdRetiro is null THEN 
						CASE
							WHEN @IdPagoEfectivo is null THEN 
								null
							ELSE (SELECT Fecha FROM dbo.Compras WHERE idCompra = @idPagoEfectivo) 
						END 
					ELSE (SELECT Fecha FROM dbo.Retiros WHERE idRetiro = @EntregadoIdRetiro)
				END
			ELSE (SELECT Fecha FROM dbo.Transferencias WHERE idTransferencia = @EntregadoIdTransferencia)
		END
	RETURN @Result
END


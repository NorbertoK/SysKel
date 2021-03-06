USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[FechaEgresoCaja]    Script Date: 04/03/2016 19:46:11 ******/
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
	DECLARE @EntregadoIdPago int
	SELECT	@EntregadoIdTransferencia = EntregadoIdTransferencia,
			@EntregadoIdRetiro = EntregadoIdRetiro,
			@EntregadoIdPago = EntregadoIdPago
	FROM dbo.ValoresRemesas
	WHERE idValorRemesa = @idValorRemesa
	SELECT @Result = 
		CASE
			WHEN @EntregadoIdTransferencia is null THEN 
				CASE
					WHEN @EntregadoIdRetiro is null THEN 
						CASE
							WHEN @EntregadoIdPago is null THEN 
								null
							ELSE (SELECT Fecha FROM dbo.Pagos WHERE idPago = @EntregadoIdPago) 
						END 
					ELSE (SELECT Fecha FROM dbo.Retiros WHERE idRetiro = @EntregadoIdRetiro)
				END
			ELSE (SELECT Fecha FROM dbo.Transferencias WHERE idTransferencia = @EntregadoIdTransferencia)
		END
	RETURN @Result
END


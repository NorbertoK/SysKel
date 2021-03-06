USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[FechaEgresoCaja]    Script Date: 02/04/2017 20:44:00 ******/
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
	DECLARE @EntregadoIdOrdenDePago int
	SELECT	@EntregadoIdTransferencia = EntregadoIdTransferencia,
			@EntregadoIdRetiro = EntregadoIdRetiro,
			@EntregadoIdOrdenDePago = EntregadoIdOrdenDePago
	FROM dbo.ValoresRemesas
	WHERE idValorRemesa = @idValorRemesa
	SELECT @Result = 
		CASE
			WHEN @EntregadoIdTransferencia is null THEN 
				CASE
					WHEN @EntregadoIdRetiro is null THEN 
						CASE
							WHEN @EntregadoIdOrdenDePago is null THEN 
								null
							ELSE (SELECT Fecha FROM dbo.OrdenesDePago WHERE idOrdenDePago = @EntregadoIdOrdenDePago) 
						END 
					ELSE (SELECT Fecha FROM dbo.Retiros WHERE idRetiro = @EntregadoIdRetiro)
				END
			ELSE (SELECT Fecha FROM dbo.Transferencias WHERE idTransferencia = @EntregadoIdTransferencia)
		END
	RETURN @Result
END


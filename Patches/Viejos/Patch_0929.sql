USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[SaldoDelGrupo]    Script Date: 11/01/2018 13:15:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[SaldoDelGrupo] 
(
	@idGrupo int,
    @fecha datetime
)
RETURNS money
AS
BEGIN
	DECLARE @Result money
	SELECT @Result = sum(Importe*CASE WHEN tc.ImporteNegativo = 1 THEN -1 ELSE 1 END) 
    FROM dbo.Comprobantes comp
    JOIN dbo.TiposDeComprobante tc on tc.idTipoDeComprobante = comp.idTipoDeComprobante
    WHERE comp.idGrupo = @idGrupo AND comp.Fecha <= dbo.Medianoche(@fecha)
    AND ISNULL(Anulado,0) = 0
	RETURN @Result
END

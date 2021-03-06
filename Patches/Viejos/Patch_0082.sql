USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[SaldoComprobante]    Script Date: 04/02/2013 23:20:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		NK
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[SaldoCompra] 
(
	-- Add the parameters for the function here
	@idCompra int
)
RETURNS money
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result money

	-- Add the T-SQL statements to compute the return value here
	SELECT @Result = sum(comp.importe * CASE WHEN tip.ImporteNegativo='True' THEN -1 ELSE 1 END)
    FROM dbo.Compras comp
    JOIN dbo.TiposDeComprobante tip on tip.idTipoDeComprobante=comp.idTipoDeComprobante
    WHERE comp.idCompra=@idCompra or comp.idReferencia=@idCompra


	-- Return the result of the function
	RETURN @Result

END

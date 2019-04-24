USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[ImporteCompra]    Script Date: 05/10/2013 12:38:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[IdProveedorCompra] 
(
	-- Add the parameters for the function here
	@idCompra int
)
RETURNS INT
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result INT

	-- Add the T-SQL statements to compute the return value here
	SELECT @Result = idProveedor FROM dbo.Compras WHERE idCompra = @idCompra

	-- Return the result of the function
	RETURN @Result

END

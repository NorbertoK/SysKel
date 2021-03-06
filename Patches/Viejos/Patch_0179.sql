USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[ContratoDelPlan]    Script Date: 10/21/2013 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
ALTER FUNCTION [dbo].[ContratoDelPlan] 
(
	-- Add the parameters for the function here
	@idPlan int
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result int

	-- Add the T-SQL statements to compute the return value here
	SELECT @Result = idContrato FROM Planes WHERE idPlan =  @idPlan

	-- Return the result of the function
	RETURN ISNULL(@Result,0)

END

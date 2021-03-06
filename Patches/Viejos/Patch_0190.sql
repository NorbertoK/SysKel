USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[HayAlgunAfiliadoActivo]    Script Date: 10/29/2013 22:04:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		NK
-- Create date: 
-- Description:	
-- =============================================
ALTER FUNCTION [dbo].[HayAlgunAfiliadoActivo]
    (
     -- Add the parameters for the function here
     @idGrupo INT
    ,@fecha SMALLDATETIME
    )
RETURNS INT
AS 
    BEGIN

	-- Add the T-SQL statements to compute the return value here
        DECLARE @Result INT
        IF ( SELECT SUM(dbo.AfiliadoActivoCualquierPlanPropio(af.idAfiliado, GETDATE()))
             FROM   dbo.Afiliados af
             WHERE  af.idGrupo = @idGrupo
           ) = 0 
            SET @Result = 0
        ELSE 
            SET @Result = 1
        RETURN @Result
    END




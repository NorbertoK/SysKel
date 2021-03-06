USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[Redondeo]    Script Date: 07/20/2016 17:48:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[Redondeo] ( @Val DECIMAL(32, 16), @decimales INT )
RETURNS DECIMAL(32, 16)
AS 
    BEGIN
        RETURN CASE WHEN ABS(@Val - ROUND(@Val, @decimales, 1)) * POWER(10, 2+1) = 5
                THEN ROUND(@Val, @decimales, 1)
                ELSE ROUND(@Val, @decimales)
                END
    END
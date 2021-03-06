USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[UltimoDiaHabilDelMes]    Script Date: 11/14/2014 18:58:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[UltimoDiaHabilDelMes] ( @fecha DATE )
RETURNS DATE
AS 
    BEGIN
        DECLARE @Result DATE
        SET @Result = DATEADD(DD, -1, DATEADD(M, 1, DATEADD(m, DATEDIFF(m, 0, @fecha), 0)))
        WHILE DATEPART(dw, @Result) IN ( 1, 7 )
            OR EXISTS ( SELECT  *
                        FROM    dbo.Feriados
                        WHERE   Fecha = @Result ) 
            BEGIN
                SET @Result = DATEADD(dd, -1, @Result)
            END

        RETURN @Result

    END

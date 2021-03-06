USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[PrimerDiaHabil]    Script Date: 11/14/2014 19:01:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[PrimerDiaHabil] ( @fecha DATE )
RETURNS DATE
AS 
    BEGIN
        DECLARE @Result DATE= CONVERT(DATE, @fecha)
        WHILE DATEPART(dw, @Result) IN ( 1, 7 )
            OR EXISTS ( SELECT  *
                        FROM    dbo.Feriados
                        WHERE   Fecha = @Result ) 
            BEGIN
                SET @Result = DATEADD(dd, 1, @Result)
            END

        RETURN @Result

    END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION PrimerDiaHabil ( @fecha VARCHAR(8) )
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
GO


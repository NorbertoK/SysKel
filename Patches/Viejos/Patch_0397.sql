SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION UltimoDiaHabilDelMes ( @fecha VARCHAR(8) )
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
GO


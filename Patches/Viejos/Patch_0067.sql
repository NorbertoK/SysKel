SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
SET DATEFIRST 7
GO
CREATE FUNCTION DiaDeLaSemana ( @fecha DATE )
RETURNS VARCHAR(10)
AS 
    BEGIN
    
        DECLARE @Result VARCHAR(10)
        SELECT  @Result = CASE DATEPART(dw, @fecha)
                            WHEN 2 THEN 'Lun'
                            WHEN 3 THEN 'Mar'
                            WHEN 4 THEN 'Mié'
                            WHEN 5 THEN 'Jue'
                            WHEN 6 THEN 'Vie'
                            WHEN 7 THEN 'Sáb'
                            WHEN 1 THEN 'Dom'
                          END 
        RETURN @Result

    END
GO


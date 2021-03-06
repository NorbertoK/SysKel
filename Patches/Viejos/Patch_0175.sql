USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[DiaDeLaSemana]    Script Date: 10/18/2013 23:38:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[DiaDeLaSemana] ( @fecha DATE )
RETURNS VARCHAR(10)
AS 
    BEGIN
        DECLARE @Result VARCHAR(10)
        SELECT  @Result = CASE @@DATEFIRST
                            WHEN 7 THEN CASE DATEPART(dw, @fecha)
                                          WHEN 2 THEN 'Lun'
                                          WHEN 3 THEN 'Mar'
                                          WHEN 4 THEN 'Mié'
                                          WHEN 5 THEN 'Jue'
                                          WHEN 6 THEN 'Vie'
                                          WHEN 7 THEN 'Sáb'
                                          WHEN 1 THEN 'Dom'
                                        END
                            WHEN 1 THEN CASE DATEPART(dw, @fecha)
                                          WHEN 1 THEN 'Lun'
                                          WHEN 2 THEN 'Mar'
                                          WHEN 3 THEN 'Mié'
                                          WHEN 4 THEN 'Jue'
                                          WHEN 5 THEN 'Vie'
                                          WHEN 6 THEN 'Sáb'
                                          WHEN 7 THEN 'Dom'
                                        END
                          END
                          
        RETURN @Result

    END

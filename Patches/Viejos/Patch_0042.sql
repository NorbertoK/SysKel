USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[MotivosDelPaciente]    Script Date: 12/02/2012 21:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Norberto Kelijman
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[MotivosDelTurno] 
(
	-- Add the parameters for the function here
	@idTurno int
)
RETURNS VarChar(MAX)
AS
BEGIN
	DECLARE @Result VarChar(MAX)
    DECLARE @cantMotivos int
    DECLARE @n int
    SET @n = 1

    DECLARE @tabla table (Renglon int identity(1,1), Motivo varchar(100),Observaciones varchar(MAX))
    INSERT  @tabla  SELECT m.Nombre, mo.Observaciones 
                    FROM dbo.MotivosPacientes mo
                    JOIN dbo.MotivosDeLlamado m ON m.idMotivoDeLlamado = mo.idMotivoDeLlamado 
                    WHERE mo.idTurno = @idTurno

    SELECT  @cantMotivos = Count(*)
    FROM    dbo.MotivosPacientes
    WHERE   idTurno = @idTurno

    WHILE @n <= @cantMotivos
    BEGIN
        IF @n = 1
            SELECT @Result = Motivo + CASE WHEN LEN(ISNULL(Observaciones,''))=0 THEN '' ELSE ' ('+Observaciones+')' END FROM @tabla WHERE Renglon = @n
        ELSE
            SELECT @Result = @Result + ' | ' + Motivo + CASE WHEN LEN(ISNULL(Observaciones,''))=0 THEN '' ELSE ' ('+Observaciones+')' END FROM @tabla WHERE Renglon = @n
        SET @n = @n + 1
    END

	RETURN @Result

END

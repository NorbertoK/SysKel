USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[DiagnosticosDelPaciente]    Script Date: 12/02/2012 21:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Norberto Kelijman
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[DiagnosticosDelTurno] 
(
	-- Add the parameters for the function here
	@idTurno int
)
RETURNS VarChar(MAX)
AS
BEGIN
	DECLARE @Result VarChar(MAX)
    DECLARE @cantDiag int
    DECLARE @n int
    SET @n = 1

    DECLARE @tabla table (Renglon int identity(1,1), Diagnostico varchar(100))
    INSERT  @tabla  SELECT d.Nombre
                    FROM dbo.DiagnosticosPacientes diag
                    JOIN dbo.Diagnosticos d ON d.idDiagnostico = diag.idDiagnostico 
                    WHERE diag.idTurno = @idTurno

    SELECT  @cantDiag = Count(*)
    FROM    dbo.DiagnosticosPacientes
    WHERE   idTurno = @idTurno

    WHILE @n <= @cantDiag
    BEGIN
        IF @n = 1
            SELECT @Result = Diagnostico FROM @tabla WHERE Renglon = @n
        ELSE
            SELECT @Result = @Result + ' | ' + Diagnostico FROM @tabla WHERE Renglon = @n
        SET @n = @n + 1
    END

	RETURN @Result

END

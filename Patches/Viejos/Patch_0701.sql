SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GuardarTokenYSign
    @token VARCHAR(MAX)
   ,@sign VARCHAR(MAX)
AS 
    BEGIN
        SET NOCOUNT ON;
        UPDATE  dbo.Parametros
        SET     Token = @token
               ,Sign = @sign
               ,VigenciaTokenSign = DATEADD(HOUR, 12, GETDATE())
    END
GO

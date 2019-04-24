USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[GuardarTokenYSign]    Script Date: 09/23/2016 13:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GuardarTokenYSign]
    @token VARCHAR(MAX)
   ,@sign VARCHAR(MAX)
AS 
    BEGIN
        SET NOCOUNT ON;
        UPDATE  dbo.Parametros
        SET     Token = @token
               ,Sign_ = @sign
               ,VigenciaTokenSign = DATEADD(HOUR, 12, GETDATE())
    END

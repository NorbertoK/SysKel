USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[GuardarCAE]    Script Date: 03/22/2017 15:28:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GuardarFacturaEnviada]
    @idComprobante INT = 0
AS 
    BEGIN
        SET NOCOUNT ON;
        UPDATE  dbo.Comprobantes
        SET     FacturaEnviada = GETDATE()
        WHERE   idComprobante = @idComprobante
    END

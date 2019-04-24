USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[GuardarCAE]    Script Date: 10/30/2016 16:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GuardarCAE]
    @idComprobante INT = 0
   ,@CAE VARCHAR(14) = 0
   ,@VencimientoCAE VARCHAR(8) = 0
AS 
    BEGIN
        SET NOCOUNT ON;
        UPDATE  dbo.Comprobantes
        SET     CAE = @CAE
               ,VencimientoCAE = @VencimientoCAE
        WHERE   idComprobante = @idComprobante
    END

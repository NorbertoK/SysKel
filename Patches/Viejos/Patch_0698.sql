SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GuardarCAE
    @idComprobante INT = 0
   ,@CAE VARCHAR(14) = 0
AS 
    BEGIN
        SET NOCOUNT ON;
        UPDATE  dbo.Comprobantes
        SET     CAE = @CAE
        WHERE   idComprobante = @idComprobante
    END
GO

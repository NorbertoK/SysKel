SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION TotalIVA ( @idComprobante INT )
RETURNS MONEY
AS 
    BEGIN

        DECLARE @Result MONEY

        SELECT  @Result = SUM(ISNULL(dbo.imp_IVA(dc.idDetalleComprobante), 0))
        FROM    dbo.Comprobantes comp
                JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
        WHERE   comp.idComprobante = @idComprobante
        RETURN @Result

    END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION TotalNoGravado ( @idComprobante INT )
RETURNS MONEY
AS 
    BEGIN

        DECLARE @Result MONEY

        SELECT  @Result = SUM(dbo.ImporteDelDetalleImpreso(dc.idDetalleComprobante))
        FROM    dbo.Comprobantes comp
                JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
        WHERE   comp.idComprobante = @idComprobante
                AND dc.idPorcentajeIVA = 1
        RETURN @Result

    END
GO


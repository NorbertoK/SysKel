
/****** Object:  UserDefinedFunction [dbo].[PrecioUnitarioImpreso]    Script Date: 10/04/2016 12:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER FUNCTION [dbo].[PrecioUnitarioImpreso]
    (
     @idDetalleComprobante INT
    )
RETURNS MONEY
AS 
    BEGIN
        DECLARE @Result MONEY

        SELECT  @Result = dbo.Redondeo(ISNULL(PrecioUnitario,
                                              dc.Importe / ISNULL(dc.Cantidad,
                                                              1))
                                       / CASE WHEN tc.DiscriminaIVA = 1
                                              THEN ( 1 + pIVA.Porcentaje / 100 )
                                              ELSE 1
                                         END, 3)
        FROM    dbo.DetallesComprobantes dc
                JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
                JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
        WHERE   idDetalleComprobante = @idDetalleComprobante

        RETURN @Result

    END



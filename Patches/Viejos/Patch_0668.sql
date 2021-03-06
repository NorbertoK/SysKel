USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[ImporteDelDetalleImpreso]    Script Date: 07/29/2016 13:23:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER FUNCTION [dbo].[ImporteDelDetalleImpreso]
    (
     @idDetalleComprobante INT
    )
RETURNS MONEY
AS 
    BEGIN
        DECLARE @Result MONEY

        SELECT  @Result = CASE WHEN tc.Serie = 'A'
                               THEN dbo.Redondeo(dc.Importe / ( 1
                                                              + ISNULL(pIVA.Porcentaje,
                                                              0) / 100 ), 3)
                               ELSE dc.Importe
                          END
        FROM    dbo.DetallesComprobantes dc
                JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
                JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
        WHERE   idDetalleComprobante = @idDetalleComprobante

        RETURN @Result

    END



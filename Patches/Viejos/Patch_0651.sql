USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[PrecioUnitarioImpreso]    Script Date: 07/21/2016 10:41:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[imp_IVA]
    (
     @idDetalleComprobante INT
    )
RETURNS MONEY
AS 
    BEGIN
        DECLARE @Result MONEY

        SELECT  @Result = CASE WHEN tc.DiscriminaIVA = 1
                               THEN dbo.Redondeo(dbo.ImporteDetalleImpreso(@idDetalleComprobante)
                                                 * pIVA.Porcentaje / 100, 2)
                               ELSE NULL
                          END
        FROM    dbo.DetallesComprobantes dc
                JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
                JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
        WHERE   idDetalleComprobante = @idDetalleComprobante

        RETURN @Result

    END



USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[imp_IVA]    Script Date: 08/05/2016 11:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER FUNCTION [dbo].[imp_IVA]
    (
     @idDetalleComprobante INT
    )
RETURNS MONEY
AS 
    BEGIN
        DECLARE @Result MONEY

        SELECT  @Result = CASE WHEN tc.DiscriminaIVA = 1
                               THEN dbo.Redondeo(dbo.ImporteDelDetalleImpreso(@idDetalleComprobante)
                                                 * pIVA.Porcentaje / 100, 2)
                               ELSE dbo.Redondeo(( dbo.ImporteDelDetalleImpreso(@idDetalleComprobante)
                                                   / ( 1 + pIVA.Porcentaje
                                                       / 100 ) )
                                                 * pIVA.Porcentaje / 100, 2)
                          END
        FROM    dbo.DetallesComprobantes dc
                JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
                JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
        WHERE   idDetalleComprobante = @idDetalleComprobante

        RETURN @Result

    END



USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[imp_IVA]    Script Date: 08/26/2016 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[imp_Gravado]
    (
     @idDetalleComprobante INT
    )
RETURNS MONEY
AS 
    BEGIN
        DECLARE @Result MONEY

        SELECT  @Result = CASE WHEN tc.DiscriminaIVA = 1
                               THEN dbo.ImporteDelDetalleImpreso(@idDetalleComprobante)
                               ELSE dbo.Redondeo(dbo.ImporteDelDetalleImpreso(@idDetalleComprobante)
                                                 / ( 1 + pIVA.Porcentaje / 100 ),
                                                 2)
                          END
        FROM    dbo.DetallesComprobantes dc
                JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
                JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
        WHERE   idDetalleComprobante = @idDetalleComprobante

        RETURN @Result

    END

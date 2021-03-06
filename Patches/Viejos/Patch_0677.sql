USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[TotalGravado]    Script Date: 08/05/2016 11:21:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[TotalGravado] ( @idComprobante INT )
RETURNS MONEY
AS 
    BEGIN
        DECLARE @Result MONEY
        IF ( SELECT tc.Serie
             FROM   dbo.Comprobantes comp
                    JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
             WHERE  comp.idComprobante = @idComprobante
           ) = 'A' 
            SELECT  @Result = SUM(dbo.ImporteDelDetalleImpreso(dc.idDetalleComprobante))
            FROM    dbo.Comprobantes comp
                    JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
            WHERE   comp.idComprobante = @idComprobante
                    AND dc.idPorcentajeIVA NOT IN ( 1 )
        ELSE 
            SELECT  @Result = SUM(dbo.ImporteDelDetalleImpreso(dc.idDetalleComprobante)
                                  / ( 1 + pIVA.Porcentaje / 100 ))
            FROM    dbo.Comprobantes comp
                    JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
                    LEFT JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
            WHERE   comp.idComprobante = @idComprobante
                    AND dc.idPorcentajeIVA NOT IN ( 1 )
        RETURN @Result

    END

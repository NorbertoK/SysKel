USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[TotalGravado]    Script Date: 12/25/2018 13:25:10 ******/
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
           ) IN ('A', 'M') 
            SELECT  @Result = SUM(CASE WHEN dc.idPorcentajeIVA IN ( 1, 2 )
                                       THEN 0
                                       ELSE dbo.ImporteDelDetalleImpreso(dc.idDetalleComprobante)
                                  END)
            FROM    dbo.Comprobantes comp
                    JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
            WHERE   comp.idComprobante = @idComprobante
        ELSE 
            SELECT  @Result = SUM(CASE WHEN dc.idPorcentajeIVA IN ( 1, 2 )
                                       THEN 0
                                       ELSE dbo.ImporteDelDetalleImpreso(dc.idDetalleComprobante)
                                            / ( 1 + pIVA.Porcentaje / 100 )
                                  END)
            FROM    dbo.Comprobantes comp
                    JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
                    LEFT JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
            WHERE   comp.idComprobante = @idComprobante
        RETURN @Result

    END

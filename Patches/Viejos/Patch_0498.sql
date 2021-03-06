USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[IVAVentasAfiliados]    Script Date: 08/26/2015 09:17:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[IVAVentasAfiliados]
    @prefijo VARCHAR(4)
   ,@desde VARCHAR(8)
   ,@hasta VARCHAR(8)
AS 
    BEGIN
        SET NOCOUNT ON;

        SELECT  tc.Serie + Comp.Prefijo + '-' + Comp.NumeroDeComprobante Comprobante
               ,Comp.Fecha
               ,Comp.NombApel Cliente
               ,Comp.Importe * CASE WHEN tc.ImporteNegativo = 1 THEN -1
                                    ELSE 1
                               END Total
        FROM    dbo.Comprobantes comp
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
        WHERE   ( Comp.Fecha BETWEEN @desde
                             AND     dbo.Medianoche(@hasta) )
                AND Comp.Prefijo = @prefijo
                ORDER BY comp.Fecha
    END


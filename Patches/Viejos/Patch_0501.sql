
/****** Object:  StoredProcedure [dbo].[IVAVentasAfiliados]    Script Date: 08/28/2015 17:10:28 ******/
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
               ,catIVA.Nombre catIVA
               ,SUBSTRING(comp.CUIT,1,2)+'-'+SUBSTRING(comp.CUIT,3,8)+'-'+SUBSTRING(comp.CUIT,11,1) CUIT          
        FROM    dbo.Comprobantes comp
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                JOIN dbo.CategoriasIVA catIVA ON comp.idCategoriaIVA = catIVA.idCategoriaIVA
        WHERE   ( Comp.Fecha BETWEEN @desde
                             AND     dbo.Medianoche(@hasta) )
                AND Comp.Prefijo = @prefijo
                AND Anulado = 0
                ORDER BY dbo.HoraCero(comp.Fecha), tc.Serie + Comp.Prefijo + '-' + Comp.NumeroDeComprobante
    END


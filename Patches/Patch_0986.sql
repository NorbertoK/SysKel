USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[IVAVentasAfiliados]    Script Date: 04/10/2019 18:55:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[IVAVentasAfiliados]
    @desde VARCHAR(8)
   ,@hasta VARCHAR(8)
AS 
    BEGIN
        SET NOCOUNT ON;

        SELECT  Comp.Fecha
               ,tc.Tipo + ' ' + tc.Serie Tipo
               ,Comp.Prefijo + '-' + Comp.NumeroDeComprobante Comprobante
               ,Comp.NombApel Cliente
               ,catIVA.Iniciales catIVA
               ,SUBSTRING(comp.CUIT, 1, 2) + '-' + SUBSTRING(comp.CUIT, 3, 8)
                + '-' + SUBSTRING(comp.CUIT, 11, 1) CUIT
               ,dbo.TotalNoGravado(comp.idComprobante)
                * CASE WHEN tc.ImporteNegativo = 1 THEN -1
                       ELSE 1
                  END NoGravado
               ,dbo.TotalExento(comp.idComprobante)
                * CASE WHEN tc.ImporteNegativo = 1 THEN -1
                       ELSE 1
                  END Exento
               ,dbo.TotalGravado(comp.idComprobante)
                * CASE WHEN tc.ImporteNegativo = 1 THEN -1
                       ELSE 1
                  END Gravado
               ,dbo.Subtotal(idComprobante)
                * CASE WHEN tc.ImporteNegativo = 1 THEN -1
                       ELSE 1
                  END SubTotal
               ,dbo.TotalIVA(comp.idComprobante)
                * CASE WHEN tc.ImporteNegativo = 1 THEN -1
                       ELSE 1
                  END IVA
               ,Comp.Importe * CASE WHEN tc.ImporteNegativo = 1 THEN -1
                                    ELSE 1
                               END Total
        FROM    dbo.Comprobantes comp
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                JOIN dbo.CategoriasIVA catIVA ON comp.idCategoriaIVA = catIVA.idCategoriaIVA
        WHERE   ( Comp.Fecha BETWEEN @desde
                             AND     dbo.Medianoche(@hasta) )
                AND Comp.Prefijo IN ( SELECT    Prefijo
                                      FROM      dbo.PuntosDeVenta
                                      WHERE     Verdadero > 0 )
                AND ISNULL(Anulado, 0) = 0
        ORDER BY dbo.HoraCero(comp.Fecha)
               ,tc.Serie + Comp.Prefijo + '-' + Comp.NumeroDeComprobante
    END


USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[IVAVentasAfiliados]    Script Date: 09/04/2015 10:18:08 ******/
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

        SELECT  Comp.Fecha
               ,tc.Tipo + ' ' + tc.Serie Tipo
               ,Comp.Prefijo + '-' + Comp.NumeroDeComprobante Comprobante
               ,Comp.NombApel Cliente
               ,catIVA.Iniciales catIVA
               ,SUBSTRING(comp.CUIT, 1, 2) + '-' + SUBSTRING(comp.CUIT, 3, 8)
                + '-' + SUBSTRING(comp.CUIT, 11, 1) CUIT
               ,CASE WHEN comp.PjeIVA = 0
                     THEN Comp.Importe
                          * CASE WHEN tc.ImporteNegativo = 1 THEN -1
                                 ELSE 1
                            END
                     ELSE NULL
                END NoGravado
               ,CASE WHEN comp.PjeIVA != 0
                     THEN dbo.Redondeo(Comp.Importe
                                       * CASE WHEN tc.ImporteNegativo = 1
                                              THEN -1
                                              ELSE 1
                                         END / ( 1 + comp.PjeIVA / 100 ))
                     ELSE NULL
                END Gravado
               ,CASE WHEN dbo.Redondeo(Comp.Importe
                                       * CASE WHEN tc.ImporteNegativo = 1
                                              THEN -1
                                              ELSE 1
                                         END
                                       - CASE WHEN comp.PjeIVA != 0
                                              THEN dbo.Redondeo(Comp.Importe
                                                              * CASE
                                                              WHEN tc.ImporteNegativo = 1
                                                              THEN -1
                                                              ELSE 1
                                                              END / ( 1
                                                              + comp.PjeIVA
                                                              / 100 ))
                                              ELSE NULL
                                         END
                                       - dbo.Redondeo(CASE WHEN comp.PjeIVA != 0
                                                           THEN dbo.Redondeo(Comp.Importe
                                                              * CASE
                                                              WHEN tc.ImporteNegativo = 1
                                                              THEN -1
                                                              ELSE 1
                                                              END / ( 1
                                                              + comp.PjeIVA
                                                              / 100 ))
                                                           ELSE NULL
                                                      END * ( comp.PjeIVA
                                                              / 100 ))) = 0
                     THEN NULL
                     ELSE dbo.Redondeo(Comp.Importe
                                       * CASE WHEN tc.ImporteNegativo = 1
                                              THEN -1
                                              ELSE 1
                                         END
                                       - CASE WHEN comp.PjeIVA != 0
                                              THEN dbo.Redondeo(Comp.Importe
                                                              * CASE
                                                              WHEN tc.ImporteNegativo = 1
                                                              THEN -1
                                                              ELSE 1
                                                              END / ( 1
                                                              + comp.PjeIVA
                                                              / 100 ))
                                              ELSE NULL
                                         END
                                       - dbo.Redondeo(CASE WHEN comp.PjeIVA != 0
                                                           THEN dbo.Redondeo(Comp.Importe
                                                              * CASE
                                                              WHEN tc.ImporteNegativo = 1
                                                              THEN -1
                                                              ELSE 1
                                                              END / ( 1
                                                              + comp.PjeIVA
                                                              / 100 ))
                                                           ELSE NULL
                                                      END * ( comp.PjeIVA
                                                              / 100 )))
                END Otros
               ,comp.PjeIVA PjeIVA
               ,ISNULL(dbo.Redondeo(CASE WHEN comp.PjeIVA != 0
                                         THEN dbo.Redondeo(Comp.Importe
                                                           * CASE
                                                              WHEN tc.ImporteNegativo = 1
                                                              THEN -1
                                                              ELSE 1
                                                             END / ( 1
                                                              + comp.PjeIVA
                                                              / 100 ))
                                         ELSE NULL
                                    END * ( comp.PjeIVA / 100 )), 0) IVA
               ,Comp.Importe * CASE WHEN tc.ImporteNegativo = 1 THEN -1
                                    ELSE 1
                               END Total
        FROM    dbo.Comprobantes comp
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                JOIN dbo.CategoriasIVA catIVA ON comp.idCategoriaIVA = catIVA.idCategoriaIVA
        WHERE   ( Comp.Fecha BETWEEN @desde
                             AND     dbo.Medianoche(@hasta) )
                AND Comp.Prefijo = @prefijo
                AND Anulado = 0
        ORDER BY dbo.HoraCero(comp.Fecha)
               ,tc.Serie + Comp.Prefijo + '-' + Comp.NumeroDeComprobante
    END


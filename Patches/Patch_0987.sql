USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[REGINFO_CV_VENTAS_CBTE]    Script Date: 04/10/2019 18:58:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[REGINFO_CV_VENTAS_CBTE]
    @desde VARCHAR(8)
   ,@hasta VARCHAR(8)
AS 
    BEGIN
        SET NOCOUNT ON;

        SELECT  CAST(YEAR(comp.Fecha) AS VARCHAR(4)) + RIGHT('00'
                                                             + CAST(MONTH(comp.Fecha) AS VARCHAR(2)),
                                                             2) + RIGHT('00'
                                                              + CAST(DAY(comp.Fecha) AS VARCHAR(2)),
                                                              2) -- Fecha de comprobante
                + RIGHT('000' + tc.TablaAFIP, 3) -- Tipo de comprobante
                + RIGHT('00000' + comp.Prefijo, 5) -- Punto de venta
                + RIGHT(REPLICATE('0', 20) + Comp.NumeroDeComprobante, 20) -- Número de comprobante
                + RIGHT(REPLICATE('0', 20) + Comp.NumeroDeComprobante, 20) -- Número de comprobante hasta
                + CASE WHEN tc.Serie = 'A' OR tc.Serie = 'M' THEN '80'
                       ELSE CASE WHEN Importe >= 1000
                                 THEN CASE WHEN LEN(comp.CUIT) = '11'
                                           THEN '80'
                                           ELSE '96'
                                      END
                                 ELSE '99'
                            END
                  END -- Código de documento del comprador
                + RIGHT(REPLICATE('0', 20) + ISNULL(comp.CUIT, '0'), 20) -- Número de identificación del comprador  
                + LEFT(ISNULL(Comp.NombApel, ' ') + REPLICATE(' ', 30), 30) -- Apellido y nombre o denominación del comprador
                + CASE WHEN tc.ImporteNegativo = 1 THEN '-'
                       ELSE '0'
                  END + RIGHT(REPLICATE('0', 14)
                              + CAST(CONVERT(INT, ISNULL(Comp.Importe, 0))
                              * 100 AS VARCHAR(14)), 14) -- Importe total de la operación
                + CASE WHEN tc.ImporteNegativo = 1 THEN '-'
                       ELSE '0'
                  END + RIGHT(REPLICATE('0', 14)
                              + CAST(CONVERT(INT, ISNULL(dbo.TotalNoGravado(comp.idComprobante),
                                                         0)) * 100 AS VARCHAR(14)),
                              14) -- Importe total de conceptos que no integran el precio neto gravado
                + REPLICATE('0', 15) -- Percepción a no categorizados
                + CASE WHEN tc.ImporteNegativo = 1 THEN '-'
                       ELSE '0'
                  END + RIGHT(REPLICATE('0', 14)
                              + CAST(CONVERT(INT, ISNULL(dbo.TotalExento(comp.idComprobante),
                                                         0)) * 100 AS VARCHAR(14)),
                              14) -- Importe de operaciones exentas
                + REPLICATE('0', 15) -- Importe de percepciones o pagos a cuenta de impuestos Nacionales
                + REPLICATE('0', 15) -- Importe de percepciones de Ingresos Brutos
                + REPLICATE('0', 15) -- Importe de percepciones impuestos Municipales
                + REPLICATE('0', 15) -- Importe impuestos internos
                + 'PES' -- Código de moneda
                + '0001000000' -- Tipo de cambio
                + CAST(( SELECT COUNT(DISTINCT pIVA.CodigoAFIP)
                         FROM   dbo.DetallesComprobantes dc
                                JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
                         WHERE  idComprobante = comp.idComprobante
                                AND pIVA.CodigoAFIP > 3
                       ) AS VARCHAR(1))-- Cantidad de alícuotas de IVA
                + ' ' -- Código de operación
                + REPLICATE('0', 15) -- Otros Tributos
                + REPLICATE(' ', 8) -- Fecha de Vencimiento de Pago
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


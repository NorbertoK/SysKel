UPDATE  dbo.DetallesComprobantes
SET     idPorcentajeIVA = 5
FROM    dbo.DetallesComprobantes dc
        JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
WHERE   idGrupo IS NOT NULL
        AND idPorcentajeIVA IS NULL

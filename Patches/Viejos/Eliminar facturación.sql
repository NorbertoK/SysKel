DELETE dbo.DetallesComprobantes
FROM dbo.DetallesComprobantes dc
JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
WHERE idPrestacion IS NULL
AND idTipoDeComprobante = 4


DELETE dbo.Comprobantes
WHERE idPrestacion IS NULL
AND idTipoDeComprobante = 4

DELETE dbo.Facturaciones

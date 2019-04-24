UPDATE dbo.TiposDeComprobante
SET Serie = 'A'
WHERE Nombre IN ('Factura A','NdeCA','NdeDA')

UPDATE dbo.TiposDeComprobante
SET Serie = 'B'
WHERE Nombre IN ('Factura B','NdeCB','NdeDB')
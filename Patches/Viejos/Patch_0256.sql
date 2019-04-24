UPDATE dbo.TiposDeComprobante
SET Tipo = 'Factura'
WHERE Nombre IN('Cupón','Factura A','Factura B')

UPDATE dbo.TiposDeComprobante
SET Tipo = 'NdeC'
WHERE Nombre IN('Nota de Crédito','NdeCA','NdeCB')

UPDATE dbo.TiposDeComprobante
SET Tipo = 'NdeD'
WHERE Nombre IN('Nota de Débito','NdeDA','NdeDB')
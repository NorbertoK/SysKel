UPDATE dbo.TiposDeComprobante
SET Tipo = 'Factura'
WHERE Nombre IN('Cup�n','Factura A','Factura B')

UPDATE dbo.TiposDeComprobante
SET Tipo = 'NdeC'
WHERE Nombre IN('Nota de Cr�dito','NdeCA','NdeCB')

UPDATE dbo.TiposDeComprobante
SET Tipo = 'NdeD'
WHERE Nombre IN('Nota de D�bito','NdeDA','NdeDB')
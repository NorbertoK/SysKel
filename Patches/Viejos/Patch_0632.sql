UPDATE  dbo.DetallesComprobantes
SET     idPorcentajeIVA = 2
FROM    dbo.DetallesComprobantes dc
        JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
        JOIN dbo.Clientes cli ON comp.idCliente = cli.idCliente
        JOIN dbo.CategoriasIVA ci ON cli.idCategoriaIva = ci.idCategoriaIVA
WHERE   comp.PjeIVA = 0
        AND ci.Nombre = 'Exento'
        AND dc.Importe IS NOT NULL

UPDATE  dbo.DetallesComprobantes
SET     idPorcentajeIVA = 1
FROM    dbo.DetallesComprobantes dc
        JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
        JOIN dbo.Clientes cli ON comp.idCliente = cli.idCliente
        JOIN dbo.CategoriasIVA ci ON cli.idCategoriaIva = ci.idCategoriaIVA
WHERE   comp.PjeIVA = 0
        AND ci.Nombre != 'Exento'
        AND dc.Importe IS NOT NULL
        
UPDATE  dbo.DetallesComprobantes
SET     idPorcentajeIVA = 4
FROM    dbo.DetallesComprobantes dc
        JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
WHERE   comp.PjeIVA = 10.5
        AND dc.Importe IS NOT NULL

UPDATE  dbo.DetallesComprobantes
SET     idPorcentajeIVA = 5
FROM    dbo.DetallesComprobantes dc
        JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
WHERE   comp.PjeIVA = 21
        AND dc.Importe IS NOT NULL
       
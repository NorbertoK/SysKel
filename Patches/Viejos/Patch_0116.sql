UPDATE [Datos].[dbo].[Sistemas]
   SET [FacturaDeCompra] = (SELECT idTipoDeComprobante FROM dbo.TiposDeComprobante WHERE Nombre = 'Compra')
GO



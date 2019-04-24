UPDATE [Datos].[dbo].[Sistemas]
   SET [Pago] = (SELECT idTipoDeComprobante FROM dbo.TiposDeComprobante WHERE Nombre = 'Pago')
GO



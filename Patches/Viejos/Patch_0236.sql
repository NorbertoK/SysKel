UPDATE [Datos].[dbo].[TiposDeComprobante]
   SET [EsFactura] = 1
 WHERE Nombre IN ('Cupón','Factura A','Factura B')
GO



INSERT  INTO [Datos].[dbo].[TiposDeComprobante]
        ( [Nombre], [Iniciales], [ImporteNegativo], [DiscriminaIVA],
         [EsFactura], [Serie], [Tipo], [TablaAFIP] )
VALUES  ( 'Factura M', 'F M', 0, 1, 1, 'M', 'Factura', 51 ),
        ( 'Nota de Cr�dito M', 'NCM', 1, 1, 0, 'M', 'NdeC', 53 ),
        ( 'Nota de D�bito M', 'NDM', 1, 0, 0, 'M', 'NdeD', 52 )
GO



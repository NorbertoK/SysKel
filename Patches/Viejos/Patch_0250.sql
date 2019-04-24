INSERT INTO [Datos].[dbo].[TiposDeComprobante]
           ([Nombre]
           ,[Iniciales]
           ,[ImporteNegativo]
           ,[DiscriminaIVA]
           ,[EsFactura])
     VALUES
           ('NdeCA'
           ,'NCA'
           ,1
           ,1
           ,0)
           ,('NdeCB'
           ,'NCB'
           ,1
           ,0
           ,0)
           ,('NdeDA'
           ,'NDA'
           ,0
           ,1
           ,0)
           ,('NdeDB'
           ,'NDB'
           ,0
           ,0
           ,0)
GO



INSERT INTO [dbo].[Contratos]
           ([Nombre]
           ,[idCliente]
           ,[idTipoDeContrato]
           ,[Ene]
           ,[Feb]
           ,[Mar]
           ,[Abr]
           ,[May]
           ,[Jun]
           ,[Jul]
           ,[Ago]
           ,[Sep]
           ,[Oct]
           ,[Nov]
           ,[Dic]
           )
     VALUES
           ('Varios'
           ,(SELECT idCliente FROM clientes WHERE RazonSocial = 'Varios')
           ,1
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           )
GO




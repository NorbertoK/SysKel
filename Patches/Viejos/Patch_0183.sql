IF NOT EXISTS (SELECT * FROM dbo.Autorizaciones WHERE Codigo = 'MC-0035')
INSERT INTO [Datos].[dbo].[Autorizaciones]
           ([Descripcion]
           ,[idTipoDeAutorizacion]
           ,[Codigo])
     VALUES
           ('Consultorio - Recibir pacientes'
           ,2
           ,'MC-0035')
GO
IF NOT EXISTS (SELECT * FROM dbo.Autorizaciones WHERE Codigo = 'MC-0036')
INSERT INTO [Datos].[dbo].[Autorizaciones]
           ([Descripcion]
           ,[idTipoDeAutorizacion]
           ,[Codigo])
     VALUES
           ('Consultorio - Àtender pacientes'
           ,2
           ,'MC-0036')
GO


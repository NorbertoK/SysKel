INSERT INTO [Datos].[dbo].[Autorizaciones]
           ([Descripcion]
           ,[idTipoDeAutorizacion]
           ,[Codigo])
     SELECT
           'Consultorio - Recibir Pacientes',
           idTipoDeAutorizacion, 
           'MC-0035'
     FROM dbo.TiposDeAutorizacion WHERE Nombre LIKE 'Men%' and Nombre Like '%abina%'
     
INSERT INTO [Datos].[dbo].[Autorizaciones]
           ([Descripcion]
           ,[idTipoDeAutorizacion]
           ,[Codigo])
     SELECT
           'Consultorio - Atender Pacientes',
           idTipoDeAutorizacion, 
           'MC-0036'
     FROM dbo.TiposDeAutorizacion WHERE Nombre LIKE 'Men%' and Nombre Like '%abina%'     
     
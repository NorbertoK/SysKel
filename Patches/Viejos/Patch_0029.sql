INSERT INTO [Datos].[dbo].[Autorizaciones]
           ([Descripcion]
           ,[idTipoDeAutorizacion]
           ,[Codigo])
     SELECT
           'Consultorio - Dar Turnos',
           idTipoDeAutorizacion, 
           'MC-0034'
     FROM dbo.TiposDeAutorizacion WHERE Nombre LIKE 'Men%' and Nombre Like '%abina%'
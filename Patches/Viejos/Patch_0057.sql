INSERT INTO [Datos].[dbo].[Autorizaciones]
           ([Descripcion]
           ,[idTipoDeAutorizacion]
           ,[Codigo])
     SELECT
           'Reportes - Estadísticas - Prestaciones por Cliente',
           idTipoDeAutorizacion, 
           'MA-0104'
     FROM dbo.TiposDeAutorizacion WHERE Nombre LIKE 'Men%' and Nombre Like '%dministrac%'
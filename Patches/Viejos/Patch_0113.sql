INSERT INTO [Datos].[dbo].[Autorizaciones]
           ([Descripcion]
           ,[idTipoDeAutorizacion]
           ,[Codigo])
     SELECT
           'Pagar Compras',
           idTipoDeAutorizacion, 
           'MA-0107'
     FROM dbo.TiposDeAutorizacion WHERE Nombre LIKE 'Men%' and Nombre Like '%dministrac%'
INSERT INTO [Datos].[dbo].[Autorizaciones]
           ([Descripcion]
           ,[idTipoDeAutorizacion]
           ,[Codigo])
     SELECT
           'Consultorio - Generar Turnos vacíos',
           idTipoDeAutorizacion, 
           'MC-0033'
     FROM dbo.TiposDeAutorizacion WHERE Nombre LIKE 'Men%' and Nombre Like '%abin%'
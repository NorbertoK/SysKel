INSERT  INTO [Datos].[dbo].[Autorizaciones]
        ( [Descripcion]
        ,[idTipoDeAutorizacion]
        ,[Codigo]
        )
        SELECT  'Consultorio - Feriados'
               ,idTipoDeAutorizacion
               ,'MC-0031'
        FROM    dbo.TiposDeAutorizacion
        WHERE   Nombre LIKE 'Men%'
                AND Nombre LIKE '%abin%'
     
INSERT  INTO [Datos].[dbo].[Autorizaciones]
        ( [Descripcion]
        ,[idTipoDeAutorizacion]
        ,[Codigo]
        )
        SELECT  'Consultorio - Moldes de Turnos'
               ,idTipoDeAutorizacion
               ,'MC-0032'
        FROM    dbo.TiposDeAutorizacion
        WHERE   Nombre LIKE 'Men%'
                AND Nombre LIKE '%abin%'
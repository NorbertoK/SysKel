UPDATE  [Datos].[dbo].[Autorizaciones]
SET     [Descripcion] = 'Reportes - Estadística - Facturado por Rubro'
WHERE   idAutorizacion = 164
GO

INSERT  INTO [Datos].[dbo].[Autorizaciones]
        ( [Descripcion]
        ,[idTipoDeAutorizacion]
        ,[Codigo]
        )
VALUES  ( 'Reportes - Estadística - Facturado por Negocio'
        ,1
        ,'MA-0118'
        )
GO


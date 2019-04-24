UPDATE [Datos].[dbo].[Comprobantes]
   SET [idEntidadDeCobranza] = NULL
GO
UPDATE [Datos].[dbo].[Facturaciones]
   SET [idEntidadDeCobranza] = NULL
GO
UPDATE [Datos].[dbo].[Clientes]
   SET [idTipoDeCobranza] = 1
      ,[idEntidadDeCobranza] = NULL
GO
DELETE FROM [Datos].[dbo].[EntidadesDeCobranza]
GO



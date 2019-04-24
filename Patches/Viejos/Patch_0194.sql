UPDATE [Datos].[dbo].[TiposDeCobranza]
   SET [RequiereDireccionReal] = 1
 WHERE Nombre != 'Contrato'
GO
UPDATE [Datos].[dbo].[TiposDeCobranza]
   SET [RequiereDireccionReal] = 0
 WHERE Nombre = 'Contrato'
GO



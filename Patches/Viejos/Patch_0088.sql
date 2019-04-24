UPDATE [Datos].[dbo].[Pacientes]
   SET [idCobertura] = 9
 WHERE [idCobertura] = 7
GO

DELETE FROM [Datos].[dbo].[Coberturas]
      WHERE [idCobertura] = 7
GO



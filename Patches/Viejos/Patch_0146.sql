/****** Script for SelectTopNRows command from SSMS  ******/
  UPDATE [Datos].[dbo].[Autorizaciones]
  SET Descripcion = 'Aplicar Rubro a Compras'
  WHERE Codigo = 'MA-0077'
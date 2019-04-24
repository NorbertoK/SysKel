USE [Datos]
GO

/****** Object:  StoredProcedure [dbo].[NuevoNumeroDeValor]    Script Date: 02/20/2017 10:18:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NuevoNumeroDeValor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[NuevoNumeroDeValor]
GO



USE [Datos]
GO

/****** Object:  StoredProcedure [dbo].[NuevoNumeroDeCaja]    Script Date: 05/14/2017 21:15:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NuevoNumeroDeCaja]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[NuevoNumeroDeCaja]
GO



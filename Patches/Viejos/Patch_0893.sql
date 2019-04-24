USE [Datos]
GO

/****** Object:  StoredProcedure [dbo].[ArchivarAumentosAutomaticos]    Script Date: 03/06/2018 10:18:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ArchivarAumentosAutomaticos]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ArchivarAumentosAutomaticos]
GO



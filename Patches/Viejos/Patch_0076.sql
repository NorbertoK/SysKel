USE [Datos]
GO

/****** Object:  StoredProcedure [dbo].[InsertarPagoEfectivoEnValores]    Script Date: 03/29/2013 11:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertarPagoEfectivoEnValores]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertarPagoEfectivoEnValores]
GO



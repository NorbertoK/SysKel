USE [Datos]
GO

/****** Object:  StoredProcedure [dbo].[CantidadAfiliadosActivosGrupo]    Script Date: 07/23/2013 00:09:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CantidadAfiliadosActivosGrupo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CantidadAfiliadosActivosGrupo]
GO



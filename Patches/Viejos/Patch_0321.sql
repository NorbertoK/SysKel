USE [Datos]
GO

/****** Object:  UserDefinedFunction [dbo].[idComprobanteDesdeProceso]    Script Date: 03/28/2014 11:29:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[idComprobanteDesdeProceso]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[idComprobanteDesdeProceso]
GO



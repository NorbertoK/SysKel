USE [Datos]
GO

/****** Object:  UserDefinedFunction [dbo].[AtencionesAnterioresConsultorio]    Script Date: 02/11/2013 13:29:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AtencionesAnterioresConsultorio]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[AtencionesAnterioresConsultorio]
GO



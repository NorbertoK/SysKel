USE [Datos]
GO

/****** Object:  UserDefinedFunction [dbo].[Func_ReporteComprobanteDeFactura]    Script Date: 09/23/2015 20:08:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Func_ReporteComprobanteDeFactura]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Func_ReporteComprobanteDeFactura]
GO



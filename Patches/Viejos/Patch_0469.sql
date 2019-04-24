
/****** Object:  UserDefinedFunction [dbo].[Func_ReporteComprobantes]    Script Date: 05/27/2015 15:46:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Func_ReporteComprobantes]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[Func_ReporteComprobantes]
GO



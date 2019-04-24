USE [Datos]
GO

/****** Object:  Table [dbo].[HistorialRecursos]    Script Date: 03/16/2014 12:14:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HistorialRecursos]') AND type in (N'U'))
DROP TABLE [dbo].[HistorialRecursos]
GO



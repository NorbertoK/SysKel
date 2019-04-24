USE [Datos]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__CopagosPl__idCod__5D80D6A1]') AND parent_object_id = OBJECT_ID(N'[dbo].[CopagosPlanes]'))
ALTER TABLE [dbo].[CopagosPlanes] DROP CONSTRAINT [FK__CopagosPl__idCod__5D80D6A1]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CopagosPlanes_Planes]') AND parent_object_id = OBJECT_ID(N'[dbo].[CopagosPlanes]'))
ALTER TABLE [dbo].[CopagosPlanes] DROP CONSTRAINT [FK_CopagosPlanes_Planes]
GO

USE [Datos]
GO

/****** Object:  Table [dbo].[CopagosPlanes]    Script Date: 10/02/2013 16:18:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CopagosPlanes]') AND type in (N'U'))
DROP TABLE [dbo].[CopagosPlanes]
GO



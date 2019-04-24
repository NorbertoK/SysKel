USE [Datos]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__DetallesP__idPag__62A57E71]') AND parent_object_id = OBJECT_ID(N'[dbo].[DetallesCompras]'))
ALTER TABLE [dbo].[DetallesCompras] DROP CONSTRAINT [FK__DetallesP__idPag__62A57E71]
GO

USE [Datos]
GO

/****** Object:  Table [dbo].[DetallesCompras]    Script Date: 10/18/2016 15:31:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DetallesCompras]') AND type in (N'U'))
DROP TABLE [dbo].[DetallesCompras]
GO



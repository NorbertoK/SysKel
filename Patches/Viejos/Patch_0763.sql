USE [Datos]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Pagos_Empleados]') AND parent_object_id = OBJECT_ID(N'[dbo].[Pagos]'))
ALTER TABLE [dbo].[Pagos] DROP CONSTRAINT [FK_Pagos_Empleados]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Pagos_Proveedores]') AND parent_object_id = OBJECT_ID(N'[dbo].[Pagos]'))
ALTER TABLE [dbo].[Pagos] DROP CONSTRAINT [FK_Pagos_Proveedores]
GO

USE [Datos]
GO

/****** Object:  Table [dbo].[Pagos]    Script Date: 11/18/2016 20:08:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pagos]') AND type in (N'U'))
DROP TABLE [dbo].[Pagos]
GO

USE [Datos]
GO

/****** Object:  Table [dbo].[Pagos]    Script Date: 11/18/2016 20:08:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrdenesDePago](
	[idOrdenDePago] [int] IDENTITY(1,1) NOT NULL,
	[idProveedor] [int] NULL,
	[idGrabador] [int] NULL,
	[Fecha] [datetime] NULL,
	[Importe] [money] NULL,
	[idCaja] [int] NULL,
 CONSTRAINT [PK_Pagos] PRIMARY KEY CLUSTERED 
(
	[idOrdenDePago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [FK_Pagos_Empleados] FOREIGN KEY([idCaja])
--REFERENCES [dbo].[Empleados] ([idEmpleado])
--GO

--ALTER TABLE [dbo].[Pagos] CHECK CONSTRAINT [FK_Pagos_Empleados]
--GO

--ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [FK_Pagos_Proveedores] FOREIGN KEY([idProveedor])
--REFERENCES [dbo].[Proveedores] ([idProveedor])
--GO

--ALTER TABLE [dbo].[Pagos] CHECK CONSTRAINT [FK_Pagos_Proveedores]
--GO



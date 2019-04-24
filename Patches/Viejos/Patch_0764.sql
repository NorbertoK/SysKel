USE [Datos]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ComprobantesPagos_Compras]') AND parent_object_id = OBJECT_ID(N'[dbo].[ComprobantesPagos]'))
ALTER TABLE [dbo].[ComprobantesPagos] DROP CONSTRAINT [FK_ComprobantesPagos_Compras]
GO

USE [Datos]
GO

/****** Object:  Table [dbo].[ComprobantesPagos]    Script Date: 11/18/2016 20:13:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ComprobantesPagos]') AND type in (N'U'))
DROP TABLE [dbo].[ComprobantesPagos]
GO

USE [Datos]
GO

/****** Object:  Table [dbo].[ComprobantesPagos]    Script Date: 11/18/2016 20:13:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ComprobantesOrdenesDePago](
	[idComprobanteOrdenDePago] [int] IDENTITY(1,1) NOT NULL,
	[idPago] [int] NOT NULL,
	[idCompra] [int] NOT NULL,
	[ImporteCompra]  AS ([dbo].[ImporteCompra]([idCompra])),
	[ImportePagado] [money] NULL,
	[Observaciones] [varchar](max) NULL,
	[FechaCompra]  AS ([dbo].[FechaCompra]([idCompra])),
	[ComprobanteCompra]  AS ([dbo].[ComprobanteCompra]([idCompra])),
	[idProveedor]  AS ([dbo].[IdProveedorCompra]([idCompra])),
 CONSTRAINT [PK_ComprobantesPagos] PRIMARY KEY CLUSTERED 
(
	[idComprobanteOrdenDePago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



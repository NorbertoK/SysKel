/*
   sábado, 05 de noviembre de 201605:13:50 p.m.
   User: 
   Server: NORBERTOPC
   Database: Datos
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Compras
	DROP CONSTRAINT FK__Pagos__idProveed__648DC6E3
GO
ALTER TABLE dbo.Proveedores SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Proveedores', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Proveedores', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Proveedores', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Compras
	(
	idCompra int NOT NULL IDENTITY (1, 1),
	idProveedor int NULL,
	idGrabador int NULL,
	FechaRegistro datetime NULL,
	Fecha date NULL,
	Serie varchar(1) NULL,
	idTipoDeComprobante int NULL,
	Comprobante varchar(13) NULL,
	Importe money NULL,
	Saldo  AS ([dbo].[SaldoCompra]([idCompra])),
	idReferencia int NULL,
	Nombre varchar(100) NULL,
	CUIT varchar(11) NULL,
	Observaciones varchar(MAX) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Compras SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Compras ON
GO
IF EXISTS(SELECT * FROM dbo.Compras)
	 EXEC('INSERT INTO dbo.Tmp_Compras (idCompra, idProveedor, idGrabador, FechaRegistro, Fecha, Serie, idTipoDeComprobante, Comprobante, Importe, idReferencia, Nombre, CUIT, Observaciones)
		SELECT idCompra, idProveedor, idGrabador, FechaRegistro, Fecha, Serie, idTipoDeComprobante, Comprobante, Importe, idReferencia, Nombre, CUIT, Observaciones FROM dbo.Compras WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Compras OFF
GO
ALTER TABLE dbo.NegociosCompras
	DROP CONSTRAINT FK_NegociosCompras_Compras
GO
ALTER TABLE dbo.ComprobantesPagos
	DROP CONSTRAINT FK_ComprobantesPagos_Compras
GO
DROP TABLE dbo.Compras
GO
EXECUTE sp_rename N'dbo.Tmp_Compras', N'Compras', 'OBJECT' 
GO
ALTER TABLE dbo.Compras ADD CONSTRAINT
	PK__Pagos__5BF880E2 PRIMARY KEY CLUSTERED 
	(
	idCompra
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Compras ADD CONSTRAINT
	FK__Pagos__idProveed__648DC6E3 FOREIGN KEY
	(
	idProveedor
	) REFERENCES dbo.Proveedores
	(
	idProveedor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Compras', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Compras', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Compras', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ComprobantesPagos ADD CONSTRAINT
	FK_ComprobantesPagos_Compras FOREIGN KEY
	(
	idCompra
	) REFERENCES dbo.Compras
	(
	idCompra
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ComprobantesPagos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ComprobantesPagos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ComprobantesPagos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ComprobantesPagos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.NegociosCompras ADD CONSTRAINT
	FK_NegociosCompras_Compras FOREIGN KEY
	(
	idCompra
	) REFERENCES dbo.Compras
	(
	idCompra
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.NegociosCompras SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.NegociosCompras', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.NegociosCompras', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.NegociosCompras', 'Object', 'CONTROL') as Contr_Per 
/*
   martes, 18 de octubre de 201603:38:47 p.m.
   User: 
   Server: (local)
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
	DROP CONSTRAINT FK_Compras_Rubros
GO
ALTER TABLE dbo.Rubros SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Rubros', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Rubros', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Rubros', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Compras
	DROP CONSTRAINT FK_Compras_TiposDeComprobante
GO
ALTER TABLE dbo.TiposDeComprobante SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TiposDeComprobante', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TiposDeComprobante', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TiposDeComprobante', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Compras
	DROP CONSTRAINT FK__Pagos__idGrabado__6581EB1C
GO
ALTER TABLE dbo.Usuarios SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Usuarios', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Usuarios', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Usuarios', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
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
	idProveedor int NOT NULL,
	idGrabador int NOT NULL,
	FechaRegistro datetime NOT NULL,
	Fecha date NOT NULL,
	Serie varchar(1) NOT NULL,
	idTipoDeComprobante int NOT NULL,
	Comprobante varchar(13) NOT NULL,
	Importe money NOT NULL,
	Saldo  AS ([dbo].[SaldoCompra]([idCompra])),
	idReferencia int NULL,
	Nombre varchar(100) NOT NULL,
	CUIT varchar(11) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Compras SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Compras ON
GO
IF EXISTS(SELECT * FROM dbo.Compras)
	 EXEC('INSERT INTO dbo.Tmp_Compras (idCompra, idProveedor, idGrabador, FechaRegistro, Fecha, Serie, idTipoDeComprobante, Comprobante, Importe, idReferencia, Nombre, CUIT)
		SELECT idCompra, idProveedor, idGrabador, FechaRegistro, Fecha, Serie, idTipoDeComprobante, CONVERT(varchar(13), Comprobante), Importe, idReferencia, Nombre, CUIT FROM dbo.Compras WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Compras OFF
GO
ALTER TABLE dbo.ComprobantesPagos
	DROP CONSTRAINT FK_ComprobantesPagos_Compras
GO
ALTER TABLE dbo.NegociosCompras
	DROP CONSTRAINT FK_NegociosCompras_Compras
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
ALTER TABLE dbo.Compras ADD CONSTRAINT
	FK__Pagos__idGrabado__6581EB1C FOREIGN KEY
	(
	idGrabador
	) REFERENCES dbo.Usuarios
	(
	idUsuario
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Compras ADD CONSTRAINT
	FK_Compras_TiposDeComprobante FOREIGN KEY
	(
	idTipoDeComprobante
	) REFERENCES dbo.TiposDeComprobante
	(
	idTipoDeComprobante
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Compras', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Compras', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Compras', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
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
select Has_Perms_By_Name(N'dbo.NegociosCompras', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.NegociosCompras', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.NegociosCompras', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
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
select Has_Perms_By_Name(N'dbo.ComprobantesPagos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ComprobantesPagos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ComprobantesPagos', 'Object', 'CONTROL') as Contr_Per 
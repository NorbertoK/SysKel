/*
   viernes, 27 de noviembre de 20154:14:28 p. m.
   User: 
   Server: NORBERTO
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
	Fecha date NOT NULL,
	Comprobante varchar(20) NULL,
	Importe money NULL,
	idTipoDeComprobante int NULL,
	idReferencia int NULL,
	FechaRegistro datetime NULL,
	Saldo  AS ([dbo].[SaldoCompra]([idCompra])),
	idPago int NULL,
	idRubro int NULL,
	Nombre varchar(100) NULL,
	CUIT varchar(11) NULL,
	ImporteNetoGravado money NULL,
	ImporteNetoNoGravado money NULL,
	IVA money NULL,
	Otros money NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Compras SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Compras ON
GO
IF EXISTS(SELECT * FROM dbo.Compras)
	 EXEC('INSERT INTO dbo.Tmp_Compras (idCompra, idProveedor, idGrabador, Fecha, Comprobante, Importe, idTipoDeComprobante, idReferencia, FechaRegistro, idPago, idRubro)
		SELECT idCompra, idProveedor, idGrabador, Fecha, CONVERT(varchar(20), Comprobante), Importe, idTipoDeComprobante, idReferencia, FechaRegistro, idPago, idRubro FROM dbo.Compras WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Compras OFF
GO
ALTER TABLE dbo.NegociosCompras
	DROP CONSTRAINT FK_NegociosCompras_Compras
GO
ALTER TABLE dbo.ComprobantesPagos
	DROP CONSTRAINT FK_ComprobantesPagos_Compras
GO
ALTER TABLE dbo.DetallesCompras
	DROP CONSTRAINT FK__DetallesP__idPag__62A57E71
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
ALTER TABLE dbo.Compras ADD CONSTRAINT
	FK_Compras_Rubros FOREIGN KEY
	(
	idRubro
	) REFERENCES dbo.Rubros
	(
	idRubro
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Compras', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Compras', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Compras', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.DetallesCompras ADD CONSTRAINT
	FK__DetallesP__idPag__62A57E71 FOREIGN KEY
	(
	idCompra
	) REFERENCES dbo.Compras
	(
	idCompra
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DetallesCompras SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DetallesCompras', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetallesCompras', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetallesCompras', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
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
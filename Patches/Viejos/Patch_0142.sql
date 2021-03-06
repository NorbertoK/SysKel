/*
   domingo, 11 de agosto de 201302:03:29 a.m.
   User: 
   Server: Norberto
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
ALTER TABLE dbo.TiposDeComprobante SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TiposDeComprobante', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TiposDeComprobante', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TiposDeComprobante', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Usuarios SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Usuarios', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Usuarios', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Usuarios', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Negocios SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Negocios', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Negocios', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Negocios', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
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
ALTER TABLE dbo.Compras SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Compras', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Compras', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Compras', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.NegociosCompras ADD CONSTRAINT
	FK_NegociosCompras_Negocios FOREIGN KEY
	(
	idNegocio
	) REFERENCES dbo.Negocios
	(
	idNegocio
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
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
ALTER TABLE dbo.Empleados SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
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
ALTER TABLE dbo.Transferencias ADD CONSTRAINT
	FK_Transferencias_Empleados1 FOREIGN KEY
	(
	De
	) REFERENCES dbo.Empleados
	(
	idEmpleado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Transferencias ADD CONSTRAINT
	FK_Transferencias_Empleados2 FOREIGN KEY
	(
	A
	) REFERENCES dbo.Empleados
	(
	idEmpleado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Transferencias ADD CONSTRAINT
	FK_Transferencias_Usuarios FOREIGN KEY
	(
	idGrabador
	) REFERENCES dbo.Usuarios
	(
	idUsuario
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Transferencias SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Transferencias', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Transferencias', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Transferencias', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Retiros ADD CONSTRAINT
	FK_Retiros_Empleados FOREIGN KEY
	(
	De
	) REFERENCES dbo.Empleados
	(
	idEmpleado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Retiros ADD CONSTRAINT
	FK_Retiros_Usuarios FOREIGN KEY
	(
	idGrabador
	) REFERENCES dbo.Usuarios
	(
	idUsuario
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Retiros SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Retiros', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Retiros', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Retiros', 'Object', 'CONTROL') as Contr_Per 
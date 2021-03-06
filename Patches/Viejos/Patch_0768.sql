/*
   sábado, 19 de noviembre de 201612:10:12 p.m.
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
ALTER TABLE dbo.OrdenesDePago SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.OrdenesDePago', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.OrdenesDePago', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.OrdenesDePago', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ComprobantesOrdenesDePago ADD CONSTRAINT
	FK_ComprobantesOrdenesDePago_OrdenesDePago FOREIGN KEY
	(
	idOrdenDePago
	) REFERENCES dbo.OrdenesDePago
	(
	idOrdenDePago
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ComprobantesOrdenesDePago SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ComprobantesOrdenesDePago', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ComprobantesOrdenesDePago', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ComprobantesOrdenesDePago', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ValoresRetiros ADD CONSTRAINT
	FK_ValoresRetiros_OrdenesDePago FOREIGN KEY
	(
	idOrdenDePago
	) REFERENCES dbo.OrdenesDePago
	(
	idOrdenDePago
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ValoresRetiros SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ValoresRetiros', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ValoresRetiros', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ValoresRetiros', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ValoresRemesas ADD CONSTRAINT
	FK_ValoresRemesas_OrdenesDePago FOREIGN KEY
	(
	EntregadoIdOrdenDePago
	) REFERENCES dbo.OrdenesDePago
	(
	idOrdenDePago
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ValoresRemesas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ValoresRemesas', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ValoresRemesas', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ValoresRemesas', 'Object', 'CONTROL') as Contr_Per 
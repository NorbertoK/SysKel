/*
   viernes, 03 de mayo de 201301:24:34 a.m.
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
ALTER TABLE dbo.Reintegros SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Reintegros', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Reintegros', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Reintegros', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Pagos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Pagos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Pagos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Pagos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ValoresRemesas ADD CONSTRAINT
	FK_ValoresRemesas_Pagos FOREIGN KEY
	(
	EntregadoIdPago
	) REFERENCES dbo.Pagos
	(
	idPago
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ValoresRemesas ADD CONSTRAINT
	FK_ValoresRemesas_Reintegros FOREIGN KEY
	(
	idReintegroEfectivo
	) REFERENCES dbo.Reintegros
	(
	idReintegro
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ValoresRemesas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ValoresRemesas', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ValoresRemesas', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ValoresRemesas', 'Object', 'CONTROL') as Contr_Per 
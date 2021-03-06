/*
   viernes, 18 de noviembre de 201608:07:44 p.m.
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
ALTER TABLE dbo.ComprobantesPagos
	DROP CONSTRAINT FK_ComprobantesPagos_Pagos
GO
ALTER TABLE dbo.ValoresRemesas
	DROP CONSTRAINT FK_ValoresRemesas_Pagos
GO
ALTER TABLE dbo.ValoresRetiros
	DROP CONSTRAINT FK_ValoresRetiros_Pagos
GO
ALTER TABLE dbo.Pagos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Pagos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Pagos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Pagos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ValoresRetiros SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ValoresRetiros', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ValoresRetiros', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ValoresRetiros', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ValoresRemesas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ValoresRemesas', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ValoresRemesas', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ValoresRemesas', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ComprobantesPagos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ComprobantesPagos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ComprobantesPagos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ComprobantesPagos', 'Object', 'CONTROL') as Contr_Per 
/*
   lunes, 25 de noviembre de 201303:01:31 p.m.
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
ALTER TABLE dbo.Contactos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Contactos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Contactos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Contactos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Afiliados SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Afiliados', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Afiliados', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Afiliados', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Emails ADD CONSTRAINT
	FK_Emails_Afiliados FOREIGN KEY
	(
	idAfiliado
	) REFERENCES dbo.Afiliados
	(
	idAfiliado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Emails ADD CONSTRAINT
	FK_Emails_Contactos FOREIGN KEY
	(
	idContacto
	) REFERENCES dbo.Contactos
	(
	idContacto
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Emails SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Emails', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Emails', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Emails', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Direcciones
	DROP CONSTRAINT FK__Direccion__idZon__51DA19CB
GO
ALTER TABLE dbo.Zonas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Zonas', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Zonas', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Zonas', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Direcciones
	DROP CONSTRAINT FK_Direcciones_Destinos
GO
ALTER TABLE dbo.Destinos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Destinos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Destinos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Destinos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Direcciones
	DROP CONSTRAINT FK__Direccion__idBar__6BEEF189
GO
ALTER TABLE dbo.Barrios SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Barrios', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Barrios', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Barrios', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Direcciones
	DROP CONSTRAINT FK__Direccion__idLug__71A7CADF
GO
ALTER TABLE dbo.Lugares SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Lugares', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Lugares', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Lugares', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Direcciones SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Direcciones', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Direcciones', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Direcciones', 'Object', 'CONTROL') as Contr_Per 
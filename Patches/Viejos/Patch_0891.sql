/*
   lunes, 5 de marzo de 201817:18:32
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
ALTER TABLE dbo.AumentosAutoCabecera SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.AumentosAutoCabecera', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.AumentosAutoCabecera', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.AumentosAutoCabecera', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.AumentosAuto ADD CONSTRAINT
	FK_AumentosAuto_AumentosAutoCabecera FOREIGN KEY
	(
	idAumentoAutoCabecera
	) REFERENCES dbo.AumentosAutoCabecera
	(
	idAumentosAUtoCabecera
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.AumentosAuto SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.AumentosAuto', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.AumentosAuto', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.AumentosAuto', 'Object', 'CONTROL') as Contr_Per 
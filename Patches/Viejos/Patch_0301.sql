/*
   domingo, 16 de marzo de 201412:51:40 a.m.
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
ALTER TABLE dbo.Hist_Recursos ADD
	Fecha datetime NULL
GO
ALTER TABLE dbo.Hist_Recursos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Hist_Recursos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Hist_Recursos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Hist_Recursos', 'Object', 'CONTROL') as Contr_Per 
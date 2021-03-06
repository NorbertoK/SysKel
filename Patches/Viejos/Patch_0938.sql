/*
   jueves, 22 de noviembre de 201811:37:38
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
EXECUTE sp_rename N'dbo.ImportarCAE.Poceso', N'Tmp_Proceso', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.ImportarCAE.Tmp_Proceso', N'Proceso', 'COLUMN' 
GO
ALTER TABLE dbo.ImportarCAE SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ImportarCAE', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ImportarCAE', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ImportarCAE', 'Object', 'CONTROL') as Contr_Per 
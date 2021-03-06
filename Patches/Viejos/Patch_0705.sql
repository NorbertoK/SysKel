/*
   viernes, 23 de septiembre de 201601:16:24 p.m.
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
EXECUTE sp_rename N'dbo.Parametros.Sign', N'Tmp_Sign_', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.Parametros.Tmp_Sign_', N'Sign_', 'COLUMN' 
GO
ALTER TABLE dbo.Parametros SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Parametros', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Parametros', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Parametros', 'Object', 'CONTROL') as Contr_Per 
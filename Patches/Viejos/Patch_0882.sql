/*
   miércoles, 28 de febrero de 201814:09:23
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
ALTER TABLE dbo.Negocios ADD
	Marca bit NULL
GO
ALTER TABLE dbo.Negocios ADD CONSTRAINT
	DF_Negocios_Marca DEFAULT 1 FOR Marca
GO
ALTER TABLE dbo.Negocios SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Negocios', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Negocios', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Negocios', 'Object', 'CONTROL') as Contr_Per 
GO
UPDATE dbo.Negocios
SET Marca = 1
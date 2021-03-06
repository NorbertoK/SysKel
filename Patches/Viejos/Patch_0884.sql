/*
   miércoles, 28 de febrero de 201814:13:14
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
ALTER TABLE dbo.Localidades ADD
	Marca bit NULL
GO
ALTER TABLE dbo.Localidades ADD CONSTRAINT
	DF_Localidades_Marca DEFAULT 1 FOR Marca
GO
ALTER TABLE dbo.Localidades SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Localidades', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Localidades', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Localidades', 'Object', 'CONTROL') as Contr_Per 
GO
UPDATE dbo.Localidades
SET Marca = 1
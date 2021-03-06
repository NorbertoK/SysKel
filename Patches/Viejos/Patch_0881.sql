/*
   miércoles, 28 de febrero de 201812:10:02
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
ALTER TABLE dbo.TiposDeContrato ADD
	Marca bit NULL
GO
ALTER TABLE dbo.TiposDeContrato ADD CONSTRAINT
	DF_TiposDeContrato_Marca DEFAULT 1 FOR Marca
GO
ALTER TABLE dbo.TiposDeContrato SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TiposDeContrato', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TiposDeContrato', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TiposDeContrato', 'Object', 'CONTROL') as Contr_Per 
GO
UPDATE dbo.TiposDeContrato
SET Marca = 1
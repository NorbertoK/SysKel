/*
   miércoles, 23 de octubre de 201303:05:32 p.m.
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
ALTER TABLE dbo.TablaImportarPadron ADD
	Direccion varchar(200) NULL,
	Telefono varchar(30) NULL,
	AfiliadoPrepago varchar(20) NULL
GO
ALTER TABLE dbo.TablaImportarPadron SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TablaImportarPadron', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TablaImportarPadron', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TablaImportarPadron', 'Object', 'CONTROL') as Contr_Per 
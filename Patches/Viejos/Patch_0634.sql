/*
   jueves, 14 de julio de 201610:23:12 a.m.
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
ALTER TABLE dbo.FacturasProforma
	DROP COLUMN PorcentajeIVA
GO
ALTER TABLE dbo.FacturasProforma SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.FacturasProforma', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.FacturasProforma', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.FacturasProforma', 'Object', 'CONTROL') as Contr_Per 
/*
   lunes, 04 de julio de 201603:17:19 p.m.
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
ALTER TABLE dbo.RenglonesFacturaProforma ADD
	idPorcentajeIVA int NULL
GO
ALTER TABLE dbo.RenglonesFacturaProforma SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.RenglonesFacturaProforma', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.RenglonesFacturaProforma', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.RenglonesFacturaProforma', 'Object', 'CONTROL') as Contr_Per 
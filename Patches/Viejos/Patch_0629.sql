/*
   lunes, 04 de julio de 201603:17:41 p.m.
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
ALTER TABLE dbo.DetallesComprobantes ADD
	idPorcentajeIVA int NULL
GO
ALTER TABLE dbo.DetallesComprobantes
	DROP COLUMN PjeDescuento
GO
ALTER TABLE dbo.DetallesComprobantes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DetallesComprobantes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetallesComprobantes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetallesComprobantes', 'Object', 'CONTROL') as Contr_Per 
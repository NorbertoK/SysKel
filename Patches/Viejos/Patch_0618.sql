/*
   domingo, 03 de julio de 201610:32:38 p.m.
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
CREATE TABLE dbo.PorcentajeIVA
	(
	idPorcentajeIVA int NOT NULL IDENTITY (1, 1),
	CodigoAFIP int NULL,
	PorcentajeIVA money NULL,
	Activo bit NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.PorcentajeIVA SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.PorcentajeIVA', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PorcentajeIVA', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PorcentajeIVA', 'Object', 'CONTROL') as Contr_Per 
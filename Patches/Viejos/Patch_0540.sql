/*
   martes, 29 de septiembre de 20151:15:22 p. m.
   User: 
   Server: NORBERTO
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
ALTER TABLE dbo.Remesas ADD
	idEntidadDeCobranza int NULL
GO
ALTER TABLE dbo.Remesas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Remesas', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Remesas', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Remesas', 'Object', 'CONTROL') as Contr_Per 
/*
   lunes, 08 de octubre de 201207:43:34 p.m.
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
EXECUTE sp_rename N'dbo.Turnos.idTipoDeDecoumento', N'Tmp_idTipoDeDocumento', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.Turnos.Tmp_idTipoDeDocumento', N'idTipoDeDocumento', 'COLUMN' 
GO
ALTER TABLE dbo.Turnos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Turnos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Turnos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Turnos', 'Object', 'CONTROL') as Contr_Per 
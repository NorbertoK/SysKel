/*
   viernes, 09 de noviembre de 201207:16:54 p.m.
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
ALTER TABLE dbo.Turnos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Turnos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Turnos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Turnos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.DiagnosticosPacientes ADD CONSTRAINT
	FK_DiagnosticosPacientes_Turnos FOREIGN KEY
	(
	idTurno
	) REFERENCES dbo.Turnos
	(
	idTurno
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DiagnosticosPacientes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DiagnosticosPacientes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DiagnosticosPacientes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DiagnosticosPacientes', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.MotivosPacientes ADD CONSTRAINT
	FK_MotivosPacientes_Turnos FOREIGN KEY
	(
	idTurno
	) REFERENCES dbo.Turnos
	(
	idTurno
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.MotivosPacientes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MotivosPacientes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MotivosPacientes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MotivosPacientes', 'Object', 'CONTROL') as Contr_Per 
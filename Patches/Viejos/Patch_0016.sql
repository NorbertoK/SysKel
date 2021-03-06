/*
   domingo, 26 de agosto de 201205:37:13 p.m.
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
ALTER TABLE dbo.DiagnosticosPacientes
	DROP CONSTRAINT FK__Diagnosti__idPac__605D434C
GO
ALTER TABLE dbo.Pacientes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Pacientes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Pacientes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Pacientes', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.DiagnosticosPacientes
	DROP CONSTRAINT FK__Diagnosti__idDia__5F691F13
GO
ALTER TABLE dbo.Diagnosticos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Diagnosticos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Diagnosticos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Diagnosticos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_DiagnosticosPacientes
	(
	idDiagnosticoPaciente int NOT NULL IDENTITY (1, 1),
	idDiagnostico int NOT NULL,
	idPaciente int NULL,
	idTurno int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_DiagnosticosPacientes SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_DiagnosticosPacientes ON
GO
IF EXISTS(SELECT * FROM dbo.DiagnosticosPacientes)
	 EXEC('INSERT INTO dbo.Tmp_DiagnosticosPacientes (idDiagnosticoPaciente, idDiagnostico, idPaciente)
		SELECT idDiagnosticoPaciente, idDiagnostico, idPaciente FROM dbo.DiagnosticosPacientes WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_DiagnosticosPacientes OFF
GO
DROP TABLE dbo.DiagnosticosPacientes
GO
EXECUTE sp_rename N'dbo.Tmp_DiagnosticosPacientes', N'DiagnosticosPacientes', 'OBJECT' 
GO
ALTER TABLE dbo.DiagnosticosPacientes ADD CONSTRAINT
	PK__DiagnosticosPaci__511AFFBC PRIMARY KEY CLUSTERED 
	(
	idDiagnosticoPaciente
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.DiagnosticosPacientes ADD CONSTRAINT
	FK__Diagnosti__idDia__5F691F13 FOREIGN KEY
	(
	idDiagnostico
	) REFERENCES dbo.Diagnosticos
	(
	idDiagnostico
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DiagnosticosPacientes ADD CONSTRAINT
	FK__Diagnosti__idPac__605D434C FOREIGN KEY
	(
	idPaciente
	) REFERENCES dbo.Pacientes
	(
	idPaciente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DiagnosticosPacientes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DiagnosticosPacientes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DiagnosticosPacientes', 'Object', 'CONTROL') as Contr_Per 
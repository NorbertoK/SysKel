/*
   domingo, 26 de agosto de 201205:38:45 p.m.
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
ALTER TABLE dbo.MotivosPacientes
	DROP CONSTRAINT FK__MotivosPa__idPac__6EAB62A3
GO
ALTER TABLE dbo.Pacientes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Pacientes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Pacientes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Pacientes', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.MotivosPacientes
	DROP CONSTRAINT FK__MotivosPa__idMot__6DB73E6A
GO
ALTER TABLE dbo.MotivosDeLlamado SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MotivosDeLlamado', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MotivosDeLlamado', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MotivosDeLlamado', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_MotivosPacientes
	(
	idMotivoPaciente int NOT NULL IDENTITY (1, 1),
	idMotivoDeLlamado int NOT NULL,
	idPaciente int NULL,
	Observaciones text NULL,
	idTurno int NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_MotivosPacientes SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_MotivosPacientes ON
GO
IF EXISTS(SELECT * FROM dbo.MotivosPacientes)
	 EXEC('INSERT INTO dbo.Tmp_MotivosPacientes (idMotivoPaciente, idMotivoDeLlamado, idPaciente, Observaciones, idTurno)
		SELECT idMotivoPaciente, idMotivoDeLlamado, idPaciente, Observaciones, idTurno FROM dbo.MotivosPacientes WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_MotivosPacientes OFF
GO
DROP TABLE dbo.MotivosPacientes
GO
EXECUTE sp_rename N'dbo.Tmp_MotivosPacientes', N'MotivosPacientes', 'OBJECT' 
GO
ALTER TABLE dbo.MotivosPacientes ADD CONSTRAINT
	PK__MotivosPacientes__53F76C67 PRIMARY KEY CLUSTERED 
	(
	idMotivoPaciente
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.MotivosPacientes ADD CONSTRAINT
	FK__MotivosPa__idMot__6DB73E6A FOREIGN KEY
	(
	idMotivoDeLlamado
	) REFERENCES dbo.MotivosDeLlamado
	(
	idMotivoDeLlamado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.MotivosPacientes ADD CONSTRAINT
	FK__MotivosPa__idPac__6EAB62A3 FOREIGN KEY
	(
	idPaciente
	) REFERENCES dbo.Pacientes
	(
	idPaciente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MotivosPacientes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MotivosPacientes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MotivosPacientes', 'Object', 'CONTROL') as Contr_Per 
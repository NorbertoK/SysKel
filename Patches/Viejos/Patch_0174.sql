/*
   sábado, 19 de octubre de 201310:13:34 a.m.
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
ALTER TABLE dbo.Turnos
	DROP CONSTRAINT FK_Turnos_Afiliados
GO
ALTER TABLE dbo.Afiliados SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Afiliados', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Afiliados', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Afiliados', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Turnos
	DROP CONSTRAINT FK_Turnos_TiposDeDocumento
GO
ALTER TABLE dbo.TiposDeDocumento SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TiposDeDocumento', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TiposDeDocumento', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TiposDeDocumento', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Turnos
	DROP CONSTRAINT FK_Turnos_Empleados
GO
ALTER TABLE dbo.Empleados SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Turnos
	(
	idTurno int NOT NULL IDENTITY (1, 1),
	idEmpleado int NOT NULL,
	Dia date NOT NULL,
	Hora varchar(5) NOT NULL,
	idTipoDeDocumento int NULL,
	NumeroDeDocumento varchar(20) NULL,
	ApelNomb varchar(100) NULL,
	Telefono varchar(50) NULL,
	Observaciones varchar(MAX) NULL,
	idAfiliado int NULL,
	Solicitado datetime NULL,
	Presente datetime NULL,
	Atendido datetime NULL,
	Terminado datetime NULL,
	Cancelado datetime NULL,
	Evolución varchar(MAX) NULL,
	idMoldeDeTurno int NULL,
	idTomador int NULL,
	idReceptor int NULL,
	DiaDeLaSemana varchar(50) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Turnos SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Turnos ON
GO
IF EXISTS(SELECT * FROM dbo.Turnos)
	 EXEC('INSERT INTO dbo.Tmp_Turnos (idTurno, idEmpleado, Dia, Hora, idTipoDeDocumento, NumeroDeDocumento, ApelNomb, Telefono, Observaciones, idAfiliado, Solicitado, Presente, Atendido, Terminado, Cancelado, Evolución, idMoldeDeTurno, idTomador, idReceptor, DiaDeLaSemana)
		SELECT idTurno, idEmpleado, Dia, Hora, idTipoDeDocumento, NumeroDeDocumento, ApelNomb, Telefono, Observaciones, idAfiliado, Solicitado, Presente, Atendido, Terminado, Cancelado, Evolución, idMoldeDeTurno, idTomador, idReceptor, DiaDeLaSemana FROM dbo.Turnos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Turnos OFF
GO
ALTER TABLE dbo.DiagnosticosPacientes
	DROP CONSTRAINT FK_DiagnosticosPacientes_Turnos
GO
ALTER TABLE dbo.MotivosPacientes
	DROP CONSTRAINT FK_MotivosPacientes_Turnos
GO
DROP TABLE dbo.Turnos
GO
EXECUTE sp_rename N'dbo.Tmp_Turnos', N'Turnos', 'OBJECT' 
GO
ALTER TABLE dbo.Turnos ADD CONSTRAINT
	PK_Turnos PRIMARY KEY CLUSTERED 
	(
	idTurno
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Turnos ADD CONSTRAINT
	FK_Turnos_Empleados FOREIGN KEY
	(
	idEmpleado
	) REFERENCES dbo.Empleados
	(
	idEmpleado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Turnos ADD CONSTRAINT
	FK_Turnos_TiposDeDocumento FOREIGN KEY
	(
	idTipoDeDocumento
	) REFERENCES dbo.TiposDeDocumento
	(
	idTipoDeDocumento
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Turnos ADD CONSTRAINT
	FK_Turnos_Afiliados FOREIGN KEY
	(
	idAfiliado
	) REFERENCES dbo.Afiliados
	(
	idAfiliado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Turnos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Turnos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Turnos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
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
select Has_Perms_By_Name(N'dbo.MotivosPacientes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MotivosPacientes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MotivosPacientes', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
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
select Has_Perms_By_Name(N'dbo.DiagnosticosPacientes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DiagnosticosPacientes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DiagnosticosPacientes', 'Object', 'CONTROL') as Contr_Per 
/*
   domingo, 16 de marzo de 201412:37:57 a.m.
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
ALTER TABLE dbo.Recursos
	DROP CONSTRAINT FK__Recursos__idMovi__7C055DC1
GO
ALTER TABLE dbo.Moviles SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Moviles', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Moviles', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Moviles', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Recursos
	DROP CONSTRAINT FK_Recursos_Empleados
GO
ALTER TABLE dbo.Recursos
	DROP CONSTRAINT FK_Recursos_Empleados1
GO
ALTER TABLE dbo.Recursos
	DROP CONSTRAINT FK_Recursos_Empleados2
GO
ALTER TABLE dbo.Recursos
	DROP CONSTRAINT FK_Recursos_Empleados3
GO
ALTER TABLE dbo.Recursos
	DROP CONSTRAINT FK_Recursos_Empleados4
GO
ALTER TABLE dbo.Recursos
	DROP CONSTRAINT FK_Recursos_Empleados5
GO
ALTER TABLE dbo.Empleados SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Recursos
	(
	idRecurso int NOT NULL IDENTITY (1, 1),
	Nombre varchar(50) NOT NULL,
	idMovil int NULL,
	idMedico int NULL,
	idMedico2 int NULL,
	idParamedico int NULL,
	idParamedico2 int NULL,
	idChofer int NULL,
	idChofer2 int NULL,
	Activo bit NOT NULL,
	Observaciones varchar(MAX) NULL,
	Tripulacion  AS ([dbo].[Tripulacion]([idRecurso]))
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Recursos SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Recursos ON
GO
IF EXISTS(SELECT * FROM dbo.Recursos)
	 EXEC('INSERT INTO dbo.Tmp_Recursos (idRecurso, Nombre, idMovil, idMedico, idMedico2, idParamedico, idParamedico2, idChofer, idChofer2, Activo, Observaciones)
		SELECT idRecurso, Nombre, idMovil, idMedico, idMedico2, idParamedico, idParamedico2, idChofer, idChofer2, Activo, CONVERT(varchar(MAX), Observaciones) FROM dbo.Recursos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Recursos OFF
GO
DROP TABLE dbo.Recursos
GO
EXECUTE sp_rename N'dbo.Tmp_Recursos', N'Recursos', 'OBJECT' 
GO
ALTER TABLE dbo.Recursos ADD CONSTRAINT
	PK__Recursos__59B045BD PRIMARY KEY CLUSTERED 
	(
	idRecurso
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Recursos ADD CONSTRAINT
	FK_Recursos_Empleados FOREIGN KEY
	(
	idMedico
	) REFERENCES dbo.Empleados
	(
	idEmpleado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Recursos ADD CONSTRAINT
	FK_Recursos_Empleados1 FOREIGN KEY
	(
	idMedico2
	) REFERENCES dbo.Empleados
	(
	idEmpleado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Recursos ADD CONSTRAINT
	FK_Recursos_Empleados2 FOREIGN KEY
	(
	idParamedico
	) REFERENCES dbo.Empleados
	(
	idEmpleado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Recursos ADD CONSTRAINT
	FK_Recursos_Empleados3 FOREIGN KEY
	(
	idParamedico2
	) REFERENCES dbo.Empleados
	(
	idEmpleado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Recursos ADD CONSTRAINT
	FK_Recursos_Empleados4 FOREIGN KEY
	(
	idChofer
	) REFERENCES dbo.Empleados
	(
	idEmpleado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Recursos ADD CONSTRAINT
	FK_Recursos_Empleados5 FOREIGN KEY
	(
	idChofer2
	) REFERENCES dbo.Empleados
	(
	idEmpleado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Recursos ADD CONSTRAINT
	FK__Recursos__idMovi__7C055DC1 FOREIGN KEY
	(
	idMovil
	) REFERENCES dbo.Moviles
	(
	idMovil
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Recursos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Recursos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Recursos', 'Object', 'CONTROL') as Contr_Per 
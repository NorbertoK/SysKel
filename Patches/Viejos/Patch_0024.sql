/*
   martes, 25 de septiembre de 201203:03:55 p.m.
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
CREATE TABLE dbo.Tmp_ModesDeTurnos
	(
	idMoldeDeTurno int NOT NULL IDENTITY (1, 1),
	idEmpleado int NOT NULL,
	Lunes bit NOT NULL,
	Martes bit NOT NULL,
	Miercoles bit NOT NULL,
	Jueves bit NOT NULL,
	Viernes bit NOT NULL,
	Sabado bit NOT NULL,
	Domingo bit NOT NULL,
	Semana1 bit NOT NULL,
	Semana2 bit NOT NULL,
	Semana3 bit NOT NULL,
	Semana4 bit NOT NULL,
	Semana5 bit NOT NULL,
	CadaSemanas int NULL,
	DesdeSemanas date NULL,
	De varchar(5) NOT NULL,
	A varchar(5) NOT NULL,
	Minutos int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_ModesDeTurnos SET (LOCK_ESCALATION = TABLE)
GO
DECLARE @v sql_variant 
SET @v = N'Generalmente, el médico.'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'Tmp_ModesDeTurnos', NULL, NULL
GO
SET IDENTITY_INSERT dbo.Tmp_ModesDeTurnos ON
GO
IF EXISTS(SELECT * FROM dbo.ModesDeTurnos)
	 EXEC('INSERT INTO dbo.Tmp_ModesDeTurnos (idMoldeDeTurno, idEmpleado, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo, Semana1, Semana2, Semana3, Semana4, Semana5, CadaSemanas, DesdeSemanas, De, A, Minutos)
		SELECT idMoldeDeTurno, idEmpleado, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo, Semana1, Semana2, Semana3, Semana4, Semana5, CadaSemanas, DesdeSemanas, CONVERT(varchar(5), De), CONVERT(varchar(5), A), Minutos FROM dbo.ModesDeTurnos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_ModesDeTurnos OFF
GO
DROP TABLE dbo.ModesDeTurnos
GO
EXECUTE sp_rename N'dbo.Tmp_ModesDeTurnos', N'ModesDeTurnos', 'OBJECT' 
GO
ALTER TABLE dbo.ModesDeTurnos ADD CONSTRAINT
	PK_ModesDeTurnos PRIMARY KEY CLUSTERED 
	(
	idMoldeDeTurno
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.ModesDeTurnos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ModesDeTurnos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ModesDeTurnos', 'Object', 'CONTROL') as Contr_Per 
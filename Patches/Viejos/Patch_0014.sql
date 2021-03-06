/*
   domingo, 26 de agosto de 201205:19:56 p.m.
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
CREATE TABLE dbo.Turnos
	(
	idTurno int NOT NULL IDENTITY (1, 1),
	idEmpleado int NOT NULL,
	Dia date NOT NULL,
	Hora time(0) NOT NULL,
	idTipoDeDecoumento int NULL,
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
	Evolución varchar(MAX) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Turnos ADD CONSTRAINT
	PK_Turnos PRIMARY KEY CLUSTERED 
	(
	idTurno
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Turnos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Turnos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Turnos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Turnos', 'Object', 'CONTROL') as Contr_Per 
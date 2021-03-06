/*
   domingo, 4 de marzo de 201818:07:20
   User: 
   Server: NORBERTOPC
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
CREATE TABLE dbo.Tmp_AumentosAuto
	(
	idAumentosAuto int NOT NULL IDENTITY (1, 1),
	Fecha datetime NULL,
	Tabla varchar(30) NULL,
	Item varchar(30) NULL,
	Marca bit NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_AumentosAuto SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_AumentosAuto ON
GO
IF EXISTS(SELECT * FROM dbo.AumentosAuto)
	 EXEC('INSERT INTO dbo.Tmp_AumentosAuto (idAumentosAuto, Fecha, Tabla, Item, Marca)
		SELECT idAumentosAuto, Fecha, Tabla, Item, Marca FROM dbo.AumentosAuto WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_AumentosAuto OFF
GO
DROP TABLE dbo.AumentosAuto
GO
EXECUTE sp_rename N'dbo.Tmp_AumentosAuto', N'AumentosAuto', 'OBJECT' 
GO
ALTER TABLE dbo.AumentosAuto ADD CONSTRAINT
	PK_AumentosAuto PRIMARY KEY CLUSTERED 
	(
	idAumentosAuto
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.AumentosAuto', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.AumentosAuto', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.AumentosAuto', 'Object', 'CONTROL') as Contr_Per 
/*
   lunes, 30 de noviembre de 20152:50:41 p. m.
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
CREATE TABLE dbo.Tmp_Rubros
	(
	idRubro int NOT NULL IDENTITY (1, 1),
	Codigo varchar(20) NULL,
	Nombre varchar(100) NULL,
	AdmiteValores bit NULL,
	NombreCompleto  AS Codigo + ' ' + Nombre
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Rubros SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Rubros ON
GO
IF EXISTS(SELECT * FROM dbo.Rubros)
	 EXEC('INSERT INTO dbo.Tmp_Rubros (idRubro, Codigo, Nombre, AdmiteValores)
		SELECT idRubro, Codigo, Nombre, AdmiteValores FROM dbo.Rubros WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Rubros OFF
GO
ALTER TABLE dbo.Compras
	DROP CONSTRAINT FK_Compras_Rubros
GO
DROP TABLE dbo.Rubros
GO
EXECUTE sp_rename N'dbo.Tmp_Rubros', N'Rubros', 'OBJECT' 
GO
ALTER TABLE dbo.Rubros ADD CONSTRAINT
	PK_Rubros PRIMARY KEY CLUSTERED 
	(
	idRubro
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.Rubros', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Rubros', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Rubros', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Compras ADD CONSTRAINT
	FK_Compras_Rubros FOREIGN KEY
	(
	idRubro
	) REFERENCES dbo.Rubros
	(
	idRubro
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Compras SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Compras', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Compras', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Compras', 'Object', 'CONTROL') as Contr_Per 
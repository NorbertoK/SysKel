/*
   viernes, 11 de diciembre de 201511:17:26 a. m.
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
ALTER TABLE dbo.NegociosDelProveedor
	DROP CONSTRAINT FK_NegociosDelProveedor_Negocios
GO
ALTER TABLE dbo.Negocios SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Negocios', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Negocios', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Negocios', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.NegociosDelProveedor
	DROP CONSTRAINT FK_NegociosDelProveedor_Proveedores
GO
ALTER TABLE dbo.Proveedores SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Proveedores', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Proveedores', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Proveedores', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_NegociosDelProveedor
	(
	idNegocioDelProveedor int NOT NULL IDENTITY (1, 1),
	idProveedor int NOT NULL,
	idNegocio int NOT NULL,
	Porcentaje money NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_NegociosDelProveedor SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_NegociosDelProveedor ON
GO
IF EXISTS(SELECT * FROM dbo.NegociosDelProveedor)
	 EXEC('INSERT INTO dbo.Tmp_NegociosDelProveedor (idNegocioDelProveedor, idProveedor, idNegocio, Porcentaje)
		SELECT idNegocioDelProveedor, idProveedor, idNegocio, Porcentaje FROM dbo.NegociosDelProveedor WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_NegociosDelProveedor OFF
GO
DROP TABLE dbo.NegociosDelProveedor
GO
EXECUTE sp_rename N'dbo.Tmp_NegociosDelProveedor', N'NegociosDelProveedor', 'OBJECT' 
GO
ALTER TABLE dbo.NegociosDelProveedor ADD CONSTRAINT
	PK_NegociosDelProveedor PRIMARY KEY CLUSTERED 
	(
	idNegocioDelProveedor
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.NegociosDelProveedor ADD CONSTRAINT
	FK_NegociosDelProveedor_Proveedores FOREIGN KEY
	(
	idProveedor
	) REFERENCES dbo.Proveedores
	(
	idProveedor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.NegociosDelProveedor ADD CONSTRAINT
	FK_NegociosDelProveedor_Negocios FOREIGN KEY
	(
	idNegocio
	) REFERENCES dbo.Negocios
	(
	idNegocio
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.NegociosDelProveedor', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.NegociosDelProveedor', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.NegociosDelProveedor', 'Object', 'CONTROL') as Contr_Per 
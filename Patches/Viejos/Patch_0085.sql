/*
   jueves, 04 de abril de 201310:49:39 a.m.
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
CREATE TABLE dbo.Negocios
	(
	idNegocio int NOT NULL IDENTITY (1, 1),
	Orden int NULL,
	Nombre varchar(100) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Negocios ADD CONSTRAINT
	PK_Negocios PRIMARY KEY CLUSTERED 
	(
	idNegocio
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Negocios SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Negocios', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Negocios', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Negocios', 'Object', 'CONTROL') as Contr_Per 
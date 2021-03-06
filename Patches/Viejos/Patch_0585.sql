/*
   domingo, 29 de noviembre de 20155:30:18 p. m.
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
CREATE TABLE dbo.NegociosDelProveedor
	(
	idNegocioDelProveedor int NOT NULL,
	idProveedor int NOT NULL,
	idNegocio int NOT NULL,
	Porcentaje money NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.NegociosDelProveedor ADD CONSTRAINT
	PK_NegociosDelProveedor PRIMARY KEY CLUSTERED 
	(
	idNegocioDelProveedor
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.NegociosDelProveedor SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.NegociosDelProveedor', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.NegociosDelProveedor', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.NegociosDelProveedor', 'Object', 'CONTROL') as Contr_Per 
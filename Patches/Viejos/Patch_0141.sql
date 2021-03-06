/*
   domingo, 11 de agosto de 201301:49:34 a.m.
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
CREATE TABLE dbo.NegociosCompras
	(
	idNegocioCompra int NOT NULL IDENTITY (1, 1),
	idNegocio int NOT NULL,
	idCompra int NOT NULL,
	Porcentaje money NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.NegociosCompras ADD CONSTRAINT
	PK_NegociosCompras PRIMARY KEY CLUSTERED 
	(
	idNegocioCompra
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.NegociosCompras SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.NegociosCompras', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.NegociosCompras', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.NegociosCompras', 'Object', 'CONTROL') as Contr_Per 
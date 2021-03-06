/*
   viernes, 21 de octubre de 201602:36:03 p.m.
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
CREATE TABLE dbo.LibroDiario
	(
	idLibroDiario int NOT NULL IDENTITY (1, 1),
	idCompra int NULL,
	idRubro int NULL,
	Debe money NULL,
	Haber money NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.LibroDiario ADD CONSTRAINT
	PK_LibroDiario PRIMARY KEY CLUSTERED 
	(
	idLibroDiario
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LibroDiario SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.LibroDiario', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.LibroDiario', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.LibroDiario', 'Object', 'CONTROL') as Contr_Per 
/*
   lunes, 5 de marzo de 201817:07:21
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
CREATE TABLE dbo.AumentosAutoCabecera
	(
	idAumentosAUtoCabecera int NOT NULL IDENTITY (1, 1),
	Fecha datetime NULL,
	Aumento decimal(10, 2) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.AumentosAutoCabecera ADD CONSTRAINT
	PK_AumentosAutoCabecera PRIMARY KEY CLUSTERED 
	(
	idAumentosAUtoCabecera
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.AumentosAutoCabecera SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.AumentosAutoCabecera', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.AumentosAutoCabecera', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.AumentosAutoCabecera', 'Object', 'CONTROL') as Contr_Per 
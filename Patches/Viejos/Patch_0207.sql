/*
   lunes, 25 de noviembre de 201302:45:32 p.m.
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
CREATE TABLE dbo.Emails
	(
	idEmail int NOT NULL IDENTITY (1, 1),
	Email varchar(50) NOT NULL,
	idAfiliado int NULL,
	idContacto int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Emails ADD CONSTRAINT
	PK_Emails PRIMARY KEY CLUSTERED 
	(
	idEmail
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Emails SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Emails', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Emails', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Emails', 'Object', 'CONTROL') as Contr_Per 
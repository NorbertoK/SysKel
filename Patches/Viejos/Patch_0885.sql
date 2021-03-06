/*
   viernes, 2 de marzo de 201812:54:32
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
CREATE TABLE dbo.AumentosAuto
	(
	idAumentosAuto int NOT NULL,
	Fecha datetime NULL,
	Tabla varchar(30) NULL,
	Item varchar(30) NULL,
	Marca bit NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.AumentosAuto ADD CONSTRAINT
	PK_AumentosAuto PRIMARY KEY CLUSTERED 
	(
	idAumentosAuto
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.AumentosAuto SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.AumentosAuto', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.AumentosAuto', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.AumentosAuto', 'Object', 'CONTROL') as Contr_Per 
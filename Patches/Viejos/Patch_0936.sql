/*
   martes, 20 de noviembre de 201812:39:59
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
CREATE TABLE dbo.ImportarCAE
	(
	Poceso varchar(255) NOT NULL,
	idComprobante int NOT NULL,
	idTipoDeComprobante int NOT NULL,
	Prefijo varchar(4) NOT NULL,
	NumeroDeComprobante varchar(8) NOT NULL,
	CAE varchar(14) NOT NULL,
	Fecha date NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.ImportarCAE ADD CONSTRAINT
	PK_ImportarCAE PRIMARY KEY CLUSTERED 
	(
	idComprobante
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.ImportarCAE SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ImportarCAE', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ImportarCAE', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ImportarCAE', 'Object', 'CONTROL') as Contr_Per 
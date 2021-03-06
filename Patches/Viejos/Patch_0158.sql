/*
   miércoles, 02 de octubre de 201304:05:17 p.m.
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
CREATE TABLE dbo.Copagos
	(
	idCopago int NOT NULL IDENTITY (1, 1),
	idCliente int NULL,
	idContrato int NULL,
	idPlan int NULL,
	idTipoDeDestino int NULL,
	idCodigo int NULL,
	idPractica int NULL,
	Importe money NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Copagos ADD CONSTRAINT
	PK_Copagos PRIMARY KEY CLUSTERED 
	(
	idCopago
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Copagos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Copagos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Copagos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Copagos', 'Object', 'CONTROL') as Contr_Per 
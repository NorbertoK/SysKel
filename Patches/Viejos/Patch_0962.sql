/*
   martes, 25 de diciembre de 201820:20:50
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
ALTER TABLE dbo.Copagos
	DROP CONSTRAINT FK_Copagos_Planes
GO
ALTER TABLE dbo.Planes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Planes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Planes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Planes', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Copagos
	DROP CONSTRAINT FK_Copagos_Contratos
GO
ALTER TABLE dbo.Contratos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Contratos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Contratos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Contratos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Copagos
	DROP CONSTRAINT FK_Copagos_Clientes
GO
ALTER TABLE dbo.Clientes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Clientes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Clientes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Clientes', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Copagos
	DROP CONSTRAINT FK_Copagos_TiposDeDestino
GO
ALTER TABLE dbo.TiposDeDestino SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TiposDeDestino', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TiposDeDestino', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TiposDeDestino', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Copagos
	DROP CONSTRAINT FK_Copagos_Practicas
GO
ALTER TABLE dbo.Practicas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Practicas', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Practicas', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Practicas', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Copagos
	(
	idCopago int NOT NULL IDENTITY (1, 1),
	idCliente int NULL,
	idContrato int NULL,
	idPlan int NULL,
	idTipoDeDestino int NULL,
	idCodigo int NULL,
	idPractica int NULL,
	idTipoDeContrato int NULL,
	Importe money NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Copagos SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Copagos ON
GO
IF EXISTS(SELECT * FROM dbo.Copagos)
	 EXEC('INSERT INTO dbo.Tmp_Copagos (idCopago, idCliente, idContrato, idPlan, idTipoDeDestino, idCodigo, idPractica, Importe)
		SELECT idCopago, idCliente, idContrato, idPlan, idTipoDeDestino, idCodigo, idPractica, Importe FROM dbo.Copagos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Copagos OFF
GO
DROP TABLE dbo.Copagos
GO
EXECUTE sp_rename N'dbo.Tmp_Copagos', N'Copagos', 'OBJECT' 
GO
ALTER TABLE dbo.Copagos ADD CONSTRAINT
	PK_Copagos PRIMARY KEY CLUSTERED 
	(
	idCopago
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Copagos WITH NOCHECK ADD CONSTRAINT
	FK_Copagos_Practicas FOREIGN KEY
	(
	idPractica
	) REFERENCES dbo.Practicas
	(
	idPractica
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Copagos WITH NOCHECK ADD CONSTRAINT
	FK_Copagos_TiposDeDestino FOREIGN KEY
	(
	idTipoDeDestino
	) REFERENCES dbo.TiposDeDestino
	(
	idTipoDeDestino
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Copagos ADD CONSTRAINT
	FK_Copagos_Clientes FOREIGN KEY
	(
	idCliente
	) REFERENCES dbo.Clientes
	(
	idCliente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Copagos ADD CONSTRAINT
	FK_Copagos_Contratos FOREIGN KEY
	(
	idContrato
	) REFERENCES dbo.Contratos
	(
	idContrato
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Copagos ADD CONSTRAINT
	FK_Copagos_Planes FOREIGN KEY
	(
	idPlan
	) REFERENCES dbo.Planes
	(
	idPlan
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Copagos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Copagos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Copagos', 'Object', 'CONTROL') as Contr_Per 
/*
   miércoles, 02 de octubre de 201304:22:05 p.m.
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
ALTER TABLE dbo.TiposDeDestino SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TiposDeDestino', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TiposDeDestino', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TiposDeDestino', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Practicas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Practicas', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Practicas', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Practicas', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Planes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Planes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Planes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Planes', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Clientes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Clientes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Clientes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Clientes', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Contratos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Contratos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Contratos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Contratos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
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
	FK_Copagos_Practicas FOREIGN KEY
	(
	idPractica
	) REFERENCES dbo.Practicas
	(
	idPractica
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Copagos ADD CONSTRAINT
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
	FK_Copagos_Planes FOREIGN KEY
	(
	idPlan
	) REFERENCES dbo.Planes
	(
	idPlan
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Copagos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Copagos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Copagos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Copagos', 'Object', 'CONTROL') as Contr_Per 
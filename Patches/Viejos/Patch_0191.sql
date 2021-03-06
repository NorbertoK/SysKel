/*
   jueves, 31 de octubre de 201301:22:48 a.m.
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
--ALTER TABLE dbo.Direcciones
--	DROP CONSTRAINT FK__Direccion__idCal__4B2D1C3C
--GO
--ALTER TABLE dbo.Direcciones
--	DROP CONSTRAINT FK__Direccion__idCal__6CE315C2
--GO
ALTER TABLE dbo.Direcciones
	DROP CONSTRAINT FK__Direccion__idEnt__4C214075
GO
ALTER TABLE dbo.Direcciones
	DROP CONSTRAINT FK__Direccion__idEnt__4D1564AE
GO
ALTER TABLE dbo.Direcciones
	DROP CONSTRAINT FK__Direccion__idEnt__6ECB5E34
GO
ALTER TABLE dbo.Direcciones
	DROP CONSTRAINT FK__Direccion__idEnt__6FBF826D
GO
ALTER TABLE dbo.Calles SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Calles', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Calles', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Calles', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Afiliados SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Afiliados', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Afiliados', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Afiliados', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Direcciones ADD CONSTRAINT
	FK_Direcciones_Afiliados FOREIGN KEY
	(
	idAfiliado
	) REFERENCES dbo.Afiliados
	(
	idAfiliado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Direcciones ADD CONSTRAINT
	FK_Direcciones_Calles FOREIGN KEY
	(
	idCalle
	) REFERENCES dbo.Calles
	(
	idCalle
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Direcciones ADD CONSTRAINT
	FK_Direcciones_Calles1 FOREIGN KEY
	(
	idEntreCalle1
	) REFERENCES dbo.Calles
	(
	idCalle
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Direcciones ADD CONSTRAINT
	FK_Direcciones_Calles2 FOREIGN KEY
	(
	idEntreCalle2
	) REFERENCES dbo.Calles
	(
	idCalle
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Direcciones SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Direcciones', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Direcciones', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Direcciones', 'Object', 'CONTROL') as Contr_Per 
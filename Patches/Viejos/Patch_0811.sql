/*
   jueves, 16 de febrero de 201711:39:27 a.m.
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
ALTER TABLE dbo.Empleados
	DROP CONSTRAINT FK_Empleados_Prestadores
GO
ALTER TABLE dbo.Prestadores SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Prestadores', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Prestadores', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Prestadores', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Bancos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Bancos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Bancos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Bancos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Rubros SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Rubros', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Rubros', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Rubros', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Empleados ADD CONSTRAINT
	FK_Empleados_Prestadores FOREIGN KEY
	(
	idPrestador
	) REFERENCES dbo.Prestadores
	(
	idPrestador
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Empleados ADD CONSTRAINT
	FK_Empleados_Rubros FOREIGN KEY
	(
	Cuenta
	) REFERENCES dbo.Rubros
	(
	idRubro
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Empleados ADD CONSTRAINT
	FK_Empleados_Bancos FOREIGN KEY
	(
	idBanco
	) REFERENCES dbo.Bancos
	(
	idBanco
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Empleados SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'CONTROL') as Contr_Per 
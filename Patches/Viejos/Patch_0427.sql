/*
   martes, 24 de febrero de 201512:18:12 p.m.
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
ALTER TABLE dbo.Empleados SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Cargos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Cargos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Cargos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Cargos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.CargosEmpleados ADD CONSTRAINT
	FK_CargosEmpleados_Empleados FOREIGN KEY
	(
	idEmpleado
	) REFERENCES dbo.Empleados
	(
	idEmpleado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.CargosEmpleados ADD CONSTRAINT
	FK_CargosEmpleados_Cargos FOREIGN KEY
	(
	idCargo
	) REFERENCES dbo.Cargos
	(
	idCargo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.CargosEmpleados SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CargosEmpleados', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CargosEmpleados', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CargosEmpleados', 'Object', 'CONTROL') as Contr_Per 
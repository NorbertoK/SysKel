/*
   viernes, 21 de octubre de 201603:12:58 p.m.
   User: 
   Server: (local)
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
ALTER TABLE dbo.PorcentajeIVA SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.PorcentajeIVA', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PorcentajeIVA', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PorcentajeIVA', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Compras
	DROP CONSTRAINT FK_Compras_TiposDeComprobante
GO
ALTER TABLE dbo.TiposDeComprobante SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TiposDeComprobante', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TiposDeComprobante', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TiposDeComprobante', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Compras
	DROP CONSTRAINT FK__Pagos__idGrabado__6581EB1C
GO
ALTER TABLE dbo.Usuarios SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Usuarios', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Usuarios', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Usuarios', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.CategoriasIVA SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CategoriasIVA', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CategoriasIVA', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CategoriasIVA', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Rubros SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Rubros', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Rubros', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Rubros', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Compras
	DROP CONSTRAINT FK__Pagos__idProveed__648DC6E3
GO
ALTER TABLE dbo.Proveedores ADD CONSTRAINT
	FK_Proveedores_Rubros FOREIGN KEY
	(
	idRubro
	) REFERENCES dbo.Rubros
	(
	idRubro
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Proveedores ADD CONSTRAINT
	FK_Proveedores_Rubros1 FOREIGN KEY
	(
	idCuenta
	) REFERENCES dbo.Rubros
	(
	idRubro
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

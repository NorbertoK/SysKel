/*
   lunes, 19 de diciembre de 201606:22:08 p.m.
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
EXECUTE sp_rename N'dbo.OrdenesDePago.idCaja', N'Tmp_idEmpleado', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.OrdenesDePago.Tmp_idEmpleado', N'idEmpleado', 'COLUMN' 
GO
ALTER TABLE dbo.OrdenesDePago SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.OrdenesDePago', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.OrdenesDePago', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.OrdenesDePago', 'Object', 'CONTROL') as Contr_Per 
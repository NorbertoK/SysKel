/*
   martes, 23 de febrero de 20168:09:07 p. m.
   User: 
   Server: NORBERTO
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
ALTER TABLE dbo.Proveedores ADD
	Serie varchar(1) NULL
GO
ALTER TABLE dbo.Proveedores
	DROP COLUMN idCategoriaIva, EmiteFacturas
GO
ALTER TABLE dbo.Proveedores SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Proveedores', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Proveedores', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Proveedores', 'Object', 'CONTROL') as Contr_Per 
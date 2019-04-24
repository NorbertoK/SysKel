/*
   lunes, 10 de octubre de 201609:47:14 p.m.
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
ALTER TABLE dbo.SolicitudesCAE
	DROP COLUMN Excepcion
GO
ALTER TABLE dbo.SolicitudesCAE SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.SolicitudesCAE', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.SolicitudesCAE', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.SolicitudesCAE', 'Object', 'CONTROL') as Contr_Per 
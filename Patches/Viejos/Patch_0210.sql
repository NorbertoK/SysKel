/*
   sábado, 30 de noviembre de 201312:19:42 p.m.
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
ALTER TABLE dbo.PuntosDeVenta ADD
	UltimoNumeroAsignadoA int NULL,
	UltimoNumeroAsignadoB int NULL
GO
ALTER TABLE dbo.PuntosDeVenta SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.PuntosDeVenta', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PuntosDeVenta', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PuntosDeVenta', 'Object', 'CONTROL') as Contr_Per 
/*
   domingo, 19 de marzo de 201709:35:20 p.m.
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
EXECUTE sp_rename N'dbo.Compras.idOrdenDeCompra', N'Tmp_idOrdenDePago', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.Compras.Tmp_idOrdenDePago', N'idOrdenDePago', 'COLUMN' 
GO
ALTER TABLE dbo.Compras SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Compras', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Compras', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Compras', 'Object', 'CONTROL') as Contr_Per 
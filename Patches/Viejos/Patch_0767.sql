/*
   sábado, 19 de noviembre de 201611:12:36 a.m.
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
EXECUTE sp_rename N'dbo.ComprobantesOrdenesDePago.idPago', N'Tmp_idOrdenDePago_2', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.ComprobantesOrdenesDePago.Tmp_idOrdenDePago_2', N'idOrdenDePago', 'COLUMN' 
GO
ALTER TABLE dbo.ComprobantesOrdenesDePago SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ComprobantesOrdenesDePago', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ComprobantesOrdenesDePago', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ComprobantesOrdenesDePago', 'Object', 'CONTROL') as Contr_Per 
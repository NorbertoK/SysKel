/*
   jueves, 13 de marzo de 201410:30:18 a.m.
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
CREATE TABLE dbo.Hist_RenglonesFacturaProforma
	(
	idHist_RenglonesFacturaProforma int NOT NULL IDENTITY (1, 1),
	idRenglonFacturaProforma int NULL,
	idContrato_anterior int NULL,
	idContrato_nuevo int NULL,
	idPlan_anterior int NULL,
	idPlan_nuevo int NULL,
	Cantidad_anterior int NULL,
	Cantidad_nuevo int NULL,
	PrecioUnitario_anterior money NULL,
	PrecioUnitario_nuevo money NULL,
	RevisarMensualmente_anterior bit NULL,
	RevisarMensualmente_nuevo bit NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Hist_RenglonesFacturaProforma ADD CONSTRAINT
	PK_Hist_RenglonesFacturaProforma PRIMARY KEY CLUSTERED 
	(
	idHist_RenglonesFacturaProforma
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Hist_RenglonesFacturaProforma SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Hist_RenglonesFacturaProforma', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Hist_RenglonesFacturaProforma', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Hist_RenglonesFacturaProforma', 'Object', 'CONTROL') as Contr_Per 
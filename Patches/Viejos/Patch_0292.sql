/*
   jueves, 13 de marzo de 201403:32:00 p.m.
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
CREATE TABLE dbo.Tmp_Hist_RenglonesFacturaProforma
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
	RevisarMensualmente_nuevo bit NULL,
	Fecha datetime NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Hist_RenglonesFacturaProforma SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Hist_RenglonesFacturaProforma ON
GO
IF EXISTS(SELECT * FROM dbo.Hist_RenglonesFacturaProforma)
	 EXEC('INSERT INTO dbo.Tmp_Hist_RenglonesFacturaProforma (idHist_RenglonesFacturaProforma, idRenglonFacturaProforma, idContrato_anterior, idContrato_nuevo, idPlan_anterior, idPlan_nuevo, Cantidad_anterior, Cantidad_nuevo, PrecioUnitario_anterior, PrecioUnitario_nuevo, RevisarMensualmente_anterior, RevisarMensualmente_nuevo, Fecha)
		SELECT idHist_RenglonesFacturaProforma, idRenglonFacturaProforma, idContrato_anterior, idContrato_nuevo, idPlan_anterior, idPlan_nuevo, Cantidad_anterior, Cantidad_nuevo, PrecioUnitario_anterior, PrecioUnitario_nuevo, RevisarMensualmente_anterior, RevisarMensualmente_nuevo, CONVERT(datetime, Fecha) FROM dbo.Hist_RenglonesFacturaProforma WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Hist_RenglonesFacturaProforma OFF
GO
DROP TABLE dbo.Hist_RenglonesFacturaProforma
GO
EXECUTE sp_rename N'dbo.Tmp_Hist_RenglonesFacturaProforma', N'Hist_RenglonesFacturaProforma', 'OBJECT' 
GO
ALTER TABLE dbo.Hist_RenglonesFacturaProforma ADD CONSTRAINT
	PK_Hist_RenglonesFacturaProforma PRIMARY KEY CLUSTERED 
	(
	idHist_RenglonesFacturaProforma
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.Hist_RenglonesFacturaProforma', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Hist_RenglonesFacturaProforma', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Hist_RenglonesFacturaProforma', 'Object', 'CONTROL') as Contr_Per 
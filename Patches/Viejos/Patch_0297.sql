/*
   domingo, 16 de marzo de 201412:20:17 a.m.
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
CREATE TABLE dbo.Hist_Planes
	(
	idHist_Planes int NOT NULL IDENTITY (1, 1),
	idPlan int NULL,
	Nombre_anterior varchar(50) NULL,
	Nombre_nuevo varchar(50) NULL,
	Iniciales_anterior varchar(10) NULL,
	Iniciales_nuevo varchar(10) NULL,
	idCotrato_anterior int NULL,
	idContrato_nuevo int NULL,
	Cuota_anterior money NULL,
	Cuota_nuevo money NULL,
	Activo_anterior bit NULL,
	Activo_nuevo bit NULL,
	PadronExterno_anterior bit NULL,
	PadronExterno_nuevo bit NULL,
	idProteccion_anterior int NULL,
	idProteccion_nuevo int NULL,
	CuotaAdherente_anterior money NULL,
	CuotaAdherente_nuevo money NULL,
	idPrepago_anterior int NULL,
	idPrepago_nuevo int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Hist_Planes ADD CONSTRAINT
	PK_Hist_Planes PRIMARY KEY CLUSTERED 
	(
	idHist_Planes
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Hist_Planes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Hist_Planes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Hist_Planes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Hist_Planes', 'Object', 'CONTROL') as Contr_Per 
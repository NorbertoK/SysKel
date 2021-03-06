/*
   domingo, 16 de marzo de 201412:38:57 a.m.
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
CREATE TABLE dbo.Hist_Recursos
	(
	idHist_Recursos int NOT NULL IDENTITY (1, 1),
	idRecurso int NULL,
	Nombre_anterior varchar(50) NULL,
	Nombre_nuevo varchar(50) NULL,
	idMovil_anterior int NULL,
	idMovil_nuevo int NULL,
	idMedico_anterior int NULL,
	idMedico_nuevo int NULL,
	idMedico2_anterior int NULL,
	idMedico2_nuevo int NULL,
	idParamedico_anterior int NULL,
	IdParamedico_nuevo int NULL,
	idParamedico2_anterior int NULL,
	idParamedico2_nuevo int NULL,
	idChofer_anterior int NULL,
	idChofer_nuevo int NULL,
	idChofer2_anterior int NULL,
	idChofer2_nuevo int NULL,
	Activo_anterior bit NULL,
	Activo_nuevo bit NULL,
	Observaciones_anterior varchar(MAX) NULL,
	Observaciones_nuevo varchar(MAX) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Hist_Recursos ADD CONSTRAINT
	PK_Hist_Recursos PRIMARY KEY CLUSTERED 
	(
	idHist_Recursos
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Hist_Recursos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Hist_Recursos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Hist_Recursos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Hist_Recursos', 'Object', 'CONTROL') as Contr_Per 
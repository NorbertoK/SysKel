/*
   miércoles, 10 de abril de 201918:35:25
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
ALTER TABLE dbo.PuntosDeVenta
	DROP CONSTRAINT DF_PuntosDeVenta_UltimoNumeroAsignado
GO
CREATE TABLE dbo.Tmp_PuntosDeVenta
	(
	idPuntoDeVenta int NOT NULL IDENTITY (1, 1),
	Prefijo varchar(4) NOT NULL,
	Observaciones varchar(MAX) NOT NULL,
	UltimoNumeroAsignado int NULL,
	UltimoNumeroAsignadoA int NULL,
	UltimoNumeroAsignadoB int NULL,
	Verdadero bit NULL,
	UltimoNumeroAsignacoNdeCA int NULL,
	UltimoNumeroAsignacoNdeDA int NULL,
	UltimoNumeroAsignacoNdeCB int NULL,
	UltimoNumeroAsignacoNdeDB int NULL,
	SolicitaCAE int NULL,
	UltimoNumeroAsignadoM int NULL,
	UltimoNumeroAsignacoNdeCM int NULL,
	UltimoNumeroAsignacoNdeDM int NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_PuntosDeVenta SET (LOCK_ESCALATION = TABLE)
GO
ALTER TABLE dbo.Tmp_PuntosDeVenta ADD CONSTRAINT
	DF_PuntosDeVenta_UltimoNumeroAsignado DEFAULT ((0)) FOR UltimoNumeroAsignado
GO
SET IDENTITY_INSERT dbo.Tmp_PuntosDeVenta ON
GO
IF EXISTS(SELECT * FROM dbo.PuntosDeVenta)
	 EXEC('INSERT INTO dbo.Tmp_PuntosDeVenta (idPuntoDeVenta, Prefijo, Observaciones, UltimoNumeroAsignado, UltimoNumeroAsignadoA, UltimoNumeroAsignadoB, Verdadero, UltimoNumeroAsignacoNdeCA, UltimoNumeroAsignacoNdeDA, UltimoNumeroAsignacoNdeCB, UltimoNumeroAsignacoNdeDB, SolicitaCAE, UltimoNumeroAsignadoM, UltimoNumeroAsignacoNdeCM, UltimoNumeroAsignacoNdeDM)
		SELECT idPuntoDeVenta, Prefijo, Observaciones, UltimoNumeroAsignado, UltimoNumeroAsignadoA, UltimoNumeroAsignadoB, Verdadero, UltimoNumeroAsignacoNdeCA, UltimoNumeroAsignacoNdeDA, UltimoNumeroAsignacoNdeCB, UltimoNumeroAsignacoNdeDB, CONVERT(int, SolicitaCAE), UltimoNumeroAsignadoM, UltimoNumeroAsignacoNdeCM, UltimoNumeroAsignacoNdeDM FROM dbo.PuntosDeVenta WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_PuntosDeVenta OFF
GO
ALTER TABLE dbo.Zonas
	DROP CONSTRAINT FK_Zonas_PuntosDeVenta
GO
DROP TABLE dbo.PuntosDeVenta
GO
EXECUTE sp_rename N'dbo.Tmp_PuntosDeVenta', N'PuntosDeVenta', 'OBJECT' 
GO
ALTER TABLE dbo.PuntosDeVenta ADD CONSTRAINT
	PK_PuntosDeVenta PRIMARY KEY CLUSTERED 
	(
	idPuntoDeVenta
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.PuntosDeVenta', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PuntosDeVenta', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PuntosDeVenta', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Zonas ADD CONSTRAINT
	FK_Zonas_PuntosDeVenta FOREIGN KEY
	(
	idPuntoDeVenta
	) REFERENCES dbo.PuntosDeVenta
	(
	idPuntoDeVenta
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Zonas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Zonas', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Zonas', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Zonas', 'Object', 'CONTROL') as Contr_Per 
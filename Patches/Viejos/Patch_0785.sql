/*
   jueves, 15 de diciembre de 201602:01:06 p.m.
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
ALTER TABLE dbo.TiposDeValores
	DROP CONSTRAINT DF_TiposDeValores_RequiereBanco
GO
ALTER TABLE dbo.TiposDeValores
	DROP CONSTRAINT DF_TiposDeValores_EsEfectivo
GO
CREATE TABLE dbo.Tmp_TiposDeValores
	(
	idTipoDeValor int NOT NULL IDENTITY (1, 1),
	Nombre varchar(50) NOT NULL,
	RequiereBanco bit NOT NULL,
	EsEfectivo bit NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_TiposDeValores SET (LOCK_ESCALATION = TABLE)
GO
ALTER TABLE dbo.Tmp_TiposDeValores ADD CONSTRAINT
	DF_TiposDeValores_RequiereBanco DEFAULT ((0)) FOR RequiereBanco
GO
ALTER TABLE dbo.Tmp_TiposDeValores ADD CONSTRAINT
	DF_TiposDeValores_EsEfectivo DEFAULT ((0)) FOR EsEfectivo
GO
SET IDENTITY_INSERT dbo.Tmp_TiposDeValores ON
GO
IF EXISTS(SELECT * FROM dbo.TiposDeValores)
	 EXEC('INSERT INTO dbo.Tmp_TiposDeValores (idTipoDeValor, Nombre, RequiereBanco, EsEfectivo)
		SELECT idTipoDeValor, Nombre, RequiereBanco, CONVERT(bit, EsEfectivo) FROM dbo.TiposDeValores WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_TiposDeValores OFF
GO
ALTER TABLE dbo.ValoresTransferencias
	DROP CONSTRAINT FK__ValoresTr__idTip__6A46A039
GO
ALTER TABLE dbo.ValoresRemesas
	DROP CONSTRAINT FK_ValoresRemesas_TiposDeValores
GO
DROP TABLE dbo.TiposDeValores
GO
EXECUTE sp_rename N'dbo.Tmp_TiposDeValores', N'TiposDeValores', 'OBJECT' 
GO
ALTER TABLE dbo.TiposDeValores ADD CONSTRAINT
	PK_TiposDeValores PRIMARY KEY CLUSTERED 
	(
	idTipoDeValor
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.TiposDeValores', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TiposDeValores', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TiposDeValores', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ValoresRemesas WITH NOCHECK ADD CONSTRAINT
	FK_ValoresRemesas_TiposDeValores FOREIGN KEY
	(
	idTipoDeValor
	) REFERENCES dbo.TiposDeValores
	(
	idTipoDeValor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ValoresRemesas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ValoresRemesas', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ValoresRemesas', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ValoresRemesas', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ValoresTransferencias WITH NOCHECK ADD CONSTRAINT
	FK__ValoresTr__idTip__6A46A039 FOREIGN KEY
	(
	idTipoDeValor
	) REFERENCES dbo.TiposDeValores
	(
	idTipoDeValor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ValoresTransferencias SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ValoresTransferencias', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ValoresTransferencias', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ValoresTransferencias', 'Object', 'CONTROL') as Contr_Per 
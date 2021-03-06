/*
   domingo, 06 de abril de 201403:53:52 p.m.
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
ALTER TABLE dbo.Grupos
	DROP CONSTRAINT FK_Grupos_TiposDeCobranza
GO
ALTER TABLE dbo.TiposDeCobranza SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TiposDeCobranza', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TiposDeCobranza', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TiposDeCobranza', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Grupos
	DROP CONSTRAINT FK_Grupos_EntidadesDeCobranza
GO
ALTER TABLE dbo.EntidadesDeCobranza SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.EntidadesDeCobranza', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.EntidadesDeCobranza', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.EntidadesDeCobranza', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Grupos
	DROP CONSTRAINT FK_Grupos_CategoriasIVA
GO
ALTER TABLE dbo.CategoriasIVA SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CategoriasIVA', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CategoriasIVA', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CategoriasIVA', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Grupos
	(
	idGrupo int NOT NULL IDENTITY (1, 1),
	idTipoDeCobranza int NOT NULL,
	idEntidadDeCobranza int NULL,
	NumeroTarjeta varchar(30) NULL,
	VencimientoTarjeta smalldatetime NULL,
	idGrabador int NULL,
	idUltimoModificador int NULL,
	NombreTitularTarjeta varchar(50) NULL,
	NumeroDocumentoTitularTarjeta varchar(20) NULL,
	TelefonoTitularTarjeta varchar(20) NULL,
	Activo bit NULL,
	Importe money NULL,
	idCategoriaIVA int NOT NULL,
	CUIT varchar(11) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Grupos SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Grupos ON
GO
IF EXISTS(SELECT * FROM dbo.Grupos)
	 EXEC('INSERT INTO dbo.Tmp_Grupos (idGrupo, idTipoDeCobranza, idEntidadDeCobranza, NumeroTarjeta, VencimientoTarjeta, idGrabador, idUltimoModificador, NombreTitularTarjeta, NumeroDocumentoTitularTarjeta, TelefonoTitularTarjeta, Activo, Importe, idCategoriaIVA, CUIT)
		SELECT idGrupo, idTipoDeCobranza, idEntidadDeCobranza, NumeroTarjeta, VencimientoTarjeta, idGrabador, idUltimoModificador, NombreTitularTarjeta, NumeroDocumentoTitularTarjeta, TelefonoTitularTarjeta, Activo, Importe, idCategoriaIVA, CUIT FROM dbo.Grupos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Grupos OFF
GO
ALTER TABLE dbo.Contactos
	DROP CONSTRAINT FK_Contactos_Grupos
GO
ALTER TABLE dbo.Afiliados
	DROP CONSTRAINT FK_Afiliados_Grupos
GO
ALTER TABLE dbo.Direcciones
	DROP CONSTRAINT FK__Direccion__idGru__4EFDAD20
GO
ALTER TABLE dbo.Direcciones
	DROP CONSTRAINT FK__Direccion__idGru__70B3A6A6
GO
ALTER TABLE dbo.Comprobantes
	DROP CONSTRAINT FK_Comprobantes_Grupos
GO
DROP TABLE dbo.Grupos
GO
EXECUTE sp_rename N'dbo.Tmp_Grupos', N'Grupos', 'OBJECT' 
GO
ALTER TABLE dbo.Grupos ADD CONSTRAINT
	PK_Grupos PRIMARY KEY CLUSTERED 
	(
	idGrupo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX _dta_index_Grupos_7_1623676832__K1 ON dbo.Grupos
	(
	idGrupo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE dbo.Grupos ADD CONSTRAINT
	FK_Grupos_CategoriasIVA FOREIGN KEY
	(
	idCategoriaIVA
	) REFERENCES dbo.CategoriasIVA
	(
	idCategoriaIVA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Grupos ADD CONSTRAINT
	FK_Grupos_EntidadesDeCobranza FOREIGN KEY
	(
	idEntidadDeCobranza
	) REFERENCES dbo.EntidadesDeCobranza
	(
	idEntidadDeCobranza
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Grupos ADD CONSTRAINT
	FK_Grupos_TiposDeCobranza FOREIGN KEY
	(
	idTipoDeCobranza
	) REFERENCES dbo.TiposDeCobranza
	(
	idTipoDeCobranza
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Grupos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Grupos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Grupos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Comprobantes ADD CONSTRAINT
	FK_Comprobantes_Grupos FOREIGN KEY
	(
	idGrupo
	) REFERENCES dbo.Grupos
	(
	idGrupo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Comprobantes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Comprobantes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Comprobantes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Comprobantes', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Direcciones ADD CONSTRAINT
	FK__Direccion__idGru__4EFDAD20 FOREIGN KEY
	(
	idGrupo
	) REFERENCES dbo.Grupos
	(
	idGrupo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Direcciones ADD CONSTRAINT
	FK__Direccion__idGru__70B3A6A6 FOREIGN KEY
	(
	idGrupo
	) REFERENCES dbo.Grupos
	(
	idGrupo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Direcciones SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Direcciones', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Direcciones', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Direcciones', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Afiliados ADD CONSTRAINT
	FK_Afiliados_Grupos FOREIGN KEY
	(
	idGrupo
	) REFERENCES dbo.Grupos
	(
	idGrupo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Afiliados SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Afiliados', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Afiliados', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Afiliados', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Contactos ADD CONSTRAINT
	FK_Contactos_Grupos FOREIGN KEY
	(
	idGrupo
	) REFERENCES dbo.Grupos
	(
	idGrupo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Contactos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Contactos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Contactos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Contactos', 'Object', 'CONTROL') as Contr_Per 
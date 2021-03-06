/*
   miércoles, 24 de abril de 201309:07:13 p.m.
   User: 
   Server: NORBERTO
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
ALTER TABLE dbo.ComprobantesPagos
	DROP CONSTRAINT FK_ComprobantesPagos_Pagos
GO
ALTER TABLE dbo.Pagos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Pagos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Pagos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Pagos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_ComprobantesPagos
	(
	idComprobantePago int NOT NULL IDENTITY (1, 1),
	idPago int NOT NULL,
	idCompra int NOT NULL,
	ImporteCompra  AS dbo.ImporteCompra(idCompra),
	ImportePagado money NULL,
	Observaciones varchar(MAX) NULL,
	FechaCompra  AS dbo.FechaCompra(idCompra),
	ComprobanteCompra  AS dbo.ComprobanteCompra(idCompra)
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_ComprobantesPagos SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_ComprobantesPagos ON
GO
IF EXISTS(SELECT * FROM dbo.ComprobantesPagos)
	 EXEC('INSERT INTO dbo.Tmp_ComprobantesPagos (idComprobantePago, idPago, idCompra, ImportePagado, Observaciones)
		SELECT idComprobantePago, idPago, idComprobante, ImportePagado, Observaciones FROM dbo.ComprobantesPagos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_ComprobantesPagos OFF
GO
DROP TABLE dbo.ComprobantesPagos
GO
EXECUTE sp_rename N'dbo.Tmp_ComprobantesPagos', N'ComprobantesPagos', 'OBJECT' 
GO
ALTER TABLE dbo.ComprobantesPagos ADD CONSTRAINT
	PK_ComprobantesPagos PRIMARY KEY CLUSTERED 
	(
	idComprobantePago
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.ComprobantesPagos ADD CONSTRAINT
	FK_ComprobantesPagos_Pagos FOREIGN KEY
	(
	idPago
	) REFERENCES dbo.Pagos
	(
	idPago
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ComprobantesPagos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ComprobantesPagos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ComprobantesPagos', 'Object', 'CONTROL') as Contr_Per 
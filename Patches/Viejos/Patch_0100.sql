/*
   viernes, 26 de abril de 201301:46:33 a.m.
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
CREATE TABLE dbo.Tmp_ValoresRetiros
	(
	idValorRetiro int NOT NULL IDENTITY (1, 1),
	idRetiro int NULL,
	idPago int NULL,
	idValorRemesa int NULL,
	idTipoDeValor int NULL,
	Importe money NULL,
	idBanco int NULL,
	NumeroDeCheque varchar(15) NULL,
	Vencimiento datetime NULL,
	NumeroPropio int NULL,
	Observaciones varchar(MAX) NULL,
	Transferido bit NULL,
	ImporteTransferido money NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_ValoresRetiros SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_ValoresRetiros ON
GO
IF EXISTS(SELECT * FROM dbo.ValoresRetiros)
	 EXEC('INSERT INTO dbo.Tmp_ValoresRetiros (idValorRetiro, idRetiro, idValorRemesa, idTipoDeValor, Importe, idBanco, NumeroDeCheque, Vencimiento, NumeroPropio, Observaciones, Transferido, ImporteTransferido)
		SELECT idValorRetiro, idRetiro, idValorRemesa, idTipoDeValor, Importe, idBanco, NumeroDeCheque, Vencimiento, NumeroPropio, Observaciones, Transferido, ImporteTransferido FROM dbo.ValoresRetiros WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_ValoresRetiros OFF
GO
DROP TABLE dbo.ValoresRetiros
GO
EXECUTE sp_rename N'dbo.Tmp_ValoresRetiros', N'ValoresRetiros', 'OBJECT' 
GO
ALTER TABLE dbo.ValoresRetiros ADD CONSTRAINT
	PK_ValoresRetiros PRIMARY KEY CLUSTERED 
	(
	idValorRetiro
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.ValoresRetiros', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ValoresRetiros', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ValoresRetiros', 'Object', 'CONTROL') as Contr_Per 
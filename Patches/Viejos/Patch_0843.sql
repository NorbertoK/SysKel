/*
   jueves, 27 de abril de 201705:56:47 p.m.
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
CREATE TABLE dbo.Tmp_Parametros
	(
	idParametro int NOT NULL IDENTITY (1, 1),
	DesdeDiaRegaloMes int NULL,
	DiasDeCarencia int NULL,
	MesesImpagosBaja int NULL,
	UltimoNumeroDePrestacion int NULL,
	MedicoVeEvolucionOtrosMedicos int NULL,
	MascaraRubros varchar(20) NULL,
	CerrarPrestacionesSinDiagnostico bit NULL,
	OcultaFacturasAnuladas bit NULL,
	RefrescoPrestaciones int NULL,
	RefrescoPrestacionesMouse int NULL,
	Token varchar(MAX) NULL,
	Sign_ varchar(MAX) NULL,
	VigenciaTokenSign datetime NULL,
	IVAAfiliados int NULL,
	UsaNegocios bit NULL,
	ProveedoresDuplicados bit NULL,
	UltimoNumeroDeRecibo int NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Parametros SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Parametros ON
GO
IF EXISTS(SELECT * FROM dbo.Parametros)
	 EXEC('INSERT INTO dbo.Tmp_Parametros (idParametro, DesdeDiaRegaloMes, DiasDeCarencia, MesesImpagosBaja, UltimoNumeroDePrestacion, MedicoVeEvolucionOtrosMedicos, MascaraRubros, CerrarPrestacionesSinDiagnostico, OcultaFacturasAnuladas, RefrescoPrestaciones, RefrescoPrestacionesMouse, Token, Sign_, VigenciaTokenSign, IVAAfiliados, UsaNegocios, ProveedoresDuplicados, UltimoNumeroDeRecibo)
		SELECT idParametro, DesdeDiaRegaloMes, DiasDeCarencia, MesesImpagosBaja, UltimoNumeroDePrestacion, MedicoVeEvolucionOtrosMedicos, MascaraRubros, CerrarPrestacionesSinDiagnostico, OcultaFacturasAnuladas, RefrescoPrestaciones, RefrescoPrestacionesMouse, Token, Sign_, VigenciaTokenSign, CONVERT(int, IVAAfiliados), UsaNegocios, ProveedoresDuplicados, UltimoNumeroDeRecibo FROM dbo.Parametros WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Parametros OFF
GO
DROP TABLE dbo.Parametros
GO
EXECUTE sp_rename N'dbo.Tmp_Parametros', N'Parametros', 'OBJECT' 
GO
ALTER TABLE dbo.Parametros ADD CONSTRAINT
	PK_AutoComprobantes PRIMARY KEY CLUSTERED 
	(
	idParametro
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.Parametros', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Parametros', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Parametros', 'Object', 'CONTROL') as Contr_Per 
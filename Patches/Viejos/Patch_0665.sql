/*
   jueves, 28 de julio de 201612:59:41 p.m.
   User: 
   Server: (local)
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
CREATE TABLE dbo.SolicitudesCAE
	(
	idSolictudCAE int NOT NULL IDENTITY (1, 1),
	Fecha date NULL,
	idComprobante int NULL,
	Error varchar(MAX) NULL,
	Pedido xml NULL,
	Respuesta xml NULL,
	Resultado varchar(1) NULL,
	CAE varchar(14) NULL,
	NumeroDeComprobante varchar(8) NULL,
	Reprocesar bit NULL,
	Reproceso bit NULL,
	Errores varchar(MAX) NULL,
	Observaciones varchar(MAX) NULL,
	Traceback varchar(MAX) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.SolicitudesCAE ADD CONSTRAINT
	PK_SolicitudesCAE PRIMARY KEY CLUSTERED 
	(
	idSolictudCAE
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.SolicitudesCAE SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.SolicitudesCAE', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.SolicitudesCAE', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.SolicitudesCAE', 'Object', 'CONTROL') as Contr_Per 
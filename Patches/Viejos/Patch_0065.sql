/*
   martes, 26 de febrero de 201311:10:44 a.m.
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
ALTER TABLE dbo.Pagos
	DROP CONSTRAINT FK__Pagos__idGrabado__6581EB1C
GO
ALTER TABLE dbo.Usuarios SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Usuarios', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Usuarios', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Usuarios', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Pagos
	DROP CONSTRAINT FK__Pagos__idProveed__648DC6E3
GO
ALTER TABLE dbo.Proveedores SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Proveedores', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Proveedores', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Proveedores', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Pagos
	DROP CONSTRAINT FK__Pagos__idPagador__6399A2AA
GO
ALTER TABLE dbo.Empleados SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Pagos
	DROP CONSTRAINT DF__Pagos__Aprobado__5B045CA9
GO
CREATE TABLE dbo.Tmp_Pagos
	(
	idPago int NOT NULL IDENTITY (1, 1),
	idProveedor int NOT NULL,
	idPagador int NOT NULL,
	idGrabador int NOT NULL,
	Fecha date NOT NULL,
	Comprobante varchar(50) NULL,
	Importe money NULL,
	Aprobado bit NULL,
	idTipoDeComprobante int NULL,
	idReferencia int NULL,
	FechaRegistro datetime NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Pagos SET (LOCK_ESCALATION = TABLE)
GO
ALTER TABLE dbo.Tmp_Pagos ADD CONSTRAINT
	DF__Pagos__Aprobado__5B045CA9 DEFAULT ((0)) FOR Aprobado
GO
SET IDENTITY_INSERT dbo.Tmp_Pagos ON
GO
IF EXISTS(SELECT * FROM dbo.Pagos)
	 EXEC('INSERT INTO dbo.Tmp_Pagos (idPago, idProveedor, idPagador, idGrabador, Fecha, Comprobante, Importe, Aprobado)
		SELECT idPago, idProveedor, idPagador, idGrabador, CONVERT(date, Fecha), Comprobante, Importe, Aprobado FROM dbo.Pagos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Pagos OFF
GO
ALTER TABLE dbo.DetallesPagos
	DROP CONSTRAINT FK__DetallesP__idPag__62A57E71
GO
DROP TABLE dbo.Pagos
GO
EXECUTE sp_rename N'dbo.Tmp_Pagos', N'Pagos', 'OBJECT' 
GO
ALTER TABLE dbo.Pagos ADD CONSTRAINT
	PK__Pagos__5BF880E2 PRIMARY KEY CLUSTERED 
	(
	idPago
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Pagos ADD CONSTRAINT
	FK__Pagos__idPagador__6399A2AA FOREIGN KEY
	(
	idPagador
	) REFERENCES dbo.Empleados
	(
	idEmpleado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Pagos ADD CONSTRAINT
	FK__Pagos__idProveed__648DC6E3 FOREIGN KEY
	(
	idProveedor
	) REFERENCES dbo.Proveedores
	(
	idProveedor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Pagos ADD CONSTRAINT
	FK__Pagos__idGrabado__6581EB1C FOREIGN KEY
	(
	idGrabador
	) REFERENCES dbo.Usuarios
	(
	idUsuario
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Pagos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Pagos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Pagos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.DetallesPagos ADD CONSTRAINT
	FK__DetallesP__idPag__62A57E71 FOREIGN KEY
	(
	idPago
	) REFERENCES dbo.Pagos
	(
	idPago
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DetallesPagos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DetallesPagos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetallesPagos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetallesPagos', 'Object', 'CONTROL') as Contr_Per 
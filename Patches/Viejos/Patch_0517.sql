/*
   miércoles, 23 de septiembre de 20158:28:51 p. m.
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
ALTER TABLE dbo.Comprobantes
	DROP CONSTRAINT FK_Comprobantes_Grupos
GO
ALTER TABLE dbo.Grupos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Grupos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Grupos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Grupos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Comprobantes
	DROP CONSTRAINT FK_Comprobantes_LiquidacionesTercerizada
GO
ALTER TABLE dbo.LiquidacionesTercerizada SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.LiquidacionesTercerizada', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.LiquidacionesTercerizada', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.LiquidacionesTercerizada', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Comprobantes
	DROP CONSTRAINT FK_Comprobantes_Facturaciones
GO
ALTER TABLE dbo.Facturaciones SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Facturaciones', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Facturaciones', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Facturaciones', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Comprobantes
	DROP CONSTRAINT FK_Comprobantes_Empleados
GO
ALTER TABLE dbo.Empleados SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Empleados', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Comprobantes
	DROP CONSTRAINT FK_Comprobantes_EntidadesDeCobranza
GO
ALTER TABLE dbo.EntidadesDeCobranza SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.EntidadesDeCobranza', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.EntidadesDeCobranza', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.EntidadesDeCobranza', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Comprobantes
	DROP CONSTRAINT FK_Comprobantes_TiposDeCobranza
GO
ALTER TABLE dbo.TiposDeCobranza SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TiposDeCobranza', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TiposDeCobranza', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TiposDeCobranza', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Comprobantes
	DROP CONSTRAINT FK_Comprobantes_TandasDeFacturacion
GO
ALTER TABLE dbo.TandasDeFacturacion SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TandasDeFacturacion', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TandasDeFacturacion', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TandasDeFacturacion', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Comprobantes
	DROP CONSTRAINT FK_Comprobantes_Zonas
GO
ALTER TABLE dbo.Zonas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Zonas', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Zonas', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Zonas', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Comprobantes
	DROP CONSTRAINT FK_Comprobantes_Prestaciones
GO
ALTER TABLE dbo.Prestaciones SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Prestaciones', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Prestaciones', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Prestaciones', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Comprobantes
	DROP CONSTRAINT FK_Comprobantes_Clientes
GO
ALTER TABLE dbo.Clientes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Clientes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Clientes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Clientes', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Comprobantes
	DROP CONSTRAINT FK__Comproban__idTip__05C3D225
GO
ALTER TABLE dbo.TiposDeComprobante SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TiposDeComprobante', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TiposDeComprobante', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TiposDeComprobante', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Comprobantes
	DROP CONSTRAINT DF_Comprobantes_Anulado
GO
CREATE TABLE dbo.Tmp_Comprobantes
	(
	idComprobante int NOT NULL IDENTITY (1, 1),
	idTipoDeComprobante int NULL,
	Prefijo varchar(4) NULL,
	NumeroDeComprobante varchar(8) NULL,
	Fecha date NOT NULL,
	Periodo varchar(7) NULL,
	idCliente int NULL,
	idGrupo int NULL,
	idPrestacion int NULL,
	Nombre varchar(200) NULL,
	Apellido varchar(50) NULL,
	Direccion varchar(50) NULL,
	Entre varchar(100) NULL,
	Barrio varchar(50) NULL,
	Localidad varchar(50) NULL,
	idZona int NULL,
	ObservacionesDireccion varchar(MAX) NULL,
	Importe money NULL,
	Saldo money NULL,
	idReferencia int NULL,
	CantidadDeDetalles int NULL,
	Telefono  AS ([dbo].[TelefonosDelGrupo]([idGrupo])),
	ApelNomb  AS (case when [Nombre] IS NULL then [Apellido] else case when [Apellido] IS NULL then [Nombre] else ([Apellido]+', ')+[Nombre] end end),
	NombApel  AS (case when [Nombre] IS NULL then [Apellido] else case when [Apellido] IS NULL then [Nombre] else ([Nombre]+' ')+[Apellido] end end),
	idTandaDeFacturacion int NULL,
	OrdenEnElGrupo smallint NULL,
	idFacturaProForma int NULL,
	idTipoDeCobranza int NULL,
	idEntidadDeCobranza int NULL,
	NumeroTarjeta varchar(30) NULL,
	idCobrador int NULL,
	idFacturacion int NULL,
	idLiquidacionTercerizada int NULL,
	PjeIVA money NULL,
	Anulado bit NULL,
	Vinculados  AS ([dbo].[ComprobantesVinculados]([idComprobante])),
	idCategoriaIVA int NULL,
	CUIT varchar(11) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Comprobantes SET (LOCK_ESCALATION = TABLE)
GO
ALTER TABLE dbo.Tmp_Comprobantes ADD CONSTRAINT
	DF_Comprobantes_Anulado DEFAULT ((0)) FOR Anulado
GO
SET IDENTITY_INSERT dbo.Tmp_Comprobantes ON
GO
IF EXISTS(SELECT * FROM dbo.Comprobantes)
	 EXEC('INSERT INTO dbo.Tmp_Comprobantes (idComprobante, idTipoDeComprobante, Prefijo, NumeroDeComprobante, Fecha, Periodo, idCliente, idGrupo, idPrestacion, Nombre, Apellido, Direccion, Entre, Barrio, Localidad, idZona, ObservacionesDireccion, Importe, Saldo, idReferencia, CantidadDeDetalles, idTandaDeFacturacion, OrdenEnElGrupo, idFacturaProForma, idTipoDeCobranza, idEntidadDeCobranza, NumeroTarjeta, idCobrador, idFacturacion, idLiquidacionTercerizada, PjeIVA, Anulado, idCategoriaIVA, CUIT)
		SELECT idComprobante, idTipoDeComprobante, Prefijo, NumeroDeComprobante, Fecha, Periodo, idCliente, idGrupo, idPrestacion, Nombre, Apellido, Direccion, Entre, Barrio, Localidad, idZona, ObservacionesDireccion, Importe, Saldo, idReferencia, CantidadDeDetalles, idTandaDeFacturacion, OrdenEnElGrupo, idFacturaProForma, idTipoDeCobranza, idEntidadDeCobranza, NumeroTarjeta, idCobrador, idFacturacion, idLiquidacionTercerizada, PjeIVA, Anulado, idCategoriaIVA, CUIT FROM dbo.Comprobantes WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Comprobantes OFF
GO
ALTER TABLE dbo.ComprobantesCambioDeCobrador
	DROP CONSTRAINT FK_ComprobantesCambioDeCobrador_Comprobantes
GO
ALTER TABLE dbo.ComprobantesArqueos
	DROP CONSTRAINT FK__Comproban__idCom__08A03ED0
GO
ALTER TABLE dbo.ComprobantesRemesas
	DROP CONSTRAINT FK__Comproban__idRef__06B7F65E
GO
ALTER TABLE dbo.ComprobantesExceptuadosPagoTercerizado
	DROP CONSTRAINT FK_ComprobantesExceptuadosPagoTercerizado_Comprobantes
GO
ALTER TABLE dbo.ComprobantesLiquidacionTercerizada
	DROP CONSTRAINT FK_ComprobantesLiquidacionTercerizada_Comprobantes
GO
ALTER TABLE dbo.DetallesComprobantes
	DROP CONSTRAINT FK__DetallesC__idCom__07AC1A97
GO
DROP TABLE dbo.Comprobantes
GO
EXECUTE sp_rename N'dbo.Tmp_Comprobantes', N'Comprobantes', 'OBJECT' 
GO
ALTER TABLE dbo.Comprobantes ADD CONSTRAINT
	PK__Comprobantes__02E7657A PRIMARY KEY CLUSTERED 
	(
	idComprobante
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX _dta_index_Comprobantes_8_690817523__K5_K7_K4_K1_K16_3_6_9_10_11_12_13_14_15_17_18_21 ON dbo.Comprobantes
	(
	Fecha,
	idCliente,
	NumeroDeComprobante,
	idComprobante,
	idZona
	) INCLUDE (Apellido, Barrio, CantidadDeDetalles, Direccion, Entre, idGrupo, Importe, Localidad, Nombre, ObservacionesDireccion, Periodo, Prefijo) 
 WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX _dta_index_Comprobantes_9_1228583465__K31_K1_K32 ON dbo.Comprobantes
	(
	idCobrador,
	idComprobante,
	idFacturacion
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX _dta_index_Comprobantes_9_1228583465__K31_K1_K32_18 ON dbo.Comprobantes
	(
	idCobrador,
	idComprobante,
	idFacturacion
	) INCLUDE (Importe) 
 WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX _dta_index_Comprobantes_5_551009044__K1_K23_6_7_8_9_12_15_18 ON dbo.Comprobantes
	(
	idComprobante,
	ApelNomb
	) INCLUDE (Direccion, idCliente, idGrupo, idPrestacion, Importe, Localidad, Periodo) 
 WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX _dta_index_Comprobantes_7_240055941__K8_K2_K6_1 ON dbo.Comprobantes
	(
	idGrupo,
	idTipoDeComprobante,
	Periodo
	) INCLUDE (idComprobante) 
 WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX _dta_index_Comprobantes_5_551009044__K9_K2_K1_4_5_10_12_14_15_18 ON dbo.Comprobantes
	(
	idPrestacion,
	idTipoDeComprobante,
	idComprobante
	) INCLUDE (Barrio, Direccion, Fecha, Importe, Localidad, Nombre, NumeroDeComprobante) 
 WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX _dta_index_Comprobantes_7_551009044__K2_1_6_7_8_9_10_11_12_15_18 ON dbo.Comprobantes
	(
	idTipoDeComprobante
	) INCLUDE (Apellido, Direccion, idCliente, idComprobante, idGrupo, idPrestacion, Importe, Localidad, Nombre, Periodo) 
 WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX _dta_index_Comprobantes_9_1228583465__K2_1 ON dbo.Comprobantes
	(
	idTipoDeComprobante
	) INCLUDE (idComprobante) 
 WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX _dta_index_Comprobantes_7_240055941__K2_K7_K6_1 ON dbo.Comprobantes
	(
	idTipoDeComprobante,
	idCliente,
	Periodo
	) INCLUDE (idComprobante) 
 WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX _dta_index_Comprobantes_5_551009044__K2_K9_K1_4_5_10_12_14_15_18 ON dbo.Comprobantes
	(
	idTipoDeComprobante,
	idPrestacion,
	idComprobante
	) INCLUDE (Barrio, Direccion, Fecha, Importe, Localidad, Nombre, NumeroDeComprobante) 
 WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX _dta_index_Comprobantes_8_690817523__K2_K6_K1_5_18 ON dbo.Comprobantes
	(
	idTipoDeComprobante,
	Periodo,
	idComprobante
	) INCLUDE (Fecha, Importe) 
 WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX _dta_index_Comprobantes_8_690817523__K6_K1 ON dbo.Comprobantes
	(
	Periodo,
	idComprobante
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX _dta_index_Comprobantes_8_690817523__K6_K1_K2_5_18 ON dbo.Comprobantes
	(
	Periodo,
	idComprobante,
	idTipoDeComprobante
	) INCLUDE (Fecha, Importe) 
 WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX _dta_index_Comprobantes_8_690817523__K20_K2_5_18 ON dbo.Comprobantes
	(
	idReferencia,
	idTipoDeComprobante
	) INCLUDE (Fecha, Importe) 
 WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX _dta_index_Comprobantes_8_690817523__K6 ON dbo.Comprobantes
	(
	Periodo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE dbo.Comprobantes ADD CONSTRAINT
	FK__Comproban__idTip__05C3D225 FOREIGN KEY
	(
	idTipoDeComprobante
	) REFERENCES dbo.TiposDeComprobante
	(
	idTipoDeComprobante
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Comprobantes ADD CONSTRAINT
	FK_Comprobantes_Clientes FOREIGN KEY
	(
	idCliente
	) REFERENCES dbo.Clientes
	(
	idCliente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Comprobantes ADD CONSTRAINT
	FK_Comprobantes_Prestaciones FOREIGN KEY
	(
	idPrestacion
	) REFERENCES dbo.Prestaciones
	(
	idPrestacion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Comprobantes ADD CONSTRAINT
	FK_Comprobantes_Zonas FOREIGN KEY
	(
	idZona
	) REFERENCES dbo.Zonas
	(
	idZona
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Comprobantes ADD CONSTRAINT
	FK_Comprobantes_TandasDeFacturacion FOREIGN KEY
	(
	idTandaDeFacturacion
	) REFERENCES dbo.TandasDeFacturacion
	(
	idTandaDeFacturacion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Comprobantes ADD CONSTRAINT
	FK_Comprobantes_TiposDeCobranza FOREIGN KEY
	(
	idTipoDeCobranza
	) REFERENCES dbo.TiposDeCobranza
	(
	idTipoDeCobranza
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Comprobantes ADD CONSTRAINT
	FK_Comprobantes_EntidadesDeCobranza FOREIGN KEY
	(
	idEntidadDeCobranza
	) REFERENCES dbo.EntidadesDeCobranza
	(
	idEntidadDeCobranza
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Comprobantes ADD CONSTRAINT
	FK_Comprobantes_Empleados FOREIGN KEY
	(
	idCobrador
	) REFERENCES dbo.Empleados
	(
	idEmpleado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Comprobantes ADD CONSTRAINT
	FK_Comprobantes_Facturaciones FOREIGN KEY
	(
	idFacturacion
	) REFERENCES dbo.Facturaciones
	(
	idFacturacion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Comprobantes ADD CONSTRAINT
	FK_Comprobantes_LiquidacionesTercerizada FOREIGN KEY
	(
	idLiquidacionTercerizada
	) REFERENCES dbo.LiquidacionesTercerizada
	(
	idLiquidacionTercerizada
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
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
COMMIT
select Has_Perms_By_Name(N'dbo.Comprobantes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Comprobantes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Comprobantes', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.DetallesComprobantes ADD CONSTRAINT
	FK__DetallesC__idCom__07AC1A97 FOREIGN KEY
	(
	idComprobante
	) REFERENCES dbo.Comprobantes
	(
	idComprobante
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DetallesComprobantes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DetallesComprobantes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetallesComprobantes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetallesComprobantes', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ComprobantesLiquidacionTercerizada ADD CONSTRAINT
	FK_ComprobantesLiquidacionTercerizada_Comprobantes FOREIGN KEY
	(
	idComprobante
	) REFERENCES dbo.Comprobantes
	(
	idComprobante
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ComprobantesLiquidacionTercerizada SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ComprobantesLiquidacionTercerizada', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ComprobantesLiquidacionTercerizada', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ComprobantesLiquidacionTercerizada', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ComprobantesExceptuadosPagoTercerizado ADD CONSTRAINT
	FK_ComprobantesExceptuadosPagoTercerizado_Comprobantes FOREIGN KEY
	(
	idComprobante
	) REFERENCES dbo.Comprobantes
	(
	idComprobante
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ComprobantesExceptuadosPagoTercerizado SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ComprobantesExceptuadosPagoTercerizado', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ComprobantesExceptuadosPagoTercerizado', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ComprobantesExceptuadosPagoTercerizado', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ComprobantesRemesas ADD CONSTRAINT
	FK__Comproban__idRef__06B7F65E FOREIGN KEY
	(
	idReferencia
	) REFERENCES dbo.Comprobantes
	(
	idComprobante
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ComprobantesRemesas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ComprobantesRemesas', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ComprobantesRemesas', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ComprobantesRemesas', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ComprobantesArqueos ADD CONSTRAINT
	FK__Comproban__idCom__08A03ED0 FOREIGN KEY
	(
	idComprobante
	) REFERENCES dbo.Comprobantes
	(
	idComprobante
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ComprobantesArqueos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ComprobantesArqueos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ComprobantesArqueos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ComprobantesArqueos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ComprobantesCambioDeCobrador ADD CONSTRAINT
	FK_ComprobantesCambioDeCobrador_Comprobantes FOREIGN KEY
	(
	idComprobante
	) REFERENCES dbo.Comprobantes
	(
	idComprobante
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ComprobantesCambioDeCobrador SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ComprobantesCambioDeCobrador', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ComprobantesCambioDeCobrador', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ComprobantesCambioDeCobrador', 'Object', 'CONTROL') as Contr_Per 
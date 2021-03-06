/*
   domingo, 21 de agosto de 201606:01:21 p.m.
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
CREATE TABLE dbo.Tmp_Sistemas
	(
	idSistema int NOT NULL IDENTITY (1, 1),
	Recibo int NOT NULL,
	NotaDeCredito int NOT NULL,
	NotaDeDebito int NULL,
	ComprobanteFactCuotaAfiliados int NULL,
	ComprobanteFactPrestaciones int NULL,
	DNI int NULL,
	MotivoDevolucionCobranza_SaldoCero int NULL,
	MotivoDevolucionCobranza_Baja int NULL,
	UltimoNumeroDeValor int NULL,
	UltimoNumeroDeCaja int NULL,
	CoberturaAfiliado int NULL,
	CoberturaContrato int NULL,
	Consulta int NULL,
	Internacion int NULL,
	MaxCantDetallesPorComprobante int NULL,
	MotivoDeBaja_Automatica int NULL,
	Empleado_Sistema int NULL,
	TandaDebitoAutomatico int NULL,
	PuntoDeVentaPrestaciones int NULL,
	ValoresEfectivo int NULL,
	MotivoDevolucionCobranza_ComprobanteFaltante int NULL,
	SinMedicamentos int NULL,
	CobradorBajas int NULL,
	CobradorMorosos int NULL,
	VendedorAfiliadosContrato int NULL,
	CodigoPrestacionProgramada int NULL,
	TipoDeDestinoPrestacionProgramada int NULL,
	NombreEmpresa varchar(50) NULL,
	FacturaDeCompra int NULL,
	Pago int NULL,
	Caja_Despachador int NULL,
	PlanConsultorio int NULL,
	ClienteVarios int NULL,
	NegocioAfiliados int NULL,
	PuntoDeVentaElectronico int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Sistemas SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Sistemas ON
GO
IF EXISTS(SELECT * FROM dbo.Sistemas)
	 EXEC('INSERT INTO dbo.Tmp_Sistemas (idSistema, Recibo, NotaDeCredito, NotaDeDebito, ComprobanteFactCuotaAfiliados, ComprobanteFactPrestaciones, DNI, MotivoDevolucionCobranza_SaldoCero, MotivoDevolucionCobranza_Baja, UltimoNumeroDeValor, UltimoNumeroDeCaja, CoberturaAfiliado, CoberturaContrato, Consulta, Internacion, MaxCantDetallesPorComprobante, MotivoDeBaja_Automatica, Empleado_Sistema, TandaDebitoAutomatico, PuntoDeVentaPrestaciones, ValoresEfectivo, MotivoDevolucionCobranza_ComprobanteFaltante, SinMedicamentos, CobradorBajas, CobradorMorosos, VendedorAfiliadosContrato, CodigoPrestacionProgramada, TipoDeDestinoPrestacionProgramada, NombreEmpresa, FacturaDeCompra, Pago, Caja_Despachador, PlanConsultorio, ClienteVarios, NegocioAfiliados, PuntoDeVentaElectronico)
		SELECT idSistema, Recibo, NotaDeCredito, NotaDeDebito, ComprobanteFactCuotaAfiliados, ComprobanteFactPrestaciones, DNI, MotivoDevolucionCobranza_SaldoCero, MotivoDevolucionCobranza_Baja, UltimoNumeroDeValor, UltimoNumeroDeCaja, CoberturaAfiliado, CoberturaContrato, Consulta, Internacion, MaxCantDetallesPorComprobante, MotivoDeBaja_Automatica, Empleado_Sistema, TandaDebitoAutomatico, PuntoDeVentaPrestaciones, ValoresEfectivo, MotivoDevolucionCobranza_ComprobanteFaltante, SinMedicamentos, CobradorBajas, CobradorMorosos, VendedorAfiliadosContrato, CodigoPrestacionProgramada, TipoDeDestinoPrestacionProgramada, NombreEmpresa, FacturaDeCompra, Pago, Caja_Despachador, PlanConsultorio, ClienteVarios, NegocioAfiliados, CONVERT(int, PuntoDeVentaElectronico) FROM dbo.Sistemas WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Sistemas OFF
GO
DROP TABLE dbo.Sistemas
GO
EXECUTE sp_rename N'dbo.Tmp_Sistemas', N'Sistemas', 'OBJECT' 
GO
ALTER TABLE dbo.Sistemas ADD CONSTRAINT
	PK_Sistema PRIMARY KEY CLUSTERED 
	(
	idSistema
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.Sistemas', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Sistemas', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Sistemas', 'Object', 'CONTROL') as Contr_Per 
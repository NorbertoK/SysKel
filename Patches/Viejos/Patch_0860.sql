CREATE STATISTICS [_dta_stat_1296723672_5_2_7] ON [dbo].[Comprobantes]([Fecha], [idTipoDeComprobante], [idCliente])
CREATE STATISTICS [_dta_stat_1296723672_1_5_2] ON [dbo].[Comprobantes]([idComprobante], [Fecha], [idTipoDeComprobante])
CREATE NONCLUSTERED INDEX [_dta_index_Comprobantes_5_1296723672__K7_K1_K2_K5_18] ON [dbo].[Comprobantes] 
(
	[idCliente] ASC,
	[idComprobante] ASC,
	[idTipoDeComprobante] ASC,
	[Fecha] ASC
)
INCLUDE ( [Importe]) WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
CREATE NONCLUSTERED INDEX [_dta_index_Contratos_5_1493580359__K3] ON [dbo].[Contratos] 
(
	[idCliente] ASC
)WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
CREATE NONCLUSTERED INDEX [_dta_index_Pacientes_5_1765581328__K15_K2] ON [dbo].[Pacientes] 
(
	[idContrato] ASC,
	[idPrestacion] ASC
)WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
CREATE STATISTICS [_dta_stat_2053582354_3_7_1] ON [dbo].[Prestaciones]([Tomada], [idMotivoDeCancelacion], [idPrestacion])
CREATE NONCLUSTERED INDEX [_dta_index_Prestaciones_5_2053582354__K1_K7_K3] ON [dbo].[Prestaciones] 
(
	[idPrestacion] ASC,
	[idMotivoDeCancelacion] ASC,
	[Tomada] ASC
)WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]

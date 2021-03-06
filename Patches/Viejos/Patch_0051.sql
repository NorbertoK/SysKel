use [Datos]
go

CREATE NONCLUSTERED INDEX [_dta_index_Prestaciones_7_1506104406__K5_K3_K1] ON [dbo].[Prestaciones] 
(
	[idCodigo] ASC,
	[Tomada] ASC,
	[idPrestacion] ASC
)WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
go

CREATE STATISTICS [_dta_stat_1506104406_3_1] ON [dbo].[Prestaciones]([Tomada], [idPrestacion])
go

CREATE STATISTICS [_dta_stat_1506104406_3_5_1] ON [dbo].[Prestaciones]([Tomada], [idCodigo], [idPrestacion])
go

CREATE NONCLUSTERED INDEX [_dta_index_Pacientes_7_1090102924__K2_15] ON [dbo].[Pacientes] 
(
	[idPrestacion] ASC
)
INCLUDE ( [idContrato]) WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
go

CREATE NONCLUSTERED INDEX [_dta_index_Pacientes_7_1090102924__K2_K15] ON [dbo].[Pacientes] 
(
	[idPrestacion] ASC,
	[idContrato] ASC
)WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
go

CREATE NONCLUSTERED INDEX [_dta_index_Destinos_7_1093578934__K1_K5] ON [dbo].[Destinos] 
(
	[idDestino] ASC,
	[idTipoDeDestino] ASC
)WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
go


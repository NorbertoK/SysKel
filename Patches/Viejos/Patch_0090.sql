use [Datos]
go

CREATE NONCLUSTERED INDEX [_dta_index_Prestaciones_8_1506104406__K3_K1_K5] ON [dbo].[Prestaciones] 
(
	[Tomada] ASC,
	[idPrestacion] ASC,
	[idCodigo] ASC
)WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
go

CREATE NONCLUSTERED INDEX [_dta_index_Direcciones_8_501576825__K17_K1_K4] ON [dbo].[Direcciones] 
(
	[idDestino] ASC,
	[idDireccion] ASC,
	[idLocalidad] ASC
)WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
go

CREATE STATISTICS [_dta_stat_501576825_1_17] ON [dbo].[Direcciones]([idDireccion], [idDestino])
go

CREATE STATISTICS [_dta_stat_501576825_1_4_17] ON [dbo].[Direcciones]([idDireccion], [idLocalidad], [idDestino])
go

CREATE NONCLUSTERED INDEX [_dta_index_Destinos_8_1093578934__K1_K2] ON [dbo].[Destinos] 
(
	[idDestino] ASC,
	[idPrestacion] ASC
)WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
go


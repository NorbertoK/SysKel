use [Datos]
go

SET QUOTED_IDENTIFIER ON
go

SET ARITHABORT ON
go

SET CONCAT_NULL_YIELDS_NULL ON
go

SET ANSI_NULLS ON
go

SET ANSI_PADDING ON
go

SET ANSI_WARNINGS ON
go

SET NUMERIC_ROUNDABORT OFF
go

CREATE NONCLUSTERED INDEX [_dta_index_Prestaciones_8_1506104406__K12_K1_3] ON [dbo].[Prestaciones] 
(
	[TelefonoSoloNumeros] ASC,
	[idPrestacion] ASC
)
INCLUDE ( [Tomada]) WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
go

CREATE STATISTICS [_dta_stat_1090102924_1_3] ON [dbo].[Pacientes]([idPaciente], [idAfiliado])
go

CREATE STATISTICS [_dta_stat_1090102924_3_15] ON [dbo].[Pacientes]([idAfiliado], [idContrato])
go

CREATE STATISTICS [_dta_stat_1090102924_2_1_15] ON [dbo].[Pacientes]([idPrestacion], [idPaciente], [idContrato])
go

CREATE STATISTICS [_dta_stat_1090102924_2_1_3_15] ON [dbo].[Pacientes]([idPrestacion], [idPaciente], [idAfiliado], [idContrato])
go

CREATE STATISTICS [_dta_stat_501576825_18_13_16] ON [dbo].[Direcciones]([idLugar], [idCliente], [idAfiliado])
go

CREATE STATISTICS [_dta_stat_501576825_17_13_16_15_18_1] ON [dbo].[Direcciones]([idDestino], [idCliente], [idAfiliado], [idGrupo], [idLugar], [idDireccion])
go

CREATE STATISTICS [_dta_stat_501576825_1_14_15_16_18_17] ON [dbo].[Direcciones]([idDireccion], [idContrato], [idGrupo], [idAfiliado], [idLugar], [idDestino])
go

CREATE STATISTICS [_dta_stat_501576825_16_1_15_18_13_14_17] ON [dbo].[Direcciones]([idAfiliado], [idDireccion], [idGrupo], [idLugar], [idCliente], [idContrato], [idDestino])
go


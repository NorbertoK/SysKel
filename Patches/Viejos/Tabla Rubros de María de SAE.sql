USE [Datos]
GO
/****** Object:  Table [dbo].[Rubros]    Script Date: 10/18/2018 09:32:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rubros](
	[idRubro] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](20) NULL,
	[Nombre] [varchar](100) NULL,
	[AdmiteValores] [bit] NULL,
	[NombreCompleto]  AS (([Codigo]+' ')+[Nombre]),
 CONSTRAINT [PK_Rubros] PRIMARY KEY CLUSTERED 
(
	[idRubro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Rubros] ON
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (1, N'5,1,0/00/00/00', N'GASTOS OPERATIVOS', 0)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (2, N'5,1,0/00/01/00', N'Honorarios Medicos', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (3, N'5,1,0/00/02/00', N'Medicamentos', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (4, N'5,1,0/00/03/00', N'Sueldos y Jornales', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (5, N'5,1,0/00/04/00', N'Cargas Sociales', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (6, N'5,1,0/00/05/00', N'Seguros de Moviles- Colegios', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (7, N'5,1,0/00/06/00', N'Mantenimiento de Rodados', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (8, N'5,1,0/00/07/00', N'Gastos de Combustible', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (9, N'5,1,0/00/08/00', N'Seguro de Mala Praxis', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (10, N'5,1,0/00/09/00', N'Mantenimiento de Equipos Medicos', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (11, N'5,1,0/00/10/00', N'Gastos Shopping', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (12, N'5,1,0/00/11/00', N'Honorarios Saber', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (13, N'5,1,0/00/12/00', N'Adicionales del Personal', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (14, N'5,1,0/00/13/00', N'Adicionales Shopping', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (15, N'5,1,0/00/14/00', N'Gastos de Oxigeno', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (16, N'5,1,0/00/15/00', N'Alquiler Rodados', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (17, N'5,1,0/00/16/00', N'Gastos Seguridad Privada', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (18, N'5,1,0/00/17/00', N'Gastos Bomberos', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (19, N'5,1,0/00/18/00', N'Gastos Sana', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (20, N'5,1,0/00/19/00', N'Gastos Semed', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (21, N'5,1,0/00/20/00', N'Gastos Vuelos Sanitarios', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (22, N'5,2,0/00/00/00', N'GASTOS COMERCIALIZACION', 0)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (23, N'5,2,0/00/00/01', N'Viaticos y Movilidad', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (24, N'5,2,0/00/00/02', N'Comision Cobranzas', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (25, N'5,2,0/00/00/03', N'Comision por Ventas', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (26, N'5,2,0/00/00/04', N'Publicidad y Propaganda', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (27, N'5,2,0/00/00/05', N'Honorarios de Comercializacion', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (28, N'5,2,0/00/00/06', N'Fondos Fijos', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (29, N'5,2,0/00/00/07', N'Comision Convenios', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (30, N'5,2,0/00/00/08', N'Cursos de Capacitacion', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (31, N'5,3,0/00/00/00', N'GASTOS ADMINISTRACION', 0)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (32, N'5,3,0/00/00/01', N'Honorarios Profesionales', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (33, N'5,3,0/00/00/02', N'Manten. y Limpieza', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (34, N'5,3,0/00/00/03', N'Uniformes del Personal', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (35, N'5,3,0/00/00/04', N'Gastos de Luz y Gas', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (36, N'5,3,0/00/00/05', N'Gastos de Telefono', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (37, N'5,3,0/00/00/06', N'Papelerias y Utiles', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (38, N'5,3,0/00/00/07', N'Reparac. y Mant. Equipo Informatico', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (39, N'5,3,0/00/00/08', N'Alquiler Local', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (40, N'5,3,0/00/00/09', N'Retiro de Socios', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (41, N'5,3,0/00/00/10', N'Consejo Profes. de Cs. Economicas', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (42, N'5,3,0/00/00/11', N'Internet', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (43, N'5,3,0/00/00/12', N'Canal 2', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (44, N'5,3,0/00/00/13', N'Union Empresarios', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (45, N'5,3,0/00/00/14', N'Gastos Pap y Utiles Shopping', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (46, N'5,3,0/00/00/15', N'Gastos Judiciales', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (47, N'5,4,0/00/00/00', N'GASTOS IMPOSITIVOS', 0)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (48, N'5,4,0/00/00/01', N'Impuesto a las Ganancias', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (49, N'5,4,0/00/00/02', N'Afip Morat. y Planes de pagos', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (50, N'5,4,0/00/00/03', N'IVA', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (51, N'5,4,0/00/00/04', N'DGR I. Brutos', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (52, N'5,4,0/00/00/05', N'DGR Agentes de Retencion', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (53, N'0,0,0/00/00/00', NULL, 0)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (54, N'5,5,0/00/00/00', N'OTROS EGRESOS', 0)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (55, N'5,5,0/00/00/01', N'Mantenimiento de Inmueble', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (56, N'5,5,1/00/00/00', N'GASTOS FINANCIEROS', 0)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (57, N'5,5,1/00/00/01', N'Gastos y comisiones bancarias', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (58, N'5,5,2/00/00/00', N'OTROS EGRESO PTE DICHOS', 0)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (59, N'5,5,2/00/00/01', N'Banco Macro', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (60, N'5,5,2/00/00/02', N'Banco HSBC', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (61, N'5,5,2/00/00/03', N'Banco Nacion', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (62, N'5,5,2/00/00/04', N'Banco ICBC', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (63, N'5,5,2/00/00/05', N'Prestamos', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (64, N'5,5,2/00/00/06', N'Gastos Varios', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (65, N'5,4,0/00/00/06', N'Retencion Ingresos Brutos', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (66, N'5,4,0/00/00/07', N'Retencion IVA', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (67, N'5,1,0/00/21/00', N'Retencion SUSS', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (68, N'5,1,0/00/22/00', N'Plan Rombo', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (69, N'5,1,0/00/23/00', N'Cuota Alimentarias', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (70, N'5,1,0/00/24/00', N'Gastos Comida y Refrigerios', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (71, N'5,1,0/00/04/01', N'DGI Seguridad Social', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (72, N'5,1,0/00/04/02', N'DGI Obra Social', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (73, N'5,1,0/00/04/03', N'ART', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (74, N'5,1,0/00/04/04', N'Seguro de Vida', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (75, N'5,1,0/00/04/05', N'Cuota Sindical', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (76, N'5,1,0/00/25/00', N'SIEM', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (77, N'1,2,1/00/00/00', N'BIENES DE USO', 0)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (78, N'1,2,1/01/00/00', N'Rodados', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (79, N'1,2,1/02/00/00', N'Muebles y Utiles', 1)
INSERT [dbo].[Rubros] ([idRubro], [Codigo], [Nombre], [AdmiteValores]) VALUES (80, N'1,2,1/03/00/00', N'Equipamientos Medicos', 1)
SET IDENTITY_INSERT [dbo].[Rubros] OFF

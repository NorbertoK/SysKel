USE [Datos]
GO

/****** Object:  View [dbo].[View_Hist_Planes]    Script Date: 03/16/2014 20:03:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[View_Hist_Planes]
AS
SELECT     pl.idHist_Planes, pl.idPlan, pl.Nombre_anterior, pl.Nombre_nuevo, pl.Iniciales_anterior, pl.Iniciales_nuevo, 
                      cli_ant.RazonSocial + CASE WHEN ISNULL(cli_ant.NombreFantasia, '') 
                      = '' THEN '' ELSE ' (' + cli_ant.NombreFantasia + ')' END + ' - ' + cto_ant.Nombre AS Contrato_anterior, 
                      cli_nue.RazonSocial + CASE WHEN ISNULL(cli_nue.NombreFantasia, '') 
                      = '' THEN '' ELSE ' (' + cli_nue.NombreFantasia + ')' END + ' - ' + cto_nue.Nombre AS Contrato_nuevo, pl.Cuota_anterior, pl.Cuota_nuevo, pl.Activo_anterior, 
                      pl.Activo_nuevo, pl.PadronExterno_anterior, pl.PadronExterno_nuevo, prot_ant.Nombre AS [Proteccion anterior], prot_nue.Nombre AS [Proteccion nueva], 
                      pl.CuotaAdherente_anterior, pl.CuotaAdherente_nuevo, prep_ant.Nombre AS [Prepago anterior], prep_nue.Nombre AS [Prepago nuevo], pl.Fecha
FROM         dbo.Hist_Planes AS pl LEFT OUTER JOIN
                      dbo.Contratos AS cto_ant ON pl.idContrato_anterior = cto_ant.idContrato LEFT OUTER JOIN
                      dbo.Clientes AS cli_ant ON cto_ant.idCliente = cli_ant.idCliente LEFT OUTER JOIN
                      dbo.Contratos AS cto_nue ON pl.idContrato_nuevo = cto_nue.idContrato LEFT OUTER JOIN
                      dbo.Clientes AS cli_nue ON cto_ant.idCliente = cli_nue.idCliente LEFT OUTER JOIN
                      dbo.Protecciones AS prot_ant ON pl.idProteccion_anterior = prot_ant.idProteccion LEFT OUTER JOIN
                      dbo.Protecciones AS prot_nue ON pl.idProteccion_nuevo = prot_nue.idProteccion LEFT OUTER JOIN
                      dbo.Prepagos AS prep_ant ON pl.idPrepago_anterior = prep_ant.idPrepago LEFT OUTER JOIN
                      dbo.Prepagos AS prep_nue ON pl.idPrepago_nuevo = prep_nue.idPrepago

GO



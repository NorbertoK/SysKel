USE [Datos]
GO

/****** Object:  View [dbo].[View_Hist_RenglonesFacturaProforma]    Script Date: 03/17/2014 09:50:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[View_Hist_RenglonesFacturaProforma]
AS
SELECT     idHist_RenglonesFacturaProforma, dbo.NombreCompletoDelCliente
                          ((SELECT     idCliente
                              FROM         dbo.Contratos
                              WHERE     (idContrato = CASE WHEN h.idContrato_anterior IS NULL THEN h.idContrato_nuevo ELSE h.idContrato_anterior END))) AS Cliente, 
                      idRenglonFacturaProforma,
                          (SELECT     Nombre
                            FROM          dbo.Contratos AS Contratos_2
                            WHERE      (idContrato = h.idContrato_anterior)) AS [Contrato Antarior],
                          (SELECT     Nombre
                            FROM          dbo.Contratos AS Contratos_1
                            WHERE      (idContrato = h.idContrato_nuevo)) AS [Contrato Nuevo],
                          (SELECT     Nombre
                            FROM          dbo.Planes
                            WHERE      (idPlan = h.idPlan_anterior)) AS [Plan Anterior],
                          (SELECT     Nombre
                            FROM          dbo.Planes AS Planes_1
                            WHERE      (idPlan = h.idPlan_nuevo)) AS [Plan Nuevo], Cantidad_anterior, Cantidad_nuevo, PrecioUnitario_anterior, PrecioUnitario_nuevo, 
                      RevisarMensualmente_anterior, RevisarMensualmente_nuevo, Fecha
FROM         dbo.Hist_RenglonesFacturaProforma AS h

GO



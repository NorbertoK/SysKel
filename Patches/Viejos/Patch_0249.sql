USE [Datos]
GO

/****** Object:  View [dbo].[View_Contratos]    Script Date: 12/20/2013 18:59:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[View_Contratos]
AS
SELECT     con.idContrato, CASE WHEN EXISTS
                          (SELECT     *
                            FROM          Direcciones
                            WHERE      idContrato = con.idContrato) THEN dirCto.idDireccion ELSE dir.idDireccion END AS Expr1, cli.RazonSocial + CASE WHEN ISNULL(cli.NombreFantasia, '') 
                      = '' THEN '' ELSE ' (' + cli.NombreFantasia + ')' END + ' - ' + con.Nombre AS Contrato,
                          (SELECT     CASE WHEN sol.AltaBajaSusp = 'A' THEN CASE
                                                       (SELECT     COUNT(*)
                                                         FROM          dbo.Comprobantes comp
                                                         WHERE      comp.idCliente = cli.idCliente AND comp.Periodo != dbo.PeríodoDeUnaFecha(GETDATE()) AND comp.idTipoDeComprobante IN
                                                                                    (SELECT     idTipoDeComprobante
                                                                                      FROM          dbo.TiposDeComprobante
                                                                                      WHERE      EsFactura = 1) AND comp.Saldo > 0) WHEN 0 THEN 'Activo' WHEN 1 THEN 'Debe 1 mes' ELSE 'Debe ' +
                                                       (SELECT     CAST(COUNT(*) AS VARCHAR(10))
                                                         FROM          dbo.Comprobantes comp
                                                         WHERE      comp.idCliente = cli.idCliente AND comp.Periodo != dbo.PeríodoDeUnaFecha(GETDATE()) AND comp.idTipoDeComprobante IN
                                                                                    (SELECT     idTipoDeComprobante
                                                                                      FROM          dbo.TiposDeComprobante
                                                                                      WHERE      EsFactura = 1) AND comp.Saldo > 0) 
                                                   + ' meses' END WHEN sol.AltaBajaSusp = 'B' THEN 'Baja' WHEN sol.AltaBajaSusp = 'S' THEN 'Suspendido' END AS Expr1
                            FROM          dbo.Solicitudes AS sol
                            WHERE      (idSolicitud =
                                                       (SELECT     MAX(idSolicitud) AS idSolicitud
                                                         FROM          dbo.Solicitudes AS S
                                                         WHERE      (FechaFinal IS NULL) AND (Fecha <= GETDATE()) AND (idContrato = con.idContrato) OR
                                                                                (Fecha <= GETDATE()) AND (idContrato = con.idContrato) AND (FechaFinal > GETDATE())))) AS Estado, 
                      dbo.DireccionCompleta(CASE WHEN EXISTS
                          (SELECT     *
                            FROM          Direcciones
                            WHERE      idContrato = con.idContrato) THEN dirCto.idDireccion ELSE dir.idDireccion END) AS DireccionCliente
FROM         dbo.Clientes AS cli LEFT OUTER JOIN
                      dbo.Contratos AS con ON con.idCliente = cli.idCliente LEFT OUTER JOIN
                      dbo.Direcciones AS dir ON dir.idCliente = cli.idCliente LEFT OUTER JOIN
                      dbo.Direcciones AS dirCto ON dirCto.idContrato = con.idContrato

GO



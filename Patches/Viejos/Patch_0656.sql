USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ExportarImpresionFacturas]    Script Date: 07/21/2016 14:58:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ExportarImpresionFacturas]
    @serie VARCHAR(1)
   ,@idPuntoDeVenta INT
   ,@desde VARCHAR(8)
   ,@hasta VARCHAR(8)
AS 
    BEGIN
        SET NOCOUNT ON;
        SELECT  c.idComprobante
               ,tc.Tipo TipoDeComprobante
               ,@serie Serie
               ,c.Prefijo
               ,c.NumeroDeComprobante
               ,c.Fecha
               ,c.NombApel
               ,CASE WHEN c.idGrupo IS NOT NULL
                     THEN ( SELECT  dbo.DireccionCompleta(( SELECT
                                                              idDireccion
                                                            FROM
                                                              dbo.Direcciones
                                                            WHERE
                                                              idGrupo = c.idGrupo
                                                              AND Real = 1
                                                          ))
                          )
                     ELSE CASE WHEN c.idCliente IS NOT NULL
                               THEN ( SELECT    dbo.DireccionCompleta(( SELECT
                                                              idDireccion
                                                              FROM
                                                              dbo.Direcciones
                                                              WHERE
                                                              idCliente = c.idCliente
                                                              AND Real = 1
                                                              ))
                                    )
                               ELSE ''
                          END
                END DireccionFiscal
               ,CASE WHEN c.idGrupo IS NOT NULL
                     THEN CASE WHEN ( SELECT    idDireccion
                                      FROM      dbo.Direcciones
                                      WHERE     idGrupo = c.idGrupo
                                                AND Real = 1
                                    ) = ( SELECT    idDireccion
                                          FROM      dbo.Direcciones
                                          WHERE     idGrupo = c.idGrupo
                                                    AND Cobranza = 1
                                        ) THEN ''
                               ELSE ( SELECT    dbo.DireccionCompleta(( SELECT
                                                              idDireccion
                                                              FROM
                                                              dbo.Direcciones
                                                              WHERE
                                                              idGrupo = c.idGrupo
                                                              AND Cobranza = 1
                                                              ))
                                    )
                          END
                     ELSE CASE WHEN c.idCliente IS NOT NULL
                               THEN CASE WHEN ( SELECT  idDireccion
                                                FROM    dbo.Direcciones
                                                WHERE   idCliente = c.idCliente
                                                        AND Real = 1
                                              ) = ( SELECT  idDireccion
                                                    FROM    dbo.Direcciones
                                                    WHERE   idCliente = c.idCliente
                                                            AND Cobranza = 1
                                                  ) THEN ''
                                         ELSE REPLACE(( SELECT
                                                              dbo.DireccionCompleta(( SELECT
                                                              idDireccion
                                                              FROM
                                                              dbo.Direcciones
                                                              WHERE
                                                              idCliente = c.idCliente
                                                              AND Cobranza = 1
                                                              ))
                                                      ), CHAR(13) + CHAR(10),
                                                      ' ')
                                    END
                               ELSE ''
                          END
                END DireccionDeCobranza
               ,CASE WHEN c.idGrupo IS NOT NULL
                     THEN ( SELECT  CI.Nombre
                            FROM    dbo.Grupos g
                                    JOIN dbo.CategoriasIVA CI ON g.idCategoriaIva = CI.idCategoriaIVA
                            WHERE   idGrupo = c.idGrupo
                          )
                     ELSE CASE WHEN c.idCliente IS NOT NULL
                               THEN ( SELECT    CI.Nombre
                                      FROM      dbo.Clientes cli
                                                JOIN dbo.CategoriasIVA CI ON cli.idCategoriaIva = CI.idCategoriaIVA
                                      WHERE     idCliente = c.idCliente
                                    )
                               ELSE ''
                          END
                END CategoriaIVA
               ,CASE WHEN c.idCliente IS NOT NULL
                     THEN ( SELECT  CUIT
                            FROM    dbo.Clientes
                            WHERE   idCliente = c.idCliente
                          )
                     ELSE ''
                END CUIT
               ,CASE WHEN c.idCliente IS NOT NULL
                     THEN ( SELECT  IngresosBrutos
                            FROM    dbo.Clientes
                            WHERE   idCliente = c.idCliente
                          )
                     ELSE ''
                END IngresosBrutos
               ,ISNULL(dbo.TotalExento(c.idComprobante), 0) TotalExento
               ,ISNULL(dbo.TotalGravado(c.idComprobante), 0) TotalGravado
               ,ISNULL(dbo.TotalNoGravado(c.idComprobante), 0) TotalNoGravado
               ,c.Importe TotalFactura
               ,dc.Cantidad
               ,CASE WHEN c.idGrupo IS NULL THEN dc.Detalle
                     ELSE dc.Nombre + ' - '
                          + ISNULL(( SELECT NumeroDeDocumento
                                     FROM   dbo.Afiliados af
                                     WHERE  idAfiliado = dc.idAfiliado
                                   ), '') + ' - ' + pl.Nombre + ' - '
                          + c.Periodo
                END Detalle
               ,dbo.PrecioUnitarioImpreso(dc.idDetalleComprobante) PrecioUnitario
               ,dbo.ImporteDelDetalleImpreso(dc.idDetalleComprobante) ImporteItem
               ,pIVA.Descripcion IVAItem
               ,dbo.imp_IVA(dc.idDetalleComprobante) ImporteIVAItem
        FROM    dbo.Comprobantes c
                LEFT JOIN dbo.DetallesComprobantes dc ON c.idComprobante = dc.idComprobante
                JOIN dbo.TiposDeComprobante tc ON c.idTipoDeComprobante = tc.idTipoDeComprobante
                LEFT JOIN dbo.Planes pl ON dc.idPlan = pl.idPlan
                LEFT JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
        WHERE   prefijo = ( SELECT  Prefijo
                            FROM    dbo.PuntosDeVenta
                            WHERE   idPuntoDeVenta = @idPuntoDeVenta
                          )
                AND NumeroDeComprobante BETWEEN @desde AND @hasta
                AND Serie = @serie
                AND ISNULL(c.Anulado, 0) = 0
    END

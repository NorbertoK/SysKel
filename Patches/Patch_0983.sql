USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ExportarImpresionFacturas]    Script Date: 04/10/2019 18:40:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ExportarImpresionFacturas]
AS 
    BEGIN
        DECLARE @prefijo VARCHAR(4)
        SELECT  @prefijo = prefijo
        FROM    dbo.PuntosDeVenta
        WHERE   SolicitaCAE > 0
        SELECT  p.CSV
        FROM    ( SELECT    idComprobante = 1
                           ,CSV = '"idComprobante","Serie","TipoDeComprobante","Prefijo","NumeroDeComprobante","Fecha","NombApel","DireccionFiscal","DireccionDeCobranza","CategoriaIVA","CUIT","IngresosBrutos","TotalExento","TotalGravado","TotalNoGravado","TotalFactura","Cantidad","Detalle","PrecioUnitario","ImporteItem","IVAItem","ImporteIVAItem"'
                  UNION ALL
                  SELECT    c.idComprobante
                           ,REPLACE(LEFT(CONVERT(VARCHAR(50), CAST(c.idComprobante AS MONEY), 1),
                                         LEN(CONVERT(VARCHAR(50), CAST(c.idComprobante AS MONEY), 1))
                                         - 3), ',', '.') + ',"' + tc.Serie
                            + '","' + tc.TablaAFIP + '","' + c.Prefijo + '","'
                            + '00000000' + '",'
                            + CONVERT(VARCHAR(10), c.Fecha, 103) + ',"'
                            + c.NombApel + '","'
                            + CASE WHEN c.idGrupo IS NOT NULL
                                   THEN ISNULL(( SELECT dbo.DireccionCompleta(( SELECT
                                                              idDireccion
                                                              FROM
                                                              dbo.Direcciones
                                                              WHERE
                                                              idGrupo = c.idGrupo
                                                              AND Real = 1
                                                              ))
                                               ), '')
                                   ELSE CASE WHEN c.idCliente IS NOT NULL
                                             THEN ISNULL(( SELECT
                                                              dbo.DireccionCompleta(( SELECT
                                                              idDireccion
                                                              FROM
                                                              dbo.Direcciones
                                                              WHERE
                                                              idCliente = c.idCliente
                                                              AND Real = 1
                                                              ))
                                                         ), '')
                                             ELSE ''
                                        END
                              END + '",'
                            + CASE WHEN c.idGrupo IS NOT NULL
                                   THEN CASE WHEN ISNULL(( SELECT
                                                              idDireccion
                                                           FROM
                                                              dbo.Direcciones
                                                           WHERE
                                                              idGrupo = c.idGrupo
                                                              AND Real = 1
                                                         ), '') = ISNULL(( SELECT
                                                              idDireccion
                                                              FROM
                                                              dbo.Direcciones
                                                              WHERE
                                                              idGrupo = c.idGrupo
                                                              AND Cobranza = 1
                                                              ), '') THEN ''
                                             ELSE '"'
                                                  + ISNULL(( SELECT
                                                              dbo.DireccionCompleta(( SELECT
                                                              idDireccion
                                                              FROM
                                                              dbo.Direcciones
                                                              WHERE
                                                              idGrupo = c.idGrupo
                                                              AND Cobranza = 1
                                                              ))
                                                           ), '') + '"'
                                        END
                                   ELSE CASE WHEN c.idCliente IS NOT NULL
                                             THEN CASE WHEN ISNULL(( SELECT
                                                              idDireccion
                                                              FROM
                                                              dbo.Direcciones
                                                              WHERE
                                                              idCliente = c.idCliente
                                                              AND Real = 1
                                                              ), '') = ISNULL(( SELECT
                                                              idDireccion
                                                              FROM
                                                              dbo.Direcciones
                                                              WHERE
                                                              idCliente = c.idCliente
                                                              AND Cobranza = 1
                                                              ), '') THEN ''
                                                       ELSE REPLACE(ISNULL(( SELECT
                                                              dbo.DireccionCompleta(( SELECT
                                                              idDireccion
                                                              FROM
                                                              dbo.Direcciones
                                                              WHERE
                                                              idCliente = c.idCliente
                                                              AND Cobranza = 1
                                                              ))
                                                              ), ''),
                                                              CHAR(13)
                                                              + CHAR(10), ' ')
                                                  END
                                             ELSE ''
                                        END
                              END + ',"'
                            + CASE WHEN c.idGrupo IS NOT NULL
                                   THEN ( SELECT    CI.Nombre
                                          FROM      dbo.Grupos g
                                                    JOIN dbo.CategoriasIVA CI ON g.idCategoriaIva = CI.idCategoriaIVA
                                          WHERE     idGrupo = c.idGrupo
                                        )
                                   ELSE CASE WHEN c.idCliente IS NOT NULL
                                             THEN ( SELECT  CI.Nombre
                                                    FROM    dbo.Clientes cli
                                                            JOIN dbo.CategoriasIVA CI ON cli.idCategoriaIva = CI.idCategoriaIVA
                                                    WHERE   idCliente = c.idCliente
                                                  )
                                             ELSE ''
                                        END
                              END + '",'
                            + CASE WHEN c.idCliente IS NOT NULL
                                   THEN CASE WHEN ( SELECT  CUIT
                                                    FROM    dbo.Clientes
                                                    WHERE   idCliente = c.idCliente
                                                  ) IS NULL THEN ''
                                             ELSE ( SELECT  '"' + CUIT + '"'
                                                    FROM    dbo.Clientes
                                                    WHERE   idCliente = c.idCliente
                                                  )
                                        END
                                   ELSE CASE WHEN c.idGrupo IS NOT NULL
                                             THEN CASE WHEN ( SELECT
                                                              CUIT
                                                              FROM
                                                              dbo.Grupos
                                                              WHERE
                                                              idGrupo = c.idGrupo
                                                            ) IS NULL THEN ''
                                                       ELSE ( SELECT
                                                              '"' + CUIT + '"'
                                                              FROM
                                                              dbo.Grupos
                                                              WHERE
                                                              idGrupo = c.idGrupo
                                                            )
                                                  END
                                             ELSE ''
                                        END
                              END + ','
                            + CASE WHEN c.idCliente IS NOT NULL
                                   THEN ( SELECT    ISNULL(IngresosBrutos, '')
                                          FROM      dbo.Clientes
                                          WHERE     idCliente = c.idCliente
                                        )
                                   ELSE ''
                              END + ',"'
                            + REVERSE(STUFF(REVERSE(REPLACE(CONVERT(VARCHAR(20), CAST(ISNULL(dbo.TotalExento(c.idComprobante),
                                                              0) AS MONEY), 1),
                                                            ',', '.')), 3, 1,
                                            ',')) + '","'
                            + REVERSE(STUFF(REVERSE(REPLACE(CONVERT(VARCHAR(20), CAST(ISNULL(dbo.TotalGravado(c.idComprobante),
                                                              0) AS MONEY), 1),
                                                            ',', '.')), 3, 1,
                                            ',')) + '","'
                            + REVERSE(STUFF(REVERSE(REPLACE(CONVERT(VARCHAR(20), CAST(ISNULL(dbo.TotalNoGravado(c.idComprobante),
                                                              0) AS MONEY), 1),
                                                            ',', '.')), 3, 1,
                                            ',')) + '","'
                            + REVERSE(STUFF(REVERSE(REPLACE(CONVERT(VARCHAR(20), CAST(c.Importe AS MONEY), 1),
                                                            ',', '.')), 3, 1,
                                            ',')) + '",'
                            + ISNULL(CAST(dc.Cantidad AS VARCHAR(30)), '')
                            + ',"'
                            + CASE WHEN c.idGrupo IS NULL THEN dc.Detalle
                                   ELSE dc.Nombre + ' - '
                                        + ISNULL(( SELECT   NumeroDeDocumento
                                                   FROM     dbo.Afiliados af
                                                   WHERE    idAfiliado = dc.idAfiliado
                                                 ), '') + ' - ' + pl.Nombre
                                        + ' - ' + c.Periodo
                              END + '","'
                            + REVERSE(STUFF(REVERSE(REPLACE(CONVERT(VARCHAR(20), CAST(dbo.PrecioUnitarioImpreso(dc.idDetalleComprobante) AS MONEY), 1),
                                                            ',', '.')), 3, 1,
                                            ',')) + '","'
                            + REVERSE(STUFF(REVERSE(REPLACE(CONVERT(VARCHAR(20), CAST(dbo.ImporteDelDetalleImpreso(dc.idDetalleComprobante) AS MONEY), 1),
                                                            ',', '.')), 3, 1,
                                            ',')) + '","'
                            + REVERSE(STUFF(REVERSE(REPLACE(CONVERT(VARCHAR(20), CAST(pIVA.Porcentaje AS MONEY), 1),
                                                            ',', '.')), 3, 1,
                                            ',')) + '00' + '","'
                            + REVERSE(STUFF(REVERSE(REPLACE(CONVERT(VARCHAR(20), CAST(dbo.imp_IVA(dc.idDetalleComprobante) AS MONEY), 1),
                                                            ',', '.')), 3, 1,
                                            ',')) + '"'
                  FROM      dbo.Comprobantes c
                            LEFT JOIN dbo.DetallesComprobantes dc ON c.idComprobante = dc.idComprobante
                            JOIN dbo.TiposDeComprobante tc ON c.idTipoDeComprobante = tc.idTipoDeComprobante
                            LEFT JOIN dbo.Planes pl ON dc.idPlan = pl.idPlan
                            LEFT JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
                  WHERE     prefijo = @prefijo
                            AND ISNULL(c.Anulado, 0) = 0
                            AND ISNULL(NumeroDeComprobante, '') = ''
                ) p
        ORDER BY p.idComprobante 
        DECLARE @fecha VARCHAR(12) = REPLACE(REPLACE(REPLACE(CONVERT(VARCHAR(16), GETDATE(), 120),
                                              '-', ''), ' ', ''), ':', '')
        --UPDATE  dbo.Comprobantes
        --SET     CAE = @fecha
        --WHERE   prefijo = @prefijo
        --        AND ISNULL(Anulado, 0) = 0
        --        AND ISNULL(CAE, '') = ''
        UPDATE dbo.Parametros
        SET FacturasExportadas = @fecha               
    END
    

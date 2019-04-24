SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE EstadisticaTasaDeUsoClientes
    @periodoDesde VARCHAR(7)
   ,@periodoHasta VARCHAR(7)
AS 
    BEGIN
        SET NOCOUNT ON;
        DECLARE @desde DATETIME
        DECLARE @hasta DATETIME
        SET @desde = dbo.PrimerDiaDelPeriodo(@periodoDesde)
        SET @hasta = dbo.Medianoche(dbo.UltimoDiaDelPeriodo(@periodoHasta))
        SELECT  idCliente
               ,NombreCompleto Cliente
               ,ISNULL(( SELECT SUM(Importe
                                    * CASE WHEN tc.ImporteNegativo = 1 THEN -1
                                           ELSE 1
                                      END)
                         FROM   dbo.Comprobantes comp
                                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                         WHERE  idCliente = cli.idCliente
                                AND tc.Tipo IN ( 'Factura', 'NdeC', 'NdeD' )
                                AND comp.Fecha BETWEEN @desde
                                               AND     dbo.Medianoche(@hasta)
                       ), 0) Facturado
               ,( SELECT    COUNT(*)
                  FROM      dbo.Pacientes pac
                            JOIN dbo.Contratos cto ON pac.idContrato = cto.idContrato
                            JOIN dbo.Prestaciones prest ON pac.idPrestacion = prest.idPrestacion
                  WHERE     cto.idCliente = cli.idCliente
                            AND prest.Tomada BETWEEN @desde
                                             AND     dbo.Medianoche(@hasta)
                            AND prest.idMotivoDeCancelacion IS NULL
                ) Pacientes
               ,CASE WHEN ISNULL(( SELECT   SUM(Importe
                                                * CASE WHEN tc.ImporteNegativo = 1
                                                       THEN -1
                                                       ELSE 1
                                                  END)
                                   FROM     dbo.Comprobantes comp
                                            JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                                   WHERE    idCliente = cli.idCliente
                                            AND tc.Tipo IN ( 'Factura', 'NdeC',
                                                             'NdeD' )
                                            AND comp.Fecha BETWEEN @desde
                                                           AND
                                                              dbo.Medianoche(@hasta)
                                 ), 0) = 0
                     THEN CASE WHEN ( SELECT    COUNT(*)
                                      FROM      dbo.Pacientes pac
                                                JOIN dbo.Contratos cto ON pac.idContrato = cto.idContrato
                                                JOIN dbo.Prestaciones prest ON pac.idPrestacion = prest.idPrestacion
                                      WHERE     cto.idCliente = cli.idCliente
                                                AND prest.Tomada BETWEEN @desde
                                                              AND
                                                              dbo.Medianoche(@hasta)
                                                AND prest.idMotivoDeCancelacion IS NULL
                                    ) = 0 THEN 0
                               ELSE ( SELECT    COUNT(*)
                                      FROM      dbo.Pacientes pac
                                                JOIN dbo.Contratos cto ON pac.idContrato = cto.idContrato
                                                JOIN dbo.Prestaciones prest ON pac.idPrestacion = prest.idPrestacion
                                      WHERE     cto.idCliente = cli.idCliente
                                                AND prest.Tomada BETWEEN @desde
                                                              AND
                                                              dbo.Medianoche(@hasta)
                                                AND prest.idMotivoDeCancelacion IS NULL
                                    ) * -1
                          END
                     ELSE CASE WHEN ( SELECT    COUNT(*)
                                      FROM      dbo.Pacientes pac
                                                JOIN dbo.Contratos cto ON pac.idContrato = cto.idContrato
                                                JOIN dbo.Prestaciones prest ON pac.idPrestacion = prest.idPrestacion
                                      WHERE     cto.idCliente = cli.idCliente
                                                AND prest.Tomada BETWEEN @desde
                                                              AND
                                                              dbo.Medianoche(@hasta)
                                                AND prest.idMotivoDeCancelacion IS NULL
                                    ) = 0
                               THEN ( SELECT    SUM(Importe
                                                    * CASE WHEN tc.ImporteNegativo = 1
                                                           THEN -1
                                                           ELSE 1
                                                      END)
                                      FROM      dbo.Comprobantes comp
                                                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                                      WHERE     idCliente = cli.idCliente
                                                AND tc.Tipo IN ( 'Factura',
                                                              'NdeC', 'NdeD' )
                                                AND comp.Fecha BETWEEN @desde
                                                              AND
                                                              dbo.Medianoche(@hasta)
                                    ) * 100
                               ELSE ( SELECT    SUM(Importe
                                                    * CASE WHEN tc.ImporteNegativo = 1
                                                           THEN -1
                                                           ELSE 1
                                                      END)
                                      FROM      dbo.Comprobantes comp
                                                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                                      WHERE     idCliente = cli.idCliente
                                                AND tc.Tipo IN ( 'Factura',
                                                              'NdeC', 'NdeD' )
                                                AND comp.Fecha BETWEEN @desde
                                                              AND
                                                              dbo.Medianoche(@hasta)
                                    )
                                    / ( SELECT  COUNT(*)
                                        FROM    dbo.Pacientes pac
                                                JOIN dbo.Contratos cto ON pac.idContrato = cto.idContrato
                                                JOIN dbo.Prestaciones prest ON pac.idPrestacion = prest.idPrestacion
                                        WHERE   cto.idCliente = cli.idCliente
                                                AND prest.Tomada BETWEEN @desde
                                                              AND
                                                              dbo.Medianoche(@hasta)
                                                AND prest.idMotivoDeCancelacion IS NULL
                                      )
                          END
                END Precio
        FROM    dbo.Clientes cli
        WHERE   cli.Activo = 1
        ORDER BY Precio
    END
GO

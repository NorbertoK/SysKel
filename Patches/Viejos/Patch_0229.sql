USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ExportarImpresionFacturas]    Script Date: 12/05/2013 20:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ExportarImpresionFacturas]
    @idTipoDeComprobante INT
   ,@idPuntoDeVenta INT
   ,@desde VARCHAR(8)
   ,@hasta VARCHAR(8)
AS 
    BEGIN
        SET NOCOUNT ON ;
        SELECT  c.idComprobante
               ,c.Prefijo
               ,c.NumeroDeComprobante
               ,c.Fecha
               ,c.NombApel
               ,CASE WHEN c.idGrupo IS NOT NULL THEN ( SELECT   dbo.DireccionCompleta(( SELECT  idDireccion
                                                                                        FROM    dbo.Direcciones
                                                                                        WHERE   idGrupo = c.idGrupo
                                                                                                AND Real = 1
                                                                                      ))
                                                     )
                     ELSE CASE WHEN c.idCliente IS NOT NULL THEN ( SELECT   dbo.DireccionCompleta(( SELECT  idDireccion
                                                                                                    FROM    dbo.Direcciones
                                                                                                    WHERE   idCliente = c.idCliente
                                                                                                            AND Real = 1
                                                                                                  ))
                                                                 )
                          END
                END DireccionFiscal
               ,CASE WHEN c.idGrupo IS NOT NULL THEN CASE WHEN ( SELECT idDireccion
                                                                 FROM   dbo.Direcciones
                                                                 WHERE  idGrupo = c.idGrupo
                                                                        AND Real = 1
                                                               ) = ( SELECT idDireccion
                                                                     FROM   dbo.Direcciones
                                                                     WHERE  idGrupo = c.idGrupo
                                                                            AND Cobranza = 1
                                                                   ) THEN ''
                                                          ELSE ( SELECT dbo.DireccionCompleta(( SELECT  idDireccion
                                                                                                FROM    dbo.Direcciones
                                                                                                WHERE   idGrupo = c.idGrupo
                                                                                                        AND Cobranza = 1
                                                                                              ))
                                                               )
                                                     END
                     ELSE CASE WHEN c.idCliente IS NOT NULL THEN CASE WHEN ( SELECT idDireccion
                                                                             FROM   dbo.Direcciones
                                                                             WHERE  idCliente = c.idCliente
                                                                                    AND Real = 1
                                                                           ) = ( SELECT idDireccion
                                                                                 FROM   dbo.Direcciones
                                                                                 WHERE  idCliente = c.idCliente
                                                                                        AND Cobranza = 1
                                                                               ) THEN ''
                                                                      ELSE ( SELECT dbo.DireccionCompleta(( SELECT  idDireccion
                                                                                                            FROM    dbo.Direcciones
                                                                                                            WHERE   idCliente = c.idCliente
                                                                                                                    AND Cobranza = 1
                                                                                                          ))
                                                                           )
                                                                 END
                          END
                END DireccionDeCobranza
               ,CASE WHEN c.idGrupo IS NOT NULL THEN 'Consumidor Final'
                     ELSE CASE WHEN c.idCliente IS NOT NULL THEN ( SELECT   CI.Nombre
                                                                   FROM     dbo.Clientes cli
                                                                   JOIN     dbo.CategoriasIVA CI ON cli.idCategoriaIva = CI.idCategoriaIVA
                                                                   WHERE    idCliente = c.idCliente
                                                                 )
                          END
                END CategoriaIVA
               ,CASE WHEN c.PjeIVA IS NULL THEN 10.5 ELSE c.PjeIVA END PjeIVA
               ,CASE WHEN c.idCliente IS NOT NULL THEN ( SELECT CUIT
                                                         FROM   dbo.Clientes
                                                         WHERE  idCliente = c.idCliente
                                                       )
                     ELSE ''
                END CUIT
               ,CASE WHEN c.idCliente IS NOT NULL THEN ( SELECT IngresosBrutos
                                                         FROM   dbo.Clientes
                                                         WHERE  idCliente = c.idCliente
                                                       )
                     ELSE ''
                END IngresosBrutos
               ,dc.Cantidad
               ,CASE WHEN c.idGrupo IS NULL THEN dc.Detalle
                     ELSE dc.Nombre + ' - ' + ISNULL(( SELECT NumeroDeDocumento
                                                     FROM   dbo.Afiliados af
                                                     WHERE  idAfiliado = dc.idAfiliado
                                                   ), '') + ' - ' + pl.Nombre
                END Detalle
               ,dc.Importe/ISNULL(dc.Cantidad,1) /(1+ISNULL(c.PjeIVA,10.5)/100) PrecioUnitarioSinIVA
               ,dc.Importe ImporteConIVA
        FROM    dbo.Comprobantes c
        JOIN    dbo.DetallesComprobantes dc ON c.idComprobante = dc.idComprobante
        LEFT JOIN dbo.Planes pl ON dc.idPlan = pl.idPlan
        WHERE   prefijo = ( SELECT  Prefijo
                            FROM    dbo.PuntosDeVenta
                            WHERE   idPuntoDeVenta = @idPuntoDeVenta
                          )
                AND NumeroDeComprobante BETWEEN @desde AND @hasta
                AND idTipoDeComprobante = @idTipoDeComprobante
    END

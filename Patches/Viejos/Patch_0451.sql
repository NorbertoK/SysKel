USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[HacerComprobantesFacturas]    Script Date: 04/23/2015 21:01:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[HacerComprobantesFacturas]
    @idTandaDeFacturacion INT
   ,@fecha VARCHAR(8)
   ,@periodo VARCHAR(7)
   ,@cantidadFacturas INT OUT
AS 
    BEGIN
        SET NOCOUNT ON ;
        DECLARE @maxCantDetallesPorComprobante INT
        SELECT TOP 1
                @maxCantDetallesPorComprobante = MaxCantDetallesPorComprobante
        FROM    dbo.Sistemas
        DECLARE @afiliadosHasta DATETIME
        DECLARE @prestacionesDesde DATETIME
        DECLARE @prestacionesHasta DATETIME
        SET @afiliadosHasta = RIGHT(dbo.PeriodoSumarMeses(@periodo, -1), 4) + LEFT(dbo.PeriodoSumarMeses(@periodo, -1), 2) + '15'
        SET @prestacionesDesde = RIGHT(dbo.PeriodoSumarMeses(@periodo, -1), 4) + LEFT(dbo.PeriodoSumarMeses(@periodo, -1), 2) + '01'
        SET @prestacionesHasta = RIGHT(@periodo, 4) + LEFT(@periodo, 2) + '01'  
        DECLARE @idFacturacion INT
		
	-- Detalles
        DECLARE @detalles TABLE
            (
             idFacturaProforma INT
            ,idRenglonFacturaProforma INT
            ,Cantidad INT
            ,Detalle VARCHAR(300)
            ,Porciento DECIMAL(10, 2)
            ,Importe MONEY
            ) ;
        WITH    cantAfiliados ( idPlan, Titulares, cantidad )
                  AS ( SELECT   e.idPlan
                               ,af.Titular
                               ,COUNT(*)
                       FROM     dbo.Afiliados af
                       OUTER APPLY dbo.EstadosDelAfiliado(af.idAfiliado, @afiliadosHasta) e
                       WHERE    e.Estado NOT IN ( 'Baja', 'Suspendido', 'Alta Futura' )
                       GROUP BY e.idPlan
                               ,af.Titular
                     ),
                cantPrestaciones ( idContrato, cantidad )
                  AS ( SELECT   pac.idContrato
                               ,COUNT(*)
                       FROM     dbo.Prestaciones prest
                       JOIN     dbo.Pacientes pac ON pac.idPrestacion = prest.idPrestacion
                       WHERE    pac.idContrato IS NOT NULL
                                AND prest.Tomada >= @prestacionesDesde
                                AND prest.Tomada <= @prestacionesHasta
                       GROUP BY pac.idContrato
                     )
            INSERT  @detalles
                    ( 
                     idFacturaProforma
                    ,idRenglonFacturaProforma
                    ,Cantidad
                    ,Detalle
                    ,Porciento
                    )
                    SELECT  fp.idFacturaProforma
                           ,rfp.idRenglonFacturaProforma
                           ,CASE cto.idTipoDeContrato
                              WHEN 1 THEN 1
                              WHEN 2 THEN CASE WHEN rfp.Cantidad IS NULL THEN ( SELECT  ISNULL(ca.cantidad, 0)
                                                                                FROM    cantAfiliados ca
                                                                                WHERE   ca.idPlan = rfp.idPlan
                                                                                        AND ca.Titulares = rfp.Titulares
                                                                              )
                                               ELSE rfp.Cantidad
                                          END
                              WHEN 3 THEN ( SELECT  ISNULL(cp.cantidad, 0)
                                            FROM    cantPrestaciones cp
                                            WHERE   cp.idContrato = rfp.idContrato
                                          )
                            END
                           ,CASE cto.idTipoDeContrato
                              WHEN 1 THEN 'Cobertura de ' + cto.Nombre + ' mes ' + @periodo
                              WHEN 2 THEN CASE WHEN rfp.Cantidad IS NULL THEN 'Afiliados plan ' + pl.Nombre + CASE WHEN rfp.Titulares = 1 THEN ' Titulares'
                                                                                                                   ELSE ' Adherentes'
                                                                                                              END
                                               ELSE 'Afiliados'
                                          END
                              WHEN 3 THEN cto.Nombre
                            END
                           ,CASE LEFT(@periodo, 2)
                              WHEN '01' THEN CASE WHEN cto.Ene = 0 THEN 0
                                                  ELSE CAST(cto.Ene AS MONEY) / 100
                                             END
                              WHEN '02' THEN CASE WHEN cto.Feb = 0 THEN 0
                                                  ELSE CAST(cto.Feb AS MONEY) / 100
                                             END
                              WHEN '03' THEN CASE WHEN cto.Mar = 0 THEN 0
                                                  ELSE CAST(cto.Mar AS MONEY) / 100
                                             END
                              WHEN '04' THEN CASE WHEN cto.Abr = 0 THEN 0
                                                  ELSE CAST(cto.Abr AS MONEY) / 100
                                             END
                              WHEN '05' THEN CASE WHEN cto.May = 0 THEN 0
                                                  ELSE CAST(cto.May AS MONEY) / 100
                                             END
                              WHEN '06' THEN CASE WHEN cto.Jun = 0 THEN 0
                                                  ELSE CAST(cto.Jun AS MONEY) / 100
                                             END
                              WHEN '07' THEN CASE WHEN cto.Jul = 0 THEN 0
                                                  ELSE CAST(cto.Jul AS MONEY) / 100
                                             END
                              WHEN '08' THEN CASE WHEN cto.Ago = 0 THEN 0
                                                  ELSE CAST(cto.Ago AS MONEY) / 100
                                             END
                              WHEN '09' THEN CASE WHEN cto.Sep = 0 THEN 0
                                                  ELSE CAST(cto.Sep AS MONEY) / 100
                                             END
                              WHEN '10' THEN CASE WHEN cto.Oct = 0 THEN 0
                                                  ELSE CAST(cto.Oct AS MONEY) / 100
                                             END
                              WHEN '11' THEN CASE WHEN cto.Nov = 0 THEN 0
                                                  ELSE CAST(cto.Nov AS MONEY) / 100
                                             END
                              WHEN '12' THEN CASE WHEN cto.Dic = 0 THEN 0
                                                  ELSE CAST(cto.Dic AS MONEY) / 100
                                             END
                            END
                    FROM    dbo.FacturasProforma fp
                    JOIN    dbo.RenglonesFacturaProforma rfp ON rfp.idFacturaProforma = fp.idFacturaProforma
                    JOIN    dbo.Contratos cto ON cto.idContrato = rfp.idContrato
                    LEFT JOIN dbo.Planes pl ON pl.idPlan = rfp.idPlan
                    WHERE   fp.idTandaDeFacturacion = @idTandaDeFacturacion
                            AND dbo.ContratoSeFactura(rfp.idContrato, @periodo, 1) = 1
        DELETE  @detalles
        WHERE   Cantidad = 0
                OR Porciento = 0
        UPDATE  @detalles
        SET     Importe = ISNULL(ROUND(d.Cantidad * d.Porciento * CASE WHEN rfp.PrecioUnitario IS NULL THEN CASE WHEN rfp.Titulares = 1 THEN ISNULL(pl.Cuota, 0) ELSE ISNULL(pl.cuotaAdherente,0) END
                                                                       ELSE rfp.PrecioUnitario -- * ( 1 + fp.PorcentajeIva / 100 )
                                                                  END, 2), 0)
        FROM    @detalles d
        JOIN    dbo.FacturasProforma fp ON fp.idFacturaProforma = d.idFacturaProforma
        JOIN    dbo.RenglonesFacturaProforma rfp ON rfp.idRenglonFacturaProforma = d.idRenglonFacturaProforma
        LEFT JOIN dbo.Planes pl ON pl.idPlan = rfp.idPlan
        DELETE  @detalles
        WHERE   Importe = 0
	-- Fin de Detalles
        BEGIN TRAN
        BEGIN TRY
		-- Ingresar los comprobantes
            DECLARE @ComprobantesIngresados TABLE
                (
                 IdComprobante INT
                ,idFacturaProforma INT
                ,Prefijo VARCHAR(4)
                ,Importe MONEY
                ,idCobrador INT
                ,idEntidadDeCobranza INT
                ,idTipoDeComprobante INT
                ) ;
            WITH    ComprobantesARealizar ( idFacturaProforma, Cantidad, SumImportes )
                      AS ( SELECT   idFacturaProforma
                                   ,COUNT(*)
                                   ,SUM(Importe)
                           FROM     @Detalles
                           GROUP BY idFacturaProforma
                         )
                INSERT  dbo.Comprobantes
                        ( 
                         idTipoDeComprobante
                        ,Prefijo
                        ,NumeroDeComprobante
                        ,Fecha
                        ,Periodo
                        ,idCliente
                        ,idFacturaProforma
                        ,idTandaDeFacturacion
                        ,Nombre
                        ,Direccion
                        ,Entre
                        ,Barrio
                        ,Localidad
                        ,idZona
                        ,ObservacionesDireccion
                        ,Importe
                        ,CantidadDeDetalles
                        ,idTipoDeCobranza
                        ,idEntidadDeCobranza
                        ,NumeroTarjeta
                        ,idCobrador
                        ,PjeIVA
                        ,idCategoriaIVA
				)
                OUTPUT  INSERTED.IdComprobante
                       ,INSERTED.idFacturaProforma
                       ,INSERTED.Prefijo
                       ,INSERTED.Importe
                       ,INSERTED.idCobrador
                       ,INSERTED.idEntidadDeCobranza
                       ,INSERTED.idTipoDeComprobante
                        INTO @ComprobantesIngresados
                        SELECT  CASE WHEN dbo.PuntosDeVenta.Verdadero = 1 THEN ( SELECT   Factura
                                                       FROM     dbo.CategoriasIVA CI
                                                       JOIN     dbo.Clientes cli ON CI.idCategoriaIVA = cli.idCategoriaIva
                                                       JOIN     dbo.FacturasProforma FP ON cli.idCliente = FP.idCliente
                                                       WHERE    fp.idFacturaProforma = CR.idFacturaProforma
                                                     )
                                     ELSE ( SELECT TOP ( 1 )
                                                    ComprobanteFactCuotaAfiliados
                                            FROM    dbo.Sistemas
                                          )
                                END
                               ,PuntosDeVenta.Prefijo
                               ,RIGHT(REPLICATE('0', 8)
                                      + CONVERT	(VARCHAR(8), ( SELECT   CASE CASE WHEN dbo.PuntosDeVenta.Verdadero = 1
                                                                                  THEN ( SELECT Factura
                                                                                         FROM   dbo.CategoriasIVA CI
                                                                                         JOIN   dbo.Clientes cli ON CI.idCategoriaIVA = cli.idCategoriaIva
                                                                                         JOIN   dbo.FacturasProforma FP ON cli.idCliente = FP.idCliente
                                                                                         WHERE  fp.idFacturaProforma = CR.idFacturaProforma
                                                                                       )
                                                                                  ELSE ( SELECT TOP ( 1 )
                                                                                                ComprobanteFactCuotaAfiliados
                                                                                         FROM   dbo.Sistemas
                                                                                       )
                                                                             END
                                                                          WHEN 4 THEN UltimoNumeroAsignado
                                                                          WHEN 7 THEN UltimoNumeroAsignadoA
                                                                          WHEN 8 THEN UltimoNumeroAsignadoB
                                                                        END
                                                               FROM     dbo.PuntosDeVenta
                                                               WHERE    idPuntoDeVenta = z.idPuntoDeVenta
                                                             )
                                      + Row_Number() OVER ( PARTITION BY z.idPuntoDeVenta,
                                                            ( CASE WHEN dbo.PuntosDeVenta.Verdadero = 1 THEN ( SELECT Factura
                                                                                     FROM   dbo.CategoriasIVA CI
                                                                                     JOIN   dbo.Clientes cli ON CI.idCategoriaIVA = cli.idCategoriaIva
                                                                                     JOIN   dbo.FacturasProforma FP ON cli.idCliente = FP.idCliente
                                                                                     WHERE  fp.idFacturaProforma = CR.idFacturaProforma
                                                                                   )
                                                                   ELSE ( SELECT TOP ( 1 )
                                                                                    ComprobanteFactCuotaAfiliados
                                                                          FROM      dbo.Sistemas
                                                                        )
                                                              END ) ORDER BY z.idCobrador, loc.idLocalidad, z.Nombre, dir.idCalle, CAST(dbo.SoloNumeros(dir.Numero) AS INTEGER), cr.idFacturaProForma )),
                                      8)
                               ,CASE WHEN @fecha < dbo.UltimaFechaComprobantes(PuntosDeVenta.Prefijo,
                                                                               CASE WHEN dbo.PuntosDeVenta.Verdadero = 1
                                                                                    THEN ( SELECT   Factura
                                                                                           FROM     dbo.CategoriasIVA CI
                                                                                           JOIN     dbo.Clientes cli ON CI.idCategoriaIVA = cli.idCategoriaIva
                                                                                           JOIN     dbo.FacturasProforma FP ON cli.idCliente = FP.idCliente
                                                                                           WHERE    fp.idFacturaProforma = CR.idFacturaProforma
                                                                                         )
                                                                                    ELSE ( SELECT TOP ( 1 )
                                                                                                    ComprobanteFactCuotaAfiliados
                                                                                           FROM     dbo.Sistemas
                                                                                         )
                                                                               END)
                                     THEN dbo.UltimaFechaComprobantes(PuntosDeVenta.Prefijo,
                                                                      CASE WHEN dbo.PuntosDeVenta.Verdadero = 1 THEN ( SELECT Factura
                                                                                             FROM   dbo.CategoriasIVA CI
                                                                                             JOIN   dbo.Clientes cli ON CI.idCategoriaIVA = cli.idCategoriaIva
                                                                                             JOIN   dbo.FacturasProforma FP ON cli.idCliente = FP.idCliente
                                                                                             WHERE  fp.idFacturaProforma = CR.idFacturaProforma
                                                                                           )
                                                                           ELSE ( SELECT TOP ( 1 )
                                                                                            ComprobanteFactCuotaAfiliados
                                                                                  FROM      dbo.Sistemas
                                                                                )
                                                                      END)
                                     ELSE @fecha
                                END
                               ,@periodo
                               ,dir.idCliente
                               ,cr.idFacturaProforma
                               ,@idTandaDeFacturacion
                               ,cli.RazonSocial
                               ,CASE WHEN c.Nombre IS NULL THEN ''
                                     ELSE c.Nombre + ' '
                                END + CASE WHEN ISNULL(dir.Numero, '') = '' THEN ''
                                           ELSE dir.Numero
                                      END + CASE WHEN ISNULL(dir.Piso, '') = '' THEN ''
                                                 ELSE ' Piso ' + dir.Piso
                                            END + CASE WHEN ISNULL(dir.Departamento, '') = '' THEN ''
                                                       ELSE ' Depto. ' + dir.Departamento
                                                  END AS Direccion
                               ,CASE WHEN dir.idEntreCalle1 IS NULL THEN CASE WHEN dir.idEntreCalle2 IS NULL THEN NULL
                                                                              ELSE 'esq. ' + e2.Nombre
                                                                         END
                                     ELSE CASE WHEN dir.idEntreCalle2 IS NULL THEN 'esq.' + e1.Nombre
                                               ELSE 'entre ' + e1.Nombre + ' y ' + e2.nombre
                                          END
                                END AS Entre
                               ,b.nombre Barrio
                               ,loc.Nombre
                               ,dir.idZona
                               ,LEFT(dir.Observaciones, 200) AS ObservacionesDireccion
                               ,cr.SumImportes
                               ,cr.Cantidad
                               ,cli.idTipoDeCobranza
                               ,CASE cli.idTipoDeCobranza
                                  WHEN 1 THEN NULL
                                  WHEN 2 THEN cli.idEntidadDeCobranza
                                END
                               ,CASE cli.idTipoDeCobranza
                                  WHEN 1 THEN NULL
                                  WHEN 2 THEN cli.NumeroTarjeta
                                END
                               ,CASE cli.idTipoDeCobranza
                                  WHEN 1 THEN z.idCobrador
                                  WHEN 2 THEN NULL
                                END
                               ,fp.PorcentajeIVA
                               ,cli.idCategoriaIva
                        FROM    ComprobantesARealizar cr
                        LEFT JOIN dbo.FacturasProforma fp ON cr.idFacturaProforma = fp.idFacturaProforma
                        JOIN    dbo.Clientes cli ON fp.idCliente = cli.idCliente
                        LEFT JOIN dbo.Direcciones dir ON dir.idCliente = cli.idCliente
                        LEFT JOIN dbo.Zonas z ON dir.idZona = z.idZona
                        LEFT JOIN dbo.PuntosDeVenta ON z.idPuntoDeVenta = PuntosDeVenta.idPuntoDeVenta
                        LEFT JOIN dbo.Calles AS c ON dir.idCalle = c.idCalle
                        LEFT JOIN dbo.Calles AS e1 ON dir.idEntreCalle1 = e1.idCalle
                        LEFT JOIN dbo.Calles AS e2 ON dir.idEntreCalle2 = e2.idCalle
                        LEFT JOIN dbo.Localidades AS loc ON dir.idLocalidad = loc.idLocalidad
                        LEFT JOIN dbo.Barrios AS b ON dir.idBarrio = b.idBarrio
                        LEFT JOIN dbo.CategoriasIVA catIVA ON cli.idCategoriaIva = catIVA.idCategoriaIVA
                        WHERE   ( dir.Cobranza = 1 ) 
            SET @cantidadFacturas = @@ROWCOUNT
		-- Fin de Ingresar los comprobantes

		-- Insertar los Detalles
            INSERT  dbo.DetallesComprobantes
                    ( 
                     Cantidad
                    ,Detalle
                    ,Importe
                    ,idComprobante
			  )
                    SELECT  det.Cantidad
                           ,det.Detalle
                           ,det.Importe
                           ,gi.idComprobante
                    FROM    @detalles det
                    JOIN    @ComprobantesIngresados gi ON det.idFacturaProforma = gi.idFacturaProforma
		-- Fin de Insertar los Detalles

		-- Actualización de los Puntos de Venta
		
		;
            WITH    Puntos ( Prefijo, cantComprobantes )
                      AS ( SELECT   Prefijo
                                   ,COUNT(*)
                           FROM     @ComprobantesIngresados
                           WHERE    idTipoDeComprobante = 4
                           GROUP BY Prefijo
                         )
                UPDATE  dbo.PuntosDeVenta
                SET     UltimoNumeroAsignado = UltimoNumeroAsignado + p.cantComprobantes
                FROM    dbo.PuntosDeVenta pv
                JOIN    Puntos p ON pv.Prefijo = p.Prefijo ;
            WITH    Puntos ( Prefijo, cantComprobantes )
                      AS ( SELECT   Prefijo
                                   ,COUNT(*)
                           FROM     @ComprobantesIngresados
                           WHERE    idTipoDeComprobante = 7
                           GROUP BY Prefijo
                         )
                UPDATE  dbo.PuntosDeVenta
                SET     UltimoNumeroAsignadoA = UltimoNumeroAsignadoA + p.cantComprobantes
                FROM    dbo.PuntosDeVenta pv
                JOIN    Puntos p ON pv.Prefijo = p.Prefijo ;
            WITH    Puntos ( Prefijo, cantComprobantes )
                      AS ( SELECT   Prefijo
                                   ,COUNT(*)
                           FROM     @ComprobantesIngresados
                           WHERE    idTipoDeComprobante = 8
                           GROUP BY Prefijo
                         )
                UPDATE  dbo.PuntosDeVenta
                SET     UltimoNumeroAsignadoB = UltimoNumeroAsignadoB + p.cantComprobantes
                FROM    dbo.PuntosDeVenta pv
                JOIN    Puntos p ON pv.Prefijo = p.Prefijo                  
		-- Fin de la Actualización de los Puntos de Venta
		
		-- Registrar Facturación
            DECLARE @facturacionesIngresadas TABLE
                (
                 idFacturacion INT
                ,idcobrador INT
                ,idEntidadDeCobranza INT
                ) ;
            WITH    FacturacionesAIngresar ( idCobrador, idEntidadDeCobranza )
                      AS ( SELECT DISTINCT
                                    idCobrador
                                   ,idEntidadDeCobranza
                           FROM     @ComprobantesIngresados
                         )
                INSERT  dbo.Facturaciones
                        ( 
                         AfiliadosOClientes
                        ,Periodo
                        ,idTandaDeFacturacion
                        ,Fecha
                        ,idCobrador
                        ,idEntidadDeCobranza
                        )
                OUTPUT  INSERTED.idFacturacion
                       ,INSERTED.idCobrador
                       ,INSERTED.idEntidadDeCobranza
                        INTO @facturacionesIngresadas
                        SELECT  'C'
                               ,@periodo
                               ,@idTandaDeFacturacion
                               ,GETDATE()
                               ,idCobrador
                               ,idEntidadDeCobranza
                        FROM    FacturacionesAIngresar        
            UPDATE  dbo.Comprobantes
            SET     idFacturacion = fi.idFacturacion
            FROM    dbo.Comprobantes comp
            JOIN    @ComprobantesIngresados ci ON comp.idComprobante = ci.IdComprobante
            JOIN    @FacturacionesIngresadas fi ON ISNULL(ci.idCobrador, 0) = ISNULL(fi.idCobrador, 0)
                                                   AND ISNULL(ci.idEntidadDeCobranza, 0) = ISNULL(fi.idEntidadDeCobranza, 0)
	-- Fin de Registrar Facturación

            COMMIT TRAN
        END TRY
        BEGIN CATCH
            ROLLBACK TRAN
            SET @cantidadFacturas = 0
            RETURN 0
        END CATCH
        RETURN 1
    END


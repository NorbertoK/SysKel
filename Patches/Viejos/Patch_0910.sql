USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[HacerComprobanteFactura]    Script Date: 10/26/2018 20:25:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[HacerComprobanteFactura]
    @idFacturaProforma INT
   ,@fecha VARCHAR(8)
   ,@periodo VARCHAR(7)
   ,@proceso VARCHAR(255)
   ,@ponerCobrador BIT
   ,@cantidadFacturas INT OUT
AS 
    BEGIN
        SET NOCOUNT ON;
        DECLARE @maxCantDetallesPorComprobante INT = 100 --En las nuevas facturas no hay límite de cantidad de renglones.
        --SELECT TOP 1
        --        @maxCantDetallesPorComprobante = MaxCantDetallesPorComprobante
        --FROM    dbo.Sistemas
        DECLARE @desde DATETIME
        DECLARE @hasta DATETIME
        SET @desde = RIGHT(dbo.PeriodoSumarMeses(@periodo, -2), 4)
            + LEFT(dbo.PeriodoSumarMeses(@periodo, -2), 2) + '16'
        SET @hasta = RIGHT(dbo.PeriodoSumarMeses(@periodo, -1), 4)
            + LEFT(dbo.PeriodoSumarMeses(@periodo, -1), 2) + '15'

	-- Detalles
        DECLARE @detalles TABLE
            (
             idFacturaProforma INT
            ,idRenglonFacturaProforma INT
            ,Cantidad INT
            ,Detalle VARCHAR(300)
            ,Porciento DECIMAL(10, 2)
            ,Importe MONEY
            ,OrdenEnElGrupo SMALLINT
            ,idNegocio INT
            ,idPorcentajeIVA INT
            ,idContrato INT
            )
        INSERT  @detalles
                ( 
                 idFacturaProforma
                ,idRenglonFacturaProforma
                ,Cantidad
                ,Detalle
                ,Porciento
                ,OrdenEnElGrupo
                ,idNegocio
                ,idPorcentajeIVA
                ,idContrato		
                )
                SELECT  fp.idFacturaProforma
                       ,rfp.idRenglonFacturaProforma
                       ,CASE cto.idTipoDeContrato
                          WHEN 1 THEN 1
                          WHEN 2
                          THEN CASE WHEN rfp.Cantidad IS NULL
                                    THEN ( SELECT   COUNT(*)
                                           FROM     dbo.Afiliados af
                                                    OUTER APPLY dbo.EstadosDelAfiliado(af.idAfiliado,
                                                              @hasta) e
                                           WHERE    e.idPlan = rfp.idPlan
                                                    AND e.Estado NOT IN (
                                                    'Baja', 'Suspendido',
                                                    'Alta Futura' )
                                                    AND af.Titular = rfp.titulares
                                         )
                                    ELSE rfp.Cantidad
                               END
                          WHEN 3
                          THEN ( SELECT COUNT(*)
                                 FROM   dbo.Prestaciones prest
                                        JOIN dbo.Pacientes pac ON pac.idPrestacion = prest.idPrestacion
                                 WHERE  prest.Tomada >= @desde
                                        AND prest.Tomada <= @hasta
                                        AND pac.idContrato = rfp.idContrato
                               )
                        END
                       ,CASE cto.idTipoDeContrato
                          WHEN 1
                          THEN 'Cobertura de ' + cto.Nombre + ' mes '
                               + @periodo
                          WHEN 2
                          THEN CASE WHEN rfp.Cantidad IS NULL
                                    THEN 'Afiliados plan ' + pl.Nombre
                                         + CASE WHEN rfp.Titulares = 1
                                                THEN ' Titulares'
                                                ELSE ' Adherentes'
                                           END
                                    ELSE 'Afiliados'
                               END
                          WHEN 3 THEN cto.Nombre
                        END
                       ,CASE LEFT(@periodo, 2)
                          WHEN '01'
                          THEN CASE WHEN cto.Ene = 0 THEN 0
                                    ELSE CAST(cto.Ene AS MONEY) / 100
                               END
                          WHEN '02'
                          THEN CASE WHEN cto.Feb = 0 THEN 0
                                    ELSE CAST(cto.Feb AS MONEY) / 100
                               END
                          WHEN '03'
                          THEN CASE WHEN cto.Mar = 0 THEN 0
                                    ELSE CAST(cto.Mar AS MONEY) / 100
                               END
                          WHEN '04'
                          THEN CASE WHEN cto.Abr = 0 THEN 0
                                    ELSE CAST(cto.Abr AS MONEY) / 100
                               END
                          WHEN '05'
                          THEN CASE WHEN cto.May = 0 THEN 0
                                    ELSE CAST(cto.May AS MONEY) / 100
                               END
                          WHEN '06'
                          THEN CASE WHEN cto.Jun = 0 THEN 0
                                    ELSE CAST(cto.Jun AS MONEY) / 100
                               END
                          WHEN '07'
                          THEN CASE WHEN cto.Jul = 0 THEN 0
                                    ELSE CAST(cto.Jul AS MONEY) / 100
                               END
                          WHEN '08'
                          THEN CASE WHEN cto.Ago = 0 THEN 0
                                    ELSE CAST(cto.Ago AS MONEY) / 100
                               END
                          WHEN '09'
                          THEN CASE WHEN cto.Sep = 0 THEN 0
                                    ELSE CAST(cto.Sep AS MONEY) / 100
                               END
                          WHEN '10'
                          THEN CASE WHEN cto.Oct = 0 THEN 0
                                    ELSE CAST(cto.Oct AS MONEY) / 100
                               END
                          WHEN '11'
                          THEN CASE WHEN cto.Nov = 0 THEN 0
                                    ELSE CAST(cto.Nov AS MONEY) / 100
                               END
                          WHEN '12'
                          THEN CASE WHEN cto.Dic = 0 THEN 0
                                    ELSE CAST(cto.Dic AS MONEY) / 100
                               END
                        END
                       ,CEILING(CAST(ROW_NUMBER() OVER ( PARTITION BY fp.idFacturaProForma ORDER BY ( SELECT
                                                              0
                                                              ) ) AS DECIMAL)
                                / @maxCantDetallesPorComprobante)
                       ,cto.idNegocio
                       ,rfp.idPorcentajeIVA
                       ,rfp.idContrato
                FROM    dbo.FacturasProforma fp
                        JOIN dbo.RenglonesFacturaProforma rfp ON rfp.idFacturaProforma = fp.idFacturaProforma
                        JOIN dbo.Contratos cto ON cto.idContrato = rfp.idContrato
                        LEFT JOIN dbo.Planes pl ON pl.idPlan = rfp.idPlan
                WHERE   fp.idFacturaProforma = @idFacturaProforma
                        AND dbo.ContratoSeFactura(rfp.idContrato, @periodo, 1) = 1
        
        UPDATE  @detalles
        SET     Importe = ISNULL(ROUND(d.Cantidad * d.Porciento
                                       * CASE WHEN rfp.PrecioUnitario IS NULL
                                              THEN CASE WHEN rfp.Titulares = 1
                                                        THEN ISNULL(pl.Cuota,
                                                              0)
                                                        ELSE ISNULL(pl.cuotaAdherente,
                                                              0)
                                                   END
                                              ELSE rfp.PrecioUnitario -- * ( 1 + fp.PorcentajeIva / 100 )
                                         END, 2), 0)
        FROM    @detalles d
                JOIN dbo.FacturasProforma fp ON fp.idFacturaProforma = d.idFacturaProforma
                JOIN dbo.RenglonesFacturaProforma rfp ON rfp.idRenglonFacturaProforma = d.idRenglonFacturaProforma
                LEFT JOIN dbo.Planes pl ON pl.idPlan = rfp.idPlan
        
        DELETE  @detalles
        WHERE   Cantidad = 0
                OR Porciento = 0
                OR Importe = 0
        
	-- Fin de Detalles
        BEGIN TRAN
        BEGIN TRY
		-- Ingresar los comprobantes
            DECLARE @Comprobantes TABLE
                (
                 idTipoDeComprobante INT
                ,Prefijo VARCHAR(4)
                ,NumeroDeComprobante VARCHAR(8)
                ,OrdenEnElGrupo SMALLINT
                ,Fecha DATETIME
                ,Periodo VARCHAR(7)
                ,idCliente INT
                ,idFacturaProforma INT
                ,idTandaDeFacturacion INT
                ,Nombre VARCHAR(200)
                ,Direccion VARCHAR(50)
                ,Entre VARCHAR(100)
                ,Barrio VARCHAR(50)
                ,Localidad VARCHAR(50)
                ,idZona INT
                ,ObservacionesDireccion VARCHAR(200)
                ,Importe MONEY
                ,CantidadDeDetalles INT
                )
            DECLARE @ComprobantesIngresados TABLE
                (
                 IdComprobante INT
                ,idFacturaProforma INT
                ,OrdenEnElGrupo SMALLINT
                ,Prefijo VARCHAR(4)
                ,Importe MONEY
                ,idTipoDeCobranza INT
                ,idCobrador INT
                ,idEntidadDeCobranza INT
                ,idTipoDeComprobante INT
                );
            WITH    ComprobantesARealizar ( idFacturaProforma, OrdenEnElGrupo, Cantidad, SumImportes )
                      AS ( SELECT   idFacturaProforma
                                   ,OrdenEnElGrupo
                                   ,COUNT(*)
                                   ,SUM(Importe)
                           FROM     @Detalles
                           GROUP BY idFacturaProforma
                                   ,OrdenEnElGrupo
                         ),
                    Puntos ( idPuntoDeVenta, UltimoNumeroAsignado )
                      AS ( SELECT   pv.idPuntoDeVenta
                                   ,UltimoNumeroAsignado
                           FROM     dbo.PuntosDeVenta pv
                         )
                INSERT  dbo.Comprobantes
                        ( 
                         idTipoDeComprobante
                        ,Prefijo
                        ,NumeroDeComprobante
                        ,OrdenEnElGrupo
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
                        ,idCategoriaIVA
                        ,CUIT
                        ,Anulado
				        )
                OUTPUT  INSERTED.IdComprobante
                       ,INSERTED.idFacturaProforma
                       ,INSERTED.OrdenEnElGrupo
                       ,INSERTED.Prefijo
                       ,INSERTED.Importe
                       ,INSERTED.idTipoDeCobranza
                       ,INSERTED.idCobrador
                       ,INSERTED.idEntidadDeCobranza
                       ,INSERTED.idTipoDeComprobante
                        INTO @ComprobantesIngresados
                        SELECT  CASE WHEN pv.Verdadero = 1 THEN catIVA.Factura
                                     ELSE ( SELECT TOP ( 1 )
                                                    ComprobanteFactCuotaAfiliados
                                            FROM    dbo.Sistemas
                                          )
                                END
                               ,pv.Prefijo
                               ,RIGHT(REPLICATE('0', 8)
                                      + CONVERT	(VARCHAR(8), ( SELECT
                                                              CASE CASE
                                                              WHEN pv.Verdadero = 1
                                                              THEN catIVA.Factura
                                                              ELSE ( SELECT TOP ( 1 )
                                                              ComprobanteFactCuotaAfiliados
                                                              FROM
                                                              dbo.Sistemas
                                                              )
                                                              END
                                                              WHEN 4
                                                              THEN UltimoNumeroAsignado
                                                              WHEN 7
                                                              THEN UltimoNumeroAsignadoA
                                                              WHEN 8
                                                              THEN UltimoNumeroAsignadoB
                                                              END
                                                              FROM
                                                              Puntos
                                                              WHERE
                                                              idPuntoDeVenta = z.idPuntoDeVenta
                                                             )
                                      + ROW_NUMBER() OVER ( PARTITION BY z.idPuntoDeVenta ORDER BY z.idCobrador, loc.idLocalidad, z.Nombre, dir.idCalle, CAST(dbo.SoloNumeros(dir.Numero) AS INTEGER), cr.idFacturaProForma, cr.OrdenEnElGrupo )),
                                      8)
                               ,cr.OrdenEnElGrupo
                               ,CASE WHEN @fecha < dbo.UltimaFechaComprobantes(pv.Prefijo,
                                                              CASE
                                                              WHEN pv.Verdadero = 1
                                                              THEN catIVA.Factura
                                                              ELSE ( SELECT TOP ( 1 )
                                                              ComprobanteFactCuotaAfiliados
                                                              FROM
                                                              dbo.Sistemas
                                                              )
                                                              END)
                                     THEN dbo.UltimaFechaComprobantes(pv.Prefijo,
                                                              CASE
                                                              WHEN pv.Verdadero = 1
                                                              THEN catIVA.Factura
                                                              ELSE ( SELECT TOP ( 1 )
                                                              ComprobanteFactCuotaAfiliados
                                                              FROM
                                                              dbo.Sistemas
                                                              )
                                                              END)
                                     ELSE @fecha
                                END AS fecha
                               ,@periodo
                               ,dir.idCliente
                               ,cr.idFacturaProforma
                               ,fp.idTandaDeFacturacion
                               ,cli.RazonSocial
                               ,CASE WHEN c.Nombre IS NULL THEN ''
                                     ELSE c.Nombre + ' '
                                END
                                + CASE WHEN ISNULL(dir.Numero, '') = ''
                                       THEN ''
                                       ELSE dir.Numero
                                  END
                                + CASE WHEN ISNULL(dir.Piso, '') = '' THEN ''
                                       ELSE ' Piso ' + dir.Piso
                                  END
                                + CASE WHEN ISNULL(dir.Departamento, '') = ''
                                       THEN ''
                                       ELSE ' Depto. ' + dir.Departamento
                                  END AS Direccion
                               ,CASE WHEN dir.idEntreCalle1 IS NULL
                                     THEN CASE WHEN dir.idEntreCalle2 IS NULL
                                               THEN NULL
                                               ELSE 'esq. ' + e2.Nombre
                                          END
                                     ELSE CASE WHEN dir.idEntreCalle2 IS NULL
                                               THEN 'esq.' + e1.Nombre
                                               ELSE 'entre ' + e1.Nombre
                                                    + ' y ' + e2.nombre
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
                               ,CASE @ponerCobrador
                                  WHEN 0 THEN NULL
                                  ELSE CASE cli.idTipoDeCobranza
                                         WHEN 1 THEN z.idCobrador
                                         WHEN 2 THEN NULL
                                       END
                                END
                               ,cli.idCategoriaIva
                               ,cli.CUIT
                               ,0 --Campo "Anulado"
                        FROM    ComprobantesARealizar cr
                                LEFT JOIN dbo.FacturasProforma fp ON cr.idFacturaProforma = fp.idFacturaProforma
                                JOIN dbo.Clientes cli ON fp.idCliente = cli.idCliente
                                LEFT JOIN dbo.Direcciones dir ON dir.idCliente = cli.idCliente
                                LEFT JOIN dbo.Zonas z ON dir.idZona = z.idZona
                                LEFT JOIN dbo.PuntosDeVenta pv ON z.idPuntoDeVenta = pv.idPuntoDeVenta
                                LEFT JOIN dbo.Calles AS c ON dir.idCalle = c.idCalle
                                LEFT JOIN dbo.Calles AS e1 ON dir.idEntreCalle1 = e1.idCalle
                                LEFT JOIN dbo.Calles AS e2 ON dir.idEntreCalle2 = e2.idCalle
                                LEFT JOIN dbo.Localidades AS loc ON dir.idLocalidad = loc.idLocalidad
                                LEFT JOIN dbo.Barrios AS b ON dir.idBarrio = b.idBarrio
                                LEFT JOIN dbo.CategoriasIVA catIVA ON cli.idCategoriaIva = catIVA.idCategoriaIVA
                        WHERE   ( dir.Cobranza = 1 ) 
            SET @cantidadFacturas = @@ROWCOUNT
            INSERT  dbo.Ids
                    ( 
                     proceso
                    ,Id 
                    )
                    SELECT  @proceso
                           ,idComprobante
                    FROM    @ComprobantesIngresados
		-- Fin de Ingresar los comprobantes

		-- Insertar los Detalles
            INSERT  dbo.DetallesComprobantes
                    ( 
                     idRenglonFacturaProforma
                    ,Cantidad
                    ,Detalle
                    ,Importe
                    ,idComprobante
                    ,idPorcentajeIVA
                    ,idContrato
			        )
                    SELECT  det.idRenglonFacturaProforma
                           ,det.Cantidad
                           ,det.Detalle
                           ,det.Importe
                           ,gi.idComprobante
                           ,det.idPorcentajeIVA
                           ,det.idContrato
                    FROM    @detalles det
                            JOIN @ComprobantesIngresados gi ON det.idFacturaProforma = gi.idFacturaProforma
                                                              AND det.OrdenEnElGrupo = gi.OrdenEnElGrupo 
		-- Fin de Insertar los Detalles

		-- Actualización de los Puntos de Venta
            --IF @idTipoDeComprobante = 4 --Cupón
            --    BEGIN
            ;
            WITH    Puntos ( Prefijo, cantComprobantes )
                      AS ( SELECT   Prefijo
                                   ,COUNT(*)
                           FROM     @ComprobantesIngresados
                           WHERE    idTipoDeComprobante = 4
                           GROUP BY Prefijo
                         )
                UPDATE  dbo.PuntosDeVenta
                SET     UltimoNumeroAsignado = UltimoNumeroAsignado
                        + p.cantComprobantes
                FROM    dbo.PuntosDeVenta pv
                        JOIN Puntos p ON pv.Prefijo = p.Prefijo
                --END
            --IF @idTipoDeComprobante = 7 --Factura A
            --    BEGIN
            ;
            WITH    Puntos ( Prefijo, cantComprobantes )
                      AS ( SELECT   Prefijo
                                   ,COUNT(*)
                           FROM     @ComprobantesIngresados
                           WHERE    idTipoDeComprobante = 7
                           GROUP BY Prefijo
                         )
                UPDATE  dbo.PuntosDeVenta
                SET     UltimoNumeroAsignadoA = UltimoNumeroAsignadoA
                        + p.cantComprobantes
                FROM    dbo.PuntosDeVenta pv
                        JOIN Puntos p ON pv.Prefijo = p.Prefijo
                --END
            --IF @idTipoDeComprobante = 8 --Factura B
            --    BEGIN
            ;
            WITH    Puntos ( Prefijo, cantComprobantes )
                      AS ( SELECT   Prefijo
                                   ,COUNT(*)
                           FROM     @ComprobantesIngresados
                           WHERE    idTipoDeComprobante = 8
                           GROUP BY Prefijo
                         )
                UPDATE  dbo.PuntosDeVenta
                SET     UltimoNumeroAsignadoB = UltimoNumeroAsignadoB
                        + p.cantComprobantes
                FROM    dbo.PuntosDeVenta pv
                        JOIN Puntos p ON pv.Prefijo = p.Prefijo
                --END          
		-- Fin de la Actualización de los Puntos de Venta
		-- Registrar Facturación
            DECLARE @facturacionesIngresadas TABLE
                (
                 idFacturacion INT
                ,idcobrador INT
                ,idEntidadDeCobranza INT
                );
            WITH    FacturacionesAIngresar ( idTipoDeCobranza, idCobrador, idEntidadDeCobranza )
                      AS ( SELECT DISTINCT
                                    idTipoDeCobranza
                                   ,idCobrador
                                   ,idEntidadDeCobranza
                           FROM     @ComprobantesIngresados
                         )
                INSERT  dbo.Facturaciones
                        ( 
                         AfiliadosOClientes
                        ,idTipoDeCobranza
                        ,Fecha
                        ,idCobrador
                        ,idEntidadDeCobranza
                        )
                OUTPUT  INSERTED.idFacturacion
                       ,INSERTED.idCobrador
                       ,INSERTED.idEntidadDeCobranza
                        INTO @facturacionesIngresadas
                        SELECT  'C'
                               ,idTipoDeCobranza
                               ,GETDATE()
                               ,idCobrador
                               ,idEntidadDeCobranza
                        FROM    FacturacionesAIngresar

            UPDATE  dbo.Comprobantes
            SET     idFacturacion = fi.idFacturacion
            FROM    dbo.Comprobantes comp
                    JOIN @ComprobantesIngresados ci ON comp.idComprobante = ci.IdComprobante
                    JOIN @FacturacionesIngresadas fi ON ISNULL(ci.idCobrador,
                                                              0) = ISNULL(fi.idCobrador,
                                                              0)
                                                        AND ISNULL(ci.idEntidadDeCobranza,
                                                              0) = ISNULL(fi.idEntidadDeCobranza,
                                                              0)
	-- Fin de Registrar Facturación
            COMMIT TRAN
        END TRY
        BEGIN CATCH
            ROLLBACK TRAN
            SET @cantidadFacturas = 0
        END CATCH
    END


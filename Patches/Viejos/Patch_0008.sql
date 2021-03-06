USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[HacerComprobanteFactura]    Script Date: 07/26/2012 19:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[HacerComprobanteFactura]
    @idFacturaProforma int,
    @fecha varchar(17),
    @periodo varchar(7),
    @proceso varchar(255),
    @ponerCobrador bit,
    @cantidadFacturas int OUT
AS 
    BEGIN
        SET NOCOUNT ON ;
        DECLARE @maxCantDetallesPorComprobante int
        SELECT TOP 1
                @maxCantDetallesPorComprobante = MaxCantDetallesPorComprobante
        FROM    dbo.Sistemas
        DECLARE @desde datetime
        DECLARE @hasta datetime
        SET @desde = Right(dbo.PeriodoSumarMeses(@periodo, -2), 4)
            + left(dbo.PeriodoSumarMeses(@periodo, -2), 2) + '16'
        SET @hasta = Right(dbo.PeriodoSumarMeses(@periodo, -1), 4)
            + left(dbo.PeriodoSumarMeses(@periodo, -1), 2) + '15'
        DECLARE @idTipoDeComprobante int
        SELECT TOP ( 1 )
                @idTipoDeComprobante = ComprobanteFactCuotaAfiliados
        FROM    dbo.Sistemas

	-- Detalles
        DECLARE @detalles table
            (
              idFacturaProforma int,
              idRenglonFacturaProforma int,
              Cantidad int,
              Detalle varchar(300),
              Porciento decimal(10, 2),
              Importe money,
              OrdenEnElGrupo smallint
            )
        INSERT  @detalles
                (
                  idFacturaProforma,
                  idRenglonFacturaProforma,
                  Cantidad,
                  Detalle,
                  Porciento,
                  OrdenEnElGrupo
						
                )
                SELECT  fp.idFacturaProforma,
                        rfp.idRenglonFacturaProforma,
                        CASE cto.idTipoDeContrato
                          WHEN 1 THEN 1
                          WHEN 2
                          THEN CASE WHEN rfp.Cantidad is null
                                    THEN ( SELECT   Count(*)
                                           FROM     dbo.Afiliados af
                                                    OUTER APPLY dbo.EstadosDelAfiliado(af.idAfiliado, @hasta) e
                                           WHERE    e.idPlan = rfp.idPlan
                                                    AND e.Estado IN ( 'Activo', 'Alta Reciente' )
                                         )
                                    ELSE rfp.Cantidad
                               END
                          WHEN 3
                          THEN ( SELECT Count(*)
                                 FROM   dbo.Prestaciones prest
                                        JOIN dbo.Pacientes pac on pac.idPrestacion = prest.idPrestacion
                                 WHERE  prest.Tomada >= @desde
                                        AND prest.Tomada <= @hasta
                                        AND pac.idContrato = rfp.idContrato
                               )
                        END,
                        CASE cto.idTipoDeContrato
                          WHEN 1
                          THEN 'Cobertura de ' + cto.Nombre + ' mes '
                               + @periodo
                          WHEN 2
                          THEN CASE WHEN rfp.Cantidad is null
                                    THEN 'Afiliados plan ' + pl.Nombre
                                    ELSE 'Afiliados'
                               END
                          WHEN 3 THEN cto.Nombre
                        END,
                        CASE left(@periodo, 2)
                          WHEN '01'
                          THEN CASE WHEN cto.Ene = 0 THEN 0
                                    ELSE CAST(cto.Ene AS Money) / 100
                               END
                          WHEN '02'
                          THEN CASE WHEN cto.Feb = 0 THEN 0
                                    ELSE CAST(cto.Feb AS Money) / 100
                               END
                          WHEN '03'
                          THEN CASE WHEN cto.Mar = 0 THEN 0
                                    ELSE CAST(cto.Mar AS Money) / 100
                               END
                          WHEN '04'
                          THEN CASE WHEN cto.Abr = 0 THEN 0
                                    ELSE CAST(cto.Abr AS Money) / 100
                               END
                          WHEN '05'
                          THEN CASE WHEN cto.May = 0 THEN 0
                                    ELSE CAST(cto.May AS Money) / 100
                               END
                          WHEN '06'
                          THEN CASE WHEN cto.Jun = 0 THEN 0
                                    ELSE CAST(cto.Jun AS Money) / 100
                               END
                          WHEN '07'
                          THEN CASE WHEN cto.Jul = 0 THEN 0
                                    ELSE CAST(cto.Jul AS Money) / 100
                               END
                          WHEN '08'
                          THEN CASE WHEN cto.Ago = 0 THEN 0
                                    ELSE CAST(cto.Ago AS Money) / 100
                               END
                          WHEN '09'
                          THEN CASE WHEN cto.Sep = 0 THEN 0
                                    ELSE CAST(cto.Sep AS Money) / 100
                               END
                          WHEN '10'
                          THEN CASE WHEN cto.Oct = 0 THEN 0
                                    ELSE CAST(cto.Oct AS Money) / 100
                               END
                          WHEN '11'
                          THEN CASE WHEN cto.Nov = 0 THEN 0
                                    ELSE CAST(cto.Nov AS Money) / 100
                               END
                          WHEN '12'
                          THEN CASE WHEN cto.Dic = 0 THEN 0
                                    ELSE CAST(cto.Dic AS Money) / 100
                               END
                        END,
                        CEILING(CAST(Row_Number() OVER ( PARTITION BY fp.idFacturaProForma ORDER BY ( SELECT    0
                                                                                                    ) ) as Decimal)
                                / @maxCantDetallesPorComprobante)
                FROM    dbo.FacturasProforma fp
                        JOIN dbo.RenglonesFacturaProforma rfp on rfp.idFacturaProforma = fp.idFacturaProforma
                        JOIN dbo.Contratos cto on cto.idContrato = rfp.idContrato
                        LEFT JOIN dbo.Planes pl on pl.idPlan = rfp.idPlan
                WHERE   fp.idFacturaProforma = @idFacturaProforma
                        AND dbo.ContratoSeFactura(rfp.idContrato, @periodo, 1) = 1
        DELETE  @detalles
        WHERE   Cantidad = 0
                OR Porciento = 0
        UPDATE  @detalles
        SET     Importe = isNull(Round(d.Cantidad * d.Porciento
                                       * CASE WHEN rfp.PrecioUnitario IS NULL
                                              THEN isnull(pl.Cuota, 0)
                                              ELSE rfp.PrecioUnitario -- * ( 1 + fp.PorcentajeIva / 100 )
                                         END, 2), 0)
        FROM    @detalles d
                JOIN dbo.FacturasProforma fp on fp.idFacturaProforma = d.idFacturaProforma
                JOIN dbo.RenglonesFacturaProforma rfp on rfp.idRenglonFacturaProforma = d.idRenglonFacturaProforma
                LEFT JOIN dbo.Planes pl on pl.idPlan = rfp.idPlan
	-- Fin de Detalles
        BEGIN TRAN
        BEGIN TRY
		-- Ingresar los comprobantes
            DECLARE @Comprobantes table
                (
                  idTipoDeComprobante int,
                  Prefijo varchar(4),
                  NumeroDeComprobante varchar(8),
                  OrdenEnElGrupo smallint,
                  Fecha DateTime,
                  Periodo varchar(7),
                  idCliente int,
                  idFacturaProforma int,
                  idTandaDeFacturacion int,
                  Nombre varchar(200),
                  Direccion varchar(50),
                  Entre varchar(100),
                  Barrio varchar(50),
                  Localidad varchar(50),
                  idZona int,
                  ObservacionesDireccion varchar(200),
                  Importe money,
                  CantidadDeDetalles int
                )
            DECLARE @ComprobantesIngresados table
                (
                  IdComprobante int,
                  idFacturaProforma int,
                  OrdenEnElGrupo smallint,
                  Prefijo varchar(4),
                  Importe money,
                  idTipoDeCobranza int,
                  idCobrador int,
                  idEntidadDeCobranza int
                ) ;
            WITH    ComprobantesARealizar ( idFacturaProforma, OrdenEnElGrupo, Cantidad, SumImportes )
                      AS ( SELECT   idFacturaProforma,
                                    OrdenEnElGrupo,
                                    count(*),
                                    sum(Importe)
                           FROM     @Detalles
                           Group By idFacturaProforma,
                                    OrdenEnElGrupo
                         ) ,
                    Puntos ( idPuntoDeVenta, UltimoNumeroAsignado )
                      AS ( SELECT   pv.idPuntoDeVenta,
                                    UltimoNumeroAsignado
                           FROM     dbo.PuntosDeVenta pv
                         )
                INSERT  dbo.Comprobantes
                        (
                          idTipoDeComprobante,
                          Prefijo,
                          NumeroDeComprobante,
                          OrdenEnElGrupo,
                          Fecha,
                          Periodo,
                          idCliente,
                          idFacturaProforma,
                          idTandaDeFacturacion,
                          Nombre,
                          Direccion,
                          Entre,
                          Barrio,
                          Localidad,
                          idZona,
                          ObservacionesDireccion,
                          Importe,
                          CantidadDeDetalles,
                          idTipoDeCobranza,
                          idEntidadDeCobranza,
                          NumeroTarjeta,
                          idCobrador
				)
                OUTPUT  INSERTED.IdComprobante,
                        INSERTED.idFacturaProforma,
                        INSERTED.OrdenEnElGrupo,
                        INSERTED.Prefijo,
                        INSERTED.Importe,
                        inserted.idTipoDeCobranza,
                        inserted.idCobrador,
                        inserted.idEntidadDeCobranza
                        INTO @ComprobantesIngresados
                        SELECT  @idTipoDeComprobante,
                                PuntosDeVenta.Prefijo,
                                RIGHT(REPLICATE('0', 8)
                                      + CONVERT	(varchar(8), ( SELECT   UltimoNumeroAsignado
                                                               FROM     Puntos
                                                               WHERE    idPuntoDeVenta = z.idPuntoDeVenta
                                                             )
                                      + Row_Number() OVER ( PARTITION BY z.idPuntoDeVenta ORDER BY z.idCobrador, loc.idLocalidad, z.Nombre, dir.idCalle, CAST(dbo.SoloNumeros(dir.Numero) AS Integer), cr.idFacturaProForma, cr.OrdenEnElGrupo )),
                                      8),
                                cr.OrdenEnElGrupo,
                                @fecha,
                                @periodo,
                                dir.idCliente,
                                cr.idFacturaProforma,
                                fp.idTandaDeFacturacion,
                                cli.RazonSocial,
                                CASE WHEN c.Nombre IS NULL THEN ''
                                     ELSE c.Nombre + ' '
                                END
                                + CASE WHEN isnull(dir.Numero, '') = ''
                                       THEN ''
                                       ELSE dir.Numero
                                  END
                                + CASE WHEN isnull(dir.Piso, '') = '' THEN ''
                                       ELSE ' Piso ' + dir.Piso
                                  END
                                + CASE WHEN isnull(dir.Departamento, '') = ''
                                       THEN ''
                                       ELSE ' Depto. ' + dir.Departamento
                                  END AS Direccion,
                                CASE WHEN dir.idEntreCalle1 IS NULL
                                     THEN CASE WHEN dir.idEntreCalle2 IS NULL
                                               THEN null
                                               ELSE 'esq. ' + e2.Nombre
                                          END
                                     ELSE CASE WHEN dir.idEntreCalle2 IS NULL
                                               THEN 'esq.' + e1.Nombre
                                               ELSE 'entre ' + e1.Nombre
                                                    + ' y ' + e2.nombre
                                          END
                                END AS Entre,
                                b.nombre Barrio,
                                loc.Nombre,
                                dir.idZona,
                                left(dir.Observaciones, 200) AS ObservacionesDireccion,
                                cr.SumImportes,
                                cr.Cantidad,
                                cli.idTipoDeCobranza,
                                CASE cli.idTipoDeCobranza
                                  WHEN 1 THEN null
                                  WHEN 2 THEN cli.idEntidadDeCobranza
                                END,
                                CASE cli.idTipoDeCobranza
                                  WHEN 1 THEN null
                                  WHEN 2 THEN cli.NumeroTarjeta
                                END,
                                CASE @ponerCobrador
                                  WHEN 0 then null
                                  ELSE CASE cli.idTipoDeCobranza
                                         WHEN 1 THEN z.idCobrador
                                         WHEN 2 THEN null
                                       END
                                END
                        FROM    ComprobantesARealizar cr
                                LEFT JOIN dbo.FacturasProforma fp on cr.idFacturaProforma = fp.idFacturaProforma
                                JOIN dbo.Clientes cli on fp.idCliente = cli.idCliente
                                LEFT JOIN dbo.Direcciones dir on dir.idCliente = cli.idCliente
                                LEFT JOIN dbo.Zonas z ON dir.idZona = z.idZona
                                LEFT JOIN dbo.PuntosDeVenta ON z.idPuntoDeVenta = PuntosDeVenta.idPuntoDeVenta
                                LEFT JOIN dbo.Calles AS c ON dir.idCalle = c.idCalle
                                LEFT JOIN dbo.Calles AS e1 ON dir.idEntreCalle1 = e1.idCalle
                                LEFT JOIN dbo.Calles AS e2 ON dir.idEntreCalle2 = e2.idCalle
                                LEFT JOIN dbo.Localidades AS loc ON dir.idLocalidad = loc.idLocalidad
                                LEFT JOIN dbo.Barrios AS b ON dir.idBarrio = b.idBarrio
                        WHERE   ( dir.Cobranza = 1 ) 
            SET @cantidadFacturas = @@ROWCOUNT
            INSERT  dbo.Ids ( proceso, Id )
                    SELECT  @proceso,
                            idComprobante
                    FROM    @ComprobantesIngresados
		-- Fin de Ingresar los comprobantes

		-- Insertar los Detalles
            INSERT  dbo.DetallesComprobantes
                    (
                      Cantidad,
                      Detalle,
                      Importe,
                      idComprobante
			  )
                    SELECT  det.Cantidad,
                            det.Detalle,
                            det.Importe,
                            gi.idComprobante
                    FROM    @detalles det
                            JOIN @ComprobantesIngresados gi on det.idFacturaProforma = gi.idFacturaProforma
                                                               AND det.OrdenEnElGrupo = gi.OrdenEnElGrupo 
		-- Fin de Insertar los Detalles

		-- Actualización de los Puntos de Venta
		;
            WITH    Puntos ( Prefijo, cantComprobantes )
                      AS ( SELECT   Prefijo,
                                    count(*)
                           FROM     @ComprobantesIngresados
                           Group By Prefijo
                         )
                UPDATE  dbo.PuntosDeVenta
                SET     UltimoNumeroAsignado = UltimoNumeroAsignado
                        + p.cantComprobantes
                FROM    dbo.PuntosDeVenta pv
                        JOIN Puntos p on pv.Prefijo = p.Prefijo 
		-- Fin de la Actualización de los Puntos de Venta
		-- Registrar Facturación
            DECLARE @facturacionesIngresadas table
                (
                  idFacturacion int,
                  idcobrador int,
                  idEntidadDeCobranza int
                ) ;
            WITH    FacturacionesAIngresar ( idTipoDeCobranza, idCobrador, idEntidadDeCobranza )
                      AS ( SELECT DISTINCT
                                    idTipoDeCobranza,
                                    idCobrador,
                                    idEntidadDeCobranza
                           FROM     @ComprobantesIngresados
                         )
                INSERT  dbo.Facturaciones
                        (
                          AfiliadosOClientes,
                          idTipoDeCobranza,
                          Fecha,
                          idCobrador,
                          idEntidadDeCobranza
                        )
                OUTPUT  INSERTED.idFacturacion,
                        INSERTED.idCobrador,
                        INSERTED.idEntidadDeCobranza
                        INTO @facturacionesIngresadas
                        SELECT  'C',
                                idTipoDeCobranza,
                                getdate(),
                                idCobrador,
                                idEntidadDeCobranza
                        FROM    FacturacionesAIngresar

            UPDATE  dbo.Comprobantes
            SET     idFacturacion = fi.idFacturacion
            FROM    dbo.Comprobantes comp
                    JOIN @ComprobantesIngresados ci on comp.idComprobante = ci.IdComprobante
                    JOIN @FacturacionesIngresadas fi ON isnull(ci.idCobrador, 0) = isnull(fi.idCobrador, 0)
                                                        AND isnull(ci.idEntidadDeCobranza, 0) = isnull(fi.idEntidadDeCobranza, 0)
	-- Fin de Registrar Facturación
            COMMIT TRAN
        END TRY
        BEGIN CATCH
            ROLLBACK TRAN
            SET @cantidadFacturas = 0
        END CATCH
    END


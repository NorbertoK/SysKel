USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[EstadoDeLaCobranza]    Script Date: 12/15/2016 11:37:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[EstadoDeLaCobranza]
    @idCobrador int,
    @fecha varchar(8),
    @meses int,
    @mostrarFuturo varchar(1)
AS 
    BEGIN
        SET NOCOUNT ON ;
        DECLARE @periodoActual varchar(7),
            @periodoActualAlvesre varchar(7),
            @periodoInicial varchar(7),
            @periodoInicialAlvesre varchar(7),
            @desde date,
            @hasta date
        SET @periodoActual = dbo.Periodo(MONTH(@fecha), YEAR(@fecha))
        SET @periodoActualAlvesre = dbo.PeriodoAnyoMes(@periodoActual)
        SET @periodoInicial = dbo.PeriodoSumarMeses(@periodoActual,
                                                    -( @meses ))
        SET @periodoInicialAlvesre = dbo.PeriodoAnyoMes(@periodoInicial)
        SET @hasta = DATEADD(d, 1, @fecha) ;
        WITH    detalle
                  AS ( SELECT   'Recibido' AS Tipo,
                                fac.AfiliadosOClientes,
                                comp.Periodo,
                                dbo.PeriodoAnyoMes(comp.Periodo) AS AnyoMes,
                                null AS Fecha,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN COUNT(comp.idComprobante)
                                     ELSE null
                                END CantAf,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN SUM(comp.Importe)
                                     ELSE null
                                END ImporteAf,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN COUNT(comp.idComprobante)
                                     ELSE null
                                END CantCli,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN SUM(comp.Importe)
                                     ELSE null
                                END ImporteCli,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN COUNT(comp.idComprobante)
                                     ELSE null
                                END CantPrest,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN SUM(comp.Importe)
                                     ELSE null
                                END ImportePrest
                       FROM     dbo.Comprobantes comp
                                JOIN dbo.Facturaciones fac on comp.idFacturacion = fac.idFacturacion
                                JOIN dbo.Empleados emp on fac.idCobrador = emp.idEmpleado
                       WHERE    fac.idCobrador = CASE @idCobrador
                                                   WHEN 0 THEN fac.idCobrador
                                                   ELSE @idCobrador
                                                 END
                                AND dbo.PeriodoAnyoMes(comp.Periodo) >= @periodoInicialAlvesre
                                AND isnull(fac.EntregadaAlCobrador,
                                           DATEADD(d, 1, @hasta)) < @hasta
                       GROUP BY fac.AfiliadosOClientes,
                                comp.Periodo
                       UNION ALL
                       SELECT   'De Otro' AS Tipo,
                                fac.AfiliadosOClientes,
                                comp.Periodo,
                                dbo.PeriodoAnyoMes(comp.Periodo),
                                null,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN COUNT(comp.idComprobante)
                                     ELSE null
                                END CantAf,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN SUM(comp.Importe)
                                     ELSE null
                                END ImporteAf,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN COUNT(comp.idComprobante)
                                     ELSE null
                                END CantCli,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN SUM(comp.Importe)
                                     ELSE null
                                END ImporteCli,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN COUNT(comp.idComprobante)
                                     ELSE null
                                END CantPrest,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN SUM(comp.Importe)
                                     ELSE null
                                END ImportePrest
                       FROM     dbo.Comprobantes comp
                                JOIN dbo.Facturaciones fac on comp.idFacturacion = fac.idFacturacion
                                JOIN dbo.ComprobantesCambioDeCobrador ccc on comp.idComprobante = ccc.idComprobante
                                JOIN dbo.CambiosDeCobrador cc on ccc.idCambioDeCobrador = cc.idCambioDeCobrador
                                JOIN dbo.Empleados emp on cc.idCobrador2 = emp.idEmpleado
                       WHERE    dbo.PeriodoAnyoMes(comp.Periodo) >= @periodoInicialAlvesre
                                AND isnull(fac.EntregadaAlCobrador,
                                           DATEADD(d, 1, @hasta)) < @hasta
                                AND cc.Fecha < @hasta
                                AND cc.idCobrador2 = CASE @idCobrador
                                                       WHEN 0
                                                       THEN cc.idCobrador2
                                                       ELSE @idCobrador
                                                     END
                       GROUP BY fac.AfiliadosOClientes,
                                comp.Periodo
                       UNION ALL
                       SELECT   'A Otro' AS Tipo,
                                fac.AfiliadosOClientes,
                                comp.Periodo,
                                dbo.PeriodoAnyoMes(comp.Periodo),
                                null,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantAf,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN -SUM(comp.Importe)
                                     ELSE null
                                END ImporteAf,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantCli,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN -SUM(comp.Importe)
                                     ELSE null
                                END ImporteCli,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantPrest,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN -SUM(comp.Importe)
                                     ELSE null
                                END ImportePrest
                       FROM     dbo.Comprobantes comp
                                JOIN dbo.Facturaciones fac on comp.idFacturacion = fac.idFacturacion
                                JOIN dbo.ComprobantesCambioDeCobrador ccc on comp.idComprobante = ccc.idComprobante
                                JOIN dbo.CambiosDeCobrador cc on ccc.idCambioDeCobrador = cc.idCambioDeCobrador
                                JOIN dbo.Empleados emp on cc.idCobrador1 = emp.idEmpleado
                       WHERE    dbo.PeriodoAnyoMes(comp.Periodo) >= @periodoInicialAlvesre
                                AND isnull(fac.EntregadaAlCobrador,
                                           DATEADD(d, 1, @hasta)) < @hasta
                                AND cc.Fecha < @hasta
                                AND cc.idCobrador1 = CASE @idCobrador
                                                       WHEN 0
                                                       THEN cc.idCobrador1
                                                       ELSE @idCobrador
                                                     END
                                AND cc.idCobrador2 != ( SELECT TOP 1
                                                                CobradorBajas
                                                        FROM    dbo.Sistemas
                                                      )
                                AND cc.idCobrador2 != ( SELECT TOP 1
                                                                CobradorMorosos
                                                        FROM    dbo.Sistemas
                                                      )
                       GROUP BY fac.AfiliadosOClientes,
                                comp.Periodo
                       UNION ALL
                       SELECT   'Cobrado' AS Tipo,
                                fac.AfiliadosOClientes,
                                comp.Periodo,
                                dbo.PeriodoAnyoMes(comp.Periodo),
                                CAST(r.Fecha AS DATE),
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantAf,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN -SUM(cr.ImporteCobrado)
                                     ELSE null
                                END ImporteAf,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantCli,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN -SUM(cr.ImporteCobrado)
                                     ELSE null
                                END ImporteCli,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantPrest,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN -SUM(cr.ImporteCobrado)
                                     ELSE null
                                END ImportePrest
                       FROM     dbo.Comprobantes comp
                                JOIN dbo.Facturaciones fac on comp.idFacturacion = fac.idFacturacion
                                JOIN dbo.ComprobantesRemesas cr on comp.idComprobante = cr.idReferencia
                                JOIN dbo.Remesas r on cr.idRemesa = r.idRemesa
                                JOIN dbo.Empleados emp on comp.idCobrador = emp.idEmpleado
                       WHERE    comp.idCobrador = CASE @idCobrador
                                                    WHEN 0
                                                    THEN comp.idCobrador
                                                    ELSE @idCobrador
                                                  END
                                AND dbo.PeriodoAnyoMes(comp.Periodo) >= @periodoInicialAlvesre
                                AND isnull(fac.EntregadaAlCobrador,
                                           DATEADD(d, 1, @hasta)) < @hasta
                                AND r.Fecha < @hasta
                                AND r.idCobrador = CASE @idCobrador
                                                     WHEN 0 THEN r.idCobrador
                                                     ELSE @idCobrador
                                                   END
                       GROUP BY fac.AfiliadosOClientes,
                                comp.Periodo,
                                r.Fecha
                       UNION ALL
                       SELECT   'A Bajas' AS Tipo,
                                fac.AfiliadosOClientes,
                                comp.Periodo,
                                dbo.PeriodoAnyoMes(comp.Periodo),
                                null,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantAf,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN -SUM(comp.Importe)
                                     ELSE null
                                END ImporteAf,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantCli,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN -SUM(comp.Importe)
                                     ELSE null
                                END ImporteCli,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantPrest,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN -SUM(comp.Importe)
                                     ELSE null
                                END ImportePrest
                       FROM     dbo.Comprobantes comp
                                JOIN dbo.Facturaciones fac on comp.idFacturacion = fac.idFacturacion
                                JOIN dbo.ComprobantesCambioDeCobrador ccc on comp.idComprobante = ccc.idComprobante
                                JOIN dbo.CambiosDeCobrador cc on ccc.idCambioDeCobrador = cc.idCambioDeCobrador
                                JOIN dbo.Empleados emp on cc.idCobrador1 = emp.idEmpleado
                       WHERE    dbo.PeriodoAnyoMes(comp.Periodo) >= @periodoInicialAlvesre
                                AND isnull(fac.EntregadaAlCobrador,
                                           DATEADD(d, 1, @hasta)) < @hasta
                                AND cc.Fecha < @hasta
                                AND cc.idCobrador1 = CASE @idCobrador
                                                       WHEN 0
                                                       THEN cc.idCobrador1
                                                       ELSE @idCobrador
                                                     END
                                AND cc.idCobrador2 = ( SELECT TOP 1
                                                                CobradorBajas
                                                       FROM     dbo.Sistemas
                                                     )
                       GROUP BY fac.AfiliadosOClientes,
                                comp.Periodo
                       UNION ALL
                       SELECT   'Bajas Arqueo' AS Tipo,
                                fac.AfiliadosOClientes,
                                comp.Periodo,
                                dbo.PeriodoAnyoMes(comp.Periodo),
                                null,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantAf,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN -SUM(comp.Importe)
                                     ELSE null
                                END ImporteAf,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantCli,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN -SUM(comp.Importe)
                                     ELSE null
                                END ImporteCli,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantPrest,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN -SUM(comp.Importe)
                                     ELSE null
                                END ImportePrest
                       FROM     dbo.Comprobantes comp
                                JOIN dbo.Facturaciones fac on comp.idFacturacion = fac.idFacturacion
                                JOIN dbo.ComprobantesArqueos ca on comp.idComprobante = ca.idComprobante
                                JOIN dbo.Arqueos a on ca.idArqueo = a.idArqueo
                                JOIN dbo.Empleados emp on a.idCobrador = emp.idEmpleado
                       WHERE    dbo.PeriodoAnyoMes(comp.Periodo) >= @periodoInicialAlvesre
                                AND isnull(fac.EntregadaAlCobrador,
                                           DATEADD(d, 1, @hasta)) < @hasta
                                AND a.Fecha < @hasta
                                AND a.idCobrador = CASE @idCobrador
                                                     WHEN 0 THEN a.idCobrador
                                                     ELSE @idCobrador
                                                   END
                                AND ca.idMotivoDevolucionCobranza = ( SELECT TOP 1
                                                                                MotivoDevolucionCobranza_Baja
                                                                      FROM      dbo.Sistemas
                                                                    )
                       GROUP BY fac.AfiliadosOClientes,
                                comp.Periodo
                       UNION ALL
                       SELECT   'A Morosos' AS Tipo,
                                fac.AfiliadosOClientes,
                                comp.Periodo,
                                dbo.PeriodoAnyoMes(comp.Periodo),
                                null,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantAf,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN -SUM(comp.Importe)
                                     ELSE null
                                END ImporteAf,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantCli,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN -SUM(comp.Importe)
                                     ELSE null
                                END ImporteCli,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantPrest,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN -SUM(comp.Importe)
                                     ELSE null
                                END ImportePrest
                       FROM     dbo.Comprobantes comp
                                JOIN dbo.Facturaciones fac on comp.idFacturacion = fac.idFacturacion
                                JOIN dbo.ComprobantesCambioDeCobrador ccc on comp.idComprobante = ccc.idComprobante
                                JOIN dbo.CambiosDeCobrador cc on ccc.idCambioDeCobrador = cc.idCambioDeCobrador
                                JOIN dbo.Empleados emp on cc.idCobrador1 = emp.idEmpleado
                       WHERE    dbo.PeriodoAnyoMes(comp.Periodo) >= @periodoInicialAlvesre
                                AND isnull(fac.EntregadaAlCobrador,
                                           DATEADD(d, 1, @hasta)) < @hasta
                                AND cc.Fecha < @hasta
                                AND cc.idCobrador1 = CASE @idCobrador
                                                       WHEN 0
                                                       THEN cc.idCobrador1
                                                       ELSE @idCobrador
                                                     END
                                AND cc.idCobrador2 = ( SELECT TOP 1
                                                                CobradorMorosos
                                                       FROM     dbo.Sistemas
                                                     )
                       GROUP BY fac.AfiliadosOClientes,
                                comp.Periodo
                       UNION ALL
                       SELECT   'Mostrador' AS Tipo,
                                fac.AfiliadosOClientes,
                                comp.Periodo,
                                dbo.PeriodoAnyoMes(comp.Periodo),
                                null,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantAf,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN -SUM(comp.Importe)
                                     ELSE null
                                END ImporteAf,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantCli,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN -SUM(comp.Importe)
                                     ELSE null
                                END ImporteCli,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN -COUNT(comp.idComprobante)
                                     ELSE null
                                END CantPrest,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN -SUM(comp.Importe)
                                     ELSE null
                                END ImportePrest
                       FROM     dbo.Comprobantes comp
                                JOIN dbo.Facturaciones fac on comp.idFacturacion = fac.idFacturacion
                                JOIN dbo.ComprobantesRemesas cr on comp.idComprobante = cr.idReferencia
                                JOIN dbo.Remesas r on cr.idRemesa = r.idRemesa
                                JOIN dbo.Empleados emp on comp.idCobrador = emp.idEmpleado
                       WHERE    comp.idCobrador = CASE @idCobrador
                                                    WHEN 0
                                                    THEN comp.idCobrador
                                                    ELSE @idCobrador
                                                  END
                                AND dbo.PeriodoAnyoMes(comp.Periodo) >= @periodoInicialAlvesre
                                AND isnull(fac.EntregadaAlCobrador,
                                           DATEADD(d, 1, @hasta)) < @hasta
                                AND r.Fecha < @hasta
                                AND r.idCobrador is null
                       GROUP BY fac.AfiliadosOClientes,
                                comp.Periodo
                       UNION ALL
                       SELECT   'NdeC' AS Tipo,
                                fac.AfiliadosOClientes,
                                comp.Periodo,
                                dbo.PeriodoAnyoMes(comp.Periodo),
                                null,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN -SUM(CASE WHEN nc.Importe = comp.Importe
                                                    THEN 1
                                                    ELSE 0
                                               END)
                                     ELSE null
                                END CantAf,
                                CASE WHEN fac.AfiliadosOClientes = 'A'
                                     THEN -SUM(nc.Importe)
                                     ELSE null
                                END ImporteAf,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN -SUM(CASE WHEN nc.Importe = comp.Importe
                                                    THEN 1
                                                    ELSE 0
                                               END)
                                     ELSE null
                                END CantCli,
                                CASE WHEN fac.AfiliadosOClientes = 'C'
                                     THEN -SUM(nc.Importe)
                                     ELSE null
                                END ImporteCli,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN -SUM(CASE WHEN nc.Importe = comp.Importe
                                                    THEN 1
                                                    ELSE 0
                                               END)
                                     ELSE null
                                END CantPrest,
                                CASE WHEN fac.AfiliadosOClientes = 'P'
                                     THEN -SUM(nc.Importe)
                                     ELSE null
                                END ImportePrest
                       FROM     dbo.Comprobantes comp
                                JOIN dbo.Facturaciones fac on comp.idFacturacion = fac.idFacturacion
                                JOIN dbo.Comprobantes nc on comp.idComprobante = nc.idReferencia
                                JOIN dbo.Empleados emp on comp.idCobrador = emp.idEmpleado
                       WHERE    comp.idCobrador = CASE @idCobrador
                                                    WHEN 0
                                                    THEN comp.idCobrador
                                                    ELSE @idCobrador
                                                  END
                                AND dbo.PeriodoAnyoMes(comp.Periodo) >= @periodoInicialAlvesre
                                AND isnull(fac.EntregadaAlCobrador,
                                           DATEADD(d, 1, @hasta)) < @hasta
                                AND nc.idTipoDeComprobante = ( SELECT TOP 1
                                                                        NotaDeCredito
                                                               FROM     dbo.Sistemas
                                                             )
                                AND nc.Fecha < @hasta
                       GROUP BY fac.AfiliadosOClientes,
                                comp.Periodo
                     )
            SELECT  CASE Tipo
                      WHEN 'Recibido' THEN 1
                      WHEN 'De Otro' THEN 2
                      WHEN 'A Otro' THEN 3
                      WHEN 'Cobrado' THEN 4
                      WHEN 'Mostrador' THEN 5
                      WHEN 'Bajas Arqueo' THEN 6
                      WHEN 'A Bajas' THEN 7
                      WHEN 'A Morosos' THEN 8
                      WHEN 'NdeC' THEN 9
                    END AS Orden,
                    Tipo,
                    Periodo,
                    AnyoMes,
                    Fecha,
                    SUM(CantAf) AS CantA,
                    SUM(ImporteAf) AS ImporteA,
                    SUM(CantCli) AS CantC,
                    SUM(ImporteCli) AS ImporteC,
                    SUM(CantPrest) AS CantP,
                    SUM(ImportePrest) AS ImporteP
            FROM    detalle
            WHERE   AnyoMes <= CASE @mostrarFuturo
                                 WHEN 'N' THEN @periodoActualAlvesre
                                 ELSE AnyoMes
                               END
            GROUP BY Tipo,
                    Periodo,
                    AnyoMes,
                    Fecha
            ORDER BY AnyoMes,
                    Periodo,
                    Orden,
                    Fecha
    END


USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[HacerComprobantes]    Script Date: 07/29/2014 12:54:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[HacerComprobantes]
    @periodo VARCHAR(7)
   ,@idTipoDeCobranza INT
   ,@cantComprobantes INT OUTPUT
AS 
    SET NOCOUNT ON 
    DECLARE @maxCantDetallesPorComprobante INT
    SELECT TOP 1
            @maxCantDetallesPorComprobante = MaxCantDetallesPorComprobante
    FROM    dbo.Sistemas
    DECLARE @fechaComprobante SMALLDATETIME
    SET @fechaComprobante = CONVERT(DATETIME, RIGHT(@periodo, 4) + LEFT(@periodo, 2) + '01', 101)
    DECLARE @fechaInicioCobertura SMALLDATETIME
    SET @fechaInicioCobertura = CONVERT(DATETIME, RIGHT(@periodo, 4) + LEFT(@periodo, 2) + '01', 101)
    DECLARE @desdeDiaRegaloMes SMALLDATETIME
    DECLARE @dia INT
    SELECT TOP 1
            @dia = DesdeDiaRegaloMes
    FROM    dbo.Parametros
    SET @desdeDiaRegaloMes = DATEADD(Day, @dia - 1, DATEADD(Month, -1, @fechaInicioCobertura))
    DECLARE @idFacturacion INT

-- Detalles
    DECLARE @detalles TABLE
        (
         nombre VARCHAR(100)
        ,idPlan INT
        ,cuota MONEY
        ,idAfiliado INT
        ,idGrupo INT
        ,OrdenEnElGrupo SMALLINT
        ,afiliados INT
        ,descuento MONEY
        ) ;
    WITH    gruposAFacturar ( idGrupo )
              AS ( SELECT   g.idGrupo
                   FROM     dbo.Grupos g
                   WHERE    idTipoDeCobranza = @idTipoDeCobranza
                            AND ( SELECT    COUNT(*)
                                  FROM      dbo.Comprobantes
                                  WHERE     idGrupo = g.idgrupo
                                            AND Periodo = @periodo
                                            AND ISNULL(Anulado,0) = 0
                                ) = 0
                 )
        INSERT  @detalles
                ( 
                 nombre
                ,idPlan
                ,cuota
                ,idAfiliado
                ,idGrupo
                ,OrdenEnElGrupo
                    
                )
                SELECT  af.NombApel
                       ,pa.idPlan idPlan
                       ,CASE WHEN ISNULL(g.Importe, 0) = 0 THEN ISNULL(CASE WHEN af.Titular = 1 THEN pl.Cuota
                                                                            ELSE pl.CuotaAdherente
                                                                       END, 0)
                             ELSE 0
                        END
                       ,af.idAfiliado
                       ,af.idGrupo
                       ,CEILING(CAST(Row_Number() OVER ( PARTITION BY af.idGrupo ORDER BY ( SELECT  0
                                                                                          ) ) AS DECIMAL) / @maxCantDetallesPorComprobante)
                FROM    ( SELECT    s.idAfiliado
                                   ,Aux.idPlan idPlan
                                   ,S.AltaBajaSusp Estado
                          FROM      dbo.AfiliadosPlanes AP
                          INNER JOIN dbo.Solicitudes S ON S.idSolicitud = AP.idSolicitud
                          INNER JOIN dbo.Afiliados afi ON afi.idAfiliado = S.idAfiliado
                          INNER JOIN ( SELECT   S.idAfiliado
                                               ,ap.idPlan
                                               ,MAX(S.idSolicitud) idSolicitud
                                       FROM     dbo.AfiliadosPlanes AP
                                       INNER JOIN dbo.Solicitudes S ON S.idSolicitud = AP.idSolicitud
                                       WHERE    ( ( S.FechaFinal IS NULL
                                                    OR S.FechaFinal < CONVERT(DATETIME, RIGHT(@periodo, 4) + LEFT(@periodo, 2) + '01', 101)
                                                  )
                                                  AND s.Fecha < CASE WHEN s.AltaBajaSusp = 'A'
                                                                     THEN CASE WHEN s.EsCambioDePlan = 1
                                                                               THEN CONVERT(DATETIME, RIGHT(@periodo, 4) + LEFT(@periodo, 2) + '01', 101)
                                                                               ELSE DATEADD(Day, ( SELECT TOP 1
                                                                                                            DesdeDiaRegaloMes
                                                                                                   FROM     dbo.Parametros
                                                                                                 ) - 1,
                                                                                            DATEADD(Month, -1,
                                                                                                    CONVERT(DATETIME, RIGHT(@periodo, 4) + LEFT(@periodo, 2)
                                                                                                    + '01', 101)))
                                                                          END
                                                                     ELSE CONVERT(DATETIME, RIGHT(@periodo, 4) + LEFT(@periodo, 2) + '01', 101)
                                                                END
                                                )
                                       GROUP BY S.idAfiliado
                                               ,ap.idPlan
                                     ) Aux ON Aux.idPlan = AP.idPlan
                                              AND Aux.idSolicitud = AP.idSolicitud
                          WHERE     idGrupo IN ( SELECT idGrupo
                                                 FROM   gruposAFacturar )
                        ) pa
                JOIN    dbo.Afiliados af ON ( af.idAfiliado = pa.idAfiliado )
                JOIN    dbo.Planes pl ON ( pl.idPlan = pa.idPlan )
                JOIN    dbo.Grupos g ON af.idGrupo = g.idGrupo
                WHERE   pa.Estado = 'A'
                        AND pl.idContrato IS NULL ;
	-- Descuentos por Grupo Numeroso
	;
    WITH    afiliadosPorGrupo ( idGrupo, Afiliados )
              AS ( SELECT   idGrupo
                           ,COUNT(DISTINCT idAfiliado)
                   FROM     @detalles
                   GROUP BY idGrupo
                 )
        UPDATE  @detalles
        SET     afiliados = a.Afiliados
        FROM    @detalles d
        JOIN    afiliadosPorGrupo a ON d.idGrupo = a.idGrupo
    UPDATE  @detalles
    SET     descuento = descu.Descuento
           ,cuota = ROUND(cuota * ( 1 - descu.Descuento / 100 ), 0)
    FROM    @detalles det
    JOIN    dbo.DescuentosGrupoNumeroso descu ON det.idPlan = descu.idPlan
    WHERE   descu.Afiliados = ( SELECT  MAX(Afiliados)
                                FROM    dbo.DescuentosGrupoNumeroso
                                WHERE   Afiliados <= det.afiliados
                              )
	-- Fin de Descuentos por Grupo Numeroso
	
	-- Suma del importe del grupo al titular
    UPDATE  @detalles
    SET     cuota = cuota + CASE WHEN ( SELECT  Titular
                                        FROM    dbo.Afiliados
                                        WHERE   idAfiliado = det.idAfiliado
                                      ) = 1 THEN ( SELECT   ISNULL(Importe, 0)
                                                   FROM     dbo.Grupos
                                                   WHERE    idGrupo = det.idGrupo
                                                 )
                                 ELSE 0
                            END
    FROM    @detalles det
	-- Fin de Suma del importe del grupo al titular
-- Fin de Detalles
    BEGIN TRAN
    BEGIN TRY
	-- Ingresar los comprobantes
        DECLARE @ComprobantesIngresados TABLE
            (
             IdComprobante INT
            ,idGrupo INT
            ,OrdenEnElGrupo SMALLINT
            ,Prefijo VARCHAR(4)
            ,Importe MONEY
            ,idCobrador INT
            ,idEntidadDeCobranza INT
            ) ;
        WITH    ComprobantesARealizar ( idGrupo, OrdenEnElGrupo, Cantidad, SumImportes )
                  AS ( SELECT   idGrupo
                               ,OrdenEnElGrupo
                               ,COUNT(*)
                               ,SUM(Cuota)
                       FROM     @Detalles
                       GROUP BY idGrupo
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
                    ,idGrupo
                    ,Nombre
                    ,Apellido
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
			  )
            OUTPUT  INSERTED.IdComprobante
                   ,INSERTED.idGrupo
                   ,INSERTED.OrdenEnElGrupo
                   ,INSERTED.Prefijo
                   ,INSERTED.Importe
                   ,INSERTED.idCobrador
                   ,INSERTED.idEntidadDeCobranza
                    INTO @ComprobantesIngresados
                    SELECT  CASE WHEN ( SELECT TOP 1
                                                EmiteFacturasAyB
                                        FROM    dbo.Parametros
                                      ) = 1 THEN catIVA.Factura
                                 ELSE ( SELECT TOP ( 1 )
                                                ComprobanteFactCuotaAfiliados
                                        FROM    dbo.Sistemas
                                      )
                            END
                           ,PuntosDeVenta.Prefijo
                           ,RIGHT(REPLICATE('0', 8) + CONVERT	(VARCHAR(8), ( SELECT CASE WHEN ( SELECT  EmiteFacturasAyB
                                                                                                    FROM    dbo.Parametros
                                                                                                  ) = 1 THEN UltimoNumeroAsignadoB
                                                                                             ELSE UltimoNumeroAsignado
                                                                                        END
                                                                                 FROM   Puntos
                                                                                 WHERE  idPuntoDeVenta = z.idPuntoDeVenta
                                                                               )
                                  + Row_Number() OVER ( PARTITION BY z.idPuntoDeVenta ORDER BY z.idCobrador, loc.idLocalidad, z.Nombre, dir.idCalle, CAST(dbo.SoloNumeros(dir.Numero) AS INTEGER), cr.idGrupo, cr.OrdenEnElGrupo )),
                                  8)
                           ,cr.OrdenEnElGrupo
                           ,CASE WHEN @fechaInicioCobertura < dbo.UltimaFechaComprobantes(PuntosDeVenta.Prefijo,
                                                                                          CASE WHEN ( SELECT TOP 1
                                                                                                                EmiteFacturasAyB
                                                                                                      FROM      dbo.Parametros
                                                                                                    ) = 1 THEN catIVA.Factura
                                                                                               ELSE ( SELECT TOP ( 1 )
                                                                                                                ComprobanteFactCuotaAfiliados
                                                                                                      FROM      dbo.Sistemas
                                                                                                    )
                                                                                          END)
                                 THEN dbo.UltimaFechaComprobantes(PuntosDeVenta.Prefijo, CASE WHEN ( SELECT TOP 1
                                                                                                            EmiteFacturasAyB
                                                                                                     FROM   dbo.Parametros
                                                                                                   ) = 1 THEN catIVA.Factura
                                                                                              ELSE ( SELECT TOP ( 1 )
                                                                                                            ComprobanteFactCuotaAfiliados
                                                                                                     FROM   dbo.Sistemas
                                                                                                   )
                                                                                         END)
                                 ELSE @fechaInicioCobertura
                            END
                           ,@periodo
                           ,dir.idGrupo
                           ,af.Nombre
                           ,af.Apellido
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
                           ,@idTipoDeCobranza
                           ,CASE g.idTipoDeCobranza
                              WHEN 1 THEN NULL
                              WHEN 2 THEN g.idEntidadDeCobranza
                            END
                           ,CASE g.idTipoDeCobranza
                              WHEN 1 THEN NULL
                              WHEN 2 THEN g.NumeroTarjeta
                            END
                           ,CASE g.idTipoDeCobranza
                              WHEN 1 THEN z.idCobrador
                              WHEN 2 THEN NULL
                            END
                    FROM    ComprobantesARealizar cr
                    JOIN    dbo.Grupos g ON cr.idGrupo = g.idGrupo
                    LEFT JOIN dbo.Direcciones dir ON dir.idGrupo = cr.idGrupo
                    LEFT JOIN dbo.Zonas z ON dir.idZona = z.idZona
                    LEFT JOIN dbo.PuntosDeVenta ON z.idPuntoDeVenta = PuntosDeVenta.idPuntoDeVenta
                    LEFT JOIN dbo.Calles AS c ON dir.idCalle = c.idCalle
                    LEFT JOIN dbo.Calles AS e1 ON dir.idEntreCalle1 = e1.idCalle
                    LEFT JOIN dbo.Calles AS e2 ON dir.idEntreCalle2 = e2.idCalle
                    LEFT JOIN dbo.Localidades AS loc ON dir.idLocalidad = loc.idLocalidad
                    LEFT JOIN dbo.Barrios AS b ON dir.idBarrio = b.idBarrio
                    LEFT JOIN dbo.Afiliados af ON af.idGrupo = cr.idGrupo
                    JOIN    dbo.CategoriasIVA catIVA ON catIVA.idCategoriaIVA = g.idCategoriaIVA
                    WHERE   ( dir.Cobranza = 1 )
                            AND ( af.Titular = 1 )
                            AND dbo.AfiliadoActivoCualquierPlan(af.idAfiliado, @fechaComprobante) = 1 
        SET @cantComprobantes = @@ROWCOUNT
	-- Fin de Ingresar los comprobantes

	-- Insertar los Detalles
        INSERT  dbo.DetallesComprobantes
                ( 
                 nombre
                ,idPlan
                ,Importe
                ,idAfiliado
                ,idComprobante
                ,PjeDescuento
		    )
                SELECT  det.Nombre
                       ,det.idPlan
                       ,det.cuota
                       ,det.idAfiliado
                       ,gi.idComprobante
                       ,det.descuento
                FROM    @detalles det
                JOIN    @ComprobantesIngresados gi ON det.idGrupo = gi.idGrupo
                                                      AND det.OrdenEnElGrupo = gi.OrdenEnElGrupo 
	-- Fin de Insertar los Detalles

	-- Actualización de los Puntos de Venta
	
        IF ( SELECT TOP 1
                    EmiteFacturasAyB
             FROM   dbo.Parametros
           ) = 1 
            BEGIN
                ;
                WITH    Puntos ( Prefijo, cantComprobantes )
                          AS ( SELECT   Prefijo
                                       ,COUNT(*)
                               FROM     @ComprobantesIngresados
                               GROUP BY Prefijo
                             )
                    UPDATE  dbo.PuntosDeVenta
                    SET     UltimoNumeroAsignadoB = UltimoNumeroAsignadoB + p.cantComprobantes
                    FROM    dbo.PuntosDeVenta pv
                    JOIN    Puntos p ON pv.Prefijo = p.Prefijo
            END
        ELSE 
            BEGIN
                ;
                WITH    Puntos ( Prefijo, cantComprobantes )
                          AS ( SELECT   Prefijo
                                       ,COUNT(*)
                               FROM     @ComprobantesIngresados
                               GROUP BY Prefijo
                             )
                    UPDATE  dbo.PuntosDeVenta
                    SET     UltimoNumeroAsignado = UltimoNumeroAsignado + p.cantComprobantes
                    FROM    dbo.PuntosDeVenta pv
                    JOIN    Puntos p ON pv.Prefijo = p.Prefijo
            END
            
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
                    ,idTipoDeCobranza
                    ,Fecha
                    ,idCobrador
                    ,idEntidadDeCobranza
                    )
            OUTPUT  INSERTED.idFacturacion
                   ,INSERTED.idCobrador
                   ,INSERTED.idEntidadDeCobranza
                    INTO @facturacionesIngresadas
                    SELECT  'A'
                           ,@periodo
                           ,@idTipoDeCobranza
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
        SET @cantComprobantes = 0
    END CATCH








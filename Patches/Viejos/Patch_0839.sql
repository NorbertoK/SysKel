USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[HacerComprobanteCuota]    Script Date: 04/17/2017 14:04:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[HacerComprobanteCuota]
    (
     @idGrupo INT = 0
    ,@fecha VARCHAR(8)
    ,@periodo VARCHAR(7) = ''
    ,@proceso VARCHAR(255) = ''
    ,@ponerCobrador BIT
    )
AS 
    SET NOCOUNT ON
    IF ( SELECT COUNT(*)
         FROM   dbo.Comprobantes
         WHERE  idGrupo = @idgrupo
                AND Periodo = @periodo
                AND ISNULL(Anulado, 0) = 0
       ) > 0 
        RETURN 0
    DECLARE @idTipoDeCobranza INT
    DECLARE @idEntidadDeCobranza INT
    DECLARE @NumeroTarjeta VARCHAR(30)
    SELECT  @idTipoDeCobranza = idTipoDeCobranza
           ,@idEntidadDeCobranza = CASE idTipoDeCobranza
                                     WHEN 2 THEN idEntidadDeCobranza
                                     ELSE NULL
                                   END
           ,@NumeroTarjeta = CASE idTipoDeCobranza
                               WHEN 2 THEN NumeroTarjeta
                               ELSE NULL
                             END
    FROM    dbo.Grupos
    WHERE   idGrupo = @idGrupo
    DECLARE @idTipoDeComprobante INT
    SELECT  @idTipoDeComprobante = CASE WHEN ( SELECT   pv.Verdadero
                                               FROM     dbo.Direcciones dir
                                                        JOIN dbo.Zonas z ON dir.idZona = z.idZona
                                                        JOIN dbo.PuntosDeVenta pv ON z.idPuntoDeVenta = pv.idPuntoDeVenta
                                               WHERE    Real = 1
                                                        AND dir.idGrupo = @idGrupo
                                             ) = 1
                                        THEN ( SELECT   catIVA.Factura
                                               FROM     dbo.Grupos g
                                                        JOIN dbo.CategoriasIVA catIVA ON catIVA.idCategoriaIVA = g.idCategoriaIVA
                                               WHERE    g.idGrupo = @idGrupo
                                             )
                                        ELSE ( SELECT TOP ( 1 )
                                                        ComprobanteFactCuotaAfiliados
                                               FROM     dbo.Sistemas
                                             )
                                   END
    DECLARE @idPorcentajeIVA INT
    SELECT TOP 1
            @idPorcentajeIVA = IVAAfiliados
    FROM    dbo.Parametros
    DECLARE @idComprobante INT
    SET @idComprobante = 0
    DECLARE @cantidadDetalles INT
    DECLARE @cantidadAfiliados INT
    DECLARE @cantidadComprobantes INT
    DECLARE @nComprobante INT
    DECLARE @maxCantDetallesPorComprobante INT
    DECLARE @cantidadDeDetalles INT
    DECLARE @idNegocio INT
    SELECT TOP 1
            @maxCantDetallesPorComprobante = MaxCantDetallesPorComprobante
           ,@idNegocio = NegocioAfiliados
    FROM    dbo.Sistemas
    SET @nComprobante = 1
    DECLARE @detalles TABLE
        (
         renglon INT IDENTITY(1, 1)
        ,nombre VARCHAR(100)
        ,idPlan INT
        ,cuota MONEY
        ,idAfiliado INT
        ,idPorcentajeIVA INT
        )
    INSERT  @detalles
            ( 
             nombre
            ,idPlan
            ,cuota
            ,idAfiliado
            ,idPorcentajeIVA
            )
            SELECT  af.Nombre + ' ' + af.Apellido Nombre
                   ,pa.idPlan idPlan
                   ,ISNULL(CASE WHEN af.Titular = 1 THEN pl.Cuota
                                ELSE pl.CuotaAdherente
                           END, 0)
                   ,af.idAfiliado
                   ,@idPorcentajeIVA
            FROM    ( SELECT    s.idAfiliado
                               ,Aux.idPlan idPlan
                               ,S.AltaBajaSusp Estado
                      FROM      dbo.AfiliadosPlanes AP
                                INNER JOIN dbo.Solicitudes S ON S.idSolicitud = AP.idSolicitud
                                INNER JOIN dbo.Afiliados afi ON afi.idAfiliado = S.idAfiliado
                                                              AND afi.idGrupo = @idGrupo
                                INNER JOIN ( SELECT S.idAfiliado
                                                   ,ap.idPlan
                                                   ,MAX(S.idSolicitud) idSolicitud
                                             FROM   dbo.AfiliadosPlanes AP
                                                    INNER JOIN dbo.Solicitudes S ON S.idSolicitud = AP.idSolicitud
                                             WHERE  ( ( S.FechaFinal IS NULL
                                                        OR S.FechaFinal < CONVERT(DATETIME, RIGHT(@periodo,
                                                              4)
                                                        + LEFT(@periodo, 2)
                                                        + '01', 101)
                                                      )
                                                      AND s.Fecha < CASE
                                                              WHEN s.AltaBajaSusp = 'A'
                                                              THEN CASE
                                                              WHEN s.EsCambioDePlan = 1
                                                              THEN CONVERT(DATETIME, RIGHT(@periodo,
                                                              4)
                                                              + LEFT(@periodo,
                                                              2) + '01', 101)
                                                              ELSE DATEADD(Day,
                                                              ( SELECT TOP 1
                                                              DesdeDiaRegaloMes
                                                              FROM
                                                              dbo.Parametros
                                                              ) - 1,
                                                              DATEADD(Month, 0,
                                                              CONVERT(DATETIME, RIGHT(@periodo,
                                                              4)
                                                              + LEFT(@periodo,
                                                              2) + '01', 101)))
                                                              END
                                                              ELSE DATEADD(DAY,
                                                              1, GETDATE())
                                                              END
                                                    )
                                             GROUP BY S.idAfiliado
                                                   ,ap.idPlan
                                           ) Aux ON Aux.idPlan = AP.idPlan
                                                    AND Aux.idSolicitud = AP.idSolicitud
                    ) pa
                    JOIN dbo.Afiliados af ON ( af.idAfiliado = pa.idAfiliado )
                    JOIN dbo.Planes pl ON ( pl.idPlan = pa.idPlan )
                    JOIN dbo.Grupos g ON af.idGrupo = g.idGrupo
            WHERE   pa.Estado = 'A'
                    AND pl.idContrato IS NULL
    SET @cantidadDetalles = @@ROWCOUNT
    SET @cantidadComprobantes = CEILING(CAST(@cantidadDetalles AS DECIMAL)
                                        / @maxCantDetallesPorComprobante) 
    BEGIN TRANSACTION
    BEGIN TRY
        WHILE @nComprobante <= @cantidadComprobantes 
            BEGIN
                INSERT  dbo.Comprobantes
                        ( 
                         idTipoDeComprobante
                        ,Prefijo
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
                        ,idTipoDeCobranza
                        ,idEntidadDeCobranza
                        ,NumeroTarjeta
                        ,idCobrador
                        ,idCategoriaIVA
                        ,CUIT
                        )
                        SELECT  @idTipoDeComprobante
                               ,PuntosDeVenta.Prefijo
                               ,CASE WHEN @fecha < dbo.UltimaFechaComprobantes(PuntosDeVenta.Prefijo,
                                                              @idTipoDeComprobante)
                                     THEN dbo.UltimaFechaComprobantes(PuntosDeVenta.Prefijo,
                                                              @idTipoDeComprobante)
                                     ELSE @fecha
                                END AS fecha
                               ,@periodo AS periodo
                               ,@idGrupo AS idGrupo
                               ,Afiliados.Nombre Nombre
                               ,Afiliados.Apellido Apellido
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
                               ,loc.Nombre AS Localidad
                               ,dir.idZona
                               ,dir.Observaciones AS ObservacionesDireccion
                               ,@idTipoDeCobranza
                               ,@idEntidadDeCobranza
                               ,@NumeroTarjeta
                               ,CASE @ponerCobrador
                                  WHEN 0 THEN NULL
                                  ELSE CASE g.idTipoDeCobranza
                                         WHEN 1 THEN z.idCobrador
                                         WHEN 2 THEN NULL
                                       END
                                END
                               ,g.idCategoriaIVA
                               ,g.CUIT
                        FROM    dbo.Grupos g
                                LEFT JOIN dbo.Direcciones dir ON g.idGrupo = dir.idGrupo
                                LEFT JOIN dbo.Zonas z ON dir.idZona = z.idZona
                                LEFT JOIN dbo.PuntosDeVenta ON z.idPuntoDeVenta = PuntosDeVenta.idPuntoDeVenta
                                LEFT JOIN dbo.Calles AS c ON dir.idCalle = c.idCalle
                                LEFT JOIN dbo.Calles AS e1 ON dir.idEntreCalle1 = e1.idCalle
                                LEFT JOIN dbo.Calles AS e2 ON dir.idEntreCalle2 = e2.idCalle
                                LEFT JOIN dbo.Localidades AS loc ON dir.idLocalidad = loc.idLocalidad
                                LEFT JOIN dbo.Barrios AS b ON dir.idBarrio = b.idBarrio
                                CROSS JOIN dbo.Afiliados
                        WHERE   ( dir.idGrupo = @idGrupo )
                                AND ( dir.Cobranza = 1 )
                                AND ( Afiliados.idGrupo = @idGrupo )
                                AND ( Afiliados.Titular = 1 )
                                AND dbo.AfiliadoActivoCualquierPlan(Afiliados.idAfiliado,
                                                              GETDATE()) = 1 
                SET @idComprobante = SCOPE_IDENTITY();
                INSERT  dbo.Ids
                        ( Proceso, Id )
                VALUES  ( @proceso, @idComprobante )
                IF ( SELECT pv.Verdadero
                     FROM   dbo.Direcciones dir
                            JOIN dbo.Zonas z ON dir.idZona = z.idZona
                            JOIN dbo.PuntosDeVenta pv ON z.idPuntoDeVenta = pv.idPuntoDeVenta
                     WHERE  Real = 1
                            AND dir.idGrupo = @idGrupo
                   ) = 1 
                    BEGIN
                        IF @idTipoDeComprobante = 7 --Factura A
                            BEGIN
                                UPDATE  dbo.PuntosDeVenta
                                SET     UltimoNumeroAsignadoA = UltimoNumeroAsignadoA
                                        + 1
                                WHERE   idPuntoDeVenta = ( SELECT
                                                              pv.idPuntoDeVenta
                                                           FROM
                                                              dbo.Comprobantes comp
                                                              LEFT JOIN dbo.PuntosDeVenta pv ON pv.Prefijo = comp.Prefijo
                                                           WHERE
                                                              comp.idComprobante = @idComprobante
                                                         )
                                UPDATE  dbo.Comprobantes
                                SET     NumeroDeComprobante = ( SELECT
                                                              RIGHT(REPLICATE('0',
                                                              8)
                                                              + CONVERT(VARCHAR(8), UltimoNumeroAsignadoA),
                                                              8)
                                                              FROM
                                                              dbo.PuntosDeVenta
                                                              WHERE
                                                              idPuntoDeVenta = ( SELECT
                                                              pv.idPuntoDeVenta
                                                              FROM
                                                              dbo.Comprobantes comp
                                                              LEFT JOIN dbo.PuntosDeVenta pv ON pv.Prefijo = comp.Prefijo
                                                              WHERE
                                                              comp.idComprobante = @idComprobante
                                                              )
                                                              )
                                WHERE   idComprobante = @idComprobante
                            END
                        IF @idTipoDeComprobante = 8 --Factura B
                            BEGIN
                                UPDATE  dbo.PuntosDeVenta
                                SET     UltimoNumeroAsignadoB = UltimoNumeroAsignadoB
                                        + 1
                                WHERE   idPuntoDeVenta = ( SELECT
                                                              pv.idPuntoDeVenta
                                                           FROM
                                                              dbo.Comprobantes comp
                                                              LEFT JOIN dbo.PuntosDeVenta pv ON pv.Prefijo = comp.Prefijo
                                                           WHERE
                                                              comp.idComprobante = @idComprobante
                                                         )
                                UPDATE  dbo.Comprobantes
                                SET     NumeroDeComprobante = ( SELECT
                                                              RIGHT(REPLICATE('0',
                                                              8)
                                                              + CONVERT(VARCHAR(8), UltimoNumeroAsignadoB),
                                                              8)
                                                              FROM
                                                              dbo.PuntosDeVenta
                                                              WHERE
                                                              idPuntoDeVenta = ( SELECT
                                                              pv.idPuntoDeVenta
                                                              FROM
                                                              dbo.Comprobantes comp
                                                              LEFT JOIN dbo.PuntosDeVenta pv ON pv.Prefijo = comp.Prefijo
                                                              WHERE
                                                              comp.idComprobante = @idComprobante
                                                              )
                                                              )
                                WHERE   idComprobante = @idComprobante
                            END
                    END
                ELSE -- Punto de Venta Verdadero = 0
                    BEGIN
                        UPDATE  dbo.PuntosDeVenta
                        SET     UltimoNumeroAsignado = UltimoNumeroAsignado
                                + 1
                        WHERE   idPuntoDeVenta = ( SELECT   pv.idPuntoDeVenta
                                                   FROM     dbo.Comprobantes comp
                                                            LEFT JOIN dbo.PuntosDeVenta pv ON pv.Prefijo = comp.Prefijo
                                                   WHERE    comp.idComprobante = @idComprobante
                                                 )
                        UPDATE  dbo.Comprobantes
                        SET     NumeroDeComprobante = ( SELECT
                                                              RIGHT(REPLICATE('0',
                                                              8)
                                                              + CONVERT(VARCHAR(8), UltimoNumeroAsignado),
                                                              8)
                                                        FROM  dbo.PuntosDeVenta
                                                        WHERE idPuntoDeVenta = ( SELECT
                                                              pv.idPuntoDeVenta
                                                              FROM
                                                              dbo.Comprobantes comp
                                                              LEFT JOIN dbo.PuntosDeVenta pv ON pv.Prefijo = comp.Prefijo
                                                              WHERE
                                                              comp.idComprobante = @idComprobante
                                                              )
                                                      )
                        WHERE   idComprobante = @idComprobante
                    END
                INSERT  dbo.DetallesComprobantes
                        ( 
                         idComprobante
                        ,Nombre
                        ,idPlan
                        ,Importe
                        ,idAfiliado
                        ,idNegocio
                        ,idPorcentajeIVA
                        )
                        SELECT  @idComprobante
                               ,nombre
                               ,idPlan
                               ,cuota
                               ,idAfiliado
                               ,@idNegocio
                               ,@idPorcentajeIVA
                        FROM    @detalles pa
                        WHERE   pa.renglon BETWEEN ( 1
                                                     + @maxCantDetallesPorComprobante
                                                     * ( @nComprobante - 1 ) )
                                           AND     ( @maxCantDetallesPorComprobante
                                                     * @nComprobante ) 
                SET @cantidadDeDetalles = @@ROWCOUNT
                UPDATE  dbo.Comprobantes
                SET     Importe = ( SELECT  SUM(Importe)
                                    FROM    dbo.DetallesComprobantes
                                    WHERE   idComprobante = @idComprobante
                                  )
                       ,CantidadDeDetalles = @cantidadDeDetalles
                WHERE   idComprobante = @idComprobante
                SET @nComprobante = @nComprobante + 1
            END
        -- Registrar Facturación
        DECLARE @facturacionesIngresadas TABLE
            (
             idFacturacion INT
            ,idcobrador INT
            ,idEntidadDeCobranza INT
            );
        WITH    FacturacionesAIngresar ( idCobrador, idEntidadDeCobranza )
                  AS ( SELECT DISTINCT
                                idCobrador
                               ,idEntidadDeCobranza
                       FROM     dbo.Comprobantes comp
                                JOIN dbo.ids i ON comp.idComprobante = i.id
                       WHERE    i.Proceso = @proceso
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
                    SELECT  'A'
                           ,@idTipoDeCobranza
                           ,GETDATE()
                           ,idCobrador
                           ,idEntidadDeCobranza
                    FROM    FacturacionesAIngresar

        UPDATE  dbo.Comprobantes
        SET     idFacturacion = fi.idFacturacion
        FROM    dbo.Comprobantes comp
                JOIN dbo.ids i ON comp.idComprobante = i.id
                JOIN @FacturacionesIngresadas fi ON ISNULL(comp.idCobrador, 0) = ISNULL(fi.idCobrador,
                                                              0)
                                                    AND ISNULL(comp.idEntidadDeCobranza,
                                                              0) = ISNULL(fi.idEntidadDeCobranza,
                                                              0)
        WHERE   i.Proceso = @proceso
	-- Fin de Registrar Facturación

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        RETURN 0
    END CATCH
    RETURN @cantidadComprobantes


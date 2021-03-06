USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[HacerComprobantePrestacion]    Script Date: 04/17/2014 17:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[HacerComprobantePrestacion] ( @idPrestacion INT = 0 )
AS 
    SET NOCOUNT ON
    IF ( SELECT COUNT(*)
         FROM   dbo.Comprobantes
         WHERE  idPrestacion = @idPrestacion
       ) > 0 
        RETURN
    DECLARE @numeroDeComprobante VARCHAR(8)
    DECLARE @idComprobante INT
    DECLARE @idtipoRecibo INT
    DECLARE @cantidadDeDetalles INT
    SELECT TOP 1
            @idtipoRecibo = Recibo
    FROM    dbo.Sistemas
    BEGIN TRANSACTION
    BEGIN TRY
        UPDATE  dbo.PuntosDeVenta
        SET     UltimoNumeroAsignado = UltimoNumeroAsignado + 1
        WHERE   idPuntoDeVenta = ( SELECT TOP 1
                                            PuntoDeVentaPrestaciones
                                   FROM     dbo.Sistemas
                                 )
        SELECT  @NumeroDeComprobante = ( SELECT RIGHT(REPLICATE('0', 8) + CONVERT(VARCHAR(8), UltimoNumeroAsignado), 8)
                                         FROM   dbo.PuntosDeVenta
                                         WHERE  idPuntoDeVenta = ( SELECT TOP 1
                                                                            PuntoDeVentaPrestaciones
                                                                   FROM     dbo.Sistemas
                                                                 )
                                       )
    -- Hago el Comprobante
        INSERT  dbo.Comprobantes
                ( 
                 idTipoDeComprobante
                ,Prefijo
                ,NumeroDeComprobante
                ,Fecha
                ,Periodo
                ,idPrestacion
                ,Nombre
                ,Direccion
                ,Entre
                ,Barrio
                ,Localidad
                ,ObservacionesDireccion
                )
                SELECT  ( SELECT TOP 1
                                    ComprobanteFactPrestaciones
                          FROM      dbo.Sistemas
                        )
                       ,( SELECT    pv.Prefijo
                          FROM      dbo.PuntosDeVenta pv
                          JOIN      dbo.Sistemas sist ON sist.PuntoDeVentaPrestaciones = pv.idPuntoDeVenta
                        )
                       ,@numeroDeComprobante
                       ,CASE WHEN prest.Tomada < dbo.UltimaFechaComprobantes(( SELECT   pv.Prefijo
                                                                               FROM     dbo.PuntosDeVenta pv
                                                                               JOIN     dbo.Sistemas sist ON sist.PuntoDeVentaPrestaciones = pv.idPuntoDeVenta
                                                                             ), ( SELECT TOP 1
                                                                                            ComprobanteFactPrestaciones
                                                                                  FROM      dbo.Sistemas
                                                                                ))
                             THEN dbo.UltimaFechaComprobantes(( SELECT  pv.Prefijo
                                                                FROM    dbo.PuntosDeVenta pv
                                                                JOIN    dbo.Sistemas sist ON sist.PuntoDeVentaPrestaciones = pv.idPuntoDeVenta
                                                              ), ( SELECT TOP 1
                                                                            ComprobanteFactPrestaciones
                                                                   FROM     dbo.Sistemas
                                                                 ))
                             ELSE prest.Tomada
                        END AS fecha
                       ,RIGHT(CONVERT(VARCHAR(10), prest.Tomada, 103), 7)
                       ,@idPrestacion AS idPrestacion
                       ,pac.Nombre Nombre
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
                       ,loc.Nombre AS Localidad
                       ,dir.Observaciones AS ObservacionesDireccion
                FROM    dbo.Prestaciones prest
                LEFT JOIN dbo.Direcciones AS dir ON dir.idDestino = dbo.PrimerDestino(@idPrestacion)
                LEFT JOIN dbo.Calles AS c ON dir.idCalle = c.idCalle
                LEFT JOIN dbo.Calles AS e1 ON dir.idEntreCalle1 = e1.idCalle
                LEFT JOIN dbo.Calles AS e2 ON dir.idEntreCalle2 = e2.idCalle
                LEFT JOIN dbo.Localidades AS loc ON dir.idLocalidad = loc.idLocalidad
                LEFT JOIN dbo.Barrios AS b ON dir.idBarrio = b.idBarrio
                LEFT JOIN dbo.Pacientes pac ON pac.idPaciente = dbo.PrimerPaciente(@idPrestacion)
                WHERE   prest.idPrestacion = @idPrestacion
        SET @idComprobante = SCOPE_IDENTITY() ;
    --Detalle
        INSERT  dbo.DetallesComprobantes
                ( 
                 idComprobante
                ,idPaciente
                ,Nombre
                ,Cantidad
                ,Detalle
                ,Importe
                )
                SELECT  @idComprobante
                       ,idPaciente
                       ,Nombre
                       ,1
                       ,'Prestación Nº ' + ( SELECT Numero
                                             FROM   dbo.Prestaciones
                                             WHERE  idPrestacion = @idPrestacion
                                           )
                       ,Importe
                FROM    dbo.Pacientes
                WHERE   idPrestacion = @idPrestacion
                        AND ISNULL(Importe, 0) > 0
        SET @cantidadDeDetalles = @@ROWCOUNT
        UPDATE  dbo.Comprobantes
        SET     Importe = ( SELECT  SUM(Importe)
                            FROM    dbo.DetallesComprobantes
                            WHERE   idComprobante = @idComprobante
                          )
               ,CantidadDeDetalles = @cantidadDeDetalles
        WHERE   idComprobante = @idComprobante
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        RETURN
    END CATCH

    RETURN


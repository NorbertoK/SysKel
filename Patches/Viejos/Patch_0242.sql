USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[EstadoDelAfiliado]    Script Date: 12/20/2013 18:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[EstadoDelAfiliado]
    (
     @idAfiliado INT
    ,@fecha SMALLDATETIME = NULL
    )
AS 
    SET NOCOUNT ON
    DECLARE @cantPlanes INT
    IF @fecha IS NULL 
        SET @fecha = GETDATE()

    SELECT  @idAfiliado idAfiliado
           ,Aux.idPlan
           ,CASE WHEN S.AltaBajaSusp = 'A' THEN CASE WHEN S.EsCambioDePlan = 0
                                                          AND S.Fecha <= @fecha
                                                          AND DATEADD(day, ( SELECT TOP 1
                                                                                    DiasDeCarencia
                                                                             FROM   dbo.Parametros
                                                                           ), S.Fecha) > @fecha THEN CAST('Alta Reciente' AS VARCHAR)
                                                     WHEN S.Fecha > @fecha THEN CAST('Alta Futura' AS VARCHAR)
                                                     ELSE CASE ( SELECT COUNT(*)
                                                                 FROM   dbo.Comprobantes comp
                                                                 JOIN   dbo.Afiliados af ON comp.idGrupo = af.idGrupo
                                                                 WHERE  af.idAfiliado = @idAfiliado
                                                                        AND comp.Periodo != dbo.PeríodoDeUnaFecha(@fecha)
                                                                        AND comp.idTipoDeComprobante IN ( SELECT    idTipoDeComprobante
                                                                                                          FROM      dbo.TiposDeComprobante
                                                                                                          WHERE     EsFactura = 1 )
                                                                        AND comp.Saldo > 0
                                                               )
                                                            WHEN 0 THEN 'Activo'
                                                            WHEN 1 THEN 'Debe 1 mes'
                                                            ELSE 'Debe ' + ( SELECT CAST(COUNT(*) AS VARCHAR(10))
                                                                             FROM   dbo.Comprobantes comp
                                                                             JOIN   dbo.Afiliados af ON comp.idGrupo = af.idGrupo
                                                                             WHERE  af.idAfiliado = @idAfiliado
                                                                                    AND comp.Periodo != dbo.PeríodoDeUnaFecha(@fecha)
                                                                                    AND comp.idTipoDeComprobante IN ( SELECT    idTipoDeComprobante
                                                                                                              FROM      dbo.TiposDeComprobante
                                                                                                              WHERE     EsFactura = 1 )
                                                                                    AND comp.Saldo > 0
                                                                           ) + ' meses'
                                                          END
                                                END
                 WHEN S.AltaBajaSusp = 'B' THEN 'Baja'
                 WHEN S.AltaBajaSusp = 'S' THEN 'Suspendido'
            END Estado
    FROM    dbo.AfiliadosPlanes AP
    INNER JOIN Solicitudes S ON S.idSolicitud = AP.idSolicitud
    INNER JOIN ( SELECT ap.idPlan
                       ,MAX(S.idSolicitud) idSolicitud
                 FROM   dbo.AfiliadosPlanes AP
                 INNER JOIN dbo.Solicitudes S ON S.idSolicitud = AP.idSolicitud
                 WHERE  ( ( S.FechaFinal IS NULL )
                          OR ( s.FechaFinal > @fecha )
                        )
                        AND s.idAfiliado = @idAfiliado
                        AND ( s.AltaBajaSusp = 'A'
                              OR s.Fecha <= @fecha
                            )
                 GROUP BY ap.idPlan
               ) Aux ON Aux.idPlan = AP.idPlan
                        AND Aux.idSolicitud = AP.idSolicitud
    SET @cantPlanes = @@ROWCOUNT
    IF @cantPlanes = 0 
        BEGIN
            SELECT  idAfiliado
                   ,0
                   ,''
            FROM    dbo.Afiliados
            WHERE   idAfiliado = @idafiliado

        END

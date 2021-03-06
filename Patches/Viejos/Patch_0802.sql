USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[Caja]    Script Date: 02/04/2017 17:37:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Caja]
    @idEmpleado INT
   ,@desde VARCHAR(8)
   ,@hasta VARCHAR(8)
AS 
    BEGIN
        SET NOCOUNT ON ;
        SELECT  Fecha AS [Fecha y Hora]
               ,CASE WHEN Detalle IS NOT NULL THEN Detalle
                     ELSE CASE WHEN idCobrador IS NOT NULL THEN 'Cobranza de ' + ( SELECT   NombApel
                                                                                   FROM     dbo.Empleados
                                                                                   WHERE    idEmpleado = r.idCobrador
                                                                                 )
                               ELSE CASE WHEN ( SELECT TOP 1
                                                        idPrestacion
                                                FROM    dbo.ComprobantesRemesas
                                                WHERE   idRemesa = r.idRemesa
                                              ) IS NOT NULL THEN 'Prestación Nº ' + ( SELECT    p.Numero
                                                                                      FROM      dbo.ComprobantesRemesas cr
                                                                                      JOIN      dbo.Prestaciones p ON p.idPrestacion = cr.idPrestacion
                                                                                      WHERE     idRemesa = r.idRemesa
                                                                                    )
                                         ELSE CASE WHEN ( SELECT TOP 1
                                                                    comp.idPrestacion
                                                          FROM      dbo.ComprobantesRemesas cr
                                                          JOIN      dbo.Comprobantes comp ON comp.idComprobante = cr.idReferencia
                                                          WHERE     idRemesa = r.idRemesa
                                                        ) IS NOT NULL
                                                   THEN 'Prestación Nº ' + ( SELECT p.Numero
                                                                             FROM   dbo.ComprobantesRemesas cr
                                                                             JOIN   dbo.Comprobantes comp ON comp.idComprobante = cr.idReferencia
                                                                             JOIN   dbo.Prestaciones p ON p.idPrestacion = comp.idPrestacion
                                                                             WHERE  idRemesa = r.idRemesa
                                                                           )
                                                   ELSE ( SELECT TOP 1
                                                                    comp.NombApel
                                                          FROM      dbo.ComprobantesRemesas cr
                                                          JOIN      dbo.Comprobantes comp ON comp.idComprobante = cr.idReferencia
                                                          WHERE     idRemesa = r.idRemesa
                                                        )
                                              END
                                    END
                          END
                END AS Detalle
               ,Importe AS Ingresos
               ,NULL AS Egresos
               ,u.Iniciales AS Grabador
        FROM    dbo.Remesas r
        JOIN    dbo.Usuarios u ON u.idUsuario = r.idGrabador
        WHERE   idReceptor = @idEmpleado
                AND Fecha BETWEEN @desde AND dbo.medianoche(@hasta)
        UNION ALL
        SELECT  t.Fecha
               ,'Transferencia a ' + ( SELECT   NombApel
                                       FROM     dbo.Empleados
                                       WHERE    idEmpleado = t.A
                                     )
               ,NULL
               ,t.Importe
               ,u.Iniciales
        FROM    dbo.Transferencias t
        JOIN    dbo.Usuarios u ON u.idUsuario = t.idGrabador
        WHERE   t.De = @idEmpleado
                AND Fecha BETWEEN @desde AND dbo.medianoche(@hasta)
        UNION ALL
        SELECT  t.Fecha
               ,'Transferencia de ' + ( SELECT  NombApel
                                        FROM    dbo.Empleados
                                        WHERE   idEmpleado = t.De
                                      )
               ,t.Importe
               ,NULL
               ,u.Iniciales
        FROM    dbo.Transferencias t
        JOIN    dbo.Usuarios u ON u.idUsuario = t.idGrabador
        WHERE   t.A = @idEmpleado
                AND Fecha BETWEEN @desde AND dbo.medianoche(@hasta)
        UNION ALL
        SELECT  r.Fecha
               ,'Retiro de Caja'
               ,NULL
               ,r.Importe
               ,u.Iniciales
        FROM    dbo.Retiros r
        JOIN    dbo.Usuarios u ON u.idUsuario = r.idGrabador
        WHERE   r.De = @idEmpleado
                AND Fecha BETWEEN @desde AND dbo.medianoche(@hasta)
        UNION ALL
        SELECT  r.Fecha
               ,'Reintegro de Caja'
               ,r.Importe
               ,NULL
               ,u.Iniciales
        FROM    dbo.Reintegros r
        JOIN    dbo.Usuarios u ON u.idUsuario = r.idGrabador
        WHERE   r.A = @idEmpleado
                AND Fecha BETWEEN @desde AND dbo.medianoche(@hasta)
        UNION ALL
        SELECT  p.Fecha,
                CASE WHEN p.idProveedor is null THEN 'Pago'
                     ELSE 'Pago a ' + ( SELECT  NombreCompleto
                                        FROM    dbo.Proveedores
                                        WHERE   idProveedor = p.idProveedor
                                      )
                END,
                null,
                p.Importe,
                u.Iniciales
        FROM    dbo.OrdenesDePago p
                JOIN dbo.Usuarios u on u.idUsuario = p.idGrabador
        WHERE   p.idEmpleado = @idEmpleado
                AND Fecha Between @desde AND dbo.medianoche(@hasta)
        UNION ALL
        SELECT  CAST(@desde AS DATETIME)
               ,'Saldo Inicial'
               ,ISNULL(dbo.SaldoCaja(@idEmpleado, CONVERT(VARCHAR(8), DATEADD(dd, -1, @desde), 112)), 0)
               ,NULL
               ,NULL
        ORDER BY 1
    END


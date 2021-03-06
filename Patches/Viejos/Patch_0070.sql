USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[Caja]    Script Date: 03/18/2013 22:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Caja]
    @idEmpleado int,
    @desde varchar(8),
    @hasta varchar(8)
AS 
    BEGIN
        SET NOCOUNT ON ;
        SELECT  Fecha as [Fecha y Hora],
                CASE WHEN Detalle is not null THEN Detalle
                     ELSE CASE WHEN idCobrador is not null
                               THEN 'Cobranza de '
                                    + ( SELECT  NombApel
                                        FROM    dbo.Empleados
                                        WHERE   idEmpleado = r.idCobrador
                                      )
                               ELSE CASE WHEN ( SELECT TOP 1
                                                        idPrestacion
                                                FROM    dbo.ComprobantesRemesas
                                                WHERE   idRemesa = r.idRemesa
                                              ) is not null
                                         THEN 'Prestación Nº '
                                              + ( SELECT    p.Numero
                                                  FROM      dbo.ComprobantesRemesas cr
                                                            JOIN dbo.Prestaciones p ON p.idPrestacion = cr.idPrestacion
                                                  WHERE     idRemesa = r.idRemesa
                                                )
                                         ELSE CASE WHEN ( SELECT TOP 1
                                                                    comp.idPrestacion
                                                          FROM      dbo.ComprobantesRemesas cr
                                                                    JOIN dbo.Comprobantes comp on comp.idComprobante = cr.idReferencia
                                                          WHERE     idRemesa = r.idRemesa
                                                        ) is not null
                                                   THEN 'Prestación Nº '
                                                        + ( SELECT  p.Numero
                                                            FROM    dbo.ComprobantesRemesas cr
                                                                    JOIN dbo.Comprobantes comp on comp.idComprobante = cr.idReferencia
                                                                    JOIN dbo.Prestaciones p ON p.idPrestacion = comp.idPrestacion
                                                            WHERE   idRemesa = r.idRemesa
                                                          )
                                                   ELSE ( SELECT TOP 1
                                                                    comp.NombApel
                                                          FROM      dbo.ComprobantesRemesas cr
                                                                    JOIN dbo.Comprobantes comp on comp.idComprobante = cr.idReferencia
                                                          WHERE     idRemesa = r.idRemesa
                                                        )
                                              END
                                    END
                          END
                END AS Detalle,
                Importe AS Ingresos,
                null AS Egresos,
                u.Iniciales AS Grabador
        FROM    dbo.Remesas r
                JOIN dbo.Usuarios u on u.idUsuario = r.idGrabador
        WHERE   idReceptor = @idEmpleado
                AND Fecha Between @desde AND dbo.medianoche(@hasta)
        UNION ALL
        SELECT  t.Fecha,
                'Transferencia a ' + ( SELECT   NombApel
                                       FROM     dbo.Empleados
                                       WHERE    idEmpleado = t.A
                                     ),
                null,
                t.Importe,
                u.Iniciales
        FROM    dbo.Transferencias t
                JOIN dbo.Usuarios u on u.idUsuario = t.idGrabador
        WHERE   t.De = @idEmpleado
                AND Fecha Between @desde AND dbo.medianoche(@hasta)
        UNION ALL
        SELECT  t.Fecha,
                'Transferencia de ' + ( SELECT  NombApel
                                        FROM    dbo.Empleados
                                        WHERE   idEmpleado = t.De
                                      ),
                t.Importe,
                null,
                u.Iniciales
        FROM    dbo.Transferencias t
                JOIN dbo.Usuarios u on u.idUsuario = t.idGrabador
        WHERE   t.A = @idEmpleado
                AND Fecha Between @desde AND dbo.medianoche(@hasta)
        UNION ALL
        SELECT  r.Fecha,
                'Retiro de Caja',
                null,
                r.Importe,
                u.Iniciales
        FROM    dbo.Retiros r
                JOIN dbo.Usuarios u on u.idUsuario = r.idGrabador
        WHERE   r.De = @idEmpleado
                AND Fecha Between @desde AND dbo.medianoche(@hasta)
        UNION ALL
        SELECT  r.Fecha,
                'Reintegro de Caja',
                r.Importe,
                null,
                u.Iniciales
        FROM    dbo.Reintegros r
                JOIN dbo.Usuarios u on u.idUsuario = r.idGrabador
        WHERE   r.A = @idEmpleado
                AND Fecha Between @desde AND dbo.medianoche(@hasta)
        UNION ALL
        SELECT  p.Fecha,
                CASE WHEN p.idProveedor is null THEN 'Pago'
                     ELSE 'Pago a ' + ( SELECT  Nombre
                                        FROM    dbo.Proveedores
                                        WHERE   idProveedor = p.idProveedor
                                      )
                END,
                null,
                p.Importe,
                u.Iniciales
        FROM    dbo.Compras p
                JOIN dbo.Usuarios u on u.idUsuario = p.idGrabador
        WHERE   p.idPagador = @idEmpleado
                AND Fecha Between @desde AND dbo.medianoche(@hasta)
        UNION ALL
        SELECT  CAST(@desde AS DateTime),
                'Saldo Inicial',
                isnull(dbo.SaldoCaja(@idEmpleado,
                                     Convert(varchar(8), DateAdd(dd, -1, @desde), 112)),
                       0),
                null,
                null
        ORDER BY 1
    END


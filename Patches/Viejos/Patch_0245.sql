USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[EstadoDelCliente]    Script Date: 12/20/2013 18:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[EstadoDelCliente]
    (
     @idCliente INT
    ,@fecha SMALLDATETIME = NULL
    )
AS 
    SET NOCOUNT ON
    IF @fecha IS NULL 
        SET @fecha = GETDATE()

    SELECT  @idCliente idCliente
           ,aux.Contrato
           ,CASE WHEN S.AltaBajaSusp = 'A' THEN CASE ( SELECT   COUNT(*)
                                                       FROM     dbo.Comprobantes comp
                                                       WHERE    comp.idCliente = @idCliente
                                                                AND comp.Periodo != dbo.PeríodoDeUnaFecha(@fecha)
                                                                AND comp.idTipoDeComprobante IN ( SELECT    idTipoDeComprobante
                                                                                                  FROM      dbo.TiposDeComprobante
                                                                                                  WHERE     EsFactura = 1 )
                                                                AND comp.Saldo > 0
                                                     )
                                                  WHEN 0 THEN 'Activo'
                                                  WHEN 1 THEN 'Debe 1 mes'
                                                  ELSE 'Debe ' + ( SELECT   CAST(COUNT(*) AS VARCHAR(10))
                                                                   FROM     dbo.Comprobantes comp
                                                                   WHERE    comp.idCliente = @idCliente
                                                                            AND comp.Periodo != dbo.PeríodoDeUnaFecha(@fecha)
                                                                            AND comp.idTipoDeComprobante IN ( SELECT    idTipoDeComprobante
                                                                                                              FROM      dbo.TiposDeComprobante
                                                                                                              WHERE     EsFactura = 1 )
                                                                            AND comp.Saldo > 0
                                                                 ) + ' meses'
                                                END
                 WHEN S.AltaBajaSusp = 'B' THEN 'Baja'
                 WHEN S.AltaBajaSusp = 'S' THEN 'Suspendido'
            END Estado
    FROM    dbo.Solicitudes S
    JOIN    ( SELECT    c.Nombre Contrato
                       ,MAX(S.idSolicitud) idSolicitud
              FROM      dbo.Solicitudes S
              JOIN      dbo.Contratos c ON c.idContrato = S.idContrato
              WHERE     ( ( S.FechaFinal IS NULL )
                          OR ( s.FechaFinal > @fecha )
                        )
                        AND S.Fecha <= @fecha
                        AND c.idCliente = @idCliente
              GROUP BY  c.nombre
            ) Aux ON aux.idSolicitud = S.idSolicitud







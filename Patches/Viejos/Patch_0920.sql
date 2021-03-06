USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[EstadosDelCliente]    Script Date: 11/01/2018 12:58:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[EstadosDelCliente]
    (
     @idCliente INT
    ,@fecha DATE = NULL
    )
RETURNS @table_variable TABLE
    (
     idCliente INT
    ,idContrato INT
    ,Estado VARCHAR(20)
    )
    --WITH SCHEMABINDING
AS 
    BEGIN
        INSERT  INTO @table_variable
                SELECT  @idCliente idCliente
                       ,aux.idContrato
                       ,CASE WHEN S.AltaBajaSusp = 'A' THEN CASE ( SELECT   COUNT(*)
                                                                   FROM     dbo.Comprobantes comp
                                                                   WHERE    comp.idCliente = @idCliente
                                                                            AND comp.Periodo != dbo.PeríodoDeUnaFecha(@fecha)
                                                                            AND comp.idTipoDeComprobante IN ( SELECT    idTipoDeComprobante
                                                                                                              FROM      dbo.TiposDeComprobante
                                                                                                              WHERE     EsFactura = 1 )
                                                                            AND comp.Saldo > 0
                                                                            AND ISNULL(Anulado,0) = 0
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
                                                                                        AND ISNULL(Anulado,0) = 0
                                                                             ) + ' meses'
                                                            END
                             WHEN S.AltaBajaSusp = 'B' THEN 'Baja'
                             WHEN S.AltaBajaSusp = 'S' THEN 'Suspendido'
                        END Estado
                FROM    dbo.Solicitudes S
                JOIN    ( SELECT    c.idContrato idContrato
                                   ,MAX(S.idSolicitud) idSolicitud
                          FROM      dbo.Solicitudes S
                          JOIN      dbo.Contratos c ON c.idContrato = S.idContrato
                          WHERE     ( ( S.FechaFinal IS NULL )
                                      OR ( s.FechaFinal > @fecha )
                                    )
                                    AND S.Fecha <= DATEADD(day, 1, @fecha)
                                    AND c.idCliente = @idCliente
                          GROUP BY  c.idContrato
                        ) Aux ON aux.idSolicitud = S.idSolicitud
        RETURN
    END

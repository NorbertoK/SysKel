USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[ContratoSeFactura]    Script Date: 02/27/2018 18:52:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER FUNCTION [dbo].[ContratoSeFactura]
    (
      @idContrato INT ,
      @periodo VARCHAR(7) ,
      @verificaSiFacturado BIT
    )
RETURNS BIT
AS 
    BEGIN
        DECLARE @Result BIT
        DECLARE @fechaUltimaSolicitud DATE
        DECLARE @periodoUltimaSolicitud VARCHAR(7)
        DECLARE @fecha DATE
        SET @fecha = RIGHT(@periodo, 4) + LEFT(@periodo, 2) + '01'
        SELECT  @fechaUltimaSolicitud = fecha
        FROM    dbo.Solicitudes
        WHERE   idSolicitud = ( SELECT  MAX(idSolicitud)
                                FROM    Solicitudes
                                WHERE   idContrato = @idContrato
                              )
        SELECT  @periodoUltimaSolicitud = dbo.Periodo(MONTH(@fechaUltimaSolicitud),
                                                      YEAR(@fechaUltimaSolicitud))
        SET @Result = CASE WHEN ( SELECT    CASE LEFT(@periodo, 2)
                                              WHEN '01' THEN cto.Ene
                                              WHEN '02' THEN cto.Feb
                                              WHEN '03' THEN cto.Mar
                                              WHEN '04' THEN cto.Abr
                                              WHEN '05' THEN cto.May
                                              WHEN '06' THEN cto.Jun
                                              WHEN '07' THEN cto.Jul
                                              WHEN '08' THEN cto.Ago
                                              WHEN '09' THEN cto.Sep
                                              WHEN '10' THEN cto.Oct
                                              WHEN '11' THEN cto.Nov
                                              WHEN '12' THEN cto.Dic
                                            END
                                  FROM      dbo.Contratos cto
                                  WHERE     cto.idContrato = @idContrato
                                ) > 0
                                AND ( SELECT    S.AltaBajaSusp
                                      FROM      Solicitudes S
                                                JOIN ( SELECT MAX(S.idSolicitud) idSolicitud
                                                       FROM   Solicitudes S
                                                       WHERE  ( ( S.FechaFinal IS NULL )
                                                              OR ( s.FechaFinal > @fecha )
                                                              )
                                                              AND S.idContrato = @idContrato
                                                       GROUP BY S.idContrato
                                                     ) Aux ON aux.idSolicitud = S.idSolicitud
                                    ) = 'A'
                                AND ( dbo.RestaPeriodos(@periodo,
                                                        @periodoUltimaSolicitud) > 0
                                      OR ( @periodoUltimaSolicitud = @periodo
                                           AND DAY(@fechaUltimaSolicitud) < ( SELECT TOP 1
                                                              DesdeDiaRegaloMes
                                                              FROM
                                                              dbo.Parametros
                                                              )
                                         )
                                    )
                                AND CASE WHEN @verificaSiFacturado = 0 THEN 0
                                         ELSE ( SELECT  COUNT(*)
                                                FROM    dbo.Comprobantes comp
                                                        JOIN dbo.Contratos cto ON comp.idCliente = cto.idCliente
                                                        JOIN dbo.RenglonesFacturaProforma rfp ON cto.idContrato = rfp.idContrato
                                                WHERE   rfp.idContrato = @idContrato
                                                        AND Periodo = @periodo
                                              )
                                    END = 0 THEN 1
                           ELSE 0
                      END
        RETURN @Result
    END

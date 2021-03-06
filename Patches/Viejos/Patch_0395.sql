USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[ContratoSeFactura]    Script Date: 11/05/2014 12:20:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER FUNCTION [dbo].[ContratoSeFactura]
    (
      @idContrato int,
      @periodo varchar(7),
      @verificaSiFacturado bit
    )
RETURNS bit
AS BEGIN
    DECLARE @Result bit
    DECLARE @fechaUltimaSolicitud date
    DECLARE @periodoUltimaSolicitud varchar(7)
    DECLARE @periodoSiguiente varchar(7)
    DECLARE @fecha date
    SET @fecha = right(@periodo, 4) + left(@periodo, 2) + '01'
    SELECT  @fechaUltimaSolicitud = fecha
    FROM    dbo.Solicitudes
    WHERE   idSolicitud = ( SELECT  max(idSolicitud)
                            FROM    Solicitudes
                            WHERE   idContrato = @idContrato
                          )
    SELECT  @periodoUltimaSolicitud = dbo.Periodo(month(@fechaUltimaSolicitud),
                                                  year(@fechaUltimaSolicitud))
    SELECT  @periodoSiguiente = dbo.PeriodoSiguiente(@periodoUltimaSolicitud)
    SET @Result = CASE WHEN ( SELECT    CASE left(@periodo, 2)
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
                                            JOIN ( SELECT   Max(S.idSolicitud) idSolicitud
                                                   FROM     Solicitudes S
                                                   WHERE    ( ( S.FechaFinal is null )
                                                              OR ( s.FechaFinal > @fecha )
                                                            )
                                                            AND S.Fecha <= @fecha
                                                            AND S.idContrato = @idContrato
                                                   GROUP BY S.idContrato
                                                 ) Aux on aux.idSolicitud = S.idSolicitud
                                ) = 'A'
                            --AND @periodoUltimaSolicitud <> @periodo
                            AND ( @periodoSiguiente <> @periodo
                                  OR day(@fechaUltimaSolicitud) < ( SELECT TOP 1
                                                                            DesdeDiaRegaloMes
                                                                    FROM    dbo.Parametros
                                                                  )
                                )
                            AND CASE WHEN @verificaSiFacturado = 0 THEN 0
                                     ELSE ( SELECT  COUNT(*)
                                            FROM    dbo.RenglonesFacturaProforma rfp
                                                    JOIN dbo.Comprobantes comp on rfp.idFacturaProforma = comp.idFacturaProForma
                                            WHERE   rfp.idContrato = @idContrato
                                                    AND Periodo = @periodo
                                          )
                                END = 0 THEN 1
                       ELSE 0
                  END
    RETURN @Result
   END

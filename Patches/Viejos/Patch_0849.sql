
/****** Object:  StoredProcedure [dbo].[EstadisticaCantidadDeAfiliados]    Script Date: 05/11/2017 21:44:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[EstadisticaCantidadDeAfiliados]
    @periodoDesde VARCHAR(7)
   ,@periodoHasta VARCHAR(7)
   ,@modo VARCHAR(8)
   ,@idPlan INT = 0
   ,@contar VARCHAR(10)
AS 
    BEGIN
        SET NOCOUNT ON;
        DECLARE @periodos TABLE
            (
             Periodo VARCHAR(7)
            ,PrimerDia DATE
            ,UltimoDia DATE
            )
        DECLARE @periodo VARCHAR(7)
        SET @periodo = @periodoDesde
        WHILE dbo.PeriodoAnyoMes(@periodo) <= dbo.PeriodoAnyoMes(@periodoHasta) 
            BEGIN
                INSERT  @periodos
                VALUES  ( @periodo, dbo.PrimerDiaDelPeriodo(@periodo),
                          dbo.UltimoDiaDelPeriodo(@periodo) )
                SET @periodo = dbo.PeriodoSiguiente(@periodo)
            END
        IF @modo = 'UnPlan' 
            BEGIN
                SELECT  '' nPlan
                       ,p.Periodo
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'A'
                                    AND ap.idPlan = @idPlan
                        ) Altas
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END * -1
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'B'
                                    AND ap.idPlan = @idPlan
                        ) Bajas
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'A'
                                    AND ap.idPlan = @idPlan
                        )
                        - ( SELECT  CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END * -1
                            FROM    dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                            WHERE   s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'B'
                                    AND ap.idPlan = @idPlan
                          ) Cambio
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha <= p.UltimoDia
                                    AND s.AltaBajaSusp = 'A'
                                    AND ap.idPlan = @idPlan
                        )
                        - ( SELECT  CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END * -1
                            FROM    dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                            WHERE   s.Fecha <= p.UltimoDia
                                    AND s.AltaBajaSusp = 'B'
                                    AND ap.idPlan = @idPlan
                          ) Padron
                FROM    @periodos p
            END
        IF @modo = 'Planes' 
            BEGIN
                SELECT  pl.Nombre nPlan
                       ,p.Periodo
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'A'
                                    AND ap.idPlan = pl.idPlan
                        ) Altas
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END * -1
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'B'
                                    AND ap.idPlan = pl.idPlan
                        ) Bajas
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'A'
                                    AND ap.idPlan = pl.idPlan
                        )
                        - ( SELECT  CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END * -1
                            FROM    dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                            WHERE   s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'B'
                                    AND ap.idPlan = pl.idPlan
                          ) Cambio
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha <= p.UltimoDia
                                    AND s.AltaBajaSusp = 'A'
                                    AND ap.idPlan = pl.idPlan
                        )
                        - ( SELECT  CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END * -1
                            FROM    dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                            WHERE   s.Fecha <= p.UltimoDia
                                    AND s.AltaBajaSusp = 'B'
                                    AND ap.idPlan = pl.idPlan
                          ) Padron
                FROM    @periodos p
                       ,dbo.Planes pl
            END    
        IF @modo = 'Todos' 
            BEGIN
                SELECT  '' nPlan
                       ,p.Periodo
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'A'
                        ) Altas
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END * -1
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'B'
                        ) Bajas
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'A'
                        )
                        - ( SELECT  CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END * -1
                            FROM    dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                            WHERE   s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'B'
                          ) Cambio
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha <= p.UltimoDia
                                    AND s.AltaBajaSusp = 'A'
                        )
                        - ( SELECT  CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END * -1
                            FROM    dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                            WHERE   s.Fecha <= p.UltimoDia
                                    AND s.AltaBajaSusp = 'B'
                          ) Padron
                FROM    @periodos p
            END
        IF @modo = 'Contrato' 
            BEGIN
                SELECT  '' nPlan
                       ,p.Periodo
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'A'
                                    AND pl.idContrato IS NOT NULL
                        ) Altas
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END * -1
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'B'
                                    AND pl.idContrato IS NOT NULL
                        ) Bajas
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'A'
                                    AND pl.idContrato IS NOT NULL
                        )
                        - ( SELECT  CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END * -1
                            FROM    dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                            WHERE   s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'B'
                                    AND pl.idContrato IS NOT NULL
                          ) Cambio
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha <= p.UltimoDia
                                    AND s.AltaBajaSusp = 'A'
                                    AND pl.idContrato IS NOT NULL
                        )
                        - ( SELECT  CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END * -1
                            FROM    dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                            WHERE   s.Fecha <= p.UltimoDia
                                    AND s.AltaBajaSusp = 'B'
                                    AND pl.idContrato IS NOT NULL
                          ) Padron
                FROM    @periodos p
            END
        IF @modo = 'Propios' 
            BEGIN
                SELECT  '' nPlan
                       ,p.Periodo
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'A'
                                    AND pl.idContrato IS NULL
                        ) Altas
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END * -1
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'B'
                                    AND pl.idContrato IS NULL
                        ) Bajas
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'A'
                                    AND pl.idContrato IS NULL
                        )
                        - ( SELECT  CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END * -1
                            FROM    dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                            WHERE   s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                    AND s.AltaBajaSusp = 'B'
                                    AND pl.idContrato IS NULL
                          ) Cambio
                       ,( SELECT    CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END
                          FROM      dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                          WHERE     s.Fecha <= p.UltimoDia
                                    AND s.AltaBajaSusp = 'A'
                                    AND pl.idContrato IS NULL
                        )
                        - ( SELECT  CASE WHEN @contar = 'Grupos'
                                         THEN COUNT(DISTINCT idGrupo)
                                         ELSE COUNT(DISTINCT af.idAfiliado)
                                    END * -1
                            FROM    dbo.Solicitudes s
                                    JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                    JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                                    JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                            WHERE   s.Fecha <= p.UltimoDia
                                    AND s.AltaBajaSusp = 'B'
                                    AND pl.idContrato IS NULL
                          ) Padron
                FROM    @periodos p
            END
    END

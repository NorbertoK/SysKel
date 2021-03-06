USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[EstadisticaCantidadDeAfiliados]    Script Date: 01/23/2013 21:37:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[EstadisticaCantidadDeAfiliados]
    @periodoDesde VARCHAR(7)
   ,@periodoHasta VARCHAR(7)
   ,@modo VARCHAR(8)
   ,@idPlan INT = 0
AS 
    BEGIN
        SET NOCOUNT ON ;
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
                VALUES  (@periodo, dbo.PrimerDiaDelPeriodo(@periodo), dbo.UltimoDiaDelPeriodo(@periodo))
                SET @periodo = dbo.PeriodoSiguiente(@periodo)
            END
        IF @modo = 'UnPlan' 
            BEGIN
                SELECT  '' nPlan
                       ,p.Periodo
                       ,(SELECT COUNT(*)
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                         WHERE  s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                AND s.AltaBajaSusp = 'A'
                                AND ap.idPlan = @idPlan
                        ) Altas
                       ,(SELECT COUNT(*) * -1
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                         WHERE  s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                AND s.AltaBajaSusp = 'B'
                                AND ap.idPlan = @idPlan
                        ) Bajas
                       ,(SELECT ISNULL(SUM(CASE s.AltaBajaSusp
                                             WHEN 'A' THEN 1
                                             WHEN 'B' THEN -1
                                           END), 0)
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                         WHERE  s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                AND ap.idPlan = @idPlan
                        ) Salto
                       ,(SELECT ISNULL(SUM(CASE s.AltaBajaSusp
                                             WHEN 'A' THEN 1
                                             WHEN 'B' THEN -1
                                           END), 0)
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                         WHERE  s.Fecha <= p.UltimoDia
                                AND ap.idPlan = @idPlan
                        ) Padron
                FROM    @periodos p
            END
        IF @modo = 'Planes' 
            BEGIN
                SELECT  pl.Nombre nPlan
                       ,p.Periodo
                       ,(SELECT COUNT(*)
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                         WHERE  s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                AND s.AltaBajaSusp = 'A'
                                AND ap.idPlan = pl.idPlan
                        ) Altas
                       ,(SELECT COUNT(*) * -1
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                         WHERE  s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                AND s.AltaBajaSusp = 'B'
                                AND ap.idPlan = pl.idPlan
                        ) Bajas
                       ,(SELECT ISNULL(SUM(CASE s.AltaBajaSusp
                                             WHEN 'A' THEN 1
                                             WHEN 'B' THEN -1
                                           END), 0)
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                         WHERE  s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                AND ap.idPlan = pl.idPlan
                        ) Salto
                       ,(SELECT ISNULL(SUM(CASE s.AltaBajaSusp
                                             WHEN 'A' THEN 1
                                             WHEN 'B' THEN -1
                                           END), 0)
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                         WHERE  s.Fecha <= p.UltimoDia
                                AND ap.idPlan = pl.idPlan
                        ) Padron
                FROM    @periodos p
                       ,dbo.Planes pl
            END    
        IF @modo = 'Todos' 
            BEGIN
                SELECT  '' nPlan
                       ,p.Periodo
                       ,(SELECT COUNT(*)
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                         WHERE  s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                AND s.AltaBajaSusp = 'A'
                        ) Altas
                       ,(SELECT COUNT(*) * -1
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                         WHERE  s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                AND s.AltaBajaSusp = 'B'
                        ) Bajas
                       ,(SELECT ISNULL(SUM(CASE s.AltaBajaSusp
                                             WHEN 'A' THEN 1
                                             WHEN 'B' THEN -1
                                           END), 0)
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                         WHERE  s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                        ) Salto
                       ,(SELECT ISNULL(SUM(CASE s.AltaBajaSusp
                                             WHEN 'A' THEN 1
                                             WHEN 'B' THEN -1
                                           END), 0)
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                         WHERE  s.Fecha <= p.UltimoDia
                        ) Padron
                FROM    @periodos p
            END
        IF @modo = 'Contrato' 
            BEGIN
                SELECT  '' nPlan
                       ,p.Periodo
                       ,(SELECT COUNT(*)
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                         WHERE  s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                AND s.AltaBajaSusp = 'A'
                                AND pl.idContrato IS NOT NULL
                        ) Altas
                       ,(SELECT COUNT(*) * -1
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                         WHERE  s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                AND s.AltaBajaSusp = 'B'
                                AND pl.idContrato IS NOT NULL
                        ) Bajas
                       ,(SELECT ISNULL(SUM(CASE s.AltaBajaSusp
                                             WHEN 'A' THEN 1
                                             WHEN 'B' THEN -1
                                           END), 0)
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                         WHERE  s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                AND pl.idContrato IS NOT NULL
                        ) Salto
                       ,(SELECT ISNULL(SUM(CASE s.AltaBajaSusp
                                             WHEN 'A' THEN 1
                                             WHEN 'B' THEN -1
                                           END), 0)
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                         WHERE  s.Fecha <= p.UltimoDia
                                AND pl.idContrato IS NOT NULL
                        ) Padron
                FROM    @periodos p
            END
        IF @modo = 'Propios' 
            BEGIN
                SELECT  '' nPlan
                       ,p.Periodo
                       ,(SELECT COUNT(*)
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                         WHERE  s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                AND s.AltaBajaSusp = 'A'
                                AND pl.idContrato IS NULL
                        ) Altas
                       ,(SELECT COUNT(*) * -1
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                         WHERE  s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                AND s.AltaBajaSusp = 'B'
                                AND pl.idContrato IS NULL
                        ) Bajas
                       ,(SELECT ISNULL(SUM(CASE s.AltaBajaSusp
                                             WHEN 'A' THEN 1
                                             WHEN 'B' THEN -1
                                           END), 0)
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                         WHERE  s.Fecha BETWEEN p.PrimerDia AND p.UltimoDia
                                AND pl.idContrato IS NULL
                        ) Salto
                       ,(SELECT ISNULL(SUM(CASE s.AltaBajaSusp
                                             WHEN 'A' THEN 1
                                             WHEN 'B' THEN -1
                                           END), 0)
                         FROM   dbo.Solicitudes s
                                JOIN dbo.AfiliadosPlanes ap ON s.idSolicitud = ap.idSolicitud
                                JOIN dbo.Planes pl ON ap.idPlan = pl.idPlan
                         WHERE  s.Fecha <= p.UltimoDia
                                AND pl.idContrato IS NULL
                        ) Padron
                FROM    @periodos p
            END
    END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION CantidadDeAfiliadosActivosDelGrupo
    (
     @idGrupo INT
    ,@fecha SMALLDATETIME
    )
RETURNS INT
AS 
    BEGIN
        DECLARE @Result INT = 0
        IF @fecha IS NULL 
            SET @fecha = GETDATE()

        DECLARE @n INT
        DECLARE @sql VARCHAR(1000)
        DECLARE @idAfiliado INT
        DECLARE @planesActivos INT
        DECLARE @registros INT
        DECLARE @AfiliadosDelGrupo TABLE
            (
             renglon INT IDENTITY(1, 1)
            ,idAfiliado INT
            )
        DECLARE @EstadosDelAfiliado TABLE
            (
             idPlan INT
            ,Estado VARCHAR(10)
            )
        INSERT  @AfiliadosDelGrupo
                SELECT  idAfiliado
                FROM    Afiliados
                WHERE   idGrupo = @idGrupo
        SET @registros = @@ROWCOUNT
        SET @n = 1
        WHILE @n <= @registros 
            BEGIN
                SELECT  @idAfiliado = idAfiliado
                FROM    @AfiliadosDelGrupo
                WHERE   renglon = @n
                DELETE  FROM @EstadosDelAfiliado
                INSERT  @EstadosDelAfiliado
                        SELECT  Aux.idPlan
                               ,s.AltaBajaSusp Estado
                        FROM    dbo.AfiliadosPlanes AP
                        INNER JOIN dbo.Solicitudes S ON S.idSolicitud = AP.idSolicitud
                        INNER JOIN ( SELECT ap.idPlan
                                           ,MAX(S.idSolicitud) idSolicitud
                                     FROM   dbo.AfiliadosPlanes AP
                                     INNER JOIN dbo.Solicitudes S ON S.idSolicitud = AP.idSolicitud
                                     WHERE  s.idAfiliado = @idAfiliado
                                            AND ( ( S.FechaFinal IS NULL )
                                                  OR ( s.FechaFinal > @fecha )
                                                )
                                            AND s.Fecha <= @fecha
                                     GROUP BY ap.idPlan
                                   ) Aux ON Aux.idPlan = AP.idPlan
                                            AND Aux.idSolicitud = AP.idSolicitud
                SELECT  @planesActivos = COUNT(*)
                FROM    @EstadosDelAfiliado ea
                INNER JOIN dbo.Planes pla ON ( pla.idPlan = ea.idPlan )
                WHERE   Estado = 'A'
                IF @planesActivos > 0 
                    SET @Result = @Result + 1
                SET @n = @n + 1
            END

        RETURN @Result

    END
GO


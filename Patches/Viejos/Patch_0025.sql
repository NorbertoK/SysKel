SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GeneradorDeTurnos @mes INT = 0, @anyo INT = 0
AS 
    BEGIN
        SET NOCOUNT ON ;
        DECLARE @primerDiaMes DATE
        DECLARE @primerDiaMesSiguiente DATE
        DECLARE @dia DATE
        DECLARE @hora TIME
        DECLARE @renglon INT
        DECLARE @idMoldeDeTurno INT
        DECLARE @idEmpleado INT
        DECLARE @Lunes BIT
        DECLARE @Martes BIT
        DECLARE @Miercoles BIT
        DECLARE @Jueves BIT
        DECLARE @Viernes BIT
        DECLARE @Sabado BIT
        DECLARE @Domingo BIT
        DECLARE @Semana1 BIT
        DECLARE @Semana2 BIT
        DECLARE @Semana3 BIT
        DECLARE @Semana4 BIT
        DECLARE @Semana5 BIT
        DECLARE @CadaSemanas INT
        DECLARE @DesdeSemanas DATE
        DECLARE @De TIME(0)
        DECLARE @A TIME(0)
        DECLARE @Minutos INT
        SET @primerDiaMes = CAST(@anyo AS VARCHAR(4)) + CASE WHEN @mes < 10 THEN '0'
                                                             ELSE ''
                                                        END + CAST(@mes AS VARCHAR(2)) + '01'
        SET @primerDiaMesSiguiente = DATEADD(m, 1, @primerDiaMes)
        DECLARE @TurnosDados TABLE
            (
             idEmpleado INT
            ,Dia DATE
            ,Hora TIME(0)
            )
        INSERT  @TurnosDados
                ( 
                 idEmpleado
                ,Dia
                ,Hora
                )
                SELECT  idEmpleado
                       ,Dia
                       ,Hora
                FROM    dbo.Turnos
                WHERE   Dia >= @primerDiaMes
                        AND Dia < @primerDiaMesSiguiente
        DECLARE @TurnosADar TABLE
            (
             idEmpleado INT
            ,Dia DATE
            ,Hora TIME(0)
            )
        DECLARE @moldesDeTurnos TABLE
            (
             renglon INT IDENTITY(1, 1)
            ,idMoldeDeTurno INT
            ,idEmpleado INT
            ,Lunes BIT
            ,Martes BIT
            ,Miercoles BIT
            ,Jueves BIT
            ,Viernes BIT
            ,Sabado BIT
            ,Domingo BIT
            ,Semana1 BIT
            ,Semana2 BIT
            ,Semana3 BIT
            ,Semana4 BIT
            ,Semana5 BIT
            ,CadaSemanas INT
            ,DesdeSemanas DATE
            ,De TIME(0)
            ,A TIME(0)
            ,Minutos INT
            )
        DECLARE @cantMoldesDeTurnos INT
        INSERT  @moldesDeTurnos
                ( 
                 idMoldeDeTurno
                ,idEmpleado
                ,Lunes
                ,Martes
                ,Miercoles
                ,Jueves
                ,Viernes
                ,Sabado
                ,Domingo
                ,Semana1
                ,Semana2
                ,Semana3
                ,Semana4
                ,Semana5
                ,CadaSemanas
                ,DesdeSemanas
                ,De
                ,A
                ,Minutos
                )
                SELECT  idMoldeDeTurno
                       ,idEmpleado
                       ,Lunes
                       ,Martes
                       ,Miercoles
                       ,Jueves
                       ,Viernes
                       ,Sabado
                       ,Domingo
                       ,Semana1
                       ,Semana2
                       ,Semana3
                       ,Semana4
                       ,Semana5
                       ,CadaSemanas
                       ,DesdeSemanas
                       ,De
                       ,A
                       ,Minutos
                FROM    dbo.MoldesDeTurnos
        SET @cantMoldesDeTurnos = @@ROWCOUNT
        SET @dia = @primerDiaMes
        WHILE @dia < @primerDiaMesSiguiente 
            BEGIN
                IF EXISTS ( SELECT  *
                            FROM    dbo.Feriados
                            WHERE   Fecha = @dia )
                    OR @dia < GETDATE() 
                    BEGIN
                        SET @dia = DATEADD(d, 1, @dia)
                        CONTINUE
                    END
                SET @renglon = 1
                WHILE @renglon <= @cantMoldesDeTurnos 
                    BEGIN
                        PRINT @dia
                        PRINT @renglon
                        SELECT  @idMoldeDeTurno = idMoldeDeTurno
                               ,@idEmpleado = idEmpleado
                               ,@Lunes = Lunes
                               ,@Martes = Martes
                               ,@Miercoles = Miercoles
                               ,@Jueves = Jueves
                               ,@Viernes = Viernes
                               ,@Sabado = Sabado
                               ,@Domingo = Domingo
                               ,@Semana1 = Semana1
                               ,@Semana2 = Semana2
                               ,@Semana3 = Semana3
                               ,@Semana4 = Semana4
                               ,@Semana5 = Semana5
                               ,@CadaSemanas = CadaSemanas
                               ,@DesdeSemanas = DesdeSemanas
                               ,@De = CAST(De AS TIME(0))
                               ,@A = CAST(A AS TIME(0))
                               ,@Minutos = Minutos
                        FROM    @MoldesDeTurnos
                        WHERE   renglon = @renglon
                        IF ( ( DATEPART(dw, @dia) = 1
                               AND ISNULL(@Domingo, 0) = 1
                             )
                             OR ( DATEPART(dw, @dia) = 2
                                  AND ISNULL(@Lunes, 0) = 1
                                )
                             OR ( DATEPART(dw, @dia) = 3
                                  AND ISNULL(@Martes, 0) = 1
                                )
                             OR ( DATEPART(dw, @dia) = 4
                                  AND ISNULL(@Miercoles, 0) = 1
                                )
                             OR ( DATEPART(dw, @dia) = 5
                                  AND ISNULL(@Jueves, 0) = 1
                                )
                             OR ( DATEPART(dw, @dia) = 6
                                  AND ISNULL(@Viernes, 0) = 1
                                )
                             OR ( DATEPART(dw, @dia) = 7
                                  AND ISNULL(@Sabado, 0) = 1
                                )
                           )
                            AND ( ( ( DATEPART(d, @dia) < 8
                                      AND ISNULL(@Semana1, 0) = 1
                                    )
                                    OR ( DATEPART(d, @dia) BETWEEN 8 AND 14
                                         AND ISNULL(@Semana2, 0) = 1
                                       )
                                    OR ( DATEPART(d, @dia) BETWEEN 15 AND 21
                                         AND ISNULL(@Semana3, 0) = 1
                                       )
                                    OR ( DATEPART(d, @dia) BETWEEN 22 AND 28
                                         AND ISNULL(@Semana4, 0) = 1
                                       )
                                    OR ( DATEPART(d, @dia) > 28
                                         AND ISNULL(@Semana5, 0) = 1
                                       )
                                  )
                                  OR ( @CadaSemanas > 0
                                       AND DATEDIFF(wk, DATEADD(d, -( DATEPART(dw, @dia) - 1 ), @DesdeSemanas), @dia) % @CadaSemanas = 0
                                     )
                                ) 
                            BEGIN
                                SET @hora = @De
                                WHILE @hora < @A 
                                    BEGIN
                                        IF ( SELECT COUNT(*)
                                             FROM   @TurnosDados
                                             WHERE  idEmpleado = @idEmpleado
                                                    AND Dia = @Dia
                                                    AND Hora = @Hora
                                           ) = 0 
                                            BEGIN
                                                INSERT  @TurnosADar
                                                        ( idEmpleado, Dia, Hora )
                                                VALUES  ( @idEmpleado, @Dia, @Hora )
                                            END
                                        SET @hora = DATEADD(mi, @minutos, @hora)
                                    END
                            END
                        SET @renglon = @renglon + 1
                    END
                SET @dia = DATEADD(d, 1, @dia)
            END
        INSERT  dbo.Turnos
                ( 
                 idEmpleado
                ,Dia
                ,Hora
                    
                )
                SELECT  idEmpleado
                       ,Dia
                       ,Hora
                FROM    @TurnosADar
    END
GO

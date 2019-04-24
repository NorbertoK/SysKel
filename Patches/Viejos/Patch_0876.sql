SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE SeleccionPrestacionesCliente
    @desde VARCHAR(8) ,
    @hasta VARCHAR(8) ,
    @idCliente INT = 0 ,
    @proceso VARCHAR(255) OUTPUT
AS 
    BEGIN
        SET @proceso = CONVERT(VARCHAR(255), NEWID())
        INSERT  dbo.Ids
                ( Proceso ,
                  Id 
                )
                SELECT DISTINCT
                        @proceso ,
                        prest.idPrestacion
                FROM    dbo.Prestaciones prest
                        LEFT JOIN dbo.Codigos ON prest.idCodigo = Codigos.idCodigo
                WHERE   CASE WHEN prest.Agendada IS NULL THEN prest.Tomada
                             ELSE prest.Agendada
                        END >= @desde
                        AND CASE WHEN prest.Agendada IS NULL THEN prest.Tomada
                                 ELSE prest.Agendada
                            END < DATEADD(dd, 1, @hasta)
                        AND prest.idMotivoDeCancelacion IS NULL
                        AND EXISTS ( SELECT *
                                     FROM   dbo.Pacientes pac
                                            JOIN dbo.Contratos cto ON cto.idContrato = pac.idContrato
                                     WHERE  pac.idPrestacion = prest.idPrestacion
                                            AND cto.idCliente = @idCliente )
    END
GO

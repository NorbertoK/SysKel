USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[SugerirCopago]    Script Date: 10/06/2013 11:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SugerirCopago]
    @idContrato INT = 0
   ,@idAfiliado INT = 0
   ,@idTipoDeDestino INT = 0
   ,@idCodigo INT = 0
   ,@idPractica INT = 0
AS 
    BEGIN
        SET NOCOUNT ON ;
        DECLARE @Result MONEY
        DECLARE @planes TABLE ( idPlan INT )
        INSERT  @planes
                SELECT  idPlan
                FROM    dbo.EstadosDelAfiliado(@idAfiliado, GETDATE())
                WHERE   Estado NOT IN ( 'Baja', 'Suspendido' ) 
        SELECT  @Result = MIN(Importe)
        FROM    dbo.Copagos c
        LEFT JOIN @planes p ON 1 = 1
        WHERE   ISNULL(idCliente, 0) = CASE WHEN ISNULL(idCliente, 0) = 0 THEN 0
                                            ELSE ( SELECT   idCliente
                                                   FROM     dbo.Contratos
                                                   WHERE    idCliente = @idContrato
                                                 )
                                       END
                AND ISNULL(idContrato, 0) = CASE WHEN ISNULL(idContrato, 0) = 0 THEN 0
                                                 ELSE @idContrato
                                            END
                AND ISNULL(c.idPlan, 0) = CASE WHEN ISNULL(c.idPlan, 0) = 0 THEN 0
                                               ELSE p.idPlan
                                          END
                AND ISNULL(idTipoDeDestino, 0) = CASE WHEN ISNULL(idTipoDeDestino, 0) = 0 THEN 0
                                                      ELSE @idTipoDeDestino
                                                 END
                AND ISNULL(idCodigo, 0) = CASE WHEN ISNULL(idCodigo, 0) = 0 THEN 0
                                               ELSE @idCodigo
                                          END
                AND ISNULL(idPractica, 0) = CASE WHEN ISNULL(idPractica, 0) = 0 THEN 0
                                                 ELSE @idPractica
                                            END
        RETURN ISNULL(@Result,0)
    END

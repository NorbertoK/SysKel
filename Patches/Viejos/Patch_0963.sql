USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[SugerirCopago]    Script Date: 01/04/2019 18:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SugerirCopago]
    @idContrato INT = 0
   ,@idPlan INT = 0
   ,@idTipoDeDestino INT = 0
   ,@idCodigo INT = 0
   ,@idPractica INT = 0
   ,@idTipoDeContrato INT = 0
   ,@result MONEY OUTPUT
AS 
    BEGIN
        SET NOCOUNT ON;
        SELECT  @Result = ISNULL(MIN(Importe), 0)
        FROM    dbo.Copagos c
        WHERE   ISNULL(idCliente, 0) = CASE WHEN ISNULL(idCliente, 0) = 0
                                            THEN 0
                                            ELSE ISNULL(( SELECT
                                                              idCliente
                                                          FROM
                                                              dbo.Contratos
                                                          WHERE
                                                              idContrato = @idContrato
                                                        ), 0)
                                       END
                AND ISNULL(idContrato, 0) = CASE WHEN ISNULL(idContrato, 0) = 0
                                                 THEN 0
                                                 ELSE @idContrato
                                            END
                AND ISNULL(c.idPlan, 0) = CASE WHEN ISNULL(c.idPlan, 0) = 0
                                               THEN 0
                                               ELSE @idPlan
                                          END
                AND ISNULL(idTipoDeDestino, 0) = CASE WHEN ISNULL(idTipoDeDestino,
                                                              0) = 0 THEN 0
                                                      ELSE @idTipoDeDestino
                                                 END
                AND ISNULL(idCodigo, 0) = CASE WHEN ISNULL(idCodigo, 0) = 0
                                               THEN 0
                                               ELSE @idCodigo
                                          END
                AND ISNULL(idPractica, 0) = CASE WHEN ISNULL(idPractica, 0) = 0
                                                 THEN 0
                                                 ELSE @idPractica
                                            END
                AND ISNULL(idTipoDeContrato, 0) = CASE WHEN ISNULL(idTipoDeContrato,
                                                              0) = 0 THEN 0
                                                       ELSE @idTipoDeContrato
                                                  END
        RETURN 
    END

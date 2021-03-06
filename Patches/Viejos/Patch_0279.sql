USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[SugerirCopago]    Script Date: 02/18/2014 15:02:31 ******/
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
   ,@result MONEY OUTPUT
AS 
    BEGIN
        SET NOCOUNT ON ;
        SELECT  @Result = ISNULL(MIN(Importe),0)
        FROM    dbo.Copagos c
        WHERE   ISNULL(idCliente, 0) = ISNULL(( SELECT   idCliente
                                                   FROM     dbo.Contratos
                                                   WHERE    idContrato = @idContrato
                                                 ),0)
                AND ISNULL(idContrato, 0) = @idContrato
                AND ISNULL(c.idPlan, 0) = @idPlan
                AND ISNULL(idTipoDeDestino, 0) = @idTipoDeDestino
                AND ISNULL(idCodigo, 0) = @idCodigo
                AND ISNULL(idPractica, 0) = @idPractica
        RETURN 
    END

USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[SaldoComprobante]    Script Date: 09/23/2015 20:18:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[SaldoComprobante] ( @idComprobante INT )
RETURNS MONEY
AS 
    BEGIN
        DECLARE @Result MONEY
		
        IF ( SELECT Anulado
             FROM   dbo.Comprobantes
             WHERE  idComprobante = @idComprobante
           ) = 1 
            SELECT  @Result = 0
        ELSE 
            SELECT  @Result = SUM(comp.importe * CASE WHEN tip.ImporteNegativo = 'True' THEN -1
                                                      ELSE 1
                                                 END)
            FROM    dbo.Comprobantes comp
            JOIN    dbo.TiposDeComprobante tip ON tip.idTipoDeComprobante = comp.idTipoDeComprobante
            WHERE   ( comp.idComprobante = @idComprobante
                      OR comp.idReferencia = @idComprobante
                    )
                    AND ISNULL(comp.Anulado,0) = 0


        RETURN @Result

    END

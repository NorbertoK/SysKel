USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[TotalComprobante]    Script Date: 11/01/2018 13:16:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[TotalComprobante] ( @idComprobante INT )
RETURNS MONEY
AS 
    BEGIN
        DECLARE @Result MONEY

        SELECT  @Result = SUM(comp.importe
                              * CASE WHEN tip.ImporteNegativo = 'True' THEN -1
                                     ELSE 1
                                END)
        FROM    dbo.Comprobantes comp
                JOIN dbo.TiposDeComprobante tip ON tip.idTipoDeComprobante = comp.idTipoDeComprobante
        WHERE   ( comp.idComprobante = @idComprobante
                  OR comp.idReferencia = @idComprobante
                )
                AND comp.idTipoDeComprobante != ( SELECT TOP 1
                                                            Recibo
                                                  FROM      dbo.Sistemas
                                                )
                AND ISNULL(Anulado, 0) = 0
        RETURN @Result

    END

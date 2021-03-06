/****** Object:  UserDefinedFunction [dbo].[TotalesIVA]    Script Date: 08/30/2016 19:10:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[TotalesIVA]
    (
     @idComprobante INT
    ,@importe VARCHAR(7) -- Gravado o IVA
    ,@porCientoIVA int
    )
RETURNS MONEY
AS 
    BEGIN
        DECLARE @Result MONEY

        SELECT  @Result = SUM(CASE @importe
                                WHEN 'Gravado'
                                THEN dbo.imp_Gravado(idDetalleComprobante)
                                ELSE dbo.imp_IVA(idDetalleComprobante)
                              END)
        FROM    dbo.DetallesComprobantes
        WHERE   idComprobante = @idComprobante
        AND idPorcentajeIVA = @porCientoIVA

        RETURN @Result

    END

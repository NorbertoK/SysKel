SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION TotalesIVA
    (
     @idComprobante INT
    ,@importe VARCHAR(7) -- Gravado o IVA
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

        RETURN @Result

    END
GO


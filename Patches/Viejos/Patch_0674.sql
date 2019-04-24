SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION Subtotal ( @idComprobante INT )
RETURNS MONEY
AS 
    BEGIN
        DECLARE @Result MONEY

        SELECT  @Result = dbo.Redondeo(ISNULL(dbo.TotalGravado(@idComprobante),
                                              0)
                                       + ISNULL(dbo.TotalNoGravado(@idComprobante),
                                                0)
                                       + ISNULL(dbo.TotalExento(@idComprobante),
                                                0)
                                       + CASE WHEN ( SELECT Serie
                                                     FROM   dbo.Comprobantes comp
                                                            JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                                                     WHERE  comp.idComprobante = @idComprobante
                                                   ) = 'B'
                                              THEN ISNULL(dbo.imp_IVA(@idComprobante),
                                                          0)
                                              ELSE 0
                                         END, 2) 
        RETURN @Result

    END
GO


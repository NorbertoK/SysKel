USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[FuncPrecioUnitarioImpreso]    Script Date: 07/20/2016 15:18:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER FUNCTION [dbo].[FuncPrecioUnitarioImpreso]
    (
     @idDetalleComprobante INT
    )
RETURNS MONEY
AS 
    BEGIN
        DECLARE @Result MONEY

        SELECT  @Result = ISNULL(PrecioUnitario,
                                 dc.Importe / ISNULL(dc.Cantidad, 1))
                / CASE WHEN tc.DiscriminaIVA = 1
                       THEN ( 1 + pIVA.Porcentaje / 100 )
                       ELSE 1
                  END
        FROM    dbo.DetallesComprobantes dc
                JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
                JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
        WHERE   idDetalleComprobante = @idDetalleComprobante

        RETURN @Result

    END


USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[PrecioUnitarioImpreso]    Script Date: 07/20/2016 18:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[ImporteDelDetalleImpreso]
    (
     @idDetalleComprobante INT
    )
RETURNS MONEY
AS 
    BEGIN
        DECLARE @Result MONEY

        SELECT  @Result = dbo.Redondeo(Cantidad
                                       * dbo.PrecioUnitarioImpreso(idDetalleComprobante),
                                       3)
        FROM    dbo.DetallesComprobantes dc
        WHERE   idDetalleComprobante = @idDetalleComprobante

        RETURN @Result

    END



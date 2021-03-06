USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[ImporteDelDetalleImpreso]    Script Date: 07/22/2016 11:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER FUNCTION [dbo].[ImporteDelDetalleImpreso]
    (
     @idDetalleComprobante INT
    )
RETURNS MONEY
AS 
    BEGIN
        DECLARE @Result MONEY

        SELECT  @Result = dbo.Redondeo(ISNULL(Cantidad, 1)
                                       * dbo.PrecioUnitarioImpreso(idDetalleComprobante),
                                       3)
        FROM    dbo.DetallesComprobantes dc
        WHERE   idDetalleComprobante = @idDetalleComprobante

        RETURN @Result

    END



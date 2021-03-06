USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[TotalIVA]    Script Date: 12/13/2016 09:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[TotalIVA] ( @idComprobante INT )
RETURNS MONEY
AS 
    BEGIN

        DECLARE @Result MONEY

        --SELECT  @Result = SUM(ISNULL(dbo.imp_IVA(dc.idDetalleComprobante), 0))
        --FROM    dbo.Comprobantes comp
        --        JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
        --WHERE   comp.idComprobante = @idComprobante
        
        SELECT  @Result = dbo.TotalesIVA(@idComprobante, 'IVA', 4)
                + dbo.TotalesIVA(@idComprobante, 'IVA', 5)
        FROM    dbo.Comprobantes
        WHERE   idComprobante = @idComprobante
        
        RETURN @Result

    END

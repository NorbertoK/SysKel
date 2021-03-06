USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[TotalExento]    Script Date: 08/01/2016 09:45:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[TotalExento] ( @idComprobante INT )
RETURNS MONEY
AS 
    BEGIN

        DECLARE @Result MONEY
        IF ( SELECT TOP 1
                    NombreEmpresa
             FROM   dbo.Sistemas
           ) = 'Activa' 
            SELECT  @Result = 0
        ELSE 
            SELECT  @Result = SUM(dbo.ImporteDelDetalleImpreso(dc.idDetalleComprobante))
            FROM    dbo.Comprobantes comp
                    JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
            WHERE   comp.idComprobante = @idComprobante
                    AND dc.idPorcentajeIVA = 2
        RETURN @Result

    END

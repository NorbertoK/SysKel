USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[TotalGravado]    Script Date: 10/08/2016 20:53:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[TotalGravado] ( @idComprobante INT )
RETURNS MONEY
AS 
    BEGIN

        DECLARE @Result MONEY

        IF ( SELECT TOP 1
                    NombreEmpresa
             FROM   dbo.Sistemas
           ) = 'Activa' 
            IF ( SELECT tc.Serie
                 FROM   dbo.Comprobantes comp
                        JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                 WHERE  comp.idComprobante = @idComprobante
               ) = 'A' 
                SELECT  @Result = SUM(CASE WHEN dc.idPorcentajeIVA NOT IN ( 1 ) THEN dbo.ImporteDelDetalleImpreso(dc.idDetalleComprobante)ELSE 0 END)
                FROM    dbo.Comprobantes comp
                        JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
                WHERE   comp.idComprobante = @idComprobante
            ELSE 
                SELECT  @Result = SUM(CASE WHEN dc.idPorcentajeIVA NOT IN ( 1 ) THEN dbo.ImporteDelDetalleImpreso(dc.idDetalleComprobante)
                                      / ( 1 + pIVA.Porcentaje / 100 )ELSE 0 END)
                FROM    dbo.Comprobantes comp
                        JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
                        LEFT JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
                WHERE   comp.idComprobante = @idComprobante
        ELSE 
            IF ( SELECT tc.Serie
                 FROM   dbo.Comprobantes comp
                        JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                 WHERE  comp.idComprobante = @idComprobante
               ) = 'A' 
                SELECT  @Result = SUM(CASE WHEN dc.idPorcentajeIVA NOT IN ( 1, 2 ) THEN dbo.ImporteDelDetalleImpreso(dc.idDetalleComprobante) ELSE 0 END)
                FROM    dbo.Comprobantes comp
                        JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
                WHERE   comp.idComprobante = @idComprobante
            ELSE 
                SELECT  @Result = SUM(CASE WHEN dc.idPorcentajeIVA NOT IN ( 1, 2 ) THEN dbo.ImporteDelDetalleImpreso(dc.idDetalleComprobante)
                                      / ( 1 + pIVA.Porcentaje / 100 ) ELSE 0 END )
                FROM    dbo.Comprobantes comp
                        JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
                        LEFT JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
                WHERE   comp.idComprobante = @idComprobante
        RETURN @Result

    END

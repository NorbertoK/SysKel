USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[TotalesIVA]    Script Date: 12/13/2016 09:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[TotalesIVA]
    (
     @idComprobante INT
    ,@importe VARCHAR(7) -- Gravado o IVA
    ,@porCientoIVA INT
    )
RETURNS MONEY
AS 
    BEGIN
        DECLARE @Result MONEY

        --SELECT  @Result = ISNULL(SUM(CASE @importe
        --                               WHEN 'Gravado'
        --                               THEN dbo.imp_Gravado(idDetalleComprobante)
        --                               ELSE dbo.imp_IVA(idDetalleComprobante)
        --                             END), 0)
        --FROM    dbo.DetallesComprobantes
        --WHERE   idComprobante = @idComprobante
        --        AND idPorcentajeIVA = @porCientoIVA
        
        SELECT  @Result = ISNULL(SUM(dbo.imp_Gravado(idDetalleComprobante)), 0)
                * CASE @importe
                    WHEN 'Gravado' THEN 1
                    ELSE ( SELECT   Porcentaje / 100
                           FROM     dbo.PorcentajeIVA
                           WHERE    CodigoAFIP = @porCientoIVA
                         )
                  END
        FROM    dbo.DetallesComprobantes
        WHERE   idComprobante = @idComprobante
                AND idPorcentajeIVA = @porCientoIVA
                

        RETURN @Result

    END

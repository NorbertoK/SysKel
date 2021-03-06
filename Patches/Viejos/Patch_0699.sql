USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[TotalesIVA]    Script Date: 09/17/2016 11:00:54 ******/
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

        SELECT  @Result = ISNULL(SUM(CASE @importe
                                       WHEN 'Gravado'
                                       THEN dbo.imp_Gravado(idDetalleComprobante)
                                       ELSE dbo.imp_IVA(idDetalleComprobante)
                                     END), 0)
        FROM    dbo.DetallesComprobantes
        WHERE   idComprobante = @idComprobante
                AND idPorcentajeIVA = @porCientoIVA

        RETURN @Result

    END

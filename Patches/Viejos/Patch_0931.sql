USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[UltimaFechaComprobantes]    Script Date: 11/01/2018 13:56:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[UltimaFechaComprobantes]
    (
     @prefijo VARCHAR(4)
    ,@idTipoDeComprobante INT
    )
RETURNS DATE
AS 
    BEGIN
        DECLARE @Result DATE

        SELECT  @Result = ISNULL(MAX(Fecha), dbo.HoraCero(GETDATE()))
        FROM    dbo.Comprobantes
        WHERE   Prefijo = @prefijo
                AND idTipoDeComprobante IN (
                SELECT  idTipoDeComprobante
                FROM    dbo.TiposDeComprobante
                WHERE   Serie = ( SELECT    Serie
                                  FROM      dbo.TiposDeComprobante
                                  WHERE     idTipoDeComprobante = @idTipoDeComprobante
                                ) )
                AND ISNULL(Anulado, 0) = 0

        RETURN @Result

    END

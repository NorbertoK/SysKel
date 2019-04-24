SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION UltimoComprobante
    (
     @idTipoDeComprobante INT
    ,@idPuntoDeVenta INT
    )
RETURNS INT
AS 
    BEGIN
        DECLARE @Result INT

        SELECT  @Result = CASE @idTipoDeComprobante
                            WHEN 4 THEN UltimoNumeroAsignado
                            WHEN 7 THEN UltimoNumeroAsignadoA
                            WHEN 8 THEN UltimoNumeroAsignadoB
                          END
        FROM    dbo.PuntosDeVenta
        WHERE   idPuntoDeVenta = @idPuntoDeVenta
 
        RETURN @Result

    END
GO


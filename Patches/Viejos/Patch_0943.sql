SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION GetIdTipoDeComprobante
    (
     @tipo VARCHAR(10)
    ,@idReferencia INT
    )
RETURNS INT
AS 
    BEGIN
        DECLARE @Result INT
        SELECT  @Result = idTipoDeComprobante
        FROM    dbo.TiposDeComprobante
        WHERE   tipo = @tipo
                AND Serie = ( SELECT    tc.Serie
                              FROM      dbo.TiposDeComprobante tc
                                        JOIN dbo.Comprobantes comp ON tc.idTipoDeComprobante = comp.idTipoDeComprobante
                              WHERE     comp.idComprobante = @idReferencia
                            )
        RETURN @Result
    END
GO


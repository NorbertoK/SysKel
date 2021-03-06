USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[GetIdTipoDeComprobante]    Script Date: 12/17/2018 15:49:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[GetIdTipoDeComprobante]
    (
     @tipo VARCHAR(10)
    ,@idReferencia INT
    )
RETURNS INT
AS 
    BEGIN
        DECLARE @Result INT
        SELECT  @Result = CASE @tipo
          WHEN 'Factura' THEN Factura
          WHEN 'NdeC' THEN NdeC
          WHEN 'NdeD' THEN NdeD
        END
FROM    dbo.CategoriasIVA
WHERE   idCategoriaIVA = ( SELECT   idCategoríaIVA
                           FROM     dbo.Comprobantes
                           WHERE    idComprobante = @idReferencia)
        RETURN @Result
    END

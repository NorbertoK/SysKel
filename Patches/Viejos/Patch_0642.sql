USE [Datos]
GO

/****** Object:  UserDefinedFunction [dbo].[PrecioUnitarioImpreso]    Script Date: 07/20/2016 12:45:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PrecioUnitarioImpreso]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[PrecioUnitarioImpreso]
GO

USE [Datos]
GO

/****** Object:  UserDefinedFunction [dbo].[PrecioUnitarioImpreso]    Script Date: 07/20/2016 12:45:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[FuncPrecioUnitarioImpreso]
    (
     @idDetalleComprobante INT
    )
RETURNS MONEY
AS 
    BEGIN
        DECLARE @Result MONEY

        SELECT  @Result = ISNULL(PrecioUnitario, dc.Importe) / ISNULL(dc.Cantidad,1)
                / CASE WHEN tc.DiscriminaIVA = 1
                       THEN ( 1 + pIVA.Porcentaje / 100 )
                       ELSE 1
                  END
        FROM    dbo.DetallesComprobantes dc
                JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
                JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
        WHERE   idDetalleComprobante = @idDetalleComprobante

        RETURN @Result

    END

GO



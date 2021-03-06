USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[ComprobantesVinculados]    Script Date: 11/23/2015 11:02:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[ComprobantesVinculados] ( @idComprobante INT )
RETURNS BIT
AS 
    BEGIN
        DECLARE @Result BIT

        SELECT  @Result = CASE WHEN EXISTS ( SELECT *
                                             FROM   dbo.Comprobantes
                                             WHERE  idReferencia = @idComprobante
                                                    AND Anulado = 0 ) THEN 1
                               ELSE 0
                          END

        RETURN @Result

    END
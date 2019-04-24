USE [Datos]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ComprobantesVinculados] ( @idComprobante INT )
RETURNS BIT
AS 
    BEGIN
        DECLARE @Result BIT

        SELECT  @Result = CASE WHEN EXISTS ( SELECT *
                                             FROM   dbo.Comprobantes
                                             WHERE  idReferencia = @idComprobante ) THEN 1
                               ELSE 0
                          END

        RETURN @Result

    END
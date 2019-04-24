SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION idComprobanteDesdeProceso ( @proceso VARCHAR(255) )
RETURNS INT
AS 
    BEGIN
        DECLARE @Result INT

        SELECT  @Result = idComprobante
        FROM    dbo.Comprobantes
        WHERE   Proceso = @proceso

        RETURN @Result

    END
GO


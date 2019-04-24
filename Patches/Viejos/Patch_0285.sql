SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION SalidasDelRecursoHoy ( @idRecurso INT )
RETURNS INT
AS 
    BEGIN
        DECLARE @Result INT

        SELECT  @Result = COUNT(*)
        FROM    dbo.DestinosRecursos
        WHERE   idRecurso = @idRecurso
                AND ISNULL(Salida,DATEADD(dd, 0, DATEDIFF(dd, 0, GETDATE()))) >= DATEADD(hh, 8, DATEADD(dd, 0, DATEDIFF(dd, 0, GETDATE())))
                AND Cancelado IS NULL

        RETURN @Result

    END
GO


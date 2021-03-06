USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ListadoPorPlan]    Script Date: 12/02/2014 14:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ListadoPorPlan] 
    @idPlan int,	
    @fecha varchar(8)
    
AS
BEGIN
	SET NOCOUNT ON;
    DECLARE @tabla table(
                            Nombre VarChar(100),
                            Titular Bit,
                            idGrupo int,
                            NumeroDeDocumento VarChar(12),
                            NombreTitular VarChar(100)            
                        )
    INSERT @tabla
    SELECT  af.ApelNomb Nombre,
            af.Titular,
            af.idGrupo,
            af.NumeroDeDocumento,
            (   SELECT	(ApelNomb) 
                FROM	dbo.Afiliados afi 
                CROSS APPLY dbo.EstadosDelAfiliado(afi.idAfiliado, @fecha) es 
                WHERE   idGrupo = af.idGrupo AND 
                        Titular = 1 AND 
                        es.Estado NOT IN ('Baja','Suspendido')
            ) NombreTitular
    FROM    dbo.Afiliados af
    OUTER APPLY dbo.EstadosDelAfiliado(af.idAfiliado,@fecha) est 
    WHERE est.Estado NOT IN  ('Baja','Suspendido') AND
        est.idPlan = @idPlan
    ORDER BY NombreTitular, Titular Desc, Nombre
    SELECT * FROM @tabla
END

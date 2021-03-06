USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[BuscarAfiliadosActivos]    Script Date: 12/02/2014 22:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[BuscarAfiliadosActivos](@frase varchar(1000)) AS
SET NOCOUNT ON
DECLARE @PlanesAfiliados table(idAfiliado int,idPlan int,Estado varchar(20)) 
DECLARE @idAfiliado int
DECLARE @registros int
DECLARE @n int
DECLARE @sql varchar(1000)
SET @sql='SELECT idAfiliado FROM dbo.Afiliados WHERE '+@frase
DECLARE @AfiliadosCondicion table(renglon int IDENTITY(1,1),idAfiliado int)
INSERT @AfiliadosCondicion EXEC(@sql)
SET @registros=@@ROWCOUNT
SET @n=1
WHILE @n<=@registros
BEGIN
	SELECT @idAfiliado=idAfiliado FROM @AfiliadosCondicion WHERE renglon=@n
	INSERT @PlanesAfiliados EXEC dbo.EstadoDelAfiliado @idAfiliado
	SET @n=@n+1
END
SELECT af.idGrupo idGrupo, ISNULL(af.Apellido,'')+', '+ISNULL(af.Nombre,'') Nombre, tc.Iniciales TipoDoc, af.NumeroDeDocumento NroDoc,pl.Nombre nPlan,pa.Estado Estado, pa.idAfiliado idAfiliado
FROM @PlanesAfiliados pa
JOIN dbo.Afiliados af on (af.idAfiliado=pa.idAfiliado)
LEFT JOIN dbo.Planes pl on (pl.idPlan=pa.idPlan)
LEFT JOIN dbo.TiposDeDocumento tc on (tc.idTipoDeDocumento=af.idTipoDeDocumento)
WHERE pa.idAfiliado in	(	SELECT idAfiliado
							FROM	@PlanesAfiliados paf
							JOIN	dbo.Planes pla on pla.idPlan = paf.idPlan
							WHERE	paf.Estado NOT IN ('Baja','Suspendido') 
						)


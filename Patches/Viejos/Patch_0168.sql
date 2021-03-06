USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[BuscarAfiliado]    Script Date: 10/14/2013 21:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[BuscarAfiliado] 
(
@idAfiliado int
)
RETURNS TABLE
AS RETURN
(
    SELECT		gru.idAfiliado AS idAfiliado,
				null AS idContrato,
				null AS idLugar,
				dir.idDireccion AS idDireccion,
				dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta,
				gru.Nombre + ' ' + gru.Apellido AS Nombre,
				pla.Nombre AS nPlan,
				est.Estado AS Estado,
				null AS Observaciones,
				pla.idPlan AS idPlan
    FROM		dbo.Afiliados af   
    LEFT JOIN   dbo.Afiliados gru on gru.idGrupo = af.idGrupo
    LEFT JOIN	dbo.Direcciones dir on (af.idAfiliado = dir.idAfiliado) OR (af.idGrupo = dir.idGrupo)
    OUTER APPLY	dbo.EstadosDelAfiliado(gru.idAfiliado,GetDate()) est 
    INNER JOIN	dbo.Planes pla on pla.idPlan = est.idplan
    WHERE       af.idAfiliado = @idAfiliado
)

USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[AfiliadoActivoCualquierPlanPropio]    Script Date: 10/29/2013 22:06:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[AfiliadoActivoCualquierPlanPropio] 
(
	@idAfiliado int,
    @fecha datetime
)
RETURNS INT
AS

BEGIN

	DECLARE @Result INT
    SET @result = 0
    IF
	(Select Count(*)
        From dbo.AfiliadosPlanes AP
        Inner Join dbo.Solicitudes S On S.idSolicitud = AP.idSolicitud  
        Inner Join (Select ap.idPlan, Max(S.idSolicitud) idSolicitud
                    From dbo.AfiliadosPlanes AP 
                    Inner Join dbo.Solicitudes S ON S.idSolicitud = AP.idSolicitud AND S.Fecha <= @fecha 
					JOIN dbo.Planes pl on ap.idPlan = pl.idPlan
                    Where ((S.FechaFinal is null) OR (s.FechaFinal>@fecha)) AND s.idAfiliado=@idAfiliado
					AND pl.idContrato is null
                    Group By ap.idPlan
                    ) Aux ON Aux.idPlan = AP.idPlan AND Aux.idSolicitud = AP.idSolicitud
        JOIN dbo.Planes pl on pl.idPlan=AP.idPlan
        WHERE s.AltaBajaSusp in ('A','S')) > 0
    SET @Result = 1 

	RETURN @Result

END

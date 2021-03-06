USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[EstPrestLocalidadMotivoCodigo]    Script Date: 04/15/2013 16:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[EstPrestLocalidadMotivoCodigo]
    @desde varchar(8),
    @hasta varchar(8)
AS 
    BEGIN
        SET NOCOUNT ON ;
        SELECT  loc.Nombre Localidad
        ,dbo.MotivosDelPaciente(pac.idPaciente) Motivo
       ,CAST(cod.Jerarquia AS VARCHAR(1)) + cod.Nombre Codigo
       ,prest.EnTiempo
       ,COUNT(*) Cuantas
FROM    dbo.Prestaciones prest
JOIN    dbo.Pacientes pac ON prest.idPrestacion = pac.idPrestacion
JOIN    dbo.Codigos cod ON prest.idCodigo = cod.idCodigo
JOIN    dbo.Destinos dest ON prest.idPrestacion = dest.idPrestacion
JOIN    dbo.Direcciones dir ON dest.idDestino = dir.idDestino
JOIN    dbo.Localidades loc ON dir.idLocalidad = loc.idLocalidad
WHERE   prest.Tomada BETWEEN @desde AND dbo.Medianoche(@hasta)
        AND dest.idDestino = dbo.PrimerDestino(prest.idPrestacion)
GROUP BY loc.Nombre
       ,dbo.MotivosDelPaciente(pac.idPaciente)
       ,CAST(cod.Jerarquia AS VARCHAR(1)) + cod.Nombre
       ,prest.EnTiempo
    END


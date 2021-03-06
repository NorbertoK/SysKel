USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[EstPrestCodigoLocalidad]    Script Date: 04/15/2013 19:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[EstPrestCodigoLocalidad] 
	@desde varchar(8), 
	@hasta varchar(8)
AS
BEGIN
	SET NOCOUNT ON;
     SELECT cod.Nombre AS Codigo
       ,loc.Nombre AS Localidad
       ,prest.TiempoDeLlegada
       ,prest.EnTiempo
       ,prest.idPrestacion
       ,prest.PrimerDestino
 FROM   dbo.Prestaciones prest
 LEFT JOIN dbo.Codigos cod ON cod.idCodigo = prest.idCodigo
 LEFT JOIN dbo.Direcciones dir ON dir.idDestino = prest.PrimerDestino
 LEFT JOIN dbo.Localidades loc ON loc.idLocalidad = dir.idLocalidad
 WHERE  prest.Tomada BETWEEN @desde AND dbo.Medianoche(@hasta)
        AND prest.idMotivoDeCancelacion IS NULL
END


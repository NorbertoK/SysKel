UPDATE dbo.Grupos
SET idCategoriaIVA = null
FROM    dbo.Grupos g
JOIN    dbo.TiposDeCobranza tdec ON g.idTipoDeCobranza = tdec.idTipoDeCobranza
WHERE   tdec.RequiereZonaDeCobranza = 0
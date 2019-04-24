UPDATE  dbo.TiposDeValores
SET     SePagaCon = 1
WHERE   idTipoDeValor < 3

UPDATE  dbo.TiposDeValores
SET     SePagaCon = 0
WHERE   idTipoDeValor > 2
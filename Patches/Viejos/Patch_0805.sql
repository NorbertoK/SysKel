UPDATE  dbo.ValoresTransferencias
SET     idTipoDeValor = 1
WHERE   idTipoDeValor = 3

DELETE  dbo.TiposDeValores
WHERE   Nombre = 'Transferencia'
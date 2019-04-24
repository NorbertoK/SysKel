UPDATE dbo.PuntosDeVenta
SET Verdadero = 0
WHERE Prefijo = '0000'

UPDATE dbo.PuntosDeVenta
SET Verdadero = 1
WHERE Prefijo = '0001'
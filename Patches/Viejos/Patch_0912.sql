UPDATE  dbo.Comprobantes
SET     Anulado = 0
WHERE   Prefijo = '0002'
        AND Anulado IS NULL
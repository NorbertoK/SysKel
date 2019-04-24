DELETE  dbo.Direcciones
WHERE   Real = 0
        AND Cobranza = 0
        AND idCliente IS NOT NULL
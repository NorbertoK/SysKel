UPDATE  dbo.Comprobantes
SET     Nombre = ( SELECT   Nombre
                   FROM     dbo.Comprobantes
                   WHERE    idComprobante = c.idReferencia
                 )
       ,Apellido = ( SELECT Apellido
                     FROM   dbo.Comprobantes
                     WHERE  idComprobante = c.idReferencia
                   )
FROM    dbo.Comprobantes c
WHERE   idReferencia IS NOT NULL
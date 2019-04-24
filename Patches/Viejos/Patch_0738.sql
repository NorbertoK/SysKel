DELETE  dbo.AutorizacionesDelPuesto
WHERE   idAutorizacion = ( SELECT   idAutorizacion
                           FROM     dbo.Autorizaciones
                           WHERE    Codigo = 'MA-0077'
                         )

DELETE  dbo.Autorizaciones
WHERE   Codigo = 'MA-0077'
UPDATE  dbo.Sistemas
SET     ClienteVarios = ( SELECT    idCliente
                          FROM      dbo.Clientes
                          WHERE     RazonSocial = 'Varios'
                        )
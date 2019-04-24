INSERT  INTO [dbo].[Solicitudes]
        ( [AltaBajaSusp]
        ,[idContrato]
        ,[Fecha]
        ,FechaRegistro
        )
VALUES  ( 'A'
        ,( SELECT   idContrato
           FROM     dbo.Contratos c
                    JOIN dbo.Clientes cli ON c.idCliente = cli.idCliente
           WHERE    RazonSocial = 'Varios'
         )
        ,GETDATE()
        ,GETDATE()
        )
GO



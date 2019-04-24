
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION ResumenPrestacionesPorCliente
    (
     @desde VARCHAR(8)
    ,@hasta VARCHAR(8)
    )
RETURNS TABLE
AS
RETURN
    (
	WITH  origen ( RazonSocial, TipoDeDestino, Codigo, Cuantos )
              AS ( SELECT   ISNULL(cli.RazonSocial, 'AYMED')
                           ,td.Nombre
                           ,cod.Nombre
                           ,COUNT(*) Cuantos
                   FROM     dbo.Pacientes pac
                   JOIN     dbo.Prestaciones prest ON pac.idPrestacion = prest.idPrestacion
                   JOIN     dbo.Codigos cod ON prest.idCodigo = cod.idCodigo
                   LEFT JOIN dbo.Contratos cto ON pac.idContrato = cto.idContrato
                   LEFT JOIN dbo.Clientes cli ON cto.idCliente = cli.idCliente
                   JOIN     dbo.TiposDeDestino td ON td.idTipoDeDestino = ( SELECT  idTipoDeDestino
                                                                            FROM    dbo.Destinos
                                                                            WHERE   idDestino = dbo.PrimerDestino(prest.idPrestacion)
                                                                          )
                   WHERE    prest.Tomada BETWEEN @desde AND dbo.Medianoche(@hasta)
                   GROUP BY cli.RazonSocial
                           ,td.Nombre
                           ,cod.Nombre
                 )
    SELECT  RazonSocial
           ,ISNULL(( SELECT Cuantos
                     FROM   origen
                     WHERE  RazonSocial = o.RazonSocial
                            AND TipoDeDestino = 'En Base'
                            AND Codigo = 'Consulta'
                   ), 0) BV
           ,ISNULL(( SELECT Cuantos
                     FROM   origen
                     WHERE  RazonSocial = o.RazonSocial
                            AND TipoDeDestino = 'En Base'
                            AND Codigo = 'Urgencia'
                   ), 0) BA
           ,ISNULL(( SELECT Cuantos
                     FROM   origen
                     WHERE  RazonSocial = o.RazonSocial
                            AND TipoDeDestino = 'En Base'
                            AND Codigo = 'Emergencia'
                   ), 0) BR
           ,ISNULL(( SELECT SUM(Cuantos)
                     FROM   origen
                     WHERE  RazonSocial = o.RazonSocial
                            AND TipoDeDestino != 'En Base'
                            AND Codigo = 'Consulta'
                   ), 0) DV
           ,ISNULL(( SELECT SUM(Cuantos)
                     FROM   origen
                     WHERE  RazonSocial = o.RazonSocial
                            AND TipoDeDestino != 'En Base'
                            AND Codigo = 'Urgencia'
                   ), 0) DA
           ,ISNULL(( SELECT SUM(Cuantos)
                     FROM   origen
                     WHERE  RazonSocial = o.RazonSocial
                            AND TipoDeDestino != 'En Base'
                            AND Codigo = 'Emergencia'
                   ), 0) DR
           ,ISNULL(( SELECT SUM(Cuantos)
                     FROM   origen
                     WHERE  RazonSocial = o.RazonSocial
                            AND TipoDeDestino != 'En Base'
                            AND Codigo = 'Traslado Programado'
                   ), 0) DT
    FROM    origen o
    GROUP BY RazonSocial
)
GO

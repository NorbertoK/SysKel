USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[ResumenPrestacionesPorClienteSoloDomicilios]    Script Date: 09/09/2014 01:55:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER FUNCTION [dbo].[ResumenPrestacionesPorClienteSoloDomicilios]
    (
     @desde VARCHAR(8)
    ,@hasta VARCHAR(8)
    )
RETURNS TABLE
AS
RETURN
    (
	WITH  origen ( RazonSocial, Codigo, Cuantos )
              AS ( SELECT   CASE WHEN ISNULL(cli.RazonSocial, '') = '' THEN ( SELECT TOP 1
                                                                                        NombreEmpresa
                                                                              FROM      dbo.Sistemas
                                                                            )
                                 ELSE dbo.NombreCompletoDelCliente(cli.idCliente)
                            END
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
                   WHERE    CASE WHEN prest.Agendada IS NULL THEN prest.Tomada
                                 ELSE prest.Agendada
                            END BETWEEN @desde
                                AND     dbo.Medianoche(@hasta)
                            AND prest.idMotivoDeCancelacion IS NULL
                   GROUP BY cli.idCliente
                           ,cli.RazonSocial
                           ,td.Nombre
                           ,cod.Nombre
                 )
    SELECT  RazonSocial
           ,ISNULL(( SELECT SUM(Cuantos)
                     FROM   origen
                     WHERE  RazonSocial = o.RazonSocial
                            AND Codigo = 'Consulta'
                   ), 0) DV
           ,ISNULL(( SELECT SUM(Cuantos)
                     FROM   origen
                     WHERE  RazonSocial = o.RazonSocial
                            AND Codigo = 'Urgencia'
                   ), 0) DA
           ,ISNULL(( SELECT SUM(Cuantos)
                     FROM   origen
                     WHERE  RazonSocial = o.RazonSocial
                            AND Codigo = 'Emergencia'
                   ), 0) DR
           ,ISNULL(( SELECT SUM(Cuantos)
                     FROM   origen
                     WHERE  RazonSocial = o.RazonSocial
                            AND Codigo = 'Traslado Programado'
                   ), 0) DT
    FROM    origen o
    GROUP BY RazonSocial
)

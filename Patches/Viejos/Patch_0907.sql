USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ReporteNARANJA]    Script Date: 10/17/2018 10:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ReporteNARANJA] @periodo VARCHAR(7)
AS 
    BEGIN
        SET NOCOUNT ON ;
        DECLARE @fechaHora NVARCHAR(30)= CONVERT(NVARCHAR(30), ( GETDATE() ), 126)
        DECLARE @fecha VARCHAR(8)= SUBSTRING(@fechaHora, 1, 4) + SUBSTRING(@fechaHora, 6, 2) + SUBSTRING(@fechaHora, 9, 2)
        DECLARE @fechaVencimiento DATE = dbo.UltimoDiaHabilDelMes(dbo.PrimerDiaDelPeriodo(@periodo))
        DECLARE @vencimiento VARCHAR(8) = CAST(DATEPART(yy, @fechaVencimiento) AS VARCHAR(4)) + RIGHT('0' + CAST(DATEPART(mm, @fechaVencimiento) AS VARCHAR(10)),
                                                                                                      2) + RIGHT('0'
                                                                                                                 + CAST(DATEPART(dd, @fechaVencimiento) AS VARCHAR(10)),
                                                                                                                 2)
        SELECT  'C' + RIGHT(REPLICATE('0', 9) + ( SELECT    NumeroDeCliente
                                                  FROM      dbo.EntidadesDeCobranza
                                                  WHERE     NombreOculto = 'Tarjeta Naranja'
                                                ), 9) + REPLICATE(' ', 97) + @fecha AS Registro
        UNION ALL
        SELECT  
        /*TIPO DE REGISTRO*/ 'D' 
        /*NRO DE TARJETA*/  + CASE WHEN comp.idGrupo IS NOT NULL THEN ( SELECT  ISNULL(g.NumeroTarjeta, REPLICATE('#', 16))
                                                                FROM    dbo.Grupos g
                                                                WHERE   comp.idGrupo = g.idGrupo
                                                              )
                           ELSE ( SELECT    ISNULL(cli.NumeroTarjeta, REPLICATE('#', 16))
                                  FROM      dbo.Clientes cli
                                  WHERE     comp.idCliente = cli.idCliente
                                )
                      END 
         /*IMPORTE*/ + RIGHT(REPLICATE('0', 12) + CAST(CAST(comp.Saldo * 100 AS INT) AS VARCHAR(12)), 12) 
         /*FECHA ALTA*/ + REPLICATE('0',8) -- Provisorio
         /*NRO DE DEBITO*/ + CASE WHEN comp.idGrupo IS NOT NULL THEN 'A' + RIGHT(REPLICATE('0', 9) + CAST(comp.idGrupo AS VARCHAR(9)), 9) + REPLICATE(' ',20) ELSE 'C' + RIGHT(REPLICATE('0', 9) + CAST(comp.idCliente AS VARCHAR(9)), 9) + REPLICATE(' ',20) END
         /*FECHA DE VENCIMIENTO*/ + @vencimiento
         /*NRO DE CUOTA*/ + SUBSTRING(@periodo, 1, 2)
         /*NRO DE FACTURA*/ + RIGHT(REPLICATE('0', 8) + CAST(comp.idComprobante AS VARCHAR(8)), 8) 
         /*AÑO DE LA CUOTA*/ + SUBSTRING(@periodo, 4, 4)
         /*DATOS ADICIONALES*/ + REPLICATE(' ', 26)
        FROM    dbo.Comprobantes comp
        WHERE   comp.Periodo = @periodo
                AND comp.idEntidadDeCobranza = ( SELECT idEntidadDeCobranza
                                                 FROM   dbo.EntidadesDeCobranza
                                                 WHERE  NombreOculto = 'Tarjeta Naranja'
                                               )
        UNION ALL
        SELECT  'P' + RIGHT(REPLICATE('0', 6) + CAST(( SELECT   COUNT(*)
                                                       FROM     dbo.Comprobantes
                                                       WHERE    Periodo = @periodo
                                                                AND idEntidadDeCobranza = ( SELECT  idEntidadDeCobranza
                                                                                            FROM    dbo.EntidadesDeCobranza
                                                                                            WHERE   NombreOculto = 'Tarjeta Naranja'
                                                                                          )
                                                     ) AS VARCHAR(6)), 6) + REPLICATE(' ', 88)
                + ( SELECT  RIGHT(REPLICATE('0', 12) + CAST(CAST(SUM(Saldo) * 100 AS INT) AS VARCHAR(12)), 12)
                    FROM    dbo.Comprobantes comp
                    WHERE   comp.Periodo = @periodo
                            AND comp.idEntidadDeCobranza = ( SELECT idEntidadDeCobranza
                                                             FROM   dbo.EntidadesDeCobranza
                                                             WHERE  NombreOculto = 'Tarjeta Naranja'
                                                           )
                            AND comp.Saldo > 0
                  ) + REPLICATE(' ', 8)
    END


USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ReporteVISA]    Script Date: 11/01/2018 13:06:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ReporteVISA] @periodo VARCHAR(7)
AS 
    BEGIN
        SET NOCOUNT ON;
        DECLARE @fechaHora NVARCHAR(30)
        SET @fechaHora = CONVERT(NVARCHAR(30), ( SELECT Fecha
                                                 FROM   dbo.Facturaciones
                                                 WHERE  Periodo = @periodo
                                                        AND idTipoDeCobranza = 2
                                               ), 126)
        DECLARE @fecha VARCHAR(8)
        DECLARE @hora VARCHAR(4)
        SET @fecha = SUBSTRING(@fechaHora, 1, 4) + SUBSTRING(@fechaHora, 6, 2)
            + SUBSTRING(@fechaHora, 9, 2)
        SET @hora = SUBSTRING(@fechaHora, 12, 2) + SUBSTRING(@fechaHora, 15, 2)
        DECLARE @vencimiento VARCHAR(8)
        SET @vencimiento = SUBSTRING(@periodo, 4, 4) + SUBSTRING(@periodo, 1,
                                                              2) + '01'
        DECLARE @n INT
        DECLARE @cant INT
        DECLARE @primerPeriodo VARCHAR(7)
        DECLARE @id VARCHAR(15)
        DECLARE @provi TABLE
            (
             Renglon INT IDENTITY(1, 1)
            ,Tarjeta VARCHAR(16)
            ,Comprobante VARCHAR(8)
            ,Id VARCHAR(15)
            ,Importe VARCHAR(15)
            ,Antig VARCHAR(1)
            )
        INSERT  @provi
                ( 
                 Tarjeta
                ,Comprobante
                ,Id
                ,Importe
                ,Antig
                )
                SELECT  CASE WHEN comp.idGrupo IS NOT NULL
                             THEN ( SELECT  ISNULL(g.NumeroTarjeta,
                                                   REPLICATE('#', 16))
                                    FROM    dbo.Grupos g
                                    WHERE   comp.idGrupo = g.idGrupo
                                  )
                             ELSE ( SELECT  ISNULL(cli.NumeroTarjeta,
                                                   REPLICATE('#', 16))
                                    FROM    dbo.Clientes cli
                                    WHERE   comp.idCliente = cli.idCliente
                                  )
                        END
                       ,comp.NumeroDeComprobante
                       ,CASE WHEN comp.idGrupo IS NOT NULL
                             THEN 'A' + RIGHT(REPLICATE('0', 14)
                                              + CAST(comp.idGrupo AS VARCHAR(14)),
                                              14)
                             ELSE 'C' + RIGHT(REPLICATE('0', 14)
                                              + CAST(comp.idCliente AS VARCHAR(14)),
                                              14)
                        END
                       ,RIGHT(REPLICATE('0', 15)
                              + CAST(CAST(comp.Saldo * 100 AS INT) AS VARCHAR(15)),
                              15)
                       ,' '
                FROM    dbo.Comprobantes comp
                WHERE   comp.Periodo = @periodo
                        AND comp.idEntidadDeCobranza = ( SELECT
                                                              idEntidadDeCobranza
                                                         FROM dbo.EntidadesDeCobranza
                                                         WHERE
                                                              NombreOculto = 'VISA'
                                                       )
                        AND ISNULL(Anulado, 0) = 0
        SET @cant = @@ROWCOUNT
        SET @n = 1
        WHILE @n <= @cant 
            BEGIN
                SELECT  @id = Id
                FROM    @provi
                WHERE   Renglon = @n
                SELECT  @primerPeriodo = PrimerPeriodo
                FROM    dbo.VISA
                WHERE   id = @id
                IF @primerPeriodo IS NULL 
                    BEGIN
                        INSERT  INTO [Datos].[dbo].[VISA]
                                ( [id], [PrimerPeriodo] )
                        VALUES  ( @id, @periodo )
                        UPDATE  @provi
                        SET     Antig = 'E'
                        WHERE   Renglon = @n
                    END
                ELSE 
                    IF @primerPeriodo = @periodo 
                        UPDATE  @provi
                        SET     Antig = 'E'
                        WHERE   Renglon = @n
                SET @n = @n + 1
            END
        SELECT  '0DEBLIQD ' + RIGHT(REPLICATE('0', 10)
                                    + ( SELECT  NumeroDeCliente
                                        FROM    dbo.EntidadesDeCobranza
                                        WHERE   NombreOculto = 'VISA'
                                      ), 10) + '900000    ' + @fecha + @hora
                + '0' + REPLICATE(' ', 57) + '*' AS Registro
        UNION ALL
        SELECT  '1' + Tarjeta + REPLICATE(' ', 3) + Comprobante + @vencimiento
                + '0005' + Importe + Id + Antig + REPLICATE(' ', 28) + '*'
        FROM    @provi
        UNION ALL
        SELECT  '9DEBLIQD ' + RIGHT(REPLICATE('0', 10)
                                    + ( SELECT  NumeroDeCliente
                                        FROM    dbo.EntidadesDeCobranza
                                        WHERE   NombreOculto = 'VISA'
                                      ), 10) + '900000    ' + @fecha + @hora
                + RIGHT(REPLICATE('0', 7) + CAST(@cant AS VARCHAR(7)), 7)
                + ( SELECT  RIGHT(REPLICATE('0', 15)
                                  + CAST(SUM(CAST(Importe AS INT)) AS VARCHAR(15)),
                                  15)
                    FROM    @provi
                  ) + REPLICATE(' ', 36) + '*'
    END


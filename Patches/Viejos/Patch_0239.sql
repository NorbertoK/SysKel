USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[TasaDeUso]    Script Date: 12/20/2013 18:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[TasaDeUso]
    @modo VARCHAR(10)
   ,@periodoDesde VARCHAR(7)
   ,@periodoHasta VARCHAR(7)
AS 
    BEGIN
        DECLARE @desde VARCHAR(8)= RIGHT(@periodoDesde, 4) + LEFT(@periodoDesde, 2) + '01'
        DECLARE @postPeriodo VARCHAR(7) = dbo.PeriodoSiguiente(@periodoHasta)
        DECLARE @hasta VARCHAR(8) = RIGHT(@postPeriodo, 4) + LEFT(@postPeriodo, 2) + '01'
        SET NOCOUNT ON ;
        IF @modo = 'RubroCli' 
            BEGIN
                SELECT  rub.Nombre Grupo
                       ,cli.RazonSocial + CASE WHEN cli.NombreFantasia IS NULL THEN ''
                                               ELSE ' (' + cli.NombreFantasia + ')'
                                          END Elemento
                       ,( SELECT    ISNULL(SUM(dbo.TotalComprobante(comp.idComprobante)), 0)
                          FROM      dbo.Comprobantes comp
                          WHERE     cli.idCliente = comp.idCliente
                                    AND comp.idTipoDeComprobante IN ( SELECT    idTipoDeComprobante
                                                                      FROM      dbo.TiposDeComprobante
                                                                      WHERE     EsFactura = 1 )
                                    AND dbo.RestaPeriodos(comp.Periodo, @periodoDesde) >= 0
                                    AND dbo.RestaPeriodos(@periodoHasta, comp.Periodo) >= 0
                        ) Facturado
                       ,( SELECT    COUNT(*)
                          FROM      dbo.Pacientes pac
                          JOIN      dbo.Prestaciones prest ON pac.idPrestacion = prest.idPrestacion
                          WHERE     idContrato IN ( SELECT  cto.idContrato
                                                    FROM    dbo.Contratos cto
                                                    WHERE   idCliente = cli.idCliente )
                                    AND prest.Tomada >= @desde
                                    AND prest.Tomada <= @hasta
                        ) Pacientes
                FROM    dbo.Clientes cli
                JOIN    dbo.TiposDeCliente rub ON cli.idTipoDeCliente = rub.idTipoDeCliente
            END
        
    END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE FacturadoPorPeriodoYRubro
    @periodoDesde VARCHAR(7)
   ,@periodoHasta VARCHAR(7)
AS 
    BEGIN
        SET NOCOUNT ON ;
        SELECT  Periodo
               ,tc.Nombre Rubro
               ,SUM(Importe)Importe
        FROM    dbo.Comprobantes comp
        JOIN    dbo.Clientes cli ON comp.idCliente = cli.idCliente
        JOIN    dbo.TiposDeCliente tc ON cli.idTipoDeCliente = tc.idTipoDeCliente
        WHERE   idTipoDeComprobante NOT IN ( 6, 10, 11 )
                AND Periodo IS NOT NULL
                AND dbo.PeriodoAnyoMes(Periodo) >= dbo.PeriodoAnyoMes(@periodoDesde)
                AND dbo.PeriodoAnyoMes(Periodo) <= dbo.PeriodoAnyoMes(@periodoHasta)
                AND comp.Anulado = 0
        GROUP BY Periodo
               ,tc.Nombre
        ORDER BY dbo.PeriodoAnyoMes(Periodo)
               ,tc.Nombre
    END
GO

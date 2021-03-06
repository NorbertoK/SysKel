
/****** Object:  StoredProcedure [dbo].[FacturadoPorPeriodoYRubro]    Script Date: 09/23/2015 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[FacturadoPorPeriodoYRubro]
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
                AND ISNULL(comp.Anulado,0) = 0
        GROUP BY Periodo
               ,tc.Nombre
        ORDER BY dbo.PeriodoAnyoMes(Periodo)
               ,tc.Nombre
    END

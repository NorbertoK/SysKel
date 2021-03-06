USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[EstadisticaTasaDeUsoAfYCli]    Script Date: 11/01/2018 12:41:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[EstadisticaTasaDeUsoAfYCli]
    @periodoDesde VARCHAR(7)
   ,@periodoHasta VARCHAR(7)
AS 
    BEGIN
        SET NOCOUNT ON;
        DECLARE @periodos TABLE
            (
             Periodo VARCHAR(7)
            ,PrimerDia DATE
            ,UltimoDia DATE
            )
        DECLARE @periodo VARCHAR(7)
        SET @periodo = @periodoDesde
        WHILE dbo.PeriodoAnyoMes(@periodo) <= dbo.PeriodoAnyoMes(@periodoHasta) 
            BEGIN
                INSERT  @periodos
                VALUES  ( @periodo, dbo.PrimerDiaDelPeriodo(@periodo),
                          dbo.UltimoDiaDelPeriodo(@periodo) )
                SET @periodo = dbo.PeriodoSiguiente(@periodo)
            END
        SELECT  p.periodo
               ,ISNULL(( SELECT SUM(Importe
                                    * CASE WHEN tc.ImporteNegativo = 1 THEN -1
                                           ELSE 1
                                      END)
                         FROM   dbo.Comprobantes comp
                                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                         WHERE  idGrupo IS NOT NULL
                                AND tc.Tipo IN ( 'Factura', 'NdeC', 'NdeD' )
                                AND comp.Fecha BETWEEN PrimerDia
                                               AND     dbo.Medianoche(UltimoDia)
                                AND ISNULL(Anulado, 0) = 0
                       ), 0) FacturadoAfiliados
               ,ISNULL(( SELECT SUM(Importe
                                    * CASE WHEN tc.ImporteNegativo = 1 THEN -1
                                           ELSE 1
                                      END)
                         FROM   dbo.Comprobantes comp
                                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                         WHERE  idCliente IS NOT NULL
                                AND tc.Tipo IN ( 'Factura', 'NdeC', 'NdeD' )
                                AND comp.Fecha BETWEEN PrimerDia
                                               AND     dbo.Medianoche(UltimoDia)
                                AND ISNULL(Anulado, 0) = 0
                       ), 0) FacturadoClientes
               ,( SELECT    COUNT(*)
                  FROM      dbo.Pacientes pac
                            JOIN dbo.Prestaciones prest ON pac.idPrestacion = prest.idPrestacion
                  WHERE     pac.idAfiliado IS NOT NULL
                            AND prest.Tomada BETWEEN PrimerDia
                                             AND     dbo.Medianoche(UltimoDia)
                            AND prest.idMotivoDeCancelacion IS NULL
                ) PacientesAfiliados
               ,( SELECT    COUNT(*)
                  FROM      dbo.Pacientes pac
                            JOIN dbo.Prestaciones prest ON pac.idPrestacion = prest.idPrestacion
                  WHERE     pac.idContrato IS NOT NULL
                            AND prest.Tomada BETWEEN PrimerDia
                                             AND     dbo.Medianoche(UltimoDia)
                            AND prest.idMotivoDeCancelacion IS NULL
                ) PacientesClientes
        FROM    @periodos p
    END

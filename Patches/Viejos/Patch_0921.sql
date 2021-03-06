USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[InformeVentas]    Script Date: 11/01/2018 13:01:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[InformeVentas]
    @desde VARCHAR(8)
   ,@hasta VARCHAR(8)
AS 
    BEGIN

        SET NOCOUNT ON ;
        DECLARE @comprobanteAfiliado INT
        DECLARE @comprobantePrestacion INT
        DECLARE @nDeC INT
        SELECT  @comprobanteAfiliado = ComprobanteFactCuotaAfiliados
               ,@comprobantePrestacion = ComprobanteFactPrestaciones
               ,@nDeC = NotaDeCredito
        FROM    dbo.Sistemas 
        SELECT  CASE WHEN comp.idGrupo IS NOT NULL THEN 'Afiliados'
                     WHEN comp.idCliente IS NOT NULL THEN 'Clientes'
                     WHEN comp.idPrestacion IS NOT NULL THEN 'Prestaciones'
                END AS TipoCliente
               ,
                --pv.Observaciones AS PuntoDeVenta,
                tcob.Nombre AS TipoDeCobranza
               ,
                --CASE tcob.Nombre
                --  WHEN 'Propia' THEN emp.ApelNomb
                --  WHEN 'Tercerizada' THEN ec.Nombre
                --  WHEN 'Contrato'
                --  THEN dbo.NombreCompletoDelCliente(comp.idCliente)
                --END AS Cobranza,
                CASE WHEN comp.idGrupo IS NOT NULL THEN ''
                     ELSE CASE WHEN comp.idCliente IS NULL THEN ''
                               ELSE dbo.RubroDelCliente(comp.idCliente)
                          END
                END AS Rubro
               ,SUM(comp.Importe * CASE tc.ImporteNegativo
                                     WHEN 0 THEN 1
                                     WHEN 1 THEN -1
                                   END) AS Importe
        FROM    dbo.Comprobantes comp --JOIN dbo.PuntosDeVenta pv on pv.Prefijo = comp.Prefijo
                JOIN dbo.TiposDeComprobante tc ON tc.idTipodeComprobante = comp.idTipoDeComprobante
                JOIN dbo.TiposDeCobranza tcob ON tcob.idTipoDeCobranza = comp.idTipoDeCobranza
                --LEFT JOIN dbo.EntidadesDeCobranza ec on ec.idEntidadDeCobranza = comp.idEntidadDeCobranza
                --LEFT JOIN dbo.Empleados emp on emp.idEmpleado = comp.idCobrador
        WHERE   comp.Fecha >= @desde
                AND comp.Fecha <= dbo.medianoche(@hasta)
                AND comp.idTipoDeComprobante IN (@comprobanteAfiliado, @nDeC)
                AND ISNULL(Anulado,0) = 0
        GROUP BY CASE WHEN comp.idGrupo IS NOT NULL THEN 'Afiliados'
                      WHEN comp.idCliente IS NOT NULL THEN 'Clientes'
                      WHEN comp.idPrestacion IS NOT NULL THEN 'Prestaciones'
                 END
               ,
                --pv.Observaciones,
                tcob.Nombre
               ,
                --CASE tcob.Nombre
                --  WHEN 'Propia' THEN emp.ApelNomb
                --  WHEN 'Tercerizada' THEN ec.Nombre
                --  WHEN 'Contrato'
                --  THEN dbo.NombreCompletoDelCliente(comp.idCliente)
                --END,
                CASE WHEN comp.idGrupo IS NOT NULL THEN ''
                     ELSE CASE WHEN comp.idCliente IS NULL THEN ''
                               ELSE dbo.RubroDelCliente(comp.idCliente)
                          END
                END
        HAVING  SUM(comp.Importe * CASE tc.ImporteNegativo
                                     WHEN 0 THEN 1
                                     WHEN 1 THEN -1
                                   END) <> 0
        --ORDER BY 1
        --        ,2
        --        ,3
                --,4
                --,5

    END


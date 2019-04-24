SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE FacturadoYCobrado
    @desde VARCHAR(8)
   ,@hasta VARCHAR(8)
AS 
    BEGIN
        SET NOCOUNT ON;
        DECLARE @FacturasRepetidas TABLE ( idComprobante INT )
        INSERT  @FacturasRepetidas
                SELECT  comp.idComprobante
                FROM    dbo.Comprobantes comp
                        JOIN dbo.Clientes cli ON comp.idCliente = cli.idCliente
                        JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
                        JOIN dbo.Negocios n ON dc.idNegocio = n.idNegocio
                        JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                WHERE   cli.RazonSocial = 'Varios'
                        AND n.Nombre = 'Afiliados'
                        AND Fecha >= @desde
                        AND Fecha < DATEADD(d, 1, @hasta)
                        AND tc.Tipo = 'Factura'
                        AND comp.Anulado = 0;
        WITH    renglones ( Nombre, Negocio, Facturado, Cobrado )
                  AS ( SELECT   CASE WHEN comp.idGrupo IS NULL
                                     THEN comp.NombApel
                                     ELSE 'Afiliados'
                                END Nombre
                               ,n.Nombre Negocio
                               ,dc.Importe Facturado
                               ,0 Cobrado
                       FROM     dbo.DetallesComprobantes dc
                                JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
                                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                                JOIN dbo.Negocios n ON dc.idNegocio = n.idNegocio
                       WHERE    Fecha >= @desde
                                AND Fecha < DATEADD(d, 1, @hasta)
                                AND tc.Tipo = 'Factura'
                                AND comp.Anulado = 0
                                AND comp.idComprobante NOT IN (
                                SELECT  idComprobante
                                FROM    @FacturasRepetidas fr )
                       UNION ALL
                       SELECT   CASE WHEN comp.idGrupo IS NULL
                                     THEN comp.NombApel
                                     ELSE 'Afiliados'
                                END Nombre
                               ,n.Nombre Negocio
                               ,dc.Importe / comp.Importe * NdeC.Importe * -1 Facturado
                               ,0 Cobrado
                       FROM     dbo.DetallesComprobantes dc
                                JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
                                JOIN dbo.Comprobantes NdeC ON comp.idComprobante = NdeC.idReferencia
                                JOIN dbo.TiposDeComprobante tc ON NdeC.idTipoDeComprobante = tc.idTipoDeComprobante
                                JOIN dbo.Negocios n ON dc.idNegocio = n.idNegocio
                       WHERE    NdeC.Fecha >= @desde
                                AND NdeC.Fecha < DATEADD(d, 1, @hasta)
                                AND tc.Tipo = 'NdeC'
                                AND NdeC.Anulado = 0
                                AND comp.idComprobante NOT IN (
                                SELECT  idComprobante
                                FROM    @FacturasRepetidas fr )
                       UNION ALL
                       SELECT   CASE WHEN comp.idGrupo IS NULL
                                     THEN comp.NombApel
                                     ELSE 'Afiliados'
                                END Nombre
                               ,n.Nombre Negocio
                               ,dc.Importe / comp.Importe * NdeD.Importe Facturado
                               ,0 Cobrado
                       FROM     dbo.DetallesComprobantes dc
                                JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
                                JOIN dbo.Comprobantes NdeD ON comp.idComprobante = NdeD.idReferencia
                                JOIN dbo.TiposDeComprobante tc ON NdeD.idTipoDeComprobante = tc.idTipoDeComprobante
                                JOIN dbo.Negocios n ON dc.idNegocio = n.idNegocio
                       WHERE    NdeD.Fecha >= @desde
                                AND NdeD.Fecha < DATEADD(d, 1, @hasta)
                                AND tc.Tipo = 'NdeD'
                                AND NdeD.Anulado = 0
                                AND comp.idComprobante NOT IN (
                                SELECT  idComprobante
                                FROM    @FacturasRepetidas fr )
                       UNION ALL
                       SELECT   CASE WHEN comp.idGrupo IS NULL
                                     THEN comp.NombApel
                                     ELSE 'Afiliados'
                                END Nombre
                               ,n.Nombre Negocio
                               ,0 Facturado
                               ,dc.Importe / comp.Importe * recibos.Importe Cobrado
                       FROM     dbo.DetallesComprobantes dc
                                JOIN dbo.Comprobantes comp ON dc.idComprobante = comp.idComprobante
                                JOIN dbo.Comprobantes recibos ON comp.idComprobante = recibos.idReferencia
                                JOIN dbo.TiposDeComprobante tc ON recibos.idTipoDeComprobante = tc.idTipoDeComprobante
                                JOIN dbo.Negocios n ON dc.idNegocio = n.idNegocio
                       WHERE    recibos.Fecha >= @desde
                                AND recibos.Fecha < DATEADD(d, 1, @hasta)
                                AND tc.Tipo = 'Recibo'
                                AND recibos.Anulado = 0
                                AND comp.idComprobante NOT IN (
                                SELECT  idComprobante
                                FROM    @FacturasRepetidas fr )
                     )
            SELECT  Nombre
                   ,Negocio
                   ,SUM(Facturado) Facturado
                   ,SUM(Cobrado) Cobrado
            FROM    renglones
            GROUP BY nombre
                   ,Negocio
            ORDER BY Nombre
                   ,Negocio
    END
GO

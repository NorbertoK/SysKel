USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[DetalleFacturasSinCAE]    Script Date: 11/03/2016 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DetalleFacturasSinCAE] ( @idComprobante INT )
AS 
    BEGIN
        SET NOCOUNT ON;
        SELECT  comp.idComprobante
               ,dc.idDetalleComprobante
               ,CASE WHEN comp.idGrupo IS NULL THEN dc.Detalle
                     ELSE dc.Nombre + ' - '
                          + ISNULL(( SELECT NumeroDeDocumento
                                     FROM   dbo.Afiliados af
                                     WHERE  idAfiliado = dc.idAfiliado
                                   ), '') + ' - ' + pl.Nombre + ' - '
                          + comp.Periodo
                END ds
               ,dc.Cantidad qty
               ,CAST(dbo.PrecioUnitarioImpreso(dc.idDetalleComprobante) AS VARCHAR(30)) PrecioUnitario
               ,CASE WHEN tc.Serie = 'B' THEN NULL
                     ELSE pIVA.CodigoAFIP
                END iva_id
               ,CASE WHEN tc.Serie = 'B' THEN NULL
                     ELSE CAST(dbo.imp_IVA(dc.idDetalleComprobante) AS VARCHAR(30))
                END imp_iva
               ,CAST(dbo.ImporteDelDetalleImpreso(dc.idDetalleComprobante) AS VARCHAR(30)) ImporteDelDetalle
        FROM    dbo.Comprobantes comp
                JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                LEFT JOIN dbo.Planes pl ON dc.idPlan = pl.idPlan
                LEFT JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
        WHERE   comp.idComprobante = @idComprobante
    END

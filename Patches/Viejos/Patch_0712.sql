USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[FacturasSinCAE]    Script Date: 10/03/2016 14:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DetalleFacturasSinCAE]
AS 
    BEGIN
        SET NOCOUNT ON;
        SELECT  comp.idComprobante
        ,dc.idDetalleComprobante
        ,CASE WHEN comp.idGrupo IS NULL THEN dc.Detalle
               ELSE dc.Nombre + ' - '
                    + ISNULL(( SELECT   NumeroDeDocumento
                               FROM     dbo.Afiliados af
                               WHERE    idAfiliado = dc.idAfiliado
                             ), '') + ' - ' + pl.Nombre + ' - ' + comp.Periodo
          END ds
        ,dc.Cantidad qty
        ,CAST(dbo.PrecioUnitarioImpreso(dc.idDetalleComprobante) AS varchar(30)) PrecioUnitario
        ,pIVA.CodigoAFIP iva_id
        ,CASE WHEN tc.Serie = 'B' THEN NULL ELSE CAST(dbo.imp_IVA(dc.idDetalleComprobante) AS VARCHAR(30)) END imp_iva
        ,CAST(dbo.ImporteDelDetalleImpreso(dc.idDetalleComprobante) AS VARCHAR(30)) ImporteDelDetalle
        FROM    dbo.Comprobantes comp
        JOIN dbo.DetallesComprobantes dc ON comp.idComprobante = dc.idComprobante
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                JOIN dbo.PuntosDeVenta pv ON comp.Prefijo = pv.Prefijo
                LEFT JOIN dbo.CategoriasIVA catIVA ON comp.idCategoriaIVA = catIVA.idCategoriaIVA
                LEFT JOIN dbo.Planes pl ON dc.idPlan = pl.idPlan
                LEFT JOIN dbo.PorcentajeIVA pIVA ON dc.idPorcentajeIVA = pIVA.idPorcentajeIVA
        WHERE   pv.SolicitaCAE = 1
                AND CAST(tc.TablaAFIP AS INT) IS NOT NULL
                AND ISNULL(CAE, '') = ''
    END

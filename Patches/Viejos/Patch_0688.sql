SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE FacturasSinCAE
AS 
    BEGIN
        SET NOCOUNT ON;
        DECLARE @CUIT VARCHAR(11)
        SELECT TOP 1
                @CUIT = CUITEmpresa
        FROM    dbo.Sistemas s
        SELECT  CAST(tc.TablaAFIP AS INT) tipoCbte
               ,CAST(comp.Prefijo AS INT) puntoVta
               ,@CUIT nroDoc
               ,comp.NumeroDeComprobante cbtDesde
               ,comp.NumeroDeComprobante cbtHasta
               ,CAST(Importe AS VARCHAR(30)) impTotal
               ,CAST(ISNULL(dbo.TotalNoGravado(idComprobante), 0) AS VARCHAR(30)) impTotConc
               ,CAST(dbo.TotalGravado(idComprobante) AS VARCHAR(30)) impNeto
               ,CAST(dbo.TotalIVA(idComprobante) AS VARCHAR(30)) impIVA
               ,'0.00' impTrib
               ,CAST(ISNULL(dbo.TotalExento(idComprobante), 0) AS VARCHAR(30)) impOpEx
               ,CONVERT(VARCHAR(8), Fecha, 112) fechaCbte
               ,CONVERT(VARCHAR(8), DATEADD(d, 10, Fecha), 112) fechaVencPago
               ,CONVERT(VARCHAR(8), CASE WHEN Periodo IS NULL
                                              OR Periodo = '' THEN Fecha
                                         ELSE dbo.PrimerDiaDelPeriodo(Periodo)
                                    END, 112) fechaServDesde
               ,CONVERT(VARCHAR(8), CASE WHEN Periodo IS NULL
                                              OR Periodo = '' THEN Fecha
                                         ELSE dbo.UltimoDiaDelPeriodo(Periodo)
                                    END, 112) fechaServDesde
        FROM    dbo.Comprobantes comp
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                JOIN dbo.PuntosDeVenta pv ON comp.Prefijo = pv.Prefijo
        WHERE   pv.SolicitaCAE = 1
                AND CAST(tc.TablaAFIP AS INT) IS NOT NULL
                AND ISNULL(CAE, '') = ''
        ORDER BY idComprobante
    END
GO

USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[FacturasSinCAE]    Script Date: 09/23/2016 17:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[FacturasSinCAE]
AS 
    BEGIN
        SET NOCOUNT ON;
        DECLARE @token VARCHAR(MAX)
           ,@sign VARCHAR(MAX)
           ,@cuit VARCHAR(11)
        SELECT TOP 1
                @token = Token
               ,@sign = Sign_
        FROM    dbo.Parametros
        SELECT TOP 1
                @cuit = CUITEmpresa
        FROM    dbo.Sistemas    
        SELECT  comp.idComprobante
               ,@token Token
               ,@sign Sign
               ,CASE WHEN catIVA.ExigeCUIT = 1 THEN 80
                     ELSE 99
                END tipoDoc
               ,@cuit CUIT
               ,CAST(tc.TablaAFIP AS INT) tipoCbte
               ,CAST(comp.Prefijo AS INT) puntoVta
               ,CASE WHEN tc.Serie = 'A' THEN comp.CUIT
                     ELSE '0'
                END nroDoc
               ,CAST(comp.NumeroDeComprobante AS BIGINT) cbtDesde
               ,CAST(comp.NumeroDeComprobante AS BIGINT) cbtHasta
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
                                    END, 112) fechaServHasta
               ,CAST(dbo.TotalesIVA(idComprobante, 'Gravado', 4) AS VARCHAR(30)) baseImp4
               ,CAST(dbo.TotalesIVA(idComprobante, 'IVA', 4) AS VARCHAR(30)) importeIVA4
               ,CAST(dbo.TotalesIVA(idComprobante, 'Gravado', 5) AS VARCHAR(30)) baseImp5
               ,CAST(dbo.TotalesIVA(idComprobante, 'IVA', 5) AS VARCHAR(30)) importeIVA5
        FROM    dbo.Comprobantes comp
                JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
                JOIN dbo.PuntosDeVenta pv ON comp.Prefijo = pv.Prefijo
                LEFT JOIN dbo.CategoriasIVA catIVA ON comp.idCategoriaIVA = catIVA.idCategoriaIVA
        WHERE   pv.SolicitaCAE = 1
                AND CAST(tc.TablaAFIP AS INT) IS NOT NULL
                AND ISNULL(CAE, '') = ''
        ORDER BY idComprobante
    END

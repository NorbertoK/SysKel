USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ReporteArgencard]    Script Date: 12/26/2014 17:35:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteCredimas] @periodo VARCHAR(7)
AS 
    BEGIN
        SET NOCOUNT ON ;
/*Registro Header*/
SELECT  
/*TIPO_REGISTRO */
                '000'
/*Tipo de Archivo*/ + 'DB'
/*N° DE COMERCIO*/ + RIGHT(REPLICATE('0', 11) + ( SELECT    NumeroDeCliente
                                                  FROM      dbo.EntidadesDeCobranza
                                                  WHERE     NombreOculto = 'Credimás'
                                                ), 11)
/*FECHA PRESENTACION*/ + LEFT(REPLACE(CONVERT(NVARCHAR(30), ( GETDATE() ), 103), '/', ''), 4) + RIGHT(REPLACE(CONVERT(NVARCHAR(30), ( GETDATE() ), 103), '/', ''),
                                                                                                      4)
/*Período a Debitar*/ + LEFT(@periodo, 2) + RIGHT(@periodo, 4) 
/*Número de Presentación*/ + '01' 
/*FILLER*/ + REPLICATE(' ', 26)
        FROM    dbo.Comprobantes comp
        JOIN    dbo.Grupos g ON comp.idGrupo = g.idGrupo
        WHERE   g.idTipoDeCobranza = 2
                AND g.idEntidadDeCobranza = ( SELECT    idEntidadDeCobranza
                                              FROM      dbo.EntidadesDeCobranza
                                              WHERE     NombreOculto = 'Credimás'
                                            )
                AND comp.Periodo = @periodo
                AND comp.Saldo > 0
        UNION
/*Registro Detalle*/
        SELECT 
/*TIPO_REGISTRO */
                '001'
/*NÚMERO DE TARJETA*/ + LEFT(g.NumeroTarjeta, 16)
/*Tipo de Documento Cliente*/ + '1'
/*Número de Documento Cliente*/ + LEFT(g.NumeroDocumentoTitularTarjeta, 8)
/*ID_ABONADO*/ + '1' + RIGHT(REPLICATE('0', 19) + CAST(comp.idGrupo AS VARCHAR(19)), 19) -- El 1 inicial indica Afiliado. Si es 2 es Cliente.
/*IMPORTE*/ + RIGHT(REPLICATE('0', 10) + CAST(CAST(comp.Saldo * 100 AS INT) AS VARCHAR(10)), 10)
        FROM    dbo.Comprobantes comp
        JOIN    dbo.Grupos g ON comp.idGrupo = g.idGrupo
        WHERE   g.idTipoDeCobranza = 2
                AND g.idEntidadDeCobranza = ( SELECT    idEntidadDeCobranza
                                              FROM      dbo.EntidadesDeCobranza
                                              WHERE     NombreOculto = 'Credimás'
                                            )
                AND comp.Periodo = @periodo
                AND comp.Saldo > 0
        UNION
/*Registro Resumen*/
        SELECT 
/*TIPO_REGISTRO */
                '999'
/*CANTIDAD DE REGISTROS*/ + RIGHT(REPLICATE('0', 5) + CAST(COUNT(*) AS VARCHAR(5)), 5)
/*IMPORTE*/ + RIGHT(REPLICATE('0', 12) + CAST(CAST(SUM(comp.Saldo) * 100 AS INT) AS VARCHAR(12)), 12)
/*FILLER*/ + REPLICATE(' ', 38)
/*Fin*/ + char(10) + char(13)
        FROM    dbo.Comprobantes comp
        JOIN    dbo.Grupos g ON comp.idGrupo = g.idGrupo
        WHERE   g.idTipoDeCobranza = 2
                AND g.idEntidadDeCobranza = ( SELECT    idEntidadDeCobranza
                                              FROM      dbo.EntidadesDeCobranza
                                              WHERE     NombreOculto = 'Credimás'
                                            )
                AND comp.Periodo = @periodo
                AND comp.Saldo > 0
        ORDER BY 1
    END

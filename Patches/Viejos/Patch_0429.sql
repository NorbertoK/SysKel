USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ReporteArgencard]    Script Date: 03/10/2015 01:25:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ReporteArgencard] @periodo VARCHAR(7)
AS 
    BEGIN
        SET NOCOUNT ON ;


/*Registro Header*/
        SELECT  
/*N° DE COMERCIO*/
                '05584039'
/*TIPO_REGISTRO */ + '1'
/*FECHA PRESENTACION*/ + LEFT(REPLACE(CONVERT(NVARCHAR(30), ( GETDATE() ), 103), '/', ''), 4) + RIGHT(REPLACE(CONVERT(NVARCHAR(30), ( GETDATE() ), 103), '/', ''),
                                                                                                      2)
/*CANTIDAD DE REGISTROS*/ + RIGHT(REPLICATE('0', 7) + CAST(COUNT(*) AS VARCHAR(7)), 7)
/*SIGNO IMPORTE PRESENTE*/ + '0'
/*IMPORTE*/ + RIGHT(REPLICATE('0', 14) + CAST(CAST(SUM(comp.Saldo) * 100 AS INT) AS VARCHAR(14)), 14)
/*FILLER*/ + REPLICATE(' ', 91)
        FROM    dbo.Comprobantes comp
        WHERE   comp.idTipoDeCobranza = 2
                AND comp.idEntidadDeCobranza = ( SELECT    idEntidadDeCobranza
                                              FROM      dbo.EntidadesDeCobranza
                                              WHERE     NombreOculto = 'Argencard'
                                            )
                AND comp.Periodo = @periodo
                AND comp.Saldo > 0
        UNION
/*Registro Detalle*/
        SELECT 
/*N° DE COMERCIO*/
                '05584039'
/*TIPO_REGISTRO */ + '2'
/*NÚMERO DE TARJETA*/ + LEFT(comp.NumeroTarjeta, 16)
/*ID_ABONADO*/ + '1' + RIGHT(REPLICATE('0', 11) + CAST(comp.idGrupo AS VARCHAR(11)), 11) -- El 1 inicial indica Afiliado. Si es 2 es Cliente.
/*CUOTA/S*/ + '000'
/*CUOTAS PLAN*/ + '999'
/*FRECUENCIA DB*/ + '01'
/*IMPORTE*/ + RIGHT(REPLICATE('0', 11) + CAST(CAST(comp.Saldo * 100 AS INT) AS VARCHAR(11)), 11)
/*PERIODO*/ + LEFT(@periodo, 2) + '/' + RIGHT(@periodo, 2)
/*FILLER*/ + REPLICATE(' ', 1)
/*FECHA VTO PAGO*/ + REPLACE(CONVERT(NVARCHAR(30), ( DATEADD(mm, 1, GETDATE()) ), 103), '/', '')
/*DATOS AUXILIARES*/ + RIGHT(REPLICATE('0', 12) + CAST(comp.idComprobante AS VARCHAR(12)), 12) + REPLICATE(' ', 28)
/*FILLER*/ + REPLICATE(' ', 20)
        FROM    dbo.Comprobantes comp
        WHERE   comp.idTipoDeCobranza = 2
                AND comp.idEntidadDeCobranza = ( SELECT    idEntidadDeCobranza
                                              FROM      dbo.EntidadesDeCobranza
                                              WHERE     NombreOculto = 'Argencard'
                                            )
                AND comp.Periodo = @periodo
                AND comp.Saldo > 0
        ORDER BY 1
    END

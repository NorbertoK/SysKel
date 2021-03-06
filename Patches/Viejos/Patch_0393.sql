/****** Object:  StoredProcedure [dbo].[ReporteMacro]    Script Date: 10/30/2014 13:51:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteArgencard] @periodo VARCHAR(7)
AS 
    BEGIN
        SET NOCOUNT ON ;


/*Registro Header*/
        SELECT  
/*N° DE COMERCIO*/
                '05587039'
/*TIPO_REGISTRO */ + '1'
/*FECHA PRESENTACION*/ + REPLACE(CONVERT(NVARCHAR(30), ( GETDATE() ), 103), '/', '')
/*CANTIDAD DE REGISTROS*/ + RIGHT(REPLICATE('0', 7) + CAST(COUNT(*) AS VARCHAR(7)), 7)
/*SIGNO IMPORTE PRESENTE*/ + '0'
/*IMPORTE*/ + RIGHT(REPLICATE('0', 14) + CAST(CAST(SUM(comp.Saldo) * 100 AS INT) AS VARCHAR(14)), 14)
/*FILLER*/ + REPLICATE(' ', 91)
        FROM    dbo.Comprobantes comp
        JOIN    dbo.Grupos g ON comp.idGrupo = g.idGrupo
        WHERE   g.idEntidadDeCobranza = ( SELECT    idEntidadDeCobranza
                                          FROM      dbo.EntidadesDeCobranza
                                          WHERE     NombreOculto = 'Argencard'
                                        )
                AND comp.Periodo = @periodo
        UNION
/*Registro Detalle*/
        SELECT 
/*N° DE COMERCIO*/
                '05587039'
/*TIPO_REGISTRO */ + '2'
/*NÚMERO DE TARJETA*/ + LEFT(g.NumeroTarjeta,16)
/*ID_ABONADO*/ + RIGHT(REPLICATE('0', 12) + CAST(comp.idComprobante AS VARCHAR(12)), 12)
/*CUOTA/S*/ + '000'
/*CUOTAS PLAN*/ + '999'
/*FRECUENCIA DB*/ + '01'
/*IMPORTE*/ + RIGHT(REPLICATE('0', 11) + CAST(CAST(comp.Saldo * 100 AS INT) AS VARCHAR(11)), 11)
/*PERIODO*/ + LEFT(@periodo,2) + '/' + RIGHT(@periodo,2)
/*FILLER*/ + REPLICATE(' ', 1)
/*FECHA VTO PAGO*/ + REPLACE(CONVERT(NVARCHAR(30), ( DATEADD(mm,1,GETDATE()) ), 103), '/', '')
/*DATOS AUXILIARES*/ + REPLICATE(' ', 40)
/*FILLER*/ + REPLICATE(' ', 20)
        FROM    dbo.Comprobantes comp
        JOIN    dbo.Grupos g ON comp.idGrupo = g.idGrupo
        WHERE   g.idEntidadDeCobranza = ( SELECT    idEntidadDeCobranza
                                          FROM      dbo.EntidadesDeCobranza
                                          WHERE     NombreOculto = 'Argencard'
                                        )
                AND comp.Periodo = @periodo
        ORDER BY 1
    END

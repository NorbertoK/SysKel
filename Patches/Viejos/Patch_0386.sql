SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE ReporteMacro
    @periodo VARCHAR(7)
   ,@jubilado INT
   ,@secuencial INT
   ,@rectificativa INT
AS 
    BEGIN
        SET NOCOUNT ON ;

/*Registro 1*/
        SELECT  
/*TIPO_REGISTRO */
                '0'
/*TIPO_ARCHIVO*/ + '2' -- Vuelco A Definitivo
/*BLANCOS*/ + REPLICATE(' ', 106)
        UNION
/*Registro 2*/
        SELECT 
/*TIPO_REGISTRO*/
                '1'
/*COD_BANCO*/ + '285'
/*CONVENIO*/ + '10673'
/*PARÁMETRO_CARGA*/ + '00' + LEFT(@periodo, 2)
/*SECUENCIAL*/ + RIGHT('0' + CAST(@secuencial AS VARCHAR(2)), 2)
/*COD_RECTIFICATIVA*/ + CAST(@rectificativa AS VARCHAR(1))
/*EMPRESA_SUELDOS*/ + '00000'
/*BLANCOS*/ + REPLICATE(' ', 87)
        UNION
/*Registro 3*/
        SELECT 
/*TIPO_REGISTRO*/
                '2'
/*CONVENIO*/ + '10673'
/*SERVICIO*/ + REPLICATE(' ', 10)
/*EMPRESA _SUELDOS*/ + REPLICATE('0', 5)
/*ID_ABONADO*/ + LEFT(CAST(idComprobante AS VARCHAR(20)) + REPLICATE(' ', 20), 20)
/*FECHA VENCIMIENTO*/ + CAST(DATEPART(yy, DATEADD(dd, 65, dbo.PrimerDiaDelPeriodo(@periodo))) AS VARCHAR(4)) + RIGHT('0'
                                                                                                                     + CAST(DATEPART(mm,
                                                                                                                                     DATEADD(dd, 65,
                                                                                                                                             dbo.PrimerDiaDelPeriodo(@periodo))) AS VARCHAR(10)),
                                                                                                                     2) + RIGHT('0'
                                                                                                                                + CAST(DATEPART(dd,
                                                                                                                                                DATEADD(dd, 65,
                                                                                                                                                dbo.PrimerDiaDelPeriodo(@periodo))) AS VARCHAR(10)),
                                                                                                                                2)
/*IMPORTE*/ + RIGHT(REPLICATE('0', 11) + CAST(CAST(comp.Saldo * 100 AS INT) AS VARCHAR(11)), 11)
/*CÓDIGO DE BANCO*/ + '285'
/*TIPO_CUENTA*/ + '4' 
/*SUC_CUENTA*/ + LEFT(CAST(g.Sucursal AS VARCHAR(3)) + REPLICATE('0', 3), 3) 
/*NÚMERO DE CUENTA*/ + LEFT(CAST(g.NumeroTarjeta AS VARCHAR(16)) + REPLICATE(' ', 16), 16) 
/*SECUENCIAL*/ + RIGHT('0' + CAST(ROW_NUMBER() OVER ( PARTITION BY comp.idGrupo ORDER BY comp.idComprobante ) AS VARCHAR(2)), 2) 
/*CUOTA*/ + '00'
/*ESTADO*/ + ' '
/*LIBRES*/ + REPLICATE(' ', 20)
        FROM    dbo.Comprobantes comp
        JOIN    dbo.Grupos g ON comp.idGrupo = g.idGrupo
        WHERE   g.idEntidadDeCobranza = 1
                AND g.Jubilado = @jubilado
                AND g.Sucursal IS NOT NULL
                AND comp.Periodo = @periodo
        ORDER BY 1
    END
GO

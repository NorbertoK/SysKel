USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[EnCajaTodos]    Script Date: 02/17/2017 13:04:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[EnCajaTodos]
AS
BEGIN
	SET NOCOUNT ON;
    DECLARE @tabla table    (    Empleado varchar(100)
                                ,TipoDeValor varchar(50)
                                ,Importe money
                                ,Banco varchar(50)
                                ,NumeroDeCheque varchar(15)
                                ,Vencimiento datetime
                                ,Observaciones varchar(MAX)
                            )
    INSERT @tabla   (	 Empleado
                        ,TipoDeValor 
                        ,Importe 
                        ,Banco 
                        ,NumeroDeCheque 
                        ,Vencimiento 
                        ,Observaciones 
                    )
    SELECT emp.ApelNomb
          ,tv.Nombre 
          ,vr.Importe
          ,b.Nombre
          ,vr.NumeroDeCheque
          ,vr.Vencimiento
          ,vr.Observaciones
    FROM dbo.ValoresRemesas vr
	JOIN dbo.Empleados emp on emp.idEmpleado = vr.idEmpleado
	LEFT JOIN dbo.TiposDeValores tv on tv.idTipoDeValor = vr.idTipoDeValor
	LEFT JOIN dbo.Bancos b on b.idBanco = vr.idBanco
    WHERE tv.EsEfectivo = 0
        AND EntregadoIdTransferencia is null
        AND EntregadoIdRetiro is NULL
        AND EntregadoIdOrdenDePago IS NULL
    UNION ALL
    SELECT emp.ApelNomb
          ,'Efectivo'
          ,sum(vr.Importe)
          ,null
          ,null
          ,null
          ,null
    FROM dbo.ValoresRemesas vr
	JOIN dbo.Empleados emp on emp.idEmpleado = vr.idEmpleado
	JOIN dbo.TiposDeValores tv ON vr.idTipoDeValor = tv.idTipoDeValor
    WHERE tv.EsEfectivo = 1
	Group By emp.ApelNomb
	HAVING sum(vr.Importe) > 0
    SELECT * FROM @tabla
	ORDER BY 1,2
END


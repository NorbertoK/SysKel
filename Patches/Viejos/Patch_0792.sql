USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[EnCaja]    Script Date: 12/15/2016 14:58:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[EnCaja] @idEmpleado int
AS
BEGIN
	SET NOCOUNT ON;
    DECLARE @tabla table    (    idValorRemesa int
                                ,idTipoDeValor int
                                ,Importe money
                                ,idBanco int
                                ,NumeroDeCheque varchar(15)
                                ,Vencimiento datetime
                                ,NumeroPropio int
                                ,Observaciones varchar(MAX)
                                ,Transferido bit
                                ,ImporteTransferido money
                            )
    INSERT @tabla   (
                         idvalorRemesa 
                        ,idTipoDeValor 
                        ,Importe 
                        ,idBanco 
                        ,NumeroDeCheque 
                        ,Vencimiento 
                        ,NumeroPropio 
                        ,Observaciones 
                        ,Transferido 
                        ,ImporteTransferido
                    )
    SELECT vr.idValorRemesa 
          ,vr.idTipoDeValor 
          ,vr.Importe
          ,vr.idBanco
          ,vr.NumeroDeCheque
          ,vr.Vencimiento
          ,vr.NumeroPropio
          ,vr.Observaciones
          ,0
          ,0
    FROM dbo.ValoresRemesas vr
    JOIN dbo.TiposDeValores tv ON vr.idTipoDeValor = tv.idTipoDeValor
    WHERE vr.idEmpleado = @idEmpleado
        AND tv.EsEfectivo = 0 
        AND EntregadoIdTransferencia is null
        AND EntregadoIdRetiro is NULL
        AND EntregadoIdOrdenDePago IS NULL
    UNION ALL
    SELECT 0
          ,(SELECT TOP 1 idTipoDeValor FROM dbo.TiposDeValores tv WHERE tv.EsEfectivo = 1)
          ,sum(vr.Importe)
          ,null
          ,null
          ,null
          ,null
          ,null
          ,0
          ,0
    FROM dbo.ValoresRemesas vr
    JOIN dbo.TiposDeValores tv ON vr.idTipoDeValor = tv.idTipoDeValor
    WHERE vr.idEmpleado = @idEmpleado
        AND tv.EsEfectivo = 1
	HAVING sum(vr.Importe) > 0
    SELECT * FROM @tabla
END


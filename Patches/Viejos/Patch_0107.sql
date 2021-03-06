USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[EnCaja]    Script Date: 05/03/2013 11:47:31 ******/
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
    WHERE vr.idEmpleado = @idEmpleado
        AND vr.idTipoDeValor != (SELECT TOP 1 ValoresEfectivo FROM dbo.Sistemas)
        AND EntregadoIdTransferencia is null
        AND EntregadoIdRetiro is NULL
        AND EntregadoIdPago IS NULL
    UNION ALL
    SELECT 0
          ,(SELECT TOP 1 ValoresEfectivo FROM dbo.Sistemas)
          ,sum(vr.Importe)
          ,null
          ,null
          ,null
          ,null
          ,null
          ,0
          ,0
    FROM dbo.ValoresRemesas vr
    WHERE vr.idEmpleado = @idEmpleado
        AND vr.idTipoDeValor = (SELECT TOP 1 ValoresEfectivo FROM dbo.Sistemas)
	HAVING sum(vr.Importe) > 0
    SELECT * FROM @tabla
END


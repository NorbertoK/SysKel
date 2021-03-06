USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ProcesarPago]    Script Date: 08/04/2013 20:44:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[ProcesarPago] @idPago INT = 0
AS 
    SET NOCOUNT ON
    BEGIN TRY
        BEGIN TRANSACTION
        DECLARE @fecha SMALLDATETIME
        SELECT  @fecha = Fecha
        FROM    dbo.Pagos
        WHERE   idPago = @idPago
        DECLARE @idTipoPago INT
        SELECT TOP 1
                @idtipoPago = Pago
        FROM    dbo.Sistemas

		-- Hacer los recibos
        INSERT  INTO dbo.Compras
                ( 
                 idProveedor
                ,idGrabador
                ,Fecha
                ,Comprobante
                ,Importe
                ,Aprobado
                ,idTipoDeComprobante
                ,idReferencia
                ,FechaRegistro
                ,idPago
                )
                SELECT  comp.idProveedor
                       ,comp.idGrabador
                       ,@fecha
                       ,cp.ComprobanteCompra
                       ,cp.ImportePagado
                       ,0
                       ,@idTipoPago
                       ,comp.idCompra
                       ,@fecha
                       ,@idPago
                FROM    dbo.ComprobantesPagos cp
                JOIN    dbo.Compras comp ON ( cp.idCompra = comp.idCompra )
                WHERE   cp.idPago = @idPago
                        AND cp.ImportePagado > 0
		-- Fin de Hacer los recibos
		
		-- Procesar Valores
		DECLARE @n int
            DECLARE @cuantos int
            DECLARE @idCaja int
            SELECT @idCaja = idCaja FROM dbo.Pagos WHERE idPago = @idPago
            DECLARE @tabla table    (   Renglon int identity(1,1),
                                        idValorRemesa int, 
                                        idTipoDeValor int, 
                                        Importe money,
                                        idBanco int,
                                        NumeroDeCheque varchar(15),
                                        Vencimiento datetime,
                                        NumeroPropio int, 
                                        Observaciones varchar(MAX), 
                                        Transferido bit, 
                                        ImporteTransferido money
                                    )
            INSERT @tabla   (   idValorRemesa, 
                                idTipoDeValor, 
                                Importe,
                                idBanco,
                                NumeroDeCheque,
                                Vencimiento,
                                NumeroPropio, 
                                Observaciones, 
                                Transferido, 
                                ImporteTransferido
                            )
            SELECT  idValorRemesa, 
                    idTipoDeValor, 
                    Importe,
                    idBanco,
                    NumeroDeCheque,
                    Vencimiento,
                    NumeroPropio, 
                    Observaciones, 
                    Transferido, 
                    ImporteTransferido
            FROM    dbo.ValoresRetiros
            WHERE   idPago = @idPago
            SET @cuantos = @@ROWCOUNT
            SET @n = 1
            WHILE @n <= @cuantos
            BEGIN
                IF (SELECT ImporteTransferido FROM @tabla WHERE Renglon = @n) != 0
                BEGIN
                    IF (SELECT idValorRemesa FROM @tabla WHERE Renglon = @n) = 0
                    BEGIN
                        INSERT INTO [Datos].[dbo].[ValoresRemesas]
                           ([idTipoDeValor]
                           ,[Importe]
                           ,[Observaciones]
                           ,[EntregadoIdPago]
                           ,[idEmpleado])
                        SELECT
                            (SELECT TOP 1 ValoresEfectivo FROM dbo.Sistemas),
                            ImporteTransferido * -1,
                            Observaciones,
                            @idPago,
                            @idCaja
                        FROM    @tabla
                        WHERE   Renglon = @n
                    END
                    ELSE
                    BEGIN
                        UPDATE dbo.ValoresRemesas
                        SET EntregadoIdPago = @idPago
                        WHERE idValorRemesa = (SELECT idValorRemesa FROM @tabla WHERE Renglon = @n)
                    END
                END
                SET @n = @n + 1
            END
		-- Fin de Procesar Valores

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK
        RETURN 0
    END CATCH
    RETURN 1

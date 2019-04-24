USE [Datos]
GO

/****** Object:  StoredProcedure [dbo].[ProcesarPago]    Script Date: 11/20/2016 20:06:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcesarPago]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProcesarPago]
GO

USE [Datos]
GO

/****** Object:  StoredProcedure [dbo].[ProcesarPago]    Script Date: 11/20/2016 20:06:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ProcesarOrdenDePago] @idOrdenDePago INT = 0
AS 
    SET NOCOUNT ON
    BEGIN TRY
        BEGIN TRANSACTION
        DECLARE @fecha SMALLDATETIME
        SELECT  @fecha = Fecha
        FROM    dbo.OrdenesDePago
        WHERE   idOrdenDePago = @idOrdenDePago
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
                ,idTipoDeComprobante
                ,idReferencia
                ,FechaRegistro
                ,idOrdenDePago
                )
                SELECT  comp.idProveedor
                       ,comp.idGrabador
                       ,@fecha
                       ,cop.ComprobanteCompra
                       ,cop.ImportePagado
                       ,@idTipoPago
                       ,comp.idCompra
                       ,@fecha
                       ,@idOrdenDePago
                FROM    dbo.ComprobantesOrdenesDePago cop
                JOIN    dbo.Compras comp ON ( cop.idCompra = comp.idCompra )
                WHERE   cop.idOrdenDePago = @idOrdenDePago
                        AND cop.ImportePagado > 0
		-- Fin de Hacer los recibos
		
		-- Procesar Valores
		DECLARE @n int
            DECLARE @cuantos int
            DECLARE @idCaja int
            SELECT @idCaja = idCaja FROM dbo.OrdenesDePago WHERE idOrdenDePago = @idOrdenDePago
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
            WHERE   idOrdenDePago = @idOrdenDePago
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
                           ,[EntregadoIdOrdenDePago]
                           ,[idEmpleado])
                        SELECT
                            (SELECT TOP 1 ValoresEfectivo FROM dbo.Sistemas),
                            ImporteTransferido * -1,
                            Observaciones,
                            @idOrdenDePago,
                            @idCaja
                        FROM    @tabla
                        WHERE   Renglon = @n
                    END
                    ELSE
                    BEGIN
                        UPDATE dbo.ValoresRemesas
                        SET EntregadoIdOrdenDePago = @idOrdenDePago
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

GO



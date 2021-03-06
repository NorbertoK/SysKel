USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ProcesarOrdenDePago]    Script Date: 12/15/2016 14:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[ProcesarOrdenDePago] @idOrdenDePago INT = 0
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
                        JOIN dbo.Compras comp ON ( cop.idCompra = comp.idCompra )
                WHERE   cop.idOrdenDePago = @idOrdenDePago
                        AND cop.ImportePagado > 0
		-- Fin de Hacer los recibos
		
		-- Procesar Valores
        DECLARE @n INT
        DECLARE @cuantos INT
        DECLARE @idCaja INT
        SELECT  @idCaja = idCaja
        FROM    dbo.OrdenesDePago
        WHERE   idOrdenDePago = @idOrdenDePago
        DECLARE @tabla TABLE
            (
             Renglon INT IDENTITY(1, 1)
            ,idValorRemesa INT
            ,idTipoDeValor INT
            ,Importe MONEY
            ,idBanco INT
            ,NumeroDeCheque VARCHAR(15)
            ,Vencimiento DATETIME
            ,NumeroPropio INT
            ,Observaciones VARCHAR(MAX)
            ,Transferido BIT
            ,ImporteTransferido MONEY
            )
        INSERT  @tabla
                ( 
                 idValorRemesa
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
                SELECT  idValorRemesa
                       ,idTipoDeValor
                       ,Importe
                       ,idBanco
                       ,NumeroDeCheque
                       ,Vencimiento
                       ,NumeroPropio
                       ,Observaciones
                       ,Transferido
                       ,ImporteTransferido
                FROM    dbo.ValoresRetiros
                WHERE   idOrdenDePago = @idOrdenDePago
        SET @cuantos = @@ROWCOUNT
        SET @n = 1
        WHILE @n <= @cuantos 
            BEGIN
                IF ( SELECT ImporteTransferido
                     FROM   @tabla
                     WHERE  Renglon = @n
                   ) != 0 
                    BEGIN
                        IF ( SELECT idValorRemesa
                             FROM   @tabla
                             WHERE  Renglon = @n
                           ) = 0 
                            BEGIN
                                INSERT  INTO [Datos].[dbo].[ValoresRemesas]
                                        ( 
                                         [idTipoDeValor]
                                        ,[Importe]
                                        ,[Observaciones]
                                        ,[EntregadoIdOrdenDePago]
                                        ,[idEmpleado]
                                        )
                                        SELECT  ( SELECT TOP 1
                                                            idTipoDeValor
                                                  FROM      dbo.TiposDeValores tv
                                                  WHERE     tv.EsEfectivo = 1
                                                )
                                               ,ImporteTransferido * -1
                                               ,Observaciones
                                               ,@idOrdenDePago
                                               ,@idCaja
                                        FROM    @tabla
                                        WHERE   Renglon = @n
                            END
                        ELSE 
                            BEGIN
                                UPDATE  dbo.ValoresRemesas
                                SET     EntregadoIdOrdenDePago = @idOrdenDePago
                                WHERE   idValorRemesa = ( SELECT
                                                              idValorRemesa
                                                          FROM
                                                              @tabla
                                                          WHERE
                                                              Renglon = @n
                                                        )
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


USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[RecibosRemesa]    Script Date: 05/01/2013 18:13:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[RecibosPagos] @idPago INT = 0
AS 
    SET NOCOUNT ON
    BEGIN TRY
        BEGIN TRANSACTION
        DECLARE @fecha SMALLDATETIME
        SELECT  @fecha = Fecha
        FROM    dbo.Pagos
        WHERE   idPago = @idPago
        DECLARE @idTipoRecibo INT
        DECLARE @idTipoDeComprobante INT
        SELECT TOP 1
                @idtipoRecibo = Recibo
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
                )
                SELECT  comp.idProveedor
                       ,comp.idGrabador
                       ,@fecha
                       ,cp.ComprobanteCompra
                       ,cp.ImportePagado
                       ,0
                       ,@idTipoDeComprobante
                       ,comp.idCompra
                       ,@fecha
                FROM    dbo.ComprobantesPagos cp
                JOIN    dbo.Compras comp ON ( cp.idCompra = comp.idCompra )
                WHERE   cp.idPago = @idPago
                        AND cp.ImportePagado > 0
		-- Fin de Hacer los recibos

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK
        RETURN 0
    END CATCH
    RETURN 1

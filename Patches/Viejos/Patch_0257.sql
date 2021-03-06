USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[RecibosRemesa]    Script Date: 01/09/2014 18:16:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[RecibosRemesa] @idRemesa INT = 0
AS 
    SET NOCOUNT ON
    BEGIN TRY
        BEGIN TRANSACTION
        DECLARE @fecha SMALLDATETIME
        SELECT  @fecha = Fecha
        FROM    dbo.Remesas
        WHERE   idRemesa = @idRemesa
        DECLARE @idTipoRecibo INT
        DECLARE @idTipoDeComprobante INT
        SELECT TOP 1
                @idtipoRecibo = Recibo
        FROM    dbo.Sistemas

		-- Hacer los recibos
        INSERT  INTO dbo.Comprobantes
                ( 
                 idTipoDeComprobante
                ,Fecha
                ,Periodo
                ,idGrupo
                ,idCliente
                ,Importe
                ,idReferencia
			
                )
                SELECT  @idTipoRecibo
                       ,@fecha
                       ,comp.Periodo
                       ,comp.idGrupo
                       ,comp.idCliente
                       ,cr.ImporteCobrado
                       ,cr.idReferencia
                FROM    dbo.ComprobantesRemesas cr
                JOIN    dbo.Comprobantes comp ON ( cr.idReferencia = comp.idComprobante )
                WHERE   cr.idRemesa = @idRemesa
                        AND cr.ImporteCobrado > 0
		-- Fin de Hacer los recibos

		-- Hacer las NdeC o NdeD
        DECLARE @NdeC TABLE
            (
             idComprobante INT
            ,idReferencia INT
            ,Prefijo VARCHAR(4)
            ,idTipoDeComprobante INT
            ) ;
        INSERT  dbo.Comprobantes
                ( 
                 idTipoDeComprobante
                ,Prefijo
                ,NumeroDeComprobante
                ,idReferencia
                ,Fecha
                ,Importe
                ,idGrupo
                ,idCliente
                ,Periodo
			  
                )
        OUTPUT  INSERTED.idComprobante
               ,INSERTED.idReferencia
               ,INSERTED.Prefijo
               ,INSERTED.idTipoDeComprobante
                INTO @NdeC
                SELECT  ( SELECT    idTipoDeComprobante
                          FROM      dbo.TiposDeComprobante
                          WHERE     Tipo = CASE WHEN cr.ImporteReferencia > cr.ImporteCobrado THEN 'NdeC'
                                                ELSE 'NdeD'
                                           END
                                    AND Serie = ( SELECT    tdec.Serie
                                                  FROM      dbo.Comprobantes c
                                                  JOIN      dbo.TiposDeComprobante tdec ON c.idTipoDeComprobante = tdec.idTipoDeComprobante
                                                )
                        ) idTipoDeComprobante
                       ,comp.Prefijo
                       ,RIGHT(REPLICATE('0', 8) + CONVERT	(VARCHAR(8), ( SELECT   CASE ( SELECT   Serie
                                                                                           FROM     dbo.TiposDeComprobante
                                                                                           WHERE    idTipoDeComprobante = comp.idTipoDeComprobante
                                                                                         )
                                                                                      WHEN 'A' THEN UltimoNumeroAsignadoA
                                                                                      WHEN 'B' THEN UltimoNumeroAsignadoB
                                                                                      ELSE UltimoNumeroAsignado
                                                                                    END
                                                                           FROM     dbo.PuntosDeVenta
                                                                           WHERE    Prefijo = comp.Prefijo
                                                                         )
                              + Row_Number() OVER ( PARTITION BY comp.Prefijo, comp.idTipoDeComprobante ORDER BY ( SELECT   ( 0 )
                                                                                                                 ) )), 8)
                       ,cr.idReferencia
                       ,@fecha
                       ,CASE WHEN cr.ImporteReferencia > cr.ImporteCobrado THEN cr.ImporteReferencia - cr.ImporteCobrado ELSE cr.ImporteCobrado - cr.ImporteReferencia END 
                       ,comp.idGrupo
                       ,comp.idCliente
                       ,comp.Periodo
                FROM    dbo.ComprobantesRemesas cr
                JOIN    dbo.Comprobantes comp ON ( cr.idReferencia = comp.idComprobante )
                WHERE   cr.idRemesa = @idRemesa
                        AND cr.ImporteReferencia != cr.ImporteCobrado
                        AND cr.HacerNdeC = 1
			-- Actualización de los Puntos de Venta
			;
        WITH    Notas ( Prefijo, Serie, cantComprobantes )
                  AS ( SELECT   Prefijo
                               ,tc.Serie
                               ,COUNT(*)
                       FROM     @NdeC nc
                       JOIN     dbo.TiposDeComprobante tc ON nc.idTipoDeComprobante = tc.idTipoDeComprobante
                       GROUP BY Prefijo
                               ,Serie
                     )
            UPDATE  dbo.PuntosDeVenta
            SET     UltimoNumeroAsignado = UltimoNumeroAsignado + CASE WHEN n.Serie <> 'A'
                                                                            AND n.Serie <> 'B' THEN n.cantComprobantes
                                                                       ELSE 0
                                                                  END
                   ,UltimoNumeroAsignadoA = UltimoNumeroAsignadoA + CASE WHEN n.Serie = 'A' THEN n.cantComprobantes
                                                                         ELSE 0
                                                                    END
                   ,UltimoNumeroAsignadoB = UltimoNumeroAsignadoB + CASE WHEN n.Serie = 'B' THEN n.cantComprobantes
                                                                         ELSE 0
                                                                    END
            FROM    dbo.PuntosDeVenta pv
            JOIN    Notas n ON pv.Prefijo = n.Prefijo 
			-- Fin de la Actualización de los Puntos de Venta
			-- Inserción de los Detalles de la N.deC.
        INSERT  dbo.DetallesComprobantes
                ( 
                 idComprobante
                ,Detalle
                ,Importe
				
                )
                SELECT  nc.idComprobante
                       ,cr.Observaciones
                       ,cr.ImporteReferencia - cr.ImporteCobrado
                FROM    @NdeC nc
                JOIN    dbo.ComprobantesRemesas cr ON nc.idComprobante = cr.idReferencia
                WHERE   cr.idRemesa = @idRemesa
			-- Fin de Inserción de los Detalles de la N.deC.
		-- Fin de Hacer las NdeC

		-- Total de la Remesa
        UPDATE  dbo.Remesas
        SET     Importe = ( SELECT  SUM(ImporteCobrado)
                            FROM    dbo.ComprobantesRemesas
                            WHERE   idRemesa = @idRemesa
                          )
        WHERE   idRemesa = @idRemesa
		-- Fin de Total de la Remesa
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK
        RETURN 0
    END CATCH
    RETURN 1



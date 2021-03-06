USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[RecibosRemesa]    Script Date: 04/10/2019 18:43:06 ******/
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
        DECLARE @NumeroDeRecibo INT
        SELECT TOP 1
                @NumeroDeRecibo = ISNULL(UltimoNumeroDeRecibo, 0) + 1
        FROM    dbo.Parametros
        SELECT TOP 1
                @idtipoRecibo = Recibo
        FROM    dbo.Sistemas
        IF ( SELECT ISNULL(Caja, '')
             FROM   dbo.Remesas
             WHERE  idRemesa = @idRemesa
           ) = '' 
            BEGIN
                UPDATE  dbo.Remesas
                SET     Caja = @NumeroDeRecibo
                WHERE   idRemesa = @idRemesa
                UPDATE  dbo.Parametros
                SET     UltimoNumeroDeRecibo = @numeroDeRecibo
            END

		-- Hacer los recibos
        INSERT  INTO dbo.Comprobantes
                ( 
                 idTipoDeComprobante
                ,Fecha
                ,Periodo
                ,idGrupo
                ,idCliente
                ,Apellido
                ,Nombre
                ,Importe
                ,idReferencia
                ,NumeroDeComprobante
                )
                SELECT  @idTipoRecibo
                       ,@fecha
                       ,comp.Periodo
                       ,comp.idGrupo
                       ,comp.idCliente
                       ,comp.Apellido
                       ,comp.Nombre
                       ,cr.ImporteCobrado
                       ,cr.idReferencia
                       ,r.Caja
                FROM    dbo.ComprobantesRemesas cr
                        JOIN dbo.Comprobantes comp ON ( cr.idReferencia = comp.idComprobante )
                        JOIN dbo.Remesas r ON cr.idRemesa = r.idRemesa
                WHERE   cr.idRemesa = @idRemesa
                        AND cr.ImporteCobrado > 0
		-- Fin de Hacer los recibos

		-- Hacer las NdeC o NdeD
        DECLARE @prefijo VARCHAR(4) = ( SELECT  MAX(Prefijo)
                                        FROM    dbo.PuntosDeVenta
                                        WHERE   SolicitaCAE > 0
                                      )
        DECLARE @NdeC TABLE
            (
             idComprobante INT
            ,idReferencia INT
            ,Prefijo VARCHAR(4)
            ,idTipoDeComprobante INT
            );
        INSERT  dbo.Comprobantes
                ( 
                 idTipoDeComprobante
                ,Prefijo
                ,NumeroDeComprobante
                ,idReferencia
                ,Apellido
                ,Nombre
                ,Fecha
                ,Importe
                ,idGrupo
                ,idCliente
                ,Periodo
                ,CantidadDeDetalles
                ,idCategoriaIVA
                ,CUIT
                ,Barrio
                ,Direccion
                ,Entre
                ,idZona
                ,Localidad
                ,ObservacionesDireccion
                )
        OUTPUT  INSERTED.idComprobante
               ,INSERTED.idReferencia
               ,INSERTED.Prefijo
               ,INSERTED.idTipoDeComprobante
                INTO @NdeC
                SELECT  ( SELECT    idTipoDeComprobante
                          FROM      dbo.TiposDeComprobante
                          WHERE     Tipo = CASE WHEN cr.ImporteReferencia > cr.ImporteCobrado
                                                THEN 'NdeC'
                                                ELSE 'NdeD'
                                           END
                                    AND Serie = ( SELECT    tdec.Serie
                                                  FROM      dbo.Comprobantes c
                                                            JOIN dbo.TiposDeComprobante tdec ON c.idTipoDeComprobante = tdec.idTipoDeComprobante
                                                  WHERE     idComprobante = comp.idComprobante
                                                )
                        ) idTipoDeComprobante
                       ,CASE WHEN comp.Prefijo = '0000' THEN '0000'
                             ELSE @prefijo
                        END
                       ,CASE WHEN ( SELECT TOP 1
                                            NombreEmpresa
                                    FROM    dbo.Sistemas
                                  ) = 'Activa' THEN NULL
                             ELSE RIGHT(REPLICATE('0', 8)
                                        + CONVERT	(VARCHAR(8), ( SELECT
                                                              CASE ( SELECT
                                                              Serie
                                                              FROM
                                                              dbo.TiposDeComprobante
                                                              WHERE
                                                              idTipoDeComprobante = comp.idTipoDeComprobante
                                                              )
                                                              WHEN 'A'
                                                              THEN CASE
                                                              WHEN cr.ImporteReferencia > cr.ImporteCobrado
                                                              THEN UltimoNumeroAsignacoNdeCA
                                                              ELSE UltimoNumeroAsignacoNdeDA
                                                              END
                                                              WHEN 'B'
                                                              THEN CASE
                                                              WHEN cr.ImporteReferencia > cr.ImporteCobrado
                                                              THEN UltimoNumeroAsignacoNdeCB
                                                              ELSE UltimoNumeroAsignacoNdeDB
                                                              END
                                                              WHEN 'M'
                                                              THEN CASE
                                                              WHEN cr.ImporteReferencia > cr.ImporteCobrado
                                                              THEN UltimoNumeroAsignacoNdeCM
                                                              ELSE UltimoNumeroAsignacoNdeDM
                                                              END
                                                              ELSE UltimoNumeroAsignado
                                                              END
                                                              FROM
                                                              dbo.PuntosDeVenta
                                                              WHERE
                                                              Prefijo = comp.Prefijo
                                                              )
                                        + ROW_NUMBER() OVER ( PARTITION BY CASE
                                                              WHEN comp.Prefijo = '0000'
                                                              THEN '0000'
                                                              ELSE @prefijo
                                                              END,
                                                              comp.idTipoDeComprobante ORDER BY ( SELECT
                                                              ( 0 )
                                                              ) )), 8)
                        END
                       ,cr.idReferencia
                       ,comp.Apellido
                       ,comp.Nombre
                       ,CASE WHEN @fecha < dbo.UltimaFechaComprobantes(CASE
                                                              WHEN comp.Prefijo = '0000'
                                                              THEN '0000'
                                                              ELSE @prefijo
                                                              END,
                                                              ( SELECT
                                                              idTipoDeComprobante
                                                              FROM
                                                              dbo.TiposDeComprobante
                                                              WHERE
                                                              Tipo = CASE
                                                              WHEN cr.ImporteReferencia > cr.ImporteCobrado
                                                              THEN 'NdeC'
                                                              ELSE 'NdeD'
                                                              END
                                                              AND Serie = ( SELECT
                                                              tdec.Serie
                                                              FROM
                                                              dbo.Comprobantes c
                                                              JOIN dbo.TiposDeComprobante tdec ON c.idTipoDeComprobante = tdec.idTipoDeComprobante
                                                              WHERE
                                                              idComprobante = comp.idComprobante
                                                              )
                                                              ))
                             THEN dbo.UltimaFechaComprobantes(CASE
                                                              WHEN comp.Prefijo = '0000'
                                                              THEN '0000'
                                                              ELSE @prefijo
                                                              END,
                                                              ( SELECT
                                                              idTipoDeComprobante
                                                              FROM
                                                              dbo.TiposDeComprobante
                                                              WHERE
                                                              Tipo = CASE
                                                              WHEN cr.ImporteReferencia > cr.ImporteCobrado
                                                              THEN 'NdeC'
                                                              ELSE 'NdeD'
                                                              END
                                                              AND Serie = ( SELECT
                                                              tdec.Serie
                                                              FROM
                                                              dbo.Comprobantes c
                                                              JOIN dbo.TiposDeComprobante tdec ON c.idTipoDeComprobante = tdec.idTipoDeComprobante
                                                              WHERE
                                                              idComprobante = comp.idComprobante
                                                              )
                                                              ))
                             ELSE @fecha
                        END
                       ,CASE WHEN cr.ImporteReferencia > cr.ImporteCobrado
                             THEN cr.ImporteReferencia - cr.ImporteCobrado
                             ELSE cr.ImporteCobrado - cr.ImporteReferencia
                        END
                       ,comp.idGrupo
                       ,comp.idCliente
                       ,comp.Periodo
                       ,1
                       ,comp.idCategoriaIVA
                       ,comp.CUIT
                       ,comp.Barrio
                       ,comp.Direccion
                       ,comp.Entre
                       ,comp.idZona
                       ,comp.Localidad
                       ,comp.ObservacionesDireccion
                FROM    dbo.ComprobantesRemesas cr
                        JOIN dbo.Comprobantes comp ON ( cr.idReferencia = comp.idComprobante )
                WHERE   cr.idRemesa = @idRemesa
                        AND cr.ImporteReferencia != cr.ImporteCobrado
                        AND cr.HacerNdeC = 1
                                                
        INSERT  dbo.DetallesComprobantes
                ( 
                 idComprobante
                ,Cantidad
                ,Detalle
                ,idAfiliado
                ,idNegocio
                ,idPaciente
                ,idPlan
                ,idRenglonFacturaProforma
                ,Importe
                ,Nombre
                ,idPorcentajeIVA
                ,PrecioUnitario
                )
                SELECT  nc.idComprobante
                       ,dc.Cantidad
                       ,dc.Detalle
                       ,dc.idAfiliado
                       ,dc.idNegocio
                       ,dc.idPaciente
                       ,dc.idPlan
                       ,dc.idRenglonFacturaProforma
                       ,CASE WHEN cr.ImporteReferencia > cr.ImporteCobrado
                             THEN cr.ImporteReferencia - cr.ImporteCobrado
                             ELSE cr.ImporteCobrado - cr.ImporteReferencia
                        END * dc.Importe / cr.ImporteReferencia
                       ,dc.Nombre
                       ,dc.idPorcentajeIVA
                       ,dc.PrecioUnitario
                FROM    @NdeC nc
                        JOIN dbo.ComprobantesRemesas cr ON nc.idReferencia = cr.idReferencia
                        JOIN dbo.DetallesComprobantes dc ON nc.idReferencia = dc.idComprobante
        IF ( ( SELECT TOP 1
                        NombreEmpresa
               FROM     dbo.Sistemas
             ) != 'Activa' ) 
            BEGIN                               
			-- Actualización de los Puntos de Venta
			;
                WITH    Notas ( Prefijo, idTipoDeComprobante, cantComprobantes )
                          AS ( SELECT   Prefijo
                                       ,idTipoDeComprobante
                                       ,COUNT(*)
                               FROM     @NdeC nc
                               GROUP BY Prefijo
                                       ,idTipoDeComprobante
                             )
                    UPDATE  dbo.PuntosDeVenta
                    SET     UltimoNumeroAsignado = UltimoNumeroAsignado
                            + CASE WHEN n.idTipoDeComprobante < 12
                                   THEN n.cantComprobantes
                                   ELSE 0
                              END
                           ,UltimoNumeroAsignacoNdeCA = UltimoNumeroAsignacoNdeCA
                            + CASE WHEN n.idTipoDeComprobante = 12
                                   THEN n.cantComprobantes
                                   ELSE 0
                              END
                           ,UltimoNumeroAsignacoNdeCB = UltimoNumeroAsignacoNdeCB
                            + CASE WHEN n.idTipoDeComprobante = 13
                                   THEN n.cantComprobantes
                                   ELSE 0
                              END
                           ,UltimoNumeroAsignacoNdeCM = UltimoNumeroAsignacoNdeCM
                            + CASE WHEN n.idTipoDeComprobante = 21
                                   THEN n.cantComprobantes
                                   ELSE 0
                              END
                           ,UltimoNumeroAsignacoNdeDA = UltimoNumeroAsignacoNdeDA
                            + CASE WHEN n.idTipoDeComprobante = 14
                                   THEN n.cantComprobantes
                                   ELSE 0
                              END
                           ,UltimoNumeroAsignacoNdeDB = UltimoNumeroAsignacoNdeDB
                            + CASE WHEN n.idTipoDeComprobante = 15
                                   THEN n.cantComprobantes
                                   ELSE 0
                              END
                           ,UltimoNumeroAsignacoNdeDM = UltimoNumeroAsignacoNdeDM
                            + CASE WHEN n.idTipoDeComprobante = 22
                                   THEN n.cantComprobantes
                                   ELSE 0
                              END
                    FROM    dbo.PuntosDeVenta pv
                            JOIN Notas n ON pv.Prefijo = n.Prefijo 
			-- Fin de la Actualización de los Puntos de Venta
            END
			-- Inserción de los Detalles de la N.deC.
        --INSERT  dbo.DetallesComprobantes
        --        ( 
        --         idComprobante
        --        ,Detalle
        --        ,Importe
				
        --        )
        --        SELECT  nc.idComprobante
        --               ,cr.Observaciones
        --               ,cr.ImporteReferencia - cr.ImporteCobrado
        --        FROM    @NdeC nc
        --                JOIN dbo.ComprobantesRemesas cr ON nc.idComprobante = cr.idReferencia
        --        WHERE   cr.idRemesa = @idRemesa
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

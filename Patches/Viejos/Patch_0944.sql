USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[HacerComprobanteFacturaManual]    Script Date: 12/13/2018 10:44:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[HacerComprobanteFacturaManual]
    @idComprobante INT
   ,@ponerCobrador BIT
AS 
    SET NOCOUNT ON;
    DECLARE @cantidadDeDetalles INT
    DECLARE @idCliente INT
    DECLARE @idFacturacion INT
    DECLARE @idTipoDeComprobante INT
    IF ( SELECT Nombre
         FROM   Comprobantes
         WHERE  idComprobante = @idComprobante
       ) IS NULL -- Factura a cliente registrado, NdeC o NdeD.
        IF ( SELECT idTipoDeComprobante
             FROM   dbo.Comprobantes
             WHERE  idComprobante = @idComprobante
           ) IS NOT NULL -- NdeC o NdeD
            SET @idTipoDeComprobante = ( SELECT idTipoDeComprobante
                                         FROM   dbo.Comprobantes
                                         WHERE  idComprobante = @idComprobante
                                       )
        ELSE -- Factura a cliente registrado
            IF ( SELECT pv.Verdadero
                 FROM   dbo.Direcciones dir
                        JOIN dbo.Zonas z ON dir.idZona = z.idZona
                        JOIN dbo.PuntosDeVenta pv ON z.idPuntoDeVenta = pv.idPuntoDeVenta
                 WHERE  Real = 1
                        AND dir.idCliente = ( SELECT    idCliente
                                              FROM      dbo.Comprobantes
                                              WHERE     idComprobante = @idComprobante
                                            )
               ) = 1 -- Factura a cliente registrado blanco
                SELECT  @idTipoDeComprobante = Factura
                FROM    dbo.CategoriasIVA CI
                        JOIN dbo.Clientes cli ON CI.idCategoriaIVA = cli.idCategoriaIva
                        JOIN dbo.Comprobantes comp ON cli.idCliente = comp.idCliente
                WHERE   comp.idComprobante = @idComprobante
            ELSE -- Factura a cliente registrado negro
                SELECT TOP ( 1 )
                        @idTipoDeComprobante = ComprobanteFactCuotaAfiliados
                FROM    dbo.Sistemas
    ELSE -- Factura a cliente no registrado.
        IF ( SELECT pv.Verdadero
             FROM   dbo.PuntosDeVenta pv
                    JOIN dbo.Comprobantes comp ON pv.Prefijo = comp.Prefijo
             WHERE  comp.idComprobante = @idComprobante
           ) = 1 -- Factura a cliente no registrado blanco
            SELECT  @idTipoDeComprobante = Factura
            FROM    dbo.CategoriasIVA CI
                    JOIN dbo.Comprobantes comp ON CI.idCategoriaIVA = comp.idCategoriaIVA
            WHERE   comp.idComprobante = @idComprobante
        ELSE -- Factura a cliente no registrado negro.
            SELECT TOP ( 1 )
                    @idTipoDeComprobante = ComprobanteFactCuotaAfiliados
            FROM    dbo.Sistemas
    DECLARE @iniciales VARCHAR(10)
    SELECT  @iniciales = Iniciales
    FROM    dbo.TiposDeComprobante
    WHERE   idTipoDeComprobante = @idTipoDeComprobante
    BEGIN TRANSACTION
    BEGIN TRY
		-- Actualización de los Puntos de Venta
        UPDATE  dbo.PuntosDeVenta
        SET     UltimoNumeroAsignado = UltimoNumeroAsignado
                + CASE WHEN @iniciales = 'C' THEN 1
                       ELSE 0
                  END
               ,UltimoNumeroAsignadoA = UltimoNumeroAsignadoA
                + CASE WHEN @iniciales = 'F A' THEN 1
                       ELSE 0
                  END
                + CASE WHEN (UltimoNumeroAsignacoNdeCA IS NULL AND @iniciales = 'NCA') OR (UltimoNumeroAsignacoNdeDA IS NULL AND @iniciales = 'NDA') THEN 1
                       ELSE 0
                  END 
               ,UltimoNumeroAsignadoB = UltimoNumeroAsignadoB
                + CASE WHEN @iniciales = 'F B' THEN 1
                       ELSE 0
                  END
                + CASE WHEN (UltimoNumeroAsignacoNdeCB IS NULL AND @iniciales = 'NCB') OR (UltimoNumeroAsignacoNdeDB IS NULL AND @iniciales = 'NDB') THEN 1
                       ELSE 0
                  END 
               ,UltimoNumeroAsignacoNdeCA = UltimoNumeroAsignacoNdeCA
                + CASE WHEN UltimoNumeroAsignacoNdeCA IS NOT NULL AND @iniciales = 'NCA' THEN 1
                       ELSE 0
                  END
               ,UltimoNumeroAsignacoNdeDA = UltimoNumeroAsignacoNdeDA
                + CASE WHEN UltimoNumeroAsignacoNdeDA IS NOT NULL AND @iniciales = 'NDA' THEN 1
                       ELSE 0
                  END
               ,UltimoNumeroAsignacoNdeCB = UltimoNumeroAsignacoNdeCB
                + CASE WHEN UltimoNumeroAsignacoNdeCB IS NOT NULL AND @iniciales = 'NCB' THEN 1
                       ELSE 0
                  END
               ,UltimoNumeroAsignacoNdeDB = UltimoNumeroAsignacoNdeDB
                + CASE WHEN UltimoNumeroAsignacoNdeDB IS NOT NULL AND @iniciales = 'NDB' THEN 1
                       ELSE 0
                  END
        FROM    dbo.PuntosDeVenta pv
        WHERE   pv.Prefijo = ( SELECT   Prefijo
                               FROM     dbo.Comprobantes
                               WHERE    idComprobante = @idComprobante
                             )
		-- Fin de la Actualización de los Puntos de Venta
		
        IF ( SELECT Nombre
             FROM   Comprobantes
             WHERE  idComprobante = @idComprobante
           ) IS NULL 
            UPDATE  dbo.Comprobantes
            SET     idTipoDeComprobante = @idTipoDeComprobante
                   ,NumeroDeComprobante = ( SELECT  RIGHT(REPLICATE('0', 8)
                                                          + CONVERT(VARCHAR(8), CASE 
                                                              WHEN @iniciales = 'C'
                                                              THEN UltimoNumeroAsignado
                                                              WHEN @iniciales = 'F A'
                                                              THEN UltimoNumeroAsignadoA
                                                              WHEN @iniciales = 'F B'
                                                              THEN UltimoNumeroAsignadoB
                                                              WHEN @iniciales = 'NCA' AND UltimoNumeroAsignacoNdeCA IS NOT NULL
                                                              THEN UltimoNumeroAsignacoNdeCA
                                                              WHEN @iniciales = 'NCA' AND UltimoNumeroAsignacoNdeCA IS NULL
                                                              THEN UltimoNumeroAsignadoA
                                                              WHEN @iniciales = 'NDA' AND UltimoNumeroAsignacoNdeDA IS NOT NULL
                                                              THEN UltimoNumeroAsignacoNdeDA
                                                              WHEN @iniciales = 'NDA' AND UltimoNumeroAsignacoNdeDA IS NULL
                                                              THEN UltimoNumeroAsignadoA
                                                              WHEN @iniciales = 'NCB' AND UltimoNumeroAsignacoNdeCB IS NOT NULL
                                                              THEN UltimoNumeroAsignacoNdeCB
                                                              WHEN @iniciales = 'NCB' AND UltimoNumeroAsignacoNdeCB IS NULL
                                                              THEN UltimoNumeroAsignadoB
                                                              WHEN @iniciales = 'NDB' AND UltimoNumeroAsignacoNdeDB IS NOT NULL
                                                              THEN UltimoNumeroAsignacoNdeDB
                                                              WHEN @iniciales = 'NDB' AND UltimoNumeroAsignacoNdeDB IS NULL
                                                              THEN UltimoNumeroAsignadoB
                                                              END), 8)
                                            FROM    dbo.PuntosDeVenta
                                            WHERE   idPuntoDeVenta = ( SELECT
                                                              idPuntoDeVenta
                                                              FROM
                                                              dbo.PuntosDeVenta
                                                              WHERE
                                                              Prefijo = ( SELECT
                                                              Prefijo
                                                              FROM
                                                              dbo.Comprobantes
                                                              WHERE
                                                              idComprobante = @idComprobante
                                                              )
                                                              )
                                          )
                   ,Nombre = cli.RazonSocial
                   ,Direccion = CASE WHEN c.Nombre IS NULL THEN ''
                                     ELSE c.Nombre + ' '
                                END
                    + CASE WHEN ISNULL(dir.Numero, '') = '' THEN ''
                           ELSE dir.Numero
                      END + CASE WHEN ISNULL(dir.Piso, '') = '' THEN ''
                                 ELSE ' Piso ' + dir.Piso
                            END
                    + CASE WHEN ISNULL(dir.Departamento, '') = '' THEN ''
                           ELSE ' Depto. ' + dir.Departamento
                      END
                   ,Entre = CASE WHEN dir.idEntreCalle1 IS NULL
                                 THEN CASE WHEN dir.idEntreCalle2 IS NULL
                                           THEN ''
                                           ELSE 'esq. ' + e2.Nombre
                                      END
                                 ELSE CASE WHEN dir.idEntreCalle2 IS NULL
                                           THEN 'esq.' + e1.Nombre
                                           ELSE 'entre ' + e1.Nombre + ' y '
                                                + e2.nombre
                                      END
                            END
                   ,Barrio = b.nombre
                   ,Localidad = Localidades.Nombre
                   ,idZona = dir.idZona
                   ,ObservacionesDireccion = dir.Observaciones
                   ,idTipoDeCobranza = cli.idTipoDeCobranza
                   ,idEntidadDeCobranza = CASE cli.idTipoDeCobranza
                                            WHEN 1 THEN NULL
                                            WHEN 2
                                            THEN cli.idEntidadDeCobranza
                                          END
                   ,NumeroTarjeta = CASE cli.idTipoDeCobranza
                                      WHEN 1 THEN NULL
                                      WHEN 2 THEN cli.NumeroTarjeta
                                    END
                   ,idCobrador = CASE @ponerCobrador
                                   WHEN 0 THEN NULL
                                   ELSE CASE cli.idTipoDeCobranza
                                          WHEN 1 THEN z.idCobrador
                                          WHEN 2 THEN NULL
                                        END
                                 END
                   ,idCategoriaIVA = cli.idCategoriaIva
                   ,CUIT = cli.CUIT
                   ,Anulado = 0
            FROM    dbo.Comprobantes comp
                    LEFT JOIN dbo.Clientes cli ON cli.idCliente = comp.idCliente
                    LEFT JOIN dbo.Direcciones dir ON dir.idcliente = cli.idCliente
                                                     AND dir.Cobranza = 1
                    LEFT JOIN dbo.Zonas z ON dir.idZona = z.idZona
                    LEFT JOIN dbo.PuntosDeVenta pv ON z.idPuntoDeVenta = pv.idPuntoDeVenta
                    LEFT JOIN dbo.Calles AS c ON dir.idCalle = c.idCalle
                    LEFT JOIN dbo.Calles AS e1 ON dir.idEntreCalle1 = e1.idCalle
                    LEFT JOIN dbo.Calles AS e2 ON dir.idEntreCalle2 = e2.idCalle
                    LEFT JOIN dbo.Localidades ON c.idLocalidad = Localidades.idLocalidad
                    LEFT JOIN dbo.Barrios AS b ON dir.idBarrio = b.idBarrio
                                                  AND Localidades.idLocalidad = b.idLocalidad
                    CROSS JOIN dbo.Sistemas
            WHERE   comp.idComprobante = @idComprobante
        ELSE 
            UPDATE  dbo.Comprobantes
            SET     idTipoDeComprobante = @idTipoDeComprobante
                   ,NumeroDeComprobante = ( SELECT  RIGHT(REPLICATE('0', 8)
                                                          + CONVERT(VARCHAR(8), CASE 
                                                              WHEN @iniciales = 'C'
                                                              THEN UltimoNumeroAsignado
                                                              WHEN @iniciales = 'F A'
                                                              THEN UltimoNumeroAsignadoA
                                                              WHEN @iniciales = 'F B'
                                                              THEN UltimoNumeroAsignadoB
                                                              WHEN @iniciales = 'NCA' AND UltimoNumeroAsignacoNdeCA IS NOT NULL
                                                              THEN UltimoNumeroAsignacoNdeCA
                                                              WHEN @iniciales = 'NCA' AND UltimoNumeroAsignacoNdeCA IS NULL
                                                              THEN UltimoNumeroAsignadoA
                                                              WHEN @iniciales = 'NDA' AND UltimoNumeroAsignacoNdeDA IS NOT NULL
                                                              THEN UltimoNumeroAsignacoNdeDA
                                                              WHEN @iniciales = 'NDA' AND UltimoNumeroAsignacoNdeDA IS NULL
                                                              THEN UltimoNumeroAsignadoA
                                                              WHEN @iniciales = 'NCB' AND UltimoNumeroAsignacoNdeCB IS NOT NULL
                                                              THEN UltimoNumeroAsignacoNdeCB
                                                              WHEN @iniciales = 'NCB' AND UltimoNumeroAsignacoNdeCB IS NULL
                                                              THEN UltimoNumeroAsignadoB
                                                              WHEN @iniciales = 'NDB' AND UltimoNumeroAsignacoNdeDB IS NOT NULL
                                                              THEN UltimoNumeroAsignacoNdeDB
                                                              WHEN @iniciales = 'NDB' AND UltimoNumeroAsignacoNdeDB IS NULL
                                                              THEN UltimoNumeroAsignadoB
                                                              END), 8)
                                            FROM    dbo.PuntosDeVenta
                                            WHERE   idPuntoDeVenta = ( SELECT
                                                              idPuntoDeVenta
                                                              FROM
                                                              dbo.PuntosDeVenta
                                                              WHERE
                                                              Prefijo = ( SELECT
                                                              Prefijo
                                                              FROM
                                                              dbo.Comprobantes
                                                              WHERE
                                                              idComprobante = @idComprobante
                                                              )
                                                              )
                                          )
                   ,idCliente = ( SELECT    idCliente
                                  FROM      dbo.Clientes
                                  WHERE     RazonSocial = 'Varios'
                                )
                   ,idTipoDeCobranza = 1
            WHERE   idComprobante = @idComprobante
        UPDATE  dbo.Comprobantes
        SET     Importe = ( SELECT  SUM(Importe)
                            FROM    dbo.DetallesComprobantes
                            WHERE   idComprobante = @idComprobante
                          )
               ,CantidadDeDetalles = ( SELECT   COUNT(*)
                                       FROM     dbo.DetallesComprobantes
                                       WHERE    idComprobante = @idComprobante
                                     )
               ,Fecha = CASE WHEN GETDATE() < dbo.UltimaFechaComprobantes(Prefijo,
                                                              idTipoDeComprobante)
                             THEN dbo.UltimaFechaComprobantes(Prefijo,
                                                              idTipoDeComprobante)
                             ELSE GETDATE()
                        END
        WHERE   idComprobante = @idComprobante
        
        -- Registrar Facturación
        IF @ponerCobrador = 1 
            BEGIN
                INSERT  dbo.Facturaciones
                        ( 
                         AfiliadosOClientes
                        ,Periodo
                        ,idTipoDeCobranza
                        ,Fecha
                        ,idCobrador
                        ,idEntidadDeCobranza
                            
                        )
                        SELECT  'C'
                               ,NULL
                               ,1
                               ,GETDATE()
                               ,idCobrador
                               ,idEntidadDeCobranza
                        FROM    dbo.Comprobantes
                        WHERE   idComprobante = @idComprobante
                SET @idFacturacion = SCOPE_IDENTITY() 

                UPDATE  dbo.Comprobantes
                SET     idFacturacion = @idFacturacion
                FROM    dbo.Comprobantes
                WHERE   idComprobante = @idComprobante
            END
	-- Fin de Registrar Facturación
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        RETURN 0
    END CATCH
    RETURN 1



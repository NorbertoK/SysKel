USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[HacerComprobanteFacturaManual]    Script Date: 01/10/2014 22:07:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[HacerComprobanteFacturaManual]
    @idComprobante INT
   ,@ponerCobrador BIT
AS 
    BEGIN
        SET NOCOUNT ON ;
        DECLARE @cantidadDeDetalles INT
        DECLARE @idCliente INT
        DECLARE @idFacturacion INT
        DECLARE @idTipoDeComprobante INT
        IF ( SELECT TOP 1
                    EmiteFacturasAyB
             FROM   dbo.Parametros
           ) = 1 
            SELECT  @idTipoDeComprobante = Factura
            FROM    dbo.CategoriasIVA CI
            JOIN    dbo.Clientes cli ON CI.idCategoriaIVA = cli.idCategoriaIva
            JOIN    dbo.Comprobantes comp ON cli.idCliente = comp.idCliente
            WHERE   comp.idComprobante = @idComprobante
        ELSE 
            SELECT TOP ( 1 )
                    @idTipoDeComprobante = ComprobanteFactCuotaAfiliados
            FROM    dbo.Sistemas
        DECLARE @serie VARCHAR(1)
        SELECT  @serie = Serie
        FROM    dbo.TiposDeComprobante
        WHERE   idTipoDeComprobante = @idTipoDeComprobante
    
        UPDATE  dbo.PuntosDeVenta
        SET     UltimoNumeroAsignado = UltimoNumeroAsignado + CASE WHEN @serie = 'C' THEN 1
                                                                   ELSE 0
                                                              END
               ,UltimoNumeroAsignadoA = UltimoNumeroAsignadoA + CASE WHEN @serie = 'A' THEN 1
                                                                     ELSE 0
                                                                END
               ,UltimoNumeroAsignadoB = UltimoNumeroAsignadoB + CASE WHEN @serie = 'B' THEN 1
                                                                     ELSE 0
                                                                END
        FROM    dbo.PuntosDeVenta pv
        WHERE   pv.Prefijo = ( SELECT   Prefijo
                               FROM     dbo.Comprobantes
                               WHERE    idComprobante = @idComprobante
                             )
		-- Fin de la Actualización de los Puntos de Venta
        UPDATE  dbo.Comprobantes
        SET     idTipoDeComprobante = @idTipoDeComprobante
               ,NumeroDeComprobante = ( SELECT  RIGHT(REPLICATE('0', 8) + CONVERT(VARCHAR(8), CASE @serie
                                                                                                WHEN 'C' THEN UltimoNumeroAsignado
                                                                                                WHEN 'A' THEN UltimoNumeroAsignadoA
                                                                                                WHEN 'B' THEN UltimoNumeroAsignadoB
                                                                                              END), 8)
                                        FROM    dbo.PuntosDeVenta
                                        WHERE   idPuntoDeVenta = ( SELECT   idPuntoDeVenta
                                                                   FROM     dbo.PuntosDeVenta
                                                                   WHERE    Prefijo = ( SELECT  Prefijo
                                                                                        FROM    dbo.Comprobantes
                                                                                        WHERE   idComprobante = @idComprobante
                                                                                      )
                                                                 )
                                      )
               ,Nombre = cli.RazonSocial
               ,Direccion = CASE WHEN c.Nombre IS NULL THEN ''
                                 ELSE c.Nombre + ' '
                            END + CASE WHEN ISNULL(dir.Numero, '') = '' THEN ''
                                       ELSE dir.Numero
                                  END + CASE WHEN ISNULL(dir.Piso, '') = '' THEN ' Piso ' + dir.Piso
                                             ELSE ''
                                        END + CASE WHEN ISNULL(dir.Departamento, '') = '' THEN ' Depto. ' + dir.Departamento
                                                   ELSE ''
                                              END
               ,Entre = CASE WHEN dir.idEntreCalle1 IS NULL THEN 'esq. ' + e2.Nombre
                             ELSE CASE WHEN dir.idEntreCalle2 IS NULL THEN 'esq.' + e1.Nombre
                                       ELSE 'entre ' + e1.Nombre + ' y ' + e2.nombre
                                  END
                        END
               ,Barrio = b.nombre
               ,Localidad = Localidades.Nombre
               ,idZona = dir.idZona
               ,ObservacionesDireccion = dir.Observaciones
               ,idTipoDeCobranza = cli.idTipoDeCobranza
               ,idEntidadDeCobranza = CASE cli.idTipoDeCobranza
                                        WHEN 1 THEN NULL
                                        WHEN 2 THEN cli.idEntidadDeCobranza
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
        UPDATE  dbo.Comprobantes
        SET     Importe = ( SELECT  SUM(Importe)
                            FROM    dbo.DetallesComprobantes
                            WHERE   idComprobante = @idComprobante
                          )
               ,CantidadDeDetalles = ( SELECT   COUNT(*)
                                       FROM     dbo.DetallesComprobantes
                                       WHERE    idComprobante = @idComprobante
                                     )
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
        
    END


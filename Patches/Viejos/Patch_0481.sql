USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[FacturasDeClientes]    Script Date: 07/17/2015 13:34:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER FUNCTION [dbo].[FacturasDeClientes]
    (
     @periodo VARCHAR(7)
    ,@idPuntoDeVenta INT
    )
RETURNS @tabla TABLE
    (
     Coberura VARCHAR(7)
    ,RazonSocial VARCHAR(200)
    ,DireccionReal VARCHAR(MAX)
    ,CategoriaIVA VARCHAR(50)
    ,CUIT VARCHAR(15)
    ,IngresosBrutos VARCHAR(12)
    ,ObservacionesCliente VARCHAR(MAX)
    ,idFacturaProforma INT
    ,idRenglonFacturaProforma INT
    ,idTipoDeContrato INT
    ,PorcentajeIVA MONEY
    ,Observaciones VARCHAR(MAX)
    ,TipoDeComprobante VARCHAR(50)
    ,DiscriminaIVA BIT
    ,Cantidad INT
    ,PrecioUnitario MONEY
    ,Detalle VARCHAR(200)
    ,Porciento DECIMAL(10, 2)
    ,Importe MONEY
    )
AS 
    BEGIN
        DECLARE @afiliadosHasta DATETIME
        DECLARE @prestacionesDesde DATETIME
        DECLARE @prestacionesHasta DATETIME
        SET @afiliadosHasta = RIGHT(dbo.PeriodoSumarMeses(@periodo, -1), 4)
            + LEFT(dbo.PeriodoSumarMeses(@periodo, -1), 2) + '15'
        SET @prestacionesDesde = RIGHT(dbo.PeriodoSumarMeses(@periodo, -1), 4)
            + LEFT(dbo.PeriodoSumarMeses(@periodo, -1), 2) + '01'
        SET @prestacionesHasta = RIGHT(@periodo, 4) + LEFT(@periodo, 2) + '01'
        DECLARE @cantAfiliados TABLE
            (
             idPlan INT
            ,Titulares BIT
            ,cantidad INT
            )
        INSERT  @cantAfiliados
                ( 
                 idPlan
                ,Titulares
                ,cantidad 
                )
                SELECT  e.idPlan
                       ,af.Titular
                       ,COUNT(*)
                FROM    dbo.Afiliados af
                        OUTER APPLY dbo.EstadosDelAfiliado(af.idAfiliado,
                                                           @afiliadosHasta) e
                WHERE   e.Estado NOT IN ( 'Baja', 'Suspendido', 'Alta Futura' )
                GROUP BY e.idPlan
                       ,af.Titular
        DECLARE @cantPrestaciones TABLE
            (
             idContrato INT
            ,cantidad INT
            )
        INSERT  @cantPrestaciones
                ( idContrato
                ,cantidad
                )
                SELECT  pac.idContrato
                       ,COUNT(*)
                FROM    dbo.Prestaciones prest
                        JOIN dbo.Pacientes pac ON pac.idPrestacion = prest.idPrestacion
                WHERE   pac.idContrato IS NOT NULL
                        AND prest.Tomada >= @prestacionesDesde
                        AND prest.Tomada <= @prestacionesHasta
                GROUP BY pac.idContrato
        INSERT  @tabla
                ( 
                 Coberura
                ,RazonSocial
                ,DireccionReal
                ,CategoriaIVA
                ,CUIT
                ,IngresosBrutos
                ,ObservacionesCliente
                ,idFacturaProforma
                ,idRenglonFacturaProforma
                ,idTipoDeContrato
                ,PorcentajeIVA
                ,Observaciones
                ,TipoDeComprobante
                ,DiscriminaIVA
                ,Cantidad
                ,Porciento
                ,Detalle
                    
                )
                SELECT  @periodo AS Coberura
                       ,cli.RazonSocial
                       ,dbo.DireccionCompleta(DirR.idDireccion) AS DireccionReal
                       ,ci.Nombre AS CategoriaIVA
                       ,dbo.FormatoCUIT(cli.CUIT) AS CUIT
                       ,dbo.FormatoIngresosBrutos(cli.IngresosBrutos) IngresosBrutos
                       ,CASE WHEN DirR.idDireccion = DirC.idDireccion THEN ''
                             ELSE 'Cobrar en '
                                  + dbo.DireccionCompleta(DirC.idDireccion)
                        END AS ObservacionesCliente
                       ,fp.idFacturaProforma
                       ,r.idRenglonFacturaProforma
                       ,cto.idTipoDeContrato
                       ,fp.PorcentajeIVA
                       ,fp.Observaciones
                       ,tc.Nombre TipoDeComprobante
                       ,tc.DiscriminaIVA
                       ,CASE cto.idTipoDeContrato
                          WHEN 1 THEN 1
                          WHEN 2
                          THEN CASE WHEN r.Cantidad IS NULL
                                    THEN ( SELECT   ISNULL(ca.cantidad, 0)
                                           FROM     @cantAfiliados ca
                                           WHERE    ca.idPlan = r.idPlan
                                                    AND ca.Titulares = r.Titulares
                                         )
                                    ELSE r.Cantidad
                               END
                          WHEN 3 THEN ( SELECT  ISNULL(cp.cantidad, 0)
                                        FROM    @cantPrestaciones cp
                                        WHERE   cp.idContrato = r.idContrato
                                      )
                        END
                       ,CASE LEFT(@periodo, 2)
                          WHEN '01'
                          THEN CASE WHEN cto.Ene = 0 THEN 0
                                    ELSE CAST(cto.Ene AS MONEY) / 100
                               END
                          WHEN '02'
                          THEN CASE WHEN cto.Feb = 0 THEN 0
                                    ELSE CAST(cto.Feb AS MONEY) / 100
                               END
                          WHEN '03'
                          THEN CASE WHEN cto.Mar = 0 THEN 0
                                    ELSE CAST(cto.Mar AS MONEY) / 100
                               END
                          WHEN '04'
                          THEN CASE WHEN cto.Abr = 0 THEN 0
                                    ELSE CAST(cto.Abr AS MONEY) / 100
                               END
                          WHEN '05'
                          THEN CASE WHEN cto.May = 0 THEN 0
                                    ELSE CAST(cto.May AS MONEY) / 100
                               END
                          WHEN '06'
                          THEN CASE WHEN cto.Jun = 0 THEN 0
                                    ELSE CAST(cto.Jun AS MONEY) / 100
                               END
                          WHEN '07'
                          THEN CASE WHEN cto.Jul = 0 THEN 0
                                    ELSE CAST(cto.Jul AS MONEY) / 100
                               END
                          WHEN '08'
                          THEN CASE WHEN cto.Ago = 0 THEN 0
                                    ELSE CAST(cto.Ago AS MONEY) / 100
                               END
                          WHEN '09'
                          THEN CASE WHEN cto.Sep = 0 THEN 0
                                    ELSE CAST(cto.Sep AS MONEY) / 100
                               END
                          WHEN '10'
                          THEN CASE WHEN cto.Oct = 0 THEN 0
                                    ELSE CAST(cto.Oct AS MONEY) / 100
                               END
                          WHEN '11'
                          THEN CASE WHEN cto.Nov = 0 THEN 0
                                    ELSE CAST(cto.Nov AS MONEY) / 100
                               END
                          WHEN '12'
                          THEN CASE WHEN cto.Dic = 0 THEN 0
                                    ELSE CAST(cto.Dic AS MONEY) / 100
                               END
                        END
                       ,CASE cto.idTipoDeContrato
                          WHEN 1
                          THEN 'Cobertura de ' + cto.Nombre + ' mes '
                               + @periodo
                          WHEN 2
                          THEN CASE WHEN r.Cantidad IS NULL
                                    THEN 'Afiliados plan ' + pl.Nombre
                                         + CASE WHEN r.Titulares = 1
                                                THEN ' Titulares'
                                                ELSE ' Adherentes'
                                           END
                                    ELSE 'Afiliados'
                               END
                          WHEN 3 THEN cto.Nombre
                        END Detalle
                FROM    dbo.Clientes cli
                        JOIN dbo.FacturasProforma fp ON fp.idCliente = cli.idCliente
                        JOIN dbo.RenglonesFacturaProforma r ON r.idFacturaProforma = fp.idFacturaProforma
                                                              AND ( r.Cantidad IS NULL
                                                              OR r.Cantidad > 0
                                                              )
                        LEFT JOIN dbo.Planes pl ON pl.idPlan = r.idPlan
                        LEFT JOIN dbo.Contratos cto ON cto.idContrato = r.idContrato
                        LEFT JOIN dbo.Direcciones AS DirR ON cli.idCliente = DirR.idCliente
                                                             AND DirR.Real = 1
                        LEFT JOIN dbo.Direcciones AS DirC ON cli.idCliente = DirC.idCliente
                                                             AND DirC.Cobranza = 1
                        LEFT JOIN dbo.Zonas z ON DirC.idZona = z.idZona
                        INNER JOIN dbo.CategoriasIVA ci ON cli.idCategoriaIva = ci.idCategoriaIVA
                        LEFT JOIN dbo.TiposDeComprobante tc ON tc.idTipoDeComprobante = ci.Factura
                WHERE   z.idPuntoDeVenta = @idPuntoDeVenta
                        AND ( cto.idContrato IS NULL
                              OR dbo.ContratoSeFactura(cto.idContrato,
                                                       @periodo, 0) = 1
                            )
        UPDATE  @tabla
        SET     PrecioUnitario = CASE WHEN rfp.PrecioUnitario IS NULL
                                      THEN pl.Cuota
                                      ELSE rfp.PrecioUnitario
                                 END * t.Porciento
        FROM    @tabla t
                JOIN dbo.FacturasProforma fp ON fp.idFacturaProforma = t.idFacturaProforma
                JOIN dbo.RenglonesFacturaProforma rfp ON rfp.idRenglonFacturaProforma = t.idRenglonFacturaProforma
                LEFT JOIN dbo.Planes pl ON pl.idPlan = rfp.idPlan
                LEFT JOIN dbo.Contratos cto ON rfp.idContrato = cto.idContrato
        UPDATE  @tabla
        SET     Importe = ISNULL(ROUND(t.Cantidad * t.Porciento
                                       * CASE WHEN rfp.PrecioUnitario IS NULL
                                              THEN ISNULL(pl.Cuota, 0)
                                              ELSE rfp.PrecioUnitario
                                         END, 2), 0)
        FROM    @tabla t
                JOIN dbo.FacturasProforma fp ON fp.idFacturaProforma = t.idFacturaProforma
                JOIN dbo.RenglonesFacturaProforma rfp ON rfp.idRenglonFacturaProforma = t.idRenglonFacturaProforma
                LEFT JOIN dbo.Planes pl ON pl.idPlan = rfp.idPlan
                LEFT JOIN dbo.Contratos cto ON rfp.idContrato = cto.idContrato
        DELETE  @tabla
        WHERE   Importe = 0  
	
        RETURN 
    END


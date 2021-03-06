USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[Func_ReporteComprobantes]    Script Date: 05/20/2015 11:18:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Norberto Kelijman
-- Create date: 4/3/07
-- Description:	Crea una tabla para comprobantes de cuota mensual.
-- =============================================
ALTER FUNCTION [dbo].[Func_ReporteComprobantes]
    (
     @periodo VARCHAR(7) = ''
    ,@idTipoDeCobranza INT = 0
    ,@idEntidadDeCobranza INT = 0
    ,@idCobrador INT = 0
    ,@prefijo VARCHAR(4) = ''
    ,@idZona INT = 0
    ,@desde VARCHAR(8) = '00000000'
    ,@hasta VARCHAR(8) = '99999999'
    ,@desdefecha VARCHAR(17) = '19470121'
    ,@hastafecha VARCHAR(17) = '19470121'
    ,@todosOPendientes VARCHAR(1)
    ,@comprobantes VARCHAR(1)
    )
RETURNS TABLE
AS
RETURN
    ( SELECT    tdc.Nombre TipoDeCobranza
               ,comp.idComprobante
               ,comp.Prefijo
               ,comp.NumeroDeComprobante
               ,comp.Fecha
               ,comp.Periodo
               ,comp.NombApel Nombre
               ,comp.Direccion
               ,comp.Entre
               ,comp.Barrio
               ,comp.Localidad
               ,comp.ObservacionesDireccion
               ,comp.Importe
               ,dc.Nombre AS Afiliado
               ,CASE WHEN dc.idPlan IS NULL THEN dc.Detalle
                     ELSE pl.Nombre + CASE WHEN ISNULL(dc.PjeDescuento, 0) = 0 THEN ''
                                           ELSE ' (-Dto. ' + CAST(dc.PjeDescuento AS VARCHAR) + '%)'
                                      END
                END AS nPlan
               ,dc.Importe AS CuotaPlan
               ,emp.Iniciales AS Cobrador
               ,emp.ApelNomb AS NombreCobrador
               ,'*' + CAST(comp.idComprobante AS VARCHAR) + '*' AS CodigoBarra
               ,ec.Nombre AS EntidadesDeCobranza
               ,z.Iniciales AS InicialesZona
               ,z.Nombre AS NombreZona
               ,comp.ApelNomb AS ApelNomb
               ,( SELECT    af.NumeroDeDocumento AS NroDocumento
                  FROM      Afiliados af
                  WHERE     idAfiliado = dc.idAfiliado
                ) AS NroDocumento
               ,comp.Telefono AS Telefono
               ,comp.CantidadDeDetalles
               ,catIVA.Nombre CategoriaIVA
               ,comp.CUIT
      FROM      Comprobantes AS comp
      LEFT JOIN DetallesComprobantes AS dc ON comp.idComprobante = dc.idComprobante
      LEFT JOIN Planes AS pl ON dc.idPlan = pl.idPlan
      LEFT JOIN Empleados AS emp ON comp.idCobrador = emp.idEmpleado
      LEFT JOIN EntidadesDeCobranza AS ec ON ec.idEntidadDeCobranza = comp.idEntidadDeCobranza
      LEFT JOIN Zonas AS z ON comp.idZona = z.idZona
      LEFT JOIN TiposDeCobranza tdc ON tdc.idTipoDeCobranza = comp.idTipoDeCobranza
      LEFT JOIN dbo.CategoriasIVA catIVA ON comp.idCategoriaIVA = catIVA.idCategoriaIVA
      WHERE     comp.idCliente IS NULL
                AND ISNULL(comp.Periodo, '') = CASE WHEN @periodo = '' THEN ISNULL(comp.Periodo, '')
                                                    ELSE @periodo
                                               END
                AND comp.idTipoDeComprobante = CASE @comprobantes
                                                 WHEN 'C' THEN 4
                                                 WHEN 'A' THEN 7
                                                 WHEN 'B' THEN 8
                                               END
                AND ISNULL(comp.idTipoDeCobranza, 0) = CASE WHEN @idTipoDeCobranza = 0 THEN ISNULL(comp.idTipoDeCobranza, 0)
                                                            ELSE @idTipoDeCobranza
                                                       END
                AND ISNULL(comp.idEntidadDeCobranza, 0) = CASE WHEN @idEntidadDeCobranza = 0 THEN ISNULL(comp.idEntidadDeCobranza, 0)
                                                               ELSE @idEntidadDeCobranza
                                                          END
                AND ISNULL(comp.idCobrador, 0) = CASE WHEN @idCobrador = 0 THEN ISNULL(comp.idCobrador, 0)
                                                      ELSE @idCobrador
                                                 END
                AND ISNULL(comp.Prefijo, '') = CASE WHEN @prefijo = '' THEN ISNULL(comp.Prefijo, '')
                                                    ELSE @prefijo
                                               END
                AND ISNULL(comp.idZona, 0) = CASE WHEN @idZona = 0 THEN ISNULL(comp.idZona, 0)
                                                  ELSE @idZona
                                             END
                AND ISNULL(comp.Fecha, '19470121') >= CASE WHEN LEFT(@desdeFecha, 8) = '19470121' THEN ISNULL(comp.Fecha, '19470121')
                                                           ELSE LEFT(@desdeFecha, 8)
                                                      END
                AND ISNULL(comp.Fecha, '19470121') <= CASE WHEN LEFT(@hastaFecha, 8) = '19470121' THEN ISNULL(comp.Fecha, '19470121')
                                                           ELSE dbo.Medianoche(LEFT(@hastaFecha, 9))
                                                      END
                AND comp.NumeroDeComprobante BETWEEN @desde AND @hasta
                AND comp.Saldo > CASE WHEN @todosOPendientes = 'P' THEN 0
                                      ELSE -1
                                 END
    )


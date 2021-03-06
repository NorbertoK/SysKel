USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[Func_ReporteComprobantesDeFacturasPorProceso]    Script Date: 10/06/2015 21:53:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Norberto Kelijman
-- Create date: 4/3/07
-- Description:	Crea una tabla para comprobantes de cuota mensual.
-- =============================================
ALTER FUNCTION [dbo].[Func_ReporteComprobantesDeFacturasPorProceso] ( @proceso VARCHAR(255) )
RETURNS TABLE
AS
RETURN
    ( SELECT    comp.idComprobante
               ,comp.Prefijo
               ,comp.NumeroDeComprobante
               ,tc.Tipo
               ,comp.Fecha
               ,comp.Periodo
               ,comp.NombApel Nombre
               ,comp.Direccion
               ,comp.Entre
               ,comp.Barrio
               ,comp.Localidad
               ,comp.ObservacionesDireccion
               ,comp.Importe ImporteComprobante
               ,dc.Nombre AS Afiliado
               ,CASE WHEN dc.idPlan IS NULL THEN dc.Detalle
                     ELSE pl.Nombre
                          + CASE WHEN ISNULL(dc.PjeDescuento, 0) = 0 THEN ''
                                 ELSE ' (-Dto. '
                                      + CAST(dc.PjeDescuento AS VARCHAR)
                                      + '%)'
                            END
                END AS nPlan
               ,dc.Cantidad
               ,dc.Detalle
               ,dc.Importe
               ,emp.Iniciales AS Cobrador
               ,'*' + CAST(comp.idComprobante AS VARCHAR) + '*' AS CodigoBarra
               ,z.Iniciales AS InicialesZona
               ,comp.CantidadDeDetalles
               ,( SELECT    af.NumeroDeDocumento AS NroDocumento
                  FROM      Afiliados af
                  WHERE     idAfiliado = dc.idAfiliado
                ) AS NroDocumento
               ,catIVA.Nombre CategoriaIVA
               ,comp.CUIT
               ,comp.PjeIVA
      FROM      dbo.Comprobantes AS comp
                LEFT JOIN dbo.DetallesComprobantes AS dc ON comp.idComprobante = dc.idComprobante
                LEFT JOIN Planes AS pl ON dc.idPlan = pl.idPlan
                LEFT JOIN dbo.Empleados AS emp ON comp.idCobrador = emp.idEmpleado
                LEFT JOIN dbo.Zonas AS z ON comp.idZona = z.idZona
                LEFT JOIN dbo.TiposDeCobranza tdc ON tdc.idTipoDeCobranza = comp.idTipoDeCobranza
                LEFT JOIN dbo.Clientes cli ON cli.idcliente = comp.idcliente
                LEFT JOIN dbo.CategoriasIVA catIVA ON comp.idCategoriaIVA = catIVA.idCategoriaIVA
                LEFT JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
      WHERE     comp.idComprobante IN ( SELECT  Id
                                        FROM    dbo.Ids
                                        WHERE   Proceso = @Proceso )
    )


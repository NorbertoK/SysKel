USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[Func_ReporteComprobantesDeFacturasPorProceso]    Script Date: 09/24/2015 10:13:43 ******/
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
               ,comp.Nombre
               ,cli.NombreFantasia
               ,comp.Direccion
               ,comp.Entre
               ,comp.Barrio
               ,comp.Localidad
               ,comp.ObservacionesDireccion
               ,comp.Importe ImporteComprobante
               ,dc.Cantidad
               ,dc.Detalle
               ,dc.Importe
               ,emp.Iniciales AS Cobrador
               ,emp.ApelNomb AS NombreCobrador
               ,'*' + CAST(comp.idComprobante AS VARCHAR) + '*' AS CodigoBarra
               ,ec.Nombre AS EntidadesDeCobranza
               ,z.Iniciales AS InicialesZona
               ,z.Nombre AS NombreZona
               ,comp.CantidadDeDetalles
               ,catIVA.Nombre CategoriaIVA
               ,comp.CUIT
               ,comp.PjeIVA
      FROM      dbo.Comprobantes AS comp
                LEFT JOIN dbo.DetallesComprobantes AS dc ON comp.idComprobante = dc.idComprobante
                LEFT JOIN dbo.Empleados AS emp ON comp.idCobrador = emp.idEmpleado
                LEFT JOIN dbo.EntidadesDeCobranza AS ec ON ec.idEntidadDeCobranza = comp.idEntidadDeCobranza
                LEFT JOIN dbo.Zonas AS z ON comp.idZona = z.idZona
                LEFT JOIN dbo.TiposDeCobranza tdc ON tdc.idTipoDeCobranza = comp.idTipoDeCobranza
                LEFT JOIN dbo.Clientes cli ON cli.idcliente = comp.idcliente
                LEFT JOIN dbo.CategoriasIVA catIVA ON comp.idCategoriaIVA = catIVA.idCategoriaIVA
                LEFT JOIN dbo.TiposDeComprobante tc ON comp.idTipoDeComprobante = tc.idTipoDeComprobante
      WHERE     comp.idComprobante IN ( SELECT  Id
                                        FROM    dbo.Ids
                                        WHERE   Proceso = @Proceso )
    )


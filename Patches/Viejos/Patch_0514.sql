
/****** Object:  UserDefinedFunction [dbo].[Func_ReporteComprobanteDeFactura]    Script Date: 09/20/2015 21:25:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Norberto Kelijman
-- Create date: 4/3/07
-- Description:	Crea una tabla para comprobantes de cuota mensual.
-- =============================================
ALTER FUNCTION [dbo].[Func_ReporteComprobanteDeFactura] ( @idComprobante INT )
RETURNS TABLE
AS
RETURN
    ( SELECT    comp.idComprobante
               ,comp.Prefijo
               ,comp.NumeroDeComprobante
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
               ,emp.Nombre AS NombreCobrador
               ,'*' + CAST(comp.idComprobante AS VARCHAR) + '*' AS CodigoBarra
               ,ec.Nombre AS EntidadesDeCobranza
               ,z.Iniciales AS InicialesZona
               ,z.Nombre AS NombreZona
               ,comp.CantidadDeDetalles
               ,catIVA.Nombre CategoriaIVA
               ,dbo.FormatoCUIT(comp.CUIT) AS CUIT
      FROM      Comprobantes AS comp
                LEFT JOIN dbo.DetallesComprobantes AS dc ON comp.idComprobante = dc.idComprobante
                LEFT JOIN dbo.Empleados AS emp ON comp.idCobrador = emp.idEmpleado
                LEFT JOIN dbo.EntidadesDeCobranza AS ec ON ec.idEntidadDeCobranza = comp.idEntidadDeCobranza
                LEFT JOIN dbo.Zonas AS z ON comp.idZona = z.idZona
                LEFT JOIN dbo.Clientes cli ON cli.idCliente = comp.idCliente
                LEFT JOIN dbo.CategoriasIVA catIVA ON comp.idCategoriaIVA = catIVA.idCategoriaIVA 
      WHERE     comp.idComprobante = @idComprobante
    )

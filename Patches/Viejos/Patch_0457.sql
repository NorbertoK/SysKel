USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[Func_ReporteComprobantesDeFacturas]    Script Date: 05/05/2015 11:38:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Norberto Kelijman
-- Create date: 4/3/07
-- Description:	Crea una tabla para comprobantes de cuota mensual.
-- =============================================
ALTER FUNCTION [dbo].[Func_ReporteComprobantesDeFacturas] 
(	
	@periodo varchar(7),
    @idTandaDeFacturacion int,
    @idCobrador int,
    @idZona int,
    @desde varchar(8),
    @hasta varchar(8),
    @todosOPendientes varchar(1)
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT		comp.idComprobante,
			    comp.Prefijo,
			    comp.NumeroDeComprobante,
			    comp.Fecha,
			    comp.Periodo,
			    comp.Nombre,
                cli.NombreFantasia,
			    comp.Direccion,
			    comp.Entre, 
                comp.Barrio,
			    comp.Localidad,
			    comp.ObservacionesDireccion,
			    comp.Importe ImporteComprobante,
			    dc.Cantidad,
			    dc.Detalle,
			    dc.Importe, 
			    emp.Iniciales AS Cobrador,
                emp.ApelNomb AS NombreCobrador,
			    '*' + CAST(comp.idComprobante AS varchar) + '*' AS CodigoBarra,
			    ec.Nombre AS EntidadesDeCobranza,
			    z.Iniciales AS InicialesZona,
                z.Nombre AS NombreZona,
                comp.CantidadDeDetalles,
                catIVA.Nombre CategoriaIVA,
                comp.CUIT
    FROM        dbo.Comprobantes AS comp
    LEFT JOIN   dbo.DetallesComprobantes AS dc ON comp.idComprobante = dc.idComprobante
    LEFT JOIN   dbo.Empleados AS emp ON comp.idCobrador = emp.idEmpleado
    LEFT JOIN   dbo.EntidadesDeCobranza AS ec ON ec.idEntidadDeCobranza = comp.idEntidadDeCobranza
    LEFT JOIN   dbo.Zonas AS z ON comp.idZona = z.idZona
    LEFT JOIN   dbo.TiposDeCobranza tdc on tdc.idTipoDeCobranza = comp.idTipoDeCobranza
    LEFT JOIN   dbo.Clientes cli on cli.idcliente = comp.idcliente
    LEFT JOIN   dbo.CategoriasIVA catIVA ON comp.idCategoriaIVA = catIVA.idCategoriaIVA
    WHERE		comp.periodo = @periodo AND
                comp.idTandaDeFacturacion = @idTandaDeFacturacion AND
                ISNULL(comp.idCobrador,0) =	CASE
									            WHEN @idCobrador = 0 THEN ISNULL(comp.idCobrador,0)
									            ELSE @idCobrador
								            END AND
                ISNULL(comp.idZona,0) =	CASE
								            WHEN @idZona = 0 THEN ISNULL(comp.idZona,0)
								            ELSE @idZona
							            END AND
			    comp.NumeroDeComprobante BETWEEN @desde AND @hasta AND
                comp.Saldo > CASE
                                WHEN @todosOPendientes = 'P' THEN 0
                                ELSE -1
                            END
)


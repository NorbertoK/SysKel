USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[Func_ReporteComprobantesPorProceso]    Script Date: 05/05/2015 11:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Norberto Kelijman
-- Create date: 4/3/07
-- Description:	Crea una tabla para comprobantes de cuota mensual.
-- =============================================
ALTER FUNCTION [dbo].[Func_ReporteComprobantesPorProceso] ( @proceso varchar(255) )
RETURNS TABLE
AS
RETURN
    ( SELECT    tdc.Nombre TipoDeCobranza,
                comp.idComprobante,
                comp.Prefijo,
                comp.NumeroDeComprobante,
                comp.Fecha,
                comp.Periodo,
                comp.NombApel Nombre,
                comp.Direccion,
                comp.Entre,
                comp.Barrio,
                comp.Localidad,
                comp.ObservacionesDireccion,
                comp.Importe,
                dc.Nombre AS Afiliado,
                CASE WHEN dc.idPlan IS NULL THEN dc.Detalle
                     ELSE pl.Nombre
                          + CASE WHEN ISNULL(dc.PjeDescuento, 0) = 0 THEN ''
                                 ELSE ' (-Dto. '
                                      + CAST(dc.PjeDescuento AS VARCHAR)
                                      + '%)'
                            END
                END AS nPlan,
                dc.Importe AS CuotaPlan,
                emp.Iniciales AS Cobrador,
                emp.Nombre AS NombreCobrador,
                '*' + CAST(comp.idComprobante AS varchar) + '*' AS CodigoBarra,
                ec.Nombre AS EntidadesDeCobranza,
                z.Iniciales AS InicialesZona,
                z.Nombre AS NombreZona,
                comp.ApelNomb AS ApelNomb,
                ( SELECT    af.NumeroDeDocumento AS NroDocumento
                  FROM      Afiliados af
                  WHERE     idAfiliado = dc.idAfiliado
                ) AS NroDocumento,
                comp.Telefono AS Telefono,
                comp.CantidadDeDetalles,
                catIVA.Nombre CategoriaIVA,
                comp.CUIT
      FROM      Comprobantes AS comp
                LEFT JOIN DetallesComprobantes AS dc ON comp.idComprobante = dc.idComprobante
                LEFT JOIN Planes AS pl ON dc.idPlan = pl.idPlan
                LEFT JOIN Empleados AS emp ON comp.idCobrador = emp.idEmpleado
                LEFT JOIN EntidadesDeCobranza AS ec ON ec.idEntidadDeCobranza = comp.idEntidadDeCobranza
                LEFT JOIN Zonas AS z ON comp.idZona = z.idZona
                LEFT JOIN TiposDeCobranza tdc on tdc.idTipoDeCobranza = comp.idTipoDeCobranza
                LEFT JOIN dbo.CategoriasIVA catIVA ON comp.idCategoriaIVA = catIVA.idCategoriaIVA
      WHERE     comp.idComprobante in ( SELECT  Id
                                        FROM    dbo.Ids
                                        WHERE   Proceso = @Proceso )
    )


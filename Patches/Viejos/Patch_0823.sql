USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[CuentaCorrienteProveedor]    Script Date: 03/11/2017 11:32:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[CuentaCorrienteProveedor] ( @id INT )
RETURNS TABLE
AS
RETURN
    ( SELECT    comp.idCompra
               ,comp.Fecha
               ,tdec.Nombre AS TipoDeComprobante
               ,comp.Comprobante
               ,emp.Iniciales Pagador
               ,comp.Importe
               ,comp.Saldo
               ,tdec.ImporteNegativo
               ,CASE WHEN comp.idReferencia IS NULL THEN ''
                     ELSE ( SELECT  prefijo + '-' + NumeroDeComprobante
                            FROM    dbo.Comprobantes
                            WHERE   idComprobante = comp.idReferencia
                          )
                END Referencia
      FROM      dbo.Compras AS comp
      INNER JOIN TiposDeComprobante AS tdec ON comp.idTipoDeComprobante = tdec.idTipoDeComprobante
      LEFT JOIN dbo.ComprobantesOrdenesDePago cop ON comp.idCompra = cop.idCompra
      LEFT JOIN dbo.OrdenesDePago op ON cop.idOrdenDePago = op.idOrdenDePago
      LEFT JOIN dbo.empleados emp ON emp.idEmpleado = op.idEmpleado
      WHERE     comp.idProveedor = @id
    )


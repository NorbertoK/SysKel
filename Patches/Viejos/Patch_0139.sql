USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[CuentaCorriente]    Script Date: 08/04/2013 20:35:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[CuentaCorrienteProveedor] ( @id INT )
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
      LEFT JOIN dbo.Pagos pag ON comp.idPago = pag.idPago
      LEFT JOIN dbo.empleados emp ON emp.idEmpleado = pag.idCaja
      WHERE     comp.idProveedor = @id
    )


USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[CuentaCorriente]    Script Date: 01/28/2014 14:15:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[CuentaCorriente]
    (
      @GrupoOCliente varchar(1),
      @id int
    )
RETURNS TABLE
AS
RETURN
    ( SELECT    comp.idComprobante,
                comp.Fecha,
                tdec.Nombre AS TipoDeComprobante,
                comp.Prefijo + '-' + comp.NumeroDeComprobante Numero,
                comp.Periodo,
                CASE WHEN comp.idCobrador is not null
                     THEN ( SELECT  Iniciales
                            FROM    dbo.Empleados
                            WHERE   idEmpleado = comp.idCobrador
                          )
                     WHEN comp.idEntidadDeCobranza is not null
                     THEN ( SELECT  '*'+isnull(Iniciales,'')
                            FROM    dbo.EntidadesDeCobranza
                            WHERE   idEntidadDeCobranza = comp.idEntidadDeCobranza
                          )
                     ELSE null
                END Cobrador,
                comp.Importe,
                comp.Saldo,
                tdec.ImporteNegativo,
                CASE WHEN comp.idReferencia is null THEN ''
                     ELSE ( SELECT  prefijo + '-' + NumeroDeComprobante
                            FROM    dbo.Comprobantes
                            WHERE   idComprobante = comp.idReferencia
                          )
                END Referencia,
                comp.Anulado
      FROM      Comprobantes AS comp
                INNER JOIN TiposDeComprobante AS tdec ON comp.idTipoDeComprobante = tdec.idTipoDeComprobante
                LEFT JOIN dbo.Empleados emp on comp.idCobrador = emp.idEmpleado
      WHERE     CASE WHEN @GrupoOCliente = 'G' THEN comp.idgrupo
                     ELSE comp.idCliente
                END = @id
    )


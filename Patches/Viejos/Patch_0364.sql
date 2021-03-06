USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[CuentaCorriente]    Script Date: 06/16/2014 16:51:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[CuentaCorriente]
    (
     @GrupoOCliente VARCHAR(1)
    ,@id INT
    )
RETURNS TABLE
AS
RETURN
    ( SELECT    comp.idComprobante
               ,comp.Fecha
               ,tdec.Nombre AS TipoDeComprobante
               ,comp.Prefijo + '-' + comp.NumeroDeComprobante Numero
               ,comp.Periodo
               ,CASE WHEN comp.idCobrador IS NOT NULL THEN ( SELECT Iniciales
                                                             FROM   dbo.Empleados
                                                             WHERE  idEmpleado = comp.idCobrador
                                                           )
                     WHEN comp.idEntidadDeCobranza IS NOT NULL THEN ( SELECT    '*' + ISNULL(Iniciales, '')
                                                                      FROM      dbo.EntidadesDeCobranza
                                                                      WHERE     idEntidadDeCobranza = comp.idEntidadDeCobranza
                                                                    )
                     ELSE NULL
                END Cobrador
               ,comp.Importe
               ,comp.Saldo
               ,tdec.ImporteNegativo
               ,CASE WHEN comp.idReferencia IS NULL THEN ''
                     ELSE ( SELECT  prefijo + '-' + NumeroDeComprobante
                            FROM    dbo.Comprobantes
                            WHERE   idComprobante = comp.idReferencia
                          )
                END Referencia
               ,comp.Anulado
      FROM      Comprobantes AS comp
      INNER JOIN TiposDeComprobante AS tdec ON comp.idTipoDeComprobante = tdec.idTipoDeComprobante
      LEFT JOIN dbo.Empleados emp ON comp.idCobrador = emp.idEmpleado
      WHERE     CASE WHEN @GrupoOCliente = 'G' THEN comp.idgrupo
                     ELSE comp.idCliente
                END = @id
                AND 0 = CASE WHEN ( SELECT TOP 1
                                            OcultaFacturasAnuladas
                                    FROM    dbo.Parametros
                                  ) = 1 THEN comp.Anulado
                             ELSE 0
                        END
    )


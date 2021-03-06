USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[CuentaCorriente]    Script Date: 01/18/2017 12:11:32 ******/
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
               ,CASE WHEN ISNULL(comp.Prefijo + '-', '') = '' THEN ''
                     ELSE comp.Prefijo + '-'
                END + comp.NumeroDeComprobante Numero
               ,comp.Periodo
               ,CASE WHEN comp.idCobrador IS NOT NULL
                     THEN ( SELECT  Iniciales
                            FROM    dbo.Empleados
                            WHERE   idEmpleado = comp.idCobrador
                          )
                     WHEN comp.idEntidadDeCobranza IS NOT NULL
                     THEN ( SELECT  '*' + ISNULL(Iniciales, '')
                            FROM    dbo.EntidadesDeCobranza
                            WHERE   idEntidadDeCobranza = comp.idEntidadDeCobranza
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
               ,ISNULL(comp.Anulado, 0) Anulado
               ,CASE WHEN ( SELECT  ISNULL(RazonSocial, '')
                            FROM    dbo.Clientes
                            WHERE   idCliente = @id
                          ) = 'Varios' THEN comp.Nombre
                     ELSE ''
                END Nombre
      FROM      Comprobantes AS comp
                INNER JOIN TiposDeComprobante AS tdec ON comp.idTipoDeComprobante = tdec.idTipoDeComprobante
                LEFT JOIN dbo.Empleados emp ON comp.idCobrador = emp.idEmpleado
      WHERE     CASE WHEN @GrupoOCliente = 'G' THEN comp.idgrupo
                     ELSE comp.idCliente
                END = @id
                AND 0 = CASE WHEN ( SELECT TOP 1
                                            OcultaFacturasAnuladas
                                    FROM    dbo.Parametros
                                  ) = 1 THEN ISNULL(comp.Anulado, 0)
                             ELSE 0
                        END
    )


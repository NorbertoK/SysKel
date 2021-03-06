USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[Deudores]    Script Date: 11/01/2018 12:39:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Stored Procedure
ALTER PROCEDURE [dbo].[Deudores] @hasta VARCHAR(8)
AS 
	DECLARE @diaDespuesHasta DATE = DATEADD(d,1,@hasta)
    BEGIN
        UPDATE  dbo.Grupos
        SET     Activo = dbo.HayAlgunAfiliadoActivo(g.idGrupo, GETDATE())
        FROM    dbo.Grupos g
        SELECT  'Afiliados' AS TipoDeCliente
               ,comp.Periodo AS Cobertura
               ,comp.apelnomb
               ,comp.Direccion
               ,comp.Localidad
               ,comp.Telefono
               ,comp.idComprobante
               ,comp.Importe
               ,comp.Saldo
               ,CASE comp.idTipoDeCobranza
                  WHEN 1 THEN 'Propia'
                  WHEN 2 THEN 'Tercerizada'
                  WHEN 3 THEN 'Convenio'
                  ELSE 'No tiene'
                END AS Cobranza
               ,ec.Nombre AS EntidadDeCobranza
               ,emp.ApelNomb AS Cobrador
               ,CASE ( g.Activo )
                  WHEN 0 THEN 'No'
                  WHEN 1 THEN 'Si'
                  ELSE NULL
                END AS Activo
               ,( SELECT    emp.ApelNomb
                  FROM      dbo.Direcciones dir
                  JOIN      dbo.Zonas z ON dir.idZona = z.idZona
                  JOIN      dbo.Empleados emp ON emp.idEmpleado = z.idCobrador
                  WHERE     dir.idGrupo = comp.idGrupo
                            AND dir.Cobranza = 1
                ) AS CobradorActual
               ,'G' + CAST(comp.idGrupo AS VARCHAR) AS Id
        FROM    dbo.Comprobantes comp
        LEFT JOIN dbo.EntidadesDeCobranza ec ON comp.idEntidadDeCobranza = ec.idEntidadDeCobranza
        LEFT JOIN dbo.Empleados emp ON comp.idCobrador = emp.idEmpleado
        JOIN    dbo.Grupos g ON comp.idGrupo = g.idGrupo
        WHERE   comp.idTipoDeComprobante IN ( SELECT    idTipoDeComprobante
                                              FROM      dbo.TiposDeComprobante
                                              WHERE     EsFactura = 1 )
                AND comp.Saldo > 0
                AND Fecha < @diaDespuesHasta
                AND ISNULL(Anulado,0) = 0
                --AND dbo.RestaPeriodos(dbo.Periodo(DatePart(month, getdate()),
                --                                  DatePart(year, getdate())),
                --                      comp.Periodo) > 0
        UNION ALL
        SELECT  'Clientes' AS TipoDeCliente
               ,comp.Periodo AS Cobertura
               ,comp.apelnomb
               ,comp.Direccion
               ,comp.Localidad
               ,comp.Telefono
               ,comp.idComprobante
               ,comp.Importe
               ,comp.Saldo
               ,CASE comp.idTipoDeCobranza
                  WHEN 1 THEN 'Propia'
                  WHEN 2 THEN 'Tercerizada'
                  WHEN 3 THEN 'Convenio'
                  ELSE 'No tiene'
                END AS Cobranza
               ,ec.Nombre AS EntidadDeCobranza
               ,emp.ApelNomb AS Cobrador
               ,CASE ( cli.Activo )
                  WHEN 0 THEN 'No'
                  WHEN 1 THEN 'Si'
                  ELSE NULL
                END AS Activo
               ,( SELECT    emp.ApelNomb
                  FROM      dbo.Direcciones dir
                  JOIN      dbo.Zonas z ON dir.idZona = z.idZona
                  JOIN      dbo.Empleados emp ON emp.idEmpleado = z.idCobrador
                  WHERE     dir.idCliente = comp.idCliente
                            AND dir.Cobranza = 1
                ) AS CobradorActual
               ,'C' + CAST(comp.idCliente AS VARCHAR) AS Id
        FROM    dbo.Comprobantes comp
        JOIN    dbo.Clientes cli ON comp.idCliente = cli.idCliente
        LEFT JOIN dbo.EntidadesDeCobranza ec ON comp.idEntidadDeCobranza = ec.idEntidadDeCobranza
        LEFT JOIN dbo.Empleados emp ON comp.idCobrador = emp.idEmpleado
        WHERE   comp.idTipoDeComprobante IN ( SELECT    idTipoDeComprobante
                                              FROM      dbo.TiposDeComprobante
                                              WHERE     EsFactura = 1 )
                AND comp.Saldo > 0
                AND Fecha < @diaDespuesHasta
                AND ISNULL(Anulado,0) = 0
                --AND dbo.RestaPeriodos(dbo.Periodo(DatePart(month, getdate()),
                --                                  DatePart(year, getdate())),
                --                      comp.Periodo) > 0
        UNION ALL
        SELECT  'Prestaciones' AS TipoDeCliente
               ,comp.Periodo AS Cobertura
               ,comp.apelnomb
               ,comp.Direccion
               ,comp.Localidad
               ,comp.Telefono
               ,comp.idComprobante
               ,comp.Importe
               ,comp.Saldo
               ,CASE comp.idTipoDeCobranza
                  WHEN 1 THEN 'Propia'
                  WHEN 2 THEN 'Tercerizada'
                  WHEN 3 THEN 'Convenio'
                  ELSE 'No tiene'
                END AS Cobranza
               ,ec.Nombre AS EntidadDeCobranza
               ,emp.ApelNomb AS Cobrador
               ,NULL AS Activo
               ,( SELECT    emp.ApelNomb
                  FROM      dbo.Direcciones dir
                  JOIN      dbo.Zonas z ON dir.idZona = z.idZona
                  JOIN      dbo.Empleados emp ON emp.idEmpleado = z.idCobrador
                  WHERE     dir.idCliente = comp.idCliente
                            AND dir.Cobranza = 1
                ) AS CobradorActual
               ,'P' + CAST(idPrestacion AS VARCHAR) AS Id
        FROM    dbo.Comprobantes comp
        LEFT JOIN dbo.EntidadesDeCobranza ec ON comp.idEntidadDeCobranza = ec.idEntidadDeCobranza
        LEFT JOIN dbo.Empleados emp ON comp.idCobrador = emp.idEmpleado
        WHERE   comp.idTipoDeComprobante = ( SELECT TOP 1
                                                    ComprobanteFactCuotaAfiliados
                                             FROM   dbo.Sistemas
                                           )
                AND comp.idPrestacion IS NOT NULL
                AND comp.Saldo > 0
                AND Fecha < @diaDespuesHasta
                AND ISNULL(Anulado,0) = 0
    END


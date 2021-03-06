USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[BuscarTelefono]    Script Date: 03/22/2014 22:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[BuscarTelefono] ( @telefono VARCHAR(50) )
RETURNS TABLE
AS RETURN
    (
	-- Contacto de un Cliente
      SELECT    NULL AS idAfiliado
               ,cto.idContrato AS idContrato
               ,NULL AS idLugar
               ,dir.idDireccion AS idDireccion
               ,dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta
               ,cli.RazonSocial + CASE WHEN LEN(ISNULL(cli.NombreFantasia, '')) = 0 THEN ''
                                       ELSE ' (' + cli.NombreFantasia + ')'
                                  END AS Nombre
               ,cto.Nombre AS nPlan
               ,est.Estado AS Estado
               ,'Llamó ' + ct.Nombre AS Observaciones
               ,NULL AS idPlan
               ,NULL AS idPaciente
      FROM      dbo.Telefonos tel
      INNER JOIN dbo.Contactos ct ON ct.idContacto = tel.idContacto
      INNER JOIN dbo.Clientes cli ON cli.idCliente = ct.idCliente
      OUTER APPLY dbo.EstadosDelCliente(cli.idCliente, GETDATE()) est
      INNER JOIN dbo.Contratos cto ON cto.idContrato = est.idcontrato
      INNER JOIN dbo.Direcciones dir ON dir.idCliente = cli.idCliente
      WHERE     tel.SoloNumeros = dbo.SoloNumeros(@telefono)
      UNION ALL
    -- Contacto de un Grupo (En caso de Emergencia...)
      SELECT    af.idAfiliado AS idAfiliado
               ,pla.idContrato AS idContrato
               ,NULL AS idLugar
               ,CASE WHEN dirAf.idDireccion IS NULL THEN dirGru.idDireccion
                     ELSE dirAf.idDireccion
                END AS idDireccion
               ,CASE WHEN dirAf.idDireccion IS NULL THEN dbo.DireccionCompleta(dirGru.idDireccion)
                     ELSE dbo.DireccionCompleta(dirAf.idDireccion)
                END AS DireccionCompleta
               ,af.Nombre + ' ' + af.Apellido AS Nombre
               ,pla.Iniciales AS nPlan
               ,est.Estado AS Estado
               ,'Llama ' + ct.Nombre + CASE WHEN ct.Observaciones IS NULL THEN ''
                                            ELSE ' (' + ct.Observaciones + ')'
                                       END AS Observaciones
               ,pla.idPlan AS idPlan
               ,NULL AS idPaciente
      FROM      dbo.Telefonos tel
      INNER JOIN dbo.Contactos ct ON ct.idContacto = tel.idContacto
      INNER JOIN dbo.Afiliados af ON af.idGrupo = ct.idGrupo
      LEFT JOIN dbo.Direcciones dirAf ON dirAf.idAfiliado = af.idAfiliado
      LEFT JOIN dbo.Direcciones dirGru ON dirGru.idGrupo = ct.idGrupo
      OUTER APPLY dbo.EstadosDelAfiliado(af.idAfiliado, GETDATE()) est
      INNER JOIN dbo.Planes pla ON pla.idPlan = est.idplan
      WHERE     tel.SoloNumeros = dbo.SoloNumeros(@telefono)
      UNION ALL
    -- Contacto de un Lugar 
      SELECT    NULL AS idAfiliado
               ,NULL AS idContrato
               ,lug.idlugar AS idLugar
               ,dir.idDireccion AS idDireccion
               ,dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta
               ,lug.Nombre AS Nombre
               ,'' AS nPlan
               ,'Sin Cobertura' AS Estado
               ,'Llama ' + ct.Nombre + CASE WHEN ct.Observaciones IS NULL THEN ''
                                            ELSE ' (' + ct.Observaciones + ')'
                                       END AS Observaciones
               ,NULL AS idPlan
               ,NULL AS idPaciente
      FROM      dbo.Telefonos tel
      INNER JOIN dbo.Contactos ct ON ct.idContacto = tel.idContacto
      INNER JOIN dbo.Lugares lug ON lug.idLugar = ct.idLugar
      INNER JOIN dbo.Direcciones dir ON dir.idLugar = lug.idLugar
      WHERE     tel.SoloNumeros = dbo.SoloNumeros(@telefono)
    -- Falta programar el contacto de un Evento.
      UNION ALL
    -- Dirección de un Cliente
      SELECT    NULL AS idAfiliado
               ,cto.idContrato AS idContrato
               ,NULL AS idLugar
               ,dir.idDireccion AS idDireccion
               ,dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta
               ,cli.RazonSocial + CASE WHEN LEN(ISNULL(cli.NombreFantasia, '')) = 0 THEN ''
                                       ELSE ' (' + cli.NombreFantasia + ')'
                                  END AS Nombre
               ,cto.Nombre AS nPlan
               ,est.Estado AS Estado
               ,cto.Condiciones AS Observaciones
               ,NULL AS idPlan
               ,NULL AS idPaciente
      FROM      dbo.Telefonos tel
      LEFT JOIN dbo.Direcciones dir ON dir.idDireccion = tel.idDireccion
      INNER JOIN dbo.Clientes cli ON cli.idCliente = dir.idCliente
      OUTER APPLY dbo.EstadosDelCliente(cli.idCliente, GETDATE()) est
      INNER JOIN dbo.Contratos cto ON cto.idContrato = est.idcontrato
      WHERE     tel.SoloNumeros = dbo.SoloNumeros(@telefono)
      UNION ALL
   -- Dirección de un Contrato
      SELECT    NULL AS idAfiliado
               ,cto.idContrato AS idContrato
               ,NULL AS idLugar
               ,dir.idDireccion AS idDireccion
               ,dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta
               ,cli.RazonSocial + CASE WHEN LEN(ISNULL(cli.NombreFantasia, '')) = 0 THEN ''
                                       ELSE ' (' + cli.NombreFantasia + ')'
                                  END AS Nombre
               ,cto.Nombre AS nPlan
               ,est.Estado AS Estado
               ,cto.Condiciones AS Observaciones
               ,NULL AS idPlan
               ,NULL AS idPaciente
      FROM      dbo.Telefonos tel
      LEFT JOIN dbo.Direcciones dir ON dir.idDireccion = tel.idDireccion
      INNER JOIN dbo.Contratos cto ON cto.idContrato = dir.idContrato
      INNER JOIN dbo.Clientes cli ON cli.idCliente = cto.idCliente
      OUTER APPLY dbo.EstadosDelCliente(cli.idCliente, GETDATE()) est
      WHERE     tel.SoloNumeros = dbo.SoloNumeros(@telefono)
      UNION ALL
    -- Dirección de un Grupo
      SELECT    af.idAfiliado AS idAfiliado
               ,pla.idContrato AS idContrato
               ,NULL AS idLugar
               ,dir.idDireccion AS idDireccion
               ,dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta
               ,af.Nombre + ' ' + af.Apellido AS Nombre
               ,pla.Iniciales AS nPlan
               ,est.Estado AS Estado
               ,'Llaman desde esta dirección' AS Observaciones
               ,pla.idPlan AS idPlan
               ,NULL AS idPaciente
      FROM      dbo.Telefonos tel
      LEFT JOIN dbo.Direcciones dir ON dir.idDireccion = tel.idDireccion
      LEFT JOIN dbo.Grupos gru ON gru.idGrupo = dir.idGrupo
      LEFT JOIN dbo.Afiliados af ON af.idGrupo = gru.idGrupo
      OUTER APPLY dbo.EstadosDelAfiliado(af.idAfiliado, GETDATE()) est
      INNER JOIN dbo.Planes pla ON pla.idPlan = est.idplan
      WHERE     tel.SoloNumeros = dbo.SoloNumeros(@telefono)
      UNION ALL
    -- Dirección de un Afiliado (muestro todo el Grupo)
      SELECT    gru.idAfiliado AS idAfiliado
               ,pla.idContrato AS idContrato
               ,NULL AS idLugar
               ,dir.idDireccion AS idDireccion
               ,dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta
               ,gru.Nombre + ' ' + gru.Apellido AS Nombre
               ,pla.Iniciales AS nPlan
               ,est.Estado AS Estado
               ,'Llaman desde lo de ' + ISNULL(af.Nombre, '') + ' ' + ISNULL(af.Apellido, '') AS Observaciones
               ,pla.idPlan AS idPlan
               ,NULL AS idPaciente
      FROM      dbo.Telefonos tel
      LEFT JOIN dbo.Direcciones dir ON dir.idDireccion = tel.idDireccion
      LEFT JOIN dbo.Afiliados af ON af.idAfiliado = dir.idAfiliado
      LEFT JOIN dbo.Afiliados gru ON gru.idGrupo = af.idGrupo
      OUTER APPLY dbo.EstadosDelAfiliado(gru.idAfiliado, GETDATE()) est
      INNER JOIN dbo.Planes pla ON pla.idPlan = est.idplan
      WHERE     tel.SoloNumeros = dbo.SoloNumeros(@telefono)
      UNION ALL   
    -- Direccion de un Lugar 
      SELECT    NULL AS idAfiliado
               ,NULL AS idContrato
               ,lug.idlugar AS idLugar
               ,dir.idDireccion AS idDireccion
               ,dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta
               ,lug.Nombre AS Nombre
               ,'' AS nPlan
               ,'Sin Cobertura' AS Estado
               ,'Llaman desde esta dirección' AS Observaciones
               ,NULL AS idPlan
               ,NULL AS idPaciente
      FROM      dbo.Telefonos tel
      INNER JOIN dbo.Direcciones dir ON dir.idDireccion = tel.idDireccion
      INNER JOIN dbo.Lugares lug ON lug.idLugar = dir.idLugar
      WHERE     tel.SoloNumeros = dbo.SoloNumeros(@telefono)
      UNION ALL
    -- Teléfono de un Afiliado (muestro todo el grupo)
      SELECT    af.idAfiliado AS idAfiliado
               ,pla.idContrato AS idContrato
               ,NULL AS idLugar
               ,CASE WHEN dirAf.idDireccion IS NULL THEN dirGru.idDireccion
                     ELSE dirAf.idDireccion
                END AS idDireccion
               ,CASE WHEN dirAf.idDireccion IS NULL THEN dbo.DireccionCompleta(dirGru.idDireccion)
                     ELSE dbo.DireccionCompleta(dirAf.idDireccion)
                END AS DireccionCompleta
               ,af.Nombre + ' ' + af.Apellido AS Nombre
               ,pla.Iniciales AS nPlan
               ,est.Estado AS Estado
               ,'Llama ' + ISNULL(ct.Nombre, '') + ' ' + ISNULL(ct.Apellido, '') + ' (Un afiliado del grupo)' AS Observaciones
               ,pla.idPlan AS idPlan
               ,NULL AS idPaciente
      FROM      dbo.Telefonos tel
      INNER JOIN dbo.Afiliados ct ON ct.idAfiliado = tel.idAfiliado
      INNER JOIN dbo.Afiliados af ON af.idGrupo = ct.idGrupo
      LEFT JOIN dbo.Direcciones dirAf ON dirAf.idAfiliado = af.idAfiliado
      LEFT JOIN dbo.Direcciones dirGru ON dirGru.idGrupo = ct.idGrupo
      OUTER APPLY dbo.EstadosDelAfiliado(af.idAfiliado, GETDATE()) est
      INNER JOIN dbo.Planes pla ON pla.idPlan = est.idplan
      WHERE     tel.SoloNumeros = dbo.SoloNumeros(@telefono)
      UNION ALL
    -- Teléfono de una Prestación
      SELECT TOP 1
                pac.idAfiliado AS idAfiliado
               ,pac.idContrato AS idContrato
               ,NULL AS idLugar
               ,dir.idDireccion AS idDireccion
               ,dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta
               ,pac.Nombre AS Nombre
               ,pla.Iniciales AS nPlan
               ,est.Estado AS Estado
               ,'Prestación ' + RIGHT('0' + CAST(DATEPART(dd, prest.Tomada) AS VARCHAR(10)), 2) + '/' + RIGHT('0'
                                                                                                              + CAST(DATEPART(mm, prest.Tomada) AS VARCHAR(10)),
                                                                                                              2) + '/'
                + CAST(DATEPART(yy, prest.Tomada) AS VARCHAR(4)) + ' ' + RIGHT('0' + CAST(DATEPART(HH, prest.Tomada) AS VARCHAR(10)), 2) + ':' + RIGHT('0'
                                                                                                                                                + CAST(DATEPART(mi,
                                                                                                                                                prest.Tomada) AS VARCHAR(10)),
                                                                                                                                                2) + ' '
                + pac.MotivosDeLlamado AS Observaciones
               ,pla.idPlan AS idPlan
               ,pac.idPaciente AS idPaciente
      FROM      dbo.Prestaciones prest
      JOIN      dbo.Pacientes pac ON prest.idPrestacion = pac.idPrestacion
      JOIN      dbo.Destinos dest ON prest.idPrestacion = dest.idPrestacion
      JOIN      dbo.Direcciones dir ON dest.idDestino = dir.idDestino
      OUTER APPLY dbo.EstadosDelAfiliado(pac.idAfiliado, GETDATE()) est
      LEFT JOIN dbo.Planes pla ON pla.idPlan = est.idplan
      WHERE     prest.TelefonoSoloNumeros = dbo.SoloNumeros(@telefono)
                AND NOT EXISTS ( SELECT *
                                 FROM   dbo.Telefonos
                                 WHERE  SoloNumeros = dbo.SoloNumeros(@telefono) )
      ORDER BY  idPaciente DESC
    )

USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[BuscarTelefono]    Script Date: 10/14/2013 21:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[BuscarTelefono] (@telefono varchar(50))
RETURNS TABLE
AS RETURN
(
	-- Contacto de un Cliente
	SELECT      null AS idAfiliado,
				cto.idContrato AS idContrato,
				null AS idLugar,
				dir.idDireccion AS idDireccion, 
				dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta,
				cli.RazonSocial + CASE WHEN len(isnull(cli.NombreFantasia,''))=0 THEN '' ELSE ' (' + cli.NombreFantasia + ')' END AS Nombre,
				cto.Nombre AS nPlan,
				est.Estado AS Estado,
				'Llamó ' + ct.Nombre AS Observaciones,
				NULL AS idPlan
    FROM        dbo.Telefonos tel
    INNER JOIN	dbo.Contactos ct on ct.idContacto = tel.idContacto
    INNER JOIN	dbo.Clientes cli on cli.idCliente = ct.idCliente
    OUTER APPLY dbo.EstadosDelCliente(cli.idCliente,GetDate()) est
    INNER JOIN	dbo.Contratos cto on cto.idContrato = est.idcontrato 
    INNER JOIN  dbo.Direcciones dir on dir.idCliente = cli.idCliente
    WHERE       tel.SoloNumeros = dbo.SoloNumeros(@telefono)
	UNION ALL
    -- Contacto de un Grupo (En caso de Emergencia...)
	SELECT		af.idAfiliado AS idAfiliado,
				pla.idContrato AS idContrato,
				null AS idLugar,
				CASE
					WHEN dirAf.idDireccion IS NULL THEN
						dirGru.idDireccion
					ELSE
						dirAf.idDireccion 
				END  AS idDireccion,
				CASE
					WHEN dirAf.idDireccion IS NULL THEN
						dbo.DireccionCompleta(dirGru.idDireccion) 
					ELSE
						dbo.DireccionCompleta(dirAf.idDireccion) 
				END AS DireccionCompleta,
				af.Nombre + ' ' + af.Apellido AS Nombre,
				pla.Iniciales AS nPlan,
				est.Estado AS Estado,
				'Llama ' + ct.Nombre +	CASE
								WHEN ct.Observaciones IS NULL THEN ''
								ELSE ' (' + ct.Observaciones + ')'
							END AS Observaciones,
				pla.idPlan AS idPlan			
    FROM		dbo.Telefonos tel
    INNER JOIN	dbo.Contactos ct on ct.idContacto = tel.idContacto
    INNER JOIN	dbo.Afiliados af on af.idGrupo = ct.idGrupo
    LEFT JOIN	dbo.Direcciones dirAf on dirAf.idAfiliado = af.idAfiliado
    LEFT JOIN	dbo.Direcciones dirGru on dirGru.idGrupo = ct.idGrupo
    OUTER APPLY	dbo.EstadosDelAfiliado(af.idAfiliado,GetDate()) est 
    INNER JOIN	dbo.Planes pla on pla.idPlan = est.idplan
    WHERE       tel.SoloNumeros = dbo.SoloNumeros(@telefono)
    UNION ALL
    -- Contacto de un Lugar 
    SELECT      null AS idAfiliado,
				null AS idContrato,
				lug.idlugar AS idLugar,
				dir.idDireccion AS idDireccion, 
				dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta,
				lug.Nombre AS Nombre,
				'' AS nPlan,
				'Sin Cobertura' AS Estado,
				'Llama ' + ct.Nombre +	CASE
								WHEN ct.Observaciones IS NULL THEN ''
								ELSE ' (' + ct.Observaciones + ')'
							END AS Observaciones,
				NULL AS idPlan			
    FROM        dbo.Telefonos tel
    INNER JOIN	dbo.Contactos ct on ct.idContacto = tel.idContacto
    INNER JOIN	dbo.Lugares lug on lug.idLugar = ct.idLugar 
    INNER JOIN  dbo.Direcciones dir on dir.idLugar = lug.idLugar
    WHERE       tel.SoloNumeros = dbo.SoloNumeros(@telefono)
    -- Falta programar el contacto de un Evento.
    UNION ALL
    -- Dirección de un Cliente
    SELECT      null AS idAfiliado,
				cto.idContrato AS idContrato,
				null AS idLugar,
				dir.idDireccion AS idDireccion, 
				dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta,
				cli.RazonSocial + CASE WHEN len(isnull(cli.NombreFantasia,''))=0 THEN '' ELSE ' (' + cli.NombreFantasia + ')' END AS Nombre,
				cto.Nombre AS nPlan,
				est.Estado AS Estado,
				cto.Condiciones AS Observaciones,
				NULL AS idPlan
    FROM        dbo.Telefonos tel
    LEFT JOIN   dbo.Direcciones dir on dir.idDireccion = tel.idDireccion
    INNER JOIN	dbo.Clientes cli on cli.idCliente = dir.idCliente
    OUTER APPLY dbo.EstadosDelCliente(cli.idCliente,GetDate()) est
    INNER JOIN	dbo.Contratos cto on cto.idContrato = est.idcontrato
    WHERE       tel.SoloNumeros = dbo.SoloNumeros(@telefono)
    UNION ALL
   -- Dirección de un Contrato
    SELECT      null AS idAfiliado,
				cto.idContrato AS idContrato,
				null AS idLugar,
				dir.idDireccion AS idDireccion, 
				dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta,
				cli.RazonSocial + CASE WHEN len(isnull(cli.NombreFantasia,''))=0 THEN '' ELSE ' (' + cli.NombreFantasia + ')' END AS Nombre,
				cto.Nombre AS nPlan,
				est.Estado AS Estado,
				cto.Condiciones AS Observaciones,
				NULL AS idPlan
    FROM        dbo.Telefonos tel
    LEFT JOIN   dbo.Direcciones dir on dir.idDireccion = tel.idDireccion
    INNER JOIN  dbo.Contratos cto on cto.idContrato = dir.idContrato
    INNER JOIN	dbo.Clientes cli on cli.idCliente = cto.idCliente
    OUTER APPLY dbo.EstadosDelCliente(cli.idCliente,GetDate()) est
    WHERE       tel.SoloNumeros = dbo.SoloNumeros(@telefono)
    UNION ALL
    -- Dirección de un Grupo
    SELECT		af.idAfiliado AS idAfiliado,
				pla.idContrato AS idContrato,
				null AS idLugar,
				dir.idDireccion AS idDireccion,
				dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta,
				af.Nombre + ' ' + af.Apellido AS Nombre,
				pla.Iniciales AS nPlan,
				est.Estado AS Estado,
				'Llaman desde esta dirección' AS Observaciones,
				pla.idPlan AS idPlan
    FROM		dbo.Telefonos tel
    LEFT JOIN   dbo.Direcciones dir on dir.idDireccion = tel.idDireccion
    LEFT JOIN	dbo.Grupos gru on gru.idGrupo = dir.idGrupo
    LEFT JOIN	dbo.Afiliados af on af.idGrupo = gru.idGrupo
    OUTER APPLY	dbo.EstadosDelAfiliado(af.idAfiliado,GetDate()) est 
    INNER JOIN	dbo.Planes pla on pla.idPlan = est.idplan
    WHERE       tel.SoloNumeros = dbo.SoloNumeros(@telefono)
    UNION ALL
    -- Dirección de un Afiliado (muestro todo el Grupo)
    SELECT		gru.idAfiliado AS idAfiliado,
				pla.idContrato AS idContrato,
				null AS idLugar,
				dir.idDireccion AS idDireccion,
				dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta,
				gru.Nombre + ' ' + gru.Apellido AS Nombre,
				pla.Iniciales AS nPlan,
				est.Estado AS Estado,
				'Llaman desde lo de ' + ISNULL(af.Nombre,'') + ' ' + ISNULL(af.Apellido,'') AS Observaciones,
				pla.idPlan AS idPlan
    FROM		dbo.Telefonos tel
    LEFT JOIN   dbo.Direcciones dir on dir.idDireccion = tel.idDireccion
    LEFT JOIN	dbo.Afiliados af on af.idAfiliado = dir.idAfiliado
    LEFT JOIN   dbo.Afiliados gru on gru.idGrupo = af.idGrupo
    OUTER APPLY	dbo.EstadosDelAfiliado(gru.idAfiliado,GetDate()) est 
    INNER JOIN	dbo.Planes pla on pla.idPlan = est.idplan
    WHERE       tel.SoloNumeros = dbo.SoloNumeros(@telefono)
    UNION ALL   
    -- Direccion de un Lugar 
    SELECT      null AS idAfiliado,
				null AS idContrato,
				lug.idlugar AS idLugar,
				dir.idDireccion AS idDireccion, 
				dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta,
				lug.Nombre AS Nombre,
				'' AS nPlan,
				'Sin Cobertura' AS Estado,
				'Llaman desde esta dirección' AS Observaciones,
				NULL AS idPlan
    FROM        dbo.Telefonos tel
    INNER JOIN  dbo.Direcciones dir on dir.idDireccion = tel.idDireccion
    INNER JOIN	dbo.Lugares lug on lug.idLugar = dir.idLugar 
    WHERE       tel.SoloNumeros = dbo.SoloNumeros(@telefono)
    UNION ALL
    -- Teléfono de un Afiliado (muestro todo el grupo)
	SELECT		af.idAfiliado AS idAfiliado,
				pla.idContrato AS idContrato,
				null AS idLugar,
				CASE
					WHEN dirAf.idDireccion IS NULL THEN
						dirGru.idDireccion
					ELSE
						dirAf.idDireccion 
				END  AS idDireccion,
				CASE
					WHEN dirAf.idDireccion IS NULL THEN
						dbo.DireccionCompleta(dirGru.idDireccion) 
					ELSE
						dbo.DireccionCompleta(dirAf.idDireccion) 
				END AS DireccionCompleta,
				af.Nombre + ' ' + af.Apellido AS Nombre,
				pla.Iniciales AS nPlan,
				est.Estado AS Estado,
				'Llama ' + ISNULL(ct.Nombre,'') + ' ' +	ISNULL(ct.Apellido,'') + ' (Un afiliado del grupo)' AS Observaciones,
				pla.idPlan AS idPlan
    FROM		dbo.Telefonos tel
    INNER JOIN	dbo.Afiliados ct on ct.idAfiliado = tel.idAfiliado
    INNER JOIN	dbo.Afiliados af on af.idGrupo = ct.idGrupo
    LEFT JOIN	dbo.Direcciones dirAf on dirAf.idAfiliado = af.idAfiliado
    LEFT JOIN	dbo.Direcciones dirGru on dirGru.idGrupo = ct.idGrupo
    OUTER APPLY	dbo.EstadosDelAfiliado(af.idAfiliado,GetDate()) est 
    INNER JOIN	dbo.Planes pla on pla.idPlan = est.idplan
    WHERE       tel.SoloNumeros = dbo.SoloNumeros(@telefono)
)

USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[BuscarDireccion]    Script Date: 10/14/2013 21:57:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[BuscarDireccion] 
(
@idCalle int,
@numero varchar(100)
)
RETURNS TABLE
AS RETURN
(
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
    FROM        dbo.Direcciones dir
    INNER JOIN	dbo.Clientes cli on cli.idCliente = dir.idCliente
    OUTER APPLY dbo.EstadosDelCliente(cli.idCliente,GetDate()) est
    INNER JOIN	dbo.Contratos cto on cto.idContrato = est.idcontrato
    WHERE       dir.Indice = dbo.IndiceDireccion(@idCalle,@numero)
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
    FROM        dbo.Direcciones dir
    INNER JOIN  dbo.Contratos cto on cto.idContrato = dir.idContrato
    INNER JOIN	dbo.Clientes cli on cli.idCliente = cto.idCliente
    OUTER APPLY dbo.EstadosDelCliente(cli.idCliente,GetDate()) est
    WHERE       dir.Indice = dbo.IndiceDireccion(@idCalle,@numero)
    UNION ALL
    -- Dirección de un Grupo
    SELECT		af.idAfiliado AS idAfiliado,
				null AS idContrato,
				null AS idLugar,
				dir.idDireccion AS idDireccion,
				dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta,
				af.NombApel AS Nombre,
				pla.Nombre AS nPlan,
				est.Estado AS Estado,
				'Llaman desde esta dirección' AS Observaciones,
				pla.idPlan AS idPlan
    FROM		dbo.Direcciones dir 
    LEFT JOIN	dbo.Grupos gru on gru.idGrupo = dir.idGrupo
    LEFT JOIN	dbo.Afiliados af on af.idGrupo = gru.idGrupo
    OUTER APPLY	dbo.EstadosDelAfiliado(af.idAfiliado,GetDate()) est 
    INNER JOIN	dbo.Planes pla on pla.idPlan = est.idplan
    WHERE       dir.Indice = dbo.IndiceDireccion(@idCalle,@numero)
    UNION ALL
    -- Dirección de un Afiliado (muestro todo el Grupo)
    SELECT		gru.idAfiliado AS idAfiliado,
				null AS idContrato,
				null AS idLugar,
				dir.idDireccion AS idDireccion,
				dbo.DireccionCompleta(dir.idDireccion) AS DireccionCompleta,
				gru.NombApel AS Nombre,
				pla.Nombre AS nPlan,
				est.Estado AS Estado,
				'Llaman desde lo de ' + ISNULL(af.Nombre,'') + ' ' + ISNULL(af.Apellido,'') AS Observaciones,
				pla.idPlan AS idPlan
    FROM		dbo.Direcciones dir
    LEFT JOIN	dbo.Afiliados af on af.idAfiliado = dir.idAfiliado
    LEFT JOIN   dbo.Afiliados gru on gru.idGrupo = af.idGrupo
    OUTER APPLY	dbo.EstadosDelAfiliado(gru.idAfiliado,GetDate()) est 
    INNER JOIN	dbo.Planes pla on pla.idPlan = est.idplan
    WHERE       dir.Indice = dbo.IndiceDireccion(@idCalle,@numero)
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
    FROM        dbo.Direcciones dir 
    INNER JOIN	dbo.Lugares lug on lug.idLugar = dir.idLugar 
    WHERE       dir.Indice = dbo.IndiceDireccion(@idCalle,@numero)
)

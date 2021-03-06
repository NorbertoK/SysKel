USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[FraseCambiarGrupo]    Script Date: 07/23/2013 00:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[FraseCambiarGrupo]
	(
	@idGrupo int = 0,
	@idAfiliado int = 0,
	@frase varchar(200) = 'OK' OUTPUT
	)
AS
SET NOCOUNT ON 
SET @frase = 'OK'

-- Ver si no es el único afiliado del grupo.
DECLARE @cuantos INT = (SELECT dbo.CantidadDeAfiliadosActivosDelGrupo(@idGrupo,NULL))
IF @cuantos=1 RETURN

-- Ver si no es titular.
IF (SELECT Titular FROM dbo.Afiliados WHERE idAfiliado=@idafiliado)=1
SET @frase = 'Hay que modificar antes su Grupo Actual para que deje de ser el titular.' 
RETURN





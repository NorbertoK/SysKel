USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[CambiarAfiliadoAGrupoNuevo]    Script Date: 07/22/2013 23:59:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[CambiarAfiliadoAGrupoNuevo]
    (
     @idAfiliado INT = 0
    ,@idGrupoActual INT = 0
	
    )
AS 
    SET NOCOUNT ON 
-- Ver si no es el único afiliado del grupo.
    DECLARE @cuantos INT = ( SELECT dbo.CantidadDeAfiliadosActivosDelGrupo(@idGrupoActual, NULL)
                           )
    IF @cuantos = 1 
        RETURN 0

    DECLARE @idNuevoGrupo INT
    DECLARE @Direcciones TABLE
        (
         renglon INT IDENTITY(1, 1)
        ,idDireccion INT
        )
    DECLARE @Telefonos TABLE
        (
         renglon INT IDENTITY(1, 1)
        ,idTelefono INT
        ,idDireccion INT
        ,Numero VARCHAR(50)
        )
    DECLARE @nDireccion INT
    DECLARE @cantDirecciones INT
    DECLARE @idDireccion INT
    DECLARE @idNuevaDireccion INT

-- Creo el nuevo grupo
    INSERT  dbo.Grupos
            ( idTipoDeCobranza
            ,idEntidadDeCobranza
            ,NumeroTarjeta
            ,VencimientoTarjeta
            )
            SELECT  idTipoDeCobranza
                   ,idEntidadDeCobranza
                   ,NumeroTarjeta
                   ,VencimientoTarjeta
            FROM    dbo.Grupos
            WHERE   idGrupo = @idGrupoActual
    SET @idNuevoGrupo = SCOPE_IDENTITY()

-- Le pongo el afiliado
    UPDATE  dbo.Afiliados
    SET     idGrupo = @idNuevoGrupo
           ,Titular = 1
    WHERE   idAfiliado = @idAfiliado

-- Direcciones y teléfonos del grupo.
    INSERT  @Direcciones
            SELECT  idDireccion
            FROM    dbo.Direcciones
            WHERE   idGrupo = @idGrupoActual
    SET @cantDirecciones = @@ROWCOUNT
    INSERT  @Telefonos
            SELECT  idTelefono
                   ,idDireccion
                   ,Numero
            FROM    dbo.Telefonos
            WHERE   idDireccion IN ( SELECT idDireccion
                                     FROM   @direcciones )
    SET @nDireccion = 1
    WHILE @nDireccion <= @cantDirecciones 
        BEGIN
            SELECT  @idDireccion = idDireccion
            FROM    @Direcciones
            WHERE   renglon = @nDireccion
            INSERT  dbo.Direcciones
                    ( Real
                    ,Cobranza
                    ,idCalle
                    ,Numero
                    ,Piso
                    ,Departamento
                    ,idEntreCalle1
                    ,idEntreCalle2
                    ,idZona
                    ,Observaciones
                    ,idGrupo
                    ,idBarrio
                    )
                    SELECT  Real
                           ,Cobranza
                           ,idCalle
                           ,Numero
                           ,Piso
                           ,Departamento
                           ,idEntreCalle1
                           ,idEntreCalle2
                           ,idZona
                           ,Observaciones
                           ,@idNuevoGrupo
                           ,idBarrio
                    FROM    dbo.Direcciones
                    WHERE   ( idDireccion = @idDireccion )
            SET @idNuevaDireccion = SCOPE_IDENTITY()
            INSERT  DBO.Telefonos
                    ( idDireccion
                    ,Numero
                    )
                    SELECT  @idNuevaDireccion
                           ,Numero
                    FROM    @Telefonos
                    WHERE   idDireccion = @idDireccion
            SET @nDireccion = @nDireccion + 1
        END 

-- Contactos (En caso de Emergencia...)
    INSERT  dbo.Contactos
            ( Nombre
            ,Observaciones
            ,idGrupo
            )
            SELECT  Nombre
                   ,Observaciones
                   ,@idNuevoGrupo
            FROM    dbo.Contactos
            WHERE   idGrupo = @idGrupoActual

    RETURN @idNuevoGrupo






USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[EstadoAfiliadosDelGrupo]    Script Date: 07/11/2012 12:49:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[EstadoAfiliadosDelGrupo] ( @idGrupo INT = 0 )
AS 
    SET NOCOUNT ON
    DECLARE @PlanesAfiliados TABLE
        (
          idAfiliado INT ,
          idPlan INT ,
          Estado VARCHAR(20)
        ) 
    DECLARE @idAfiliado INT
    DECLARE @registros INT
    DECLARE @cantAfiliadosActivos INT
    DECLARE @n INT
    DECLARE @AfiliadosDelGrupo TABLE
        (
          renglon INT IDENTITY(1, 1) ,
          idAfiliado INT
        )
    INSERT  @AfiliadosDelGrupo
            SELECT  idAfiliado
            FROM    dbo.Afiliados
            WHERE   idGrupo = @idGrupo
    SET @registros = @@ROWCOUNT
    SET @n = 1
    WHILE @n <= @registros 
        BEGIN
            SELECT  @idAfiliado = idAfiliado
            FROM    @AfiliadosDelGrupo
            WHERE   renglon = @n
            INSERT  @PlanesAfiliados
                    EXEC dbo.EstadoDelAfiliado @idAfiliado
            SET @n = @n + 1
        END
    SELECT  @cantAfiliadosActivos = COUNT(DISTINCT idAfiliado)
    FROM    @PlanesAfiliados
    WHERE   Estado IN ( 'Activo', 'Alta Reciente' )
    SELECT  af.idGrupo idGrupo ,
            ISNULL(af.Apellido, '') + ', ' + ISNULL(af.Nombre, '') Nombre ,
            tc.Iniciales TipoDoc ,
            af.NumeroDeDocumento NroDoc ,
            pl.Nombre nPlan ,
            pa.Estado Estado ,
            pa.idAfiliado idAfiliado ,
            CASE WHEN pa.Estado IN ( 'Activo', 'Alta Reciente' )
                 THEN ROUND(pl.Cuota * ( 1 - descu.Descuento / 100 ), 0)
                 ELSE 0
            END Cuota ,
            af.Titular
    FROM    @PlanesAfiliados pa
            JOIN dbo.Afiliados af ON ( af.idAfiliado = pa.idAfiliado )
            LEFT JOIN dbo.Planes pl ON ( pl.idPlan = pa.idPlan )
            LEFT JOIN dbo.TiposDeDocumento tc ON ( tc.idTipoDeDocumento = af.idTipoDeDocumento )
            JOIN dbo.DescuentosGrupoNumeroso descu ON pl.idPlan = descu.idPlan
    WHERE   descu.Afiliados = ( SELECT  MAX(Afiliados)
                                FROM    dbo.DescuentosGrupoNumeroso
                                WHERE   Afiliados <= @cantAfiliadosActivos
                              )








USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[EstadoAfiliadosDelGrupo]    Script Date: 07/25/2013 11:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[EstadoAfiliadosDelGrupo] ( @idGrupo INT = 0 )
AS 
    SET NOCOUNT ON
    DECLARE @PlanesAfiliados TABLE
        (
         idAfiliado INT
        ,idPlan INT
        ,Estado VARCHAR(20)
        ) 
    DECLARE @idAfiliado INT
    DECLARE @registros INT
    DECLARE @cantAfiliadosActivos INT
    DECLARE @n INT
    DECLARE @AfiliadosDelGrupo TABLE
        (
         renglon INT IDENTITY(1, 1)
        ,idAfiliado INT
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
    DECLARE @detalles TABLE
        (
         idGrupo INT
        ,Nombre VARCHAR(100)
        ,TipoDoc VARCHAR(10)
        ,NroDoc VARCHAR(20)
        ,idPlan INT
        ,nPlan VARCHAR(50)
        ,Estado VARCHAR(30)
        ,idAfiliado INT
        ,Cuota MONEY
        ,Titular BIT
        )
    INSERT  @detalles
            ( 
             idGrupo
            ,Nombre
            ,TipoDoc
            ,NroDoc
            ,idPlan
            ,nPlan
            ,Estado
            ,idAfiliado
            ,Cuota
            ,Titular
			
            )
            SELECT  af.idGrupo idGrupo
                   ,ISNULL(af.Apellido, '') + ', ' + ISNULL(af.Nombre, '') Nombre
                   ,tc.Iniciales TipoDoc
                   ,af.NumeroDeDocumento NroDoc
                   ,pl.idPlan
                   ,pl.Nombre nPlan
                   ,pa.Estado Estado
                   ,pa.idAfiliado idAfiliado
                   ,CASE WHEN pa.Estado NOT IN ( 'Alta Futura', 'Baja', 'Suspendido' )
                         THEN CASE WHEN ISNULL(g.Importe, 0) = 0 THEN ISNULL(CASE WHEN af.Titular = 1 THEN pl.Cuota
                                                                                  ELSE pl.CuotaAdherente
                                                                             END, 0)
                                   ELSE 0
                              END
                         ELSE 0
                    END Cuota
                   ,af.Titular
            FROM    @PlanesAfiliados pa
            JOIN    dbo.Afiliados af ON ( af.idAfiliado = pa.idAfiliado )
            JOIN    dbo.Grupos g ON af.idGrupo = g.idGrupo
            LEFT JOIN dbo.Planes pl ON ( pl.idPlan = pa.idPlan )
            JOIN    dbo.TiposDeDocumento tc ON ( tc.idTipoDeDocumento = af.idTipoDeDocumento )
	   -- Descuentos por Grupo Numeroso
    UPDATE  @detalles
    SET     cuota = ROUND(cuota * ( 1 - descu.Descuento / 100 ), 0)
    FROM    @detalles det
    JOIN    dbo.DescuentosGrupoNumeroso descu ON det.idPlan = descu.idPlan
    WHERE   descu.Afiliados = ( SELECT  MAX(Afiliados)
                                FROM    dbo.DescuentosGrupoNumeroso
                                WHERE   Afiliados <= @cantAfiliadosActivos
                              )
		-- Fin de Descuentos por Grupo Numeroso         
		-- Suma del importe del grupo al titular
    UPDATE  @detalles
    SET     cuota = cuota + CASE WHEN ( SELECT  Titular
                                        FROM    dbo.Afiliados
                                        WHERE   idAfiliado = det.idAfiliado
                                      ) = 1 THEN ( SELECT   ISNULL(Importe, 0)
                                                   FROM     dbo.Grupos
                                                   WHERE    idGrupo = ( SELECT  idGrupo
                                                                        FROM    dbo.Afiliados
                                                                        WHERE   idAfiliado = det.idAfiliado
                                                                      )
                                                 )
                                 ELSE 0
                            END
    FROM    @detalles det
		-- Fin de Suma del importe del grupo al titular                
    SELECT  idGrupo
           ,Nombre
           ,TipoDoc
           ,NroDoc
           ,nPlan
           ,Estado
           ,idAfiliado
           ,Cuota
           ,Titular
    FROM    @detalles
                              







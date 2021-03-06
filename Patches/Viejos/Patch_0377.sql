USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[Padron]    Script Date: 08/04/2014 14:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Padron]
    @fecha DATETIME
   ,@idZonaCob INT
AS 
    BEGIN
        SET NOCOUNT ON ;
        DECLARE @tabla TABLE
            (
             Nombre VARCHAR(100)
            ,Titular BIT
            ,nPlan VARCHAR(50)
            ,Cuota MONEY
            ,DirCobranza VARCHAR(MAX)
            ,ZonaCob VARCHAR(50)
            ,DirReal VARCHAR(MAX)
            ,NombreTitular VARCHAR(100)
            ,idAfiliado INT
            ,idGrupo INT
            ,afiliados INT
            ,idPlan INT
            )
        INSERT  @tabla
                ( 
                 Nombre
                ,Titular
                ,nPlan
                ,Cuota
                ,DirCobranza
                ,ZonaCob
                ,DirReal
                ,NombreTitular
                ,idAfiliado
                ,idGrupo
                ,idPlan
                )
                SELECT  af.ApelNomb Nombre
                       ,af.Titular Titular
                       ,pl.Nombre nPlan
                       ,CASE ISNULL(af.Titular, 0)
                          WHEN 1 THEN pl.Cuota
                          ELSE pl.CuotaAdherente
                        END Cuota
                       ,dbo.DireccionCompleta(dir.idDireccion) DirCobranza
                       ,z.Nombre ZonaCob
                       ,dbo.DireccionCompleta(dbo.DireccionRealDelAfiliado(af.idAfiliado)) DirReal
                       ,( SELECT    MAX(ApelNomb)
                          FROM      dbo.Afiliados
                          WHERE     idGrupo = af.idGrupo
                                    AND Titular = 1
                        ) NombreTitular
                       ,af.idAfiliado
                       ,af.idGrupo
                       ,pl.idPlan
                FROM    Afiliados af
                OUTER APPLY dbo.EstadosDelAfiliado(af.idAfiliado, @fecha) est
                LEFT JOIN dbo.Planes pl ON pl.idPlan = est.idPlan
                LEFT JOIN dbo.Direcciones dir ON dir.idGrupo = af.idGrupo
                                                 AND dir.Cobranza = 1
                LEFT JOIN dbo.Zonas z ON z.idZona = dir.idZona
                WHERE   est.Estado IN ( 'Activo', 'Alta Reciente' )
                        AND dir.idZona = CASE WHEN @idZonaCob = 0 THEN dir.idZona
                                              ELSE @idZonaCob
                                         END
                ORDER BY NombreTitular
                       ,Titular DESC
                       ,Nombre
	-- Descuentos por Grupo Numeroso
	;
        WITH    afiliadosPorGrupo ( idGrupo, Afiliados )
                  AS ( SELECT   idGrupo
                               ,COUNT(DISTINCT idAfiliado)
                       FROM     @tabla
                       GROUP BY idGrupo
                     )
            UPDATE  @tabla
            SET     afiliados = a.Afiliados
            FROM    @tabla t
            JOIN    afiliadosPorGrupo a ON t.idGrupo = a.idGrupo
        UPDATE  @tabla
        SET     cuota = ROUND(cuota * ( 1 - descu.Descuento / 100 ), 0)
        FROM    @tabla t
        JOIN    dbo.DescuentosGrupoNumeroso descu ON t.idPlan = descu.idPlan
        WHERE   descu.Afiliados = ( SELECT  MAX(Afiliados)
                                    FROM    dbo.DescuentosGrupoNumeroso
                                    WHERE   Afiliados <= t.afiliados
                                  )
	-- Fin de Descuentos por Grupo Numeroso
	
	-- Suma del importe del grupo al titular
        UPDATE  @tabla
        SET     cuota = cuota + CASE WHEN ( SELECT  Titular
                                            FROM    dbo.Afiliados
                                            WHERE   idAfiliado = t.idAfiliado
                                          ) = 1 THEN ( SELECT   ISNULL(Importe, 0)
                                                       FROM     dbo.Grupos
                                                       WHERE    idGrupo = t.idGrupo
                                                     )
                                     ELSE 0
                                END
        FROM    @tabla t
	-- Fin de Suma del importe del grupo al titular
        SELECT  Nombre
               ,Titular
               ,nPlan
               ,Cuota
               ,DirCobranza
               ,ZonaCob
               ,DirReal
               ,NombreTitular
        FROM    @tabla
    END

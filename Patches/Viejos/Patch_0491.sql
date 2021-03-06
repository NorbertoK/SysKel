USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ListadoPorPlan]    Script Date: 08/08/2015 21:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ListadoPorPlan]
    @idPlan INT
   ,@fecha VARCHAR(8)
AS 
    BEGIN
        SET NOCOUNT ON;
        DECLARE @cuotaTitular MONEY
        DECLARE @cuotaAdherente MONEY
        SELECT  @cuotaTitular = Cuota
               ,@cuotaAdherente = CuotaAdherente
        FROM    dbo.Planes
        WHERE   idPlan = @idPlan
        DECLARE @tabla TABLE
            (
             Nombre VARCHAR(100)
            ,Titular BIT
            ,idGrupo INT
            ,NumeroDeDocumento VARCHAR(12)
            ,NombreTitular VARCHAR(100)
            ,Cuota MONEY
            )
        INSERT  @tabla
                SELECT  af.ApelNomb Nombre
                       ,af.Titular
                       ,af.idGrupo
                       ,af.NumeroDeDocumento
                       ,( SELECT    TOP 1 ( ApelNomb )
                          FROM      dbo.Afiliados afi
                                    CROSS APPLY dbo.EstadosDelAfiliado(afi.idAfiliado,
                                                              @fecha) es
                          WHERE     idGrupo = af.idGrupo
                                    AND Titular = 1
                                    AND es.Estado NOT IN ( 'Baja',
                                                           'Suspendido', 'Alta Futura' )
                        ) NombreTitular
                       ,CASE WHEN af.Titular = 1 THEN @cuotaTitular
                             ELSE @cuotaAdherente
                        END
                FROM    dbo.Afiliados af
                        OUTER APPLY dbo.EstadosDelAfiliado(af.idAfiliado,
                                                           @fecha) est
                WHERE   est.Estado NOT IN ( 'Baja', 'Suspendido', 'Alta Futura' )
                        AND est.idPlan = @idPlan
                ORDER BY NombreTitular
                       ,Titular DESC
                       ,Nombre
        SELECT  *
        FROM    @tabla
    END

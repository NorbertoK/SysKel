USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[AfiliadosPorEntidadDeCobranza]    Script Date: 08/04/2014 19:29:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[AfiliadosPorEntidadDeCobranza]
    @idEntidadDeCobranza INT = 0
AS 
    BEGIN
        SET NOCOUNT ON ;
        SELECT DISTINCT
                g.idGrupo
               ,1 Cabecera
               ,dbo.FormatoNumeroTarjeta(g.NumeroTarjeta, ( SELECT  MascaraTarjeta
                                                            FROM    dbo.EntidadesDeCobranza
                                                            WHERE   idEntidadDeCobranza = @idEntidadDeCobranza
                                                          )) NumeroTarjeta
               ,af.ApelNomb
               ,af.NumeroDeDocumento
               ,g.NombreTitularTarjeta
               ,g.NumeroDocumentoTitularTarjeta
               ,g.TelefonoTitularTarjeta
               ,( SELECT    COUNT(*)
                  FROM      dbo.AfiliadosActivosDelGrupo(g.idGrupo)
                ) CantidadAfiliadosGrupo
               ,dbo.DireccionCompleta(( SELECT  dir.idDireccion
                                        FROM    dbo.Direcciones dir
                                        WHERE   dir.idGrupo = g.idGrupo
                                                AND dir.Real = 1
                                      )) Direccion
               ,NULL nPlan
               ,NULL Cuota
               ,( SELECT    SUM(CASE WHEN afi.Titular = 1 THEN pla.Cuota
                                     ELSE pla.CuotaAdherente
                                END)
                  FROM      dbo.AfiliadosActivosDelGrupo(g.idGrupo) aag
                  CROSS APPLY dbo.EstadosDelAfiliado(aag.idAfiliado, GETDATE()) ea
                  JOIN      dbo.Planes pla ON pla.idPlan = ea.idPlan
                  JOIN dbo.Afiliados afi ON aag.idAfiliado = afi.idAfiliado
                  WHERE     ea.Estado IN ( 'Activo', 'Alta Reciente' )
                ) CuotaGrupo
               ,NULL Saldo
               , -- NO VA MÁS EN EL REPORTE dbo.SaldoDelGrupo(af.idGrupo, getdate()) Saldo,
                ( SELECT    Apelnomb
                  FROM      dbo.Afiliados
                  WHERE     idGrupo = af.idGrupo
                            AND Titular = 1
                ) NombreTitular
        FROM    dbo.Grupos g
        CROSS APPLY dbo.AfiliadosActivosDelGrupo(g.idGrupo) AS act
        JOIN    dbo.Afiliados af ON af.idAfiliado = act.idAfiliado
        CROSS APPLY dbo.EstadosDelAfiliado(af.idAfiliado, GETDATE()) AS est
        WHERE   g.idTipoDeCobranza = 2
                AND g.idEntidadDeCobranza = @idEntidadDeCobranza
                AND est.Estado IN ( 'Activo', 'Alta Reciente' )
                AND af.Titular = 1
        UNION ALL
        SELECT  g.idGrupo
               ,0 Cabecera
               ,NULL NumeroTarjeta
               ,af.ApelNomb
               ,af.NumeroDeDocumento
               ,NULL
               ,NULL
               ,NULL
               ,NULL CantidadAfiliadosGrupo
               ,dbo.DireccionCompleta(dbo.DireccionRealDelAfiliado(af.idAfiliado)) Direccion
               ,pl.Nombre nPlan
               ,CASE ISNULL(af.titular, 0)
                  WHEN 1 THEN Cuota
                  ELSE CuotaAdherente
                END Cuota
               ,NULL CuotaGrupo
               ,NULL Saldo
               ,( SELECT    Apelnomb
                  FROM      dbo.AfiliadosActivosDelGrupo(g.idgrupo) aagr
                  JOIN      dbo.Afiliados afil ON afil.idAfiliado = aagr.idAfiliado
                  WHERE     afil.Titular = 1
                ) NombreTitular
        FROM    dbo.Grupos g
        CROSS APPLY dbo.AfiliadosActivosDelGrupo(g.idGrupo) AS act
        JOIN    dbo.Afiliados af ON af.idAfiliado = act.idAfiliado
        CROSS APPLY dbo.EstadosDelAfiliado(af.idAfiliado, GETDATE()) AS est
        JOIN    dbo.Planes pl ON pl.idPlan = est.idPlan
        WHERE   g.idTipoDeCobranza = 2
                AND g.idEntidadDeCobranza = @idEntidadDeCobranza
                AND est.Estado IN ( 'Activo', 'Alta Reciente' )
        ORDER BY NombreTitular
               ,g.idgrupo
               ,Cabecera DESC
               ,af.ApelNomb
    END

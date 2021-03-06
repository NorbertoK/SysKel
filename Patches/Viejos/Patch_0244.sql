USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[BajasAutomaticas]    Script Date: 12/20/2013 18:21:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery1.sql|7|0|C:\Documents and Settings\Norberto Kelijman\Local Settings\Temp\~vs9B7.sql
ALTER PROCEDURE [dbo].[BajasAutomaticas] 
	-- El parámetro @periodoActual es el último período cuya cobranza terminó.
    @periodoActual VARCHAR(7)
   ,@idGrabador INT
   ,@cantBajas INT OUTPUT
   ,@proceso VARCHAR(255)
AS 
    BEGIN
        SET NOCOUNT ON ;
        DECLARE @meses INT
        SELECT TOP 1
                @meses = MesesImpagosBaja
        FROM    dbo.Parametros 
        SET @cantBajas = 0
        DECLARE @gruposADarDeBaja TABLE ( idGrupo INT )
        DECLARE @ahora DATETIME
        SET @ahora = GETDATE()
        DECLARE @idMotivoDeBaja INT
        DECLARE @idTomadorDeBaja INT
        SELECT TOP 1
                @idMotivoDeBaja = MotivoDeBaja_Automatica
               ,@idTomadorDeBaja = Empleado_Sistema
        FROM    dbo.Sistemas ;
        WITH    comprobantesPagos ( idGrupo, Cantidad )
                  AS ( SELECT   comp.idGrupo
                               ,COUNT(*)
                       FROM     dbo.Comprobantes comp
                       JOIN     dbo.Grupos g ON comp.idGrupo = g.idGrupo
                       WHERE    g.Activo = 1
                                AND comp.idTipoDeCobranza = 1
                                AND comp.idTipoDeComprobante IN ( SELECT    idTipoDeComprobante
                                                                  FROM      dbo.TiposDeComprobante
                                                                  WHERE     EsFactura = 1 )
                                AND dbo.RestaPeriodos(@periodoActual, comp.Periodo) <= @meses
                                AND comp.Saldo = 0
                       GROUP BY comp.idGrupo
                     ),
                periodosFacturados ( idGrupo, Cantidad )
                  AS ( SELECT   idGrupo
                               ,COUNT(*)
                       FROM     ( SELECT DISTINCT
                                            comp.idGrupo
                                           ,comp.Periodo
                                  FROM      dbo.Comprobantes comp
                                  JOIN      dbo.Grupos g ON comp.idGrupo = g.idGrupo
                                  WHERE     g.Activo = 1
                                            AND comp.idTipoDeCobranza = 1
                                            AND comp.idTipoDeComprobante IN ( SELECT    idTipoDeComprobante
                                                                              FROM      dbo.TiposDeComprobante
                                                                              WHERE     EsFactura = 1 )
                                            AND dbo.RestaPeriodos(@periodoActual, comp.Periodo) <= @meses
                                ) periodos
                       GROUP BY idGrupo
                     )
            INSERT  @gruposADarDeBaja
                    SELECT  g.idGrupo
                    FROM    dbo.Grupos g
                    LEFT JOIN comprobantesPagos cp ON g.idGrupo = cp.idGrupo
                    LEFT JOIN periodosFacturados pf ON g.idGrupo = pf.idGrupo
                    WHERE   pf.Cantidad = @meses
                            AND cp.Cantidad IS NULL
                    
        DECLARE @planesADarDeBaja TABLE
            (
             idAfiliado INT
            ,idPlan INT
            )
        INSERT  @planesADarDeBaja
                ( 
                 idAfiliado
                ,idPlan 
                )
                SELECT  af.idAfiliado
                       ,est.idPlan
                FROM    @gruposADarDeBaja AS gb
                INNER JOIN dbo.Afiliados AS af ON af.idGrupo = gb.idGrupo
                CROSS APPLY dbo.EstadosDelAfiliado(af.idAfiliado, GETDATE()) est
                WHERE   est.Estado = 'Activo'
        DECLARE @SolicitudesIngresadas TABLE
            (
             idSolicitud INT
            ,idAfiliado INT
            )
        BEGIN TRANSACTION
        BEGIN TRY    
            INSERT  INTO [Datos].[dbo].[Solicitudes]
                    ( 
                     [AltaBajaSusp]
                    ,[idAfiliado]
                    ,[Fecha]
                    ,[FechaRegistro]
                    ,[idTomadorDeBaja]
                    ,[idMotivoDeBaja]
                    ,[idGrabador]
                
                    )
            OUTPUT  INSERTED.idSolicitud
                   ,INSERTED.idAfiliado
                    INTO @SolicitudesIngresadas
                    SELECT  'B'
                           ,idAfiliado
                           ,@ahora
                           ,@ahora
                           ,@idTomadorDeBaja
                           ,@idmotivoDeBaja
                           ,@idGrabador
                    FROM    @planesADarDeBaja
            SET @cantBajas = @@ROWCOUNT
            INSERT  INTO [Datos].[dbo].[AfiliadosPlanes]
                    ( 
                     [idSolicitud]
                    ,[idPlan]
                
                    )
                    SELECT  si.idSolicitud
                           ,pb.idPlan
                    FROM    @SolicitudesIngresadas si
                    JOIN    @planesADarDeBaja pb ON si.idAfiliado = pb.idAfiliado
            INSERT  INTO [Datos].[dbo].[ids]
                    ( 
                     [Proceso]
                    ,[id] 
                    )
                    SELECT  @proceso
                           ,idSolicitud
                    FROM    @SolicitudesIngresadas si
            UPDATE  dbo.Grupos
            SET     Activo = 0
            FROM    dbo.Grupos g
            JOIN    @gruposADarDeBaja gb ON g.idGrupo = gb.idGrupo

            COMMIT TRANSACTION
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION
            SET @cantBajas = 0
        END CATCH
    END

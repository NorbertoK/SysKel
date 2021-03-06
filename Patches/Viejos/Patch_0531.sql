USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[NdeDManual]    Script Date: 09/23/2015 22:23:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[NdeDManual]
    @ClienteOGrupo VARCHAR(1) = ' '
   ,@id INT = 0
   ,@prefijo VARCHAR(4)
   ,@importe MONEY = 0
   ,@detalle VARCHAR(MAX)
   ,@periodo VARCHAR(7) = ''
   ,@idReferencia INT
AS 
    BEGIN
        BEGIN TRY
            BEGIN TRANSACTION
            SET NOCOUNT ON;
            DECLARE @idComprobante INT
            DECLARE @idTipoDeComprobante INT
            DECLARE @serie VARCHAR(1)
            SELECT  @serie = Serie
            FROM    dbo.Comprobantes c
                    JOIN dbo.TiposDeComprobante t ON c.idTipoDeComprobante = t.idTipoDeComprobante
            WHERE   idComprobante = @idReferencia
            SELECT  @idTipoDeComprobante = idTipoDeComprobante
            FROM    dbo.TiposDeComprobante
            WHERE   Tipo = 'NdeD'
                    AND Serie = @serie
            DECLARE @NumeroDeComprobante VARCHAR(8)
            UPDATE  dbo.PuntosDeVenta
            SET     UltimoNumeroAsignado = UltimoNumeroAsignado
                    + CASE WHEN @serie = 'C' THEN 1
                           ELSE 0
                      END
                   ,UltimoNumeroAsignadoA = UltimoNumeroAsignadoA
                    + CASE WHEN @serie = 'A' THEN 1
                           ELSE 0
                      END
                   ,UltimoNumeroAsignadoB = UltimoNumeroAsignadoB
                    + CASE WHEN @serie = 'B' THEN 1
                           ELSE 0
                      END
            WHERE   idPuntoDeVenta = ( SELECT   pv.idPuntoDeVenta
                                       FROM     dbo.PuntosDeVenta pv
                                       WHERE    pv.Prefijo = @prefijo
                                     )
            SELECT  @NumeroDeComprobante = RIGHT(REPLICATE('0', 8)
                                                 + CONVERT(VARCHAR(8), CASE @serie
                                                              WHEN 'A'
                                                              THEN UltimoNumeroAsignadoA
                                                              WHEN 'B'
                                                              THEN UltimoNumeroAsignadoB
                                                              WHEN 'C'
                                                              THEN UltimoNumeroAsignado
                                                              END), 8)
            FROM    dbo.PuntosDeVenta
            WHERE   idPuntoDeVenta = ( SELECT   pv.idPuntoDeVenta
                                       FROM     dbo.PuntosDeVenta pv
                                       WHERE    pv.Prefijo = @prefijo
                                     )
        
            INSERT  INTO [Datos].[dbo].[Comprobantes]
                    ( 
                     [idTipoDeComprobante]
                    ,[Prefijo]
                    ,[NumeroDeComprobante]
                    ,[Fecha]
                    ,[Periodo]
                    ,[idCliente]
                    ,[idGrupo]
                    ,[idPrestacion]
                    ,[Importe]
                    ,[idReferencia]
                    ,[Nombre]
                    ,[CantidadDeDetalles]
                    ,idCategoriaIVA
                    ,CUIT
                    ,Barrio
                    ,Direccion
                    ,Entre
                    ,idZona
                    ,Localidad
                    ,ObservacionesDireccion
                    ,PjeIVA
                    )
            VALUES  ( 
                     @idTipoDeComprobante
                    ,@prefijo
                    ,@NumeroDeComprobante
                    ,CASE WHEN dbo.HoraCero(GETDATE()) < dbo.UltimaFechaComprobantes(@prefijo,
                                                              @idTipoDeComprobante)
                          THEN dbo.UltimaFechaComprobantes(@prefijo,
                                                           @idTipoDeComprobante)
                          ELSE dbo.HoraCero(GETDATE())
                     END
                    ,@periodo
                    ,CASE WHEN @ClienteOGrupo = 'C' THEN @id
                          ELSE NULL
                     END
                    ,CASE WHEN @ClienteOGrupo = 'G' THEN @id
                          ELSE NULL
                     END
                    ,CASE WHEN @ClienteOGrupo = 'P' THEN @id
                          ELSE NULL
                     END
                    ,@importe
                    ,@idReferencia
                    ,( SELECT   Nombre
                       FROM     dbo.Comprobantes
                       WHERE    idComprobante = @idReferencia
                     )
                    ,1
                    ,( SELECT   idCategoriaIVA
                       FROM     dbo.Comprobantes
                       WHERE    idComprobante = @idReferencia
                     )
                    ,( SELECT   CUIT
                       FROM     dbo.Comprobantes
                       WHERE    idComprobante = @idReferencia
                     )
                    ,( SELECT   Barrio
                       FROM     dbo.Comprobantes
                       WHERE    idComprobante = @idReferencia
                     )
                    ,( SELECT   Direccion
                       FROM     dbo.Comprobantes
                       WHERE    idComprobante = @idReferencia
                     )
                    ,( SELECT   Entre
                       FROM     dbo.Comprobantes
                       WHERE    idComprobante = @idReferencia
                     )
                    ,( SELECT   idZona
                       FROM     dbo.Comprobantes
                       WHERE    idComprobante = @idReferencia
                     )
                    ,( SELECT   Localidad
                       FROM     dbo.Comprobantes
                       WHERE    idComprobante = @idReferencia
                     )
                    ,( SELECT   ObservacionesDireccion
                       FROM     dbo.Comprobantes
                       WHERE    idComprobante = @idReferencia
                     )
                    ,( SELECT   PjeIVA
                       FROM     dbo.Comprobantes
                       WHERE    idComprobante = @idReferencia
                     )
                    )
            SET @idComprobante = SCOPE_IDENTITY();
            INSERT  INTO [Datos].[dbo].[DetallesComprobantes]
                    ( 
                     [idComprobante]
                    ,[Detalle]
                    ,[Importe]
                    )
            VALUES  ( 
                     @idComprobante
                    ,@detalle
                    ,@importe
                    )
            COMMIT TRANSACTION
        END TRY
        BEGIN CATCH
            ROLLBACK
            RETURN 0
        END CATCH
        RETURN 1
    END
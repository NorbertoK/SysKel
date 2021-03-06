USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ProcesarReintegro]    Script Date: 12/15/2016 14:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ProcesarReintegro]
    @idReintegro INT
   ,@resultado VARCHAR(2) OUTPUT
AS 
    SET NOCOUNT ON
    BEGIN
        BEGIN TRY
            BEGIN TRANSACTION
            SET NOCOUNT ON;
            DECLARE @a INT
            DECLARE @importe MONEY
            DECLARE @observaciones VARCHAR(MAX)
            DECLARE @tipoValoresEfectivo INT
            SET @tipoValoresEfectivo = ( SELECT TOP 1
                                                idTipoDeValor
                                         FROM   dbo.TiposDeValores tv
                                         WHERE  tv.EsEfectivo = 1
                                       )
            SELECT  @a = a
                   ,@importe = Importe
                   ,@observaciones = Observaciones
            FROM    dbo.Reintegros
            WHERE   idReintegro = @idReintegro
            IF @importe != 0 
                INSERT  INTO [Datos].[dbo].[ValoresRemesas]
                        ( [idTipoDeValor]
                        ,[Importe]
                        ,[Observaciones]
                        ,[IdReintegroEfectivo]
                        ,[idEmpleado]
                        )
                VALUES  ( 
                         @tipoValoresEfectivo
                        ,@importe
                        ,@observaciones
                        ,@idReintegro
                        ,@a
						)
            COMMIT TRANSACTION
        END TRY
        BEGIN CATCH
            ROLLBACK
            SET @resultado = 'No'
        END CATCH
        SET @resultado = 'OK'
    END


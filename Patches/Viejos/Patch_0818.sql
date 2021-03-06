USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ProcesarRetiro]    Script Date: 02/17/2017 13:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ProcesarRetiro]
    @idRetiro INT
   ,@resultado VARCHAR(2) OUTPUT
AS 
    SET NOCOUNT ON
    BEGIN
        BEGIN TRY
            BEGIN TRANSACTION
            SET NOCOUNT ON;
            DECLARE @n INT
            DECLARE @cuantos INT
            DECLARE @de INT
            SELECT  @de = De
            FROM    dbo.Retiros
            WHERE   idRetiro = @idRetiro
            DECLARE @tabla TABLE
                (
                 Renglon INT IDENTITY(1, 1)
                ,idValorRemesa INT
                ,idTipoDeValor INT
                ,Importe MONEY
                ,idBanco INT
                ,NumeroDeCheque VARCHAR(15)
                ,Vencimiento DATETIME
                ,Observaciones VARCHAR(MAX)
                ,Transferido BIT
                ,ImporteTransferido MONEY
                )
            INSERT  @tabla
                    ( 
                     idValorRemesa
                    ,idTipoDeValor
                    ,Importe
                    ,idBanco
                    ,NumeroDeCheque
                    ,Vencimiento
                    ,Observaciones
                    ,Transferido
                    ,ImporteTransferido
                            
                    )
                    SELECT  idValorRemesa
                           ,idTipoDeValor
                           ,Importe
                           ,idBanco
                           ,NumeroDeCheque
                           ,Vencimiento
                           ,Observaciones
                           ,Transferido
                           ,ImporteTransferido
                    FROM    dbo.ValoresRetiros
                    WHERE   idRetiro = @idRetiro
            SET @cuantos = @@ROWCOUNT
            SET @n = 1
            WHILE @n <= @cuantos 
                BEGIN
                    IF ( SELECT ImporteTransferido
                         FROM   @tabla
                         WHERE  Renglon = @n
                       ) != 0 
                        BEGIN
                            IF ( SELECT idValorRemesa
                                 FROM   @tabla
                                 WHERE  Renglon = @n
                               ) = 0 
                                BEGIN
                                    INSERT  INTO [Datos].[dbo].[ValoresRemesas]
                                            ( [idTipoDeValor]
                                            ,[Importe]
                                            ,[Observaciones]
                                            ,[EntregadoIdRetiro]
                                            ,[idEmpleado]
                                            )
                                            SELECT  ( SELECT TOP 1
                                                              idTipoDeValor
                                                      FROM    dbo.TiposDeValores tv
                                                      WHERE   tv.EsEfectivo = 1
                                                    )
                                                   ,ImporteTransferido * -1
                                                   ,Observaciones
                                                   ,@idRetiro
                                                   ,@de
                                            FROM    @tabla
                                            WHERE   Renglon = @n
                                END
                            ELSE 
                                BEGIN
                                    UPDATE  dbo.ValoresRemesas
                                    SET     EntregadoIdRetiro = @idRetiro
                                    WHERE   idValorRemesa = ( SELECT
                                                              idValorRemesa
                                                              FROM
                                                              @tabla
                                                              WHERE
                                                              Renglon = @n
                                                            )
                                END
                        END
                    SET @n = @n + 1
                END
            COMMIT TRANSACTION
        END TRY
        BEGIN CATCH
            ROLLBACK
            SET @resultado = 'No'
        END CATCH
        SET @resultado = 'OK'
    END


USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ProcesarTransferencia]    Script Date: 06/29/2013 20:22:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ProcesarTransferencia]
    @idTransferencia INT
   ,@resultado VARCHAR(2) OUTPUT
AS 
    SET NOCOUNT ON
    BEGIN
        BEGIN TRY
            BEGIN TRANSACTION
            DECLARE @n INT
            DECLARE @cuantos INT
            DECLARE @de INT
            DECLARE @a INT
            DECLARE @esBanco BIT
            SELECT  @de = De
                   ,@a = A
            FROM    dbo.Transferencias
            WHERE   idTransferencia = @idTransferencia
            IF EXISTS ( SELECT  *
                        FROM    dbo.Empleados emp
                        JOIN    dbo.Cargos c ON emp.idCargo = c.idCargo
                        WHERE   idEmpleado = @a
                                AND c.Nombre = 'Banco' ) 
                SET @esBanco = 1
            ELSE 
                SET @esBanco = 0 
            DECLARE @tabla TABLE
                (
                 Renglon INT IDENTITY(1, 1)
                ,idValorRemesa INT
                ,idTipoDeValor INT
                ,Importe MONEY
                ,idBanco INT
                ,NumeroDeCheque VARCHAR(15)
                ,Vencimiento DATETIME
                ,NumeroPropio INT
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
                    ,NumeroPropio
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
                           ,NumeroPropio
                           ,Observaciones
                           ,Transferido
                           ,ImporteTransferido
                    FROM    dbo.ValoresTransferencias
                    WHERE   idTransferencia = @idTransferencia
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
                                            ( 
                                             [idTipoDeValor]
                                            ,[Importe]
                                            ,[Observaciones]
                                            ,[RecibidoIdTransferencia]
                                            ,[idEmpleado]
                                            )
                                            SELECT  ( SELECT TOP 1
                                                                ValoresEfectivo
                                                      FROM      dbo.Sistemas
                                                    )
                                                   ,ImporteTransferido * -1
                                                   ,Observaciones
                                                   ,@idTransferencia
                                                   ,@de
                                            FROM    @tabla
                                            WHERE   Renglon = @n
                                    INSERT  INTO [Datos].[dbo].[ValoresRemesas]
                                            ( 
                                             [idTipoDeValor]
                                            ,[Importe]
                                            ,[Observaciones]
                                            ,[RecibidoIdTransferencia]
                                            ,[idEmpleado]
                                            )
                                            SELECT  ( SELECT TOP 1
                                                                ValoresEfectivo
                                                      FROM      dbo.Sistemas
                                                    )
                                                   ,ImporteTransferido
                                                   ,Observaciones
                                                   ,@idTransferencia
                                                   ,@a
                                            FROM    @tabla
                                            WHERE   Renglon = @n
                                END
                            ELSE 
                                BEGIN
                                    UPDATE  dbo.ValoresRemesas
                                    SET     EntregadoIdTransferencia = @idTransferencia
                                    WHERE   idValorRemesa = ( SELECT    idValorRemesa
                                                              FROM      @tabla
                                                              WHERE     Renglon = @n
                                                            )
                                    IF ( @esBanco = 1 ) 
                                        BEGIN
                                            INSERT  INTO [Datos].[dbo].[ValoresRemesas]
                                                    ( 
                                                     [idTipoDeValor]
                                                    ,[Importe]
                                                    ,[Observaciones]
                                                    ,[RecibidoIdTransferencia]
                                                    ,[idEmpleado]
                                                    )
                                                    SELECT  ( SELECT TOP 1
                                                                        ValoresEfectivo
                                                              FROM      dbo.Sistemas
                                                            )
                                                           ,ImporteTransferido
                                                           ,Observaciones
                                                           ,@idTransferencia
                                                           ,@a
                                                    FROM    @tabla
                                                    WHERE   Renglon = @n
                                        END                        
                                    ELSE 
                                        BEGIN
                                            INSERT  INTO [Datos].[dbo].[ValoresRemesas]
                                                    ( 
                                                     [idTipoDeValor]
                                                    ,[Importe]
                                                    ,[Observaciones]
                                                    ,[idBanco]
                                                    ,[NumeroDeCheque]
                                                    ,[Vencimiento]
                                                    ,[NumeroPropio]
                                                    ,[RecibidoIdTransferencia]
                                                    ,[idEmpleado]
                                                    )
                                                    SELECT  idTipoDeValor
                                                           ,ImporteTransferido
                                                           ,Observaciones
                                                           ,idBanco
                                                           ,NumeroDeCheque
                                                           ,Vencimiento
                                                           ,NumeroPropio
                                                           ,@idTransferencia
                                                           ,@a
                                                    FROM    @tabla
                                                    WHERE   Renglon = @n
                                        END
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


USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ProcesarTransferencia]    Script Date: 07/20/2017 14:52:20 ******/
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
            DECLARE @idTipoDeValorEfectivo INT
            DECLARE @de INT
            DECLARE @a INT
            DECLARE @esBanco BIT
            SELECT  @de = De
                   ,@a = A
            FROM    dbo.Transferencias
            WHERE   idTransferencia = @idTransferencia
            IF EXISTS ( SELECT  *
                        FROM    dbo.Empleados emp
                                JOIN dbo.CargosEmpleados ce ON emp.idEmpleado = ce.idEmpleado
                                JOIN dbo.Cargos c ON ce.idCargo = c.idCargo
                        WHERE   emp.idEmpleado = @a
                                AND c.Nombre = 'Banco' ) 
                SET @esBanco = 1
            ELSE 
                SET @esBanco = 0
                 
            SELECT TOP 1
                    @idTipoDeValorEfectivo = idTipoDeValor
            FROM    dbo.TiposDeValores tv
            WHERE   tv.EsEfectivo = 1
               
            INSERT  INTO [Datos].[dbo].[ValoresRemesas]
                    ( 
                     [idTipoDeValor]
                    ,[Importe]
                    ,[Observaciones]
                    ,[RecibidoIdTransferencia]
                    ,[idEmpleado]
                    )
                    SELECT  @idTipoDeValorEfectivo
                           ,ImporteTransferido * -1
                           ,Observaciones
                           ,@idTransferencia
                           ,@de
                    FROM    dbo.ValoresTransferencias
                    WHERE   idTransferencia = @idTransferencia
                            AND ImporteTransferido != 0
                            AND idValorRemesa != 0
            INSERT  INTO [Datos].[dbo].[ValoresRemesas]
                    ( 
                     [idTipoDeValor]
                    ,[Importe]
                    ,[Observaciones]
                    ,[RecibidoIdTransferencia]
                    ,[idEmpleado]
                    )
                    SELECT  @idTipoDeValorEfectivo
                           ,ImporteTransferido
                           ,Observaciones
                           ,@idTransferencia
                           ,@a
                    FROM    dbo.ValoresTransferencias
                    WHERE   idTransferencia = @idTransferencia
                            AND ImporteTransferido != 0
                            AND idValorRemesa != 0  
            UPDATE  dbo.ValoresRemesas
            SET     EntregadoIdTransferencia = @idTransferencia
            WHERE   idValorRemesa = ( SELECT    idValorRemesa
                                      FROM      dbo.ValoresTransferencias
                                      WHERE     idTransferencia = @idTransferencia
                                                AND ImporteTransferido != 0
                                                AND idValorRemesa = 0
                                    )                              
            INSERT  INTO [Datos].[dbo].[ValoresRemesas]
                    ( 
                     [idTipoDeValor]
                    ,[Importe]
                    ,[Observaciones]
                    ,[RecibidoIdTransferencia]
                    ,[idEmpleado]
                    )
                    SELECT  ( SELECT TOP 1
                                        idTipoDeValor
                              FROM      dbo.TiposDeValores
                              WHERE     EsEfectivo = 1
                            )
                           ,ImporteTransferido
                           ,Observaciones
                           ,@idTransferencia
                           ,@a
                    FROM    dbo.ValoresTransferencias
                    WHERE   idTransferencia = @idTransferencia
                            AND ImporteTransferido != 0
                            AND idValorRemesa = 0
                            AND @esBanco = 1
            INSERT  INTO [Datos].[dbo].[ValoresRemesas]
                    ( 
                     [idTipoDeValor]
                    ,[Importe]
                    ,[Observaciones]
                    ,[idBanco]
                    ,[NumeroDeCheque]
                    ,[Vencimiento]
                    ,[RecibidoIdTransferencia]
                    ,[idEmpleado]
                    )
                    SELECT  idTipoDeValor
                           ,ImporteTransferido
                           ,Observaciones
                           ,idBanco
                           ,NumeroDeCheque
                           ,Vencimiento
                           ,@idTransferencia
                           ,@a
                    FROM    dbo.ValoresTransferencias
                    WHERE   idTransferencia = @idTransferencia
                            AND ImporteTransferido != 0
                            AND idValorRemesa = 0
                            AND @esBanco = 0
            UPDATE  dbo.Transferencias
            SET     Importe = ( SELECT  SUM(ImporteTransferido)
                                FROM    dbo.ValoresTransferencias
                                WHERE   idTransferencia = @idTransferencia
                              )
            WHERE   idTransferencia = @idTransferencia
            COMMIT TRANSACTION
        END TRY
        BEGIN CATCH
            ROLLBACK
            SET @resultado = 'No'
        END CATCH
        SET @resultado = 'OK'
    END


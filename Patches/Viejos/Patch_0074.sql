USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[InsertarPagoEfectivoEnValores]    Script Date: 03/18/2013 22:32:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[InsertarPagoEfectivoEnValores] @idCompra int 
AS
BEGIN
	SET NOCOUNT ON;
    DECLARE @idTipoDeValor int
    DECLARE @importe money
    DECLARE @idEmpleado int
    SELECT @idEmpleado = [idPagador]
          ,@importe = [Importe]*-1
    FROM [Datos].[dbo].[Compras]
    WHERE idCompra = @idCompra
    SELECT TOP 1 @idTipoDeValor = ValoresEfectivo FROM dbo.Sistemas
    INSERT INTO [Datos].[dbo].[ValoresRemesas]
               ([idTipoDeValor]
               ,[Importe]
               ,[IdPagoEfectivo]
               ,[idEmpleado])
         VALUES
               (@idTipoDeValor
               ,@importe
               ,@idCompra
               ,@idEmpleado)
END

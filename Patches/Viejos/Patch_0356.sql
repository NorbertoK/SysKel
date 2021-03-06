USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[BuscarClientesYDireccion]    Script Date: 04/22/2014 19:58:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[BuscarClientesYDireccion] ( @frase VARCHAR(1000) )
AS 
    SET NOCOUNT ON
    DECLARE @tabla TABLE
        (
         idContrato INT
        ,idDireccion INT
        ,Contrato VARCHAR(300)
        ,Estado VARCHAR(20)
        ,DireccionCliente VARCHAR(MAX)
        )
    DECLARE @sql VARCHAR(1000)
    SET @sql = 'SELECT * FROM dbo.View_Contratos WHERE ' + @frase
    INSERT  @tabla
            EXEC ( @sql
                )
    SELECT  idContrato
           ,idDireccion
           ,Contrato
           ,Estado
           ,DireccionCliente
    FROM    @tabla
    WHERE   Estado != 'Baja'





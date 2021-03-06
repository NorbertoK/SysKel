USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[BuscarClientes]    Script Date: 11/30/2015 17:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarProveedores] ( @frase VARCHAR(1000) )
AS 
    SET NOCOUNT ON
    DECLARE @Result TABLE
        (
         idProveedor INT
        ,RazonSocial VARCHAR(200)
        ,NombreFantasia VARCHAR(200)
        ,CUIT VARCHAR(11)
        )
    DECLARE @sql VARCHAR(1000)
    SET @sql = 'SELECT idProveedor, RazonSocial, NombreFantasia, CUIT FROM dbo.Proveedores WHERE '
        + @frase
    INSERT  @Result
            ( 
             idProveedor
            ,RazonSocial
            ,NombreFantasia
            ,CUIT
            )
            EXEC ( @sql
                )
    SELECT  *
    FROM    @Result


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE ArchivarAumentosAutomaticos(@aumento MONEY)
AS 
    BEGIN
        SET NOCOUNT ON;
        DECLARE @fecha DATETIME = GETDATE()
        INSERT  dbo.AumentosAuto
                ( 
                 Fecha
                ,Tabla
                ,Item
                ,Marca
                )
                SELECT  @fecha
                       ,'Rubro'
                       ,Nombre
                       ,Marca
                FROM    dbo.TiposDeCliente
                UNION ALL
                SELECT  @fecha
                       ,'Tipo de Contrato'
                       ,Nombre
                       ,Marca
                FROM    dbo.TiposDeContrato
                UNION ALL
                SELECT  @fecha
                       ,'Negocio'
                       ,Nombre
                       ,Marca
                FROM    dbo.Negocios
                UNION ALL
                SELECT  @fecha
                       ,'Tanda'
                       ,Nombre
                       ,Marca
                FROM    dbo.TandasDeFacturacion
                UNION ALL
                SELECT  @fecha
                       ,'Localidad'
                       ,Nombre
                       ,Marca
                FROM    dbo.Localidades
    END
GO

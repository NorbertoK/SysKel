USE [Datos]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[AumentosAutomaticos] 
    @aumento DECIMAL(10, 2) = 0
   ,@frase VARCHAR(MAX) = ''
   ,@idAumento INT OUTPUT
AS 
    BEGIN
        SET NOCOUNT ON;
        DECLARE @fecha DATETIME = GETDATE()
        INSERT  dbo.AumentosAutoCabecera
                ( Fecha, Aumento )
        VALUES  ( @fecha, @aumento )
        SET @idAumento = SCOPE_IDENTITY()
        INSERT  dbo.AumentosAuto
                ( 
                 Fecha
                ,Tabla
                ,Item
                ,Marca
                ,idAumentoAutoCabecera
                )
                SELECT  @fecha
                       ,'Rubro'
                       ,Nombre
                       ,Marca
                       ,@idAumento
                FROM    dbo.TiposDeCliente
                UNION ALL
                SELECT  @fecha
                       ,'Tipo de Contrato'
                       ,Nombre
                       ,Marca
                       ,@idAumento
                FROM    dbo.TiposDeContrato
                UNION ALL
                SELECT  @fecha
                       ,'Negocio'
                       ,Nombre
                       ,Marca
                       ,@idAumento
                FROM    dbo.Negocios
                UNION ALL
                SELECT  @fecha
                       ,'Tanda'
                       ,Nombre
                       ,Marca
                       ,@idAumento
                FROM    dbo.TandasDeFacturacion
                UNION ALL
                SELECT  @fecha
                       ,'Localidad'
                       ,Nombre
                       ,Marca
                       ,@idAumento
                FROM    dbo.Localidades
        DECLARE @parametros NVARCHAR(MAX) = '@aumento DECIMAL(10,2), @frase VARCHAR(MAX)'
        DECLARE @sql VARCHAR(MAX) = 'UPDATE  dbo.RenglonesFacturaProforma
SET     PrecioUnitario = dbo.Redondeo(PrecioUnitario * (1 + '
            + CONVERT(VARCHAR(10), @aumento / 100)
            + '),2) 
FROM    dbo.RenglonesFacturaProforma rfp
        JOIN dbo.Contratos cto ON rfp.idContrato = cto.idContrato
        JOIN dbo.Clientes cli ON cto.idCliente = cli.idCliente
        JOIN dbo.FacturasProforma fp ON rfp.idFacturaProforma = fp.idFacturaProforma
        JOIN dbo.Direcciones dir ON fp.idCliente = dir.idCliente
WHERE   dir.Real = 1 ' + @frase
        DECLARE @sql1 VARCHAR(MAX) = 'UPDATE  dbo.Planes
SET     Cuota = dbo.Redondeo(Cuota * (1 + '
            + CAST(@aumento / 100 AS VARCHAR(10))
            + '),2),CuotaAdherente = dbo.Redondeo(CuotaAdherente * (1 + '
            + CAST(@aumento / 100 AS VARCHAR(10))
            + '),2)
FROM    dbo.Planes pl
        JOIN dbo.RenglonesFacturaProforma rfp ON pl.idPlan = rfp.idPlan
        JOIN dbo.Contratos cto ON rfp.idContrato = cto.idContrato
        JOIN dbo.Clientes cli ON cto.idCliente = cli.idCliente
        JOIN dbo.FacturasProforma fp ON rfp.idFacturaProforma = fp.idFacturaProforma
        JOIN dbo.Direcciones dir ON fp.idCliente = dir.idCliente
WHERE   dir.Real = 1 ' + @frase

        EXEC sp_executesql @sql, @parametros, @aumento, @frase
        EXEC sp_executesql @sql1, @parametros, @aumento, @frase
    END

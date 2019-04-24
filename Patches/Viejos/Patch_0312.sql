UPDATE  [Datos].[dbo].[Autorizaciones]
SET     [Descripcion] = 'Renumerar y Anular Facturas'
WHERE   Codigo = 'MA-0111'
GO

INSERT  INTO [Datos].[dbo].[Autorizaciones]
        ( [Descripcion], [idTipoDeAutorizacion], [Codigo] )
VALUES  ( 'Histórico de Planes', 1, 'MA-0113' ),
        ( 'Histórico de Recursos', 1, 'MA-0114' )
GO



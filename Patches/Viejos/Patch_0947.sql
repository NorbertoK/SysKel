UPDATE  [Datos].[dbo].[PuntosDeVenta]
SET     [UltimoNumeroAsignacoNdeCA] = 0
       ,[UltimoNumeroAsignacoNdeDA] = 0
       ,[UltimoNumeroAsignacoNdeCB] = 0
       ,[UltimoNumeroAsignacoNdeDB] = 0
       ,[UltimoNumeroAsignadoM] = 0
       ,[UltimoNumeroAsignacoNdeCM] = 0
       ,[UltimoNumeroAsignacoNdeDM] = 0
WHERE   idPuntoDeVenta = 3
        AND Prefijo = 2
        AND Observaciones = 'AFIP'
GO



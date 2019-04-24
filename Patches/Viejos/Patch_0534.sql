UPDATE  comp
SET     idCategoriaIVA = ref.idCategoriaIVA
       ,CUIT = ref.CUIT
FROM    dbo.Comprobantes comp
        JOIN dbo.Comprobantes ref ON comp.idReferencia = ref.idComprobante
WHERE   comp.idTipoDeComprobante IN ( 5, 9, 12, 13, 14, 15 )
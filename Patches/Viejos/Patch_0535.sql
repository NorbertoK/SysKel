UPDATE  comp
SET     Barrio = ref.Barrio
       ,Direccion = ref.Direccion
       ,Entre = ref.Entre
       ,idZona = ref.idZona
       ,Localidad = ref.Localidad
       ,ObservacionesDireccion = ref.ObservacionesDireccion
       ,PjeIVA = ref.PjeIVA
FROM    dbo.Comprobantes comp
        JOIN dbo.Comprobantes ref ON comp.idReferencia = ref.idComprobante
WHERE   comp.idTipoDeComprobante IN ( 5, 9, 12, 13, 14, 15 )
UPDATE comp
SET Apellido = ref.Apellido, Nombre =  ref.Nombre
FROM dbo.Comprobantes comp
JOIN dbo.Comprobantes ref ON comp.idReferencia = ref.idComprobante
WHERE comp.NombApel IS null

UPDATE dbo.AfiliadosPlanes
SET idPlan = (SELECT idPlan FROM dbo.Planes WHERE Nombre = 'Honorario')
FROM
dbo.AfiliadosPlanes ap
JOIN dbo.Solicitudes s ON ap.idSolicitud = s.idSolicitud
JOIN dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
JOIN dbo.Grupos g ON af.idGrupo = g.idGrupo
WHERE g.importe = 0
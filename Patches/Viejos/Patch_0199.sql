DELETE dbo.Grupos
FROM dbo.Grupos gru
WHERE (SELECT COUNT(*) FROM dbo.Afiliados WHERE idGrupo = gru.idGrupo) = 0
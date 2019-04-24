UPDATE  dbo.AfiliadosPlanes
SET     idPlan = 2
FROM    dbo.AfiliadosPlanes
WHERE   idPlan IN ( 1, 5 )

UPDATE  dbo.AfiliadosPlanes
SET     idPlan = 3
FROM    dbo.AfiliadosPlanes
WHERE   idPlan IN ( 4, 6 )

DELETE  dbo.Planes
WHERE   idPlan IN ( 1, 5, 4, 6 )

UPDATE  dbo.Planes
SET     Cuota = 92
       ,CuotaAdherente = 43
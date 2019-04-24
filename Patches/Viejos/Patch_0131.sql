DECLARE @Titular MONEY = 102
DECLARE @Adherente MONEY = 47
UPDATE  dbo.Grupos
SET     Importe = CASE WHEN Importe * 1.5 < @Titular + ( dbo.CantidadDeAfiliadosActivosDelGrupo(idGrupo, NULL) - 1 ) * @Adherente THEN Importe * 1.5
                       ELSE 0
                  END
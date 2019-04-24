UPDATE  dbo.Parametros
SET     UsaNegocios = CASE WHEN ( SELECT    NombreEmpresa
                                  FROM      dbo.Sistemas
                                ) = 'SAE' THEN 1
                           ELSE 0
                      END

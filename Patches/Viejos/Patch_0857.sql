USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[DireccionCompleta]    Script Date: 05/24/2017 19:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[DireccionCompleta] ( @idDireccion INT = 0 )
RETURNS VARCHAR(MAX)
AS 
    BEGIN
        DECLARE @frase VARCHAR(MAX)
        SELECT  @frase = CASE WHEN c.Nombre IS NULL THEN ''
                              ELSE c.Nombre + ' '
                         END + CASE WHEN dir.Numero IS NULL THEN ''
                                    ELSE dir.Numero + ' '
                               END + CASE WHEN dir.Piso IS NULL
                                               OR LEN(dir.Piso) = 0 THEN ''
                                          ELSE 'Piso ' + dir.Piso + ' '
                                     END
                + CASE WHEN dir.Departamento IS NULL
                            OR LEN(dir.Departamento) = 0 THEN ''
                       ELSE 'Depto. ' + dir.Departamento + ' '
                  END
                + CASE WHEN dir.idEntreCalle1 IS NULL
                       THEN CASE WHEN dir.idEntreCalle2 IS NULL
                                 THEN CASE WHEN b.Nombre IS NULL
                                                OR b.Nombre = '' THEN ''
                                           ELSE b.Nombre + ' '
                                      END
                                 ELSE 'esq. ' + e2.Nombre
                                      + CASE WHEN b.Nombre IS NULL
                                                  OR b.Nombre = '' THEN ''
                                             ELSE ' - ' + b.Nombre + ' '
                                        END
                            END
                       ELSE CASE WHEN dir.idEntreCalle2 IS NULL
                                 THEN 'esq.' + e1.Nombre
                                      + CASE WHEN b.Nombre IS NULL
                                                  OR b.Nombre = '' THEN ''
                                             ELSE ' - ' + b.Nombre
                                        END
                                 ELSE 'entre ' + e1.Nombre + ' y ' + e2.nombre
                                      + CASE WHEN b.Nombre IS NULL
                                                  OR b.Nombre = '' THEN ''
                                             ELSE ' - ' + b.Nombre
                                        END
                            END
                  END + CASE WHEN Localidades.Nombre IS NULL
                                  OR Localidades.Nombre = '' THEN ''
                             ELSE ' -  ' + Localidades.Nombre + ' '
                        END
                + CASE WHEN dir.Observaciones IS NULL
                            OR REPLACE(REPLACE(REPLACE(REPLACE(dir.Observaciones,
                                                              CHAR(10), ''),
                                                       CHAR(13), ''), CHAR(9),
                                               ''), ' ', '') = '' THEN ''
                       ELSE '(' + dir.Observaciones + ')'
                  END
        FROM    Direcciones AS dir
                LEFT JOIN Zonas ON dir.idZona = Zonas.idZona
                LEFT JOIN Calles AS c ON dir.idCalle = c.idCalle
                LEFT JOIN Calles AS e1 ON dir.idEntreCalle1 = e1.idCalle
                LEFT JOIN Calles AS e2 ON dir.idEntreCalle2 = e2.idCalle
                LEFT JOIN Localidades ON c.idLocalidad = Localidades.idLocalidad
                LEFT JOIN Barrios AS b ON dir.idBarrio = b.idBarrio
                                          AND Localidades.idLocalidad = b.idLocalidad
        WHERE   idDireccion = @idDireccion
        SET @frase = LEFT(@frase, LEN(@frase))
        RETURN @frase
    END


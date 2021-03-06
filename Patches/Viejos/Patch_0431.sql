USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[SelectModificarPrestaciones]    Script Date: 03/19/2015 16:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SelectModificarPrestaciones] ( @proceso varchar(255) )
AS 
    SET NOCOUNT ON ;
    DECLARE @sql nVarChar(MAX)
    DECLARE @parametros nVarChar(MAX)
    DECLARE @tabla table
        (
          idPrestacion int,
          Numero varchar(12),
          Agendada DATETIME,
          Estado int,
          Direccion varchar(MAX),
          Nombre varchar(200),
          Edad varchar(10),
          Recurso Varchar(20),
          Jerarquia smallint,
          Motivos varchar(max),
          TiempoDeLlegada datetime
        )
    INSERT  @tabla
            (
              idPrestacion,
              Numero,
              Agendada,
              Estado,
              Direccion,
              Nombre,
              Edad,
              Recurso,
              Jerarquia,
              Motivos,
              TiempoDeLlegada
            )
            SELECT  prest.idPrestacion,
                    prest.Numero,
                    prest.Agendada,
                    dbo.EstadoDeLaPrestacion(prest.idPrestacion) AS Estado,
                    dbo.DireccionCompleta(( SELECT  min(Dir.idDireccion)
                                            FROM    dbo.Direcciones dir
                                                    JOIN dbo.Destinos dest ON dest.idDestino = dir.idDestino
                                            WHERE   dest.idPrestacion = prest.idPrestacion
                                          )) AS Direccion,
                    ( SELECT    Pac.Nombre
                      FROM      dbo.Pacientes pac
                      WHERE     pac.idPrestacion = prest.idPrestacion
                                AND pac.idPaciente = ( SELECT   min(Pacientes.idPaciente)
                                                       FROM     dbo.Pacientes
                                                       WHERE    Pacientes.idPrestacion = prest.idPrestacion
                                                     )
                    ) AS Nombre,
                    CAST(( SELECT   Pac.Edad
                           FROM     dbo.Pacientes pac
                           WHERE    pac.idPrestacion = prest.idPrestacion
                                    AND pac.idPaciente = ( SELECT   min(Pacientes.idPaciente)
                                                           FROM     dbo.Pacientes
                                                           WHERE    Pacientes.idPrestacion = prest.idPrestacion
                                                         )
                         ) AS varchar)
                    + CASE ( SELECT Pac.EdadEn
                             FROM   dbo.Pacientes pac
                             WHERE  pac.idPrestacion = prest.idPrestacion
                                    AND pac.idPaciente = ( SELECT   min(Pacientes.idPaciente)
                                                           FROM     dbo.Pacientes
                                                           WHERE    Pacientes.idPrestacion = prest.idPrestacion
                                                         )
                           )
                        WHEN 'A' THEN ' años'
                        WHEN 'M' THEN ' meses'
                        WHEN 'D' THEN ' días'
                      END AS Edad,
                    ( SELECT    Recursos.Nombre
                      FROM      dbo.Recursos
                                JOIN dbo.DestinosRecursos dr ON dr.idRecurso = Recursos.idRecurso
                                                                AND dr.idDestinoRecurso = ( SELECT  min(idDestinoRecurso)
                                                                                            FROM    dbo.DestinosRecursos
                                                                                                    JOIN dbo.Destinos dest ON dest.idDestino = DestinosRecursos.idDestino
                                                                                            WHERE   dest.idPrestacion = prest.idPrestacion
                                                                                                    AND DestinosRecursos.Cancelado IS NULL
                                                                                          )
                    ) AS Recurso,
                    Codigos.Jerarquia,
                    ( SELECT    pac.MotivosDeLlamado
                      FROM      dbo.Pacientes pac
                      WHERE     pac.idPrestacion = prest.idPrestacion
                                AND pac.idPaciente = ( SELECT   min(Pacientes.idPaciente)
                                                       FROM     dbo.Pacientes
                                                       WHERE    Pacientes.idPrestacion = prest.idPrestacion
                                                     )
                    ) AS Motivos,
                    CASE WHEN prest.TiempoDeLlegada is null
                         THEN getdate() - prest.Tomada
                         ELSE prest.TiempoDeLlegada
                    END AS TiempoDeLlegada
            FROM    dbo.Ids i
                    JOIN dbo.Prestaciones prest on prest.idPrestacion = i.Id
                    LEFT JOIN dbo.Codigos ON prest.idCodigo = Codigos.idCodigo
            WHERE   i.Proceso = @proceso
    SELECT  *
    FROM    @tabla
    DELETE  dbo.Ids
    WHERE   Proceso = @proceso


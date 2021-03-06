USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[SelectPrestacionesResumen]    Script Date: 12/15/2013 01:50:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SelectPrestacionesResumen] ( @agendada VARCHAR(20) )
AS 
    SET NOCOUNT ON ;
    DECLARE @tabla TABLE
        (
         idPrestacion INT
        ,Numero VARCHAR(12)
        ,Agendada DATETIME
        ,Estado INT
        ,Direccion VARCHAR(MAX)
        ,Nombre VARCHAR(200)
        ,Edad VARCHAR(10)
        ,Recurso VARCHAR(20)
        ,Jerarquia SMALLINT
        ,Motivos VARCHAR(MAX)
        ,TiempoDeLlegada DATETIME
        ,AlertaProgramadaNoSalio BIT
        )
    INSERT  @tabla
            ( 
             idPrestacion
            ,Numero
            ,Agendada
            ,Estado
            ,Direccion
            ,Nombre
            ,Edad
            ,Recurso
            ,Jerarquia
            ,Motivos
            ,TiempoDeLlegada
            ,AlertaProgramadaNoSalio
            )
            SELECT  prest.idPrestacion
                   ,prest.Numero
                   ,prest.Agendada
                   ,dbo.EstadoDeLaPrestacion(prest.idPrestacion)
                   ,REPLACE(REPLACE(REPLACE(dbo.DireccionCompleta(( SELECT  MIN(Dir.idDireccion)
                                                                    FROM    dbo.Direcciones dir
                                                                    JOIN    dbo.Destinos dest ON dest.idDestino = dir.idDestino
                                                                    WHERE   dest.idPrestacion = prest.idPrestacion
                                                                  )), CHAR(10), ' '), CHAR(13), ' '), CHAR(9), ' ') AS Direccion
                   ,( SELECT    Pac.Nombre
                      FROM      dbo.Pacientes pac
                      WHERE     pac.idPrestacion = prest.idPrestacion
                                AND pac.idPaciente = ( SELECT   MIN(Pacientes.idPaciente)
                                                       FROM     dbo.Pacientes
                                                       WHERE    Pacientes.idPrestacion = prest.idPrestacion
                                                     )
                    ) AS Nombre
                   ,CAST(( SELECT   Pac.Edad
                           FROM     dbo.Pacientes pac
                           WHERE    pac.idPrestacion = prest.idPrestacion
                                    AND pac.idPaciente = ( SELECT   MIN(Pacientes.idPaciente)
                                                           FROM     dbo.Pacientes
                                                           WHERE    Pacientes.idPrestacion = prest.idPrestacion
                                                         )
                         ) AS VARCHAR) + CASE ( SELECT  Pac.EdadEn
                                                FROM    dbo.Pacientes pac
                                                WHERE   pac.idPrestacion = prest.idPrestacion
                                                        AND pac.idPaciente = ( SELECT   MIN(Pacientes.idPaciente)
                                                                               FROM     Pacientes
                                                                               WHERE    Pacientes.idPrestacion = prest.idPrestacion
                                                                             )
                                              )
                                           WHEN 'A' THEN ' años'
                                           WHEN 'M' THEN ' meses'
                                           WHEN 'D' THEN ' días'
                                         END AS Edad
                   ,( SELECT    Recursos.Nombre
                      FROM      dbo.Recursos
                      JOIN      dbo.DestinosRecursos dr ON dr.idRecurso = Recursos.idRecurso
                                                           AND dr.idDestinoRecurso = ( SELECT   MIN(idDestinoRecurso)
                                                                                       FROM     dbo.DestinosRecursos
                                                                                       JOIN     dbo.Destinos dest ON dest.idDestino = DestinosRecursos.idDestino
                                                                                       WHERE    dest.idPrestacion = prest.idPrestacion
                                                                                                AND DestinosRecursos.Cancelado IS NULL
                                                                                     )
                    ) AS Recurso
                   ,Codigos.Jerarquia
                   ,( SELECT    pac.MotivosDeLlamado
                      FROM      dbo.Pacientes pac
                      WHERE     pac.idPrestacion = prest.idPrestacion
                                AND pac.idPaciente = ( SELECT   MIN(Pacientes.idPaciente)
                                                       FROM     dbo.Pacientes
                                                       WHERE    Pacientes.idPrestacion = prest.idPrestacion
                                                     )
                    ) AS Motivos
                   ,CASE WHEN prest.Agendada IS NOT NULL THEN NULL
                         ELSE CASE WHEN prest.TiempoDeLlegada IS NULL THEN GETDATE() - prest.Tomada
                                   ELSE prest.TiempoDeLlegada
                              END
                    END AS TiempoDeLlegada
                   ,CASE WHEN prest.Agendada IS NOT NULL
                              AND (DATEDIFF(mi,GETDATE(),prest.Agendada) <= 15)
                              AND dbo.EstadoDeLaPrestacion(prest.idPrestacion) < 3 THEN 1
                         ELSE 0
                    END AlertaProgramadaNoSalio
            FROM    dbo.Prestaciones AS prest
            LEFT JOIN dbo.Codigos ON prest.idCodigo = Codigos.idCodigo
            WHERE   ( prest.Terminada = 0 )
    IF @agendada = 'todas' 
        SELECT  *
        FROM    @tabla
    IF ISNUMERIC(@agendada) = 1 
        SELECT  *
        FROM    @tabla
        WHERE   agendada IS NULL
                OR agendada < GETDATE()
                OR DATEDIFF(hh, GETDATE(), agendada) <= @agendada
    IF @agendada = 'hoy' 
        SELECT  *
        FROM    @tabla
        WHERE   agendada IS NULL
                OR dbo.HoraCero(agendada) <= dbo.HoraCero(GETDATE()) 
    IF @agendada = 'semana' 
        SELECT  *
        FROM    @tabla
        WHERE   agendada IS NULL
                OR dbo.HoraCero(agendada) <= DATEADD(dd, 6, dbo.HoraCero(GETDATE())) 
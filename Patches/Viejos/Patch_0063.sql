USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[AtencionesAnterioresConsultorio]    Script Date: 02/11/2013 11:28:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AtencionesAnterioresConsultorio]
    (
     @idTurno INT
    ,@NumeroDeDocumento VARCHAR(10)
    )
RETURNS @tabla TABLE
    (
     Practica VARCHAR(30)
    ,Medico VARCHAR(50)
    ,Hora DATETIME
    ,Motivo VARCHAR(200)
    ,Diagnostico VARCHAR(200)
    ,Evolucion VARCHAR(MAX)
    )
AS 
    BEGIN
        INSERT  @tabla
                ( 
                 Hora
                ,Medico
                ,Practica
                ,Evolucion
                ,Diagnostico
                ,Motivo
                )
                ( SELECT    pr.Nombre Practica
                           ,emp.NombApel Medico
                           ,( SELECT    dr.Llegada
                              FROM      dbo.DestinosRecursos dr
                              JOIN      dbo.Destinos dest ON dr.idDestino = dest.idDestino
                              JOIN      dbo.Prestaciones prest ON dest.idDestino = dbo.PrimerDestino(prest.idPrestacion)
                              WHERE     prest.idPrestacion = pac.idPrestacion
                            ) Hora
                           ,dbo.MotivosDelPaciente(pac.idPaciente) Motivo
                           ,dbo.DiagnosticosDelPaciente(pac.idPaciente) Diagnostico
                           ,CASE WHEN ISNULL(pac.Evolución, '') = '' THEN CASE WHEN EXISTS ( SELECT *
                                                                                             FROM   dbo.Destinos dest
                                                                                             WHERE  dest.idPrestacion = prest.idPrestacion
                                                                                                    AND dest.idTipoDeDestino = ( SELECT TOP 1
                                                                                                                                        Internacion
                                                                                                                                 FROM   dbo.Sistemas
                                                                                                                               ) ) THEN 'Se internó.'
                                                                               ELSE ''
                                                                          END
                                 ELSE pac.Evolucion + CASE WHEN EXISTS ( SELECT *
                                                                         FROM   dbo.Destinos dest
                                                                         WHERE  dest.idPrestacion = prest.idPrestacion
                                                                                AND dest.idTipoDeDestino = ( SELECT TOP 1
                                                                                                                    Internacion
                                                                                                             FROM   dbo.Sistemas
                                                                                                           ) ) THEN ' - Se internó.'
                                                           ELSE ''
                                                      END
                            END Evolucion
                  FROM      dbo.Pacientes pac
                  JOIN      dbo.Practicas pr ON pac.idPractica = pr.idPractica
                  JOIN      dbo.Empleados emp ON pac.idMedico = emp.idEmpleado
                  JOIN      dbo.Prestaciones prest ON prest.idPrestacion = pac.idPrestacion
                  WHERE     pac.NumeroDeDocumento = @NumeroDeDocumento
                )
                UNION ALL
                SELECT  'Cosultorio'
                       ,emp.NombApel
                       ,t.Atendido
                       ,dbo.MotivosDelTurno(t.idTurno)
                       ,dbo.DiagnosticosDelTurno(t.idTurno)
                       ,t.Evolución
                FROM    dbo.Turnos t
                JOIN    dbo.Empleados emp ON t.idEmpleado = emp.idEmpleado
                WHERE   t.NumeroDeDocumento = @NumeroDeDocumento
                        AND t.Terminado IS NOT NULL
        RETURN
    END
            

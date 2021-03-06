USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[AtencionesAnterioresConsultorio]    Script Date: 11/22/2013 22:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[AtencionesAnterioresConsultorio]
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
        DECLARE @idMedico INT = ( SELECT    idEmpleado
                                  FROM      dbo.Turnos
                                  WHERE     idTurno = @idTurno
                                )
        DECLARE @mostrar INT = ( SELECT TOP 1
                                        MedicoVeEvolucionOtrosMedicos
                                 FROM   dbo.Parametros
                               )
        INSERT  @tabla
                ( 
                 Practica
                ,Medico
                ,Hora
                ,Motivo
                ,Diagnostico
                ,Evolucion
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
                       ,CASE WHEN emp.idempleado = @idMedico
                                  OR @mostrar = 1 THEN dbo.MotivosDelTurno(t.idTurno)
                             ELSE ''
                        END
                       ,CASE WHEN emp.idempleado = @idMedico
                                  OR @mostrar = 1 THEN dbo.DiagnosticosDelTurno(t.idTurno)
                             ELSE ''
                        END
                       ,CASE WHEN emp.idempleado = @idMedico
                                  OR @mostrar = 1 THEN t.Evolución
                             ELSE ''
                        END
                FROM    dbo.Turnos t
                JOIN    dbo.Empleados emp ON t.idEmpleado = emp.idEmpleado
                WHERE   t.NumeroDeDocumento = @NumeroDeDocumento
                        AND t.idTurno != @idTurno
        RETURN
    END
            

-- ================================================
-- Template generated from Template Explorer using:
-- Create Inline Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		NK
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION AtencionesAnterioresConsultorio
    (
     -- Add the parameters for the function here
     @idTurno INT
    ,@NumeroDeDocumento VARCHAR(10)
    )
RETURNS TABLE
AS
RETURN
    (
	-- Add the SELECT statement with parameter references here
      SELECT    pr.Nombre Practica
               ,emp.NombApel Medico
               ,( SELECT    dr.Llegada
                  FROM      dbo.DestinosRecursos dr
                  JOIN      dbo.Destinos dest ON dr.idDestino = dest.idDestino
                  JOIN      dbo.Prestaciones prest ON dest.idDestino = dbo.PrimerDestino(prest.idPrestacion)
                  WHERE     prest.idPrestacion = pac.idPrestacion
                ) Hora
               ,dbo.MotivosDelPaciente(pac.idPaciente) Motivo
               ,dbo.DiagnosticosDelPaciente(pac.idPaciente) Diagnostico
               ,CASE WHEN ISNULL(pac.Evolución, '') = '' THEN 'Se internó.'
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
GO

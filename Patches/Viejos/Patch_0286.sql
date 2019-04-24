USE [Datos]
GO

/****** Object:  View [dbo].[RecursosConEstado]    Script Date: 03/09/2014 18:01:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[RecursosConEstado]
AS
SELECT     idRecurso, Nombre, Tripulacion, idMovil, idMedico, idMedico2, idParamedico, idParamedico2, idChofer, idChofer2, Observaciones,
                          (SELECT     Color
                            FROM          dbo.DestinosRecursosConEstado
                            WHERE      (idRecurso = r.idRecurso)) AS Color,
                          (SELECT     Direccion
                            FROM          dbo.DestinosRecursosConEstado AS DestinosRecursosConEstado_2
                            WHERE      (idRecurso = r.idRecurso)) AS Direccion, CASE WHEN EXISTS
                          (SELECT     *
                            FROM          dbo.DestinosRecursosConEstado
                            WHERE      idRecurso = r.idRecurso) THEN
                          (SELECT     Estado
                            FROM          dbo.DestinosRecursosConEstado
                            WHERE      idRecurso = r.idRecurso) ELSE 'Libre' END AS Estado, CASE WHEN EXISTS
                          (SELECT     *
                            FROM          dbo.DestinosRecursosConEstado
                            WHERE      idRecurso = r.idRecurso) THEN
                          (SELECT     TOP 1 IndiceEstado
                            FROM          dbo.DestinosRecursosConEstado
                            WHERE      idRecurso = r.idRecurso) ELSE 0 END AS IndiceEstado,
                          (SELECT     idDestinoRecurso
                            FROM          dbo.DestinosRecursosConEstado AS DestinosRecursosConEstado_1
                            WHERE      (idRecurso = r.idRecurso)) AS idDestinoRecurso, dbo.SalidasDelRecursoHoy(idRecurso) AS Salidas
FROM         dbo.Recursos AS r
WHERE     (Activo = 1)

GO



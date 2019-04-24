USE [Datos]
GO

/****** Object:  View [dbo].[View_Hist_Recursos]    Script Date: 03/20/2014 14:44:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[View_Hist_Recursos]
AS
SELECT     idHist_Recursos, idRecurso, Nombre_anterior, Nombre_nuevo,
                          (SELECT     Nombre
                            FROM          dbo.Moviles
                            WHERE      (idMovil = dbo.Hist_Recursos.idMovil_anterior)) AS Movil_anterior,
                          (SELECT     Nombre
                            FROM          dbo.Moviles AS Moviles_1
                            WHERE      (idMovil = dbo.Hist_Recursos.idMovil_nuevo)) AS Movil_nuevo,
                          (SELECT     NombApel
                            FROM          dbo.Empleados
                            WHERE      (idEmpleado = dbo.Hist_Recursos.idMedico_anterior)) AS Medico_anterior,
                          (SELECT     NombApel
                            FROM          dbo.Empleados AS Empleados_11
                            WHERE      (idEmpleado = dbo.Hist_Recursos.idMedico_nuevo)) AS Medico_nuevo,
                          (SELECT     NombApel
                            FROM          dbo.Empleados AS Empleados_10
                            WHERE      (idEmpleado = dbo.Hist_Recursos.idMedico2_anterior)) AS Medico2_anterior,
                          (SELECT     NombApel
                            FROM          dbo.Empleados AS Empleados_9
                            WHERE      (idEmpleado = dbo.Hist_Recursos.idMedico2_nuevo)) AS Medico2_nuevo,
                          (SELECT     NombApel
                            FROM          dbo.Empleados AS Empleados_8
                            WHERE      (idEmpleado = dbo.Hist_Recursos.idParamedico_anterior)) AS Paramedico_anterior,
                          (SELECT     NombApel
                            FROM          dbo.Empleados AS Empleados_7
                            WHERE      (idEmpleado = dbo.Hist_Recursos.IdParamedico_nuevo)) AS Paramedico_nuevo,
                          (SELECT     NombApel
                            FROM          dbo.Empleados AS Empleados_6
                            WHERE      (idEmpleado = dbo.Hist_Recursos.idParamedico2_anterior)) AS Paramedico2_anterior,
                          (SELECT     NombApel
                            FROM          dbo.Empleados AS Empleados_5
                            WHERE      (idEmpleado = dbo.Hist_Recursos.idParamedico2_nuevo)) AS Paramedico2_nuevo,
                          (SELECT     NombApel
                            FROM          dbo.Empleados AS Empleados_4
                            WHERE      (idEmpleado = dbo.Hist_Recursos.idChofer_anterior)) AS Chofer_anterior,
                          (SELECT     NombApel
                            FROM          dbo.Empleados AS Empleados_3
                            WHERE      (idEmpleado = dbo.Hist_Recursos.idChofer_nuevo)) AS Chofer_nuevo,
                          (SELECT     NombApel
                            FROM          dbo.Empleados AS Empleados_2
                            WHERE      (idEmpleado = dbo.Hist_Recursos.idChofer2_anterior)) AS Chofer2_anterior,
                          (SELECT     NombApel
                            FROM          dbo.Empleados AS Empleados_1
                            WHERE      (idEmpleado = dbo.Hist_Recursos.idChofer2_nuevo)) AS Chofer2_nuevo, Activo_anterior, Activo_nuevo, Observaciones_anterior, Observaciones_nuevo, 
                      Fecha
FROM         dbo.Hist_Recursos

GO



USE [Datos]
GO

/****** Object:  View [dbo].[View_Hist_Recursos]    Script Date: 03/16/2014 12:52:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Hist_Recursos]
AS
SELECT     idHist_Recursos, idRecurso, Nombre_anterior, Nombre_nuevo, idMovil_anterior, idMovil_nuevo,
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

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Hist_Recursos"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Hist_Recursos'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Hist_Recursos'
GO



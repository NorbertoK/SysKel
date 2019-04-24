USE [Datos]
GO

/****** Object:  View [dbo].[View_Hist_Planes]    Script Date: 03/16/2014 11:53:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Hist_Planes]
AS
SELECT     pl.idHist_Planes, pl.idPlan, pl.Nombre_anterior, pl.Nombre_nuevo, pl.Iniciales_anterior, pl.Iniciales_nuevo, 
                      cli_ant.RazonSocial + CASE WHEN ISNULL(cli_ant.NombreFantasia, '') = '' THEN '' ELSE ' (' + cli_ant.NombreFantasia + ')' END + ' - ' + cto_ant.Nombre AS Contrato, 
                      cli_nue.RazonSocial + CASE WHEN ISNULL(cli_nue.NombreFantasia, '') = '' THEN '' ELSE ' (' + cli_nue.NombreFantasia + ')' END + ' - ' + cto_nue.Nombre AS Expr1, 
                      pl.Cuota_anterior, pl.Cuota_nuevo, pl.Activo_anterior, pl.Activo_nuevo, pl.PadronExterno_anterior, pl.PadronExterno_nuevo, prot_ant.Nombre AS [Proteccion anterior], 
                      prot_nue.Nombre AS [Proteccion nueva], pl.CuotaAdherente_anterior, pl.CuotaAdherente_nuevo, prep_ant.Nombre AS [Prepago anterior], 
                      prep_nue.Nombre AS [Prepago nuevo], pl.Fecha
FROM         dbo.Hist_Planes AS pl LEFT OUTER JOIN
                      dbo.Contratos AS cto_ant ON pl.idContrato_anterior = cto_ant.idContrato LEFT OUTER JOIN
                      dbo.Clientes AS cli_ant ON cto_ant.idCliente = cli_ant.idCliente LEFT OUTER JOIN
                      dbo.Contratos AS cto_nue ON pl.idContrato_nuevo = cto_nue.idContrato LEFT OUTER JOIN
                      dbo.Clientes AS cli_nue ON cto_ant.idCliente = cli_nue.idCliente LEFT OUTER JOIN
                      dbo.Protecciones AS prot_ant ON pl.idProteccion_anterior = prot_ant.idProteccion LEFT OUTER JOIN
                      dbo.Protecciones AS prot_nue ON pl.idProteccion_nuevo = prot_nue.idProteccion LEFT OUTER JOIN
                      dbo.Prepagos AS prep_ant ON pl.idPrepago_anterior = prep_ant.idPrepago LEFT OUTER JOIN
                      dbo.Prepagos AS prep_nue ON pl.idPrepago_nuevo = prep_nue.idPrepago

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
         Begin Table = "pl"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 251
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cto_ant"
            Begin Extent = 
               Top = 6
               Left = 289
               Bottom = 125
               Right = 462
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cli_ant"
            Begin Extent = 
               Top = 6
               Left = 500
               Bottom = 125
               Right = 745
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cto_nue"
            Begin Extent = 
               Top = 6
               Left = 783
               Bottom = 125
               Right = 956
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cli_nue"
            Begin Extent = 
               Top = 6
               Left = 994
               Bottom = 125
               Right = 1239
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prot_ant"
            Begin Extent = 
               Top = 6
               Left = 1277
               Bottom = 125
               Right = 1437
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prot_nue"
            Begin Extent = 
               Top = 6
               Left = 1475
               Bottom = 125
               Right = 1635
            End
            DisplayFlags = 280
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Hist_Planes'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'       TopColumn = 0
         End
         Begin Table = "prep_ant"
            Begin Extent = 
               Top = 6
               Left = 1673
               Bottom = 110
               Right = 1833
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prep_nue"
            Begin Extent = 
               Top = 114
               Left = 1673
               Bottom = 218
               Right = 1833
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Hist_Planes'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Hist_Planes'
GO



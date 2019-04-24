USE [Datos]
GO

/****** Object:  View [dbo].[View_Facturaciones]    Script Date: 11/01/2018 14:07:32 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[View_Facturaciones]'))
DROP VIEW [dbo].[View_Facturaciones]
GO

USE [Datos]
GO

/****** Object:  View [dbo].[View_Facturaciones]    Script Date: 11/01/2018 14:07:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Facturaciones]
AS
SELECT     f.idFacturacion, f.Periodo, CASE f.AfiliadosOClientes WHEN 'A' THEN 'Afiliados' WHEN 'C' THEN 'Clientes' WHEN 'P' THEN 'Prestaciones' END AS AfiliadosOClientes, 
                      tf.Nombre AS TandaDeFacturacion, tc.Nombre AS TipoDeCobranza, f.Fecha, f.EntregadaAlCobrador, ec.Nombre AS EntidadDeCobranza, e.ApelNomb AS Cobrador,
                          (SELECT     COUNT(*) AS Expr1
                            FROM          dbo.Comprobantes
                            WHERE      (idFacturacion = f.idFacturacion) AND (ISNULL(Anulado, 0) = 0)) AS Comprobantes,
                          (SELECT     SUM(Importe) AS Expr1
                            FROM          dbo.Comprobantes AS Comprobantes_1
                            WHERE      (idFacturacion = f.idFacturacion) AND (ISNULL(Anulado, 0) = 0)) AS Importe, f.Entregar
FROM         dbo.Facturaciones AS f LEFT OUTER JOIN
                      dbo.Empleados AS e ON f.idCobrador = e.idEmpleado LEFT OUTER JOIN
                      dbo.EntidadesDeCobranza AS ec ON f.idEntidadDeCobranza = ec.idEntidadDeCobranza LEFT OUTER JOIN
                      dbo.TandasDeFacturacion AS tf ON f.idTandaDeFacturacion = tf.idTandaDeFacturacion LEFT OUTER JOIN
                      dbo.TiposDeCobranza AS tc ON f.idTipoDeCobranza = tc.idTipoDeCobranza

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
         Begin Table = "f"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 201
               Right = 226
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "e"
            Begin Extent = 
               Top = 123
               Left = 402
               Bottom = 238
               Right = 565
            End
            DisplayFlags = 280
            TopColumn = 9
         End
         Begin Table = "ec"
            Begin Extent = 
               Top = 6
               Left = 465
               Bottom = 121
               Right = 656
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tf"
            Begin Extent = 
               Top = 6
               Left = 264
               Bottom = 91
               Right = 452
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tc"
            Begin Extent = 
               Top = 6
               Left = 694
               Bottom = 121
               Right = 913
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Facturaciones'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Facturaciones'
GO


USE [Datos]
GO

/****** Object:  View [dbo].[View_Contratos]    Script Date: 11/01/2018 14:02:40 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[View_Contratos]'))
DROP VIEW [dbo].[View_Contratos]
GO

USE [Datos]
GO

/****** Object:  View [dbo].[View_Contratos]    Script Date: 11/01/2018 14:02:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Contratos]
AS
SELECT     con.idContrato, CASE WHEN EXISTS
                          (SELECT     *
                            FROM          Direcciones
                            WHERE      idContrato = con.idContrato) THEN dirCto.idDireccion ELSE dir.idDireccion END AS Expr1, cli.RazonSocial + CASE WHEN ISNULL(cli.NombreFantasia, '') 
                      = '' THEN '' ELSE ' (' + cli.NombreFantasia + ')' END + ' - ' + con.Nombre AS Contrato,
                          (SELECT     CASE WHEN sol.AltaBajaSusp = 'A' THEN CASE
                                                       (SELECT     COUNT(*)
                                                         FROM          dbo.Comprobantes comp
                                                         WHERE      comp.idCliente = cli.idCliente AND comp.Periodo != dbo.PeríodoDeUnaFecha(GETDATE()) AND comp.idTipoDeComprobante IN
                                                                                    (SELECT     idTipoDeComprobante
                                                                                      FROM          dbo.TiposDeComprobante
                                                                                      WHERE      EsFactura = 1) AND comp.Saldo > 0) WHEN 0 THEN 'Activo' WHEN 1 THEN 'Debe 1 mes' ELSE 'Debe ' +
                                                       (SELECT     CAST(COUNT(*) AS VARCHAR(10))
                                                         FROM          dbo.Comprobantes comp
                                                         WHERE      comp.idCliente = cli.idCliente AND comp.Periodo != dbo.PeríodoDeUnaFecha(GETDATE()) AND comp.idTipoDeComprobante IN
                                                                                    (SELECT     idTipoDeComprobante
                                                                                      FROM          dbo.TiposDeComprobante
                                                                                      WHERE      EsFactura = 1) AND comp.Saldo > 0 AND ISNULL(Anulado, 0) = 0) 
                                                   + ' meses' END WHEN sol.AltaBajaSusp = 'B' THEN 'Baja' WHEN sol.AltaBajaSusp = 'S' THEN 'Suspendido' END AS Expr1
                            FROM          dbo.Solicitudes AS sol
                            WHERE      (idSolicitud =
                                                       (SELECT     MAX(idSolicitud) AS idSolicitud
                                                         FROM          dbo.Solicitudes AS S
                                                         WHERE      (FechaFinal IS NULL) AND (Fecha <= GETDATE()) AND (idContrato = con.idContrato) OR
                                                                                (Fecha <= GETDATE()) AND (idContrato = con.idContrato) AND (FechaFinal > GETDATE())))) AS Estado, dbo.DireccionCompleta(CASE WHEN EXISTS
                          (SELECT     *
                            FROM          Direcciones
                            WHERE      idContrato = con.idContrato) THEN dirCto.idDireccion ELSE dir.idDireccion END) AS DireccionCliente
FROM         dbo.Clientes AS cli LEFT OUTER JOIN
                      dbo.Contratos AS con ON con.idCliente = cli.idCliente LEFT OUTER JOIN
                      dbo.Direcciones AS dir ON dir.idCliente = cli.idCliente LEFT OUTER JOIN
                      dbo.Direcciones AS dirCto ON dirCto.idContrato = con.idContrato

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
         Begin Table = "cli"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 222
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "con"
            Begin Extent = 
               Top = 145
               Left = 376
               Bottom = 260
               Right = 541
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "dir"
            Begin Extent = 
               Top = 6
               Left = 463
               Bottom = 121
               Right = 615
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "dirCto"
            Begin Extent = 
               Top = 138
               Left = 654
               Bottom = 257
               Right = 814
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
         Alias = 1560
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Contratos'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Contratos'
GO



USE [Datos]
GO
/****** Object:  Trigger [dbo].[Hist_RenglonesDeFactura]    Script Date: 03/15/2014 23:07:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
ALTER TRIGGER [dbo].[Hist_RenglonesDeFactura] ON [dbo].[RenglonesFacturaProforma]
    AFTER INSERT, DELETE, UPDATE
AS
    BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
        SET NOCOUNT ON ;

    -- Insert statements for trigger here
        DECLARE @tablaInserted TABLE
            (
             Renglon INT IDENTITY(1, 1)
            ,idRenglonFacturaProforma INT
            )
        DECLARE @cuantosInserted INT
           ,@n INT
        DECLARE @tablaDeleted TABLE
            (
             Renglon INT IDENTITY(1, 1)
            ,idRenglonFacturaProforma INT
            )
        DECLARE @cuantosDeleted INT   
        INSERT  @tablaInserted
                ( 
                 idRenglonFacturaProforma 
                )
                SELECT  idRenglonFacturaProforma
                FROM    INSERTED
        SET @cuantosInserted = @@ROWCOUNT
        INSERT  @tablaDeleted
                ( 
                 idRenglonFacturaProforma 
                )
                SELECT  idRenglonFacturaProforma
                FROM    DELETED d
                WHERE   NOT EXISTS ( SELECT *
                                     FROM   @tablaInserted
                                     WHERE  idRenglonFacturaProforma = d.idRenglonFacturaProforma )
        SET @cuantosDeleted = @@ROWCOUNT
        SET @n = 1
        WHILE @n <= @cuantosInserted 
            BEGIN
                INSERT  dbo.Hist_RenglonesFacturaProforma
                        ( 
                         Fecha
                        ,idRenglonFacturaProforma
                        ,idContrato_anterior
                        ,idContrato_nuevo
                        ,idPlan_anterior
                        ,idPlan_nuevo
                        ,Cantidad_anterior
                        ,Cantidad_nuevo
                        ,PrecioUnitario_anterior
                        ,PrecioUnitario_nuevo
                        ,RevisarMensualmente_anterior
                        ,RevisarMensualmente_nuevo
                        )
                        SELECT  GETDATE()
                               ,idRenglonFacturaProforma
                               ,( SELECT    ISNULL(idContrato, NULL)
                                  FROM      DELETED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(idContrato, NULL)
                                  FROM      INSERTED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(idPlan, NULL)
                                  FROM      DELETED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(idPlan, NULL)
                                  FROM      INSERTED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(Cantidad, NULL)
                                  FROM      DELETED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(Cantidad, NULL)
                                  FROM      INSERTED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(PrecioUnitario, NULL)
                                  FROM      DELETED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(PrecioUnitario, NULL)
                                  FROM      INSERTED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(RevisarMensualmente, NULL)
                                  FROM      DELETED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(RevisarMensualmente, NULL)
                                  FROM      INSERTED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                        FROM    @tablaInserted t
                        WHERE   Renglon = @n
                SET @n = @n + 1
            END  
        SET @n = 1
        WHILE @n <= @cuantosDeleted 
            BEGIN
                INSERT  dbo.Hist_RenglonesFacturaProforma
                        ( 
                         Fecha
                        ,idRenglonFacturaProforma
                        ,idContrato_anterior
                        ,idContrato_nuevo
                        ,idPlan_anterior
                        ,idPlan_nuevo
                        ,Cantidad_anterior
                        ,Cantidad_nuevo
                        ,PrecioUnitario_anterior
                        ,PrecioUnitario_nuevo
                        ,RevisarMensualmente_anterior
                        ,RevisarMensualmente_nuevo
                        )
                        SELECT  GETDATE()
                               ,idRenglonFacturaProforma
                               ,( SELECT    ISNULL(idContrato, NULL)
                                  FROM      DELETED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(idContrato, NULL)
                                  FROM      INSERTED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(idPlan, NULL)
                                  FROM      DELETED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(idPlan, NULL)
                                  FROM      INSERTED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(Cantidad, NULL)
                                  FROM      DELETED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(Cantidad, NULL)
                                  FROM      INSERTED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(PrecioUnitario, NULL)
                                  FROM      DELETED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(PrecioUnitario, NULL)
                                  FROM      INSERTED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(RevisarMensualmente, NULL)
                                  FROM      DELETED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                               ,( SELECT    ISNULL(RevisarMensualmente, NULL)
                                  FROM      INSERTED
                                  WHERE     idRenglonFacturaProforma = t.idRenglonFacturaProforma
                                )
                        FROM    @tablaDeleted t
                        WHERE   Renglon = @n
                SET @n = @n + 1
            END                 
    END

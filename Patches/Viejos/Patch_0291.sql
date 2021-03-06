USE [Datos]
GO
/****** Object:  Trigger [dbo].[Hist_RenglonesDeFactura]    Script Date: 03/13/2014 11:20:13 ******/
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
        DECLARE @tabla TABLE
            (
             Renglon INT IDENTITY(1, 1)
            ,idRenglonFacturaProforma INT
            )
        DECLARE @cuantos INT
           ,@n INT = 1
        INSERT  @tabla
                ( 
                 idRenglonFacturaProforma 
                )
                SELECT  idRenglonFacturaProforma
                FROM    INSERTED
        SET @cuantos = @@ROWCOUNT
        WHILE @n <= @cuantos 
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
                        FROM    @tabla t
                        WHERE   Renglon = @n
                SET @n = @n + 1
            END                
    END

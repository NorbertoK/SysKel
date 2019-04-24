
USE [Datos]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE TRIGGER dbo.Trigger_Hist_Planes ON dbo.Planes
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
            ,idPlan INT
            )
        DECLARE @cuantosInserted INT
           ,@n INT
        DECLARE @tablaDeleted TABLE
            (
             Renglon INT IDENTITY(1, 1)
            ,idPlan INT
            )
        DECLARE @cuantosDeleted INT   
        INSERT  @tablaInserted
                ( idPlan )
                SELECT  idPlan
                FROM    INSERTED
        SET @cuantosInserted = @@ROWCOUNT
        INSERT  @tablaDeleted
                ( 
                 idPlan 
                )
                SELECT  idPlan
                FROM    DELETED d
                WHERE   NOT EXISTS ( SELECT *
                                     FROM   @tablaInserted
                                     WHERE  idPlan = d.idPlan )
        SET @cuantosDeleted = @@ROWCOUNT
        SET @n = 1
        WHILE @n <= @cuantosInserted 
            BEGIN
                INSERT  dbo.Hist_Planes
                        ( 
                         Fecha
                        ,idPlan
                        ,Nombre_anterior
                        ,Nombre_nuevo
                        ,Iniciales_anterior
                        ,Iniciales_nuevo
                        ,idCotrato_anterior
                        ,idContrato_nuevo
                        ,Cuota_anterior
                        ,Cuota_nuevo
                        ,Activo_anterior
                        ,Activo_nuevo
                        ,PadronExterno_anterior
                        ,PadronExterno_nuevo
                        ,idProteccion_anterior
                        ,idProteccion_nuevo
                        ,CuotaAdherente_anterior
                        ,CuotaAdherente_nuevo
                        ,idPrepago_anterior
                        ,idPrepago_nuevo
				        
                        )
                        SELECT  GETDATE()
                               ,idPlan
                               ,( SELECT    ISNULL(Nombre, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(Nombre, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(Iniciales, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(Iniciales, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(idContrato, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(idContrato, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(Cuota, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(Cuota, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(Activo, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(Activo, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(PadronExterno, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(PadronExterno, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(idProteccion, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(idProteccion, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(CuotaAdherente, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(CuotaAdherente, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(idPrepago, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(idPrepago, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                        FROM    @tablaInserted t
                        WHERE   Renglon = @n
                SET @n = @n + 1
            END
        SET @n = 1
        WHILE @n <= @cuantosDeleted 
            BEGIN
                INSERT  dbo.Hist_Planes
                        ( 
                         Fecha
                        ,idPlan
                        ,Nombre_anterior
                        ,Nombre_nuevo
                        ,Iniciales_anterior
                        ,Iniciales_nuevo
                        ,idCotrato_anterior
                        ,idContrato_nuevo
                        ,Cuota_anterior
                        ,Cuota_nuevo
                        ,Activo_anterior
                        ,Activo_nuevo
                        ,PadronExterno_anterior
                        ,PadronExterno_nuevo
                        ,idProteccion_anterior
                        ,idProteccion_nuevo
                        ,CuotaAdherente_anterior
                        ,CuotaAdherente_nuevo
                        ,idPrepago_anterior
                        ,idPrepago_nuevo
				        
                        )
                        SELECT  GETDATE()
                               ,idPlan
                               ,( SELECT    ISNULL(Nombre, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(Nombre, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(Iniciales, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(Iniciales, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(idContrato, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(idContrato, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(Cuota, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(Cuota, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(Activo, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(Activo, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(PadronExterno, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(PadronExterno, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(idProteccion, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(idProteccion, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(CuotaAdherente, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(CuotaAdherente, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(idPrepago, NULL)
                                  FROM      DELETED
                                  WHERE     idPlan = t.idPlan
                                )
                               ,( SELECT    ISNULL(idPrepago, NULL)
                                  FROM      INSERTED
                                  WHERE     idPlan = t.idPlan
                                )
                        FROM    @tablaDeleted t
                        WHERE   Renglon = @n
                SET @n = @n + 1
            END
    END
GO

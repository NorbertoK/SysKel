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
CREATE TRIGGER dbo.Trigger_Hist_Recursos ON dbo.Recursos
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
            ,idRecurso INT
            )
        DECLARE @cuantosInserted INT
           ,@n INT
        DECLARE @tablaDeleted TABLE
            (
             Renglon INT IDENTITY(1, 1)
            ,idRecurso INT
            )
        DECLARE @cuantosDeleted INT   
        INSERT  @tablaInserted
                ( idRecurso )
                SELECT  idRecurso
                FROM    INSERTED
        SET @cuantosInserted = @@ROWCOUNT
        INSERT  @tablaDeleted
                ( 
                 idRecurso 
                )
                SELECT  idRecurso
                FROM    DELETED d
                WHERE   NOT EXISTS ( SELECT *
                                     FROM   @tablaInserted
                                     WHERE  idRecurso = d.idRecurso )
        SET @cuantosDeleted = @@ROWCOUNT
        SET @n = 1
        WHILE @n <= @cuantosInserted 
            BEGIN
                INSERT  dbo.Hist_Recursos
                        ( 
                         Fecha
                        ,idRecurso
                        ,Nombre_anterior
                        ,Nombre_nuevo
                        ,idMovil_anterior
                        ,idMovil_nuevo
                        ,idMedico_anterior
                        ,idMedico_nuevo
                        ,idMedico2_anterior
                        ,idMedico2_nuevo
                        ,idParamedico_anterior
                        ,IdParamedico_nuevo
                        ,idParamedico2_anterior
                        ,idParamedico2_nuevo
                        ,idChofer_anterior
                        ,idChofer_nuevo
                        ,idChofer2_anterior
                        ,idChofer2_nuevo
                        ,Activo_anterior
                        ,Activo_nuevo
                        ,Observaciones_anterior
                        ,Observaciones_nuevo
                        )
                        SELECT  GETDATE()
                               ,idRecurso
                               ,( SELECT    ISNULL(Nombre, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(Nombre, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idMovil, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idMovil, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idMedico, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idMedico, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idMedico2, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idMedico2, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idParamedico, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idParamedico, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idParamedico2, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idParamedico2, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idChofer, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idChofer, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idChofer2, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idChofer2, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(Activo, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(Activo, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(Observaciones, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(Observaciones, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                        FROM    @tablaInserted t
                        WHERE   Renglon = @n
                SET @n = @n + 1
            END  
        SET @n = 1
        WHILE @n <= @cuantosDeleted 
            BEGIN
                INSERT  dbo.Hist_Recursos
                        ( 
                         Fecha
                        ,idRecurso
                        ,Nombre_anterior
                        ,Nombre_nuevo
                        ,idMovil_anterior
                        ,idMovil_nuevo
                        ,idMedico_anterior
                        ,idMedico_nuevo
                        ,idMedico2_anterior
                        ,idMedico2_nuevo
                        ,idParamedico_anterior
                        ,IdParamedico_nuevo
                        ,idParamedico2_anterior
                        ,idParamedico2_nuevo
                        ,idChofer_anterior
                        ,idChofer_nuevo
                        ,idChofer2_anterior
                        ,idChofer2_nuevo
                        ,Activo_anterior
                        ,Activo_nuevo
                        ,Observaciones_anterior
                        ,Observaciones_nuevo
                        )
                        SELECT  GETDATE()
                               ,idRecurso
                               ,( SELECT    ISNULL(Nombre, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(Nombre, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idMovil, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idMovil, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idMedico, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idMedico, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idMedico2, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idMedico2, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idParamedico, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idParamedico, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idParamedico2, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idParamedico2, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idChofer, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idChofer, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idChofer2, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(idChofer2, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(Activo, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(Activo, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(Observaciones, NULL)
                                  FROM      DELETED
                                  WHERE     idRecurso = t.idRecurso
                                )
                               ,( SELECT    ISNULL(Observaciones, NULL)
                                  FROM      INSERTED
                                  WHERE     idRecurso = t.idRecurso
                                )
                        FROM    @tablaDeleted t
                        WHERE   Renglon = @n
                SET @n = @n + 1
            END
    END
GO

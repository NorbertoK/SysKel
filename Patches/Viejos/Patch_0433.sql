/*
   martes, 31 de marzo de 201502:49:30 p.m.
   User: 
   Server: Norberto
   Database: Datos
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RenglonesFacturaProforma
	DROP CONSTRAINT FK_RenglonesFacturaProforma_Planes
GO
ALTER TABLE dbo.Planes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Planes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Planes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Planes', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.RenglonesFacturaProforma
	DROP CONSTRAINT FK_RenglonesFacturaProforma_Contratos
GO
ALTER TABLE dbo.Contratos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Contratos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Contratos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Contratos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.RenglonesFacturaProforma
	DROP CONSTRAINT FK_RenglonesFacturaProforma_FacturasProforma
GO
ALTER TABLE dbo.FacturasProforma SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.FacturasProforma', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.FacturasProforma', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.FacturasProforma', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_RenglonesFacturaProforma
	(
	idRenglonFacturaProforma int NOT NULL IDENTITY (1, 1),
	idFacturaProforma int NULL,
	idContrato int NULL,
	idPlan int NULL,
	Cantidad int NULL,
	PrecioUnitario money NULL,
	RevisarMensualmente bit NULL,
	Titulares bit NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_RenglonesFacturaProforma SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_RenglonesFacturaProforma ON
GO
IF EXISTS(SELECT * FROM dbo.RenglonesFacturaProforma)
	 EXEC('INSERT INTO dbo.Tmp_RenglonesFacturaProforma (idRenglonFacturaProforma, idFacturaProforma, idContrato, idPlan, Cantidad, PrecioUnitario, RevisarMensualmente, Titulares)
		SELECT idRenglonFacturaProforma, idFacturaProforma, idContrato, idPlan, Cantidad, PrecioUnitario, RevisarMensualmente, CONVERT(bit, CuotaAdherente) FROM dbo.RenglonesFacturaProforma WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_RenglonesFacturaProforma OFF
GO
DROP TABLE dbo.RenglonesFacturaProforma
GO
EXECUTE sp_rename N'dbo.Tmp_RenglonesFacturaProforma', N'RenglonesFacturaProforma', 'OBJECT' 
GO
ALTER TABLE dbo.RenglonesFacturaProforma ADD CONSTRAINT
	PK_RenglonesFacturaProforma PRIMARY KEY CLUSTERED 
	(
	idRenglonFacturaProforma
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.RenglonesFacturaProforma ADD CONSTRAINT
	FK_RenglonesFacturaProforma_FacturasProforma FOREIGN KEY
	(
	idFacturaProforma
	) REFERENCES dbo.FacturasProforma
	(
	idFacturaProforma
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.RenglonesFacturaProforma ADD CONSTRAINT
	FK_RenglonesFacturaProforma_Contratos FOREIGN KEY
	(
	idContrato
	) REFERENCES dbo.Contratos
	(
	idContrato
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.RenglonesFacturaProforma ADD CONSTRAINT
	FK_RenglonesFacturaProforma_Planes FOREIGN KEY
	(
	idPlan
	) REFERENCES dbo.Planes
	(
	idPlan
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE TRIGGER [dbo].[Hist_RenglonesDeFactura] ON dbo.RenglonesFacturaProforma
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
GO
COMMIT
select Has_Perms_By_Name(N'dbo.RenglonesFacturaProforma', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.RenglonesFacturaProforma', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.RenglonesFacturaProforma', 'Object', 'CONTROL') as Contr_Per 
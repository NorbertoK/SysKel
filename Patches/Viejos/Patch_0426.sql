/*
   martes, 24 de febrero de 201512:14:00 p.m.
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
CREATE TABLE dbo.CargosEmpleados
	(
	idCargoEmpleado int NOT NULL IDENTITY (1, 1),
	idEmpleado int NOT NULL,
	idCargo int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.CargosEmpleados ADD CONSTRAINT
	PK_CargosEmpleados PRIMARY KEY CLUSTERED 
	(
	idCargoEmpleado
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.CargosEmpleados SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CargosEmpleados', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CargosEmpleados', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CargosEmpleados', 'Object', 'CONTROL') as Contr_Per 
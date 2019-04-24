UPDATE [Datos].[dbo].[Planes]
   SET [Cuota] = 102
      ,[CuotaAdherente] = 47
 WHERE idContrato IS NULL
GO

INSERT INTO [Datos].[dbo].[Planes]
           ([Nombre]
           ,[Iniciales]
           ,[idContrato]
           ,[Cuota]
           ,[Activo]
           ,[PadronExterno]
           ,[idProteccion]
           ,[CuotaAdherente])
     VALUES
           ('Honorario'
           ,'H'
           ,NULL
           ,0
           ,1
           ,0
           ,1
           ,0)
GO


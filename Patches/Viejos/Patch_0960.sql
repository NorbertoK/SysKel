USE [Datos]
GO

/****** Object:  StoredProcedure [dbo].[NdeCManual]    Script Date: 12/25/2018 13:32:12 ******/
IF EXISTS ( SELECT  *
            FROM    sys.objects
            WHERE   object_id = OBJECT_ID(N'[dbo].[NdeCManual]')
                    AND type IN ( N'P', N'PC' ) ) 
    DROP PROCEDURE [dbo].[NdeCManual]
GO


USE [Datos]
GO

/****** Object:  StoredProcedure [dbo].[NdeDManual]    Script Date: 12/25/2018 13:33:44 ******/
IF EXISTS ( SELECT  *
            FROM    sys.objects
            WHERE   object_id = OBJECT_ID(N'[dbo].[NdeDManual]')
                    AND type IN ( N'P', N'PC' ) ) 
    DROP PROCEDURE [dbo].[NdeDManual]
GO


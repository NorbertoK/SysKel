USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[TelefonosDelAfiliado]    Script Date: 11/24/2013 18:47:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Norberto Kelijman
-- Create date: 
-- Description:	
-- =============================================
ALTER FUNCTION [dbo].[TelefonosDelAfiliado] ( -- Add the parameters for the function here
                                              @idAfiliado INT )
RETURNS VARCHAR(MAX)
AS 
    BEGIN
        DECLARE @Result VARCHAR(MAX)
        DECLARE @cantTel INT
        DECLARE @n INT
        SET @n = 1

        DECLARE @tabla TABLE
            (
             Renglon INT IDENTITY(1, 1)
            ,Numero VARCHAR(20)
            )
        INSERT  @tabla
                SELECT  t.Numero
                FROM    dbo.Telefonos t
                WHERE   t.idAfiliado = @idAfiliado
                        OR t.idDireccion = CASE WHEN ( SELECT   COUNT(*)
                                                       FROM     dbo.Direcciones
                                                       WHERE    idAfiliado = @idAfiliado
                                                     ) = 0 THEN ( SELECT    idDireccion
                                                                  FROM      dbo.Direcciones
                                                                  WHERE     idGrupo = ( SELECT  idGrupo
                                                                                        FROM    dbo.Afiliados
                                                                                        WHERE   idAfiliado = @idAfiliado
                                                                                      )
                                                                )
                                                ELSE ( SELECT   idDirección
                                                       FROM     dbo.Direcciones
                                                       WHERE    idAfiliado = @idAfiliado
                                                     )
                                           END
                        
        SET @cantTel = @@ROWCOUNT
        IF @cantTel = 0 RETURN ''
        WHILE @n <= @cantTel 
            BEGIN
                IF @n = 1 
                    SELECT  @Result = Numero
                    FROM    @tabla
                    WHERE   Renglon = @n
                ELSE 
                    SELECT  @Result = @Result + ' | ' + Numero
                    FROM    @tabla
                    WHERE   Renglon = @n
                SET @n = @n + 1
            END

        RETURN @Result

    END

USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[BuscarAfiliados]    Script Date: 11/14/2013 13:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[BuscarAfiliados] ( @frase VARCHAR(1000) )
AS 
    SET NOCOUNT ON
    DECLARE @PlanesAfiliados TABLE
        (
         idAfiliado INT
        ,idPlan INT
        ,Estado VARCHAR(20)
        ) 
    DECLARE @idAfiliado INT
    DECLARE @registros INT
    DECLARE @n INT
    DECLARE @hoy DATETIME
    SET @hoy = GETDATE()
    DECLARE @sql VARCHAR(1000)
    SET @sql = 'SELECT idAfiliado FROM dbo.Afiliados WHERE ' + @frase
    DECLARE @AfiliadosCondicion TABLE
        (
         renglon INT IDENTITY(1, 1)
        ,idAfiliado INT
        )
    INSERT  @AfiliadosCondicion
            EXEC ( @sql
                )
    SET @registros = @@ROWCOUNT
    SET @n = 1
    WHILE @n <= @registros 
        BEGIN
            SELECT  @idAfiliado = idAfiliado
            FROM    @AfiliadosCondicion
            WHERE   renglon = @n
            INSERT  @PlanesAfiliados
                    EXEC dbo.EstadoDelAfiliado @idAfiliado
            SET @n = @n + 1
        END
    SELECT  af.idGrupo idGrupo
           ,ISNULL(af.Apellido, '') + ', ' + ISNULL(af.Nombre, '') Nombre
           ,tc.Iniciales TipoDoc
           ,af.NumeroDeDocumento NroDoc
           ,pl.Nombre nPlan
           ,pl.Iniciales iniPlan
           ,pl.idPlan
           ,pa.Estado Estado
           ,pa.idAfiliado idAfiliado
           ,pl.idContrato
           ,dbo.DireccionCompleta(dbo.DireccionRealDelAfiliado(af.idAfiliado)) Direccion
           ,dbo.EdadCompleta(af.FechaDeNacimiento, @hoy) Edad
           ,dbo.DireccionRealDelAfiliado(af.idAfiliado) idDireccion
    FROM    @PlanesAfiliados pa
    JOIN    dbo.Afiliados af ON ( af.idAfiliado = pa.idAfiliado )
    LEFT JOIN dbo.Planes pl ON ( pl.idPlan = pa.idPlan )
    LEFT JOIN dbo.TiposDeDocumento tc ON ( tc.idTipoDeDocumento = af.idTipoDeDocumento )









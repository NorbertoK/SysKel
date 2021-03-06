USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[BuscarAfiliados]    Script Date: 10/21/2013 14:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[BuscarAfiliados] ( @frase varchar(1000) )
AS 
    SET NOCOUNT ON
    DECLARE @PlanesAfiliados table
        (
          idAfiliado int,
          idPlan int,
          Estado varchar(20)
        ) 
    DECLARE @idAfiliado int
    DECLARE @registros int
    DECLARE @n int
    DECLARE @hoy datetime
    SET @hoy = GETDATE()
    DECLARE @sql varchar(1000)
    SET @sql = 'SELECT idAfiliado FROM dbo.Afiliados WHERE ' + @frase
    DECLARE @AfiliadosCondicion table
        (
          renglon int IDENTITY(1, 1),
          idAfiliado int
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
    SELECT  af.idGrupo idGrupo,
            ISNULL(af.Apellido, '') + ', ' + ISNULL(af.Nombre, '') Nombre,
            tc.Iniciales TipoDoc,
            af.NumeroDeDocumento NroDoc,
            pl.Nombre nPlan,
            pl.Iniciales iniPlan,
            pl.idPlan,
            pa.Estado Estado,
            pa.idAfiliado idAfiliado,
            pl.idContrato,
            dbo.DireccionCompleta(dbo.DireccionRealDelAfiliado(af.idAfiliado)) Direccion,
            dbo.EdadCompleta(af.FechaDeNacimiento, @hoy) Edad
    FROM    @PlanesAfiliados pa
            JOIN dbo.Afiliados af on ( af.idAfiliado = pa.idAfiliado )
            LEFT JOIN dbo.Planes pl on ( pl.idPlan = pa.idPlan )
            LEFT JOIN dbo.TiposDeDocumento tc on ( tc.idTipoDeDocumento = af.idTipoDeDocumento )









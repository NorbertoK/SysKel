USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[EfectivoEnCaja]    Script Date: 12/15/2016 14:33:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[EfectivoEnCaja] @idEmpleado INT
AS 
    BEGIN
        SET NOCOUNT ON;
        SELECT  ISNULL(SUM(Importe), 0)
        FROM    dbo.ValoresRemesas vr
        JOIN dbo.TiposDeValores tv ON vr.idTipoDeValor = tv.idTipoDeValor
        WHERE   idEmpleado = @idEmpleado
                AND tv.EsEfectivo = 1
    END


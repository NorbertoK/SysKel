USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ImportarDatosCAE]    Script Date: 02/04/2019 10:47:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ImportarDatosCAE]
    @proceso VARCHAR(255) = 0
AS 
    BEGIN
        SET NOCOUNT ON;
        UPDATE  dbo.Comprobantes
        SET     idTipoDeComprobante = ic.idTipoDeComprobante
               ,Prefijo = ic.Prefijo
               ,NumeroDeComprobante = ic.NumeroDeComprobante
               ,CAE = ic.CAE
               ,Fecha = ic.Fecha
        FROM    dbo.Comprobantes comp
                JOIN dbo.ImportarCAE ic ON comp.idComprobante = ic.idComprobante
                WHERE ic.Proceso = @proceso
                DELETE dbo.ImportarCAE WHERE Proceso = @proceso
    END

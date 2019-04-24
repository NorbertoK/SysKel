-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE ReporteRubrosNegocios 
	-- Add the parameters for the stored procedure here
    @desde VARCHAR(8) = ''
   ,@hasta VARCHAR(8) = ''
AS 
    BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
        SET NOCOUNT ON ;

    -- Insert statements for procedure here
        SELECT  rub.Código + ' ' + rub.Nombre Rubro
               ,neg.Nombre Negocio
               ,SUM(pago.Importe * nc.Porcentaje / 100) Importe
        FROM    dbo.Compras pago
        JOIN    compras comp ON pago.idReferencia = comp.idCompra
        JOIN    dbo.NegociosCompras nc ON comp.idCompra = nc.idCompra
        JOIN    dbo.Rubros rub ON comp.idRubro = rub.idRubro
        JOIN    dbo.Negocios neg ON nc.idNegocio = neg.idNegocio
        WHERE   pago.Fecha BETWEEN @desde AND dbo.Medianoche(@hasta)
                AND pago.idTipoDeComprobante = ( SELECT TOP 1
                                                        Pago
                                                 FROM   dbo.Sistemas
                                               )
        GROUP BY rub.Código + ' ' + rub.Nombre
               ,neg.Nombre
               ,neg.Orden
        ORDER BY rub.Código + ' ' + rub.Nombre
               ,neg.Orden
    END
GO

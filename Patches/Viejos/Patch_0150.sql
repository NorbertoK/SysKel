USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ReporteRubrosNegocios]    Script Date: 08/26/2013 09:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
ALTER PROCEDURE [dbo].[ReporteRubrosNegocios] 
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
               ,neg.Orden Orden
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

USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[PeriodoAFacturarClientes]    Script Date: 12/20/2013 18:04:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[PeriodoAFacturarClientes]
    (
     @idFacturaProforma INT 
    )
RETURNS VARCHAR(7)
AS 
    BEGIN
        DECLARE @Result VARCHAR(7)
        DECLARE @ultimoPeriodoAnyoYMesFacturado VARCHAR(7)
        DECLARE @fechaInicioPrimerContrato DATE
        DECLARE @dia INT
        DECLARE @primerPeriodoFuturo VARCHAR(7)
        SELECT TOP 1
                @dia = DesdeDiaRegaloMes
        FROM    dbo.Parametros
    
        SET @ultimoPeriodoAnyoYMesFacturado = ( SELECT  MAX(dbo.PeriodoAnyoMes(c.Periodo))
                                                FROM    dbo.Comprobantes c
                                                WHERE   c.idFacturaProforma = @idFacturaProforma
                                                        AND c.idTipoDeComprobante IN ( SELECT   idTipoDeComprobante
                                                                                       FROM     dbo.TiposDeComprobante
                                                                                       WHERE    EsFactura = 1 )
                                              )
        IF @ultimoPeriodoAnyoYMesFacturado IS NULL 
            BEGIN
                SELECT  @fechaInicioPrimerContrato = MIN(s.Fecha)
                FROM    dbo.FacturasProforma fp
                JOIN    dbo.RenglonesFacturaProforma rfp ON fp.idFacturaProforma = rfp.idFacturaProforma
                JOIN    dbo.Solicitudes s ON rfp.idContrato = s.idContrato
                WHERE   fp.idFacturaProforma = @idFacturaProforma
                SET @Result = dbo.PeriodoSumarMeses(dbo.PeriodoDeUnaFecha(@fechaInicioPrimerContrato), CASE WHEN DAY(@fechaInicioPrimerContrato) < @dia THEN 1
                                                                                                            ELSE 2
                                                                                                       END)
            END
        ELSE 
            BEGIN
                SELECT  @Result = dbo.PeriodoSiguiente(SUBSTRING(@ultimoPeriodoAnyoYMesFacturado, 6, 2) + '/' + SUBSTRING(@ultimoPeriodoAnyoYMesFacturado, 1, 4))
            END
        SET @primerPeriodoFuturo = dbo.PeriodoSumarMeses(dbo.PeriodoDeUnaFecha(GETDATE()), 1)
        IF dbo.PeriodoAnyoMes(@Result) < dbo.PeriodoAnyoMes(@primerPeriodoFuturo) 
            SET @Result = @primerPeriodoFuturo
        RETURN @Result
    END

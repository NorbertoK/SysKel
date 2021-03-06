USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[PeriodoAFacturarAfiliados]    Script Date: 06/25/2014 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[PeriodoAFacturarAfiliados] ( @idGrupo INT )
RETURNS VARCHAR(7)
AS 
    BEGIN
        DECLARE @Result VARCHAR(7)
        DECLARE @ultimoPeriodoAnyoYMesFacturado VARCHAR(7)
        DECLARE @fechaInicioGrupo DATE
        DECLARE @dia INT
        DECLARE @primerPeriodoFuturo VARCHAR(7)
        SELECT TOP 1
                @dia = DesdeDiaRegaloMes
        FROM    dbo.Parametros
        SET @ultimoPeriodoAnyoYMesFacturado = ( SELECT  MAX(dbo.PeriodoAnyoMes(c.Periodo))
                                                FROM    dbo.Comprobantes c
                                                WHERE   c.idGrupo = @idGrupo
                                                        AND Anulado = 0
                                                        AND c.idTipoDeComprobante IN ( SELECT   idTipoDeComprobante
                                                                                       FROM     dbo.TiposDeComprobante
                                                                                       WHERE    EsFactura = 1 )
                                              )
        IF @ultimoPeriodoAnyoYMesFacturado IS NULL 
            BEGIN
                SELECT  @fechaInicioGrupo = MIN(s.Fecha)
                FROM    dbo.Solicitudes s
                JOIN    dbo.Afiliados af ON s.idAfiliado = af.idAfiliado
                WHERE   af.idGrupo = @idGrupo
                SET @Result = dbo.PeriodoSumarMeses(dbo.PeriodoDeUnaFecha(@fechaInicioGrupo), CASE WHEN DAY(@fechaInicioGrupo) < @dia THEN 0
                                                                                                   ELSE 1
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

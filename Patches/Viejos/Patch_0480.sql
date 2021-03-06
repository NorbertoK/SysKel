
/****** Object:  UserDefinedFunction [dbo].[PeriodoAFacturarAfiliados]    Script Date: 07/01/2015 10:59:24 ******/
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
        IF dbo.RestaPeriodos(@Result,dbo.PeriodoDeUnaFecha(GETDATE())) <0 
            SET @Result = dbo.PeriodoDeUnaFecha(GETDATE())
        RETURN @Result
    END

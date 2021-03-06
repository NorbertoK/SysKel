USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[MotivoRetenerComprobanteArqueo]    Script Date: 12/20/2013 18:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[MotivoRetenerComprobanteArqueo] ( @idComprobante INT )
RETURNS VARCHAR(100)
AS 
    BEGIN
        DECLARE @fecha DATETIME
        SET @fecha = GETDATE()
        DECLARE @activo INT
        DECLARE @mesesPorCobrar INT
        DECLARE @mesesPermitidos INT
        DECLARE @motivoSaldoCero INT
        DECLARE @motivoBaja INT
        DECLARE @saldo MONEY
        SELECT TOP ( 1 )
                @motivoSaldoCero = MotivoDevolucionCobranza_SaldoCero
               ,@motivoBaja = MotivoDevolucionCobranza_Baja
        FROM    Sistemas
        SELECT  @activo = CASE WHEN ( SELECT    idGrupo
                                      FROM      dbo.Comprobantes
                                      WHERE     idComprobante = @idComprobante
                                    ) IS NOT NULL THEN dbo.HayAlgunAfiliadoActivo(( SELECT  idGrupo
                                                                                    FROM    dbo.Comprobantes
                                                                                    WHERE   idComprobante = @idComprobante
                                                                                  ), @fecha)
                               WHEN ( SELECT    idCliente
                                      FROM      dbo.Comprobantes
                                      WHERE     idComprobante = @idComprobante
                                    ) IS NOT NULL THEN dbo.HayAlgunContratoActivo(( SELECT  idCliente
                                                                                    FROM    dbo.Comprobantes
                                                                                    WHERE   idComprobante = @idComprobante
                                                                                  ), @fecha)
                               ELSE 1
                          END
        IF @activo = 0 
            RETURN RIGHT('00000000' + CAST(@motivoBaja AS VARCHAR(8)), 8)
            + 'Retener: Baja'
        SELECT  @saldo = saldo
        FROM    dbo.Comprobantes
        WHERE   idComprobante = @idComprobante
        IF @saldo = 0 
            RETURN RIGHT('00000000' + CAST(@motivoSaldoCero AS VARCHAR(8)), 8)
            + 'Retener: Pagado'
        RETURN '00000000' + 'Vuelve al Cobrador'
    END

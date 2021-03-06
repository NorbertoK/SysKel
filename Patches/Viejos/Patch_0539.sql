USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[MensajeRemesa]    Script Date: 09/28/2015 20:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[MensajeRemesa]
    (
     -- Add the parameters for the function here
     @idComprobante INT
    ,@idCobradorOrig INT
    ,@idEntidadOrig INT
    )
RETURNS VARCHAR(200)
AS 
    BEGIN
	-- Declare the return variable here
        DECLARE @Result VARCHAR(200)
        SET @Result = ''

	-- Add the T-SQL statements to compute the return value here
        IF ( SELECT COUNT(*)
             FROM   dbo.Comprobantes
             WHERE  idComprobante = @idComprobante
           ) = 0 
            SET @Result = 'No existe en la Base de Datos.'
        ELSE -- Existe en la Base de Datos
            IF ( @idCobradorOrig != 0 ) -- Rendición de un cobrador
                IF ( SELECT idCobrador
                     FROM   dbo.Comprobantes
                     WHERE  idComprobante = @idComprobante
                   ) IS NULL 
                    IF ( SELECT idEntidadDeCobranza
                         FROM   dbo.Comprobantes
                         WHERE  idComprobante = @idComprobante
                       ) IS NULL 
                        SET @Result = 'No tiene cobrador.'
                    ELSE 
                        SET @Result = 'Se cobra por '
                            + ( SELECT  ec.Nombre
                                FROM    dbo.Comprobantes comp
                                        JOIN dbo.EntidadesDeCobranza ec ON comp.idEntidadDeCobranza = ec.idEntidadDeCobranza
                                WHERE   comp.idComprobante = @idComprobante
                              )
                ELSE 
                    IF ( SELECT idCobrador
                         FROM   dbo.Comprobantes
                         WHERE  idComprobante = @idComprobante
                       ) <> @idCobradorOrig 
                        SET @Result = 'Es del cobrador '
                            + ( SELECT  emp.NombApel
                                FROM    dbo.Comprobantes comp
                                        JOIN dbo.Empleados emp ON emp.idEmpleado = comp.idCobrador
                                WHERE   comp.idComprobante = @idComprobante
                              )
                            + CASE WHEN ( SELECT    fac.EntregadaAlCobrador
                                          FROM      dbo.Comprobantes comp
                                                    JOIN dbo.Facturaciones fac ON comp.idFacturacion = fac.idFacturacion
                                          WHERE     comp.idComprobante = @idComprobante
                                        ) IS NULL THEN ' y no se le entregó,'
                                   ELSE '.'
                              END
                    ELSE 
                        BEGIN 
                            IF ( SELECT fac.EntregadaAlCobrador
                                 FROM   dbo.Comprobantes comp
                                        JOIN dbo.Facturaciones fac ON comp.idFacturacion = fac.idFacturacion
                                 WHERE  comp.idComprobante = @idComprobante
                               ) IS NULL 
                                SET @Result = 'No fue entregado al cobrador.'
                        END  
            ELSE -- Rendición de una Entidad de Cobranza
                IF ( SELECT idEntidadDeCobranza
                     FROM   dbo.Comprobantes
                     WHERE  idComprobante = @idComprobante
                   ) IS NULL -- No tiene Entidad de Cobranza
                    IF ( SELECT idCobrador
                         FROM   dbo.Comprobantes
                         WHERE  idComprobante = @idComprobante
                       ) IS NULL -- No tiene Cobrador
                        SET @Result = 'No tiene Entidad de Cobranza.'
                    ELSE -- Tiene Cobrador
                        SET @Result = 'Es del cobrador '
                            + ( SELECT  emp.NombApel
                                FROM    dbo.Comprobantes comp
                                        JOIN dbo.Empleados emp ON emp.idEmpleado = comp.idCobrador
                                WHERE   comp.idComprobante = @idComprobante
                              )
                            + CASE WHEN ( SELECT    fac.EntregadaAlCobrador
                                          FROM      dbo.Comprobantes comp
                                                    JOIN dbo.Facturaciones fac ON comp.idFacturacion = fac.idFacturacion
                                          WHERE     comp.idComprobante = @idComprobante
                                        ) IS NULL THEN ' y no se le entregó,'
                                   ELSE '.'
                              END
                ELSE 
                    IF ( SELECT idEntidadDeCobranza
                         FROM   dbo.Comprobantes
                         WHERE  idComprobante = @idComprobante
                       ) <> @idEntidadOrig -- Es de otra Entidad de Cobranza
                        SET @Result = 'Se cobra por '
                            + ( SELECT  ec.Nombre
                                FROM    dbo.Comprobantes comp
                                        JOIN dbo.EntidadesDeCobranza ec ON comp.idEntidadDeCobranza = ec.idEntidadDeCobranza
                                WHERE   comp.idComprobante = @idComprobante
                              )
                    

	-- Return the result of the function
        RETURN @Result

    END

-- ================================================
-- Template generated from Template Explorer using:
-- Create Scalar Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION EsBanco ( @idEmpleado INT )
RETURNS BIT
AS 
    BEGIN
        DECLARE @Result BIT = 0
        IF EXISTS ( SELECT  *
                    FROM    dbo.Empleados emp
                            JOIN dbo.CargosEmpleados cemp ON emp.idEmpleado = cemp.idEmpleado
                            JOIN dbo.Cargos c ON cemp.idCargo = c.idCargo
                    WHERE   emp.idEmpleado = @idEmpleado
                            AND c.Nombre = 'Banco' )
                            SET @Result = 1
            RETURN @Result
    END
GO


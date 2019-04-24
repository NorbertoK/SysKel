SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION CajasConSaldoOBanco ( )
RETURNS @Tabla TABLE ( idEmpleado INT )
AS 
    BEGIN
        DECLARE @provi TABLE ( idEmpleado INT )
        INSERT  @provi
                SELECT  emp.idEmpleado
                FROM    dbo.ValoresRemesas vr
                        JOIN dbo.Empleados emp ON emp.idEmpleado = vr.idEmpleado
                        LEFT JOIN dbo.TiposDeValores tv ON tv.idTipoDeValor = vr.idTipoDeValor
                WHERE   tv.EsEfectivo = 0
                        AND EntregadoIdTransferencia IS NULL
                        AND EntregadoIdRetiro IS NULL
                        AND EntregadoIdOrdenDePago IS NULL
                UNION ALL
                SELECT  vr.idEmpleado
                FROM    dbo.ValoresRemesas vr
                        JOIN dbo.TiposDeValores tv ON vr.idTipoDeValor = tv.idTipoDeValor
                WHERE   tv.EsEfectivo = 1
                GROUP BY vr.idEmpleado
                HAVING  SUM(vr.Importe) != 0
                UNION ALL
                SELECT  idEmpleado
                FROM    dbo.Empleados
                WHERE   dbo.EsBanco(idEmpleado) = 1
        INSERT  @tabla
                SELECT  DISTINCT
                        idEmpleado
                FROM    @provi
	
        RETURN 
    END
GO
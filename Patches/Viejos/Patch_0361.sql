SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE BuscarTurnos 
	@frase varchar(1000)
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @sql VARCHAR(1000) = 'SELECT  Turnos.Hora
       ,Turnos.NumeroDeDocumento
       ,Turnos.ApelNomb
       ,Turnos.Telefono
       ,Turnos.Observaciones
       ,Turnos.Solicitado
       ,Turnos.Cancelado
       ,Empleados.ApelNomb AS Medico
       ,TiposDeDocumento.Iniciales AS TipoDeDocumento
       ,Usuarios.Iniciales AS Tomador
       ,Turnos.Dia
FROM    Turnos
INNER JOIN Empleados ON Turnos.idEmpleado = Empleados.idEmpleado
LEFT OUTER JOIN TiposDeDocumento ON Turnos.idTipoDeDocumento = TiposDeDocumento.idTipoDeDocumento
LEFT OUTER JOIN Usuarios ON Empleados.idEmpleado = Usuarios.idEmpleado
WHERE ' + @frase
EXEC (@sql)
END
GO

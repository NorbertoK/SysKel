IF ( SELECT Apellido
     FROM   dbo.Empleados
     WHERE  idEmpleado = 1
   ) = 'Ruiz' 
    BEGIN
        UPDATE  dbo.Grupos
        SET     idCategoriaIVA = NULL
        WHERE   idGrupo = 140
        UPDATE  dbo.Sistemas
        SET     NombreEmpresa = 'Activa'
    END
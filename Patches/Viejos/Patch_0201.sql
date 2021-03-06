USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ImprimirPrestaciones]    Script Date: 11/19/2013 18:58:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[ImprimirPrestaciones] @proceso VARCHAR(255)
AS 
    BEGIN
        SET NOCOUNT ON ;
        DECLARE @destinos TABLE
            (
             renglon INT IDENTITY(1, 1)
            ,idDestino INT
            ,TipoDeDestino VARCHAR(50)
            ,LugarDeDestino VARCHAR(100)
            ,HoraSolicitada DATETIME
            ,Direccion VARCHAR(MAX)
            ,NumeroPrest INT
            )
        INSERT  @destinos
                (idDestino
                ,TipoDeDestino
                ,LugarDeDestino
                ,HoraSolicitada
                ,Direccion
                ,NumeroPrest     
                )
                SELECT  d.idDestino
                       ,td.Nombre
                       ,lug.Nombre
                       ,d.HoraSolicitada
                       ,dbo.DireccionCompleta(dir.idDireccion)
                       ,CAST(prest.Numero AS INT)
                FROM    dbo.Destinos d
                        JOIN dbo.Prestaciones prest ON d.idPrestacion = prest.idPrestacion
                        JOIN dbo.ids ids ON d.idPrestacion = ids.id
                        LEFT JOIN dbo.TiposDeDestino td ON td.idTipoDeDestino = d.idTipoDeDestino
                        LEFT JOIN dbo.Lugares lug ON lug.idLugar = d.idLugar
                        LEFT JOIN dbo.direcciones dir ON dir.idDestino = d.idDestino
                WHERE   ids.Proceso = @proceso

        DECLARE @recursos TABLE
            (
             renglon INT IDENTITY(1, 1)
            ,idDestino INT
            ,CodigoRecurso VARCHAR(20)
            ,LugarDeSalida VARCHAR(100)
            ,OtroLugarDeSalida VARCHAR(200)
            ,Tomada DATETIME
            ,Asignado DATETIME
            ,Salida DATETIME
            ,Llegada DATETIME
            ,Terminado DATETIME
            ,Cancelado DATETIME
            ,NombrePacienteABordo VARCHAR(100)
            ,Despachador VARCHAR(100)
            ,ObservacionesDelRecurso VARCHAR(MAX)
            ,Movil VARCHAR(50)
            ,Medico1 VARCHAR(100)
            ,Medico2 VARCHAR(100)
            ,Paramedico1 VARCHAR(100)
            ,Paramedico2 VARCHAR(100)
            ,Chofer1 VARCHAR(100)
            ,Chofer2 VARCHAR(100)
            ,NumeroPrest INT
            )
        INSERT  @recursos
                (idDestino
                ,CodigoRecurso
                ,LugarDeSalida
                ,OtroLugarDeSalida
                ,Tomada
                ,Asignado
                ,Salida
                ,Llegada
                ,Terminado
                ,Cancelado
                ,NombrePacienteABordo
                ,Despachador
                ,ObservacionesDelRecurso
                ,Movil
                ,Medico1
                ,Medico2
                ,Paramedico1
                ,Paramedico2
                ,Chofer1
                ,Chofer2
                ,NumeroPrest
                        
                )
                SELECT  d.idDestino
                       ,cod.Nombre
                       ,lug.Nombre
                       ,dr.OtroLugarDeSalida
                       ,prest.Tomada
                       ,dr.Asignado
                       ,dr.Salida
                       ,dr.Llegada
                       ,dr.Terminado
                       ,dr.Cancelado
                       ,pac.Nombre
                       ,u.NombApel
                       ,dr.Observaciones
                       ,mov.Nombre
                       ,med1.NombApel
                       ,med2.NombApel
                       ,par1.NombApel
                       ,par2.NombApel
                       ,cho1.NombApel
                       ,cho2.NombApel
                       ,CAST(prest.Numero AS INT)
                FROM    dbo.ids ids
                        JOIN dbo.Prestaciones prest ON ids.id = prest.idPrestacion
                        JOIN dbo.Destinos d ON prest.idPrestacion = d.idPrestacion
                        JOIN dbo.DestinosRecursos dr ON dr.idDestino = d.idDestino
                        LEFT JOIN dbo.Codigos cod ON cod.idCodigo = dr.idCodigo
                        LEFT JOIN dbo.Lugares lug ON lug.idLugar = dr.idLugarDeSalida
                        LEFT JOIN dbo.Pacientes pac ON pac.idPaciente = dr.idPaciente
                        LEFT JOIN dbo.Usuarios u ON u.idUsuario = dr.idDespachador
                        LEFT JOIN dbo.Moviles mov ON mov.idMovil = dr.idMovil
                        LEFT JOIN dbo.Empleados med1 ON med1.idEmpleado = dr.idMedico1
                        LEFT JOIN dbo.Empleados med2 ON med2.idEmpleado = dr.idMedico2
                        LEFT JOIN dbo.Empleados par1 ON par1.idEmpleado = dr.idParamedico1
                        LEFT JOIN dbo.Empleados par2 ON par2.idEmpleado = dr.idParamedico2
                        LEFT JOIN dbo.Empleados cho1 ON cho1.idEmpleado = dr.idChofer1
                        LEFT JOIN dbo.Empleados cho2 ON cho2.idEmpleado = dr.idChofer2
                WHERE   ids.Proceso = @proceso

        DECLARE @pacientes TABLE
            (
             renglon INT IDENTITY(1, 1)
            ,idPaciente INT
            ,NombreDelPaciente VARCHAR(100)
            ,TipoDeDocumento VARCHAR(10)
            ,NumeroDeDocumento INT
            ,Edad VARCHAR(10)
            ,Sexo VARCHAR(10)
            ,EsAfiliado BIT
            ,Prepago VARCHAR(100)
            ,NroAfiliadoPrepago VARCHAR(30)
            ,Antecedentes VARCHAR(MAX)
            ,Contrato VARCHAR(300)
            ,Cobertura VARCHAR(50)
            ,Práctica VARCHAR(50)
            ,MédicoFirmaHC VARCHAR(100)
            ,IncidenteExterno VARCHAR(30)
            ,ImportePaciente MONEY
            ,Motivos VARCHAR(MAX)
            ,Diagnosticos VARCHAR(MAX)
            ,NumeroPrest INT
            ,ExtraCobertura VARCHAR(2)
            )
        INSERT  @pacientes
                (idPaciente
                ,NombreDelPaciente
                ,TipoDeDocumento
                ,NumeroDeDocumento
                ,Edad
                ,Sexo
                ,EsAfiliado
                ,Prepago
                ,NroAfiliadoPrepago
                ,Antecedentes
                ,Contrato
                ,Cobertura
                ,ExtraCobertura
                ,Práctica
                ,MédicoFirmaHC
                ,IncidenteExterno
                ,ImportePaciente
                ,Motivos
                ,Diagnosticos
                ,NumeroPrest
                )
                SELECT  pac.idPaciente
                       ,pac.Nombre
                       ,tDoc.Iniciales
                       ,CAST(pac.NumeroDeDocumento AS INT)
                       ,pac.xEdad
                       ,pac.Sexo
                       ,CASE WHEN pac.idAfiliado IS NULL THEN 0
                             ELSE 1
                        END
                       ,pp.Nombre
                       ,pac.NroAfiliadoPrepago
                       ,pac.Antecedentes
                       ,cli.RazonSocial + CASE WHEN cli.NombreFantasia IS NULL THEN ''
                                               ELSE ' (' + cli.NOmbreFantasia + ')'
                                          END + ' - ' + cto.Nombre
                       ,cob.Nombre
                       ,CASE ISNULL(ExtraCobertura, 0)
                          WHEN 0 THEN 'No'
                          ELSE 'Si'
                        END
                       ,prac.Nombre
                       ,emp.NombApel
                       ,pac.IncidenteExterno
                       ,pac.Importe
                       ,pac.MotivosDeLlamado
                       ,pac.Diagnosticos
                       ,CAST(prest.Numero AS INT)
                FROM    dbo.ids ids
                        JOIN dbo.Prestaciones prest ON ids.id = prest.idPrestacion
                        JOIN dbo.Pacientes pac ON prest.idPrestacion = pac.idPrestacion
                        LEFT JOIN dbo.Prepagos pp ON pp.idPrepago = pac.idPrepago
                        LEFT JOIN dbo.Contratos cto ON cto.idContrato = pac.idContrato
                        LEFT JOIN dbo.Clientes cli ON cli.idCliente = cto.idCliente
                        LEFT JOIN dbo.Coberturas cob ON cob.idCobertura = pac.idCobertura
                        LEFT JOIN dbo.Practicas prac ON prac.idPractica = pac.idPractica
                        LEFT JOIN dbo.Empleados emp ON emp.idEmpleado = pac.idMedico
                        LEFT JOIN dbo.TiposDeDocumento tDoc ON pac.idTipoDeDocumento = tDoc.idTipoDeDocumento
                WHERE   ids.Proceso = @proceso
                
        DECLARE @medicamentos TABLE
            (
             renglon INT IDENTITY(1, 1)
            ,idPaciente INT
            ,Medicamento VARCHAR(50)
            ,Cantidad INT
            ,Unidad VARCHAR(20)
            ,NumeroPrest INT
            )
        INSERT  @medicamentos
                (idPaciente
                ,Medicamento
                ,Cantidad
                ,Unidad
                ,NumeroPrest
                )
                SELECT  pac.idPaciente
                       ,med.Nombre
                       ,mp.Cantidad
                       ,CASE WHEN mp.Cantidad = 1 THEN med.Unidad
                             ELSE med.Unidades
                        END
                       ,CAST(prest.Numero AS INT)
                FROM    dbo.ids ids
                        JOIN dbo.Prestaciones prest ON ids.id = prest.idPrestacion
                        JOIN dbo.Pacientes pac ON prest.idPrestacion = pac.idPrestacion
                        JOIN dbo.MedicamentosPacientes mp ON mp.idPaciente = pac.idPaciente
                        JOIN dbo.Medicamentos med ON med.idMedicamento = mp.idMedicamento
                WHERE   ids.Proceso = @proceso

        DECLARE @tabla TABLE
            (
             Prestacion INT
            ,DestOPac INT
            ,OrdenDestOPac INT
            ,RecMotDiagOMed INT
            ,OrdenRecMotDiagOMed INT
            ,NumeroPrest INT
            ,CodigoTomada VARCHAR(20)
            ,Tomada DATETIME
            ,FinTomada DATETIME
            ,Tomador VARCHAR(50)
            ,EncargadoDeCobrar VARCHAR(100)
            ,Importe MONEY
            ,Cobrado MONEY
            ,ObservacionesCobradoMenos VARCHAR(MAX)
            ,ObservacionesPrestacion VARCHAR(MAX)
            ,MotivoDeCancelacion VARCHAR(50)
            ,Terminada BIT
            ,Agendada DATETIME
            ,TipoDeDestino VARCHAR(50)
            ,LugarDeDestino VARCHAR(100)
            ,HoraSolicitada DATETIME
            ,Direccion VARCHAR(MAX)
            ,CodigoRecurso VARCHAR(20)
            ,LugarDeSalida VARCHAR(100)
            ,OtroLugarDeSalida VARCHAR(200)
            ,Asignado DATETIME
            ,Salida DATETIME
            ,Llegada DATETIME
            ,Terminado DATETIME
            ,Cancelado DATETIME
            ,NombrePacienteABordo VARCHAR(100)
            ,Despachador VARCHAR(100)
            ,ObservacionesDelRecurso VARCHAR(MAX)
            ,Movil VARCHAR(50)
            ,Medico1 VARCHAR(100)
            ,Medico2 VARCHAR(100)
            ,Paramedico1 VARCHAR(100)
            ,Paramedico2 VARCHAR(100)
            ,Chofer1 VARCHAR(100)
            ,Chofer2 VARCHAR(100)
            ,NombreDelPaciente VARCHAR(100)
            ,TipoDeDocumento VARCHAR(10)
            ,NumeroDeDocumento INT
            ,Edad VARCHAR(10)
            ,Sexo VARCHAR(10)
            ,EsAfiliado BIT
            ,Prepago VARCHAR(100)
            ,NroAfiliadoPrepago VARCHAR(30)
            ,Antecedentes VARCHAR(MAX)
            ,Contrato VARCHAR(300)
            ,CondicionesDelContrato VARCHAR(MAX)
            ,Cobertura VARCHAR(50)
            ,ExtraCobertura VARCHAR(2)
            ,Práctica VARCHAR(50)
            ,MédicoFirmaHC VARCHAR(100)
            ,IncidenteExterno VARCHAR(30)
            ,ImportePaciente MONEY
            ,Motivos VARCHAR(MAX)
            ,Diagnosticos VARCHAR(MAX)
            ,Medicamento VARCHAR(50)
            ,Cantidad INT
            ,Unidad VARCHAR(50)
            ,CantidadDeComprobantes INT
            )
        INSERT  @tabla
                (Prestacion
                ,DestOPac
                ,OrdenDestOPac
                ,RecMotDiagOMed
                ,OrdenRecMotDiagOMed
                ,NumeroPrest
                ,CodigoTomada
                ,Tomada
                ,FinTomada
                ,Tomador
                ,EncargadoDeCobrar
                ,Importe
                ,Cobrado
                ,ObservacionesCobradoMenos
                ,ObservacionesPrestacion
                ,MotivoDeCancelacion
                ,Terminada
                ,Agendada
                ,CantidadDeComprobantes
                )
                SELECT  1
                       ,0
                       ,0
                       ,0
                       ,0
                       ,CAST(prest.Numero AS INT)
                       ,cod.Nombre
                       ,prest.Tomada
                       ,prest.FinTomada
                       ,u.NombApel
                       ,emp.NombApel
                       ,prest.Importe
                       ,cr.ImporteCobrado
                       ,cr.Observaciones
                       ,prest.ObservacionesTomador
                       ,mot.Nombre
                       ,prest.Terminada,
                        prest.Agendada,
                        (SELECT COUNT(*) FROM dbo.Comprobantes WHERE idPrestacion = prest.idPrestacion)
                FROM    dbo.ids ids
                        JOIN dbo.Prestaciones prest ON ids.id = prest.idPrestacion
                        LEFT JOIN dbo.Codigos cod ON cod.idCodigo = prest.idCodigo
                        LEFT JOIN dbo.Usuarios u ON u.idUsuario = prest.idTomador
                        LEFT JOIN dbo.MotivosDeCancelacionPrestacion mot ON mot.idMotivoDeCancelacionPrestacion = prest.idMotivoDeCancelacion
                        LEFT JOIN dbo.ComprobantesRemesas cr ON prest.idPrestacion = cr.idPrestacion
                        LEFT JOIN dbo.Remesas r ON r.idRemesa = cr.idRemesa
                        LEFT JOIN dbo.Empleados emp ON emp.idEmpleado = r.idReceptor
                WHERE   ids.Proceso = @proceso

        INSERT  @tabla
                (Prestacion
                ,DestOPac
                ,OrdenDestOPac
                ,RecMotDiagOMed
                ,OrdenRecMotDiagOMed
                ,TipoDeDestino
                ,LugarDeDestino
                ,HoraSolicitada
                ,Direccion
                ,NumeroPrest
                        
                )
                SELECT  1
                       ,1
                       ,idDestino
                       ,0
                       ,0
                       ,TipoDeDestino
                       ,LugarDeDestino
                       ,HoraSolicitada
                       ,Direccion
                       ,NumeroPrest
                FROM    @destinos

        INSERT  @tabla
                (Prestacion
                ,DestOPac
                ,OrdenDestOPac
                ,RecMotDiagOMed
                ,OrdenRecMotDiagOMed
                ,CodigoRecurso
                ,LugarDeSalida
                ,OtroLugarDeSalida
                ,Tomada
                ,Asignado
                ,Salida
                ,Llegada
                ,Terminado
                ,Cancelado
                ,NombrePacienteABordo
                ,Despachador
                ,ObservacionesDelRecurso
                ,Movil
                ,Medico1
                ,Medico2
                ,Paramedico1
                ,Paramedico2
                ,Chofer1
                ,Chofer2
                ,NumeroPrest
                        
                )
                SELECT  1
                       ,1
                       ,idDestino
                       ,1
                       ,Renglon
                       ,CodigoRecurso
                       ,LugarDeSalida
                       ,OtroLugarDeSalida
                       ,Tomada
                       ,Asignado
                       ,Salida
                       ,Llegada
                       ,Terminado
                       ,Cancelado
                       ,NombrePacienteABordo
                       ,Despachador
                       ,ObservacionesDelRecurso
                       ,Movil
                       ,Medico1
                       ,Medico2
                       ,Paramedico1
                       ,Paramedico2
                       ,Chofer1
                       ,Chofer2
                       ,NumeroPrest
                FROM    @recursos

        INSERT  @tabla
                (Prestacion
                ,DestOPac
                ,OrdenDestOPac
                ,RecMotDiagOMed
                ,OrdenRecMotDiagOMed
                ,NombreDelPaciente
                ,TipoDeDocumento
                ,NumeroDeDocumento
                ,Edad
                ,Sexo
                ,EsAfiliado
                ,Prepago
                ,NroAfiliadoPrepago
                ,Antecedentes
                ,Contrato
                ,Cobertura
                ,ExtraCobertura
                ,Práctica
                ,MédicoFirmaHC
                ,IncidenteExterno
                ,ImportePaciente
                ,Motivos
                ,Diagnosticos
                ,NumeroPrest
                        
                )
                SELECT  1
                       ,2
                       ,idPaciente
                       ,0
                       ,0
                       ,NombreDelPaciente
                       ,TipoDeDocumento
                       ,NumeroDeDocumento
                       ,Edad
                       ,Sexo
                       ,EsAfiliado
                       ,Prepago
                       ,NroAfiliadoPrepago
                       ,Antecedentes
                       ,Contrato
                       ,Cobertura
                       ,ExtraCobertura
                       ,Práctica
                       ,MédicoFirmaHC
                       ,IncidenteExterno
                       ,ImportePaciente
                       ,Motivos
                       ,Diagnosticos
                       ,NumeroPrest
                FROM    @pacientes

        INSERT  @tabla
                (Prestacion
                ,DestOPac
                ,OrdenDestOPac
                ,RecMotDiagOMed
                ,OrdenRecMotDiagOMed
                ,Medicamento
                ,Cantidad
                ,Unidad
                ,NumeroPrest
                        
                )
                SELECT  1
                       ,2
                       ,idPaciente
                       ,4
                       ,Renglon
                       ,Medicamento
                       ,Cantidad
                       ,Unidad
                       ,NumeroPrest
                FROM    @medicamentos
        SELECT  *
        FROM    @tabla
        ORDER BY NumeroPrest
               ,Prestacion
               ,DestOPac
               ,OrdenDestOPac
               ,RecMotDiagOMed
               ,OrdenRecMotDiagOMed
    END


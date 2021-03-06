USE [Datos]
GO
/****** Object:  StoredProcedure [dbo].[ImprimirPrestacion]    Script Date: 11/19/2013 19:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[ImprimirPrestacion] @idPrestacion int = 0
AS 
    BEGIN
        SET NOCOUNT ON ;
        DECLARE @cantDestinos int
        DECLARE @nDestino int
        DECLARE @idDestino int
        DECLARE @cantPacientes int
        DECLARE @nPaciente int
        DECLARE @idPaciente int
    
        DECLARE @destinos table
            (
              renglon int IDENTITY(1, 1),
              idDestino int,
              TipoDeDestino varchar(50),
              LugarDeDestino varchar(100),
              HoraSolicitada DateTime,
              Direccion varchar(MAX),
              NumeroPrest int
            )
        INSERT  @destinos
                (
                  idDestino,
                  TipoDeDestino,
                  LugarDeDestino,
                  HoraSolicitada,
                  Direccion,
                  NumeroPrest
                        
                )
                SELECT  d.idDestino,
                        td.Nombre,
                        lug.Nombre,
                        d.HoraSolicitada,
                        dbo.DireccionCompleta(dir.idDireccion),
                        ( SELECT    CAST(Numero AS INT)
                          FROM      dbo.Prestaciones
                          WHERE     idPrestacion = @idPrestacion
                        )
                FROM    dbo.Destinos d
                        LEFT JOIN dbo.TiposDeDestino td on td.idTipoDeDestino = d.idTipoDeDestino
                        LEFT JOIN dbo.Lugares lug on lug.idLugar = d.idLugar
                        LEFT JOIN dbo.direcciones dir on dir.idDestino = d.idDestino
                WHERE   d.idPrestacion = @idPrestacion
        SET @cantDestinos = @@ROWCOUNT

        DECLARE @recursos table
            (
              renglon int IDENTITY(1, 1),
              idDestino int,
              CodigoRecurso varchar(20),
              LugarDeSalida varchar(100),
              OtroLugarDeSalida varchar(200),
              Tomada DateTime,
              Asignado DateTime,
              Salida DateTime,
              Llegada DateTime,
              Terminado DateTime,
              Cancelado DateTime,
              NombrePacienteABordo varchar(100),
              Despachador varchar(100),
              ObservacionesDelRecurso varchar(MAX),
              Movil varchar(50),
              Medico1 varchar(100),
              Medico2 varchar(100),
              Paramedico1 varchar(100),
              Paramedico2 varchar(100),
              Chofer1 varchar(100),
              Chofer2 varchar(100),
              NumeroPrest int
            )
        INSERT  @recursos
                (
                  idDestino,
                  CodigoRecurso,
                  LugarDeSalida,
                  OtroLugarDeSalida,
                  Tomada,
                  Asignado,
                  Salida,
                  Llegada,
                  Terminado,
                  Cancelado,
                  NombrePacienteABordo,
                  Despachador,
                  ObservacionesDelRecurso,
                  Movil,
                  Medico1,
                  Medico2,
                  Paramedico1,
                  Paramedico2,
                  Chofer1,
                  Chofer2,
                  NumeroPrest
                        
                )
                SELECT  d.idDestino,
                        cod.Nombre,
                        lug.Nombre,
                        dr.OtroLugarDeSalida,
                        ( SELECT    Tomada
                          FROM      dbo.Prestaciones
                          WHERE     idPrestacion = @idPrestacion
                        ),
                        dr.Asignado,
                        dr.Salida,
                        dr.Llegada,
                        dr.Terminado,
                        dr.Cancelado,
                        pac.Nombre,
                        u.NombApel,
                        dr.Observaciones,
                        mov.Nombre,
                        med1.NombApel,
                        med2.NombApel,
                        par1.NombApel,
                        par2.NombApel,
                        cho1.NombApel,
                        cho2.NombApel,
                        ( SELECT    CAST(Numero AS INT)
                          FROM      dbo.Prestaciones
                          WHERE     idPrestacion = @idPrestacion
                        )
                FROM    dbo.Destinos d
                        JOIN dbo.DestinosRecursos dr on dr.idDestino = d.idDestino
                        LEFT JOIN dbo.Codigos cod on cod.idCodigo = dr.idCodigo
                        LEFT JOIN dbo.Lugares lug on lug.idLugar = dr.idLugarDeSalida
                        LEFT JOIN dbo.Pacientes pac on pac.idPaciente = dr.idPaciente
                        LEFT JOIN dbo.Usuarios u on u.idUsuario = dr.idDespachador
                        LEFT JOIN dbo.Moviles mov on mov.idMovil = dr.idMovil
                        LEFT JOIN dbo.Empleados med1 on med1.idEmpleado = dr.idMedico1
                        LEFT JOIN dbo.Empleados med2 on med2.idEmpleado = dr.idMedico2
                        LEFT JOIN dbo.Empleados par1 on par1.idEmpleado = dr.idParamedico1
                        LEFT JOIN dbo.Empleados par2 on par2.idEmpleado = dr.idParamedico2
                        LEFT JOIN dbo.Empleados cho1 on cho1.idEmpleado = dr.idChofer1
                        LEFT JOIN dbo.Empleados cho2 on cho2.idEmpleado = dr.idChofer2
                WHERE   d.idPrestacion = @idPrestacion

        DECLARE @pacientes table
            (
              renglon int IDENTITY(1, 1),
              idPaciente int,
              NombreDelPaciente varchar(100),
              TipoDeDocumento VARCHAR(10),
              NumeroDeDocumento INT,
              Edad varchar(10),
              Sexo varchar(10),
              EsAfiliado bit,
              Prepago varchar(100),
              NroAfiliadoPrepago varchar(30),
              Antecedentes varchar(MAX),
              Contrato varchar(300),
              Cobertura varchar(50),
              Práctica varchar(50),
              MédicoFirmaHC varchar(100),
              IncidenteExterno varchar(30),
              ImportePaciente money,
              Motivos varchar(MAX),
              Diagnosticos varchar(MAX),
              NumeroPrest int,
              ExtraCobertura varchar(2)
            )
        INSERT  @pacientes
                (
                  idPaciente,
                  NombreDelPaciente,
                  TipoDeDocumento,
                  NumeroDeDocumento,
                  Edad,
                  Sexo,
                  EsAfiliado,
                  Prepago,
                  NroAfiliadoPrepago,
                  Antecedentes,
                  Contrato,
                  Cobertura,
                  ExtraCobertura,
                  Práctica,
                  MédicoFirmaHC,
                  IncidenteExterno,
                  ImportePaciente,
                  Motivos,
                  Diagnosticos,
                  NumeroPrest
                        
                )
                SELECT  pac.idPaciente,
                        pac.Nombre,
                        tDoc.Iniciales,
                        CAST(pac.NumeroDeDocumento AS INT),
                        pac.xEdad,
                        pac.Sexo,
                        CASE WHEN pac.idAfiliado is null THEN 0
                             ELSE 1
                        END,
                        pp.Nombre,
                        pac.NroAfiliadoPrepago,
                        pac.Antecedentes,
                        cli.RazonSocial
                        + CASE WHEN cli.NombreFantasia is null THEN ''
                               ELSE ' (' + cli.NOmbreFantasia + ')'
                          END + ' - ' + cto.Nombre,
                        cob.Nombre,
                        CASE isnull(ExtraCobertura, 0)
                          WHEN 0 THEN 'No'
                          ELSE 'Si'
                        END,
                        prac.Nombre,
                        emp.NombApel,
                        pac.IncidenteExterno,
                        pac.Importe,
                        pac.MotivosDeLlamado,
                        pac.Diagnosticos,
                        ( SELECT    CAST(Numero AS INT)
                          FROM      dbo.Prestaciones
                          WHERE     idPrestacion = @idPrestacion
                        )
                FROM    dbo.Pacientes pac
                        LEFT JOIN dbo.Prepagos pp on pp.idPrepago = pac.idPrepago
                        LEFT JOIN dbo.Contratos cto on cto.idContrato = pac.idContrato
                        LEFT JOIN dbo.Clientes cli on cli.idCliente = cto.idCliente
                        LEFT JOIN dbo.Coberturas cob on cob.idCobertura = pac.idCobertura
                        LEFT JOIN dbo.Practicas prac on prac.idPractica = pac.idPractica
                        LEFT JOIN dbo.Empleados emp on emp.idEmpleado = pac.idMedico
                        LEFT JOIN dbo.TiposDeDocumento tDoc ON pac.idTipoDeDocumento = tDoc.idTipoDeDocumento
                WHERE   pac.idPrestacion = @idPrestacion
        SET @cantPacientes = @@ROWCOUNT

        DECLARE @medicamentos table
            (
              renglon int IDENTITY(1, 1),
              idPaciente int,
              Medicamento varchar(50),
              Cantidad int,
              Unidad varchar(20),
              NumeroPrest int
            )
        INSERT  @medicamentos
                (
                  idPaciente,
                  Medicamento,
                  Cantidad,
                  Unidad,
                  NumeroPrest
                            
                )
                SELECT  pac.idPaciente,
                        med.Nombre,
                        mp.Cantidad,
                        CASE WHEN mp.Cantidad = 1 THEN med.Unidad
                             ELSE med.Unidades
                        END,
                        ( SELECT    CAST(Numero AS INT)
                          FROM      dbo.Prestaciones
                          WHERE     idPrestacion = @idPrestacion
                        )
                FROM    dbo.Pacientes pac
                        JOIN dbo.MedicamentosPacientes mp on mp.idPaciente = pac.idPaciente
                        JOIN dbo.Medicamentos med on med.idMedicamento = mp.idMedicamento
                WHERE   pac.idPrestacion = @idPrestacion

        DECLARE @tabla table
            (
              Prestacion int,
              DestOPac int,
              OrdenDestOPac int,
              RecMotDiagOMed int,
              OrdenRecMotDiagOMed int,
              NumeroPrest int,
              CodigoTomada varchar(20),
              Tomada DateTime,
              FinTomada DateTime,
              Tomador VarChar(50),
              EncargadoDeCobrar VarChar(100),
              Importe Money,
              Cobrado Money,
              ObservacionesCobradoMenos VarChar(MAX),
              ObservacionesPrestacion VarChar(MAX),
              MotivoDeCancelacion VarChar(50),
              Terminada bit,
              Agendada DATETIME,
              TipoDeDestino varchar(50),
              LugarDeDestino varchar(100),
              HoraSolicitada DateTime,
              Direccion varchar(MAX),
              CodigoRecurso varchar(20),
              LugarDeSalida varchar(100),
              OtroLugarDeSalida varchar(200),
              Asignado DateTime,
              Salida DateTime,
              Llegada DateTime,
              Terminado DateTime,
              Cancelado DateTime,
              NombrePacienteABordo varchar(100),
              Despachador varchar(100),
              ObservacionesDelRecurso varchar(MAX),
              Movil varchar(50),
              Medico1 varchar(100),
              Medico2 varchar(100),
              Paramedico1 varchar(100),
              Paramedico2 varchar(100),
              Chofer1 varchar(100),
              Chofer2 varchar(100),
              NombreDelPaciente varchar(100),
              TipoDeDocumento VARCHAR(10),
              NumeroDeDocumento INT,
              Edad varchar(10),
              Sexo varchar(10),
              EsAfiliado bit,
              Prepago varchar(100),
              NroAfiliadoPrepago varchar(30),
              Antecedentes varchar(MAX),
              Contrato varchar(300),
              CondicionesDelContrato varchar(MAX),
              Cobertura varchar(50),
              ExtraCobertura varchar(2),
              Práctica varchar(50),
              MédicoFirmaHC varchar(100),
              IncidenteExterno varchar(30),
              ImportePaciente money,
              Motivos varchar(MAX),
              Diagnosticos varchar(MAX),
              Medicamento varchar(50),
              Cantidad int,
              Unidad varchar(50),
              CantidadDeComprobantes INT
            )
        INSERT  @tabla
                (
                  Prestacion,
                  DestOPac,
                  OrdenDestOPac,
                  RecMotDiagOMed,
                  OrdenRecMotDiagOMed,
                  NumeroPrest,
                  CodigoTomada,
                  Tomada,
                  FinTomada,
                  Tomador,
                  EncargadoDeCobrar,
                  Importe,
                  Cobrado,
                  ObservacionesCobradoMenos,
                  ObservacionesPrestacion,
                  MotivoDeCancelacion,
                  Terminada,
                  Agendada,
                  CantidadDeComprobantes
                )
                SELECT  1,
                        0,
                        0,
                        0,
                        0,
                        CAST(prest.Numero AS INT),
                        cod.Nombre,
                        prest.Tomada,
                        prest.FinTomada,
                        u.NombApel,
                        emp.NombApel,
                        prest.Importe,
                        cr.ImporteCobrado,
                        cr.Observaciones,
                        prest.ObservacionesTomador,
                        mot.Nombre,
                        prest.Terminada,
                        prest.Agendada,
                        (SELECT COUNT(*) FROM dbo.Comprobantes WHERE idPrestacion = prest.idPrestacion)
                FROM    dbo.Prestaciones prest
                        LEFT JOIN dbo.Codigos cod on cod.idCodigo = prest.idCodigo
                        LEFT JOIN dbo.Usuarios u on u.idUsuario = prest.idTomador
                        LEFT JOIN dbo.MotivosDeCancelacionPrestacion mot on mot.idMotivoDeCancelacionPrestacion = prest.idMotivoDeCancelacion
                        LEFT JOIN dbo.ComprobantesRemesas cr on cr.idPrestacion = @idPrestacion
                        LEFT JOIN dbo.Remesas r on r.idRemesa = cr.idRemesa
                        LEFT JOIN dbo.Empleados emp on emp.idEmpleado = r.idReceptor
                WHERE   prest.idPrestacion = @idPrestacion

        SET @nDestino = 1
        WHILE @nDestino <= @cantDestinos
            BEGIN
                SELECT  @idDestino = idDestino
                FROM    @destinos
                WHERE   Renglon = @nDestino
                INSERT  @tabla
                        (
                          Prestacion,
                          DestOPac,
                          OrdenDestOPac,
                          RecMotDiagOMed,
                          OrdenRecMotDiagOMed,
                          TipoDeDestino,
                          LugarDeDestino,
                          HoraSolicitada,
                          Direccion,
                          NumeroPrest
                        )
                        SELECT  1,
                                1,
                                @nDestino,
                                0,
                                0,
                                TipoDeDestino,
                                LugarDeDestino,
                                HoraSolicitada,
                                Direccion,
                                NumeroPrest
                        FROM    @destinos
                        WHERE   Renglon = @nDestino
                INSERT  @tabla
                        (
                          Prestacion,
                          DestOPac,
                          OrdenDestOPac,
                          RecMotDiagOMed,
                          OrdenRecMotDiagOMed,
                          CodigoRecurso,
                          LugarDeSalida,
                          OtroLugarDeSalida,
                          Tomada,
                          Asignado,
                          Salida,
                          Llegada,
                          Terminado,
                          Cancelado,
                          NombrePacienteABordo,
                          Despachador,
                          ObservacionesDelRecurso,
                          Movil,
                          Medico1,
                          Medico2,
                          Paramedico1,
                          Paramedico2,
                          Chofer1,
                          Chofer2,
                          NumeroPrest
                        )
                        SELECT  1,
                                1,
                                @nDestino,
                                1,
                                Renglon,
                                CodigoRecurso,
                                LugarDeSalida,
                                OtroLugarDeSalida,
                                Tomada,
                                Asignado,
                                Salida,
                                Llegada,
                                Terminado,
                                Cancelado,
                                NombrePacienteABordo,
                                Despachador,
                                ObservacionesDelRecurso,
                                Movil,
                                Medico1,
                                Medico2,
                                Paramedico1,
                                Paramedico2,
                                Chofer1,
                                Chofer2,
                                NumeroPrest
                        FROM    @recursos
                        WHERE   idDestino = @idDestino
                SET @nDestino = @nDestino + 1
            END
        SET @nPaciente = 1
        WHILE @nPaciente <= @cantPacientes
            BEGIN
                SELECT  @idPaciente = idPaciente
                FROM    @pacientes
                WHERE   Renglon = @nPaciente
                INSERT  @tabla
                        (
                          Prestacion,
                          DestOPac,
                          OrdenDestOPac,
                          RecMotDiagOMed,
                          OrdenRecMotDiagOMed,
                          NombreDelPaciente,
                          TipoDeDocumento,
                          NumeroDeDocumento,
                          Edad,
                          Sexo,
                          EsAfiliado,
                          Prepago,
                          NroAfiliadoPrepago,
                          Antecedentes,
                          Contrato,
                          Cobertura,
                          ExtraCobertura,
                          Práctica,
                          MédicoFirmaHC,
                          IncidenteExterno,
                          ImportePaciente,
                          Motivos,
                          Diagnosticos,
                          NumeroPrest
                        )
                        SELECT  1,
                                2,
                                @nPaciente,
                                0,
                                0,
                                NombreDelPaciente,
                                TipoDeDocumento,
                                NumeroDeDocumento,
                                Edad,
                                Sexo,
                                EsAfiliado,
                                Prepago,
                                NroAfiliadoPrepago,
                                Antecedentes,
                                Contrato,
                                Cobertura,
                                ExtraCobertura,
                                Práctica,
                                MédicoFirmaHC,
                                IncidenteExterno,
                                ImportePaciente,
                                Motivos,
                                Diagnosticos,
                                NumeroPrest
                        FROM    @pacientes
                        WHERE   Renglon = @nPaciente
                INSERT  @tabla
                        (
                          Prestacion,
                          DestOPac,
                          OrdenDestOPac,
                          RecMotDiagOMed,
                          OrdenRecMotDiagOMed,
                          Medicamento,
                          Cantidad,
                          Unidad,
                          NumeroPrest
                        )
                        SELECT  1,
                                2,
                                @nPaciente,
                                4,
                                Renglon,
                                Medicamento,
                                Cantidad,
                                Unidad,
                                NumeroPrest
                        FROM    @medicamentos
                        WHERE   idPaciente = @idPaciente
                SET @nPaciente = @nPaciente + 1
            END
        SELECT  *
        FROM    @tabla
    END


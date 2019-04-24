using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Administración.Properties;

namespace Administración
{
    public partial class CmpCabPrestaciones : Component
    {
        public CmpCabPrestaciones()
        {
            InitializeComponent();
        }

        public CmpCabPrestaciones(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public DsPrestacion GetPrestacion(int idPrestacion)
        {
            var ret = new DsPrestacion();
            prestacionesTableAdapter1.FillByIdPrestacion(ret.Prestaciones, idPrestacion);
            return ret;
        }

        public DsDestinos GetDestinos(int idPrestacion)
        {
            var ret = new DsDestinos();
            destinosTableAdapter1.FillByIdPrestacion(ret.Destinos, idPrestacion);
            destinosRecursosTableAdapter1.FillByIdPrestacion(ret.DestinosRecursos, idPrestacion);
            direccionesDestinosTableAdapter1.FillByIdPrestacion(ret.Direcciones, idPrestacion);
            return ret;
        }

        public DsPacientesPrestacion GetPacientes(int idPrestacion)
        {
            var ret = new DsPacientesPrestacion();
            pacientesTableAdapter1.FillByIdPrestacion(ret.Pacientes, idPrestacion);
            motivosPacientesTableAdapter1.FillByIdPrestacion(ret.MotivosPacientes, idPrestacion);
            diagnosticosPacientesTableAdapter1.FillByIdPrestacion(ret.DiagnosticosPacientes, idPrestacion);
            medicamentosPacientesTableAdapter1.FillByIdPrestacion(ret.MedicamentosPacientes, idPrestacion);
            return ret;
        }

        public DsPacientesPrestacion GetPaciente(int idPaciente)
        {
            var ret = new DsPacientesPrestacion();
            pacientesTableAdapter1.FillByIdPaciente(ret.Pacientes, idPaciente);
            motivosPacientesTableAdapter1.FillByIdPaciente(ret.MotivosPacientes, idPaciente);
            diagnosticosPacientesTableAdapter1.FillByIdPaciente(ret.DiagnosticosPacientes, idPaciente);
            medicamentosPacientesTableAdapter1.FillByIdPaciente(ret.MedicamentosPacientes, idPaciente);
            return ret;
        }

        public DsPrestacion UpdatePrestacion(DsPrestacion prest)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    prestacionesTableAdapter1.Update(prest.Prestaciones);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return prest;
            }
        }

        public DsDestinos UpdateDestinos(DsDestinos dest)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    destinosTableAdapter1.Update(dest.Destinos.Select("", "",
                                                                      DataViewRowState.Added |
                                                                      DataViewRowState.ModifiedCurrent));
                    destinosRecursosTableAdapter1.Update(dest.DestinosRecursos.Select("", "",
                                                                                      DataViewRowState.Added |
                                                                                      DataViewRowState.ModifiedCurrent));
                    direccionesDestinosTableAdapter1.Update(dest.Direcciones.Select("", "",
                                                                                    DataViewRowState.Added |
                                                                                    DataViewRowState.ModifiedCurrent));
                    direccionesDestinosTableAdapter1.Update(dest.Direcciones);
                    destinosRecursosTableAdapter1.Update(dest.DestinosRecursos);
                    destinosTableAdapter1.Update(dest.Destinos);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return dest;
            }
        }

        public DsPacientesPrestacion UpdatePacientes(DsPacientesPrestacion pac)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    pacientesTableAdapter1.Update(pac.Pacientes.Select("", "",
                                                                       DataViewRowState.Added |
                                                                       DataViewRowState.ModifiedCurrent));
                    motivosPacientesTableAdapter1.Update(pac.MotivosPacientes.Select("", "",
                                                                                     DataViewRowState.Added |
                                                                                     DataViewRowState.ModifiedCurrent));
                    diagnosticosPacientesTableAdapter1.Update(pac.DiagnosticosPacientes.Select("", "",
                                                                                               DataViewRowState.Added |
                                                                                               DataViewRowState.
                                                                                                   ModifiedCurrent));
                    medicamentosPacientesTableAdapter1.Update(pac.MedicamentosPacientes.Select("", "",
                                                                                               DataViewRowState.Added |
                                                                                               DataViewRowState.
                                                                                                   ModifiedCurrent));
                    medicamentosPacientesTableAdapter1.Update(pac.MedicamentosPacientes);
                    diagnosticosPacientesTableAdapter1.Update(pac.DiagnosticosPacientes);
                    motivosPacientesTableAdapter1.Update(pac.MotivosPacientes);
                    pacientesTableAdapter1.Update(pac.Pacientes);
                    foreach (DataRow paciente in pac.Pacientes.Rows)
                    {
                        using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
                        {
                            var command =
                                new SqlCommand(
                                    "UPDATE dbo.Pacientes SET MotivosDeLlamado=dbo.MotivosDelPaciente(@idPaciente),Diagnosticos=dbo.DiagnosticosDelPaciente(@idPaciente),Medicamentos = dbo.MedicamentosDelPaciente(@idPaciente) WHERE idPaciente=@idPaciente",
                                    connection);
                            var xidPaciente = command.Parameters.Add("idPaciente", SqlDbType.Int);
                            xidPaciente.Value = paciente["idPaciente"];
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return pac;
            }
        }

        public DsDireccionLugar GetDireccionLugar(int lug)
        {
            var ret = new DsDireccionLugar();
            direccionLugarTableAdapter1.Fill(ret.DireccionLugar, lug);
            return ret;
        }

        public DsRecursos GetRecursosActivos()
        {
            var ret = new DsRecursos();
            recursosActivosTableAdapter1.Fill(ret.RecursosActivos);
            return ret;
        }

        public DsPrestacionesResumen GetPrestacionesResumen(string agendada)
        {
            var ret = new DsPrestacionesResumen();
            prestacionesResumenTableAdapter1.Fill(ret.PrestacionesResumen,agendada);
            return ret;
        }

        public DateTime HoraActual()
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT getdate()", connection);
                connection.Open();
                return (DateTime) command.ExecuteScalar();
            }
        }

        public DateTime Hoy()
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT DATEADD(dd, 0, DATEDIFF(dd, 0, GETDATE()))", connection);
                connection.Open();
                return (DateTime)command.ExecuteScalar();
            }
        }

        public void MarcarPrestacionComoVista(int idPrestacion)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "UPDATE dbo.Prestaciones SET VistaPorElDespachador=1 WHERE idPrestacion=@idPrestacion",
                        connection);
                var xidPrestacion = command.Parameters.Add("idPrestacion", SqlDbType.Int);
                xidPrestacion.Value = idPrestacion;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public int PrestacionDelDestinoRecurso(int idDestinoRecurso)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "dbo.PrestacionDelDestinoRecurso",
                        connection) {CommandType = CommandType.StoredProcedure};
                var xidDestinoRecurso = command.Parameters.Add("idDestinoRecurso", SqlDbType.Int);
                xidDestinoRecurso.Value = idDestinoRecurso;
                connection.Open();
                var retorno = (int) command.ExecuteScalar();
                return retorno;
            }
        }

        public string GetProcesoPrestaciones(string desde,
                                             string hasta,
                                             string desdeHora,
                                             string hastaHora,
                                             string nroPrestacion,
                                             int idCobertura,
                                             int idTipoDeDestino,
                                             int idCliente,
                                             int idContrato,
                                             int idRubro,
                                             int idCodigo,
                                             int idEntidadDeCobranza,
                                             string paciente,
                                             string hC,
                                             int idLocalidad,
                                             int idCalle,
                                             string telefono,
                                             int idMovil,
                                             int tiempoDeLlegada,
                                             int idMedico,
                                             int idParamedico,
                                             int idChofer,
                                             int idMotivo,
                                             int idDiagnostico,
                                             int idMedicamento,
                                             int internacion,
                                             int idLugar,
                                             int idTomador,
                                             int idDespachador,
                                             int verCanceladas,
                                             int cuentaPacientes
            )
        {
            string retorno;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                SqlParameter xProceso;
                using (var command = new SqlCommand("dbo.SeleccionDePrestaciones", connection) {CommandType = CommandType.StoredProcedure})
                {
                    xProceso = command.Parameters.Add("@proceso", SqlDbType.VarChar, 255);
                    xProceso.Direction = ParameterDirection.Output;
                    var xDesde = command.Parameters.Add("@desde", SqlDbType.VarChar, 8);
                    xDesde.Value = desde;
                    var xHasta = command.Parameters.Add("@hasta", SqlDbType.VarChar, 8);
                    xHasta.Value = hasta;
                    var xDesdeHora = command.Parameters.Add("@desdeHora", SqlDbType.VarChar, 5);
                    xDesdeHora.Value = desdeHora;
                    var xHastaHora = command.Parameters.Add("@hastaHora", SqlDbType.VarChar, 5);
                    xHastaHora.Value = hastaHora;
                    var xVerCanceladas = command.Parameters.Add("@verCanceladas", SqlDbType.Int);
                    xVerCanceladas.Value = verCanceladas;
                    var xNroPrestacion = command.Parameters.Add("@nroPrestacion", SqlDbType.VarChar);
                    xNroPrestacion.Value = nroPrestacion;
                    var xIdCobertura = command.Parameters.Add("@idCobertura", SqlDbType.Int);
                    xIdCobertura.Value = idCobertura;
                    var xIdTipoDeDestino = command.Parameters.Add("@idTipoDeDestino", SqlDbType.Int);
                    xIdTipoDeDestino.Value = idTipoDeDestino;
                    var xIdCliente = command.Parameters.Add("@idCliente", SqlDbType.Int);
                    xIdCliente.Value = idCliente;
                    var xIdContrato = command.Parameters.Add("@idContrato", SqlDbType.Int);
                    xIdContrato.Value = idContrato;
                    var xIdRubro = command.Parameters.Add("@idRubro", SqlDbType.Int);
                    xIdRubro.Value = idRubro;
                    var xIdCodigo = command.Parameters.Add("@idCodigo", SqlDbType.Int);
                    xIdCodigo.Value = idCodigo;
                    var xIdEntidadDeCobranza = command.Parameters.Add("@idEntidadDeCobranza", SqlDbType.Int);
                    xIdEntidadDeCobranza.Value = idEntidadDeCobranza;
                    var xPaciente = command.Parameters.Add("@paciente", SqlDbType.VarChar);
                    xPaciente.Value = paciente;
                    var xHC = command.Parameters.Add("@hC", SqlDbType.VarChar);
                    xHC.Value = hC;
                    var xIdLocalidad = command.Parameters.Add("@idLocalidad", SqlDbType.Int);
                    xIdLocalidad.Value = idLocalidad;
                    var xIdCalle = command.Parameters.Add("@idCalle", SqlDbType.Int);
                    xIdCalle.Value = idCalle;
                    var xTelefono = command.Parameters.Add("@telefono", SqlDbType.VarChar);
                    xTelefono.Value = telefono;
                    var xIdMovil = command.Parameters.Add("@idMovil", SqlDbType.Int);
                    xIdMovil.Value = idMovil;
                    var xTiempoDeLlegada = command.Parameters.Add("@tiempoDeLlegada", SqlDbType.Int);
                    xTiempoDeLlegada.Value = tiempoDeLlegada;
                    var xIdMedico = command.Parameters.Add("@idMedico", SqlDbType.Int);
                    xIdMedico.Value = idMedico;
                    var xIdParamedico = command.Parameters.Add("@idParamedico", SqlDbType.Int);
                    xIdParamedico.Value = idParamedico;
                    var xIdChofer = command.Parameters.Add("@idChofer", SqlDbType.Int);
                    xIdChofer.Value = idChofer;
                    var xIdMotivo = command.Parameters.Add("@idMotivo", SqlDbType.Int);
                    xIdMotivo.Value = idMotivo;
                    var xIdDiagnostico = command.Parameters.Add("@idDiagnostico", SqlDbType.Int);
                    xIdDiagnostico.Value = idDiagnostico;
                    var xIdMedicamento = command.Parameters.Add("@idMedicamento", SqlDbType.Int);
                    xIdMedicamento.Value = idMedicamento;
                    var xInternacion = command.Parameters.Add("@internacion", SqlDbType.Int);
                    xInternacion.Value = internacion;
                    var xIdLugar = command.Parameters.Add("@idLugar", SqlDbType.Int);
                    xIdLugar.Value = idLugar;
                    var xIdTomador = command.Parameters.Add("@idTomador", SqlDbType.Int);
                    xIdTomador.Value = idTomador;
                    var xIdDespachador = command.Parameters.Add("@idDespachador", SqlDbType.Int);
                    xIdDespachador.Value = idDespachador;
                    var xCuentaPacientes = command.Parameters.Add("@cuentaPacientes", SqlDbType.Int);
                    xCuentaPacientes.Value = cuentaPacientes;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                retorno = xProceso.Value.ToString();
            }
            return retorno;
        }

        public string GetProcesoPrestacionesCliente(string desde,
                                             string hasta,
                                             int idCliente
            )
        {
            string retorno;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                SqlParameter xProceso;
                using (var command = new SqlCommand("dbo.SeleccionPrestacionesCliente", connection) { CommandType = CommandType.StoredProcedure })
                {
                    xProceso = command.Parameters.Add("@proceso", SqlDbType.VarChar, 255);
                    xProceso.Direction = ParameterDirection.Output;
                    var xDesde = command.Parameters.Add("@desde", SqlDbType.VarChar, 8);
                    xDesde.Value = desde;
                    var xHasta = command.Parameters.Add("@hasta", SqlDbType.VarChar, 8);
                    xHasta.Value = hasta;
                    var xIdCliente = command.Parameters.Add("@idCliente", SqlDbType.Int);
                    xIdCliente.Value = idCliente;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                retorno = xProceso.Value.ToString();
            }
            return retorno;
        }

        public int ContarPrestaciones(string proceso)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT count(*) FROM dbo.Ids WHERE Proceso = @proceso",
                        connection);
                var xProceso = command.Parameters.Add("@proceso", SqlDbType.VarChar, 255);
                xProceso.Value = proceso;
                connection.Open();
                var retorno = (int) command.ExecuteScalar();
                return retorno;
            }
        }

        public DsPrestacionesResumen GetPrestacionesAModificar(string proceso)
        {
            var ret = new DsPrestacionesResumen();
            prestacionesResumenTableAdapter1.FillByProceso(ret.PrestacionesResumen, proceso);
            return ret;
        }

        public DsBuscarPacientes GetPacientesPorNombre(string frase)
        {
            var ret = new DsBuscarPacientes();
            buscarPacientesTableAdapter1.FillByNombrePaciente(ret.BuscarPacientes, frase);
            return ret;
        }

        public void HacerComprobantePrestacion(int idPrestacion)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.HacerComprobantePrestacion", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var xIdPrestacion = command.Parameters.Add("@idPrestacion", SqlDbType.Int);
                xIdPrestacion.Value = idPrestacion;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DsComprobantePrestacion GetComprobantePrestacion(int idPrestacion)
        {
            var ret = new DsComprobantePrestacion();
            comprobantePrestacionTableAdapter1.Fill(ret.ComprobantePrestacion, idPrestacion);
            return ret;
        }

        public DsPersonalPrestacion GetPersonalPrestacion(int idPrestacion)
        {
            var ret = new DsPersonalPrestacion();
            personalPrestacionTableAdapter1.Fill(ret.PersonalPrestacion, idPrestacion);
            return ret;
        }

        public DsPrestacionesSinCobrador GetPrestacionesSinCobrador()
        {
            var ret = new DsPrestacionesSinCobrador();
            prestacionesSinCobradorTableAdapter1.Fill(ret.PrestacionesSinCobrador);
            return ret;
        }

        public DsPrestacionesSinCobrador UpdatePrestacionesSinCobrador(DsPrestacionesSinCobrador prest)
        {
            try
            {
                prestacionesSinCobradorTableAdapter1.Update(prest);
            }
            catch
            {
                return null;
            }
            return prest;
        }

        public void AsignarCobradorAPrestaciones(string proceso)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.AsignarCobradorAPrestaciones", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var xProceso = command.Parameters.Add("@proceso", SqlDbType.VarChar, 255);
                xProceso.Value = proceso;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DsPrestacionesConSaldo GetPrestacionesConSaldo()
        {
            var ret = new DsPrestacionesConSaldo();
            prestacionesConSaldoTableAdapter1.SetTimeOut();
            prestacionesConSaldoTableAdapter1.Fill(ret.PrestacionesConSaldo);
            return ret;
        }

        public DsPrestacionesConSaldo GetPrestacionesConSaldoNeg()
        {
            var ret = new DsPrestacionesConSaldo();
            prestacionesConSaldoTableAdapter1.SetTimeOut();
            prestacionesConSaldoTableAdapter1.FillSaldoNeg(ret.PrestacionesConSaldo);
            return ret;
        }

        public DsPacientesIncompletos GetPacientesIncompletos()
        {
            var ret = new DsPacientesIncompletos();
            pacientesIncompletosTableAdapter1.Fill(ret.PacientesIncompletos);
            return ret;
        }
        public DsRepResumenPrestacionesPorCliente GetResumenPrestacionesPorCliente(string desde, string hasta)
        {
            var ret = new DsRepResumenPrestacionesPorCliente();
            resumenPrestacionesPorClienteTableAdapter1.Fill(ret.ResumenPrestacionesPorCliente, desde, hasta);
            return ret;
        }
        public DsRepResumenPrestacionesPorCliente GetResumenPrestacionesPorClienteSoloDomicilios(string desde, string hasta)
        {
            var ret = new DsRepResumenPrestacionesPorCliente();
            resumenPrestacionesPorClienteSoloDomiciliosTableAdapter1.SetTimeOut();
            resumenPrestacionesPorClienteSoloDomiciliosTableAdapter1.Fill(ret.ResumenPrestacionesPorClienteSoloDomicilios, desde, hasta);
            return ret;
        }
        public string MotivosDelPaciente(int idPaciente)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT dbo.MotivosDelPaciente(@idPaciente)",
                        connection);
                command.Parameters.AddWithValue("@idPaciente", idPaciente);
                connection.Open();
                var retorno = command.ExecuteScalar().ToString();
                return retorno;
            }
        }
        public string DireccionCompletaDelDestino(int idDestino)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT REPLACE(REPLACE(REPLACE(dbo.DireccionCompleta(( SELECT idDireccion FROM dbo.Direcciones WHERE idDestino = @idDestino)), CHAR(10), ' '), CHAR(13), ' '), CHAR(9), ' ')",
                        connection);
                command.Parameters.AddWithValue("@idDestino", idDestino);
                connection.Open();
                var retorno = command.ExecuteScalar().ToString();
                return retorno;
            }
        }
    }
}
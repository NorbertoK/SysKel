using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Administración.Properties;

namespace Administración
{
    using System.Transactions;

    public partial class CmpFacturacionMensualAfiliados : Component
    {
        public CmpFacturacionMensualAfiliados()
        {
            InitializeComponent();
        }


        public int CantidadDeComprobantesRealizados(string periodo1, int idTipoDeCobranza1, int idEntidadDeCobranza1, int jubilado1)
        {
            int cantidad;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.HacerComprobantes", connection)
                                  {
                                      CommandType = CommandType.StoredProcedure,
                                      CommandTimeout = 0
                                  };
                var periodo = command.Parameters.Add("@periodo", SqlDbType.VarChar, 7);
                periodo.Value = periodo1;
                var idTipoDeCobranza = command.Parameters.Add("@idTipoDeCobranza", SqlDbType.Int);
                idTipoDeCobranza.Value = idTipoDeCobranza1;
                var idEntidadDeCobranza = command.Parameters.Add("@idEntidadDeCobranza", SqlDbType.Int);
                idEntidadDeCobranza.Value = idEntidadDeCobranza1;
                var jubilado = command.Parameters.Add("@jubilado", SqlDbType.Int);
                jubilado.Value = jubilado1;
                var cantGrupos = command.Parameters.Add("@cantComprobantes", SqlDbType.Int);
                cantGrupos.Direction = ParameterDirection.Output;
                connection.Open();
                command.ExecuteNonQuery();
                cantidad = (int) cantGrupos.Value;
            }
            return cantidad;
        }

        public int CantidadDeComprobantesManualesRealizados(int idGrupo, string periodo, string fecha, string proceso, bool ponerCobrador)
        {
            int cantidad;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.HacerComprobanteCuota", connection)
                                  {
                                      CommandType = CommandType.StoredProcedure,
                                      CommandTimeout = 0
                                  };
                var xIdGrupo = command.Parameters.Add("@idGrupo", SqlDbType.Int);
                xIdGrupo.Value = idGrupo;
                var xPeriodo = command.Parameters.Add("@periodo", SqlDbType.VarChar, 7);
                xPeriodo.Value = periodo;
                var xFecha = command.Parameters.Add("@fecha", SqlDbType.VarChar, 8);
                xFecha.Value = fecha;
                var xProceso = command.Parameters.Add("@proceso", SqlDbType.VarChar, 255);
                xProceso.Value = proceso;
                var xPonerCobrador = command.Parameters.Add("@ponerCobrador", SqlDbType.Bit);
                xPonerCobrador.Value = ponerCobrador;
                var ret = command.Parameters.Add("@ReturnValue", SqlDbType.Int);
                ret.Direction = ParameterDirection.ReturnValue;
                connection.Open();
                command.ExecuteNonQuery();
                cantidad = (int) ret.Value;
            }
            return cantidad;
        }

        public int CantidadDeComprobantesDeFacturasRealizados(int idTandaDeFacturacion, string fecha, string periodo)
        {
            int cantidad;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.HacerComprobantesFacturas", connection)
                                  {
                                      CommandType = CommandType.StoredProcedure,
                                      CommandTimeout = 0
                                  };
                var xIdTandaDeFacturacion = command.Parameters.Add("@idTandaDeFacturacion", SqlDbType.Int);
                xIdTandaDeFacturacion.Value = idTandaDeFacturacion;
                var xFecha = command.Parameters.Add("@fecha", SqlDbType.VarChar, 8);
                xFecha.Value = fecha;
                var xPeriodo = command.Parameters.Add("@periodo", SqlDbType.VarChar, 7);
                xPeriodo.Value = periodo;
                var cantFacturas = command.Parameters.Add("@cantidadFacturas", SqlDbType.Int);
                cantFacturas.Direction = ParameterDirection.Output;
                connection.Open();
                command.ExecuteNonQuery();
                cantidad = (int) cantFacturas.Value;
            }
            return cantidad;
        }

        public int CantidadDeComprobantesFacturasPorFacturaProforma(int idFacturaProforma, string periodo, string fecha,
                                                                    string proceso, bool ponerCobrador)
        {
            int cantidad;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.HacerComprobanteFactura", connection)
                                  {
                                      CommandType = CommandType.StoredProcedure,
                                      CommandTimeout = 0
                                  };
                var xIdFacturaProforma = command.Parameters.Add("@idFacturaProforma", SqlDbType.Int);
                xIdFacturaProforma.Value = idFacturaProforma;
                var xFecha = command.Parameters.Add("@fecha", SqlDbType.VarChar, 8);
                xFecha.Value = fecha;
                var xPeriodo = command.Parameters.Add("@periodo", SqlDbType.VarChar);
                xPeriodo.Value = periodo;
                var xProceso = command.Parameters.Add("@proceso", SqlDbType.VarChar, 255);
                xProceso.Value = proceso;
                var xPonerCobrador = command.Parameters.Add("@ponerCobrador", SqlDbType.Bit);
                xPonerCobrador.Value = ponerCobrador;
                var cantFacturas = command.Parameters.Add("@cantidadFacturas", SqlDbType.Int);
                cantFacturas.Direction = ParameterDirection.Output;
                connection.Open();
                command.ExecuteNonQuery();
                cantidad = (int) cantFacturas.Value;
            }
            return cantidad;
        }

        public int CantidadDeBajasAutomaticas(string periodo1, int idGrabador1, string proceso1)
        {
            int cantidad;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.BajasAutomaticas", connection)
                                  {
                                      CommandType = CommandType.StoredProcedure,
                                      CommandTimeout = 0
                                  };
                var periodo = command.Parameters.Add("@periodoActual", SqlDbType.VarChar,7);
                periodo.Value = periodo1;
                var idGrabador = command.Parameters.Add("@idGrabador", SqlDbType.Int);
                idGrabador.Value = idGrabador1;
                var cantGrupos = command.Parameters.Add("@cantBajas", SqlDbType.Int);
                cantGrupos.Direction = ParameterDirection.Output;
                var proceso = command.Parameters.Add("@proceso", SqlDbType.VarChar,255);
                proceso.Value = proceso1;
                connection.Open();
                command.ExecuteNonQuery();
                cantidad = (int) cantGrupos.Value;
            }
            return cantidad;
        }

        public string PrimerPeriodoSinFacturarGrupo(int idGrupo)
        {
            string periodo;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT	dbo.PeriodoAFacturarAfiliados(@idGrupo)",
                        connection);
                var xIdGrupo = command.Parameters.Add("@idGrupo", SqlDbType.Int);
                xIdGrupo.Value = idGrupo;
                connection.Open();
                periodo = command.ExecuteScalar().ToString();
            }
            return periodo;
        }

        public string PrimerPeriodoSinFacturarFacturaProforma(int idFacturaProforma)
        {
            string periodo;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT	dbo.PeriodoAFacturarClientes(@idFacturaProforma)",
                        connection);
                var xIdFacturaProforma = command.Parameters.Add("@idFacturaProforma", SqlDbType.Int);
                xIdFacturaProforma.Value = idFacturaProforma;
                connection.Open();
                periodo = command.ExecuteScalar().ToString();
            }
            return periodo;
        }

        public DsTipoDeCobranzaDelGrupo GetTipoDeCobranzaDelGrupo(int idGrupo)
        {
            var ret = new DsTipoDeCobranzaDelGrupo();
            tipoDeCobranzaDelGrupoTableAdapter1.Fill(ret.TipoDeCobranzaDelGrupo, idGrupo);
            return ret;
        }
        public void FacturacionComprobantesManuales(string proceso, string afiliadoOCliente)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "dbo.FacturacionComprobantesManuales",
                        connection) {CommandType = CommandType.StoredProcedure};
                var xProceso = command.Parameters.Add("@proceso", SqlDbType.VarChar,255);
                xProceso.Value = proceso;
                var xAfiliadoOCliente = command.Parameters.Add("@afiladoOCliente", SqlDbType.VarChar, 1);
                xAfiliadoOCliente.Value = afiliadoOCliente;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public DsDescuentosGrupoNumeroso GetDescuentosGrupoNumeroso()
        {
            var ret = new DsDescuentosGrupoNumeroso();
            descuentosGrupoNumerosoTableAdapter1.Fill(ret.DescuentosGrupoNumeroso);
            return ret;
        }
        public DsDescuentosGrupoNumeroso UpdateDescuentosGrupoNumeroso(DsDescuentosGrupoNumeroso desc)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    descuentosGrupoNumerosoTableAdapter1.Update(desc);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return desc;
            }
        }
    }
}
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Administración.Properties;

namespace Administración
{
    public partial class CmpCaja : Component
    {
        public CmpCaja()
        {
            InitializeComponent();
        }

        public decimal GetEfectivoEnCaja(int idEmpleado)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.EfectivoEnCaja", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var xIdEmpleado = command.Parameters.Add("@idEmpleado", SqlDbType.Int);
                xIdEmpleado.Value = idEmpleado;
                connection.Open();
                var result = (decimal) command.ExecuteScalar();
                return result;
            }
        }

        public DsEnCaja GetValoresEmpleado(int idempleado)
        {
            var ret = new DsEnCaja();
            enCajaTableAdapter1.Fill(ret.EnCaja, idempleado);
            return ret;
        }

        public DsTransferencias UpdateTransferencia(DsTransferencias trans)
        {
            try
            {
                transferenciasTableAdapter1.Update(trans.Transferencias);
            }
            catch
            {
                return null;
            }
            return trans;
        }

        public DsTransferencias UpdateValoresTransferencia(DsTransferencias trans)
        {
            try
            {
                valoresTransferenciasTableAdapter1.Update(trans.ValoresTransferencias);
            }
            catch
            {
                return null;
            }
            return trans;
        }

        public string ProcesarTransferencia(int idTransferencia)
        {
            string resultado;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.ProcesarTransferencia", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var xIdTransferencia = command.Parameters.Add("@idTransferencia", SqlDbType.Int);
                xIdTransferencia.Value = idTransferencia;
                var xResultado = command.Parameters.Add("@resultado", SqlDbType.VarChar, 2);
                xResultado.Direction = ParameterDirection.Output;
                connection.Open();
                command.ExecuteNonQuery();
                resultado = xResultado.Value.ToString();
            }
            return resultado;
        }

        public DsReporteTransferencia GetReporteTransferencia(int idTransferencia)
        {
            var ret = new DsReporteTransferencia();
            reporteTransferenciasCabeceraTableAdapter1.Fill(ret.ReporteTransferenciasCabecera, idTransferencia);
            reporteTransferenciaTableAdapter1.Fill(ret.ReporteTransferencia, idTransferencia);
            return ret;
        }

        public DsRetiros UpdateRetiro(DsRetiros ret)
        {
            try
            {
                retirosTableAdapter1.Update(ret.Retiros);
            }
            catch
            {
                return null;
            }
            return ret;
        }

        public DsRetiros UpdateValoresRetiro(DsRetiros ret)
        {
            try
            {
                valoresRetirosTableAdapter1.Update(ret.ValoresRetiros);
            }
            catch
            {
                return null;
            }
            return ret;
        }

        public string ProcesarRetiro(int idRetiro)
        {
            string resultado;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.ProcesarRetiro", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var xIdRetiro = command.Parameters.Add("@idRetiro", SqlDbType.Int);
                xIdRetiro.Value = idRetiro;
                var xResultado = command.Parameters.Add("@resultado", SqlDbType.VarChar, 2);
                xResultado.Direction = ParameterDirection.Output;
                connection.Open();
                command.ExecuteNonQuery();
                resultado = xResultado.Value.ToString();
            }
            return resultado;
        }

        public DsReporteRetiro GetReporteRetiro(int idRetiro)
        {
            var ret = new DsReporteRetiro();
            retiroReporteCabeceraTableAdapter1.Fill(ret.ReporteRetiroCabecera, idRetiro);
            reporteRetiroTableAdapter1.Fill(ret.ReporteRetiro, idRetiro);
            return ret;
        }

        public DsReintegros UpdateRintegro(DsReintegros ret)
        {
            try
            {
                reintegrosTableAdapter1.Update(ret.Reintegros);
            }
            catch
            {
                return null;
            }
            return ret;
        }

        public string ProcesarReintegro(int idReintegro)
        {
            string resultado;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.ProcesarReintegro", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var xIdReintegro = command.Parameters.Add("@idReintegro", SqlDbType.Int);
                xIdReintegro.Value = idReintegro;
                var xResultado = command.Parameters.Add("@resultado", SqlDbType.VarChar, 2);
                xResultado.Direction = ParameterDirection.Output;
                connection.Open();
                command.ExecuteNonQuery();
                resultado = xResultado.Value.ToString();
            }
            return resultado;
        }

        public DsReporteReintegro GetReporteReintegro(int idReintegro)
        {
            var ret = new DsReporteReintegro();
            reporteReintegrosTableAdapter1.Fill(ret.ReporteReintegros, idReintegro);
            return ret;
        }

        public DsCaja GetCaja(int idEmpleado, string desde, string hasta)
        {
            var ret = new DsCaja();
            cajaTableAdapter1.Fill(ret.Caja, idEmpleado, desde, hasta);
            return ret;
        }

        public DsCajas GetCajas()
        {
            var ret = new DsCajas();
            enCajaTodosTableAdapter1.Fill(ret.EnCajaTodos);
            return ret;
        }
    }
}
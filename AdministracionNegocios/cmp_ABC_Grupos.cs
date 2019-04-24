using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Administración.Properties;

namespace Administración
{
    public partial class CmpABCGrupos : Component
    {
        public CmpABCGrupos()
        {
            InitializeComponent();
        }

        public DsBuscarAfiliados GetBuscarAfiliados(string frase)
        {
            var ret = new DsBuscarAfiliados();
            buscarAfiliadosTableAdapter1.Fill(ret.BuscarAfiliados, frase);
            if (ret.BuscarAfiliados.Count == 0)
            {
                ret.BuscarAfiliados.Rows.Add(0);
                ret.BuscarAfiliados[0].Nombre = "Ningún Resultado";
            }
            return ret;
        }

        public DsBuscarAfiliados GetBuscarAfiliadosPropios(string frase)
        {
            var ret = new DsBuscarAfiliados();
            buscarAfiliadosTableAdapter1.FillByPropios(ret.BuscarAfiliados, frase);
            if (ret.BuscarAfiliados.Count == 0)
            {
                ret.BuscarAfiliados.Rows.Add(0);
                ret.BuscarAfiliados[0].Nombre = "Ningún Resultado";
            }
            return ret;
        }

        public DsBuscarAfiliadosActivos GetBuscarAfiliadosActivos(string frase)
        {
            var ret = new DsBuscarAfiliadosActivos();
            buscarAfiliadosActivosTableAdapter1.Fill(ret.BuscarAfiliadosActivos, frase);
            if (ret.BuscarAfiliadosActivos.Count == 0)
            {
                ret.BuscarAfiliadosActivos.Rows.Add(0);
                ret.BuscarAfiliadosActivos[0].Nombre = "Ningún Resultado";
            }
            return ret;
        }

        public DsFechasBajasAutomaticas GetFechasBajasAutomaticas()
        {
            var ret = new DsFechasBajasAutomaticas();
            fechasBajasAutomaticasTableAdapter1.Fill(ret.FechasBajasAutomaticas);
            return ret;
        }

        public void ReporteBajasAutomaticas(string proceso, string fecha)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.ReporteBajasAutomaticas", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var xProceso = command.Parameters.Add("@proceso", SqlDbType.VarChar, 255);
                xProceso.Value = proceso;
                var xFecha = command.Parameters.Add("@fecha", SqlDbType.VarChar, 17);
                xFecha.Value = fecha;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public int ImportarPadron(string proceso,  int idPlan, string fechaSolicitudes, int idGrabador)
        {
            int resultado;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.ImportarPadron", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var xproceso = command.Parameters.Add("@proceso", SqlDbType.VarChar, 255);
                xproceso.Value = proceso;
                var xidPlan = command.Parameters.Add("@idPlan", SqlDbType.Int);
                xidPlan.Value = idPlan;
                var xFechaSolicitudes = command.Parameters.Add("@FechaSolicitudes", SqlDbType.VarChar, 8);
                xFechaSolicitudes.Value = fechaSolicitudes;
                var xidGrabador = command.Parameters.Add("@idGrabador", SqlDbType.Int);
                xidGrabador.Value = idGrabador;
                var ret = command.Parameters.Add("@ReturnValue", SqlDbType.Int);
                ret.Direction = ParameterDirection.ReturnValue;
                connection.Open();
                command.ExecuteNonQuery();
                resultado = (int) ret.Value;
            }
            return resultado;
        }
    }
}
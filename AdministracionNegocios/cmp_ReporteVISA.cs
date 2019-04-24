using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Administración.Properties;

namespace Administración
{
    public partial class CmpReporteVISA : Component
    {
        public CmpReporteVISA()
        {
            InitializeComponent();
        }

        public DsReporteVISA GetReporteVISA(string periodo)
        {
            var ret = new DsReporteVISA();
            reporteVISATableAdapter1.Fill(ret.ReporteVISA, periodo);
            return ret;
        }

        public DsReporteKadicard GetReporteKadicard(string periodo)
        {
            var ret = new DsReporteKadicard();
            reporteKADICARDTableAdapter1.Fill(ret.ReporteKADICARD, periodo);
            return ret;
        }

        public DsReporteNaranja GetReporteNaranja(string periodo)
        {
            var ret = new DsReporteNaranja();
            reporteNARANJATableAdapter1.Fill(ret.ReporteNARANJA, periodo);
            return ret;
        }

        public DsReporteNaranja GetReporteNaranjaInforme(string periodo)
        {
            var ret = new DsReporteNaranja();
            reporteNaranjaInformeTableAdapter1.Fill(ret.ReporteNaranjaInforme, periodo);
            return ret;
        }

        public DsReporteMacro GetBancoMacroArchivo(string periodo, int jubilado, int secuencial, int rectificativa)
        {
            var ret =new DsReporteMacro();
            reporteMacroTableAdapter1.Fill(ret.ReporteMacro, periodo, jubilado, secuencial, rectificativa);
            return ret;
        }
        public DsReporteMacro GetReporteMacro(bool jubilado, string periodo)
        {
            var ret = new DsReporteMacro();
            bancoMacroTableAdapter1.Fill(ret.BancoMacro, jubilado, periodo);
            return ret;
        }
        public DsReporteMacro GetArgencardArchivo(string periodo)
        {
            var ret = new DsReporteMacro();
            reporteArgencardTableAdapter1.Fill(ret.ReporteArgencard, periodo);
            return ret;
        }
        public DsReporteMacro GetReporteArgencard(string periodo)
        {
            var ret = new DsReporteMacro();
            argencardTableAdapter1.Fill(ret.Argencard, periodo);
            return ret;
        }

        public string MensajeDebitoAutomatico(string periodo)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT COUNT(*) FROM Facturaciones WHERE Periodo = @periodo AND idTipoDeCobranza = 2",
                        connection);
                var xPeriodo = command.Parameters.Add("@periodo", SqlDbType.VarChar, 7);
                xPeriodo.Value = periodo;
                connection.Open();
                var afiliados = (int) command.ExecuteScalar();
                command.CommandText =
                    "SELECT COUNT(*) FROM Facturaciones WHERE Periodo = @periodo AND idTandaDeFacturacion = (SELECT TOP 1 TandaDebitoAutomatico FROM Sistemas)";
                var clientes = (int) command.ExecuteScalar();
                if (afiliados == 0)
                {
                    return clientes == 0 ? "Ambos" : "Afiliados";
                }
                return clientes == 0 ? "Clientes" : "Ninguno";
            }
        }
    }
}
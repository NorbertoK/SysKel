using System.ComponentModel;

namespace Administración
{
    public partial class CmpRepEstPrest : Component
    {
        public CmpRepEstPrest()
        {
            InitializeComponent();
        }

        public DsRepPrestCodigoLocalidad GetPrestCodigoLocalidad(string desde, string hasta)
        {
            var ret = new DsRepPrestCodigoLocalidad();
            estPrestCodigoLocalidadTableAdapter1.Fill(ret.EstPrestCodigoLocalidad, desde, hasta);
            return ret;
        }
        public DsDatosPrestaciones GetDatosPrestaciones(string desde, string hasta)
        {
            var ret = new DsDatosPrestaciones();
            datosPrestacionesTableAdapter1.SetTimeOut();
            datosPrestacionesTableAdapter1.Fill(ret.DatosPrestaciones, desde, hasta);
            return ret;
        }

        public DsRepPrestLocalidadMotivoCodigo GetPrestLocalidadMotivoCodigo(string desde, string hasta)
        {
            var ret = new DsRepPrestLocalidadMotivoCodigo();
            estPrestLocalidadMotivoCodigoTableAdapter1.Fill(ret.EstPrestLocalidadMotivoCodigo, desde, hasta);
            return ret;
        }
        public DsRepPrestMedicamentosUtilizados GetRepPrestMedicamentosUtilizados(string desde, string hasta)
        {
            var ret = new DsRepPrestMedicamentosUtilizados();
            medicamentosUtilizadosTableAdapter1.Fill(ret.MedicamentosUtilizados, desde, hasta);
            return ret;
        }
        public DsRepTasaDeUso GetTasaDeUso(string modo, string periodoDesde, string periodoHasta)
        {
            var ret = new DsRepTasaDeUso();
            tasaDeUsoTableAdapter1.SetTimeOut();
            tasaDeUsoTableAdapter1.Fill(ret.TasaDeUso, modo, periodoDesde, periodoHasta);
            return ret;
        }

        public DsTasaDeUsoClientes GetTasaDeUsoClientes(string periodoDesde, string periodoHasta)
        {
            var ret = new DsTasaDeUsoClientes();
            estadisticaTasaDeUsoClientesTableAdapter1.Fill(ret.EstadisticaTasaDeUsoClientes, periodoDesde, periodoHasta);
            return ret;
        }
        public DsTasaDeUsoAfYCli GetTasaDeUsoAfYCli(string periodoDesde, string periodoHasta)
        {
            var ret = new DsTasaDeUsoAfYCli();
            estadisticaTasaDeUsoAfYCliTableAdapter1.Fill(ret.EstadisticaTasaDeUsoAfYCli, periodoDesde, periodoHasta);
            return ret;
        }
    }
}
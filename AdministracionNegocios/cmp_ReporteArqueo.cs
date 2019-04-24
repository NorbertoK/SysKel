using System.ComponentModel;

namespace Administración
{
    public partial class CmpReporteArqueo : Component
    {
        public CmpReporteArqueo()
        {
            InitializeComponent();
        }

        public CmpReporteArqueo(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public DsReportArqueo ObtenerDatosArqueo(int idArqueo)
        {
            var ret = new DsReportArqueo();
            arqueoTableAdapter1.Fill(ret.Arqueo, idArqueo);
            comprobantesFaltantesTableAdapter1.Fill(ret.ComprobantesFaltantes, idArqueo);
            comprobantesRetenidosTableAdapter1.Fill(ret.ComprobantesRetenidos, idArqueo);
            comprobantesQueVuelvenAlCobradorTableAdapter1.Fill(ret.ComprobantesQue_VuelvenAlCobrador, idArqueo);
            return ret;
        }
    }
}
using System.ComponentModel;

namespace Administración
{
    public partial class CmpReporteRemesa : Component
    {
        public CmpReporteRemesa()
        {
            InitializeComponent();
        }

        public DsReportRemesa GetReporteRemesa(int idRemesa)
        {
            var ret = new DsReportRemesa();
            remesaTableAdapter1.Fill(ret.Remesa, idRemesa);
            comprobantesTableAdapter1.Fill(ret.Comprobantes, idRemesa);
            valoresTableAdapter1.Fill(ret.Valores, idRemesa);
            return ret;
        }
    }
}
using System.ComponentModel;

namespace Administración
{
    public partial class CmpReporteNdeC : Component
    {
        public CmpReporteNdeC()
        {
            InitializeComponent();
        }

        public DsRepNdeC GetRepNdeC(string desde, string hasta)
        {
            var ret = new DsRepNdeC();
            reporteNdeCTableAdapter1.Fill(ret.ReporteNdeC, desde, hasta);
            return ret;
        }
    }
}
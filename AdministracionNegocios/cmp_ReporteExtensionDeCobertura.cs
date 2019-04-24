using System.ComponentModel;

namespace Administración
{
    public partial class CmpReporteExtensionDeCobertura : Component
    {
        public CmpReporteExtensionDeCobertura()
        {
            InitializeComponent();
        }

        public DsReportExtensionDeCobertura GetReportExtensionDeCobertura(int idGrupo)
        {
            var ret = new DsReportExtensionDeCobertura();
            afiliadosTableAdapter1.Fill(ret.Afiliados, idGrupo);
            return ret;
        }
    }
}
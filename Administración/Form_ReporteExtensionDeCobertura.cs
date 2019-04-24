using System;
using Administraci�n.WS;

namespace Administraci�n
{
    public partial class FormReporteExtensionDeCobertura : Form1
    {
        public FormReporteExtensionDeCobertura()
        {
            InitializeComponent();
        }

        public int IdGrupo { get; set; }

        private void FormReporteExtensionDeCoberturaLoad(object sender, EventArgs e)
        {
            dsReportExtensionDeCobertura1.Merge(new Service().GetReportExtensionDeCobertura(IdGrupo, Program.Pin));
            crExtensionDeCoberturaAfiliados1.SetDataSource(dsReportExtensionDeCobertura1);
        }
    }
}
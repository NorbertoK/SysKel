using System;
using Administración.WS;

namespace Administración
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
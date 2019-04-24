using System;
using Administraci�n.WS;

namespace Administraci�n
{
    public partial class FormRepRetiro : FormCR
    {
        public FormRepRetiro()
        {
            InitializeComponent();
        }

        public int IdRetiro { get; set; }

        private void FormRepRetiroLoad(object sender, EventArgs e)
        {
            dsReporteRetiro1.Merge(new Service().GetReporteRetiro(IdRetiro, Program.Pin));
            crRetiro1.SetDataSource(dsReporteRetiro1);
        }
    }
}
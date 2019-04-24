using System;
using Direcci�n.WS;

namespace Direcci�n
{
    public partial class FormRepReintegro : FormCR
    {
        public FormRepReintegro()
        {
            InitializeComponent();
        }

        public int IdReintegro { get; set; }

        private void FormRepReintegroLoad(object sender, EventArgs e)
        {
            dsReporteReintegro1.Merge(new Service().GetReporteReintegro(IdReintegro, Program.Pin));
            crReintegro1.SetDataSource(dsReporteReintegro1);
        }
    }
}
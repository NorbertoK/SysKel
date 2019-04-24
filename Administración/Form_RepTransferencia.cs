using System;
using Administración.WS;

namespace Administración
{
    public partial class FormRepTransferencia : FormCR
    {
        public FormRepTransferencia()
        {
            InitializeComponent();
        }

        public int IdTransferencia { get; set; }

        private void FormRepTransferenciaLoad(object sender, EventArgs e)
        {
            dsReporteTransferencia1.Merge(new Service().GetReporteTransferencia(IdTransferencia, Program.Pin));
            crTransferencia1.SetDataSource(dsReporteTransferencia1);
        }
    }
}
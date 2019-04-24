using System;
using Administración.WS;

namespace Administración
{
    public partial class FormRepFacturasSinCAE : FormCR
    {
        public FormRepFacturasSinCAE()
        {
            InitializeComponent();
        }

        private void FormRepFacturasSinCAE_Load(object sender, EventArgs e)
        {
            dsFacturasSinCAE1.Merge(new Service().GetFacturaSinCAEParaReporte(Program.Pin));
            CR_FacturasSinCAE1.SetDataSource(dsFacturasSinCAE1);
        }
    }
}

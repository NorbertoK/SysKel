using System;
namespace Administración
{
    using WS;

    public partial class FormRepEntidadesSinLiquidar : FormCR
    {
        public FormRepEntidadesSinLiquidar()
        {
            InitializeComponent();
        }

        private void FormRepEntidadesSinLiquidarLoad(object sender, EventArgs e)
        {
            dsEntidadesSinLiquidar1.Merge(new Service().GetEntidadesSinLiquidar(Program.Pin));
            CR_EntidadesSinLiquidar1.SetDataSource(dsEntidadesSinLiquidar1);
        }
    }
}

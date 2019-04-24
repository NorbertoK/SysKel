using System;
using Administración.WS;

namespace Administración
{
    public partial class FormRepRenglonesAFacturar : FormCR
    {
        public FormRepRenglonesAFacturar()
        {
            InitializeComponent();
        }

        private void FormRepRenglonesAFacturarLoad(object sender, EventArgs e)
        {
            dsRepRenglonesAFacturar1.Merge(new Service().GetRenglonesAFacturar(Program.Pin));
            crRenglonesAFacturar1.SetDataSource(dsRepRenglonesAFacturar1);
        }
    }
}
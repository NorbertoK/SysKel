using System;
using Administraci�n.WS;

namespace Administraci�n
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
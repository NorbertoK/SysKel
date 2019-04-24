using System;
using Administración.WS;

namespace Administración
{
    public partial class FormReporteRemesa : Form1
    {
        private int _idremesa;

        public FormReporteRemesa()
        {
            InitializeComponent();
        }

        public int IdRemesa
        {
            get { return _idremesa; }
            set { _idremesa = value; }
        }

        private void FormReporteRemesaLoad(object sender, EventArgs e)
        {
            dsReportRemesa1.Merge(new Service().GetReporteRemesa(_idremesa, Program.Pin));
            crRemesa1.SetDataSource(dsReportRemesa1);
        }
    }
}
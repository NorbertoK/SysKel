using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cabina
{
    using WS;
    public partial class FormRepPago : FormCR
    {
        public FormRepPago()
        {
            InitializeComponent();
        }
        public int IdPago { get; set; }

        private void FormRepPagoLoad(object sender, EventArgs e)
        {
            dsReportPago1.Merge(new Service().GetReportPago(IdPago,Program.Pin));
            CR_ReportPago1.SetDataSource(dsReportPago1);
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    public partial class FormReportFacturadoYCobrado : Form1
    {
        public FormReportFacturadoYCobrado()
        {
            InitializeComponent();
        }

        private void Form_Report_FacturadoYCobrado_Load(object sender, EventArgs e)
        {
            var ahora = new Service().HoraActual(Program.Pin);
            ultraDateTimeEditorDesde.Value = ahora.AddDays(-(ahora.Day - 1)).AddMonths(-1);
            ultraDateTimeEditorHasta.Value = ahora.AddDays(-ahora.Day);
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var f = new FormRepFacturadoYCobrado
            {
                Desde = ((DateTime)ultraDateTimeEditorDesde.Value),
                Hasta = ((DateTime)ultraDateTimeEditorHasta.Value),
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            f.Show();
            Close();
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    public partial class FormReportPrestacionesPorCliente : Form1
    {
        public FormReportPrestacionesPorCliente()
        {
            InitializeComponent();
        }

        private void FormReportPrestacionesPorClienteLoad(object sender, EventArgs e)
        {
            var ahora = new Service().HoraActual(Program.Pin);
            ultraDateTimeEditorDesde.Value = ahora.AddDays(-(ahora.Day - 1)).AddMonths(-1);
            ultraDateTimeEditorHasta.Value = ahora.AddDays(-ahora.Day);
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var f = new FormRepPrestacionesPorCliente
            {
                Desde = (DateTime) ultraDateTimeEditorDesde.Value,
                Hasta = (DateTime) ultraDateTimeEditorHasta.Value,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            f.Show();
            Close();
        }
    }
}
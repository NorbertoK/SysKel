using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    public partial class FormReportHistPlanes : Form1
    {
        public FormReportHistPlanes()
        {
            InitializeComponent();
        }

        private void FormReportHistPlanesLoad(object sender, EventArgs e)
        {
            ultraCalendarCombo1.Value = new Service().Hoy(Program.Pin);
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var rep = new FormRepHistPlanes
                          {
                Titulo = "Modificaciones de los Planes desde el " + ultraCalendarCombo1.Text,
                Desde = (DateTime)ultraCalendarCombo1.Value,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            rep.Show();
            Close();
        }
    }
}

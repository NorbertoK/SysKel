using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    public partial class FormReportCantidadAfiliadosPorPlan : Form
    {
        public FormReportCantidadAfiliadosPorPlan()
        {
            InitializeComponent();
        }

        private void FormReportCantidadAfiliadosPorPlanLoad(object sender, EventArgs e)
        {
            ultraDateTimeEditor1.DateTime = new Service().HoraActual(Program.Pin);
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;
            var rep = new FormRepCantidadAfiliadosPlan
                          {
                              Fecha = ultraDateTimeEditor1.DateTime,
                              MdiParent = MdiParent,
                              StartPosition = FormStartPosition.Manual,
                              Location = new Point(0, 0)
                          };
            rep.Show();
            Close();
        }
    }
}
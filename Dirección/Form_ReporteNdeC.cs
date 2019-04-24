using System;
using System.Windows.Forms;
using Dirección.WS;

namespace Dirección
{
    public partial class FormReporteNdeC : Form
    {
        public FormReporteNdeC()
        {
            InitializeComponent();
        }

        private void FormEstPrestLoad(object sender, EventArgs e)
        {
            ultraCalendarComboDesde.Value = new Service().HoraActual(Program.Pin);
            ultraCalendarComboHasta.Value = new Service().HoraActual(Program.Pin);
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var frm = new FormRepNdeC
                          {
                              Desde = ((DateTime) ultraCalendarComboDesde.Value),
                              Hasta = ((DateTime) ultraCalendarComboHasta.Value),
                              MdiParent = MdiParent
                          };
            frm.Show();
            Close();
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
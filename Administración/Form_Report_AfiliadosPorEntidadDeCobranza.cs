using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormReportAfiliadosPorEntidadDeCobranza : Form
    {
        public FormReportAfiliadosPorEntidadDeCobranza()
        {
            InitializeComponent();
        }

        private void UltraCombo1RowSelected(object sender, RowSelectedEventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void FormReportAfiliadosPorEntidadDeCobranzaLoad(object sender, EventArgs e)
        {
            dsEntidadesDeCobranza.Merge(new Service().GetEntidadesDeCobranza(Program.Pin));
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var f = new FormRepAfiliadosPorEntidadDeCobranza
                        {
                            IdEntidadDeCobranza = ((int) ultraCombo1.Value),
                            EntidadDeCobranza = ultraCombo1.Text,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(0, 0),
                            MdiParent = MdiParent
                        };
            f.Show();
            Close();
        }
    }
}
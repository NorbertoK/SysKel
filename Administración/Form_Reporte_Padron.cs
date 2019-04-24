using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinEditors;

namespace Administración
{
    public partial class FormReportePadron : Form
    {
        public FormReportePadron()
        {
            InitializeComponent();
        }

        private void FormReportePadronLoad(object sender, EventArgs e)
        {
            ultraCalendarCombo1.Value = new Service().HoraActual(Program.Pin);
            dsZonas.Merge(new Service().GetZonas(Program.Pin));
        }

        private void UltraComboZonasItemNotInList(object sender, ValidationErrorEventArgs e)
        {
            if (e.InvalidText == "")
            {
                e.RetainFocus = false; // Permite que haya valores nulos.
            }
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;
            ultraLabel4.Visible = true;
            ultraLabel4.Update();
            var frm = new FormRepPadron {Fecha = ((DateTime) ultraCalendarCombo1.Value)};
            if (ultraComboZonas.Value == null)
            {
                frm.IdZona = 0;
                frm.NombreZona = "";
            }
            else
            {
                frm.IdZona = (int) ultraComboZonas.Value;
                frm.NombreZona = ultraComboZonas.Text;
            }
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
            Close();
        }
    }
}
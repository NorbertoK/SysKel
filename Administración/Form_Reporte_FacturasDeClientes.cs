using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormReporteFacturasDeClientes : Form
    {
        public FormReporteFacturasDeClientes()
        {
            InitializeComponent();
        }

        private void FormReporteFacturasDeClientesLoad(object sender, EventArgs e)
        {
            ultraDateTimeEditorPeriodo.DateTime = new Service().HoraActual(Program.Pin).Day < 21
                ? new Service().HoraActual(Program.Pin)
                : new Service().HoraActual(Program.Pin).AddMonths(1);
            dsPuntosDeVenta.Merge(new Service().GetPuntosDeVenta(Program.Pin));
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var fo = new FormRepInformeFacturasClientes
            {
                Periodo = ultraDateTimeEditorPeriodo.Text,
                IdPuntoDeVenta = ((int) ultraComboPuntosDeVenta.Value),
                PuntoDeVenta = ultraComboPuntosDeVenta.Text,
                MdiParent = MdiParent
            };
            fo.Show();
            Close();
        }

        private void UltraComboTandasDeFacturacionItemNotInList(object sender, ValidationErrorEventArgs e)
        {
            if (e.InvalidText == "")
            {
                e.RetainFocus = false;
            }
        }

        private void UltraComboTandasDeFacturacionRowSelected(object sender, RowSelectedEventArgs e)
        {
            buttonAceptar.Enabled = true;
        }
    }
}
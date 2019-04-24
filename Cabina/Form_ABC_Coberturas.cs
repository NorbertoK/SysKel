using System;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using Properties;

    public partial class FormABCCoberturas : Form1
    {
        public FormABCCoberturas()
        {
            InitializeComponent();
        }

        private void FormABCCoberturasLoad(object sender, EventArgs e)
        {
            dsCoberturas.Merge(new WS.Service().GetCoberturas(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            coberturasBindingSource.EndEdit();
            var aux = new WS.Service().UpdateCoberturas(dsCoberturas, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsCoberturas.Clear();
                dsCoberturas.Merge(new WS.Service().GetCoberturas(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsCoberturas.Merge(aux);
            ManejoDatos.AplicarUpdate(dsCoberturas);
            return true;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            Grabar();
            buttonAplicar.Enabled = false;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (buttonAplicar.Enabled)
            {
                if (Grabar())
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void CoberturasUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void CoberturasUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void coberturasUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                coberturasUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
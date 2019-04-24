using System;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using Properties;

    public partial class FormABCTiposDeMovil : Form1
    {
        public FormABCTiposDeMovil()
        {
            InitializeComponent();
        }

        private void FormABCTiposDeMovilLoad(object sender, EventArgs e)
        {
            dsTiposDeMovil.Merge(new WS.Service().GetTiposDeMovil(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            tiposDeMovilBindingSource.EndEdit();
            var aux = new WS.Service().UpdateTiposDeMovil(dsTiposDeMovil, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsTiposDeMovil.Clear();
                dsTiposDeMovil.Merge(new WS.Service().GetTiposDeMovil(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsTiposDeMovil.Merge(aux);
            ManejoDatos.AplicarUpdate(dsTiposDeMovil);
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

        private void TiposDeMovilUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void TiposDeMovilUltraGridBeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void tiposDeMovilUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tiposDeMovilUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
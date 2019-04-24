using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Administración.Properties.Resources;

namespace Administración
{
    public partial class FormABCNegocios : Form1
    {
        public FormABCNegocios()
        {
            InitializeComponent();
        }

        private void FormNegociosLoad(object sender, EventArgs e)
        {
            dsNegocios.Merge(new Service().GetNegocios(Program.Pin));
        }
        private bool Grabar()
        {
            Validate();
            negociosBindingSource.EndEdit();
            var aux = new Service().UpdateNegocios(dsNegocios, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsNegocios.Clear();
                dsNegocios.Merge(new Service().GetCodigos(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsNegocios.Merge(aux);
            ManejoDatos.AplicarUpdate(dsNegocios);
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

        private void NegociosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void NegociosUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void negociosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                negociosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}

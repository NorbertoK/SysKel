using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormAbccuitRepetibles : Form1
    {
        public FormAbccuitRepetibles()
        {
            InitializeComponent();
        }

        private void FormAbccuitRepetiblesLoad(object sender, EventArgs e)
        {
            ds_CUITRepetibles.Merge(new Service().GetCUITRepetibles(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            cUITRepetiblesBindingSource.EndEdit();
            var aux = new Service().UpdateCUITRepetibles(ds_CUITRepetibles, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_CUITRepetibles.Clear();
                ds_CUITRepetibles.Merge(new Service().GetCUITRepetibles(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_CUITRepetibles.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_CUITRepetibles);
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

        private void CUitRepetiblesUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void CUitRepetiblesUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void cUITRepetiblesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cUITRepetiblesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormABCBancos : Form1
    {
        public FormABCBancos()
        {
            InitializeComponent();
        }

        private void FormABCBancosLoad(object sender, EventArgs e)
        {
            ds_Bancos.Merge(new Service().GetBancos(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            bancosBindingSource.EndEdit();
            var aux = new Service().UpdateBancos(ds_Bancos, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_Bancos.Clear();
                ds_Bancos.Merge(new Service().GetBancos(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_Bancos.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_Bancos);
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

        private void BancosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            if (bancosUltraGrid.ActiveCell.Value.GetType().ToString() == "System.Boolean" ||
                bancosUltraGrid.ActiveCell.Value.GetType().ToString() == "System.DBNull") return;
            bancosUltraGrid.ActiveCell.SelStart = 0;
            bancosUltraGrid.ActiveCell.SelLength = bancosUltraGrid.ActiveCell.Value == DBNull.Value
                ? 0
                : bancosUltraGrid.ActiveCell.Text.Length;
        }

        private void BancosUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void bancosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bancosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
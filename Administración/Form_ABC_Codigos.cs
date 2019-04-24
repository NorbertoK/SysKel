using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormABCCodigos : Form1
    {
        public FormABCCodigos()
        {
            InitializeComponent();
        }

        private void Form2Load(object sender, EventArgs e)
        {
            ds_Codigos.Merge(new Service().GetCodigos(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            codigosBindingSource.EndEdit();
            var aux = new Service().UpdateCodigos(ds_Codigos, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_Codigos.Clear();
                ds_Codigos.Merge(new Service().GetCodigos(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_Codigos.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_Codigos);
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

        private void CodigosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            if (codigosUltraGrid.ActiveCell.Value.GetType().ToString() == "System.Boolean" ||
                codigosUltraGrid.ActiveCell.Value.GetType().ToString() == "System.DBNull") return;
            codigosUltraGrid.ActiveCell.SelStart = 0;
            codigosUltraGrid.ActiveCell.SelLength = codigosUltraGrid.ActiveCell.Value == DBNull.Value
                ? 0
                : codigosUltraGrid.ActiveCell.Text.Length;
        }

        private void CodigosUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void codigosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                codigosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
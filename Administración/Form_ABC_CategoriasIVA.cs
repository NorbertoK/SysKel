using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormABCCategoriasIVA : Form1
    {
        public FormABCCategoriasIVA()
        {
            InitializeComponent();
        }

        private void FormABCCategoriasIVALoad(object sender, EventArgs e)
        {
            ds_CategoriasIVA.Merge(new Service().GetCategoriasIva(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            categoriasIVABindingSource.EndEdit();
            var aux = new Service().UpdateCategoriasIVA(ds_CategoriasIVA, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos."+ Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_CategoriasIVA.Clear();
                ds_CategoriasIVA.Merge(new Service().GetCategoriasIva(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_CategoriasIVA.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_CategoriasIVA);
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

        private void CategoriasIVAUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            if (categoriasIVAUltraGrid.ActiveCell.Value.GetType().ToString() == "System.Boolean" ||
                categoriasIVAUltraGrid.ActiveCell.Value.GetType().ToString() == "System.DBNull") return;
            categoriasIVAUltraGrid.ActiveCell.SelStart = 0;
            categoriasIVAUltraGrid.ActiveCell.SelLength = categoriasIVAUltraGrid.ActiveCell.Value == DBNull.Value
                ? 0
                : categoriasIVAUltraGrid.ActiveCell.Text.Length;
        }

        private void CategoriasIVAUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void FormABCCategoriasIVAActivated(object sender, EventArgs e)
        {
            ds_TiposDeComprobante.Merge(new Service().GetTiposDeComprobante(Program.Pin));
        }

        private void categoriasIVAUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                categoriasIVAUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void ultraDropDownTiposDeComprobante_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraDropDownTiposDeComprobante.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }
    }
}
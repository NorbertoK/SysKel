using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormABCAutorizacionesDelPuesto : Form1
    {
        public FormABCAutorizacionesDelPuesto()
        {
            InitializeComponent();
        }

        private void FormABCAutorizacionesDelPuestoLoad(object sender, EventArgs e)
        {
            dsAutorizacionesDelPuesto.Merge(new Service().GetAutorizacionesDelPuesto(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            autorizacionesDelPuestoBindingSource.EndEdit();
            var aux = new Service().UpdateAutorizacionesDelPuesto(dsAutorizacionesDelPuesto,
                                                                  Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsAutorizacionesDelPuesto.Clear();
                dsAutorizacionesDelPuesto.Merge(new Service().GetAutorizacionesDelPuesto(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsAutorizacionesDelPuesto.Merge(aux);
            ManejoDatos.AplicarUpdate(dsAutorizacionesDelPuesto);
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

        private void AutorizacionesDelPuestoUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            if (autorizacionesDelPuestoUltraGrid.ActiveCell.Value.GetType().ToString() == "System.Boolean" ||
                autorizacionesDelPuestoUltraGrid.ActiveCell.Value.GetType().ToString() == "System.DBNull") return;
            autorizacionesDelPuestoUltraGrid.ActiveCell.SelStart = 0;
            autorizacionesDelPuestoUltraGrid.ActiveCell.SelLength = autorizacionesDelPuestoUltraGrid.ActiveCell.Value == DBNull.Value
                ? 0
                : autorizacionesDelPuestoUltraGrid.ActiveCell.Text.Length;
        }

        private void AutorizacionesDelPuestoUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void FormABCAutorizacionesDelPuestoActivated(object sender, EventArgs e)
        {
            // Lleno los combos.
            dsAutorizaciones.Merge(new Service().GetAutorizaciones(Program.Pin));
            dsPuestos.Merge(new Service().GetPuestos(Program.Pin));
            dsTiposDeAutorizacion.Merge(new Service().GetTiposDeAutorizacion(Program.Pin));
        }

        private void UltraDropDownAutorizacionesFilterRow(object sender, FilterRowEventArgs e)
        {
            if (autorizacionesDelPuestoUltraGrid.ActiveRow.Cells["idTipoDeAutorizacion"].Value == DBNull.Value) return;
            var fc = new FilterCondition(e.Row.Band.Columns["idTipoDeAutorizacion"],
                                         FilterComparisionOperator.Equals,
                                         dsTiposDeAutorizacion.TiposDeAutorizacion.FindByidTipoDeAutorizacion(
                                             (int)
                                             autorizacionesDelPuestoUltraGrid.ActiveRow.Cells["idTipoDeAutorizacion"
                                                 ].Value).idTipoDeAutorizacion);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownTiposDeAutorizacionRowSelected(object sender, RowSelectedEventArgs e)
        {
            ultraDropDownAutorizaciones.DisplayLayout.RefreshFilters();
        }

        #region BeforeDropDown
        private void UltraDropDownPuestosBeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraDropDownPuestos.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
               PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownTiposDeAutorizacionBeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraDropDownTiposDeAutorizacion.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
               PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownAutorizacionesBeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraDropDownAutorizaciones.DisplayLayout.Bands[0].Columns["Descripcion"].PerformAutoResize(
               PerformAutoSizeType.AllRowsInBand);
        }
        #endregion

        private void autorizacionesDelPuestoUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                autorizacionesDelPuestoUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
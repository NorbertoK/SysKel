using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Administración.Properties.Resources;

namespace Administración
{
    public partial class FormABCLugares : Form1
    {
        public FormABCLugares()
        {
            InitializeComponent();
        }

        private void FormABCLugaresLoad(object sender, EventArgs e)
        {
            dsLugares.Merge(new Service().GetLugares(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            var aux = new Service().UpdateLugares(dsLugares, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine +
                    Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información",
                    "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsLugares.Clear();
                dsLugares.Merge(new Service().GetLugares(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }

            dsLugares.Merge(aux);
            ManejoDatos.AplicarUpdate(dsLugares);
            return true;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            if (Verificado()) Grabar();
            buttonAplicar.Enabled = false;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (!Verificado()) return;
            if (buttonAplicar.Enabled)
            {
                if (Grabar()) Close();
            }
            else
            {
                Close();
            }
        }

        private void LugaresUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void LugaresUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void UltraDropDownCalleFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = lugaresUltraGrid.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                ? new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals, 0)
                : new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals,
                    dsLocalidadesLista.LocalidadesLista.FindByidLocalidad(
                        (int) lugaresUltraGrid.ActiveRow.Cells["idLocalidad"].Value).idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void LugaresUltraGridCellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "idLocalidad") return;
            ultraDropDownBarrios.DisplayLayout.RefreshFilters();
            ultraDropDownCalle.DisplayLayout.RefreshFilters();
        }

        private void LugaresUltraGridBeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            if (!lugaresUltraGrid.Selected.Rows[0].HasChild()) return;
            MessageBox.Show(this, "Tiene hijos.",
                "¡No se puede borrar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }

        private void UltraDropDownBarriosFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals,
                dsCallesLista1.Calles.FindByidCalle(
                    (int) lugaresUltraGrid.ActiveRow.Cells["idCalle"].Value).idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void FormABCLugaresActivated(object sender, EventArgs e)
        {
            dsCallesLista1.Merge(new Service().GetCallesLista(Program.Pin));
            dsLocalidadesLista.Merge(new Service().GetLocalidadesLista(Program.Pin));
        }

        private void UltraDropDownLocalidadRowSelected(object sender, RowSelectedEventArgs e)
        {
            lugaresUltraGrid.Update();
            ultraDropDownBarrios.DisplayLayout.RefreshFilters();
            ultraDropDownCalle.DisplayLayout.RefreshFilters();
        }

        private void LugaresUltraGridAfterRowActivate(object sender, EventArgs e)
        {
            if (lugaresUltraGrid.ActiveRow.Band.Key != "FK_Direcciones_Lugares") return;
            ultraDropDownBarrios.DisplayLayout.RefreshFilters();
            ultraDropDownCalle.DisplayLayout.RefreshFilters();
        }

        private bool Verificado()
        {
            var lugares = lugaresUltraGrid.DisplayLayout.Bands["Lugares"];
            foreach (UltraGridRow lugar in lugares.GetRowEnumerator(GridRowType.DataRow))
            foreach (var direccion in lugar.ChildBands["FK_Direcciones_Lugares"].Rows)
            {
                if (direccion.Cells["idLocalidad"].Value == DBNull.Value)
                {
                    MessageBox.Show(this, "La dirección no tiene Localidad.",
                        lugar.Cells["Nombre"].Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (direccion.Cells["idCalle"].Value != DBNull.Value &&
                    dsCallesLista1.Calles.FindByidCalle((int) direccion.Cells["idCalle"].Value).idLocalidad !=
                    (int) direccion.Cells["idLocalidad"].Value)
                {
                    MessageBox.Show(
                        "La calle " + direccion.Cells["idCalle"].Text +
                        " no pertenece a " +
                        direccion.Cells["idLocalidad"].Text + ".", lugar.Cells["Nombre"].Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }

                if (direccion.Cells["idEntreCalle1"].Value != DBNull.Value &&
                    dsCallesLista1.Calles.FindByidCalle((int) direccion.Cells["idEntreCalle1"].Value).idLocalidad !=
                    (int) direccion.Cells["idLocalidad"].Value)
                {
                    MessageBox.Show(
                        "La calle " + direccion.Cells["idEntreCalle1"].Text +
                        " no pertenece a " +
                        direccion.Cells["idLocalidad"].Text + ".", lugar.Cells["Nombre"].Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }

                if (direccion.Cells["idEntreCalle2"].Value != DBNull.Value &&
                    dsCallesLista1.Calles.FindByidCalle((int) direccion.Cells["idEntreCalle2"].Value).idLocalidad !=
                    (int) direccion.Cells["idLocalidad"].Value)
                {
                    MessageBox.Show(
                        "La calle " + direccion.Cells["idEntreCalle2"].Text +
                        " no pertenece a " +
                        direccion.Cells["idLocalidad"].Text + ".", lugar.Cells["Nombre"].Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }

                if (direccion.Cells["idBarrio"].Value == DBNull.Value ||
                    dsBarrios.BarriosLista.FindByidBarrio((int) direccion.Cells["idBarrio"].Value).idLocalidad ==
                    (int) direccion.Cells["idLocalidad"].Value) continue;
                MessageBox.Show(
                   "El barrio " + direccion.Cells["idBarrio"].Text +
                    " no pertenece a " +
                    direccion.Cells["idLocalidad"].Text + ".", lugar.Cells["Nombre"].Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void lugaresUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                lugaresUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
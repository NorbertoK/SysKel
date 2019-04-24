namespace Administración
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using WS;
    using Infragistics.Win.UltraWinGrid;
    using ColumnStyle=Infragistics.Win.UltraWinGrid.ColumnStyle;
    using Resources = Properties.Resources;

    public partial class FormCambioDeCobrador : Form1
    {
        public FormCambioDeCobrador()
        {
            InitializeComponent();
        }

        private void CambiosDeCobradorUltraGridBeforeCellDeactivate(object sender, CancelEventArgs e)
        {
            if (cambiosDeCobradorUltraGrid.ActiveCell.Text == "" ||
                cambiosDeCobradorUltraGrid.ActiveCell.Column.Key != "idComprobante") return;
            /*Pide datos de la referencia*/

            var idComprobante = Convert.ToInt32(cambiosDeCobradorUltraGrid.ActiveCell.Text);
            var idCobrador = cambiosDeCobradorUltraGrid.DisplayLayout.Rows[0].Cells["idCobrador1"].Value == DBNull.Value ? 0 : (int)cambiosDeCobradorUltraGrid.DisplayLayout.Rows[0].Cells["idCobrador1"].Value;
            var mensaje = new Service().MensajeCambioDeCobrador(idComprobante, idCobrador, Program.Pin);
            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                cambiosDeCobradorUltraGrid.BeforeRowsDeleted += CambiosDeCobradorUltraGridBeforeRowsDeleted;
                cambiosDeCobradorUltraGrid.ActiveRow.Delete();
                cambiosDeCobradorUltraGrid.UpdateData();
                cambiosDeCobradorUltraGrid.BeforeRowsDeleted -= CambiosDeCobradorUltraGridBeforeRowsDeleted;
            }
            else
            {
                foreach (
                    UltraGridRow renglon in
                        cambiosDeCobradorUltraGrid.ActiveRow.Band.GetRowEnumerator(GridRowType.DataRow))
                {
                    if (renglon.IsAddRow == false && renglon.Activated == false &&
                        (int) renglon.Cells["idComprobante"].Value ==
                        (int) cambiosDeCobradorUltraGrid.ActiveCell.Value)
                    {
                        MessageBox.Show("Ya está ingresado", "Comprobante", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        e.Cancel = true;
                        break;
                    }
                    var importe = new Service().ImporteComprobanteRemesa(idComprobante, Program.Pin);
                    cambiosDeCobradorUltraGrid.ActiveRow.Cells["Importe"].Value = importe;
                    buttonAceptar.Enabled = true;
                }
            }
        }

        private void FormCambioDeCobradorActivated(object sender, EventArgs e)
        {
            dsEmpleadosLista1.Merge(new Service().GetCobradores(Program.Pin));
            dsZonas.Merge(new Service().GetZonas(Program.Pin));
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;
            ultraLabelMensaje.Visible = true;
            ultraLabelMensaje.Update();
            Validate();
            cambiosDeCobradorBindingSource.EndEdit();
            /*Updatea*/
            dsCambiosDeCobrador.Merge(new Service().UpdateCambioDeCobrador(dsCambiosDeCobrador, Program.Pin));
            ManejoDatos.AplicarUpdate(dsCambiosDeCobrador);
            new Service().CambiarDeCobrador(
                Convert.ToInt32(cambiosDeCobradorUltraGrid.Rows[0].Cells[0].Value.ToString()), Program.Pin);
            /*Muestra el reporte*/
            var repo = new FormRepCambioDeCobrador
                           {
                               IdCambioDeCobrador =
                                   ((int) cambiosDeCobradorUltraGrid.DisplayLayout.Rows[0].Cells[0].Value),
                               MdiParent = MdiParent,
                               StartPosition = FormStartPosition.Manual,
                               Location = new Point(0, 0)
                           };
            repo.Show();
            Close();
        }

        private void UltraDropDownCobradoresFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void CambiosDeCobradorUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Band.Key != "CambiosDeCobrador") return;
            e.Row.Cells["Fecha"].Value = new Service().HoraActual(Program.Pin);
            e.Row.Cells["idGrabador"].Value = Program.IdUsuario;
        }

        private void CambiosDeCobradorUltraGridAfterRowExpanded(object sender, RowEventArgs e)
        {
            if (e.Row.Cells["idCobrador2"].Value == DBNull.Value || e.Row.Cells["idZona"].Value == DBNull.Value)
            {
                e.Row.CollapseAll();
                MessageBox.Show("El Cobrador de destino y la zona son obligatorios.", "Faltan Datos", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                e.Row.Cells["idCobrador1"].Column.Style = ColumnStyle.Edit;
                e.Row.Cells["idCobrador1"].Column.CellActivation = Activation.NoEdit;
                e.Row.Cells["idCobrador2"].Column.Style = ColumnStyle.Edit;
                e.Row.Cells["idCobrador2"].Column.CellActivation = Activation.NoEdit;
                e.Row.Cells["idZona"].Column.Style = ColumnStyle.Edit;
                e.Row.Cells["idZona"].Column.CellActivation = Activation.NoEdit;
            }
        }

        private void UltraDropDownZonasFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = cambiosDeCobradorUltraGrid.ActiveRow.Cells["idCobrador2"].Value == DBNull.Value
                                     ? new FilterCondition(e.Row.Band.Columns["idCobrador"],
                                                           FilterComparisionOperator.Equals, 0)
                                     : 
                                     new FilterCondition(e.Row.Band.Columns["idCobrador"],
                                                           FilterComparisionOperator.Equals,
                                                           (int)cambiosDeCobradorUltraGrid.ActiveRow.Cells["idCobrador2"].Value);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void CambiosDeCobradorUltraGridCellListSelect(object sender, CellEventArgs e)
        {
            ultraDropDownZonas.DisplayLayout.RefreshFilters();
        }

        private void CambiosDeCobradorUltraGridBeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            e.DisplayPromptMsg = false;
        }

        private void cambiosDeCobradorUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cambiosDeCobradorUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void cambiosDeCobradorUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}
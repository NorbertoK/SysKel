namespace Administración
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using WS;
    using Infragistics.Win.UltraWinGrid;
    using ColumnStyle = Infragistics.Win.UltraWinGrid.ColumnStyle;
    using Resources = Properties.Resources;

    public partial class FormArqueo : Form1
    {
        public FormArqueo()
        {
            InitializeComponent();
        }

        private void FormArqueoLoad(object sender, EventArgs e)
        {
            ultraCurrencyEditorTotalComprobantes.Value = 0;
            /*Llena el combo Cierre del Período*/
            arqueosUltraGrid.DisplayLayout.ValueLists.Add("Cierre");
            arqueosUltraGrid.DisplayLayout.ValueLists["Cierre"].ValueListItems.Add("S", "Sí");
            arqueosUltraGrid.DisplayLayout.ValueLists["Cierre"].ValueListItems.Add("N", "No");
            arqueosUltraGrid.DisplayLayout.Bands["Arqueos"].Columns["CierreDelPeriodo"].ValueList =
                arqueosUltraGrid.DisplayLayout.ValueLists["Cierre"];

            /*Conecta el Grid*/
            arqueosUltraGrid.DataBind();
        }

        private void ArqueosUltraGridBeforeCellDeactivate(object sender, CancelEventArgs e)
        {
            if (arqueosUltraGrid.ActiveCell.Text == "" || arqueosUltraGrid.ActiveCell.Column.Key != "idComprobante")
                return;

            /*Pide datos de la referencia*/
            var idComprobante = Convert.ToInt32(arqueosUltraGrid.ActiveCell.Text);
            var idCobrador = (int) arqueosUltraGrid.DisplayLayout.Rows[0].Cells["idCobrador"].Value;
            var elMensaje = new Service().MensajeRemesa(idComprobante, idCobrador,0, Program.Pin);
            if (elMensaje.Length > 0)
            {
                MessageBox.Show(elMensaje, "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                arqueosUltraGrid.BeforeRowsDeleted += ArqueosUltraGridBeforeRowsDeleted;
                arqueosUltraGrid.ActiveRow.Delete();
                arqueosUltraGrid.UpdateData();
                arqueosUltraGrid.BeforeRowsDeleted -= ArqueosUltraGridBeforeRowsDeleted;
            }
            else
            {
                arqueosUltraGrid.ActiveRow.Update();
                var referencia = (int) arqueosUltraGrid.ActiveCell.Value;
                if (
                    (int)
                    dsArqueos.ComprobantesArqueos.Compute("Count(idComprobante)", "idComprobante = " + referencia) >
                    1)
                {
                    MessageBox.Show("Ya está ingresado", "Comprobante", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    arqueosUltraGrid.BeforeRowsDeleted += ArqueosUltraGridBeforeRowsDeleted;
                    arqueosUltraGrid.ActiveRow.Delete();
                    arqueosUltraGrid.UpdateData();
                    arqueosUltraGrid.BeforeRowsDeleted -= ArqueosUltraGridBeforeRowsDeleted;
                }

                else
                {
                    /* Determina si el comprobante queda en la Empresa o vuelve al Cobrador.*/
                    var frase =
                        new Service().RetirarONoComprobanteArqueo((int) arqueosUltraGrid.ActiveCell.Value,
                                                                  Program.Pin);
                    var idMensaje = Convert.ToInt32(frase.Substring(0, 8));
                    var mensaje = frase.Substring(8);
                    arqueosUltraGrid.ActiveRow.Cells["Mensaje"].Value = mensaje;
                    if (idMensaje == 0)
                    {
                        arqueosUltraGrid.ActiveRow.Cells["Mensaje"].Appearance.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        arqueosUltraGrid.ActiveRow.Cells["Mensaje"].Appearance.ForeColor = Color.Red;
                        arqueosUltraGrid.ActiveRow.Cells["idMotivoDevolucionCobranza"].Value = idMensaje;
                    }
                    arqueosUltraGrid.ActiveRow.Cells["Mensaje"].Activation = Activation.NoEdit;
                    arqueosUltraGrid.ActiveRow.Cells["Faltante"].Value = false;
                    arqueosUltraGrid.ActiveRow.Cells["Importe"].Value =
                        new Service().ImporteComprobanteRemesa(
                            (int) arqueosUltraGrid.ActiveRow.Cells["idComprobante"].Value, Program.Pin);
                    buttonAceptar.Enabled = true;
                }
            }
        }

        private void ArqueosUltraGridSummaryValueChanged(object sender, SummaryValueChangedEventArgs e)
        {
            if (e.SummaryValue.Key == "TotalComprobantes")
            {
                ultraCurrencyEditorTotalComprobantes.Value = (decimal) e.SummaryValue.Value;
            }
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonCancelar.Enabled = false;
            buttonAceptar.Enabled = false;
            var aux = new Service().UpdateArqueos(dsArqueos, Program.Pin);
            if (aux != null) dsArqueos.Merge(aux);
            else
            {
                MessageBox.Show("Imposible Grabar", "¡Atención!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Close();
            }
            ManejoDatos.AplicarUpdate(dsArqueos);
            if (ultraCurrencyEditorTotalComprobantes.Value !=
                (decimal) arqueosUltraGrid.Rows[0].Cells["Total"].Value)
            {
                new Service().ComprobantesFaltantesArqueo(
                    (int) arqueosUltraGrid.Rows[0].Cells["idArqueo"].Value, Program.Pin);
            }
            new Service().ComprobantesRetenidosPorBajaPasanACobradorBajas(
                (int) arqueosUltraGrid.Rows[0].Cells["idArqueo"].Value,
                Program.Pin);
            /*Muestra el reporte*/
            var repo = new FormReporteArqueo
                           {
                               IdArqueo = ((int) arqueosUltraGrid.Rows[0].Cells[0].Value),
                               MdiParent = MdiParent,
                               Left = 0,
                               Top = 0
                           };
            repo.Show();
            Close();
        }

        private void FormArqueoActivated(object sender, EventArgs e)
        {
            dsEmpleadosLista1.Merge(new Service().GetCobradores(Program.Pin));
        }

        private void UltraDropDownCobradoresFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void ArqueosUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Band.Key == "Arqueos")
            {
                e.Row.Cells["Fecha"].Value = new Service().HoraActual(Program.Pin);
            }
        }

        private void ArqueosUltraGridAfterRowExpanded(object sender, RowEventArgs e)
        {
            e.Row.Cells["idCobrador"].Column.Style = ColumnStyle.Edit;
            e.Row.Cells["idCobrador"].Column.CellActivation = Activation.NoEdit;
            try
            {
                arqueosUltraGrid.ActiveRow.Cells["Total"].Value =
                    new Service().TotalARendir((int) arqueosUltraGrid.Rows[0].Cells["idCobrador"].Value, Program.Pin);
            }
            catch
            {
                arqueosUltraGrid.ActiveRow.Cells["Total"].Value = 0;
            }
        }

        private void ArqueosUltraGridBeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            e.DisplayPromptMsg = false;
        }

        private void arqueosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                arqueosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void arqueosUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}
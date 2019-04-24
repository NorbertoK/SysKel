namespace Administración
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Threading;
    using System.Transactions;
    using System.Windows.Forms;
    using WS;
    using Infragistics.Win.UltraWinGrid;

    public partial class FormLiquidacionEntidad : Form1
    {
        private FormPrincipal _fp;

        public FormLiquidacionEntidad()
        {
            InitializeComponent();
        }

        private void FormLiquidacionEntidadLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal) MdiParent;
            entidadesDeCobranzaBindingSource.DataSource = _fp.dsEntidadesDeCobranza;
        }

        private void LiquidacionesTercerizadaUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Band.Key != "LiquidacionesTercerizada") return;
            e.Row.Cells["Fecha"].Value = new Service().HoraActual(Program.Pin);
            e.Row.Cells["idGrabador"].Value = Program.IdUsuario;
        }

        private void LiquidacionesTercerizadaUltraGridCellListSelect(object sender, CellEventArgs e)
        {
            e.Cell.Row.Update();
            e.Cell.Row.Cells["Periodo"].Value = new Service().PrimerPeriodoSinLiquidar((int) e.Cell.Value, Program.Pin);
            buttonAceptar.Enabled = e.Cell.Row.Cells["Periodo"].Value.ToString() != "";
            e.Cell.Row.ChildBands[0].Band.MaxRows = e.Cell.Row.Cells["Periodo"].Value.ToString() == "" ? 0 : 10000;
        }

        private void LiquidacionesTercerizadaUltraGridAfterRowExpanded(object sender, RowEventArgs e)
        {
            e.Row.Cells["idEntidadDeCobranza"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            e.Row.Cells["idEntidadDeCobranza"].Activation = Activation.NoEdit;
        }

        private void LiquidacionesTercerizadaUltraGridBeforeCellDeactivate(object sender, CancelEventArgs e)
        {
            if (liquidacionesTercerizadaUltraGrid.ActiveCell.Text == "" ||
                liquidacionesTercerizadaUltraGrid.ActiveCell.Column.Key != "idComprobante")
                return;

            /*Pide datos de la referencia*/
            var idComprobante = Convert.ToInt32(liquidacionesTercerizadaUltraGrid.ActiveCell.Text);
            var idEntidad =
                (int) liquidacionesTercerizadaUltraGrid.DisplayLayout.Rows[0].Cells["idEntidadDeCobranza"].Value;
            var periodo = liquidacionesTercerizadaUltraGrid.DisplayLayout.Rows[0].Cells["Periodo"].Value.ToString();
            var mensaje = new Service().MensajeLiquidacionEntidad(idComprobante, idEntidad, periodo, Program.Pin);
            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                liquidacionesTercerizadaUltraGrid.BeforeRowsDeleted +=
                    LiquidacionesTercerizadaUltraGridBeforeRowsDeleted;
                liquidacionesTercerizadaUltraGrid.ActiveRow.Delete();
                liquidacionesTercerizadaUltraGrid.UpdateData();
                liquidacionesTercerizadaUltraGrid.BeforeRowsDeleted -=
                    LiquidacionesTercerizadaUltraGridBeforeRowsDeleted;
            }
            else
            {
                liquidacionesTercerizadaUltraGrid.ActiveRow.Update();
                var comprobante = (int) liquidacionesTercerizadaUltraGrid.ActiveCell.Value;
                if (
                    (int)
                    dsLiquidacionEntidad.ComprobantesLiquidacionTercerizada.Compute("Count(idComprobante)",
                                                                                    "idComprobante = " + comprobante) >
                    1)
                {
                    MessageBox.Show("Ya está ingresado", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    liquidacionesTercerizadaUltraGrid.BeforeRowsDeleted +=
                        LiquidacionesTercerizadaUltraGridBeforeRowsDeleted;
                    liquidacionesTercerizadaUltraGrid.ActiveRow.Delete();
                    liquidacionesTercerizadaUltraGrid.UpdateData();
                    liquidacionesTercerizadaUltraGrid.BeforeRowsDeleted -=
                        LiquidacionesTercerizadaUltraGridBeforeRowsDeleted;
                }
                else
                {
                    var importe = new Service().ImporteComprobanteRemesa(idComprobante, Program.Pin);
                    liquidacionesTercerizadaUltraGrid.ActiveRow.Cells["Importe"].Value = importe;
                }
            }
        }

        private void LiquidacionesTercerizadaUltraGridBeforeRowsDeleted(object sender,
                                                                               BeforeRowsDeletedEventArgs e)
        {
            e.DisplayPromptMsg = false;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (dsLiquidacionEntidad.ComprobantesLiquidacionTercerizada.Rows.Count == 0 &&
                MessageBox.Show("¿Seguro que no hay rechazos?", "No ingresó rechazos", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No) return;
            using (var ts = new TransactionScope())
            {
                try
                {
                    buttonAceptar.Visible = false;
                    buttonCancelar.Visible = false;
                    ultraLabelMensaje.Visible = true;
                    Validate();
                    liquidacionesTercerizadaBindingSource.EndEdit();
                    /*Updatea*/
                    var aux = new Service().UpdateLiquidacionEntidad(dsLiquidacionEntidad, Program.Pin);
                    if (aux == null)
                    {
                        MessageBox.Show(
                            "La operación fue rechazada por la Base de Datos." + Environment.NewLine +
                            Environment.NewLine + "Póngase en contacto con el Administrador del Sistema.",
                            "Operación Rechazada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dsLiquidacionEntidad.Merge(aux);
                        ManejoDatos.AplicarUpdate(dsLiquidacionEntidad);
                    }
                    Thread.Sleep(5*1000); // Espera 5 segundos a que se cierre la conexión.
                    /*Hace recibos, NdeC y nuevos comprobantes si hace falta.*/
                    if (
                        new Service().HacerRecibosLiquidacionEntidad(
                            Convert.ToInt32(liquidacionesTercerizadaUltraGrid.Rows[0].Cells[0].Value.ToString()),
                            Program.Pin) == 0)
                    {
                        MessageBox.Show("Los datos de esta remesa no pasaron a la Cuenta Corriente.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ts.Complete();
                    /*Muestra el reporte*/
                    var repo = new FormRepLiquidacionEntidad
                                   {
                                       IdLiquidacionEntidad =
                                           ((int) liquidacionesTercerizadaUltraGrid.DisplayLayout.Rows[0].Cells[0].Value),
                                       MdiParent = MdiParent,
                                       StartPosition = FormStartPosition.Manual,
                                       Location = new Point(0, 0)
                                   };
                    repo.Show();
                }
                catch
                {
                    MessageBox.Show("No se pudo realizar la operación.", "¡Atención!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    buttonAceptar.Visible = true;
                    buttonCancelar.Visible = true;
                    ts.Dispose();
                }
                Close();
            }
        }

        private void liquidacionesTercerizadaUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                liquidacionesTercerizadaUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void liquidacionesTercerizadaUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}
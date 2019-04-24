using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Transactions;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using ColumnStyle = Infragistics.Win.UltraWinGrid.ColumnStyle;
using Resources = Administración.Properties.Resources;

namespace Administración
{
    public partial class FormRemesa : Form1
    {
        private FormPrincipal _fp;

        public FormRemesa()
        {
            InitializeComponent();
        }

        private void RemesasUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            if (remesasUltraGrid.ActiveCell.Column.DataType.ToString() == "System.Boolean") return;
            remesasUltraGrid.ActiveCell.SelStart = 0;
        }

        private void RemesasUltraGridAfterCellUpdate(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "idTipoDeValor")
            {
                if (dsTiposDeValores.TiposDeValores.FindByidTipoDeValor((int) e.Cell.Value).RequiereBanco == false)
                {
                    e.Cell.Row.Cells["idBanco"].Hidden = true;
                    e.Cell.Row.Cells["NumeroDeCheque"].Hidden = true;
                    e.Cell.Row.Cells["Vencimiento"].Hidden = true;
                    e.Cell.Row.Cells["idBanco"].Value = DBNull.Value;
                    e.Cell.Row.Cells["NumeroDeCheque"].Value = DBNull.Value;
                    e.Cell.Row.Cells["Vencimiento"].Value = DBNull.Value;
                }
                else
                {
                    e.Cell.Row.Cells["idBanco"].Hidden = false;
                    e.Cell.Row.Cells["NumeroDeCheque"].Hidden = false;
                    e.Cell.Row.Cells["Vencimiento"].Hidden = false;
                }
            }
            if (e.Cell.Column.Key != "ImporteCobrado") return;
            if (e.Cell.Row.Cells["ImporteReferencia"].Value != DBNull.Value && e.Cell.Value != DBNull.Value &&
                (decimal) e.Cell.Value != (decimal) e.Cell.Row.Cells["ImporteReferencia"].Value)
            {
                remesasUltraGrid.ActiveRow.Cells["HacerNDeC"].Activation = Activation.AllowEdit;
                remesasUltraGrid.ActiveRow.Cells["HacerNdeC"].Value = true;
            }
            else
            {
                remesasUltraGrid.ActiveRow.Cells["HacerNdeC"].Value = false;
                remesasUltraGrid.ActiveRow.Cells["HacerNDeC"].Activation = Activation.Disabled;
            }
        }

        private void RemesasUltraGridBeforeCellDeactivate(object sender, CancelEventArgs e)
        {
            if (remesasUltraGrid.ActiveCell.Text == "" || remesasUltraGrid.ActiveCell.Column.Key != "idReferencia")
                return;

            /*Pide datos de la referencia*/
            var idComprobante = Convert.ToInt32(remesasUltraGrid.ActiveCell.Text);
            var idCobrador = remesasUltraGrid.DisplayLayout.Rows[0].Cells["idCobrador"].Value == DBNull.Value ? 0 : (int)remesasUltraGrid.DisplayLayout.Rows[0].Cells["idCobrador"].Value;
            var idEntidadDeCobranza = remesasUltraGrid.DisplayLayout.Rows[0].Cells["idEntidadDeCobranza"].Value == DBNull.Value ? 0 : (int)remesasUltraGrid.DisplayLayout.Rows[0].Cells["idEntidadDeCobranza"].Value;
            var mensaje = new Service().MensajeRemesa(idComprobante, idCobrador, idEntidadDeCobranza, Program.Pin);
            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                remesasUltraGrid.BeforeRowsDeleted += RemesasUltraGridBeforeRowsDeleted;
                remesasUltraGrid.ActiveRow.Delete();
                remesasUltraGrid.UpdateData();
                remesasUltraGrid.BeforeRowsDeleted -= RemesasUltraGridBeforeRowsDeleted;
            }
            else
            {
                var saldo = new Service().SaldoComprobante(idComprobante, Program.Pin);
                if (saldo < .01 && saldo > -.01)
                {
                    MessageBox.Show(
                        "Este comprobante ya ha sido cobrado." +
                        Environment.NewLine +
                        "Póngale un sello PAGADO, escríbale SERÁ RETENIDO y devuélvaselo al cobrador." +
                        Environment.NewLine +
                        "Le será retenido en el próximo arqueo." +
                        Environment.NewLine + Environment.NewLine +
                        "El importe se deberá acreditar para pagar el mes siguiente." +
                        Environment.NewLine +
                        "Si el comprobante del mes siguiente está en poder del cobrador," +
                        Environment.NewLine +
                        "ingréselo ahora para darlo por cobrado." +
                        Environment.NewLine +
                        "Caso contrario factúrelo con destino al cobrador e imprímalo para poder ingresarlo." +
                        Environment.NewLine +
                        "Tambíén póngale un sello PAGADO, escríbale CANJEAR y entrégueselo al cobrador" +
                        Environment.NewLine +
                        "para que se lo canjee al cliente por el que el cliente tiene repetido." +
                        Environment.NewLine + Environment.NewLine +
                        "El comprobante repetido deberá ser destruído por el cobrador en cuanto lo reciba del cliente.",
                        "Comprobante ya cobrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    remesasUltraGrid.BeforeRowsDeleted += RemesasUltraGridBeforeRowsDeleted;
                    remesasUltraGrid.ActiveRow.Delete();
                    remesasUltraGrid.UpdateData();
                    remesasUltraGrid.BeforeRowsDeleted -= RemesasUltraGridBeforeRowsDeleted;
                }
                else
                {
                    remesasUltraGrid.ActiveRow.Update();
                    var referencia = (int) remesasUltraGrid.ActiveCell.Value;
                    if (
                        (int)
                            dsRemesas.ComprobantesRemesas.Compute("Count(idReferencia)", "idReferencia = " + referencia) >
                        1)
                    {
                        MessageBox.Show("Ya está ingresado", "Comprobante", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        remesasUltraGrid.BeforeRowsDeleted += RemesasUltraGridBeforeRowsDeleted;
                        remesasUltraGrid.ActiveRow.Delete();
                        remesasUltraGrid.UpdateData();
                        remesasUltraGrid.BeforeRowsDeleted -= RemesasUltraGridBeforeRowsDeleted;
                    }
                    else
                    {
                        var importe = new Service().ImporteComprobanteRemesa(idComprobante, Program.Pin);
                        remesasUltraGrid.ActiveRow.Cells["ImporteReferencia"].Value = importe;
                        remesasUltraGrid.ActiveRow.Cells["ImporteCobrado"].Value = importe;
                        //remesasUltraGrid.ActiveRow.Cells["ImporteCobrado"].Column.MaxValue = importe;
                    }
                }
            }
        }

        private void RemesasUltraGridSummaryValueChanged(object sender, SummaryValueChangedEventArgs e)
        {
            if (e.SummaryValue.Key == "SumComprobantes")
            {
                ultraCurrencyEditorSumComprobantes.Value = (decimal) e.SummaryValue.Value;
            }
            if (e.SummaryValue.Key == "SumValores")
            {
                ultraCurrencyEditorSumValores.Value = (decimal) e.SummaryValue.Value;
            }
            if (ultraCurrencyEditorSumComprobantes.Value > 0 &&
                ultraCurrencyEditorSumComprobantes.Value == ultraCurrencyEditorSumValores.Value)
            {
                buttonAceptar.Enabled = true;
            }
            else
            {
                buttonAceptar.Enabled = false;
            }
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    buttonAceptar.Visible = false;
                    buttonCancelar.Visible = false;
                    ultraLabelMensaje.Visible = true;
                    Validate();
                    remesasBindingSource.EndEdit();
                    /*Updatea*/
                    var aux = new Service().UpdateRemesa(dsRemesas, Program.Pin);
                    if (aux == null)
                    {
                        MessageBox.Show(
                            "La operación fue rechazada por la Base de Datos." + Environment.NewLine +
                            Environment.NewLine +
                            "Póngase en contacto con el Administrador del Sistema.",
                            "Operación Rechazada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dsRemesas.Merge(aux);
                        ManejoDatos.AplicarUpdate(dsRemesas);
                    }
                    Thread.Sleep(5*1000); // Espera 5 segundos a que se cierre la conexión.
                    /*Hace recibos, NdeC y nuevos comprobantes si hace falta.*/
                    if (
                        new Service().HacerRecibosRemesa(
                            Convert.ToInt32(remesasUltraGrid.Rows[0].Cells[0].Value.ToString()), Program.Pin) == 0)
                    {
                        MessageBox.Show(
                            "Los datos de esta remesa no pasaron a la Cuenta Corriente.",
                            "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ts.Complete();
                    /*Muestra el reporte*/
                    var repo = new FormReporteRemesa
                    {
                        IdRemesa = ((int) remesasUltraGrid.DisplayLayout.Rows[0].Cells[0].Value),
                        MdiParent = MdiParent,
                        StartPosition = FormStartPosition.Manual,
                        Location = new Point(0, 0)
                    };
                    repo.Show();
                }
                catch
                {
                    MessageBox.Show(
                        "No se pudo realizar la operación.",
                        "¡Atención!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    buttonAceptar.Visible = true;
                    buttonCancelar.Visible = true;
                    ts.Dispose();
                }
                Close();
            }
        }

        private void RemesasUltraGridBeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            if (remesasUltraGrid.ActiveRow.Band.Key == "FK_ComprobantesRemesas_Remesas" &&
                remesasUltraGrid.ActiveRow.Cells[3].Text != remesasUltraGrid.ActiveRow.Cells[4].Text)
            {
                if (remesasUltraGrid.ActiveRow.Cells["Observaciones"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show(this,
                        "Escriba observaciones.",
                        "Cobró menos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            if (remesasUltraGrid.ActiveRow.Band.Key != "FK_Remesas_ValoresRemesas" || remesasUltraGrid.ActiveRow.Cells["idTipoDeValor"].Value == DBNull.Value ||
                !dsTiposDeValores.TiposDeValores.FindByidTipoDeValor(
                    (int) remesasUltraGrid.ActiveRow.Cells["idTipoDeValor"].Value).RequiereBanco) return;
            if (remesasUltraGrid.ActiveRow.Cells["idBanco"].Value == DBNull.Value)
            {
                e.Cancel = true;
                MessageBox.Show("Falta el Banco",
                    "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (remesasUltraGrid.ActiveRow.Cells["NumeroDeCheque"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show(this,
                        "Falta el Número de Cheque",
                        "¡Atención!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if (remesasUltraGrid.ActiveRow.Cells["Vencimiento"].Value == DBNull.Value)
                    {
                        e.Cancel = true;
                        MessageBox.Show(this,
                            "Falta el vencimiento",
                            "¡Atención!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RemesasUltraGridAfterRowExpanded(object sender, RowEventArgs e)
        {
            foreach (var celda in e.Row.Cells)
            {
                celda.Column.Style = ColumnStyle.Edit;
                celda.Column.CellActivation = Activation.NoEdit;
            }
        }

        private void FormRemesaActivated(object sender, EventArgs e)
        {
            /*Llena los combos*/
            _fp = (FormPrincipal) MdiParent;
            usuariosListaBindingSource.DataSource = _fp.dsUsuariosLista;
            dsTiposDeValores.Merge(new Service().GetTiposDeValores(Program.Pin));
            dsBancos.Merge(new Service().GetBancos(Program.Pin));
            dsCobradores.Merge(new Service().GetCobradores(Program.Pin));
            dsEmpleadosLista.Merge(new Service().GetAdministrativosYBancos(Program.Pin));
            entidadesDeCobranzaBindingSource.DataSource = _fp.dsEntidadesDeCobranza;
            if (_fp.dsUsuariosLista.UsuariosLista.FindByidUsuario(Program.IdUsuario).IsidEmpleadoNull())
            {
                MessageBox.Show(
                    "Su usuario no tiene asignado un empleado.",
                    "No está autorizado");
                buttonAceptar.Enabled = false;
            }
        }

        private void UltraDropDownCobradoresFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void RemesasUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Band.Key == "Remesas")
            {
                e.Row.Cells["Fecha"].Value = new Service().HoraActual(Program.Pin);
            }
            if (e.Row.Band.Key == "FK_Remesas_ValoresRemesas")
            {
                e.Row.Cells["idEmpleado"].Value = (int) remesasUltraGrid.Rows[0].Cells["idReceptor"].Value;
            }
        }

        private void RemesasUltraGridCellListSelect(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "idCobrador")
            {
                e.Cell.Row.Cells["idReceptor"].Value = 
                    _fp.dsUsuariosLista.UsuariosLista.FindByidUsuario(Program.IdUsuario).idEmpleado;
                remesasUltraGrid.Rows.ExpandAll(true);
            }
            if (e.Cell.Column.Key == "idEntidadDeCobranza")
            {
                e.Cell.Row.Cells["idReceptor"].Value = 
                    (int)ultraDropDownEntidadesDeCobranza.SelectedRow.Cells["idBanco"].Value;
                remesasUltraGrid.Rows.ExpandAll(true);
                remesasUltraGrid.DisplayLayout.Bands["FK_Remesas_ValoresRemesas"].Columns["idTipoDeValor"]
                    .DefaultCellValue =
                    dsTiposDeValores.TiposDeValores.Select("EsEfectivo = 1", "").First()["idTipoDeValor"];
            }
        }

        private void RemesasUltraGridBeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            e.DisplayPromptMsg = false;
        }

        private void RemesasUltraGridInitializeTemplateAddRow(object sender, InitializeTemplateAddRowEventArgs e)
        {
            if (e.TemplateAddRow.Band.Key == "Remesas")
                e.TemplateAddRow.Cells["idGrabador"].Value = Program.IdUsuario;
        }

        private void UltraDropDownCobradoresBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownCobradores.DisplayLayout.RefreshFilters();
            ultraDropDownCobradores.DisplayLayout.Bands[0].Columns["ApelNomb"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownReceptorFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownReceptorBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownReceptor.DisplayLayout.RefreshFilters();
            ultraDropDownReceptor.DisplayLayout.Bands[0].Columns["ApelNomb"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void RemesasUltraGridBeforeRowExpanded(object sender, CancelableRowEventArgs e)
        {
            if (e.Row.Band.Key != "Remesas") return;
            if ((e.Row.Cells["idCobrador"].Value == DBNull.Value && e.Row.Cells["idEntidadDeCobranza"].Value == DBNull.Value) || e.Row.Cells["idReceptor"].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void RemesasUltraGridAfterRowActivate(object sender, EventArgs e)
        {
            if (remesasUltraGrid.ActiveRow.Band.Key != "FK_ComprobantesRemesas_Remesas") return;
            if (remesasUltraGrid.ActiveRow.Cells["ImporteReferencia"].Value == DBNull.Value) return;
            remesasUltraGrid.ActiveRow.Cells["ImporteCobrado"].Column.MaxValue =
                remesasUltraGrid.ActiveRow.Cells["ImporteReferencia"].Value;
        }

        private void ultraDropDownEntidadesDeCobranza_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownEntidadesDeCobranza.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void ultraDropDownTiposDeValores_FilterRow(object sender, FilterRowEventArgs e)
        {
            if (remesasUltraGrid.Rows[0].Cells["idEntidadDeCobranza"].Value != DBNull.Value)
            {
                var fc = new FilterCondition(e.Row.Band.Columns["EsEfectivo"], FilterComparisionOperator.Equals, true);
                e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
            }
        }

        private void ultraDropDownTiposDeValores_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownTiposDeValores.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void remesasUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                remesasUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
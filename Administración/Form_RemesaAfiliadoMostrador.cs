using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormRemesaAfiliadoMostrador : Form1
    {
        private FormPrincipal _fp;

        public FormRemesaAfiliadoMostrador()
        {
            InitializeComponent();
        }

        public string Proceso { private get; set; }

        public int IdPrestacion { private get; set; }

        private void FormRemesaAfiliadoMostradorLoad(object sender, EventArgs e)
        {
            /*Llena los combos*/
            _fp = (FormPrincipal) MdiParent;
            usuariosListaBindingSource.DataSource = _fp.dsUsuariosLista;
            empleadosListaBindingSource.DataSource = _fp.dsEmpleadosLista;
            dsTiposDeValores.Merge(new Service().GetTiposDeValores(Program.Pin));
            dsBancos.Merge(new Service().GetBancos(Program.Pin));
            dsIds1.Merge(new Service().GetIds(Proceso, Program.Pin));
            remesasUltraGrid.DisplayLayout.Bands[0].AddNew();
            remesasUltraGrid.Rows[0].Update();
            remesasUltraGrid.Rows[0].ChildBands["FK_ComprobantesRemesas_Remesas"].Band.Override.AllowAddNew =
                AllowAddNew.Yes;

            foreach (DataRow row in dsIds1.ids)
            {
                var saldo = new Service().SaldoComprobante((int) row["id"], Program.Pin);
                var periodo = new Service().PeriodoDelComprobante((int) row["id"], Program.Pin);
                remesasBindingSource.EndEdit();
                remesasUltraGrid.Rows[0].Activate();
                remesasUltraGrid.Rows[0].ChildBands["FK_ComprobantesRemesas_Remesas"].Rows.TemplateAddRow.Activate();
                remesasUltraGrid.Rows[0].ChildBands["FK_ComprobantesRemesas_Remesas"].Rows.AddRowModifiedByUser = true;
                remesasUltraGrid.ActiveRow.Cells["IdReferencia"].Value = (int) row["id"];
                remesasUltraGrid.ActiveRow.Cells["ImporteReferencia"].Value = saldo;
                remesasUltraGrid.ActiveRow.Cells["ImporteCobrado"].Column.MinValue = 0;
                //remesasUltraGrid.ActiveRow.Cells["ImporteCobrado"].Column.MaxValue = saldo;
                remesasUltraGrid.ActiveRow.Cells["ImporteCobrado"].Value = saldo;
                remesasUltraGrid.ActiveRow.Cells["Periodo"].Value = periodo;
                remesasUltraGrid.PerformAction(UltraGridAction.CommitRow);
            }
            remesasUltraGrid.Rows[0].ChildBands["FK_ComprobantesRemesas_Remesas"].Band.Override.AllowAddNew = AllowAddNew.No;
            remesasUltraGrid.Rows.ExpandAll(true);
            remesasUltraGrid.ActiveRow = null;
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
            if ((decimal) e.Cell.Value != (decimal) e.Cell.Row.Cells["ImporteReferencia"].Value)
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
                    //remesasUltraGrid.DisplayLayout.Rows[0].Cells["Caja"].Value =
                    //    new Service().ObtenerNuevoNumeroDeCaja(Program.Pin);
                    Validate();
                    remesasBindingSource.EndEdit();
                    /*Updatea*/
                    var aux = new Service().UpdateRemesa(dsRemesas, Program.Pin);
                    if (aux == null)
                    {
                        MessageBox.Show(
                            "La operación fue rechazada por la Base de Datos." + Environment.NewLine +
                            "Póngase en contacto con el Administrador del Sistema.",
                            "Operación Rechazada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dsRemesas.Merge(aux);
                        ManejoDatos.AplicarUpdate(dsRemesas);
                    }
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
                }
                catch
                {
                    MessageBox.Show("No se pudo realizar la operación.",
                                    "¡Atención!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    buttonAceptar.Visible = true;
                    buttonCancelar.Visible = true;
                    ts.Dispose();
                }
                ts.Complete();
            }
            /*Muestra el reporte*/
            var repo = new FormRepReciboMostrador
                           {
                               IdRemesa = ((int) remesasUltraGrid.DisplayLayout.Rows[0].Cells[0].Value),
                               StartPosition = FormStartPosition.Manual,
                               Location = new Point(0, 0)
                           };
            Hide();
            repo.ShowDialog();
            new Service().EliminarProceso(Proceso, Program.Pin);
            Close();
        }

        private void RemesasUltraGridBeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            if (remesasUltraGrid.ActiveRow.Band.Key == "FK_ComprobantesRemesas_Remesas" &&
                remesasUltraGrid.ActiveRow.Cells[3].Text != remesasUltraGrid.ActiveRow.Cells[4].Text)
            {
                if (remesasUltraGrid.ActiveRow.Cells["Observaciones"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Escriba observaciones.",
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
                        MessageBox.Show("Falta el vencimiento",
                                        "¡Atención!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RemesasUltraGridBeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            e.DisplayPromptMsg = false;
        }

        private void RemesasUltraGridInitializeTemplateAddRow(object sender, InitializeTemplateAddRowEventArgs e)
        {
            if (e.TemplateAddRow.Band.Key == "Remesas")
            {
                _fp = (FormPrincipal) MdiParent;
                e.TemplateAddRow.Cells["Fecha"].Value = new Service().HoraActual(Program.Pin);
                e.TemplateAddRow.Cells["idGrabador"].Value = Program.IdUsuario;
                e.TemplateAddRow.Cells["idReceptor"].Value =
                    _fp.dsUsuariosLista.UsuariosLista.FindByidUsuario(Program.IdUsuario).idEmpleado;
            }
            if (e.TemplateAddRow.Band.Key == "FK_ComprobantesRemesas_Remesas")
            {
                if (IdPrestacion > 0)
                {
                    e.TemplateAddRow.Cells["idPrestacion"].Value = IdPrestacion;
                }
            }
            if (e.TemplateAddRow.Band.Key == "FK_Remesas_ValoresRemesas")
            {
                e.TemplateAddRow.Cells["idEmpleado"].Value = (int) remesasUltraGrid.Rows[0].Cells["idReceptor"].Value;
            }
        }

        private void UltraDropDownReceptorFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownReceptorBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownReceptor.DisplayLayout.RefreshFilters();
        }

        private void RemesasUltraGridBeforeRowExpanded(object sender, CancelableRowEventArgs e)
        {
            if (e.Row.Band.Key != "Remesas") return;
            if (e.Row.Cells["idReceptor"].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void ButtonCancelar1Click(object sender, EventArgs e)
        {
            new Service().EliminarProceso(Proceso, Program.Pin);
            Close();
        }

        private void remesasUltraGrid_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Band.Key == "Remesas")
            e.Row.Cells["Caja"].ToolTipText = "Opcional. Si no se ingresa, se autogenerará.";
        }

        private void ultraDropDownTiposDeValores_FilterRow(object sender, FilterRowEventArgs e)
        {
            if (new Service().EsBanco((int)remesasUltraGrid.Rows[0].Cells["idReceptor"].Value,Program.Pin))
            {
                var fc = new FilterCondition(e.Row.Band.Columns["EsEfectivo"], FilterComparisionOperator.Equals, true);
                e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
            }
            else
            {
                e.RowFilteredOut = false;
            }
        }

        private void remesasUltraGrid_CellListSelect(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "idReceptor")
            {
                remesasUltraGrid.ActiveRow.Update();
                ultraDropDownTiposDeValores.DisplayLayout.RefreshFilters();
                if (new Service().EsBanco((int)e.Cell.Value, Program.Pin))
                {
                    remesasUltraGrid.DisplayLayout.Bands["FK_Remesas_ValoresRemesas"].Columns["idTipoDeValor"]
                        .DefaultCellValue =
                        dsTiposDeValores.TiposDeValores.Select("EsEfectivo = 1", "").First()["idTipoDeValor"];
                }
                else
                {
                    remesasUltraGrid.DisplayLayout.Bands["FK_Remesas_ValoresRemesas"].Columns["idTipoDeValor"]
                        .DefaultCellValue = DBNull.Value;
                }
                dsRemesas.ValoresRemesas.Clear();
            }
        }

        private void ultraDropDownTiposDeValores_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            //e.Layout.Bands[0].PerformAutoResizeColumns(false,PerformAutoSizeType.AllRowsInBand,true);
        }

        private void remesasUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                remesasUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
            
    }
}
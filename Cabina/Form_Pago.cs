using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Cabina.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Cabina.Properties.Resources;

namespace Cabina
{
    public partial class FormPago : Form1
    {
        private FormPrincipalCabina _fp;
        public FormPago()
        {
            InitializeComponent();
        }
        public int IdCompra { get; set; }
        public string Proceso { get; set; }
        private void FormPagoLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipalCabina)MdiParent;
            empleadosListaBindingSource.DataSource = _fp.dsEmpleadosLista;
            dsBancos.Merge(new Service().GetBancos(Program.Pin));
            dsTiposDeValores.Merge(new Service().GetTiposDeValores(Program.Pin));
            dsProveedores.Merge(new Service().GetProveedoresActivos(Program.Pin));
            /*Que la fecha de registro de la Solicitud sea la actual*/
            pagosUltraGrid.DisplayLayout.Bands["Pagos"].Columns["Fecha"].DefaultCellValue =
                new Service().HoraActual(Program.Pin);
            pagosUltraGrid.DisplayLayout.Bands["Pagos"].Columns["idGrabador"].DefaultCellValue =
                Program.IdUsuario;
            if(Tag.ToString()=="Uno")
            {
                dsOrdenDePago.Merge(new Service().GetCompraDelPago(IdCompra, Program.Pin));
            }
            else
            {
                dsOrdenDePago.Merge(new Service().GetComprasDelPago(Proceso, Program.Pin));
                new Service().EliminarProceso(Proceso, Program.Pin);
            }
            pagosUltraGrid.DisplayLayout.Bands[0].AddNew();
            pagosUltraGrid.Rows[0].Update();
            pagosUltraGrid.Rows[0].ChildBands["FK_Pagos_ComprobantesPagos"].Band.Override.AllowAddNew =
                AllowAddNew.Yes;

            foreach (DataRow row in dsOrdenDePago.ComprasElegidas)
            {
                pagosBindingSource.EndEdit();
                pagosUltraGrid.Rows[0].Activate();
                pagosUltraGrid.Rows[0].ChildBands["FK_Pagos_ComprobantesPagos"].Rows.TemplateAddRow.Activate();
                pagosUltraGrid.Rows[0].ChildBands["FK_Pagos_ComprobantesPagos"].Rows.AddRowModifiedByUser = true;
                pagosUltraGrid.ActiveRow.Cells["IdCompra"].Value = (int)row["idCompra"];
                pagosUltraGrid.ActiveRow.Cells["ImporteCompra"].Value = (decimal)row["Saldo"];
                pagosUltraGrid.ActiveRow.Cells["ImportePagado"].Column.MinValue = 0;
                pagosUltraGrid.ActiveRow.Cells["ImportePagado"].Column.MaxValue = (decimal)row["Saldo"];
                pagosUltraGrid.ActiveRow.Cells["ImportePagado"].Value = (decimal)row["Saldo"];
                pagosUltraGrid.ActiveRow.Cells["FechaCompra"].Value = (DateTime)row["Fecha"];
                pagosUltraGrid.ActiveRow.Cells["ComprobanteCompra"].Value = row["Comprobante"].ToString();
                pagosUltraGrid.ActiveRow.Cells["idProveedor"].Value = (int)row["idProveedor"];
                pagosUltraGrid.PerformAction(UltraGridAction.CommitRow);
            }
            pagosUltraGrid.Rows[0].ChildBands["FK_Pagos_ComprobantesPagos"].Band.Override.AllowAddNew = AllowAddNew.No;
            pagosUltraGrid.Rows.ExpandAll(true);
            pagosUltraGrid.ActiveRow = null;
            dsOrdenDePago.OrdenesDePago[0].idProveedor = dsOrdenDePago.ComprobantesOrdenesDePago[0].idProveedor;
            Text = Text + " a " + pagosUltraGrid.Rows[0].ChildBands["FK_Pagos_ComprobantesPagos"].Rows[0].Cells["idProveedor"].Text.ToString(CultureInfo.InvariantCulture);
        }

       private void PagosUltraGridSummaryValueChanged(object sender, SummaryValueChangedEventArgs e)
        {
            if (e.SummaryValue.Key == "SumCompras")
            {
                ultraCurrencyEditorSumCompras.Value = (decimal)e.SummaryValue.Value;
                if (pagosUltraGrid.Rows[0].ChildBands["FK_Pagos_ValoresPagos"].Rows.Count == 1)
                    pagosUltraGrid.Rows[0].ChildBands["FK_Pagos_ValoresPagos"].Rows[0].Cells["ImporteTransferido"].Value =
                        ultraCurrencyEditorSumCompras.Value;
            }
            if (e.SummaryValue.Key == "SumValores")
            {
                ultraCurrencyEditorSumValores.Value = (decimal)e.SummaryValue.Value;
            }
            if (ultraCurrencyEditorSumCompras.Value > 0 &&
                ultraCurrencyEditorSumCompras.Value == ultraCurrencyEditorSumValores.Value)
            {
                dsOrdenDePago.OrdenesDePago[0].Importe = ultraCurrencyEditorSumCompras.Value;
                pagosUltraGrid.Rows[0].Refresh();
                buttonAceptar.Enabled = true;
            }
            else
            {
                buttonAceptar.Enabled = false;
            }
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (!Validado()) return;
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            pagosBindingSource.EndEdit();
            pagosUltraGrid.Update();
            //var aux = new Service().UpdateOrdenDePago(Program.Pin, dsOrdenDePago);
            //if (aux == null)
            //{
            //    MessageBox.Show(
            //        Resources.Grabar_La_operación_fue_rechazada_por_la_Base_de_Datos_ + Environment.NewLine +
            //        Environment.NewLine +
            //        Resources.
            //            FormRemesaAfiliadoMostrador_ButtonAceptarClick_Póngase_en_contacto_con_el_Administrador_del_Sistema_,
            //        Resources.Grabar_Operación_Rechazada, MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //    buttonAceptar.Enabled = true;
            //    buttonCancelar.Enabled = true;
            //}
            //else
            //{
            //    dsOrdenDePago.Merge(aux);
            //    ManejoDatos.AplicarUpdate(dsOrdenDePago);
            //    var f = new FormRepPago
            //    {
            //        IdPago = (int)dsOrdenDePago.OrdenesDePago.Rows[0]["idPago"],
            //        MdiParent = MdiParent,
            //        StartPosition = FormStartPosition.Manual,
            //        Location = new Point(0, 0)
            //    };
            //    f.Show();
            //    Close();
            //}
        }

        private void PagosUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Band.Key != "FK_Pagos_ValoresPagos") return;
            if ((int)e.Row.Cells["idValorRemesa"].Value == 0)
            {
                e.Row.Cells["Transferido"].Hidden = true;
                e.Row.Cells["ImporteTransferido"].Activation = Activation.AllowEdit;
                e.Row.Cells["ImporteTransferido"].Column.CellClickAction = CellClickAction.EditAndSelectText;
                if (e.Row.Cells["Importe"].Value != DBNull.Value)
                {
                    e.Row.Cells["ImporteTransferido"].Column.MaxValue = (decimal)e.Row.Cells["Importe"].Value;
                }
            }
            else
            {
                e.Row.Cells["ImporteTransferido"].Activation = Activation.NoEdit;
            }
        }

        private void PagosUltraGridCellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Row.Band.Key != "FK_Pagos_ValoresPagos") return;
            if (e.Cell.Column.Key != "Transferido") return;
            if ((decimal)e.Cell.Row.Cells["ImporteTransferido"].Value == 0)
            {
                e.Cell.Row.Cells["ImporteTransferido"].Value = (decimal)e.Cell.Row.Cells["Importe"].Value;
            }
            else
            {
                e.Cell.Row.Cells["ImporteTransferido"].Value = 0;
            }
        }

        private void PagosUltraGridCellListSelect(object sender, CellEventArgs e)
        {
            e.Cell.Row.ExpandAll();
            if (e.Cell.Column.Key != "idCaja") return;
            dsEnCaja1.Clear();
            ultraCurrencyEditorSumValores.Value = 0;
            if (e.Cell.Value != DBNull.Value)
            {
                dsEnCaja1.Merge(
                    new Service().GetValoresEmpleado((int)e.Cell.Value,
                                                     Program.Pin));
            }
            else
            {
                return;
            }
            pagosUltraGrid.Rows[0].ChildBands["FK_Pagos_ValoresPagos"].Band.Override.AllowAddNew =
                AllowAddNew.Yes;
            dsOrdenDePago.ValoresOrdenDePago.Clear();
            foreach (DataRow origen in dsEnCaja1.EnCaja.Rows)
            {
                pagosBindingSource.EndEdit();
                pagosUltraGrid.Rows[0].Activate();
                pagosUltraGrid.Rows[0].ChildBands["FK_Pagos_ValoresPagos"].Rows.TemplateAddRow.Activate();
                pagosUltraGrid.Rows[0].ChildBands["FK_Pagos_ValoresPagos"].Rows.AddRowModifiedByUser = true;
                pagosUltraGrid.ActiveRow.Cells["Importe"].Value= origen["Importe"];
                pagosUltraGrid.ActiveRow.Cells["NumeroDeCheque"].Value = origen["NumeroDeCheque"];
                pagosUltraGrid.ActiveRow.Cells["Vencimiento"].Value = origen["Vencimiento"];
                pagosUltraGrid.ActiveRow.Cells["Observaciones"].Value = origen["Observaciones"];
                pagosUltraGrid.ActiveRow.Cells["Transferido"].Value = origen["Transferido"];
                pagosUltraGrid.ActiveRow.Cells["ImporteTransferido"].Value = origen["ImporteTransferido"];
                pagosUltraGrid.ActiveRow.Cells["idTipoDeValor"].Value = origen["idTipoDeValor"];
                pagosUltraGrid.ActiveRow.Cells["idBanco"].Value = origen["idBanco"];
                pagosUltraGrid.ActiveRow.Cells["idValorRemesa"].Value = origen["idValorRemesa"];
                pagosUltraGrid.PerformAction(UltraGridAction.CommitRow);
            }
            pagosUltraGrid.Rows[0].ChildBands["FK_Pagos_ValoresPagos"].Band.Override.AllowAddNew = AllowAddNew.No;
            pagosUltraGrid.Rows.ExpandAll(true);
            pagosUltraGrid.ActiveRow = null;
            if(pagosUltraGrid.Rows[0].ChildBands["FK_Pagos_ValoresPagos"].Rows.Count==1)
                pagosUltraGrid.Rows[0].ChildBands["FK_Pagos_ValoresPagos"].Rows[0].Cells["ImporteTransferido"].Value =
                    ultraCurrencyEditorSumCompras.Value;
        }

        private bool Validado()
        {
            foreach (DataRow renglon in dsOrdenDePago.ValoresOrdenDePago)
            {
                if((decimal)renglon["ImporteTransferido"] > (decimal)renglon["Importe"])
                {
                   return MessageBox.Show("Quedará un saldo negativo en la cuenta.", "Pagado mayor que Importe", MessageBoxButtons.OKCancel,
                                          MessageBoxIcon.Warning)==DialogResult.OK;
                }
            }
            return true;
        }

        private void UltraDropDownCajasFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }
    }
}
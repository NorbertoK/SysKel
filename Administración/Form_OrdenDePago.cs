using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Resources = Administración.Properties.Resources;

namespace Administración
{
    public partial class FormOrdenDePago : Form1
    {
        private readonly DateTime _fecha = new Service().HoraActual(Program.Pin);
        private bool _esBanco;

        public FormOrdenDePago()
        {
            InitializeComponent();
        }

        public int IdCompra { private get; set; }
        public string Proceso { private get; set; }

        private void Form_OrdenDePago_Load(object sender, EventArgs e)
        {
            dsEmpleadosLista.Merge(new Service().GetCajasConSaldoOBanco(Program.Pin));
            dsBancos.Merge(new Service().GetBancos(Program.Pin));
            dsTiposDeValores.Merge(new Service().GetTiposDeValores(Program.Pin));
            dsProveedores.Merge(new Service().GetProveedoresActivos(Program.Pin));
            dsRubros.Merge(new Service().GetRubrosQueAdmitenValores(Program.Pin));
            dsSistemas.Merge(new Service().GetSistemas(Program.Pin));
            /*Que la fecha de registro de la Solicitud sea la actual*/
            ordenDePagoUltraGrid.DisplayLayout.Bands["OrdenesDePago"].Columns["Fecha"].DefaultCellValue =
                _fecha;
            ordenDePagoUltraGrid.DisplayLayout.Bands["OrdenesDePago"].Columns["idGrabador"].DefaultCellValue =
                Program.IdUsuario;
            if (Tag.ToString() == "Uno")
            {
                dsOrdenDePago.Merge(new Service().GetCompraDelPago(IdCompra, Program.Pin));
            }
            else
            {
                dsOrdenDePago.Merge(new Service().GetComprasDelPago(Proceso, Program.Pin));
                new Service().EliminarProceso(Proceso, Program.Pin);
            }
            ordenDePagoUltraGrid.DisplayLayout.Bands[0].AddNew();
            ordenDePagoUltraGrid.Rows[0].Update();
            ordenDePagoUltraGrid.Rows[0].ChildBands["FK_ComprobantesOrdenesDePago_OrdenesDePago"].Band.Override
                .AllowAddNew =
                AllowAddNew.Yes;

            foreach (DataRow row in dsOrdenDePago.ComprasElegidas)
            {
                ordenesDePagoBindingSource.EndEdit();
                ordenDePagoUltraGrid.Rows[0].Activate();
                ordenDePagoUltraGrid.Rows[0].ChildBands["FK_ComprobantesOrdenesDePago_OrdenesDePago"].Rows
                    .TemplateAddRow.Activate();
                ordenDePagoUltraGrid.Rows[0].ChildBands["FK_ComprobantesOrdenesDePago_OrdenesDePago"].Rows
                    .AddRowModifiedByUser = true;
                ordenDePagoUltraGrid.ActiveRow.Cells["IdCompra"].Value = (int)row["idCompra"];
                ordenDePagoUltraGrid.ActiveRow.Cells["SaldoCompra"].Value = (decimal)row["Saldo"];
                ordenDePagoUltraGrid.ActiveRow.Cells["ImportePagado"].Column.MinValue = 0;
                ordenDePagoUltraGrid.ActiveRow.Cells["ImportePagado"].Column.MaxValue = (decimal)row["Saldo"];
                ordenDePagoUltraGrid.ActiveRow.Cells["ImportePagado"].Value = (decimal)row["Saldo"];
                ordenDePagoUltraGrid.ActiveRow.Cells["FechaCompra"].Value = (DateTime)row["Fecha"];
                ordenDePagoUltraGrid.ActiveRow.Cells["ComprobanteCompra"].Value = row["Comprobante"].ToString();
                ordenDePagoUltraGrid.ActiveRow.Cells["idProveedor"].Value = (int)row["idProveedor"];
                ordenDePagoUltraGrid.PerformAction(UltraGridAction.CommitRow);
            }
            ordenDePagoUltraGrid.Rows[0].ChildBands["FK_ComprobantesOrdenesDePago_OrdenesDePago"].Band.Override
                .AllowAddNew = AllowAddNew.No;
            ordenDePagoUltraGrid.Rows.ExpandAll(true);
            ordenDePagoUltraGrid.ActiveRow = null;
            dsOrdenDePago.OrdenesDePago[0].idProveedor = dsOrdenDePago.ComprobantesOrdenesDePago[0].idProveedor;
        }

        private void ComprasElegidasUltraGridSummaryValueChanged(object sender, SummaryValueChangedEventArgs e)
        {
            if (e.SummaryValue.Key == "SumCompras" && (decimal) e.SummaryValue.Value != 0)
            {
                ordenDePagoUltraGrid.Rows[0].Cells["Importe"].Value = (decimal) e.SummaryValue.Value;
                var renglonesDebe = from renglonesA in dsOrdenDePago.LibroDiarioOrdenDePago.AsEnumerable()
                    where
                        renglonesA.Field<int>("idRubro") ==
                        dsProveedores.Proveedores.FindByidProveedor(
                            (int) ordenDePagoUltraGrid.Rows[0].Cells["idProveedor"].Value).idRubro
                    select renglonesA;
                var renglonDebe = renglonesDebe.FirstOrDefault();
                if (renglonDebe != null)
                {
                    renglonDebe["Debe"] = (decimal) e.SummaryValue.Value;
                }
            }
            if (e.SummaryValue.Key == "SumEfectivo" && !_esBanco)
            {
                var renglonesEfectivo = from renglonesB in dsOrdenDePago.LibroDiarioOrdenDePago.AsEnumerable()
                    where renglonesB.Field<int>("idRubro") == (int) dsSistemas.Sistemas.Rows[0]["PagosEfectivo"]
                    select renglonesB;
                var renglonDiario = renglonesEfectivo.FirstOrDefault();
                if (renglonDiario != null)
                {
                    if ((decimal) e.SummaryValue.Value != 0)
                    {
                        renglonDiario["Haber"] = (decimal) e.SummaryValue.Value;
                    }
                    else
                    {
                        renglonDiario.Delete();
                    }
                }
                else if ((decimal) e.SummaryValue.Value != 0)
                {
                    var row = ordenDePagoUltraGrid.DisplayLayout.Bands["FK_OrdenesDePago_LibroDiario"].AddNew();
                    row.Cells["Fecha"].Value = _fecha;
                    row.Cells["idRubro"].Value = (int) dsSistemas.Sistemas.Rows[0]["PagosEfectivo"];
                    row.Cells["Haber"].Value = (decimal) e.SummaryValue.Value;
                }
            }
            if (e.SummaryValue.Key == "SumOtrosValores" && !_esBanco)
            {
                var renglonesEfectivo = from renglonesC in dsOrdenDePago.LibroDiarioOrdenDePago.AsEnumerable()
                    where renglonesC.Field<int>("idRubro") == (int) dsSistemas.Sistemas.Rows[0]["PagosConValores"]
                    select renglonesC;
                var renglonDiario = renglonesEfectivo.FirstOrDefault();
                if (renglonDiario != null)
                {
                    if ((decimal) e.SummaryValue.Value != 0)
                    {
                        renglonDiario["Haber"] = (decimal) e.SummaryValue.Value;
                    }
                    else
                    {
                        renglonDiario.Delete();
                    }
                }
                else if ((decimal) e.SummaryValue.Value != 0)
                {
                    var row = ordenDePagoUltraGrid.DisplayLayout.Bands["FK_OrdenesDePago_LibroDiario"].AddNew();
                    row.Cells["Fecha"].Value = _fecha;
                    row.Cells["idRubro"].Value = (int) dsSistemas.Sistemas.Rows[0]["PagosConValores"];
                    row.Cells["Haber"].Value = (decimal) e.SummaryValue.Value;
                    ordenDePagoUltraGrid.Rows[0].ChildBands["FK_OrdenesDePago_LibroDiario"].Rows.AddRowModifiedByUser =
                        true;
                }
            }
            if (e.SummaryValue.Key == "SumValores" && _esBanco)
            {
                var renglonesEfectivo = from renglonesD in dsOrdenDePago.LibroDiarioOrdenDePago.AsEnumerable()
                    where
                        renglonesD.Field<int>("idRubro") ==
                        dsEmpleadosLista.EmpleadosLista.FindByidEmpleado(
                            (int) ordenDePagoUltraGrid.Rows[0].Cells["idEmpleado"].Value).Cuenta
                    select renglonesD;
                var renglonDiario = renglonesEfectivo.FirstOrDefault();
                if (renglonDiario != null)
                {
                    if ((decimal) e.SummaryValue.Value != 0)
                    {
                        renglonDiario["Haber"] = (decimal) e.SummaryValue.Value;
                    }
                    else
                    {
                        renglonDiario.Delete();
                    }
                }
                else if ((decimal) e.SummaryValue.Value != 0)
                {
                    var row = ordenDePagoUltraGrid.DisplayLayout.Bands["FK_OrdenesDePago_LibroDiario"].AddNew();
                    row.Cells["Fecha"].Value = _fecha;
                    row.Cells["idRubro"].Value = dsEmpleadosLista.EmpleadosLista.FindByidEmpleado(
                        (int) ordenDePagoUltraGrid.Rows[0].Cells["idEmpleado"].Value).Cuenta;
                    row.Cells["Haber"].Value = (decimal) e.SummaryValue.Value;
                    ordenDePagoUltraGrid.Rows[0].ChildBands["FK_OrdenesDePago_LibroDiario"].Rows.AddRowModifiedByUser =
                        true;
                }
            }
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (!Validado()) return;
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            Validate();
            ordenesDePagoBindingSource.EndEdit();
            ordenDePagoUltraGrid.Update();
            var aux = new Service().UpdateOrdenDePago(dsOrdenDePago, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine +
                    Environment.NewLine +
                    "Póngase en contacto con el Administrador del Sistema.",
                    "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                buttonAceptar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
            else
            {
                dsOrdenDePago.Merge(aux);
                ManejoDatos.AplicarUpdate(dsOrdenDePago);
                var f = new FormRepPago
                {
                    IdOrdenDePago = (int)dsOrdenDePago.OrdenesDePago.Rows[0]["idOrdenDePago"],
                    MdiParent = MdiParent,
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(0, 0)
                };
                f.Show();
                Close();
            }
        }

        private void ComprasElegidasUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Band.Key != "FK_ValoresRetiros_OrdenesDePago") return;
            //if ((bool) e.Row.Cells["EnCaja"].Value) // Trajo los datos
            //{
            if (_esBanco) // Es banco ////y trajo los datos.
            {
                e.Row.Cells["idTipoDeValor"].Activation = Activation.AllowEdit;
                e.Row.Cells["Transferido"].Hidden = true;
                e.Row.Cells["ImporteTransferido"].Activation = Activation.AllowEdit;
                e.Row.Cells["ImporteTransferido"].Column.MaxValue = (decimal) e.Row.Cells["Importe"].Value;
                if (
                    dsTiposDeValores.TiposDeValores.FindByidTipoDeValor((int) e.Row.Cells["idTipoDeValor"].Value)
                        .RequiereBanco)
                {
                    e.Row.Cells["idBanco"].Hidden = false;
                    e.Row.Cells["idBanco"].Activation = Activation.ActivateOnly;
                    e.Row.Cells["idBanco"].Value =
                        dsEmpleadosLista.EmpleadosLista.FindByidEmpleado(
                            (int) ordenDePagoUltraGrid.Rows[0].Cells["idEmpleado"].Value).idBanco;
                    e.Row.Cells["NumeroDeCheque"].Hidden = false;
                    e.Row.Cells["Vencimiento"].Hidden = false;
                }
                else
                {
                    e.Row.Cells["idBanco"].Hidden = true;
                    e.Row.Cells["NumeroDeCheque"].Hidden = true;
                    e.Row.Cells["Vencimiento"].Hidden = true;
                    e.Row.Cells["idBanco"].Value = DBNull.Value;
                    e.Row.Cells["NumeroDeCheque"].Value = DBNull.Value;
                    e.Row.Cells["Vencimiento"].Value = DBNull.Value;
                }
            }
            else // No es Banco ////y trajo los datos.
            {
                e.Row.Cells["idTipoDeValor"].Activation = Activation.ActivateOnly;
                e.Row.Cells["idBanco"].Activation = Activation.ActivateOnly;
                e.Row.Cells["NumeroDeCheque"].Activation = Activation.ActivateOnly;
                e.Row.Cells["Vencimiento"].Activation = Activation.ActivateOnly;
                if (
                    dsTiposDeValores.TiposDeValores.FindByidTipoDeValor((int) e.Row.Cells["idTipoDeValor"].Value)
                        .RequiereBanco)
                {
                    e.Row.Cells["Transferido"].Hidden = false;
                    e.Row.Cells["ImporteTransferido"].Activation = Activation.ActivateOnly;
                }
                else
                {
                    e.Row.Cells["Transferido"].Hidden = true;
                    e.Row.Cells["ImporteTransferido"].Activation = Activation.AllowEdit;
                    e.Row.Cells["ImporteTransferido"].Column.MaxValue = (decimal) e.Row.Cells["Importe"].Value;
                }
            }
            if (e.Row.Cells["idTipoDeValor"].Value != DBNull.Value)
            {
                e.Row.Cells["EsEfectivo"].Value =
                    dsTiposDeValores.TiposDeValores.FindByidTipoDeValor((int) e.Row.Cells["idTipoDeValor"].Value)
                        .EsEfectivo;
            }
        }

        private void ComprasElegidasUltraGridCellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Row.Band.Key != "FK_ValoresRetiros_OrdenesDePago") return;
            if (e.Cell.Column.Key != "Transferido") return;
            if ((decimal) e.Cell.Row.Cells["ImporteTransferido"].Value == 0)
            {
                e.Cell.Row.Cells["ImporteTransferido"].Value = (decimal) e.Cell.Row.Cells["Importe"].Value;
            }
            else
            {
                e.Cell.Row.Cells["ImporteTransferido"].Value = 0;
            }
        }

        private void ComprasElegidasUltraGridCellListSelect(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "idEmpleado") return;
            ordenDePagoUltraGrid.Rows[0].ChildBands["FK_ValoresRetiros_OrdenesDePago"].Band.Hidden = false;
            ordenDePagoUltraGrid.Rows[0].ChildBands["FK_OrdenesDePago_LibroDiario"].Band.Hidden = false;
            ordenDePagoUltraGrid.Rows[0].ChildBands["FK_ComprobantesOrdenesDePago_OrdenesDePago"].Band.Hidden = false;
            e.Cell.Row.ExpandAll();
            ordenDePagoUltraGrid.ActiveRow.Update();
            dsEnCaja1.Clear();
            var renglonesBorrar = dsOrdenDePago.LibroDiarioOrdenDePago.Select("Haber <> 0");
            foreach (var renglon in renglonesBorrar)
            {
                renglon.Delete();
            }
            dsOrdenDePago.LibroDiarioOrdenDePago.AcceptChanges();
            _esBanco = new Service().EsBanco((int) ordenDePagoUltraGrid.Rows[0].Cells["idEmpleado"].Value, Program.Pin);
            dsEnCaja1.Merge(
                new Service().GetValoresEmpleado((int) e.Cell.Value,
                    Program.Pin));
            dsOrdenDePago.ValoresOrdenDePago.Clear();
            foreach (DataRow origen in dsEnCaja1.EnCaja.Rows)
            {
                var destino = dsOrdenDePago.ValoresOrdenDePago.NewRow();
                destino["Importe"] = origen["Importe"];
                destino["NumeroDeCheque"] = origen["NumeroDeCheque"];
                destino["Vencimiento"] = origen["Vencimiento"];
                destino["Observaciones"] = origen["Observaciones"];
                destino["Transferido"] = origen["Transferido"];
                destino["ImporteTransferido"] = origen["ImporteTransferido"];
                destino["idTipoDeValor"] = origen["idTipoDeValor"];
                destino["idBanco"] = origen["idBanco"];
                destino["idValorRemesa"] = origen["idValorRemesa"];
                destino["idOrdenDePago"] = (int) ordenDePagoUltraGrid.Rows[0].Cells["idOrdenDePago"].Value;
                dsOrdenDePago.ValoresOrdenDePago.Rows.Add(destino);
            }
            /*Empieza a crear el asiento*/
            ordenesDePagoBindingSource.EndEdit();
            ordenDePagoUltraGrid.Rows[0].Activate();
            dsOrdenDePago.LibroDiarioOrdenDePago.AcceptChanges();
            ordenDePagoUltraGrid.Rows[0].ChildBands["FK_OrdenesDePago_LibroDiario"].Rows.TemplateAddRow.Activate();
            ordenDePagoUltraGrid.Rows[0].ChildBands["FK_OrdenesDePago_LibroDiario"].Rows.AddRowModifiedByUser = true;
            ordenDePagoUltraGrid.ActiveRow.Cells["Fecha"].Value = _fecha;
            ordenDePagoUltraGrid.ActiveRow.Cells["idRubro"].Value = dsProveedores.Proveedores.FindByidProveedor(
                (int) ordenDePagoUltraGrid.Rows[0].Cells["idProveedor"].Value).idRubro;
            ordenDePagoUltraGrid.ActiveRow.Cells["Debe"].Value =
                (decimal)
                    ordenDePagoUltraGrid.Rows[0].ChildBands["FK_ComprobantesOrdenesDePago_OrdenesDePago"].Rows
                        .SummaryValues["SumCompras"].Value;
            ordenDePagoUltraGrid.PerformAction(UltraGridAction.CommitRow);
            /*Termina de crear el asiento*/
            if (_esBanco)
            {
                ordenDePagoUltraGrid.DisplayLayout.Bands["FK_ValoresRetiros_OrdenesDePago"].Override.AllowAddNew =
                    AllowAddNew.TemplateOnBottom;
                ordenDePagoUltraGrid.DisplayLayout.Bands["FK_ValoresRetiros_OrdenesDePago"].Override.AllowDelete =
                    DefaultableBoolean.True;
            }
            else
            {
                ordenDePagoUltraGrid.DisplayLayout.Bands["FK_ValoresRetiros_OrdenesDePago"].Override.AllowAddNew =
                    AllowAddNew.No;
                ordenDePagoUltraGrid.DisplayLayout.Bands["FK_ValoresRetiros_OrdenesDePago"].Override.AllowDelete =
                    DefaultableBoolean.False;
            }
        }

        private bool Validado()
        {
            foreach (DataRow renglon in dsOrdenDePago.ValoresOrdenDePago)
            {
                if (renglon["Importe"] != DBNull.Value &&
                    (decimal)renglon["ImporteTransferido"] > (decimal)renglon["Importe"])
                {
                    return MessageBox.Show("Quedará un saldo negativo en la cuenta.",
                        "Pagado mayor que Importe", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning) == DialogResult.OK;
                }
            }
            if ((decimal) ordenDePagoUltraGrid.Rows[0].ChildBands["FK_OrdenesDePago_LibroDiario"].Rows.SummaryValues[
                "TotalDebe"].Value !=
                (decimal) ordenDePagoUltraGrid.Rows[0].ChildBands["FK_OrdenesDePago_LibroDiario"].Rows.SummaryValues[
                    "TotalHaber"].Value)
            {
                MessageBox.Show("El Debe y el Haber no balancean.",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void UltraDropDownCajasFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void ultraDropDownCajas_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownCajas.DisplayLayout.Bands[0].Columns["ApelNomb"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void ordenDePagoUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            if (ordenDePagoUltraGrid.ActiveCell.Column.DataType.ToString() == "System.Boolean") return;
            ordenDePagoUltraGrid.ActiveCell.SelStart = 0;
            ordenDePagoUltraGrid.ActiveCell.SelLength = e.ToString().Length;
        }

        private void ultraDropDownTiposDeValores_FilterRow(object sender, FilterRowEventArgs e)
        {
            FilterCondition fc;
            if (ordenDePagoUltraGrid.Rows[0].Cells["idEmpleado"].Value == DBNull.Value)
            {
                fc = new FilterCondition(e.Row.Band.Columns["idTipoDeValor"], FilterComparisionOperator.Equals, 0);
            }
            else if (_esBanco)
            {
                fc = new FilterCondition(e.Row.Band.Columns["SePagaCon"], FilterComparisionOperator.Equals, true);
            }
            else // No es Banco
            {
                fc = new FilterCondition(e.Row.Band.Columns["idTipoDeValor"], FilterComparisionOperator.Equals,
                    e.Row.Band.Columns["idTipoDeValor"]);
            }
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void ultraDropDownTiposDeValores_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownRubros.DisplayLayout.RefreshFilters();
        }

        private void ordenDePagoUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ordenDePagoUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
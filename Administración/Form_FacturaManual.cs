using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Administración.Properties;
using Administración.WS;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
namespace Administración
{
    public partial class FormFacturaManual : Form1
    {
        private FormPrincipal _fp;

        public FormFacturaManual()
        {
            InitializeComponent();
        }

        public string Tipo { private get; set; }
        public int IdReferencia { private get; set; }

        private void FormFacturaManual_Load(object sender, EventArgs e)
        {
            _fp = (FormPrincipal) MdiParent;
            clientesListaBindingSource.DataSource = _fp.dsClientesLista;
            dsPuntosDeVenta.Merge(new Service().GetPuntosDeVenta(Program.Pin));
            dsPorcentajeIVA.Merge(new Service().GetPorcentajeIVA(Program.Pin));
            dsCategoriasIVA1.Merge(new Service().GetCategoriasIva(Program.Pin));
            ds_TiposDeComprobante.Merge(new Service().GetTiposDeComprobante(Program.Pin));
            dsParametros1.Merge(new Service().GetParametros(Program.Pin));
            dsNegocios.Merge(new Service().GetNegocios(Program.Pin));
            /*Que la fecha del comprobante sea la actual*/
            comprobantesManualesUltraGrid.DisplayLayout.Bands["ComprobantesManuales"].Columns["Fecha"].DefaultCellValue
                =
                new Service().HoraActual(Program.Pin);
            totalesUltraGrid.DisplayLayout.Bands[0].AddNew();
            if (Tipo != "Factura")
            {
                comprobantesManualesUltraGrid.DisplayLayout.Bands["ComprobantesManuales"].Columns["idTipoDeComprobante"]
                    .CellAppearance.FontData.Bold = DefaultableBoolean.True;
                if (Tipo == "NdeC")
                {
                    Text = "Nota de Crédito";
                    comprobantesManualesUltraGrid.DisplayLayout.Appearance.BackColor = Color.LightSalmon;
                    comprobantesManualesUltraGrid.DisplayLayout.Appearance.BackColor2 = Color.DarkSalmon;
                    totalesUltraGrid.DisplayLayout.Appearance.BackColor = Color.LightSalmon;
                    totalesUltraGrid.DisplayLayout.Appearance.BackColor2 = Color.DarkSalmon;
                }

                if (Tipo == "NdeD")
                {
                    Text = "Nota de Débito";
                    comprobantesManualesUltraGrid.DisplayLayout.Appearance.BackColor = Color.Aquamarine;
                    comprobantesManualesUltraGrid.DisplayLayout.Appearance.BackColor2 = Color.DeepSkyBlue;
                    totalesUltraGrid.DisplayLayout.Appearance.BackColor = Color.Aquamarine;
                    totalesUltraGrid.DisplayLayout.Appearance.BackColor2 = Color.DeepSkyBlue;
                }
                dsFacturaOriginal.Merge(new Service().GetComprobantePorIdComprobante(IdReferencia, Program.Pin));
                var origen = dsFacturaOriginal.ComprobantesManuales.Rows[0];
                var destino = dsFacturaManual.ComprobantesManuales.NewRow();
                destino["Fecha"] = new Service().HoraActual(Program.Pin);
                destino["Periodo"] = origen["Periodo"];
                destino["idCliente"] = origen["idCliente"];
                destino["idGrupo"] = origen["idGrupo"];
                destino["idPrestacion"] = origen["idPrestacion"];
                destino["Prefijo"] = origen["Prefijo"];
                destino["ServicioDesde"] = origen["ServicioDesde"];
                destino["ServicioHasta"] = origen["ServicioHasta"];
                destino["idFacturaProForma"] = origen["idFacturaProForma"];
                destino["idReferencia"] = origen["idComprobante"];
                dsFacturaManual.ComprobantesManuales.Rows.Add(destino);
                dsRenglonesFacturaLista.Merge(new Service().GetRenglonesDeFactura(
                    (int) comprobantesManualesUltraGrid.Rows[0].Cells["idCliente"].Value, Program.Pin));
                var idComprobante = dsFacturaManual.ComprobantesManuales.Rows[0]["idComprobante"];
                foreach (DataRow renglonOrigen in dsFacturaOriginal.DetallesComprobantesManuales.Rows)
                {
                    var renglonDestino = dsFacturaManual.DetallesComprobantesManuales.NewRow();
                    renglonDestino["idComprobante"] = idComprobante;
                    renglonDestino["Cantidad"] = renglonOrigen["Cantidad"];
                    renglonDestino["Detalle"] = renglonOrigen["Detalle"];
                    renglonDestino["Importe"] = renglonOrigen["Importe"];
                    renglonDestino["PrecioUnitario"] = renglonOrigen["PrecioUnitario"];
                    renglonDestino["idPorcentajeIVA"] = renglonOrigen["idPorcentajeIVA"];
                    renglonDestino["idNegocio"] = renglonOrigen["idNegocio"];
                    renglonDestino["idRenglonFacturaProforma"] = renglonOrigen["idRenglonFacturaProforma"];
                    dsFacturaManual.DetallesComprobantesManuales.Rows.Add(renglonDestino);
                }

                PonerComprobante();
                comprobantesManualesUltraGrid.Rows[0].Cells["idTipoDeComprobante"].Value =
                    new Service().GetIdTipoDeComprobante(Tipo,
                        (int) comprobantesManualesUltraGrid.Rows[0].Cells["idReferencia"].Value, Program.Pin);
                foreach (var renglon in comprobantesManualesUltraGrid.Rows[0].ChildBands[0].Rows)
                {
                    renglon.Update();
                    renglon.Activated = true;
                    if (renglon.Cells["PrecioUnitario"].Value == DBNull.Value)
                        renglon.Cells["PrecioUnitario"].Value =
                            (decimal) renglon.Cells["Importe"].Value / (int) renglon.Cells["Cantidad"].Value;
                    CalcularPrecioUnitarioEtc();
                    renglon.Activated = false;
                }

                comprobantesManualesUltraGrid.DisplayLayout.Bands["ComprobantesManuales"].Columns["idCliente"]
                    .CellActivation = Activation.NoEdit;
                buttonAceptar.Enabled = true;
                ultraLabel1.Visible = false;
            }
        }

        private bool Verificado()
        {
            if (comprobantesManualesUltraGrid.Rows[0].ChildBands[0].Rows.Count == 0)
            {
                MessageBox.Show("Falta el Detalle.", "Imposible Grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (!Verificado()) return;
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            buttonAceptar.Refresh();
            buttonCancelar.Refresh();
            if (Grabar())
                Close();
        }

        private bool Grabar()
        {
            bool ponerCobrador;
            if (Settings.Default.Empresa != "activa" && Tipo == "Factura")
            {
                var dr =
                    MessageBox.Show(
                        "Si se está haciendo este comprobante" +
                        Environment.NewLine +
                        "para entregárselo al cobrador, se generará" +
                        Environment.NewLine +
                        "una Facturación para registrar la recepción" +
                        "por parte del Cobrador." +
                        Environment.NewLine + Environment.NewLine +
                        "Si se está haciendo para cobrarlo ahora," +
                        Environment.NewLine +
                        "por mostrador, quedará sin Cobrador, como corresponde." +
                        Environment.NewLine +
                        Environment.NewLine + "¿Es para entregar al Cobrador?",
                        "Destino del Comprobante",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ponerCobrador = dr == DialogResult.Yes;
            }
            else
            {
                ponerCobrador = false;
            }

            Validate();
            comprobantesManualesBindingSource.EndEdit();
            var aux = new Service().UpdateFacturaManual(dsFacturaManual, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine +
                    Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información",
                    "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }

            dsFacturaManual.Merge(aux);
            ManejoDatos.AplicarUpdate(dsFacturaManual);
            var idComprobante = (int) comprobantesManualesUltraGrid.Rows[0].Cells["idComprobante"].Value;
            new Service().HacerComprobanteDeFacturaManual(idComprobante, ponerCobrador, Program.Pin);
            return true;
        }

        private void ComprobantesManualesUltraGridEnter(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void comprobantesManualesUltraGrid_BeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            var renglonActivo = comprobantesManualesUltraGrid.ActiveRow;
            if (renglonActivo.Band.Key == "ComprobantesManuales")
            {
                if (renglonActivo.Cells["idCliente"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show("Falta el Cliente.",
                        "Imposible Grabar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (renglonActivo.Cells["Prefijo"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta el prefijo.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                renglonActivo.Cells["idCliente"].Column.CellActivation = Activation.ActivateOnly;
            }
            else // Detalles
            {
                if (renglonActivo.Cells["Cantidad"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta la cantidad.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (renglonActivo.Cells["Detalle"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta el Detalle.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (renglonActivo.Cells["PrecioUnitario"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta el Precio Unitario.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (renglonActivo.Cells["idPorcentajeIVA"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta el porcentaje de IVA.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (renglonActivo.Cells["idNegocio"].Value == DBNull.Value &&
                    (bool) dsParametros1.Parametros.Rows[0]["UsaNegocios"])
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta el Negocio.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comprobantesManualesUltraGrid_CellListSelect(object sender, CellEventArgs e)
        {
            comprobantesManualesUltraGrid.ActiveRow.Update();
            if (e.Cell.Column.Key == "idCliente")
            {
                dsRenglonesFacturaLista.Clear();
                dsRenglonesFacturaLista.Merge(new Service().GetRenglonesDeFactura(
                    (int) comprobantesManualesUltraGrid.Rows[0].Cells["idCliente"].Value, Program.Pin));
                PonerComprobante();
            }

            if (e.Cell.Column.Key == "idRenglonFacturaProforma")
            {
                try
                {
                    e.Cell.Row.Cells["PrecioUnitario"].Value = dsRenglonesFacturaLista.RenglonesFacturaLista
                        .FindByidRenglonFacturaProforma((int) e.Cell.Value).PrecioUnitario;
                }
                catch (StrongTypingException)
                {
                    e.Cell.Row.Cells["PrecioUnitario"].Value = DBNull.Value;
                }

                try
                {
                    e.Cell.Row.Cells["idPorcentajeIVA"].Value = dsRenglonesFacturaLista.RenglonesFacturaLista
                        .FindByidRenglonFacturaProforma((int) e.Cell.Value).idPorcentajeIVA;
                }
                catch (StrongTypingException)
                {
                    e.Cell.Row.Cells["idPorcentajeIVA"].Value = DBNull.Value;
                }

                try
                {
                    e.Cell.Row.Cells["idNegocio"].Value = dsRenglonesFacturaLista.RenglonesFacturaLista
                        .FindByidRenglonFacturaProforma((int) e.Cell.Value).idNegocio;
                }
                catch (StrongTypingException)
                {
                    e.Cell.Row.Cells["idNegocio"].Value = DBNull.Value;
                }

                if (e.Cell.Band.ParentBand.Layout.Rows[0].Cells["idFacturaProForma"].Value == DBNull.Value)
                    e.Cell.Band.ParentBand.Layout.Rows[0].Cells["idFacturaProForma"].Value = dsRenglonesFacturaLista
                        .RenglonesFacturaLista.FindByidRenglonFacturaProforma((int) e.Cell.Value)
                        .idFacturaProforma;
                comprobantesManualesUltraGrid.Update();
            }
        }

        private void PonerComprobante()
        {
            if (Tipo == "Factura")
                comprobantesManualesUltraGrid.Rows[0].Cells["idTipoDeComprobante"].Value =
                    dsCategoriasIVA1.CategoriasIVA.FindByidCategoriaIVA(
                            _fp.dsClientesLista.ClientesLista
                                .FindByidCliente((int) comprobantesManualesUltraGrid.Rows[0].Cells["idCliente"]
                                    .Value)
                                .idCategoriaIva)
                        .Factura;
            if (Tipo == "NdeC")
                comprobantesManualesUltraGrid.Rows[0].Cells["idTipoDeComprobante"].Appearance.ForeColor = Color.Red;
            if (Tipo == "NdeD")
                comprobantesManualesUltraGrid.Rows[0].Cells["idTipoDeComprobante"].Appearance.ForeColor = Color.Blue;
            if (comprobantesManualesUltraGrid.Rows[0].Cells["idTipoDeComprobante"].Text.EndsWith("B"))
            {
                comprobantesManualesUltraGrid.Rows[0].ChildBands["FK__DetallesC__idCom__07AC1A97"].Band.Columns[
                    "IVA"].Hidden = true;
                totalesUltraGrid.Rows[0].Cells["NoGravado"].Hidden = true;
                totalesUltraGrid.Rows[0].Cells["Exento"].Hidden = true;
                totalesUltraGrid.Rows[0].Cells["Neto"].Hidden = true;
                totalesUltraGrid.Rows[0].Cells["Subtotal"].Hidden = true;
                totalesUltraGrid.Rows[0].Cells["IVA"].Hidden = true;
            }
            else
            {
                comprobantesManualesUltraGrid.Rows[0].ChildBands["FK__DetallesC__idCom__07AC1A97"].Band.Columns[
                    "IVA"].Hidden = false;
                if ((bool) dsParametros1.Parametros.Rows[0]["UsaNegocios"] == false)
                    comprobantesManualesUltraGrid.Rows[0].ChildBands["FK__DetallesC__idCom__07AC1A97"].Band.Columns[
                        "idNegocio"].Hidden = true;
                totalesUltraGrid.Rows[0].Cells["NoGravado"].Hidden = false;
                totalesUltraGrid.Rows[0].Cells["Exento"].Hidden = false;
                totalesUltraGrid.Rows[0].Cells["Neto"].Hidden = false;
                totalesUltraGrid.Rows[0].Cells["Subtotal"].Hidden = false;
                totalesUltraGrid.Rows[0].Cells["IVA"].Hidden = false;
            }
        }

        private void CalcularPrecioUnitarioEtc()
        {
            comprobantesManualesUltraGrid.ActiveRow.Update();
            if (comprobantesManualesUltraGrid.ActiveRow.Cells["PrecioUnitario"].Value != DBNull.Value &&
                comprobantesManualesUltraGrid.ActiveRow.Cells["idPorcentajeIVA"].Value != DBNull.Value &&
                comprobantesManualesUltraGrid.ActiveRow.Cells["Cantidad"].Value != DBNull.Value)
            {
                /*Empieza a calcular los totales*/
                totalesUltraGrid.Rows[0].Cells["NoGravado"].Value = 0;
                totalesUltraGrid.Rows[0].Cells["Exento"].Value = 0;
                totalesUltraGrid.Rows[0].Cells["Neto"].Value = 0;
                totalesUltraGrid.Rows[0].Cells["IVA"].Value = 0;
                totalesUltraGrid.Rows[0].Cells["Total"].Value = 0;
                foreach (
                    var renglon in
                    comprobantesManualesUltraGrid.Rows[0].ChildBands["FK__DetallesC__idCom__07AC1A97"].Rows)
                { 
                    var valor = renglon.Cells["PrecioUnitario"].Value == DBNull.Value
                        ? renglon.Cells["Importe"].Value
                        : renglon.Cells["PrecioUnitario"].Value;
                    renglon.Cells["Precio"].Value = 
                        Math.Round((decimal) valor /
                                   (comprobantesManualesUltraGrid.DisplayLayout.Rows[0].Cells["idTipoDeComprobante"]
                                        .Text.EndsWith("A") || comprobantesManualesUltraGrid.DisplayLayout.Rows[0]
                                        .Cells["idTipoDeComprobante"]
                                        .Text.EndsWith("M")
                                       ? 1 +
                                         dsPorcentajeIVA.PorcentajeIVA.FindByidPorcentajeIVA(
                                                 (int) renglon.Cells["idPorcentajeIVA"]
                                                     .Value)
                                             .Porcentaje /
                                         100
                                       : 1), 2, MidpointRounding.ToEven);
                    renglon.Cells["ImporteEscrito"].Value =
                        (decimal) renglon.Cells["Precio"].Value *
                        (int) renglon.Cells["Cantidad"].Value;
                    renglon.Cells["NoGravado"].Value =
                        (int) renglon.Cells["idPorcentajeIVA"].Value == 1
                            ? (decimal) renglon.Cells["ImporteEscrito"].Value
                            : 0;
                    renglon.Cells["Exento"].Value =
                        (int) renglon.Cells["idPorcentajeIVA"].Value == 2
                            ? (decimal) renglon.Cells["ImporteEscrito"].Value
                            : 0;
                    renglon.Cells["IVA"].Hidden = false;
                    renglon.Cells["IVA"].Value =
                        Math.Round((decimal) renglon.Cells["Precio"].Value *
                                   dsPorcentajeIVA.PorcentajeIVA.FindByidPorcentajeIVA(
                                           (int) renglon.Cells["idPorcentajeIVA"].Value)
                                       .Porcentaje /
                                   100 * (int) renglon.Cells["Cantidad"].Value, 2,
                            MidpointRounding.ToEven);
                    if ((int) renglon.Cells["idPorcentajeIVA"].Value > 2)
                        renglon.Cells["Neto"].Value =
                            (decimal?) renglon.Cells["ImporteEscrito"].Value ?? 0;
                    else
                        renglon.Cells["Neto"].Value = 0;
                    totalesUltraGrid.Rows[0].Cells["NoGravado"].Value =
                        // ReSharper disable once PossibleInvalidCastException
                        (decimal) totalesUltraGrid.Rows[0].Cells["NoGravado"].Value +
                        (decimal) renglon.Cells["NoGravado"].Value;
                    totalesUltraGrid.Rows[0].Cells["Exento"].Value =
                        // ReSharper disable once PossibleInvalidCastException
                        (decimal) totalesUltraGrid.Rows[0].Cells["Exento"].Value +
                        (decimal) renglon.Cells["Exento"].Value;
                    totalesUltraGrid.Rows[0].Cells["Neto"].Value =
                        // ReSharper disable once PossibleInvalidCastException
                        (decimal) totalesUltraGrid.Rows[0].Cells["Neto"].Value + (decimal) renglon.Cells["Neto"].Value;
                    totalesUltraGrid.Rows[0].Cells["IVA"].Value =
                        // ReSharper disable once PossibleInvalidCastException
                        (decimal) totalesUltraGrid.Rows[0].Cells["IVA"].Value + (decimal) renglon.Cells["IVA"].Value;
                    if (comprobantesManualesUltraGrid.DisplayLayout.Rows[0].Cells["idTipoDeComprobante"].Text
                        .EndsWith("B"))
                        totalesUltraGrid.Rows[0].Cells["Total"].Value =
                            // ReSharper disable once PossibleInvalidCastException
                            (decimal) totalesUltraGrid.Rows[0].Cells["Total"].Value +
                            (decimal) renglon.Cells["ImporteEscrito"].Value;
                }

                totalesUltraGrid.Rows[0].Cells["Subtotal"].Value =
                    (totalesUltraGrid.Rows[0].Cells["NoGravado"].Value == DBNull.Value
                        ? 0
                        // ReSharper disable once PossibleInvalidCastException
                        : (decimal) totalesUltraGrid.Rows[0].Cells["NoGravado"].Value) +
                    (totalesUltraGrid.Rows[0].Cells["Exento"].Value == DBNull.Value
                        ? 0
                        // ReSharper disable once PossibleInvalidCastException
                        : (decimal) totalesUltraGrid.Rows[0].Cells["Exento"].Value) +
                    (totalesUltraGrid.Rows[0].Cells["Neto"].Value == DBNull.Value
                        ? 0
                        // ReSharper disable once PossibleInvalidCastException
                        : (decimal) totalesUltraGrid.Rows[0].Cells["Neto"].Value);
                if (comprobantesManualesUltraGrid.DisplayLayout.Rows[0].Cells["idTipoDeComprobante"].Text
                        .EndsWith("A") || comprobantesManualesUltraGrid.DisplayLayout.Rows[0]
                        .Cells["idTipoDeComprobante"].Text.EndsWith("M"))
                    totalesUltraGrid.Rows[0].Cells["Total"].Value =
                        (decimal) totalesUltraGrid.Rows[0].Cells["Subtotal"].Value +
                        (totalesUltraGrid.Rows[0].Cells["IVA"].Value == DBNull.Value
                            ? 0
                            // ReSharper disable once PossibleInvalidCastException
                            : (decimal) totalesUltraGrid.Rows[0].Cells["IVA"].Value);
                /*Termina de calcular los totales*/
            }
        }

        private void comprobantesManualesUltraGrid_BeforeCellDeactivate(object sender, CancelEventArgs e)
        {
            if (comprobantesManualesUltraGrid.ActiveCell.Column.Key == "Periodo")
                if (comprobantesManualesUltraGrid.ActiveCell.Value == DBNull.Value)
                {
                    comprobantesManualesUltraGrid.ActiveCell.Row.Cells["ServicioDesde"].Value = DBNull.Value;
                    comprobantesManualesUltraGrid.ActiveCell.Row.Cells["ServicioHasta"].Value = DBNull.Value;
                }
                else
                {
                    comprobantesManualesUltraGrid.ActiveCell.Row.Cells["ServicioDesde"].Value = new DateTime(
                        int.Parse(comprobantesManualesUltraGrid.ActiveCell.Text.Substring(3, 4)), int.Parse(
                            comprobantesManualesUltraGrid
                                .ActiveCell.Text.Substring(0, 2)), 1);
                    comprobantesManualesUltraGrid.ActiveCell.Row.Cells["ServicioHasta"].Value = new DateTime(
                        int.Parse(comprobantesManualesUltraGrid.ActiveCell.Text.Substring(3, 4)), int.Parse(
                            comprobantesManualesUltraGrid
                                .ActiveCell.Text.Substring(0, 2)), 1).AddMonths(1).AddDays(-1);
                }

            if (comprobantesManualesUltraGrid.ActiveCell.Column.Key == "PrecioUnitario" ||
                comprobantesManualesUltraGrid.ActiveCell.Column.Key == "Cantidad")
                CalcularPrecioUnitarioEtc();
        }

        private void comprobantesManualesUltraGrid_AfterCellListCloseUp(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "idPorcentajeIVA")
            {
                e.Cell.Row.Update();
                CalcularPrecioUnitarioEtc();
            }
        }

        private void comprobantesManualesUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }

        private void ultraDropDownRenglonesFactura_FilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["idFacturaProforma"],
                FilterComparisionOperator.Equals,
                comprobantesManualesUltraGrid.ActiveRow.Cells["idFacturaProForma"].Value);
            if (comprobantesManualesUltraGrid.Rows[0].Cells["idFacturaProForma"].Value == DBNull.Value)
                e.RowFilteredOut = false;
            else
                e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }
    }
}
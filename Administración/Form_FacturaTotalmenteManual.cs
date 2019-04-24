using System;
using System.ComponentModel;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormFacturaTotalmenteManual : Form1
    {
        private FormPrincipal _fp;

        public FormFacturaTotalmenteManual()
        {
            InitializeComponent();
        }

        private void Form_FacturaTotalmenteManual_Load(object sender, EventArgs e)
        {
            /*Que la fecha del comprobante sea la actual*/
            comprobantesUltraGrid.DisplayLayout.Bands["Comprobantes"].Columns["Fecha"].DefaultCellValue
                =
                new Service().HoraActual(Program.Pin);
            _fp = (FormPrincipal) MdiParent;
            categoriasIVABindingSource.DataSource = _fp.dsCategoriasIVA;
            dsPuntosDeVenta.Merge(new Service().GetPuntosDeVenta(Program.Pin));
            dsParametros1.Merge(new Service().GetParametros(Program.Pin));
            dsCategoriasIVA.Merge(new Service().GetCategoriasIva(Program.Pin));
            dsNegocios.Merge(new Service().GetNegocios(Program.Pin));
            dsTiposDeComprobante1.Merge(new Service().GetTiposDeComprobante(Program.Pin));
            dsPorcentajeIVA.Merge(new Service().GetPorcentajeIVA(Program.Pin));
            if (comprobantesUltraGrid.Rows.Count > 0 &&
                comprobantesUltraGrid.Rows[0].Cells["CUIT"].Value.ToString().Length < 11)
            {
                comprobantesUltraGrid.Rows[0].Cells["CUIT"].Column.Header.Caption = @"DNI";
                comprobantesUltraGrid.Rows[0].Cells["CUIT"].Column.MaskInput = @"{LOC}nnn,nnn,nnn,nnn";
            }
            totalesUltraGrid.DisplayLayout.Bands[0].AddNew();
        }

        private bool Verificado()
        {
            if (comprobantesUltraGrid.DisplayLayout.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No hay ningún dato.",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["idCategoriaIVA"].Value == DBNull.Value)
            {
                MessageBox.Show(
                    "Falta la Categoría de IVA.",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comprobantesUltraGrid.Rows[0].Cells["Nombre"].Value == DBNull.Value)
            {
                MessageBox.Show("Falta el nombre.",
                    "Imposible Grabar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (comprobantesUltraGrid.Rows[0].Cells["ObservacionesDireccion"].Value == DBNull.Value)
            {
                MessageBox.Show("Falta la dirección.",
                    "Imposible Grabar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (comprobantesUltraGrid.Rows[0].ChildBands[0].Rows.Count == 0)
            {
                MessageBox.Show("Falta el Detalle.", "Imposible Grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void comprobantesUltraGrid_BeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            var renglonActivo = comprobantesUltraGrid.ActiveRow;
            if (renglonActivo.Band.Key == "Comprobantes")
            {
                if (renglonActivo.Cells["idCategoriaIVA"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta la Categoría de IVA.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (renglonActivo.Cells["CUIT"].Value == DBNull.Value ||
                    renglonActivo.Cells["CUIT"].Text == "__-__,___,___-_" || renglonActivo.Cells["CUIT"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Falta el CUIT.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (renglonActivo.Cells["CUIT"].Column.Header.Caption == @"CUIT")
                {
                    // Validación del CUIT, que no esté ingresado.
                    var sCUIT =
                        comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["CUIT"].Text.Replace(",", "")
                            .Replace("-", "");

                    if (sCUIT.Length == 11 &&
                        (int) _fp.dscuitRepetibles.CUITRepetibles.Compute("Count(CUIT)", "CUIT = " + sCUIT) == 0)
                    {
                        var nombClienteAnterior = new Service().NombreCuitIngresado(sCUIT, 0, Program.Pin);
                        if (nombClienteAnterior.Length > 0)
                        {
                            e.Cancel = true;
                            MessageBox.Show(this,
                                "El CUIT " +
                                comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["CUIT"].Text +
                                " ya figura en nuestros registros" +
                                Environment.NewLine + "perteneciendo a " +
                                nombClienteAnterior +
                                "." +
                                Environment.NewLine + Environment.NewLine +
                                "Esta factura es para Clientes NO registrados" +
                                Environment.NewLine +
                                "Por favor haga una factura para Clientes registrados."
                                ,
                                "Falta verificar el CUIT",
                                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        /*Validación del CUIT, que sea válido*/

                        if (sCUIT.Length == 11)
                        {
                            var xa = int.Parse(sCUIT.Substring(0, 1))*5;
                            var xb = int.Parse(sCUIT.Substring(1, 1))*4;
                            var xc = int.Parse(sCUIT.Substring(2, 1))*3;
                            var xd = int.Parse(sCUIT.Substring(3, 1))*2;
                            var xe = int.Parse(sCUIT.Substring(4, 1))*7;
                            var xf = int.Parse(sCUIT.Substring(5, 1))*6;
                            var xg = int.Parse(sCUIT.Substring(6, 1))*5;
                            var xh = int.Parse(sCUIT.Substring(7, 1))*4;
                            var xi = int.Parse(sCUIT.Substring(8, 1))*3;
                            var xj = int.Parse(sCUIT.Substring(9, 1))*2;
                            var x = xa + xb + xc + xd + xe + xf + xg + xh + xi + xj;
                            var control = (11 - (x%11))%11;
                            if (control != int.Parse(sCUIT.Substring(10, 1)))
                            {
                                e.Cancel = true;
                                MessageBox.Show("Inválido",
                                    "Falta verificar el CUIT",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                if (renglonActivo.Cells["Prefijo"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta el prefijo.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Detalles
            {
                if (renglonActivo.Cells["idNegocio"].Value == DBNull.Value && (bool)dsParametros1.Parametros.Rows[0]["UsaNegocios"])
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta el Negocio.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (renglonActivo.Cells["idPorcentajeIVA"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta el porcentaje de IVA.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (!Verificado()) return;
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            buttonAceptar.Refresh();
            buttonCancelar.Refresh();
            if (Grabar())
            {
                Close();
            }
        }

        private bool Grabar()
        {
            const bool ponerCobrador = false;
            Validate();
            comprobantesBindingSource.EndEdit();
            var aux = new Service().UpdateComprobantes(dsComprobantes, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos.",
                    "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                buttonCancelar.Enabled = true;
                return false;
            }
            dsComprobantes.Merge(aux);
            ManejoDatos.AplicarUpdate(dsComprobantes);
            var idComprobante = (int) comprobantesUltraGrid.Rows[0].Cells["idComprobante"].Value;
            new Service().HacerComprobanteDeFacturaManual(idComprobante, ponerCobrador, Program.Pin);
            return true;
        }

        private void ultraDropDownCategoriasIVA_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownCategoriasIVA.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void comprobantesUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
            if (comprobantesUltraGrid.ActiveCell.Column.Key == "CUIT")
            {
                comprobantesUltraGrid.ActiveCell.SelStart = 0;
            }
        }

        private void ultraDropDownNegocios_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownNegocios.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void comprobantesUltraGrid_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
        {
            if (e.Cell.Column.Key == "CUIT")
            {
                if (e.Cell.Column.Header.Caption == @"CUIT")
                {
                    e.Cell.Column.Header.Caption = @"DNI";
                    e.Cell.Column.MaskInput = @"{LOC}nnn,nnn,nnn,nnn";
                }
                else
                {
                    e.Cell.Column.Header.Caption = @"CUIT";
                    e.Cell.Column.MaskInput = @"##-##,###,###-#";
                }
            }
        }

        private void comprobantesUltraGrid_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            var renglonActivo = e.Row;
            if (renglonActivo != null && renglonActivo.Band.Key == "Comprobantes")
            {
                renglonActivo.ToolTipText = "Doble click para cambiar a DNI.";
            }
        }

        private void comprobantesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                comprobantesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
        private void CalcularPrecioUnitarioEtc()
        {
            comprobantesUltraGrid.ActiveRow.Update();
            if (comprobantesUltraGrid.ActiveRow.Cells["PrecioUnitario"].Value != DBNull.Value &&
                comprobantesUltraGrid.ActiveRow.Cells["idPorcentajeIVA"].Value != DBNull.Value &&
                comprobantesUltraGrid.ActiveRow.Cells["Cantidad"].Value != DBNull.Value)
            {
                comprobantesUltraGrid.ActiveRow.Cells["Precio"].Value =
                    Math.Round((decimal) comprobantesUltraGrid.ActiveRow.Cells["PrecioUnitario"].Value /
                               (comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["Comprobante"].Text ==
                                "Factura A" || comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["Comprobante"].Text ==
                                "Factura M"
                                   ? 1 +
                                     dsPorcentajeIVA.PorcentajeIVA.FindByidPorcentajeIVA(
                                             (int) comprobantesUltraGrid.ActiveRow.Cells["idPorcentajeIVA"]
                                                 .Value)
                                         .Porcentaje /
                                     100
                                   : 1), 2, MidpointRounding.ToEven);
                comprobantesUltraGrid.ActiveRow.Cells["IVA"].Hidden = false;
                comprobantesUltraGrid.ActiveRow.Cells["IVA"].Value =
                    Math.Round((decimal) comprobantesUltraGrid.ActiveRow.Cells["Precio"].Value *
                               dsPorcentajeIVA.PorcentajeIVA.FindByidPorcentajeIVA(
                                       (int) comprobantesUltraGrid.ActiveRow.Cells["idPorcentajeIVA"].Value)
                                   .Porcentaje /
                               100 * (int) comprobantesUltraGrid.ActiveRow.Cells["Cantidad"].Value, 2,
                        MidpointRounding.ToEven);
                //comprobantesUltraGrid.ActiveRow.Cells["ImporteEscrito"].Value =
                //    (decimal) comprobantesUltraGrid.ActiveRow.Cells["Importe"].Value/
                //    (comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["Comprobante"].Text == "Factura A"
                //        ? (1 +
                //           dsPorcentajeIVA.PorcentajeIVA.FindByidPorcentajeIVA(
                //               (int) comprobantesUltraGrid.ActiveRow.Cells["idPorcentajeIVA"].Value).Porcentaje/
                //           100)
                //        : 1);
                comprobantesUltraGrid.ActiveRow.Cells["ImporteEscrito"].Value =
                    (decimal) comprobantesUltraGrid.ActiveRow.Cells["Precio"].Value *
                    (int) comprobantesUltraGrid.ActiveRow.Cells["Cantidad"].Value;
                if ((int) comprobantesUltraGrid.ActiveRow.Cells["idPorcentajeIVA"].Value > 2)
                    comprobantesUltraGrid.ActiveRow.Cells["Neto"].Value =
                        (decimal) comprobantesUltraGrid.ActiveRow.Cells["ImporteEscrito"].Value;
                else
                    comprobantesUltraGrid.ActiveRow.Cells["Neto"].Value = 0;

                comprobantesUltraGrid.ActiveRow.Cells["NoGravado"].Value =
                    (int) comprobantesUltraGrid.ActiveRow.Cells["idPorcentajeIVA"].Value == 1
                        ? (decimal) comprobantesUltraGrid.ActiveRow.Cells["ImporteEscrito"].Value
                        : 0;
                comprobantesUltraGrid.ActiveRow.Cells["Exento"].Value =
                    (int) comprobantesUltraGrid.ActiveRow.Cells["idPorcentajeIVA"].Value == 2
                        ? (decimal) comprobantesUltraGrid.ActiveRow.Cells["ImporteEscrito"].Value
                        : 0;
                /*Empieza a calcular los totales*/
                totalesUltraGrid.Rows[0].Cells["NoGravado"].Value = 0;
                totalesUltraGrid.Rows[0].Cells["Exento"].Value = 0;
                totalesUltraGrid.Rows[0].Cells["Neto"].Value = 0;
                totalesUltraGrid.Rows[0].Cells["IVA"].Value = 0;
                totalesUltraGrid.Rows[0].Cells["Total"].Value = 0;
                foreach (
                    var renglon in
                    comprobantesUltraGrid.Rows[0].ChildBands["FK__DetallesC__idCom__07AC1A97"].Rows)
                {
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
                    if (comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["Comprobante"].Text == "Factura B")
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
                if (comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["Comprobante"].Text == "Factura A" || comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["Comprobante"].Text == "Factura M")
                    totalesUltraGrid.Rows[0].Cells["Total"].Value =
                        (decimal) totalesUltraGrid.Rows[0].Cells["Subtotal"].Value +
                        (totalesUltraGrid.Rows[0].Cells["IVA"].Value == DBNull.Value
                            ? 0
                            // ReSharper disable once PossibleInvalidCastException
                            : (decimal) totalesUltraGrid.Rows[0].Cells["IVA"].Value);
                /*Termina de calcular los totales*/
            }
        }
        private void comprobantesUltraGrid_CellListSelect(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "idCategoriaIVA")
            {
                comprobantesUltraGrid.ActiveRow.Update();
                e.Cell.Row.Cells["Comprobante"].Value = dsTiposDeComprobante1.TiposDeComprobante.FindByidTipoDeComprobante(dsCategoriasIVA.CategoriasIVA.FindByidCategoriaIVA(
                        ((int)e.Cell.Value))
                        .Factura).Nombre;
                if ((string)e.Cell.Row.Cells["Comprobante"].Value == "Factura B")
                {
                    comprobantesUltraGrid.Rows[0].ChildBands["FK__DetallesC__idCom__07AC1A97"].Band.Columns[
                        "IVA"].Hidden = true;
                    totalesUltraGrid.Rows[0].Cells["NoGravado"].Hidden = true;
                    totalesUltraGrid.Rows[0].Cells["Exento"].Hidden = true;
                    totalesUltraGrid.Rows[0].Cells["Neto"].Hidden = true;
                    totalesUltraGrid.Rows[0].Cells["Subtotal"].Hidden = true;
                    totalesUltraGrid.Rows[0].Cells["IVA"].Hidden = true;
                }
                else
                {
                    comprobantesUltraGrid.Rows[0].ChildBands["FK__DetallesC__idCom__07AC1A97"].Band.Columns[
                        "IVA"].Hidden = false;
                    if ((bool)dsParametros1.Parametros.Rows[0]["UsaNegocios"] == false)
                        comprobantesUltraGrid.Rows[0].ChildBands["FK__DetallesC__idCom__07AC1A97"].Band.Columns[
                        "idNegocio"].Hidden = true;
                    totalesUltraGrid.Rows[0].Cells["NoGravado"].Hidden = false;
                    totalesUltraGrid.Rows[0].Cells["Exento"].Hidden = false;
                    totalesUltraGrid.Rows[0].Cells["Neto"].Hidden = false;
                    totalesUltraGrid.Rows[0].Cells["Subtotal"].Hidden = false;
                    totalesUltraGrid.Rows[0].Cells["IVA"].Hidden = false;
                }
            }
        }

        private void comprobantesUltraGrid_BeforeCellDeactivate(object sender, CancelEventArgs e)
        {
            if (comprobantesUltraGrid.ActiveCell.Column.Key == "PrecioUnitario" || comprobantesUltraGrid.ActiveCell.Column.Key == "Cantidad")
                CalcularPrecioUnitarioEtc();
        }

        private void comprobantesUltraGrid_AfterCellListCloseUp(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "idPorcentajeIVA")
            {
                e.Cell.Row.Update();
                CalcularPrecioUnitarioEtc();
            }
        }
    }
}
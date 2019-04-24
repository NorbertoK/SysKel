using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormCompra : Form1
    {
        private readonly DateTime _fecha = new Service().HoraActual(Program.Pin);
        private FormPrincipal _fp;

        public FormCompra()
        {
            InitializeComponent();
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            _fp = (FormPrincipal) MdiParent;
            dsProveedores.Merge(new Service().GetProveedoresActivos(Program.Pin));
            dsRubros.Merge(new Service().GetRubrosQueAdmitenValores(Program.Pin));
            dsNegocios.Merge(new Service().GetNegocios(Program.Pin));
            dsPorcentajeIVA.Merge(new Service().GetPorcentajeIVA(Program.Pin));
            dsParametros.Merge(new Service().GetParametros(Program.Pin));
            dsSistemas.Merge(new Service().GetSistemas(Program.Pin));
            categoriasIVABindingSource.DataSource = _fp.dsCategoriasIVA;
            var fecha = new Service().HoraActual(Program.Pin);
            comprasUltraGrid.DisplayLayout.Bands["FK_Compras_LibroDiario"].Columns["Fecha"].DefaultCellValue =
                fecha;
            if (!(bool) dsParametros.Parametros.Rows[0]["UsaNegocios"])
                comprasUltraGrid.DisplayLayout.Bands["FK_NegociosCompras_Compras"].Hidden = true;
        }

        private void ultraComboProveedor_ValueChanged(object sender, EventArgs e)
        {
            if (ultraComboProveedor.Value != DBNull.Value)
            {
                comprasUltraGrid.DisplayLayout.Bands[0].Override.AllowAddNew = AllowAddNew.Yes;
                comprasUltraGrid.DisplayLayout.Bands[0].Override.AllowDelete = DefaultableBoolean.True;

                dsCompra.Clear();
                dsProveedor.Clear(); // Es la copia de dsProveedores.
                dsProveedor.Merge(new Service().GetProveedor((int) ultraComboProveedor.Value, Program.Pin));

                var origen = dsProveedor.Proveedores.Rows[0];
                var destino = dsCompra.Compras.NewRow();
                destino["Serie"] = origen["Serie"];
                destino["idProveedor"] = origen["idProveedor"];
                //destino["idRubro"] = origen["idRubro"];
                destino["Nombre"] = (string) origen["NombreCompleto"] == "Varios" ? "" : origen["NombreCompleto"];
                destino["CUIT"] = origen["CUIT"];
                destino["idGrabador"] = Program.IdUsuario;
                destino["Fecha"] = _fecha;
                destino["FechaRegistro"] = _fecha;
                destino["idTipoDeComprobante"] = 10; //Compra
                destino["idCategoriaIVA"] = origen["idCategoriaIVA"];
                dsCompra.Compras.Rows.Add(destino);

                foreach (DataRow origenNegocio in dsProveedor.NegociosDelProveedor.Rows)
                {
                    var destinoNegocio = dsCompra.NegociosCompras.NewRow();
                    destinoNegocio["idCompra"] = dsCompra.Compras.Rows[0]["idCompra"];
                    destinoNegocio["idNegocio"] = origenNegocio["idNegocio"];
                    destinoNegocio["Porcentaje"] = origenNegocio["Porcentaje"];
                    dsCompra.NegociosCompras.Rows.Add(destinoNegocio);
                }
                comprasUltraGrid.Visible = true;
                buttonAceptar.Enabled = true;
                buttonAplicar.Enabled = true; // Aceptar y posponer el pago
            }
            else // ultraComboProveedor.Value == DBNull.Value
            {
                dsCompra.Clear();
                comprasUltraGrid.Visible = false;
                comprasUltraGrid.Update();
            }
        }

        private void comprasUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            if (comprasUltraGrid.ActiveCell.Column.DataType.ToString() == "System.Boolean") return;
            comprasUltraGrid.ActiveCell.SelStart = 0;
        }

        private bool Verificar()
        {
            var compras = comprasUltraGrid.DisplayLayout.Bands["Compras"]; //Compras
            foreach (UltraGridRow compra in compras.GetRowEnumerator(GridRowType.DataRow)) //La compra
            {
                if (compra.Cells["Fecha"].Value == DBNull.Value)
                {
                    MessageBox.Show(
                        "Falta la fecha.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (compra.Cells["Nombre"].Value == DBNull.Value)
                {
                    MessageBox.Show(
                        "Falta el nombre.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (compra.Cells["Serie"].Value == DBNull.Value)
                {
                    MessageBox.Show(
                        "Falta la Serie.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (compra.Cells["Importe"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el importe total.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!VerificarConFactura(compra)) return false;
                if (comprasUltraGrid.DisplayLayout.Bands["FK_NegociosCompras_Compras"].Hidden == false)
                {
                    if (
                        (Decimal)
                            comprasUltraGrid.Rows[0].ChildBands["FK_NegociosCompras_Compras"].Rows.SummaryValues[
                                "SumNegocios"].Value != 100)
                    {
                        MessageBox.Show("El total de los negocios no suma 100%.",
                            "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                if ((decimal) comprasUltraGrid.Rows[0].ChildBands["FK_Compras_LibroDiario"].Rows.SummaryValues[
                    "TotalDebe"].Value !=
                    (decimal) comprasUltraGrid.Rows[0].ChildBands["FK_Compras_LibroDiario"].Rows.SummaryValues[
                        "TotalHaber"].Value)
                {
                    MessageBox.Show("El Debe y el Haber no balancean.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool Grabar()
        {
            Validate();
            comprasBindingSource.EndEdit();
            var aux = new Service().UpdateCompra(dsCompra, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine +
                    Environment.NewLine +
                    "Póngase en contacto con el Administrador del Sistema.",
                    "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            dsCompra.Merge(aux);
            ManejoDatos.AplicarUpdate(dsCompra);
            return true;
        }

        private bool VerificarConFactura(UltraGridRow compra)
        {
            if (compra.Cells["Serie"].Value.ToString() != "X") //Sin Factura
            {
                if (compra.Cells["CUIT"].Value == DBNull.Value)
                {
                    MessageBox.Show(this, "Falta el CUIT.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (compra.Cells["Comprobante"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el número de la Factura.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void comprasUltraGrid_CellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "Serie") return;
            if (e.Cell.Text == "" || e.Cell.Text == "Sin Factura")
            {
                e.Cell.Row.Cells["CUIT"].Hidden = true;
                e.Cell.Row.Cells["CUIT"].Column.TabStop = false;
                e.Cell.Row.Cells["CUIT"].Value = DBNull.Value;
                e.Cell.Row.Cells["Comprobante"].Hidden = true;
                e.Cell.Row.Cells["Comprobante"].Column.TabStop = false;
                e.Cell.Row.Cells["Comprobante"].Value = DBNull.Value;
            }
            else if ("AM".Contains(e.Cell.Text))
            {
                e.Cell.Row.Cells["CUIT"].Hidden = false;
                e.Cell.Row.Cells["CUIT"].Column.TabStop = true;
                e.Cell.Row.Cells["Comprobante"].Hidden = false;
                e.Cell.Row.Cells["Comprobante"].Column.TabStop = true;
            }
            else //Factura B o C
            {
                e.Cell.Row.Cells["CUIT"].Hidden = false;
                e.Cell.Row.Cells["CUIT"].Column.TabStop = true;
                e.Cell.Row.Cells["Comprobante"].Hidden = false;
                e.Cell.Row.Cells["Comprobante"].Column.TabStop = true;
            }
        }

        private void comprasUltraGrid_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Band.Key == "Compras" && !e.ReInitialize)
            {
                if (e.Row.Cells["Serie"].Text == "" || e.Row.Cells["Serie"].Text == "Sin Factura")
                {
                    e.Row.Cells["CUIT"].Hidden = true;
                    e.Row.Cells["CUIT"].Column.TabStop = false;
                    e.Row.Cells["CUIT"].Value = DBNull.Value;
                    e.Row.Cells["Comprobante"].Hidden = true;
                    e.Row.Cells["Comprobante"].Column.TabStop = false;
                    e.Row.Cells["Comprobante"].Value = DBNull.Value;
                }
                else if ("AM".Contains(e.Row.Cells["Serie"].Text))
                {
                    e.Row.Cells["CUIT"].Hidden = false;
                    e.Row.Cells["CUIT"].Column.TabStop = true;
                    e.Row.Cells["Comprobante"].Hidden = false;
                    e.Row.Cells["Comprobante"].Column.TabStop = true;
                }
                else //Factura B o C
                {
                    e.Row.Cells["CUIT"].Hidden = false;
                    e.Row.Cells["CUIT"].Column.TabStop = true;
                    e.Row.Cells["Comprobante"].Hidden = false;
                    e.Row.Cells["Comprobante"].Column.TabStop = true;
                }
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            if (!Verificar())
            {
                buttonAceptar.Enabled = true;
                return;
            }
            if (!Grabar())
            {
                buttonAceptar.Enabled = true;
                return;
            }
            var f = new FormOrdenDePago
            {
                IdCompra = ((int) comprasUltraGrid.Rows[0].Cells["idCompra"].Value),
                Tag = "Uno",
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            f.Show();
            Close();
        }

        private void buttonAplicar_Click(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            if (comprasUltraGrid.Rows[0].Cells["FechaDePago"].Value == DBNull.Value)
            {
                MessageBox.Show("Falta la Fecha de Pago", "¡Atención!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonAceptar.Enabled = true;
                return;
            }
            if (!Verificar())
            {
                buttonAceptar.Enabled = true;
                return;
            }
            if (!Grabar())
            {
                buttonAceptar.Enabled = true;
                return;
            }
            Close();
        }

        private void comprasUltraGrid_AfterCellUpdate(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "Importe")
            {
                var renglonesHaber = from renglon in dsCompra.LibroDiarioCompra.AsEnumerable()
                    where renglon.Field<int>("idRubro") == (int) dsProveedor.Proveedores.Rows[0]["idRubro"]
                    select renglon;
                var renglonHaber = renglonesHaber.FirstOrDefault();
                if (renglonHaber != null)
                {
                    if ((decimal) e.Cell.Value != 0)
                    {
                        renglonHaber["Haber"] = (decimal) e.Cell.Value;
                    }
                    else
                    {
                        renglonHaber.Delete();
                    }
                }
                else if ((decimal) e.Cell.Value != 0)
                {
                    var destinoLibroDiario = dsCompra.LibroDiarioCompra.NewRow();
                    destinoLibroDiario["idCompra"] = dsCompra.Compras.Rows[0]["idCompra"];
                    destinoLibroDiario["Fecha"] = _fecha;
                    destinoLibroDiario["idRubro"] = dsProveedor.Proveedores.Rows[0]["idRubro"];
                    destinoLibroDiario["Haber"] = (decimal) e.Cell.Value;
                    dsCompra.LibroDiarioCompra.Rows.Add(destinoLibroDiario);
                }
            }
        }

        private void comprasUltraGrid_SummaryValueChanged(object sender, SummaryValueChangedEventArgs e)
        {
            if (e.SummaryValue.Key == "TotalNeto" && (decimal) e.SummaryValue.Value != 0)
            {
                if (dsProveedor.Proveedores.Rows.Count != 0 &&
                    dsProveedor.Proveedores.Rows[0]["idRubro"] != DBNull.Value)
                {
                    var renglonesIVA = from renglon in dsCompra.LibroDiarioCompra.AsEnumerable()
                        where renglon.Field<int>("idRubro") == (int) dsProveedor.Proveedores.Rows[0]["idRubro"]
                        select renglon;
                    var renglonIVA = renglonesIVA.FirstOrDefault();
                    if (renglonIVA != null)
                    {
                        if ((decimal) e.SummaryValue.Value != 0)
                        {
                            renglonIVA["Debe"] = (decimal) e.SummaryValue.Value;
                        }
                        else
                        {
                            renglonIVA.Delete();
                        }
                    }
                    else if ((decimal) e.SummaryValue.Value != 0)
                    {
                        var destinoLibroDiario = dsCompra.LibroDiarioCompra.NewRow();
                        destinoLibroDiario["idCompra"] = dsCompra.Compras.Rows[0]["idCompra"];
                        destinoLibroDiario["Fecha"] = _fecha;
                        destinoLibroDiario["idRubro"] = dsProveedor.Proveedores.Rows[0]["idRubro"];
                        destinoLibroDiario["Debe"] = (decimal) e.SummaryValue.Value;
                        dsCompra.LibroDiarioCompra.Rows.Add(destinoLibroDiario);
                    }
                }
            }
            if (e.SummaryValue.Key == "TotalIVA" && (decimal) e.SummaryValue.Value != 0)
            {
                var renglonesIVA = from renglon in dsCompra.LibroDiarioCompra.AsEnumerable()
                    where renglon.Field<int>("idRubro") == (int) dsSistemas.Sistemas.Rows[0]["IVACompras"]
                    select renglon;
                var renglonIVA = renglonesIVA.FirstOrDefault();
                if (renglonIVA != null)
                {
                    if ((decimal) e.SummaryValue.Value != 0)
                    {
                        renglonIVA["Debe"] = (decimal) e.SummaryValue.Value;
                    }
                    else
                    {
                        renglonIVA.Delete();
                    }
                }
                else
                {
                    var destinoLibroDiario = dsCompra.LibroDiarioCompra.NewRow();
                    destinoLibroDiario["idCompra"] = dsCompra.Compras.Rows[0]["idCompra"];
                    destinoLibroDiario["Fecha"] = _fecha;
                    destinoLibroDiario["idRubro"] = (int) dsSistemas.Sistemas.Rows[0]["IVACompras"];
                    destinoLibroDiario["Debe"] = (decimal) e.SummaryValue.Value;
                    dsCompra.LibroDiarioCompra.Rows.Add(destinoLibroDiario);
                }
            }
        }

        private void comprasUltraGrid_AfterExitEditMode(object sender, EventArgs e)
        {
            if ((comprasUltraGrid.ActiveCell.Column.Key == "ImporteNeto" &&
                 comprasUltraGrid.ActiveRow.Cells["idPorcentajeIVA"].Value != DBNull.Value) ||
                (comprasUltraGrid.ActiveCell.Column.Key == "idPorcentajeIVA" &&
                 comprasUltraGrid.ActiveRow.Cells["ImporteNeto"].Value != DBNull.Value))
            {
                try
                {
                    comprasUltraGrid.ActiveRow.Cells["ImporteIVA"].Value =
                        decimal.Round((decimal) comprasUltraGrid.ActiveRow.Cells["ImporteNeto"].Value
                                      *
                                      dsPorcentajeIVA.PorcentajeIVA.FindByidPorcentajeIVA(
                                          (int) comprasUltraGrid.ActiveRow.Cells["idPorcentajeIVA"].Value).Porcentaje/
                                      100, 2);
                }
                catch (Exception)
                {
                    comprasUltraGrid.ActiveRow.Cells["ImporteIVA"].Value = 0;
                }
            }
        }

        private void comprasUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                comprasUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void FormCompra_Shown(object sender, EventArgs e)
        {
            if (dsSistemas.Sistemas.Rows[0]["IVACompras"] == DBNull.Value)
            {
                MessageBox.Show(
                    "En la tabla Sistemas falta el dato IVA Compras.",
                    "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        #region BeforeDropDown

        private void ultraDropDownSeries_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownSeries.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void ultraDropDownNegocios_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownNegocios.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void ultraDropDownRubros_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownRubros.DisplayLayout.Bands[0].Columns["NombreCompleto"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void ultraComboProveedor_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraComboProveedor.DisplayLayout.Bands[0].Columns["NombreCompleto"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        #endregion
    }
}
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Administración.Properties.Resources;

namespace Administración
{
    public partial class FormRenglonesFP : Form1
    {
        private FormPrincipal _fp;

        public FormRenglonesFP()
        {
            InitializeComponent();
        }

        private void FormRenglonesFPLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal) MdiParent;
            dsRenglonesDeFactura.Merge(new Service().GetRenglonesFP(Program.Pin));
            dsTandasDeFacturacion.Merge(new Service().GetTandasDeFacturacion(Program.Pin));
            dsContratosLista.Merge(
                new Service().GetContratosRenglonFacturaTodos(Program.Pin));
            dsContratosLista.Merge(new Service().GetContratosListaFP(Program.Pin));
            dsPlanes1.Merge(new Service().GetPlanes(Program.Pin));
            dsClientes.Merge(new Service().GetClientes(Program.Pin));
            dsPorcentajeIVA.Merge(new Service().GetPorcentajeIVA(Program.Pin));
            categoriasIVABindingSource.DataSource = _fp.dsCategoriasIVA;
        }

        private bool Verificado()
        {
            var clientes = clientesUltraGrid.DisplayLayout.Bands["Clientes"]; //Clientes
            foreach (UltraGridRow cliente in clientes.GetRowEnumerator(GridRowType.DataRow)) //Cada cliente
            foreach (var factura in cliente.ChildBands["FK_FacturasProforma_Clientes"].Rows)
            {
                if (factura.Cells["idTandaDeFacturacion"].Text == "")
                {
                    MessageBox.Show(this,
                        cliente.Cells["RazonSocial"].Value + Environment.NewLine +
                        "Falta una Tanda de Facturación", "Imposible Grabar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }

                if (factura.ChildBands["FK_RenglonesFacturaProforma_FacturasProforma"].Rows.Count == 0)
                {
                    MessageBox.Show(this,
                        cliente.Cells["RazonSocial"].Value + Environment.NewLine +
                        "Hay una factura sin renglones.", "Imposible Grabar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }

                //foreach (
                //    var renglonFactura in
                //        factura.ChildBands["FK_RenglonesFacturaProforma_FacturasProforma"].Rows)
                //{
                //foreach (var celda in renglonFactura.Cells)
                //{
                //    if (celda.Hidden || celda.Value != DBNull.Value) continue;
                //    MessageBox.Show(this,
                //                    cliente.Cells["RazonSocial"].Value + Environment.NewLine + Resources.FormClientes_Verificar_El_campo_ +
                //                    celda.Column.Header.Caption + Resources.FormClientes_Verificar__está_vacío_, "Imposible Grabar",
                //                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return false;
                //}
                //}
            }

            return true;
        }

        private void ClientesUltraGridBeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            if (clientesUltraGrid.ActiveRow.Band.Key != "FK_FacturasProforma_Clientes") return;
            if (clientesUltraGrid.ActiveRow.Cells["idTandaDeFacturacion"].Value != DBNull.Value) return;
            MessageBox.Show(
                clientesUltraGrid.ActiveRow.ParentRow.Cells["RazonSocial"].Value + Environment.NewLine +
                "Falta la Tanda de Facturación", "Faltan Datos", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            e.Cancel = true;
        }

        private void ClientesUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Band.Key != "FK_RenglonesFacturaProforma_FacturasProforma") return;
            if (e.Row.Cells["idContrato"].Value == DBNull.Value) return;
            var cantPlanes = (from pl in dsClientes.Planes.AsEnumerable()
                where
                    pl.Field<int?>("idContrato") == (int) e.Row.Cells["idContrato"].Value
                select pl).Count();
            if (cantPlanes == 0)
            {
                e.Row.Cells["idPlan"].Hidden = true;
                e.Row.Cells["idPlan"].Value = DBNull.Value;
                e.Row.Cells["PrecioUnitario"].Hidden = false;
                if (
                    dsContratosLista.Contratos.FindByidContrato(
                        (int) e.Row.Cells["idContrato"].Value).idTipoDeContrato == 2)
                {
                    e.Row.Cells["Cantidad"].Hidden = false;
                }
                else
                {
                    e.Row.Cells["Cantidad"].Hidden = true;
                    e.Row.Cells["Cantidad"].Value = DBNull.Value;
                }
            }
            else
            {
                e.Row.Cells["idPlan"].Hidden = false;
                if (e.Row.Cells["idPlan"].Value != DBNull.Value &&
                    dsClientes.Planes.FindByidPlan((int) e.Row.Cells["idPlan"].Value).PadronExterno)
                {
                    e.Row.Cells["PrecioUnitario"].Hidden = false;
                    e.Row.Cells["Cantidad"].Hidden = false;
                }
                else
                {
                    e.Row.Cells["PrecioUnitario"].Hidden = true;
                    e.Row.Cells["PrecioUnitario"].Value = DBNull.Value;
                    e.Row.Cells["Cantidad"].Hidden = true;
                    e.Row.Cells["Cantidad"].Value = DBNull.Value;
                }
            }
        }

        private void ClientesUltraGridCellChange(object sender, CellEventArgs e)
        {
            var renglonActivo = clientesUltraGrid.ActiveRow;
            var celdaActiva = clientesUltraGrid.ActiveCell;
            if (renglonActivo == null || renglonActivo.Band.Key != "FK_RenglonesFacturaProforma_FacturasProforma")
                return;
            if (celdaActiva == null || celdaActiva.Column.Key != "idContrato") return;
            renglonActivo.Update();
            var condicion = "idContrato = " + celdaActiva.Value;
            var cantPlanes = condicion == "idContrato = "
                ? 0
                : (int) dsClientes.Planes.Compute("Count(idContrato)", condicion);
            if (cantPlanes == 0)
            {
                renglonActivo.Cells["idPlan"].Hidden = true;
                renglonActivo.Cells["idPlan"].Value = DBNull.Value;
                renglonActivo.Cells["PrecioUnitario"].Hidden = false;
                if (
                    dsContratosLista.Contratos.FindByidContrato(
                        (int) renglonActivo.Cells["idContrato"].Value).idTipoDeContrato == 2)
                {
                    renglonActivo.Cells["Cantidad"].Hidden = false;
                }
                else
                {
                    renglonActivo.Cells["Cantidad"].Hidden = true;
                    renglonActivo.Cells["Cantidad"].Value = DBNull.Value;
                }
            }
            else
            {
                renglonActivo.Cells["idPlan"].Hidden = false;
                if (renglonActivo.Cells["idPlan"].Value != DBNull.Value &&
                    dsClientes.Planes.FindByidPlan((int) renglonActivo.Cells["idPlan"].Value).PadronExterno)
                {
                    renglonActivo.Cells["PrecioUnitario"].Hidden = false;
                    renglonActivo.Cells["Cantidad"].Hidden = false;
                }
                else
                {
                    renglonActivo.Cells["PrecioUnitario"].Hidden = true;
                    renglonActivo.Cells["PrecioUnitario"].Value = DBNull.Value;
                    renglonActivo.Cells["Cantidad"].Hidden = true;
                    renglonActivo.Cells["Cantidad"].Value = DBNull.Value;
                }
            }
        }

        private void UltraDropDownPlanesFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            var fc1 = new FilterCondition(e.Row.Band.Columns["idContrato"], FilterComparisionOperator.Equals,
                (int) clientesUltraGrid.ActiveRow.Cells["idContrato"].Value);
            if (e.Row.MeetsCriteria(fc) && e.Row.MeetsCriteria(fc1))
                e.RowFilteredOut = false;
            else
                e.RowFilteredOut = true;
        }

        private void UltraDropDownContratosFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["idCliente"], FilterComparisionOperator.Equals,
                (int) clientesUltraGrid.ActiveRow.ParentRow.ParentRow.Cells["idCliente"].Value);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private bool Updatear()
        {
            var aux = new Service().UpdateRenglonesFP(dsRenglonesDeFactura, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(this, "No se pudo Grabar.", "¡Atención!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            dsRenglonesDeFactura.Merge(aux);
            ManejoDatos.AplicarUpdate(dsRenglonesDeFactura);
            return true;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            if (!Verificado()) return;
            var updateado = Updatear();
            if (updateado) buttonAplicar.Enabled = false;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (buttonAplicar.Enabled)
            {
                if (Verificado())
                {
                    var updateado = Updatear();
                    if (updateado)
                    {
                        buttonAplicar.Enabled = false;
                        Close();
                    }
                }
            }
            else
            {
                Close();
            }
        }

        private void UltraDropDownContratosRowSelected(object sender, RowSelectedEventArgs e)
        {
            clientesUltraGrid.Update();
            ultraDropDownPlanes.DisplayLayout.RefreshFilters();
        }

        private void UltraDropDownContratosInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Cells["Estado"].Text == "Activo") e.Row.Cells["Estado"].Appearance.ForeColor = Color.Green;
            if (e.Row.Cells["Estado"].Text == "Baja") e.Row.Cells["Estado"].Appearance.ForeColor = Color.Red;
            if (e.Row.Cells["Estado"].Text == "Suspendido") e.Row.Cells["Estado"].Appearance.ForeColor = Color.Blue;
        }

        private void ClientesUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void ButtonContraerClick(object sender, EventArgs e)
        {
            clientesUltraGrid.Rows.CollapseAll(true);
        }

        private void ButtonExpanderClick(object sender, EventArgs e)
        {
            clientesUltraGrid.Rows.ExpandAll(true);
        }

        private void clientesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                clientesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
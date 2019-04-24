using System;
using System.Data;
using System.Windows.Forms;
using Administración.Properties;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using ColumnStyle = Infragistics.Win.UltraWinGrid.ColumnStyle;

namespace Administración
{
    public partial class FormCambiarNumeroFacturas : Form1
    {
        public FormCambiarNumeroFacturas()
        {
            InitializeComponent();
        }

        private void ComprobantesUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if ((bool) e.Row.Cells["Vinculados"].Value)
                e.Row.Cells["Anulado"].Activation = Activation.Disabled;
            else
                e.Row.Cells["Anulado"].Activation = Activation.AllowEdit;
            if (Settings.Default.Empresa == "SAE")
            {
                if (e.Row.Cells["CAE"].Value != DBNull.Value || e.Row.Cells["CAE"].Value.ToString().Length != 0)
                {
                    e.Row.Cells["Anulado"].Activation = Activation.Disabled;
                    e.Row.Cells["NumeroDeComprobante"].Activation = Activation.NoEdit;
                    e.Row.Cells["Fecha"].Style = ColumnStyle.Edit;
                    e.Row.Cells["Fecha"].Activation = Activation.NoEdit;
                    e.Row.Cells["Periodo"].Activation = Activation.NoEdit;
                    e.Row.Cells["Prefijo"].Activation = Activation.NoEdit;
                    e.Row.Cells["CUIT"].Activation = Activation.NoEdit;
                    e.Row.Cells["PDF"].Style = ColumnStyle.Button;
                    e.Row.Cells["PDF"].Value = "Generar";
                    e.Row.Cells["PDF"].Activation = Activation.AllowEdit;
                }
                else
                {
                    e.Row.Cells["Anulado"].Activation = Activation.AllowEdit;
                    e.Row.Cells["NumeroDeComprobante"].Activation = Activation.AllowEdit;
                    e.Row.Cells["Fecha"].Style = ColumnStyle.Date;
                    e.Row.Cells["Fecha"].Activation = Activation.AllowEdit;
                    e.Row.Cells["Periodo"].Activation = Activation.AllowEdit;
                    e.Row.Cells["Prefijo"].Activation = Activation.AllowEdit;
                    e.Row.Cells["CUIT"].Activation = Activation.AllowEdit;
                    e.Row.Cells["PDF"].Style = ColumnStyle.Default;
                    e.Row.Cells["PDF"].Value = "";
                    e.Row.Cells["PDF"].Activation = Activation.Disabled;
                }
            }
        }

        private void FormCambiarNumeroFacturasLoad(object sender, EventArgs e)
        {
            dsPuntosDeVenta.Merge(new Service().GetPuntosDeVenta(Program.Pin));
            dsTiposDeComprobante.Merge(new Service().GetTiposDeComprobante(Program.Pin));
        }

        private void UltraButtonBuscarClick(object sender, EventArgs e)
        {
            dsComprobantes.Clear();
            dsComprobantes.Merge(new Service().GetComprobantes((int)ultraComboCantidad.Value,puntosDeVentaUltraCombo.Value.ToString(),ultraMaskedEditDesde.Text,tiposDeComprobanteUltraCombo.Value.ToString(),Program.Pin));
        }
        private bool Grabar()
        {
            Validate();
            comprobantesBindingSource.EndEdit();
            var aux = new Service().UpdateComprobantes(dsComprobantes, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "No se pudo grabar.", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsComprobantes.Clear();
                dsComprobantes.Merge(new Service().GetComprobantes((int)ultraComboCantidad.Value, puntosDeVentaUltraCombo.Value.ToString(), ultraMaskedEditDesde.Text, tiposDeComprobanteUltraCombo.Value.ToString(), Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsComprobantes.Merge(aux);
            ManejoDatos.AplicarUpdate(dsComprobantes);
            return true;
        }
        private void PermitirBuscar()
        {
            ultraButtonBuscar.Enabled = tiposDeComprobanteUltraCombo.Value != null && puntosDeVentaUltraCombo.Value != null &&
                                        ultraComboCantidad.Value != null;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            Grabar();
            buttonAplicar.Enabled = false;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (buttonAplicar.Enabled)
            {
                if (Grabar())
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void ComprobantesUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void TiposDeComprobanteUltraComboValueChanged(object sender, EventArgs e)
        {
            PermitirBuscar();
        }

        private void PuntosDeVentaUltraComboValueChanged(object sender, EventArgs e)
        {
            PermitirBuscar();
        }

        private void UltraComboCantidadValueChanged(object sender, EventArgs e)
        {
            PermitirBuscar();
        }

        private void ultraDropDownPrefijos_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraDropDownPrefijos.DisplayLayout.Bands[0].Columns["Prefijo"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void comprobantesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                comprobantesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void comprobantesUltraGrid_ClickCellButton(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "PDF") return;
            dsFacturasSinCAE.Clear();
            dsFacturasSinCAE.Merge(new Service().GetGenerarPDF((int)e.Cell.Row.Cells["idComprobante"].Value,Program.Pin));
            DataRow renglon = dsFacturasSinCAE.GenerarPDF.Rows[0];
            var nombreArchivo = new Service().GetPDF(
                Settings.Default.Empresa
                , (int)renglon["tipoDoc"]
                , renglon["nroDoc"].ToString()
                , (int)renglon["tipoCbte"]
                , (int)renglon["puntoVta"]
                , (long)renglon["cbtDesde"]
                , renglon["impTotal"].ToString()
                , renglon["impTotConc"].ToString()
                , renglon["impNeto"].ToString()
                , renglon["impIVA"].ToString()
                , renglon["impTrib"].ToString()
                , renglon["impOpEx"].ToString()
                , ManejoDatos.FechaConBarras(renglon["fechaCbte"].ToString())
                , ManejoDatos.FechaConBarras(renglon["fechaVencPago"].ToString())
                , ManejoDatos.FechaConBarras(renglon["fechaServDesde"].ToString())
                , ManejoDatos.FechaConBarras(renglon["fechaServHasta"].ToString())
                , renglon["CAE"].ToString()
                , renglon["VencimientoCAE"].ToString()
                , renglon["CategoriaIVA"].ToString()
                , renglon["NombreCliente"].ToString()
                , renglon["DireccionCliente"].ToString()
                , "" //solicitudCAE.Observaciones
                , renglon["LocalidadCliente"].ToString()
                , renglon["ProvinciaCliente"].ToString()
                , renglon["TipoReferencia"].ToString()
                , renglon["PrefijoReferencia"].ToString()
                , renglon["NumeroReferencia"].ToString()
                , renglon["baseImp4"].ToString()
                , renglon["importeIVA4"].ToString()
                , renglon["baseImp5"].ToString()
                , renglon["importeIVA5"].ToString()
                , (int)renglon["idComprobante"]
                , renglon["TipoComprobante"].ToString()
                , renglon["puntoVta"].ToString().PadLeft(4, '0')
                , renglon["cbtDesde"].ToString()
                , Program.Pin
            );
            MessageBox.Show(nombreArchivo);
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Administración.Properties.Resources;

namespace Administración
{
    public partial class FormImprimirCupones : Form1
    {
        public FormImprimirCupones()
        {
            InitializeComponent();
        }

        private void FormImprimirCuponesLoad(object sender, EventArgs e)
        {
            ultraDateTimeEditorPeriodo.Value = null;
            ultraDateTimeEditorDesdeFecha.Value = null;
            ultraDateTimeEditorHastaFecha.Value = null;
            ds_TiposDeCobranza.Merge(new Service().GetTiposDeCobranza(Program.Pin));
            ds_EntidadesDeCobranza.Merge(new Service().GetEntidadesDeCobranza(Program.Pin));
            ds_PuntosDeVenta.Merge(new Service().GetPuntosDeVenta(Program.Pin));
            ds_EmpleadosLista1.Merge(new Service().GetCobradores(Program.Pin));
            ds_Zonas.Merge(new Service().GetZonas(Program.Pin));
            ultraComboTodosOPendientes.Value = "T";
            ultraComboComprobantes.Value = "C";
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            // Botón Imprimir.
            if (ultraDateTimeEditorPeriodo.Value == null &&
                (ultraDateTimeEditorDesdeFecha.Value == null || ultraDateTimeEditorHastaFecha.Value == null) &&
                Convert.ToInt32(ultraMaskedEditHasta.Value.ToString()) -
                Convert.ToInt32(ultraMaskedEditDesde.Value.ToString()) > 12)
            {
                MessageBox.Show(
                    "Así puede imprimir más cupones de los que desea." +
                    Environment.NewLine +
                    "Por favor especifique el período, las fechas desde y hasta" +
                    Environment.NewLine +
                    "o limite la cantidad con los números de cupón.",
                    "¡Atención!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (ultraComboComprobantes.Value == null)
            {
                MessageBox.Show("El campo Comprobantes es obligatorio.",
                    "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ultraComboPuntosDeVenta.Value == null)
            {
                MessageBox.Show(
                    "El campo Punto de Venta es obligatorio.",
                    "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ultraPopupControlContainer1.Show();
            }
        }

        private void ListBoxImprimirClick(object sender, EventArgs e)
        {
            ultraPopupControlContainer1.Close();
            buttonAceptar.Enabled = false;
            if (listBoxImprimir.SelectedItem.ToString() == "Comprobantes")
            {
                ImprimirComprobantes();
            }
            if (listBoxImprimir.SelectedItem.ToString() == "Comprobantes y Listado")
            {
                ImprimirComprobantes();
                ImprimirListado();
            }
            if (listBoxImprimir.SelectedItem.ToString() == "Listado ordenado como los Comprobantes")
            {
                ImprimirListado();
            }
            if (listBoxImprimir.SelectedItem.ToString() == "Listado Alfabético")
            {
                ImprimirListadoAlfabetico();
            }
        }

        private void ImprimirComprobantes()
        {
            var frmAImprimir = new FormReporteCupones
            {
                MdiParent = MdiParent,
                Periodo =
                    ultraDateTimeEditorPeriodo.Value == null
                        ? ""
                        : ultraDateTimeEditorPeriodo.Text,
                IdTipoDeCobranza =
                    ultraComboTiposDeCobranza.Value == null ? 0 : (int) ultraComboTiposDeCobranza.Value,
                IdEntidadDeCobranza =
                    ultraComboEntidadesDeCobranza.Value == null ? 0 : (int) ultraComboEntidadesDeCobranza.Value,
                IdCobrador = ultraComboCobradores.Value == null ? 0 : (int) ultraComboCobradores.Value,
                Prefijo = ultraComboPuntosDeVenta.Value == null ? "" : ultraComboPuntosDeVenta.Text,
                IdZona = ultraComboZonas.Value == null ? 0 : (int) ultraComboZonas.Value,
                DesdeFecha = ultraDateTimeEditorDesdeFecha.Value == null
                    ? Convert.ToDateTime("21/01/1947")
                    : (DateTime) ultraDateTimeEditorDesdeFecha.Value,
                HastaFecha = ultraDateTimeEditorHastaFecha.Value == null
                    ? Convert.ToDateTime("21/01/1947")
                    : (DateTime) ultraDateTimeEditorHastaFecha.Value,
                Desde = ultraMaskedEditDesde.Text,
                Hasta = ultraMaskedEditHasta.Text,
                TodosOPendientes = ultraComboTodosOPendientes.Value.ToString(),
                Resumen = ultraComboComprobantes.Value.ToString() == "C" ? "Si" : "No",
                Comprobantes = ultraComboComprobantes.Value.ToString(),
                Proceso = "Nulo",
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            frmAImprimir.Show();
        }

        private void ImprimirListadoAlfabetico()
        {
            var frmAImprimir = new FormReporteListadoCuponesAlfabetico
            {
                MdiParent = MdiParent,
                Periodo =
                    (ultraDateTimeEditorPeriodo.Value == null
                        ? ""
                        : ultraDateTimeEditorPeriodo.Value.ToString().Substring(3, 7)),
                IdTipoDeCobranza =
                    ultraComboTiposDeCobranza.Value == null ? 0 : (int) ultraComboTiposDeCobranza.Value,
                IdEntidadDeCobranza =
                    ultraComboEntidadesDeCobranza.Value == null ? 0 : (int) ultraComboEntidadesDeCobranza.Value,
                IdCobrador = ultraComboCobradores.Value == null ? 0 : (int) ultraComboCobradores.Value,
                Prefijo = ultraComboPuntosDeVenta.Value == null ? "" : ultraComboPuntosDeVenta.Text,
                IdZona = ultraComboZonas.Value == null ? 0 : (int) ultraComboZonas.Value,
                DesdeFecha = ultraDateTimeEditorDesdeFecha.Value == null
                    ? Convert.ToDateTime("21/01/1947")
                    : (DateTime) ultraDateTimeEditorDesdeFecha.Value,
                HastaFecha = ultraDateTimeEditorHastaFecha.Value == null
                    ? Convert.ToDateTime("21/01/1947")
                    : (DateTime) ultraDateTimeEditorHastaFecha.Value,
                Desde = ultraMaskedEditDesde.Text,
                Hasta = ultraMaskedEditHasta.Text,
                TodosOPendientes = ultraComboTodosOPendientes.Value.ToString(),
                Comprobantes = ultraComboComprobantes.Value.ToString(),
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            frmAImprimir.Show();
        }

        private void ImprimirListado()
        {
            var frmAImprimir = new FormReporteListadoCupones
            {
                MdiParent = MdiParent,
                Periodo =
                    (ultraDateTimeEditorPeriodo.Value == null
                        ? ""
                        : ultraDateTimeEditorPeriodo.Value.ToString().Substring(3, 7)),
                IdTipoDeCobranza =
                    ultraComboTiposDeCobranza.Value == null ? 0 : (int) ultraComboTiposDeCobranza.Value,
                IdEntidadDeCobranza =
                    ultraComboEntidadesDeCobranza.Value == null ? 0 : (int) ultraComboEntidadesDeCobranza.Value,
                IdCobrador = ultraComboCobradores.Value == null ? 0 : (int) ultraComboCobradores.Value,
                Prefijo = ultraComboPuntosDeVenta.Value == null ? "" : ultraComboPuntosDeVenta.Text,
                IdZona = ultraComboZonas.Value == null ? 0 : (int) ultraComboZonas.Value,
                DesdeFecha = ultraDateTimeEditorDesdeFecha.Value == null
                    ? Convert.ToDateTime("21/01/1947")
                    : (DateTime) ultraDateTimeEditorDesdeFecha.Value,
                HastaFecha = ultraDateTimeEditorHastaFecha.Value == null
                    ? Convert.ToDateTime("21/01/1947")
                    : (DateTime) ultraDateTimeEditorHastaFecha.Value,
                Desde = ultraMaskedEditDesde.Text,
                Hasta = ultraMaskedEditHasta.Text,
                TodosOPendientes = ultraComboTodosOPendientes.Value.ToString(),
                Comprobantes = ultraComboComprobantes.Value.ToString(),
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            frmAImprimir.Show();
        }

        private void FormImprimirCuponesActivated(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void UltraComboTiposDeCobranzaRowSelected(object sender, RowSelectedEventArgs e)
        {
            if (
                ds_TiposDeCobranza.TiposDeCobranza.FindByidTipoDeCobranza((int) ultraComboTiposDeCobranza.Value).
                    RequiereEntidadDeCobranza)
            {
                ultraComboEntidadesDeCobranza.Enabled = true;
                ultraComboCobradores.Enabled = false;
                ultraComboCobradores.Value = null;
                ultraComboZonas.Enabled = false;
                ultraComboZonas.Value = null;
            }
            else
            {
                ultraComboEntidadesDeCobranza.Enabled = false;
                ultraComboEntidadesDeCobranza.Value = DBNull.Value;
                ultraComboCobradores.Enabled = true;
                ultraComboZonas.Enabled = true;
            }
        }

        private void UltraComboZonasFilterRow(object sender, FilterRowEventArgs e)
        {
            if (ultraComboCobradores.Value == null) return;
            var fc = new FilterCondition(e.Row.Band.Columns["idCobrador"], FilterComparisionOperator.Equals,
                (int) ultraComboCobradores.Value);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void ListBoxImprimirMouseMove(object sender, MouseEventArgs e)
        {
            var ih = listBoxImprimir.ItemHeight;
            var t = listBoxImprimir.Top;

            var p = e.Y - t + ih;
            var it = p/ih + listBoxImprimir.TopIndex - 1;

            if (it < listBoxImprimir.Items.Count)
                listBoxImprimir.SelectedIndex = it;
        }

        private void UltraComboCobradoresFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraComboCobradoresRowSelected(object sender, RowSelectedEventArgs e)
        {
            ultraComboZonas.DisplayLayout.RefreshFilters();
        }
    }
}
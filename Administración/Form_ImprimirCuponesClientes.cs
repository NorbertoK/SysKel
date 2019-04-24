using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    public partial class FormImprimirCuponesClientes : Form1
    {
        public FormImprimirCuponesClientes()
        {
            InitializeComponent();
        }

        private void FormImprimirCuponesLoad(object sender, EventArgs e)
        {
            ds_PuntosDeVenta.Merge(new Service().GetPuntosDeVenta(Program.Pin));
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (ultraComboPuntosDeVenta.Value == null)
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
            //buttonAceptar.Enabled = false;
            if (listBoxImprimir.SelectedItem.ToString() == "Comprobantes")
            {
                ImprimirComprobantes();
            }
            if (listBoxImprimir.SelectedItem.ToString() == "Comprobantes y Listado")
            {
                ImprimirComprobantes();
                ImprimirListado();
            }
            if (listBoxImprimir.SelectedItem.ToString() == "Listado")
            {
                ImprimirListado();
            }
        }

        private void ImprimirComprobantes()
        {
            var frmAImprimir = new FormRepComprobantesDeFactura
            {
                MdiParent = MdiParent,
                Prefijo = ultraComboPuntosDeVenta.Value == null ? "" : ultraComboPuntosDeVenta.Text,
                Desde = ultraMaskedEditDesde.Text,
                Hasta = ultraMaskedEditHasta.Text,
                Resumen = ultraComboComprobantes.Value.ToString() == "C" ? "Si" : "No",
                Comprobantes = ultraComboComprobantes.Value.ToString(),
                Proceso = "Nada",
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            frmAImprimir.Show();
        }

        private void ImprimirListado()
        {
            var frmAImprimir = new FormReporteListadoCuponesClientes
            {
                MdiParent = MdiParent,
                Periodo = "",
                IdCobrador = 0,
                Prefijo = ultraComboPuntosDeVenta.Value == null ? "" : ultraComboPuntosDeVenta.Text,
                IdZona = 0,
                Desde = ultraMaskedEditDesde.Text,
                Hasta = ultraMaskedEditHasta.Text,
                TodosOPendientes = "T",
                Comprobantes = ultraComboComprobantes.Value.ToString(),
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            frmAImprimir.Show();
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
    }
}
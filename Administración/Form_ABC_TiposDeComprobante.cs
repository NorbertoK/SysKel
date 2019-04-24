using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using Properties;

    public partial class FormABCTiposDeComprobante : Form1
    {
        public FormABCTiposDeComprobante()
        {
            InitializeComponent();
        }

        private void FormABCTiposDeComprobanteLoad(object sender, EventArgs e)
        {
            ds_TiposDeComprobante.Merge(new Service().GetTiposDeComprobante(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            tiposDeComprobanteBindingSource.EndEdit();
            var aux = new Service().UpdateTiposDeComprobante(ds_TiposDeComprobante, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_TiposDeComprobante.Clear();
                ds_TiposDeComprobante.Merge(new Service().GetTiposDeComprobante(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_TiposDeComprobante.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_TiposDeComprobante);
            return true;
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

        private void TiposDeComprobanteUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void TiposDeComprobanteUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void tiposDeComprobanteUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tiposDeComprobanteUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using Properties;

    public partial class FormABCTandasDeFacturacion : Form1
    {
        public FormABCTandasDeFacturacion()
        {
            InitializeComponent();
        }

        private void FormABCTandasDeFacturacionLoad(object sender, EventArgs e)
        {
            ds_TandasDeFacturacion.Merge(new Service().GetTandasDeFacturacion(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            tandasDeFacturacionBindingSource.EndEdit();
            var aux = new Service().UpdateTandasDeFacturacion(ds_TandasDeFacturacion, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_TandasDeFacturacion.Clear();
                ds_TandasDeFacturacion.Merge(new Service().GetTandasDeFacturacion(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_TandasDeFacturacion.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_TandasDeFacturacion);
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

        private void TandasDeFacturacionUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void TandasDeFacturacionUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void tandasDeFacturacionUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tandasDeFacturacionUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
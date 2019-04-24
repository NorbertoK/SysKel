using System;
using System.Windows.Forms;
using Cabina.WS;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using Properties;

    public partial class FormABCProveedores : Form1
    {
        public FormABCProveedores()
        {
            InitializeComponent();
        }

        private void FormABCProveedoresLoad(object sender, EventArgs e)
        {
            dsProveedores.Merge(new Service().GetProveedores(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            proveedoresBindingSource.EndEdit();
            var aux = new Service().UpdateProveedores(dsProveedores, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsProveedores.Clear();
                dsProveedores.Merge(new Service().GetProveedores(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsProveedores.Merge(aux);
            ManejoDatos.AplicarUpdate(dsProveedores);
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

        private void PrepagosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void PrepagosUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void proveedoresUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                proveedoresUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
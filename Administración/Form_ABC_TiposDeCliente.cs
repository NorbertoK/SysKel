using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using Properties;

    public partial class FormABCTiposDeCliente : Form1
    {
        public FormABCTiposDeCliente()
        {
            InitializeComponent();
        }

        private void FormABCTiposDeClienteLoad(object sender, EventArgs e)
        {
            ds_TiposDeCliente.Merge(new Service().GetTiposDeCliente(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            tiposDeClienteBindingSource.EndEdit();
            var aux = new Service().UpdateTiposDeCliente(ds_TiposDeCliente, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_TiposDeCliente.Clear();
                ds_TiposDeCliente.Merge(new Service().GetTiposDeCliente(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_TiposDeCliente.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_TiposDeCliente);
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

        private void TiposDeClienteUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void TiposDeClienteUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void tiposDeClienteUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tiposDeClienteUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
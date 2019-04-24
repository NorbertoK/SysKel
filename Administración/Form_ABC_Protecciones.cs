using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using Properties;

    public partial class FormABCProtecciones : Form1
    {
        public FormABCProtecciones()
        {
            InitializeComponent();
        }

        private void FormABCProteccionesLoad(object sender, EventArgs e)
        {
            dsProtecciones.Merge(new Service().GetProtecciones(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            proteccionesBindingSource.EndEdit();
            var aux = new Service().UpdateProtecciones(dsProtecciones, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsProtecciones.Clear();
                dsProtecciones.Merge(new Service().GetProveedores(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsProtecciones.Merge(aux);
            ManejoDatos.AplicarUpdate(dsProtecciones);
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

        private void ProteccionesUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void ProteccionesUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void proteccionesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                proteccionesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
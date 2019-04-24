using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using Properties;

    public partial class FormABCOcupaciones : Form1
    {
        public FormABCOcupaciones()
        {
            InitializeComponent();
        }

        private void FormABCOcupacionesLoad(object sender, EventArgs e)
        {
            ds_Ocupaciones.Merge(new Service().GetOcupaciones(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            ocupacionesBindingSource.EndEdit();
            var aux = new Service().UpdateOcupaciones(ds_Ocupaciones, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_Ocupaciones.Clear();
                ds_Ocupaciones.Merge(new Service().GetOcupaciones(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_Ocupaciones.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_Ocupaciones);
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

        private void OcupacionesUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void OcupacionesUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void ocupacionesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ocupacionesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
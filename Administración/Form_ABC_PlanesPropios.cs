using System;
using System.Windows.Forms;
using Administraci�n.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administraci�n
{
    using Properties;

    public partial class FormABCPlanesPropios : Form1
    {
        public FormABCPlanesPropios()
        {
            InitializeComponent();
        }

        private void FormABCPlanesPropiosLoad(object sender, EventArgs e)
        {
            dsPlanesPropios.Merge(new Service().GetPlanesPropios(Program.Pin));
            dsProtecciones.Merge(new Service().GetProtecciones(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            planesBindingSource.EndEdit();
            var aux = new Service().UpdatePlanesPropios(dsPlanesPropios, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operaci�n fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente est� intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la informaci�n", "Operaci�n Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsPlanesPropios.Clear();
                dsPlanesPropios.Merge(new Service().GetPlanesPropios(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsPlanesPropios.Merge(aux);
            ManejoDatos.AplicarUpdate(dsPlanesPropios);
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

        private void PlanesUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void PlanesUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void planesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                planesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
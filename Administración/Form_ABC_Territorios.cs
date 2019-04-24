using System;
using System.Windows.Forms;
using Administraci�n.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administraci�n
{
    using Properties;

    public partial class FormABCTerritorios : Form1
    {
        public FormABCTerritorios()
        {
            InitializeComponent();
        }

        private void FormABCTerritoriosLoad(object sender, EventArgs e)
        {
            dsTerritorios1.Merge(new Service().GetTerritorios(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            var aux = new Service().UpdateTerritorios(dsTerritorios1, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operaci�n fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente est� intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la informaci�n", "Operaci�n Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsTerritorios1.Clear();
                dsTerritorios1.Merge(new Service().GetTerritorios(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsTerritorios1.Merge(aux);
            ManejoDatos.AplicarUpdate(dsTerritorios1);
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

        private void PaisesUltraGridBeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            if (!paisesUltraGrid.Selected.Rows[0].HasChild()) return;
            MessageBox.Show(this, "Tiene hijos.", "�No se puede borrar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }

        private void PaisesUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void PaisesUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void paisesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                paisesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
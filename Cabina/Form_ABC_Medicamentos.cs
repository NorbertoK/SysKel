using System;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using Properties;

    public partial class FormABCMedicamentos : Form1
    {
        public FormABCMedicamentos()
        {
            InitializeComponent();
        }

        private void FormABCMedicamentosLoad(object sender, EventArgs e)
        {
            dsMedicamentos.Merge(new WS.Service().GetMedicamentos(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            medicamentosCategoriasBindingSource.EndEdit();
            var aux = new WS.Service().UpdateMedicamentos(dsMedicamentos, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operaci�n fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente est� intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la informaci�n", "Operaci�n Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsMedicamentos.Clear();
                dsMedicamentos.Merge(new WS.Service().GetMedicamentos(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsMedicamentos.Merge(aux);
            ManejoDatos.AplicarUpdate(dsMedicamentos);
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

        private void MedicamentosCategoriasUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void MedicamentosCategoriasUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void medicamentosCategoriasUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                medicamentosCategoriasUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
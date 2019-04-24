using System;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using Properties;

    public partial class FormABCPracticas : Form1
    {
        public FormABCPracticas()
        {
            InitializeComponent();
        }

        private void FormABCPracticasLoad(object sender, EventArgs e)
        {
            dsPracticas.Merge(new WS.Service().GetPracticas(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            practicasBindingSource.EndEdit();
            var aux = new WS.Service().UpdatePracticas(dsPracticas, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsPracticas.Clear();
                dsPracticas.Merge(new WS.Service().GetPracticas(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsPracticas.Merge(aux);
            ManejoDatos.AplicarUpdate(dsPracticas);
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

        private void PracticasUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void PracticasUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void practicasUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                practicasUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
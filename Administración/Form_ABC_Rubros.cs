using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Administración.Properties.Resources;

namespace Administración
{
    public partial class FormABCRubros : Form1
    {
        public FormABCRubros()
        {
            InitializeComponent();
        }

        private void FormABCRubrosLoad(object sender, EventArgs e)
        {
            dsRubros.Merge(new Service().GetRubros(Program.Pin));
            dsParametros1.Merge(new Service().GetParametros(Program.Pin));
            rubrosUltraGrid.DisplayLayout.Bands[0].Columns["Codigo"].MaskInput =
                (string) dsParametros1.Parametros.Rows[0]["MascaraRubros"];
        }
        private bool Grabar()
        {
            Validate();
            rubrosBindingSource.EndEdit();
            var aux = new Service().UpdateRubros(dsRubros, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsRubros.Clear();
                dsRubros.Merge(new Service().GetRubros(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsRubros.Merge(aux);
            ManejoDatos.AplicarUpdate(dsRubros);
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

        private void RubrosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void RubrosUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void rubrosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                rubrosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}

using System;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using Properties;

    public partial class FormABCRecursos : Form1
    {
        public FormABCRecursos()
        {
            InitializeComponent();
        }

        private void FormABCRecursosLoad(object sender, EventArgs e)
        {
            dsRecursos.Merge(new WS.Service().GetRecursos(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            recursosBindingSource.EndEdit();
            var aux = new WS.Service().UpdateRecursos(dsRecursos, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsRecursos.Clear();
                dsRecursos.Merge(new WS.Service().GetRecursos(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsRecursos.Merge(aux);
            ManejoDatos.AplicarUpdate(dsRecursos);
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

        private void RecursosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void RecursosUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void FormABCRecursosActivated(object sender, EventArgs e)
        {
            dsRecursos.Merge(new WS.Service().GetMovilesLista(Program.Pin));
            dsRecursos.Merge(new WS.Service().GetMedicosLista(Program.Pin));
            dsRecursos.Merge(new WS.Service().GetParamedicosLista(Program.Pin));
            dsRecursos.Merge(new WS.Service().GetChoferesLista(Program.Pin));
        }

        private void recursosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                recursosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
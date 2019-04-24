using System;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using Properties;

    public partial class FormABCFeriados : Cabina.Form1
    {
        public FormABCFeriados()
        {
            InitializeComponent();
        }

        private void FormABCFeriadosLoad(object sender, EventArgs e)
        {
            dsFeriados.Merge(new WS.Service().GetFeriados(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            feriadosBindingSource.EndEdit();
            var aux = new WS.Service().UpdateFeriados(dsFeriados, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsFeriados.Clear();
                dsFeriados.Merge(new WS.Service().GetFeriados(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsFeriados.Merge(aux);
            ManejoDatos.AplicarUpdate(dsFeriados);
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

        private void FeriadosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void FeriadosUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void feriadosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                feriadosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}

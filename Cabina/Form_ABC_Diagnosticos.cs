using System;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using Properties;

    public partial class FormABCDiagnosticos : Form1
    {
        public FormABCDiagnosticos()
        {
            InitializeComponent();
        }

        private void FormABCDiagnosticosLoad(object sender, EventArgs e)
        {
            dsDiagnosticos.Merge(new WS.Service().GetDiagnosticos(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            diagnosticosCategoriaBindingSource.EndEdit();
            var aux = new WS.Service().UpdateDiagnosticos(dsDiagnosticos, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsDiagnosticos.Clear();
                dsDiagnosticos.Merge(new WS.Service().GetDiagnosticos(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsDiagnosticos.Merge(aux);
            ManejoDatos.AplicarUpdate(dsDiagnosticos);
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

        private void DiagnosticosCategoriaUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void DiagnosticosCategoriaUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void diagnosticosCategoriaUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                diagnosticosCategoriaUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
using System;
using System.Windows.Forms;
using Cabina.WS;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using Properties;

    public partial class FormABCMoviles : Form1
    {
        public FormABCMoviles()
        {
            InitializeComponent();
        }

        private void FormABCMovilesLoad(object sender, EventArgs e)
        {
            dsMoviles.Merge(new WS.Service().GetMoviles(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            movilesBindingSource.EndEdit();
            var aux = new WS.Service().UpdateMoviles(dsMoviles, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsMoviles.Clear();
                dsMoviles.Merge(new WS.Service().GetMoviles(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsMoviles.Merge(aux);
            ManejoDatos.AplicarUpdate(dsMoviles);
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

        private void MovilesUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void MovilesUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void FormABCMovilesActivated(object sender, EventArgs e)
        {
            dsPrestadores.Merge(new Service().GetPrestadores(Program.Pin));
            dsTiposDeMovil.Merge(new WS.Service().GetTiposDeMovil(Program.Pin));
        }

        private void movilesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                movilesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
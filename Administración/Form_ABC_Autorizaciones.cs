using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormABCAutorizaciones : Form1
    {
        public FormABCAutorizaciones()
        {
            InitializeComponent();
        }

        private void FormABCAutorizacionesLoad(object sender, EventArgs e)
        {
            dsAutorizaciones.Merge(new Service().GetAutorizaciones(Program.Pin));
            if (Program.Usu == "NKelijman") return;
            buttonAceptar.Visible = false;
            buttonAplicar.Visible = false;
        }

        private bool Grabar()
        {
            Validate();
            autorizacionesBindingSource.EndEdit();
            var aux = new Service().UpdateAutorizaciones(dsAutorizaciones, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsAutorizaciones.Clear();
                dsAutorizaciones.Merge(new Service().GetAutorizaciones(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsAutorizaciones.Merge(aux);
            ManejoDatos.AplicarUpdate(dsAutorizaciones);
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

        private void AutorizacionesUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void AutorizacionesUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void FormABCAutorizacionesActivated(object sender, EventArgs e)
        {
            dsTiposDeAutorizacion.Merge(new Service().GetTiposDeAutorizacion(Program.Pin));
        }

        private void autorizacionesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                autorizacionesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using Properties;

    public partial class FormABCTiposDeAutorizacion : Form1
    {
        public FormABCTiposDeAutorizacion()
        {
            InitializeComponent();
        }

        private void FormABCTiposDeAutorizacionLoad(object sender, EventArgs e)
        {
            ds_TiposDeAutorizacion.Merge(new Service().GetTiposDeAutorizacion(Program.Pin));
            if (Program.Usu == "NKelijman") return;
            buttonAceptar.Visible = false;
            buttonAplicar.Visible = false;
        }

        private bool Grabar()
        {
            Validate();
            tiposDeAutorizacionBindingSource.EndEdit();
            var aux = new Service().UpdateTiposDeAutorizacion(ds_TiposDeAutorizacion, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_TiposDeAutorizacion.Clear();
                ds_TiposDeAutorizacion.Merge(new Service().GetTiposDeAutorizacion(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_TiposDeAutorizacion.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_TiposDeAutorizacion);
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

        private void TiposDeAutorizacionUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void TiposDeAutorizacionUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void tiposDeAutorizacionUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tiposDeAutorizacionUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
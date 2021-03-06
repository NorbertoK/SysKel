using System;
using System.Windows.Forms;
using Cabina.WS;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using Properties;

    public partial class FormABCPrepagos : Form1
    {
        public FormABCPrepagos()
        {
            InitializeComponent();
        }

        private void FormABCPrepagosLoad(object sender, EventArgs e)
        {
            dsPrepagos.Merge(new Service().GetPrepagos(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            prepagosBindingSource.EndEdit();
            var aux = new Service().UpdatePrepagos(dsPrepagos, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsPrepagos.Clear();
                dsPrepagos.Merge(new Service().GetPrepagos(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsPrepagos.Merge(aux);
            ManejoDatos.AplicarUpdate(dsPrepagos);
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

        private void PrepagosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void PrepagosUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void prepagosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                prepagosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
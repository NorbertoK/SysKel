using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using Properties;

    public partial class FormABCMotivosDevolucionCobranza : Form1
    {
        public FormABCMotivosDevolucionCobranza()
        {
            InitializeComponent();
        }

        private void FormABCMotivosDevolucionCobranzaLoad(object sender, EventArgs e)
        {
            ds_MotivosDevolucionCobranza.Merge(new Service().GetMotivosDevolucionCobranza(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            motivosDevolucionCobranzaBindingSource.EndEdit();
            var aux =
                new Service().UpdateMotivosDevolucionCobranza(ds_MotivosDevolucionCobranza, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_MotivosDevolucionCobranza.Clear();
                ds_MotivosDevolucionCobranza.Merge(new Service().GetMotivosDevolucionCobranza(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_MotivosDevolucionCobranza.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_MotivosDevolucionCobranza);
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

        private void MotivosDevolucionCobranzaUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void MotivosDevolucionCobranzaUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void motivosDevolucionCobranzaUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                motivosDevolucionCobranzaUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
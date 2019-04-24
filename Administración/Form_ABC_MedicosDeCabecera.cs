using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using Properties;

    public partial class FormABCMedicosDeCabecera : Form1
    {
        public FormABCMedicosDeCabecera()
        {
            InitializeComponent();
        }

        private void FormABCMedicosDeCabeceraLoad(object sender, EventArgs e)
        {
            ds_MedicosDeCabecera.Merge(new Service().GetMedicosDeCabecera(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            medicosDeCabeceraBindingSource.EndEdit();
            var aux = new Service().UpdateMedicosDeCabecera(ds_MedicosDeCabecera, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_MedicosDeCabecera.Clear();
                ds_MedicosDeCabecera.Merge(new Service().GetMedicosDeCabecera(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_MedicosDeCabecera.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_MedicosDeCabecera);
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

        private void MedicosDeCabeceraUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void MedicosDeCabeceraUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void medicosDeCabeceraUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                medicosDeCabeceraUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
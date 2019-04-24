using System;
using System.Windows.Forms;
using Administraci�n.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administraci�n
{
    using Properties;

    public partial class FormABCMotivosDeBaja : Form1
    {
        public FormABCMotivosDeBaja()
        {
            InitializeComponent();
        }

        private void FormABCMotivosDeBajaLoad(object sender, EventArgs e)
        {
            ds_MotivosDeBaja.Merge(new Service().GetMotivosDeBaja(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            motivosDeBajaBindingSource.EndEdit();
            var aux = new Service().UpdateMotgivosDeBaja(ds_MotivosDeBaja, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operaci�n fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente est� intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la informaci�n", "Operaci�n Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_MotivosDeBaja.Clear();
                ds_MotivosDeBaja.Merge(new Service().GetMotivosDeBaja(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_MotivosDeBaja.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_MotivosDeBaja);
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

        private void MotivosDeBajaUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void MotivosDeBajaUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void motivosDeBajaUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                motivosDeBajaUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
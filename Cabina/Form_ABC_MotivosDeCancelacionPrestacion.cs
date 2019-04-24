using System;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using Properties;

    public partial class FormABCMotivosDeCancelacionPrestacion : Form1
    {
        public FormABCMotivosDeCancelacionPrestacion()
        {
            InitializeComponent();
        }

        private void FormABCMotivosDeCancelacionPrestacionLoad(object sender, EventArgs e)
        {
            dsMotivosDeCancelacionPrestacion.Merge(
                new WS.Service().GetMotivosDeCancelacionPrestacion(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            motivosDeCancelacionPrestacionBindingSource.EndEdit();
            var aux =
                new WS.Service().UpdateMotivosDeCancelacionPrestacion(
                    dsMotivosDeCancelacionPrestacion, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsMotivosDeCancelacionPrestacion.Clear();
                dsMotivosDeCancelacionPrestacion.Merge(
                    new WS.Service().GetMotivosDeCancelacionPrestacion(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsMotivosDeCancelacionPrestacion.Merge(aux);
            ManejoDatos.AplicarUpdate(dsMotivosDeCancelacionPrestacion);
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

        private void MotivosDeCancelacionPrestacionUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void MotivosDeCancelacionPrestacionUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void motivosDeCancelacionPrestacionUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                motivosDeCancelacionPrestacionUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
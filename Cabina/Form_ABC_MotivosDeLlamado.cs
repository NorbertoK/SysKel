using System;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using Properties;

    public partial class FormABCMotivosDeLlamado : Form1
    {
        public FormABCMotivosDeLlamado()
        {
            InitializeComponent();
        }

        private void FormABCMotivosDeLlamadoLoad(object sender, EventArgs e)
        {
            dsMotivosDeLlamado.Merge(new WS.Service().GetMotivosDeLlamado(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            motivosDeLlamadoBindingSource.EndEdit();
            var aux = new WS.Service().UpdateMotivosDeLlamado(dsMotivosDeLlamado,
                                                                              Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsMotivosDeLlamado.Clear();
                dsMotivosDeLlamado.Merge(new WS.Service().GetMotivosDeLlamado(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsMotivosDeLlamado.Merge(aux);
            ManejoDatos.AplicarUpdate(dsMotivosDeLlamado);
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

        private void MotivosDeLlamadoUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            if (motivosDeLlamadoUltraGrid.ActiveCell.Column.Key != "FichaSIEM") return;
            motivosDeLlamadoUltraGrid.ActiveCell.SelStart = 0;
            motivosDeLlamadoUltraGrid.ActiveCell.SelLength = 0;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void MotivosDeLlamadoUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void motivosDeLlamadoUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                motivosDeLlamadoUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
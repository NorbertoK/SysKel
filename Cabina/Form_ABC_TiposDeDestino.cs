using System;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using Properties;

    public partial class FormABCTiposDeDestino : Form1
    {
        public FormABCTiposDeDestino()
        {
            InitializeComponent();
        }

        private void FormABCTiposDeDestinoLoad(object sender, EventArgs e)
        {
            dsTiposDeDestino.Merge(new WS.Service().GetTiposDeDestino(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            tiposDeDestinoBindingSource.EndEdit();
            var aux = new WS.Service().UpdateTiposDeDestino(dsTiposDeDestino,
                                                                            Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operaci�n fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente est� intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la informaci�n", "Operaci�n Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsTiposDeDestino.Clear();
                dsTiposDeDestino.Merge(new WS.Service().GetTiposDeDestino(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsTiposDeDestino.Merge(aux);
            ManejoDatos.AplicarUpdate(dsTiposDeDestino);
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

        private void TiposDeDestinoUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void TiposDeDestinoUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void tiposDeDestinoUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tiposDeDestinoUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
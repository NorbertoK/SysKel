using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using Properties;

    public partial class FormABCTiposDeDocumento : Form1
    {
        public FormABCTiposDeDocumento()
        {
            InitializeComponent();
        }

        private void FormABCTiposDeDocumentoLoad(object sender, EventArgs e)
        {
            ds_TiposDeDocumento.Merge(new Service().GetTiposDeDocumento(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            tiposDeDocumentoBindingSource.EndEdit();
            var aux = new Service().UpdateTiposDeDocumento(ds_TiposDeDocumento, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_TiposDeDocumento.Clear();
                ds_TiposDeDocumento.Merge(new Service().GetTiposDeCobranza(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_TiposDeDocumento.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_TiposDeDocumento);
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

        private void TiposDeDocumentoUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void TiposDeDocumentoUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void tiposDeDocumentoUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tiposDeDocumentoUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
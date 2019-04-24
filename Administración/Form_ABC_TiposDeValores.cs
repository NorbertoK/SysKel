using System;
using System.Linq;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormABCTiposDeValores : Form1
    {
        public FormABCTiposDeValores()
        {
            InitializeComponent();
        }

        private void FormABCTiposDeValoresLoad(object sender, EventArgs e)
        {
            ds_TiposDeValores.Merge(new Service().GetTiposDeValores(Program.Pin));
        }

        private bool Verificar()
        {
            if (!ds_TiposDeValores.TiposDeValores.Select("EsEfectivo = 1").Any())
            {
                MessageBox.Show(
                    "Debe haber un Tipo de Valor que sea Efectivo.",
                    "¡Atención!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (ds_TiposDeValores.TiposDeValores.Select("EsEfectivo = 1").Length > 1)
            {
                MessageBox.Show(
                    "Debe haber sólo un Tipo de Valor que sea Efectivo.",
                    "¡Atención!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool Grabar()
        {
            Validate();
            tiposDeValoresBindingSource.EndEdit();
            var aux = new Service().UpdateTiposDeValores(ds_TiposDeValores, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine +
                    Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información",
                    "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_TiposDeValores.Clear();
                ds_TiposDeValores.Merge(new Service().GetTiposDeValores(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_TiposDeValores.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_TiposDeValores);
            return true;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            if (Verificar())
            {
                Grabar();
                buttonAplicar.Enabled = false;
            }
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (buttonAplicar.Enabled)
            {
                if (Verificar())
                {
                    if (Grabar())
                    {
                        Close();
                    }
                }
            }
            else
            {
                Close();
            }
        }

        private void TiposDeValoresUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void TiposDeValoresUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void tiposDeValoresUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tiposDeValoresUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
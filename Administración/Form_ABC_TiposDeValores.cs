using System;
using System.Linq;
using System.Windows.Forms;
using Administraci�n.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administraci�n
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
                    "�Atenci�n!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (ds_TiposDeValores.TiposDeValores.Select("EsEfectivo = 1").Length > 1)
            {
                MessageBox.Show(
                    "Debe haber s�lo un Tipo de Valor que sea Efectivo.",
                    "�Atenci�n!", MessageBoxButtons.OK,
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
                    "La operaci�n fue rechazada por la Base de Datos." + Environment.NewLine +
                    Environment.NewLine +
                    "Probablemente est� intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la informaci�n",
                    "Operaci�n Rechazada", MessageBoxButtons.OK,
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
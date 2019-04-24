using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using Properties;

    public partial class FormABCPuntosDeVenta : Form1
    {
        public FormABCPuntosDeVenta()
        {
            InitializeComponent();
        }

        private void FormABCPuntosDeVentaLoad(object sender, EventArgs e)
        {
            ds_PuntosDeVenta.Merge(new Service().GetPuntosDeVenta(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            puntosDeVentaBindingSource.EndEdit();
            var aux = new Service().UpdatePuntosDeVenta(ds_PuntosDeVenta, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_PuntosDeVenta.Clear();
                ds_PuntosDeVenta.Merge(new Service().GetPuntosDeVenta(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_PuntosDeVenta.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_PuntosDeVenta);
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

        private void PuntosDeVentaUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void PuntosDeVentaUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void puntosDeVentaUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                puntosDeVentaUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
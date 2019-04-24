using System;
using System.Windows.Forms;
using Administraci�n.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administraci�n
{
    using Properties;

    public partial class FormABCPrestadores : Form1
    {
        public FormABCPrestadores()
        {
            InitializeComponent();
        }

        private void FormABCProyectosLoad(object sender, EventArgs e)
        {
            ds_Prestadores.Merge(new Service().GetPrestadores(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            prestadoresBindingSource.EndEdit();
            var aux = new Service().UpdatePrestadores(ds_Prestadores, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operaci�n fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente est� intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la informaci�n", "Operaci�n Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_Prestadores.Clear();
                ds_Prestadores.Merge(new Service().GetPrestadores(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_Prestadores.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_Prestadores);
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

        private void PrestadoresUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void PrestadoresUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void prestadoresUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                prestadoresUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
using System;
using System.Windows.Forms;
using Administraci�n.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administraci�n
{
    using Properties;

    public partial class FormABCPuestosDelUsuario : Form1
    {
        public FormABCPuestosDelUsuario()
        {
            InitializeComponent();
        }

        private void FormABCPuestosDelUsuarioLoad(object sender, EventArgs e)
        {
            ds_PuestosDelUsuario.Merge(new Service().GetPuestosDelUsuario(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            puestosUsuariosBindingSource.EndEdit();
            var aux = new Service().UpdatePuestosDelUsuario(ds_PuestosDelUsuario, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operaci�n fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente est� intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la informaci�n", "Operaci�n Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_PuestosDelUsuario.Clear();
                ds_PuestosDelUsuario.Merge(new Service().GetPuestosDelUsuario(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_PuestosDelUsuario.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_PuestosDelUsuario);
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

        private void PuestosUsuariosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void PuestosUsuariosUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void FormABCPuestosDelUsuarioActivated(object sender, EventArgs e)
        {
            ds_Usuarios.Merge(new Service().GetUsuarios(Program.Pin));
            ds_Puestos.Merge(new Service().GetPuestos(Program.Pin));
        }

        private void puestosUsuariosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                puestosUsuariosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
using System;
using System.Windows.Forms;
using Administraci�n.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administraci�n
{
    using Properties;

    public partial class FormABCUsuarios : Form1
    {
        public FormABCUsuarios()
        {
            InitializeComponent();
        }
        private FormPrincipal _fp;
        private void FormABCUsuariosLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal)MdiParent;
            empleadosListaBindingSource.DataSource = _fp.dsEmpleadosLista;
            dsUsuarios.Merge(new Service().GetUsuarios(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            usuariosBindingSource.EndEdit();
            var aux = new Service().UpdateUsuarios(dsUsuarios, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operaci�n fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente est� intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la informaci�n", "Operaci�n Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsUsuarios.Clear();
                dsUsuarios.Merge(new Service().GetUsuarios(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsUsuarios.Merge(aux);
            ManejoDatos.AplicarUpdate(dsUsuarios);
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

        private void UsuariosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void UsuariosUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void usuariosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                usuariosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
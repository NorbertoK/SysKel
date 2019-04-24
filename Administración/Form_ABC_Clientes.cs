using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormABCClientes : Form1
    {
        public FormABCClientes()
        {
            InitializeComponent();
        }

        private void FormABCClientesLoad(object sender, EventArgs e)
        {
            dsAutorizacionesDelUsuario.Merge(new Service().GetAutorizacionesDelUsuario(Program.Usu, Program.Pin));
            if (Program.Usu != "Administrador" &&
                dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0003") == null)
            {
                groupBoxClienteNuevo.Visible = false;
            }
            if (Program.Usu != "Administrador" &&
                dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0004") == null)
            {
                buttonAceptar.Visible = false;
            }
            if (Program.Usu != "Administrador" &&
                dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0007") == null)
            {
                buttonCuentaCorriente.Visible = false;
            }
        }

        private void Actualizar(string frase)
        {
            dsBuscarClientes.Clear();
            dsBuscarClientes.EnforceConstraints = false;
            dsBuscarClientes.Merge(new Service().GetBuscarClientes(frase, Program.Pin));
            ultraGrid.Rows[0].Activate();
            ultraGrid.ActiveRow = null;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            // Este es el botón Ver
            buttonAplicar.Enabled = false;
            var frmClientes = new FormClientes
            {
                MdiParent = MdiParent,
                Tag = "V",
                Cliente = ((int) ultraNumericEditor1.Value),
                StartPosition = FormStartPosition.Manual,
                Location = new Point(1, 1)
            };
            frmClientes.Show();
            maskedTextBoxCUIT.Text = "";
            textBoxRazon.Text = "";
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            // Este es el botón Modificar
            buttonAceptar.Enabled = false;
            var frmClientes = new FormClientes
            {
                MdiParent = MdiParent,
                Tag = "M",
                Cliente = ((int) ultraNumericEditor1.Value),
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            frmClientes.Show();
            maskedTextBoxCUIT.Text = "";
            textBoxRazon.Text = "";
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
        }

        private void ButtonRazonClick(object sender, EventArgs e)
        {
            buttonRazon.Enabled = false;
            var frase = "(";
            var seps = new[] {' '};
            foreach (var parte in textBoxRazon.Text.Split(seps))
            {
                frase += "RazonSocial LIKE '%" + parte + "%' or ";
                frase += "NombreFantasia LIKE '%" + parte + "%') and (";
            }
            frase = frase.Remove(frase.Length - 7) + ");";
            Actualizar(frase);
        }

        private void ButtonCUITClick(object sender, EventArgs e)
        {
            buttonCUIT.Enabled = false;
            Actualizar("CUIT LIKE '%" + maskedTextBoxCUIT.Text + "%';");
        }

        private void MaskedTextBoxCUITEnter(object sender, EventArgs e)
        {
            AcceptButton = buttonCUIT;
            textBoxRazon.Text = "";
            buttonRazon.Enabled = false;
        }

        private void MaskedTextBoxCUITLeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void TextBoxRazonEnter(object sender, EventArgs e)
        {
            AcceptButton = buttonRazon;
            maskedTextBoxCUIT.Text = "";
            buttonCUIT.Enabled = false;
        }

        private void TextBoxRazonLeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void ButtonAgregarClick(object sender, EventArgs e)
        {
            var frmClientes = new FormClientes();
            maskedTextBoxCUIT.Text = "";
            textBoxRazon.Text = "";
            buttonCUIT.Enabled = false;
            buttonRazon.Enabled = false;
            frmClientes.Tag = "N";
            frmClientes.MdiParent = MdiParent;
            frmClientes.Show();
            dsBuscarClientes.Clear();
        }

        private void MaskedTextBoxCUITKeyUp(object sender, KeyEventArgs e)
        {
            if (maskedTextBoxCUIT.Text.Length > 2)
            {
                buttonCUIT.Enabled = true;
            }
            else
            {
                buttonCUIT.Enabled = false;
                dsBuscarClientes.Clear();
            }
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
        }

        private void MaskedTextBoxCUITClick(object sender, EventArgs e)
        {
            maskedTextBoxCUIT.Select(0, 0);
        }

        private void UltraGridClick(object sender, EventArgs e)
        {
            if (ultraGrid.Selected.Rows.Count > 0 && ultraGrid.DisplayLayout.Rows[0].Cells[1].Text != "Ningún Resultado" &&
                ultraGrid.ActiveRow.Cells["RazonSocial"].Text != "Varios")
            {
                buttonAplicar.Enabled = true; //Ver
                buttonAceptar.Enabled = true; //Modificar
                buttonCuentaCorriente.Enabled = true;
                buttonFacturas.Enabled = true;
            }
            else 
            {
                buttonAplicar.Enabled = false; //Ver
                buttonAceptar.Enabled = false; //Modificar
                buttonCuentaCorriente.Enabled = false;
                buttonFacturas.Enabled = false;
            }
            if (ultraGrid.Selected.Rows.Count > 0 && ultraGrid.ActiveRow.Cells["RazonSocial"].Text == "Varios")
            {
                buttonCuentaCorriente.Enabled = true;
                buttonFacturas.Enabled = true;
            }
        }

        private void TextBoxRazonKeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxRazon.Text.Length > 2)
            {
                buttonRazon.Enabled = true;
            }
            else
            {
                buttonRazon.Enabled = false;
                dsBuscarClientes.Clear();
            }
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
            buttonCuentaCorriente.Enabled = false;
        }

        private void FormABCClientesEnter(object sender, EventArgs e)
        {
            buttonCUIT.Enabled = false;
            buttonRazon.Enabled = false;
            buttonCuentaCorriente.Enabled = false;
        }

        private void UltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Cells["Estado"].Text == "Activo")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Green;
            }
            if (e.Row.Cells["Estado"].Text == "Baja")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Red;
            }
            if (e.Row.Cells["Estado"].Text == "Suspendido")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Blue;
            }
            if (e.Row.Cells["Estado"].Text == "Alta Futura")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.BlueViolet;
            }
            if (e.Row.Cells["RazonSocial"].Text == "Ningún Resultado")
            {
                e.Row.Cells["RazonSocial"].Appearance.ForeColor = Color.Red;
            }
        }

        private void ButtonCuentaCorrienteClick(object sender, EventArgs e)
        {
            buttonCuentaCorriente.Enabled = false;
            var f = new FormRepCuentaCorriente
            {
                GrupoOCliente = "C",
                Id = ((int) ultraNumericEditor1.Value),
                Nombre = ultraGrid.ActiveRow.Cells["RazonSocial"].Text,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(1, 1)
            };
            f.Show();
        }

        private void buttonFacturas_Click(object sender, EventArgs e)
        {
            buttonFacturas.Enabled = false;
            var f = new FormRepCuentaCorrienteDetallada()
            {
                GrupoOCliente = "C",
                Id = ((int)ultraNumericEditor1.Value),
                Nombre = ultraGrid.ActiveRow.Cells["RazonSocial"].Text,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(1, 1)
            };
            f.Show();
        }

        private void ultraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
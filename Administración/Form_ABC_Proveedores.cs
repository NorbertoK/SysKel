using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormABCProveedores : Form1
    {
        public FormABCProveedores()
        {
            InitializeComponent();
        }

        private void FormABCProveedoresLoad(object sender, EventArgs e)
        {

        }

        private void Actualizar(string frase)
        {
            dsBuscarProveedores.Clear();
            dsBuscarProveedores.EnforceConstraints = false;
            dsBuscarProveedores.Merge(new Service().GetBuscarProveedores(frase, Program.Pin));
            ultraGrid.Rows[0].Activate();
            ultraGrid.ActiveRow = null;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            // Este es el botón Ver
            buttonAplicar.Enabled = false;
            var frmProveedores = new FormProveedores
            {
                MdiParent = MdiParent,
                Tag = "V",
                Proveedor = ((int) ultraNumericEditor1.Value),
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            frmProveedores.Show();
            maskedTextBoxCUIT.Text = "";
            textBoxRazon.Text = "";
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            // Este es el botón Modificar
            buttonAceptar.Enabled = false;
            var frmProveedores = new FormProveedores
            {
                MdiParent = MdiParent,
                Tag = "M",
                Proveedor = ((int) ultraNumericEditor1.Value),
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            frmProveedores.Show();
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
            var frmProveedores = new FormProveedores();
            maskedTextBoxCUIT.Text = "";
            textBoxRazon.Text = "";
            buttonCUIT.Enabled = false;
            buttonRazon.Enabled = false;
            frmProveedores.Tag = "N";
            frmProveedores.MdiParent = MdiParent;
            frmProveedores.Show();
            dsBuscarProveedores.Clear();
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
                dsBuscarProveedores.Clear();
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
            }
            else 
            {
                buttonAplicar.Enabled = false; //Ver
                buttonAceptar.Enabled = false; //Modificar
                buttonCuentaCorriente.Enabled = false;
            }
            if (ultraGrid.Selected.Rows.Count > 0 && ultraGrid.ActiveRow.Cells["RazonSocial"].Text == "Varios")
            {
                buttonCuentaCorriente.Enabled = true;
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
                dsBuscarProveedores.Clear();
            }
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
            buttonCuentaCorriente.Enabled = false;
        }

        private void FormABCProveedoresEnter(object sender, EventArgs e)
        {
            buttonCUIT.Enabled = false;
            buttonRazon.Enabled = false;
            buttonCuentaCorriente.Enabled = false;
        }

        private void UltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Cells["RazonSocial"].Text == "Ningún Resultado")
            {
                e.Row.Cells["RazonSocial"].Appearance.ForeColor = Color.Red;
            }
        }

        private void ButtonCuentaCorrienteClick(object sender, EventArgs e)
        {
            buttonCuentaCorriente.Enabled = false;
            var f = new FormRepCtaCteProveedor
            {
                IdProveedor = ((int) ultraNumericEditor1.Value),
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

        private void ultraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using Properties;

    public partial class FormCobrarEnMostradorCli : Form1
    {
        private string _proceso;
        private FormPrincipal _fp;
        public FormCobrarEnMostradorCli()
        {
            InitializeComponent();
        }

        private void Actualizar(string frase)
        {
            dsBuscarClientes.Clear();
            dsBuscarClientes.EnforceConstraints = false;
            dsBuscarClientes.Merge(new Service().GetBuscarClientes(frase, Program.Pin));
            ultraGrid.Rows[0].Activate();
            ultraGrid.ActiveRow = null;
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
                dsComprobantesImpagosCliente.Clear();
                buttonAceptar.Enabled = false;
                labelMensaje.Visible = false;
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
                dsComprobantesImpagosCliente.Clear();
                buttonAceptar.Enabled = false;
                labelMensaje.Visible = false;
            }
        }

        private void FormCobrarEnMostradorCliEnter(object sender, EventArgs e)
        {
            buttonCUIT.Enabled = false;
            buttonRazon.Enabled = false;
        }

        private void UltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Cells["Estado"].Text == "Activo")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Green;
            }
            if (e.Row.Cells["Estado"].Text == "Alta Reciente")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.DarkMagenta;
            }
            if (e.Row.Cells["Estado"].Text == "Baja")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Red;
            }
            if (e.Row.Cells["Estado"].Text == "Suspendido")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Blue;
            }
            if (e.Row.Cells["RazonSocial"].Text == "Ningún Resultado")
            {
                e.Row.Cells["RazonSocial"].Appearance.ForeColor = Color.Red;
            }
        }

        private void UltraGridAfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            buttonAceptar.Enabled = false;
            labelMensaje.Text = "Un momentito...";
            labelMensaje.Update();
            if (ultraNumericEditorIdCliente.Value == DBNull.Value)
            {
                dsComprobantesImpagosCliente.Clear();
                labelMensaje.Visible = false;
                labelMensaje.Update();
                ultraGridImpagos.Enabled = false;
            }
            else
            {
                dsComprobantesImpagosCliente.Clear();
                dsComprobantesImpagosCliente.Merge(
                    new Service().GetComprobantesImpagosCliente((int) ultraNumericEditorIdCliente.Value, Program.Pin));
                if (ultraGridImpagos.Rows.Count == 0)
                {
                    labelMensaje.Text = "No hay comprobantes con saldo.";
                    labelMensaje.Visible = true;
                    labelMensaje.Update();
                    ultraGridImpagos.Enabled = false;
                }
                else
                {
                    ultraGridImpagos.Enabled = true;
                    ultraGridImpagos.Rows[0].Activate();
                    ultraGridImpagos.ActiveRow = null;
                    labelMensaje.Text = "Marque los comprobantes que cobrará:";
                    labelMensaje.Visible = true;
                    labelMensaje.Update();
                }
            }
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (_fp.dsUsuariosLista.UsuariosLista.FindByidUsuario(Program.IdUsuario).IsidEmpleadoNull())
            {
                MessageBox.Show("Su usuario no tiene asignado un empleado.", "No está autorizado");
                buttonAceptar.Enabled = false;
                return;
            }
            Hide();
            foreach (var row in ultraGridImpagos.Rows)
            {
                if ((bool) row.Cells["Marca"].Value)
                {
                    new Service().InsertarId(_proceso, (int) row.Cells["idComprobante"].Value, 0, Program.Pin);
                }
            }
            var f = new FormRemesaAfiliadoMostrador
                        {
                            Proceso = _proceso,
                            Tag = "Clientes",
                            MdiParent = MdiParent,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(0, 0)
                        };
            f.Show();
            Close();
        }

        private void FormCobrarEnMostradorCliLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal)MdiParent;
            _proceso = new Service().GetProceso(Program.Pin);
        }

        private void UltraGridImpagosCellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "Marca") return;
            ultraGridImpagos.Update();
            if ((bool) ultraGridImpagos.ActiveRow.Cells["Marca"].Value == false)
            {
                ultraGridImpagos.ActiveRow.Cells["Marca"].Value = true;
                buttonAceptar.Enabled = true;
            }
            else
            {
                ultraGridImpagos.ActiveRow.Cells["Marca"].Value = false;
                var marcas = 0;
                foreach (var row in ultraGridImpagos.Rows)
                {
                    if ((bool) row.Cells["Marca"].Value)
                    {
                        marcas++;
                    }
                    buttonAceptar.Enabled = marcas != 0;
                }
            }
        }

        private void ultraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void ultraGridImpagos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraGridImpagos.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
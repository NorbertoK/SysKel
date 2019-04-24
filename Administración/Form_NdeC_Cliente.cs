using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormNdeCCliente : Form1
    {
        public FormNdeCCliente()
        {
            InitializeComponent();
        }

        public string Tipo{ private get; set; }
        private void FormNdeCCliente_Load(object sender, EventArgs e)
        {
            if (Tipo == "NdeD") Text = "Nota de Débito a un Cliente";
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
            }
        }

        private void MaskedTextBoxCUITClick(object sender, EventArgs e)
        {
            maskedTextBoxCUIT.Select(0, 0);
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
            }
        }

        private void FormABCClientesEnter(object sender, EventArgs e)
        {
            buttonCUIT.Enabled = false;
            buttonRazon.Enabled = false;
        }

        private void UltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Cells["Estado"].Text == "Activo") e.Row.Cells["Estado"].Appearance.ForeColor = Color.Green;
            if (e.Row.Cells["Estado"].Text == "Baja") e.Row.Cells["Estado"].Appearance.ForeColor = Color.Red;
            if (e.Row.Cells["Estado"].Text == "Suspendido") e.Row.Cells["Estado"].Appearance.ForeColor = Color.Blue;
            if (e.Row.Cells["RazonSocial"].Text == "Ningún Resultado")
                e.Row.Cells["RazonSocial"].Appearance.ForeColor = Color.Red;
        }

        private void UltraGridImpagosAfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            buttonAceptar.Enabled = true;
            labelMensaje.Visible = false;
            labelMensaje.Update();
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
                    if(Tipo == "NdeC")
                        labelMensaje.Text = "Elija el comprobante al que le hará la Nota de Crédito:";
                    if(Tipo == "NdeD")
                        labelMensaje.Text = "Elija el comprobante al que le hará la Nota de Débito:";
                    labelMensaje.Visible = true;
                    labelMensaje.Update();
                }
            }
        }
        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var f = new FormFacturaManual
            {
                Tipo = Tipo,
                IdReferencia = (int) ultraGridImpagos.ActiveRow.Cells["idComprobante"].Value,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(1, 1)
            };
            f.Show();
            Close();
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
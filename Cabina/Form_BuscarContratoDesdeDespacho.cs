using System;
using System.Drawing;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    public partial class FormBuscarContratoDesdeDespacho : Form1
    {
        public string Boton;

        public FormBuscarContratoDesdeDespacho()
        {
            InitializeComponent();
        }
        public int IdContrato
        {
            get
            {
                try
                {
                    return (int)ultraGrid.ActiveRow.Cells["idContrato"].Value;
                }
                catch
                {
                    return 0;
                }
            }
        }
        private void Actualizar(string frase)
        {
            dsBuscarContrato.Clear();
            dsBuscarContrato.EnforceConstraints = false;
            dsBuscarContrato.Merge(new WS.Service().BuscarContrato(frase, Program.Pin));
            ultraGrid.Rows[0].Activate();
            ultraGrid.ActiveRow = null;
        }


        private void ButtonRazonClick(object sender, EventArgs e)
        {
            buttonRazon.Enabled = false;
            var frase = "(";
            var seps = new[] { ' ' };
            foreach (var parte in textBoxRazon.Text.Split(seps))
            {
                frase += "Contrato LIKE '%" + parte + "%') and (";
            }
            frase = frase.Remove(frase.Length - 7) + ");";
            Actualizar(frase);
        }

        private void TextBoxRazonEnter(object sender, EventArgs e)
        {
            AcceptButton = buttonRazon;
        }

        private void TextBoxRazonLeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void UltraGridClick(object sender, EventArgs e)
        {
            if (ultraGrid.Selected.Rows.Count > 0 &&
                ultraGrid.DisplayLayout.Rows[0].Cells["Contrato"].Text != "Ningún Resultado")
            {
                buttonAceptar.Enabled = true;
            }
            else
            {
                buttonAceptar.Enabled = false;
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
                dsBuscarContrato.Clear();
            }
            buttonAceptar.Enabled = false;
        }

        private void FormABCClientesEnter(object sender, EventArgs e)
        {
            buttonRazon.Enabled = false;
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
            if (e.Row.Cells["Contrato"].Text == "Ningún Resultado")
            {
                e.Row.Cells["Contrato"].Appearance.ForeColor = Color.Red;
            }
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            Boton = "Contrato";
            Hide();
        }

        private void ultraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}

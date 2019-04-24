using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormNdeCGrupo : Form1
    {
        public FormNdeCGrupo()
        {
            InitializeComponent();
        }

        private void Actualizar(string frase)
        {
            dsBuscarAfiliados.Clear();
            dsBuscarAfiliados.EnforceConstraints = false;
            dsBuscarAfiliados.Merge(new Service().GetBuscarAfiliados(frase, Program.Pin));
            ultraGrid.DisplayLayout.Bands[0].SortedColumns.Clear();
            ultraGrid.DisplayLayout.Bands[0].SortedColumns.Add("Nombre", false, false);
            ultraGrid.Rows[0].Activate();
            ultraGrid.ActiveRow = null;
        }

        private void ButtonNombreClick(object sender, EventArgs e)
        {
            buttonNombre.Enabled = false;
            var frase = "(";
            var seps = new[] {' '};
            foreach (var parte in textBoxNombre.Text.Split(seps))
            {
                frase += "Nombre LIKE '%" + parte.Replace("'", "''") + "%' OR ";
                frase += "Apellido LIKE '%" + parte.Replace("'", "''") + "%') AND (";
            }
            frase = frase.Remove(frase.Length - 7) + ");";
            Actualizar(frase);
        }

        private void ButtonDNIClick(object sender, EventArgs e)
        {
            buttonDNI.Enabled = false;
            Actualizar("NumeroDeDocumento LIKE '%" + ultraNumericEditorDNI.Value + "%';");
        }

        private void UltraNumericEditorDNIEnter(object sender, EventArgs e)
        {
            AcceptButton = buttonDNI;
            textBoxNombre.Text = "";
            buttonNombre.Enabled = false;
        }

        private void UltraNumericEditorDNILeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void TextBoxNombreEnter(object sender, EventArgs e)
        {
            AcceptButton = buttonNombre;
            ultraNumericEditorDNI.Value = null;
            buttonDNI.Enabled = false;
        }

        private void TextBoxNombreLeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void UltraNumericEditorDNIKeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (ultraNumericEditorDNI.Value != DBNull.Value && (int) ultraNumericEditorDNI.Value > 99)
                {
                    buttonDNI.Enabled = true;
                }
                else
                {
                    buttonDNI.Enabled = false;
                    dsBuscarAfiliados.Clear();
                    dsComprobantesImpagosCliente.Clear();
                }
            }
            catch (NullReferenceException)
            {
            }
        }

        private void TextBoxNombreKeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxNombre.Text.Length > 2)
            {
                buttonNombre.Enabled = true;
            }
            else
            {
                buttonNombre.Enabled = false;
                dsBuscarAfiliados.Clear();
                dsComprobantesImpagosCliente.Clear();
            }
        }

        private void FormABCGruposEnter(object sender, EventArgs e)
        {
            buttonDNI.Enabled = false;
            buttonNombre.Enabled = false;
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
            if (e.Row.Cells["Nombre"].Text == "Ningún Resultado")
            {
                e.Row.Cells["Nombre"].Appearance.ForeColor = Color.Red;
            }
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
            if (ultraNumericEditorIdGrupo.Value == DBNull.Value)
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
                    new Service().GetComprobantesImpagosGrupo((int) ultraNumericEditorIdGrupo.Value, Program.Pin));
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
                    labelMensaje.Text = "Elija el comprobante al que le hará la Nota de Crédito:";
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
                Tipo = "NdeC",
                IdReferencia = (int) ultraGridImpagos.ActiveRow.Cells["idComprobante"].Value,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(1, 1)
            };
            f.Show();
            Close();
        }

        private void FormNdeCGrupo_Load(object sender, EventArgs e)
        {
            dsPorcentajeIVA.Merge(new Service().GetPorcentajeIVA(Program.Pin));
        }
    }
}
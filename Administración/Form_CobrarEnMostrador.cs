using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using Properties;

    public partial class FormCobrarEnMostrador : Form1
    {
        private FormPrincipal _fp;
        private string _proceso;

        public FormCobrarEnMostrador()
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
                    buttonAceptar.Enabled = false;
                    labelMensaje.Visible = false;
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
                buttonAceptar.Enabled = false;
                labelMensaje.Visible = false;
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
                    labelMensaje.Text = "Marque los comprobantes que cobrará:";
                    labelMensaje.Visible = true;
                    labelMensaje.Update();
                }
            }
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if(_fp.dsUsuariosLista.UsuariosLista.FindByidUsuario(Program.IdUsuario).IsidEmpleadoNull())
            {
                MessageBox.Show("Su usuario no tiene asignado un empleado.","No está autorizado");
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
                            MdiParent = MdiParent,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(0, 0)
                        };
            f.Show();
            Close();
        }

        private void FormCobrarEnMostradorLoad(object sender, EventArgs e)
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
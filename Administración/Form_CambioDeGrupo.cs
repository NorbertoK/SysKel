using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using Properties;

    public partial class FormCambioDeGrupo : Form1
    {
        public FormCambioDeGrupo()
        {
            InitializeComponent();
        }

        private void Actualizar(string frase)
        {
            dsBuscarAfiliados1.Clear();
            dsBuscarAfiliados1.EnforceConstraints = false;
            dsBuscarAfiliados1.Merge(new Service().GetBuscarAfiliados(frase, Program.Pin));
            ultraGrid.DisplayLayout.Bands[0].SortedColumns.Clear();
            ultraGrid.DisplayLayout.Bands[0].SortedColumns.Add("Nombre", false, false);
            ultraGrid.Rows[0].Activate();
            ultraGrid.ActiveRow = null;
        }

        private void ActualizarNuevo(string frase)
        {
            dsBuscarAfiliados2.Clear();
            dsBuscarAfiliados2.EnforceConstraints = false;
            dsBuscarAfiliados2.Merge(new Service().GetBuscarAfiliados(frase, Program.Pin));
            ultraGridDestino.DisplayLayout.Bands[0].SortedColumns.Clear();
            ultraGridDestino.DisplayLayout.Bands[0].SortedColumns.Add("Nombre", false, false);
            ultraGridDestino.Rows[0].Activate();
            ultraGridDestino.ActiveRow = null;
        }

        private void ButtonNombreClick(object sender, EventArgs e)
        {
            var frase = "(";
            var seps = new[] {' '};
            foreach (var parte in textBoxNombre.Text.Split(seps))
            {
                frase += "Nombre LIKE '%" + parte + "%' OR ";
                frase += "Apellido LIKE '%" + parte + "%') AND (";
            }
            frase = frase.Remove(frase.Length - 7) + ");";
            Actualizar(frase);
        }

        private void ButtonNombreNuevoClick(object sender, EventArgs e)
        {
            var frase = "(";
            var seps = new[] {' '};
            foreach (var parte in textBoxNombreNuevo.Text.Split(seps))
            {
                frase += "Nombre LIKE '%" + parte + "%' OR ";
                frase += "Apellido LIKE '%" + parte + "%') AND (";
            }
            frase = frase.Remove(frase.Length - 7) + ");";
            ActualizarNuevo(frase);
        }

        private void ButtonDNIClick(object sender, EventArgs e)
        {
            Actualizar("NumeroDeDocumento LIKE '%" + ultraNumericEditorDNI.Value + "%';");
        }

        private void ButtonDNINuevoClick(object sender, EventArgs e)
        {
            ActualizarNuevo("NumeroDeDocumento LIKE '%" + ultraNumericEditorDNINuevo.Value + "%';");
        }

        private void UltraNumericEditorDNIEnter(object sender, EventArgs e)
        {
            AcceptButton = buttonDNI;
            textBoxNombre.Text = "";
            buttonNombre.Enabled = false;
            labelMensaje.Text = "";
        }

        private void UltraNumericEditorDNINuevoEnter(object sender, EventArgs e)
        {
            AcceptButton = buttonDNINuevo;
            textBoxNombreNuevo.Text = "";
            buttonNombreNuevo.Enabled = false;
        }

        private void UltraNumericEditorDNILeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void UltraNumericEditorDNINuevoLeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void TextBoxNombreEnter(object sender, EventArgs e)
        {
            AcceptButton = buttonNombre;
            ultraNumericEditorDNI.Value = null;
            buttonDNI.Enabled = false;
            labelMensaje.Text = "";
        }

        private void TextBoxNombreNuevoEnter(object sender, EventArgs e)
        {
            AcceptButton = buttonNombreNuevo;
            ultraNumericEditorDNINuevo.Value = null;
            buttonDNINuevo.Enabled = false;
        }

        private void TextBoxNombreLeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void TextBoxNombreNuevoLeave(object sender, EventArgs e)
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
                    dsBuscarAfiliados1.Clear();
                }
                panelDestino.Visible = false;
                buttonAceptar.Enabled = false;
            }
            catch (NullReferenceException)
            {
            }
        }

        private void UltraNumericEditorDNINuevoKeyUp(object sender, KeyEventArgs e)
        {
            if (ultraNumericEditorDNINuevo.Value != DBNull.Value && (int) ultraNumericEditorDNINuevo.Value > 99)
            {
                buttonDNINuevo.Enabled = true;
            }
            else
            {
                buttonDNINuevo.Enabled = false;
                dsBuscarAfiliados2.Clear();
            }
            buttonAceptar.Enabled = false;
        }

        private void UltraGridClick(object sender, EventArgs e)
        {
            if (ultraGrid.Selected.Rows.Count > 0 && ultraGrid.DisplayLayout.Rows[0].Cells[1].Text != "Ningún Resultado")
            {
                panelDestino.Visible = true;
            }
            else
            {
                panelDestino.Visible = false;
            }
            var frase =
                new Service().FraseCambioGrupo(Convert.ToInt32(ultraNumericEditorGrupoAfiliadoOrigen.Value.ToString()),
                                               Convert.ToInt32(ultraNumericEditorAfiliado.Value.ToString()),
                                               Program.Pin);
            if (frase != "OK")
            {
                panelDestino.Visible = false;
                buttonAceptar.Enabled = false;
                labelMensaje.Text = frase;
            }
            else
            {
                labelMensaje.Text = "";
                buttonAceptar.Enabled = false;
                panelDestino.Visible = true;
            }
        }

        private void UltraGridDestinoClick(object sender, EventArgs e)
        {
            if (ultraGridDestino.Selected.Rows.Count > 0 &&
                ultraGrid.DisplayLayout.Rows[0].Cells[1].Text != "Ningún Resultado")
            {
                buttonAceptar.Enabled = true;
            }
            else
            {
                buttonAceptar.Enabled = false;
            }
            if ((int) ultraNumericEditorGrupoAfiliadoOrigen.Value == (int) ultraNumericEditorGrupo.Value)
            {
                labelMensaje.Text = "El grupo original del Afiliado es el mismo que el Grupo de Destino.";
                buttonAceptar.Enabled = false;
            }
            else
            {
                buttonAceptar.Enabled = true;
                labelMensaje.Text = "";
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
                dsBuscarAfiliados1.Clear();
            }
            panelDestino.Visible = false;
        }

        private void TextBoxNombreNuevoKeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxNombreNuevo.Text.Length > 2)
            {
                buttonNombreNuevo.Enabled = true;
            }
            else
            {
                buttonNombreNuevo.Enabled = false;
                dsBuscarAfiliados2.Clear();
            }
            buttonAceptar.Enabled = false;
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

        private void UltraGridDestinoInitializeRow(object sender, InitializeRowEventArgs e)
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

        private void ButtonGrupoNuevoClick(object sender, EventArgs e)
        {
            var idNuevoGrupo =
                new Service().NuevoNumeroDeGrupo(Convert.ToInt32(ultraNumericEditorAfiliado.Value.ToString()),
                                                 Convert.ToInt32(ultraNumericEditorGrupoAfiliadoOrigen.Value.ToString()),
                                                 Program.Pin);
            if (idNuevoGrupo == 0)
            {
                labelMensaje.Text = "Es el único afiliado de su Grupo. No tiene sentido pasarlo a un nuevo Grupo.";
            }
            else
            {
                var frmGrupos = new FormAfiliados {MdiParent = MdiParent, IdGrupo = idNuevoGrupo, Tag = "M"};
                MessageBox.Show(
                    "Se mostrarán los datos del nuevo grupo" + Environment.NewLine +
                    "para hacer los cambios que sea necesario.", "A continuación...", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                frmGrupos.Show();
                Close();
            }
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            new Service().CambioDeGrupo(Convert.ToInt32(ultraNumericEditorAfiliado.Value.ToString()),
                                        Convert.ToInt32(ultraNumericEditorGrupo.Value.ToString()), Program.Pin);
            Close();
        }

        private void FormCambioDeGrupoEnter(object sender, EventArgs e)
        {
            dsBuscarAfiliados1.Clear();
            buttonDNI.Enabled = false;
            buttonNombre.Enabled = false;
            panelDestino.Visible = false;
        }

        private void ultraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void ultraGridDestino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraGridDestino.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
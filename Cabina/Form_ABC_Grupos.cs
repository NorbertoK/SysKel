using System;
using System.Drawing;
using System.Windows.Forms;
using Cabina.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Cabina.Properties.Resources;

namespace Cabina
{
    public partial class FormABCGrupos : Form1
    {
        private FormPrincipalCabina _fp;

        public FormABCGrupos()
        {
            InitializeComponent();
        }

        public string ApelNomb { get; set; }
        public string NumeroDeDocumento { get; set; }
        public string Telefono { get; set; }

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

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
            buttonEsteAfiliado.Enabled = false;
            var frmGrupos = new FormGrupos((int) ultraNumericEditor1.Value)
                                {Tag = "V", ApelNomb = ApelNomb, NumeroDeDocumento = NumeroDeDocumento};
            frmGrupos.Show(Owner);
            //ultraNumericEditorDNI.Value = null;
            //textBoxNombre.Text = "";
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
            buttonEsteAfiliado.Enabled = false;
            var frmGrupos = new FormGrupos((int) ultraNumericEditor1.Value)
                                {Tag = "M", ApelNomb = ApelNomb, NumeroDeDocumento = NumeroDeDocumento};
            dsBuscarAfiliados.Clear();
            frmGrupos.Show(Owner);
            //ultraNumericEditorDNI.Value = null;
            //textBoxNombre.Text = "";
        }

        private void ButtonNombreClick(object sender, EventArgs e)
        {
            //buttonNombre.Enabled = false;
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
            //buttonDNI.Enabled = false;
            Actualizar("NumeroDeDocumento LIKE '%" + ultraNumericEditorDNI.Value + "%';");
        }

        private void UltraNumericEditorDNIEnter(object sender, EventArgs e)
        {
            AcceptButton = buttonDNI;
            //textBoxNombre.Text = "";
            //buttonNombre.Enabled = false;
        }

        private void UltraNumericEditorDNILeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void TextBoxNombreEnter(object sender, EventArgs e)
        {
            AcceptButton = buttonNombre;
            //ultraNumericEditorDNI.Value = null;
            //buttonDNI.Enabled = false;
        }

        private void TextBoxNombreLeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void ButtonAgregarClick(object sender, EventArgs e)
        {
            //ultraNumericEditorDNI.Value = null;
            //buttonDNI.Enabled = false;
            //textBoxNombre.Text = "";
            //buttonNombre.Enabled = false;
            dsBuscarAfiliados.Clear();
            var frmGrupos = new FormGrupos(0)
                                {
                                    Tag = "N", ApelNomb = ApelNomb, NumeroDeDocumento = NumeroDeDocumento, Telefono = Telefono
                                };
            frmGrupos.Show(Owner);
            dsBuscarAfiliados.Clear();
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
                }
                buttonAplicar.Enabled = false; //Ver
                buttonAceptar.Enabled = false; //Modificar
                buttonEsteAfiliado.Enabled = false;
            }
            catch (NullReferenceException)
            {
            }
        }

        private void UltraGridClick(object sender, EventArgs e)
        {
            if (ultraGrid.Selected.Rows.Count > 0 && ultraGrid.DisplayLayout.Rows[0].Cells[1].Text != "Ningún Resultado")
            {
                buttonAplicar.Enabled = true; //Ver
                buttonAceptar.Enabled = true; //Modificar
                buttonEsteAfiliado.Enabled = true;
            }
            else
            {
                buttonAplicar.Enabled = false; //Ver
                buttonAceptar.Enabled = false; //Modificar
                buttonEsteAfiliado.Enabled = false;
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
            }
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
            buttonEsteAfiliado.Enabled = false;
        }

        private void FormABCGruposEnter(object sender, EventArgs e)
        {
            //buttonDNI.Enabled = false;
            //buttonNombre.Enabled = false;
            try
            {
                buttonDNI.Enabled = (int) ultraNumericEditorDNI.Value > 99;
                buttonAplicar.Enabled = false; //Ver
                buttonAceptar.Enabled = false; //Modificar
                buttonEsteAfiliado.Enabled = false;
            }
            catch (NullReferenceException)
            {
                buttonDNI.Enabled = false;
            }
            buttonNombre.Enabled = textBoxNombre.Text.Length > 2;
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

        private void FormABCGruposLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipalCabina) Owner;
            localidadesListaBindingSource.DataSource = _fp.dsLocalidadesLista;
            bindingSourceCalle.DataSource = _fp.dsCallesLista;
            ultraNumericEditorDNI.Value = NumeroDeDocumento;
            var apelNombSinComa = ApelNomb;
            if (ApelNomb.IndexOf(", ", StringComparison.Ordinal) != -1)
            {
                apelNombSinComa = ApelNomb.Replace(", ", " ");
            }
            else
            {
                if (ApelNomb.IndexOf(",", StringComparison.Ordinal) != -1)
                {
                    apelNombSinComa = ApelNomb.Replace(",", " ");
                }
            }
            textBoxNombre.Text = apelNombSinComa;
            ultraNumericEditorDNI.Value = NumeroDeDocumento;
            if (Program.Usu != "Administrador" &&
                _fp.dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0001") == null)
            {
                groupBoxGrupoNuevo.Visible = false;
            }
            if (Program.Usu != "Administrador" &&
                _fp.dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0002") == null)
            {
                buttonAceptar.Visible = false;
            }
            if (Program.Usu != "Administrador" &&
                _fp.dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0009") == null)
            {
                buttonAplicar.Visible = false;
            }
        }

        private void UltraComboCalleFilterRow(object sender, FilterRowEventArgs e)
        {
            try
            {
                var fc = new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals,
                                             _fp.dsLocalidadesLista.LocalidadesLista.FindByidLocalidad(
                                                 (int) ultraComboLocalidad.Value).idLocalidad);
                e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
            }
            catch (InvalidCastException)
            {
                ultraComboCalle.Enabled = false;
                buttonDireccion.Enabled = false;
            }
        }

        private void UltraComboLocalidadRowSelected(object sender, RowSelectedEventArgs e)
        {
            ultraComboCalle.DisplayLayout.RefreshFilters();
            ultraComboCalle.Value = null;
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
            buttonEsteAfiliado.Enabled = false;
            dsBuscarAfiliados.Clear();
        }

        private void TextBoxNumeroEnter(object sender, EventArgs e)
        {
            textBoxNumero.Text = "";
            textBoxNumero.Update();
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
            buttonEsteAfiliado.Enabled = false;
            buttonDireccion.Enabled = true;
            AcceptButton = buttonDireccion;
        }

        private void ButtonDireccionClick(object sender, EventArgs e)
        {
            //buttonDireccion.Enabled = false;
            AcceptButton = null;
            if (string.IsNullOrEmpty(textBoxNumero.Text) ||
                textBoxNumero.Text == "Nº")
            {
                Actualizar(
                    "dbo.DireccionRealDelAfiliado(idAfiliado) in (SELECT idDireccion FROM dbo.Direcciones WHERE left(Indice,12) = left(dbo.IndiceDireccion(" +
                    ultraComboCalle.Value + ",0),12));");
            }
            else
            {
                Actualizar(
                    "dbo.DireccionRealDelAfiliado(idAfiliado) in (SELECT idDireccion FROM dbo.Direcciones WHERE Indice = dbo.IndiceDireccion(" +
                    ultraComboCalle.Value + ",dbo.SoloNumeros('" + textBoxNumero.Text + "')));");
            }
        }

        private void UltraComboCalleRowSelected(object sender, RowSelectedEventArgs e)
        {
            buttonDireccion.Enabled = true;
            AcceptButton = buttonDireccion;
            dsBuscarAfiliados.Clear();
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
            buttonEsteAfiliado.Enabled = false;
        }

        private void TextBoxNumeroLeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void TextBoxNumeroKeyUp(object sender, KeyEventArgs e)
        {
            buttonDireccion.Enabled = true;
            AcceptButton = buttonDireccion;
            dsBuscarAfiliados.Clear();
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
            buttonEsteAfiliado.Enabled = false;
        }

        private void ButtonEsteAfiliadoClick(object sender, EventArgs e)
        {
            Hide();
            DialogResult = DialogResult.OK;
        }

        private void ultraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Administración.Properties.Resources;

namespace Administración
{
    public partial class FormABCGrupos : Form1
    {
        private FormPrincipal _fp;

        public FormABCGrupos()
        {
            InitializeComponent();
        }

        private string _frase;
        private void Actualizar(string frase)
        {
            dsBuscarAfiliados.Clear();
            dsBuscarAfiliados.EnforceConstraints = false;
            dsBuscarAfiliados.Merge(ultraCheckEditorPlanesPropios.CheckState == CheckState.Unchecked
                                        ? new Service().GetBuscarAfiliados(frase, Program.Pin)
                                        : new Service().GetBuscarAfiliadosPropios(frase, Program.Pin));
            ultraGrid.DisplayLayout.Bands[0].SortedColumns.Clear();
            ultraGrid.DisplayLayout.Bands[0].SortedColumns.Add("Nombre", false, false);
            ultraGrid.Rows[0].Activate();
            ultraGrid.ActiveRow = null;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            // Este es el botón Ver
            buttonAplicar.Enabled = false;
            //var frmGrupos = new FormGrupos((int)ultraNumericEditor1.Value) { MdiParent = MdiParent, Tag = "V" };
            var frmGrupos = new FormAfiliados
            {
                IdGrupo = (int)ultraNumericEditor1.Value,
                MdiParent = MdiParent,
                Tag = "V",
                StartPosition = FormStartPosition.Manual,
                Location = new Point(1, 1)
            };
            frmGrupos.Show();
            ultraNumericEditorDNI.Value = null;
            textBoxNombre.Text = "";
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            // Este es el botón Modificar
            buttonAceptar.Enabled = false;
            //var frmGrupos = new FormGrupos((int) ultraNumericEditor1.Value) {MdiParent = MdiParent, Tag = "M"};
            var frmGrupos = new FormAfiliados
            {
                IdGrupo = (int)ultraNumericEditor1.Value,
                MdiParent = MdiParent,
                Tag = "M",
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            frmGrupos.Show();
            ultraNumericEditorDNI.Value = null;
            textBoxNombre.Text = "";
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
        }

        private void ButtonNombreClick(object sender, EventArgs e)
        {
            buttonNombre.Enabled = false;
            _frase = "(";
            var seps = new[] {' '};
            foreach (var parte in textBoxNombre.Text.Split(seps))
            {
                _frase += "Nombre LIKE '%" + parte.Replace("'", "''") + "%' OR ";
                _frase += "Apellido LIKE '%" + parte.Replace("'", "''") + "%') AND (";
            }
            _frase = _frase.Remove(_frase.Length - 7) + ");";
            Actualizar(_frase);
        }

        private void ButtonDNIClick(object sender, EventArgs e)
        {
            _frase = "NumeroDeDocumento LIKE '%" + ultraNumericEditorDNI.Value + "%';";
            buttonDNI.Enabled = false;
            Actualizar(_frase);
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

        private void ButtonAgregarClick(object sender, EventArgs e)
        {
            ultraNumericEditorDNI.Value = null;
            buttonDNI.Enabled = false;
            textBoxNombre.Text = "";
            buttonNombre.Enabled = false;
            //var frmGrupos = new FormGrupos(0) {MdiParent = MdiParent, Tag = "N"};
            var frmGrupos = new FormAfiliados { IdGrupo = 0, MdiParent = MdiParent, Tag = "N" };
            frmGrupos.Show();
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
                buttonExtensionDeCobertura.Enabled = true;
                buttonCuentaCorriente.Enabled = true;
                buttonBajasOCambios.Enabled = true;
            }
            else
            {
                buttonAplicar.Enabled = false; //Ver
                buttonAceptar.Enabled = false; //Modificar
                buttonExtensionDeCobertura.Enabled = false;
                buttonCuentaCorriente.Enabled = false;
                buttonBajasOCambios.Enabled = false;
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
            buttonExtensionDeCobertura.Enabled = false;
            buttonCuentaCorriente.Enabled = false;
            buttonBajasOCambios.Enabled = false;
        }

        private void FormABCGruposEnter(object sender, EventArgs e)
        {
            buttonDNI.Enabled = false;
            buttonNombre.Enabled = false;
            buttonExtensionDeCobertura.Enabled = false;
            buttonCuentaCorriente.Enabled = false;
            buttonBajasOCambios.Enabled = false;
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

        private void ButtonExtensionDeCoberturaClick(object sender, EventArgs e)
        {
            var formext = new FormReporteExtensionDeCobertura
                              {
                                  IdGrupo = ((int) ultraNumericEditor1.Value),
                                  MdiParent = MdiParent
                              };
            formext.Show();
            ultraNumericEditorDNI.Value = null;
            textBoxNombre.Text = "";
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
            buttonExtensionDeCobertura.Enabled = false;
        }

        private void ButtonBajasOCambiosClick(object sender, EventArgs e)
        {
            var f = new FormBajasOCambios {IdGrupo = ((int) ultraNumericEditor1.Value), MdiParent = MdiParent};
            f.Show();
            ultraNumericEditorDNI.Value = null;
            textBoxNombre.Text = "";
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
            buttonBajasOCambios.Enabled = false;
        }

        private void FormABCGruposLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal) MdiParent;
            localidadesListaBindingSource.DataSource = _fp.dsLocalidadesLista;
            bindingSourceCalle.DataSource = _fp.dsCallesLista;
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
                _fp.dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0005") == null)
            {
                buttonExtensionDeCobertura.Visible = false;
            }
            if (Program.Usu != "Administrador" &&
                _fp.dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0006") == null)
            {
                buttonCuentaCorriente.Visible = false;
            }
            if (Program.Usu != "Administrador" &&
                _fp.dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0008") == null)
            {
                buttonBajasOCambios.Visible = false;
            }
            if (Program.Usu != "Administrador" &&
                _fp.dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0009") == null)
            {
                buttonAplicar.Visible = false;
            }
            ActiveControl = textBoxNombre;
        }

        private void ButtonCuentaCorrienteClick(object sender, EventArgs e)
        {
            buttonCuentaCorriente.Enabled = false;
            var f = new FormRepCuentaCorriente
                        {
                            GrupoOCliente = "G",
                            Id = (int) ultraNumericEditor1.Value,
                            Nombre = new Service().NombApelTitular((int) ultraNumericEditor1.Value, Program.Pin),
                            MdiParent = MdiParent,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(0, 0)
                        };
            f.Show();
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
            buttonExtensionDeCobertura.Enabled = false;
            buttonCuentaCorriente.Enabled = false;
            buttonBajasOCambios.Enabled = false;
            dsBuscarAfiliados.Clear();
            ultraComboCalle.Enabled = true;
        }

        private void TextBoxNumeroEnter(object sender, EventArgs e)
        {
            textBoxNumero.Text = "";
            textBoxNumero.Update();
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
            buttonExtensionDeCobertura.Enabled = false;
            buttonCuentaCorriente.Enabled = false;
            buttonBajasOCambios.Enabled = false;
            buttonDireccion.Enabled = true;
            AcceptButton = buttonDireccion;
        }

        private void ButtonDireccionClick(object sender, EventArgs e)
        {
            buttonDireccion.Enabled = false;
            AcceptButton = null;
            if (string.IsNullOrEmpty(textBoxNumero.Text) ||
                textBoxNumero.Text == "Nº")
            {
                _frase =
                    "dbo.DireccionRealDelAfiliado(idAfiliado) in (SELECT idDireccion FROM dbo.Direcciones WHERE left(Indice,12) = left(dbo.IndiceDireccion(" +
                    ultraComboCalle.Value + ",0),12));";
            }
            else
            {
                _frase =
                    "dbo.DireccionRealDelAfiliado(idAfiliado) in (SELECT idDireccion FROM dbo.Direcciones WHERE Indice = dbo.IndiceDireccion(" +
                    ultraComboCalle.Value + ",dbo.SoloNumeros('" + textBoxNumero.Text + "')));";
            }
            Actualizar(_frase);
        }

        private void UltraComboCalleRowSelected(object sender, RowSelectedEventArgs e)
        {
            buttonDireccion.Enabled = true;
            AcceptButton = buttonDireccion;
            dsBuscarAfiliados.Clear();
            buttonAplicar.Enabled = false; //Ver
            buttonAceptar.Enabled = false; //Modificar
            buttonExtensionDeCobertura.Enabled = false;
            buttonCuentaCorriente.Enabled = false;
            buttonBajasOCambios.Enabled = false;
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
            buttonExtensionDeCobertura.Enabled = false;
            buttonCuentaCorriente.Enabled = false;
            buttonBajasOCambios.Enabled = false;
        }

        private void UltraCheckEditorPlanesPropiosCheckedChanged(object sender, EventArgs e)
        {
            if (_frase != null)
            Actualizar(_frase);
        }

        private void ultraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
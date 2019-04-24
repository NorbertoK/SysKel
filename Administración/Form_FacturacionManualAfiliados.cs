using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Administración.Properties.Resources;

namespace Administración
{
    public partial class FormFacturacionManualAfiliados : Form1
    {
        private FormPrincipal _fp;
        private string _primerPeriodo;

        public FormFacturacionManualAfiliados()
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
                    dsEstadoActualDelGrupo.Clear();
                }

                buttonAceptar.Enabled = false;
            }
            catch (NullReferenceException)
            {
            }
        }

        private void UltraGridClick(object sender, EventArgs e)
        {
            if (ultraGrid.Selected.Rows.Count == 0 ||
                ultraGrid.DisplayLayout.Rows[0].Cells[1].Text == "Ningún Resultado") return;
            dsEstadoActualDelGrupo.Clear();
            dsTipoDeCobranzaDelGrupo1.Clear();
            dsTipoDeCobranzaDelGrupo1.Merge(
                new Service().GetTipoDeCobranzaDelGrupo((int) ultraGrid.ActiveRow.Cells["idGrupo"].Value, Program.Pin));
            if (ultraGrid.Selected.Rows.Count > 0 &&
                ultraGrid.DisplayLayout.Rows[0].Cells[1].Text != "Ningún Resultado")
            {
                dsEstadoActualDelGrupo.Merge(
                    new Service().GetEstadoActualDelGrupo((int) ultraGrid.ActiveRow.Cells["idGrupo"].Value,
                        Program.Pin));
                estadoAfiliadosDelGrupoUltraGrid.Rows[0].Activate();
                estadoAfiliadosDelGrupoUltraGrid.ActiveRow = null;
                if (dsTipoDeCobranzaDelGrupo1.TipoDeCobranzaDelGrupo.Rows[0][0] != null
                    //&& (int) dsTipoDeCobranzaDelGrupo1.TipoDeCobranzaDelGrupo.Rows[0][0] == 1
                )
                {
                    _primerPeriodo =
                        new Service().PrimerPeriodoSinFacturarGrupo((int) ultraGrid.ActiveRow.Cells["idGrupo"].Value,
                            Program.Pin);
                    ultraLabelPrimerPeriodo.Text =
                        "período(s) comenzando por " +
                        _primerPeriodo + ".";
                    ultraLabelPrimerPeriodo.Update();
                    panelPeriodos.Visible = true;
                    panelNoCobranzaPropia.Visible = false;
                    buttonAceptar.Enabled = true;
                }

                //if (dsTipoDeCobranzaDelGrupo1.TipoDeCobranzaDelGrupo.Rows[0][0] != null &&
                //    (int) dsTipoDeCobranzaDelGrupo1.TipoDeCobranzaDelGrupo.Rows[0][0] != 1)
                //{
                //    ultraLabelNoCobranzaPropia.Text =
                //        Resources.FormFacturacionManualAfiliados_UltraGridClick_Sólo_se_pueden_hacer_facturas_manuales_a_los_grupos_con_Cobranza_Propia_y_éste_tiene_Cobranza_ +
                //        dsTipoDeCobranzaDelGrupo1.TipoDeCobranzaDelGrupo.Rows[0][1] + ".";
                //    ultraLabelNoCobranzaPropia.Update();
                //    panelNoCobranzaPropia.Visible = true;
                //    panelNoCobranzaPropia.Update();
                //    buttonAceptar.Enabled = false;
                //}
            }
            else
            {
                buttonAceptar.Enabled = false;
                panelPeriodos.Visible = false;
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
                dsEstadoActualDelGrupo.Clear();
            }

            buttonAceptar.Enabled = false;
        }

        private void FormABCGruposEnter(object sender, EventArgs e)
        {
            buttonDNI.Enabled = false;
            buttonNombre.Enabled = false;
            buttonDireccion.Enabled = false;
        }

        private void TextBoxNumeroEnter(object sender, EventArgs e)
        {
            textBoxNumero.Text = "";
            textBoxNumero.Update();
            buttonAceptar.Enabled = false;
            buttonDireccion.Enabled = true;
            AcceptButton = buttonDireccion;
        }

        private void ButtonDireccionClick(object sender, EventArgs e)
        {
            buttonDireccion.Enabled = false;
            AcceptButton = null;
            if (string.IsNullOrEmpty(textBoxNumero.Text) ||
                textBoxNumero.Text == "Nº")
                Actualizar(
                    "dbo.DireccionRealDelAfiliado(idAfiliado) in (SELECT idDireccion FROM dbo.Direcciones WHERE left(Indice,12) = left(dbo.IndiceDireccion(" +
                    ultraComboCalle.Value + ",0),12));");
            else
                Actualizar(
                    "dbo.DireccionRealDelAfiliado(idAfiliado) in (SELECT idDireccion FROM dbo.Direcciones WHERE Indice = dbo.IndiceDireccion(" +
                    ultraComboCalle.Value + ",dbo.SoloNumeros('" + textBoxNumero.Text + "')));");
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
            dsEstadoActualDelGrupo.Clear();
            buttonAceptar.Enabled = false;
        }

        private void UltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Cells["Estado"].Text == "Activo") e.Row.Cells["Estado"].Appearance.ForeColor = Color.Green;
            if (e.Row.Cells["Estado"].Text == "Alta Reciente")
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.DarkMagenta;
            if (e.Row.Cells["Estado"].Text == "Baja") e.Row.Cells["Estado"].Appearance.ForeColor = Color.Red;
            if (e.Row.Cells["Estado"].Text == "Suspendido") e.Row.Cells["Estado"].Appearance.ForeColor = Color.Blue;
            if (e.Row.Cells["Nombre"].Text == "Ningún Resultado")
                e.Row.Cells["Nombre"].Appearance.ForeColor = Color.Red;
        }

        private void UltraComboCalleFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = ultraComboLocalidad.Value == null
                ? new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals, 0)
                : new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals,
                    dsLocalidadesLista.LocalidadesLista.FindByidLocalidad(
                        (int) ultraComboLocalidad.Value).idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraComboCalleRowSelected(object sender, RowSelectedEventArgs e)
        {
            buttonDireccion.Enabled = true;
            AcceptButton = buttonDireccion;
            buttonAceptar.Enabled = false;
        }

        private void UltraComboLocalidadRowSelected(object sender, RowSelectedEventArgs e)
        {
            ultraComboCalle.DisplayLayout.RefreshFilters();
            ultraComboCalle.Value = null;
            buttonAceptar.Enabled = false;
        }

        private void FormFacturacionManualAfiliadosLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal) MdiParent;
            localidadesListaBindingSource.DataSource = _fp.dsLocalidadesLista;
            bindingSourceCalle.DataSource = _fp.dsCallesLista;
        }

        private void EstadoAfiliadosDelGrupoUltraGridAfterRowActivate(object sender, EventArgs e)
        {
            estadoAfiliadosDelGrupoUltraGrid.ActiveRow = null;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            var dr =
                MessageBox.Show(
                    "Si se están haciendo estos comprobantes" +
                    Environment.NewLine +
                    "para entregárselos al cobrador, se generará" +
                    Environment.NewLine +
                    "una Facturación para registrar la recepción" +
                    Environment.NewLine +
                    "por parte del Cobrador." +
                    "Si se están haciendo para cobrarlos ahora," +
                    Environment.NewLine +
                    "por mostrador, quedarán sin Cobrador, como corresponde." +
                    Environment.NewLine +
                    Environment.NewLine + "¿Son para entregar al Cobrador?",
                    "Destino de los Comprobantes",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var ponerCobrador = dr == DialogResult.Yes;
            var n = 1;
            var cant = (int) ultraNumericEditorPeriodos.Value;
            var comprobantes = 0;
            var fechaComprobantes = new Service().HoraActual(Program.Pin);
            var proceso = new Service().GetProceso(Program.Pin);
            while (n <= cant)
            {
                var periodo =
                    new Service().PrimerPeriodoSinFacturarGrupo((int) ultraGrid.ActiveRow.Cells["idGrupo"].Value,
                        Program.Pin);
                comprobantes = comprobantes +
                               new Service().CantidadDeComprobantesManualesRealizados(
                                   (int) ultraGrid.ActiveRow.Cells["idGrupo"].Value, periodo,
                                   fechaComprobantes.ToString("yyyyMMdd"), proceso, ponerCobrador, Program.Pin);
                n = n + 1;
            }

            if (ponerCobrador)
                new Service().FacturacionComprobantesManuales(proceso, "A", Program.Pin);
            switch (comprobantes)
            {
                case 0:
                    ultraLabelResultado.Text = "No se hicieron comprobantes.";
                    break;
                case 1:
                    ultraLabelResultado.Text =
                        "Se hizo 1 comprobante.";
                    break;
                default:
                    ultraLabelResultado.Text =
                        "Se hicieron " + comprobantes +
                        " comprobantes.";
                    break;
            }

            ultraLabelResultado.Visible = true;
            ultraLabelResultado.Update();
            if (comprobantes <= 0 || !ponerCobrador) return;
            var frmAImprimir = new FormReporteCupones
            {
                MdiParent = MdiParent,
                Proceso = proceso,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0),
                Comprobantes = "C"
            };
            frmAImprimir.Show();
        }

        private void ultraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void estadoAfiliadosDelGrupoUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                estadoAfiliadosDelGrupoUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;
using Cabina.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Cabina.Properties.Resources;

namespace Cabina
{
    public partial class FormBuscarAfiliadoDesdeToma : Form
    {
        public string Boton = "";
        private FormPrincipalCabina _fp;

        public FormBuscarAfiliadoDesdeToma()
        {
            InitializeComponent();
        }

        public int IdAfiliado
        {
            get
            {
                if (ultraGrid.ActiveRow.Cells["idAfiliado"].Value == DBNull.Value)
                {
                    return 0;
                }
                return (int) ultraGrid.ActiveRow.Cells["idAfiliado"].Value;
            }
        }

        public int IdDireccion
        {
            get
            {
                if (ultraGrid.ActiveRow.Cells["idDireccion"].Value == DBNull.Value)
                {
                    return 0;
                }
                return (int)ultraGrid.ActiveRow.Cells["idDireccion"].Value;
            }
        }

        public int IdContrato
        {
            get
            {
                if (ultraGrid.ActiveRow.Cells["idContrato"].Value == DBNull.Value)
                {
                    return 0;
                }
                return (int) ultraGrid.ActiveRow.Cells["idContrato"].Value;
            }
        }

        public int IdPlan
        {
            get
            {
                try
                {
                    if (ultraGrid.ActiveRow.Cells["idPlan"].Value == DBNull.Value)
                    {
                        return 0;
                    }
                }
                catch (NullReferenceException)
                {
                    return 0;
                }
                return ultraGrid.ActiveRow.Cells["Estado"].Value.ToString() == "Baja" ||
                       ultraGrid.ActiveRow.Cells["Estado"].Value.ToString() == "Suspendido"
                           ? 0
                           : (int) ultraGrid.ActiveRow.Cells["idPlAN"].Value;
            }
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
                    ds_BuscarAfiliados.Clear();
                }
                buttonSoloAfiliado.Enabled = false;
                buttonSoloDireccion.Enabled = false;
                buttonAfiliadoYDireccion.Enabled = false;
            }
            catch (NullReferenceException)
            {
            }
        }

        private void UltraGridClick(object sender, EventArgs e)
        {
            if (ultraGrid.Selected.Rows.Count > 0 && ultraGrid.DisplayLayout.Rows[0].Cells[1].Text != "Ningún Resultado")
            {
                buttonSoloAfiliado.Enabled = true;
                buttonSoloDireccion.Enabled = true;
                buttonAfiliadoYDireccion.Enabled = true;
            }
            else
            {
                buttonSoloAfiliado.Enabled = false;
                buttonSoloDireccion.Enabled = false;
                buttonAfiliadoYDireccion.Enabled = false;
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
                ds_BuscarAfiliados.Clear();
            }
            buttonSoloAfiliado.Enabled = false;
            buttonSoloDireccion.Enabled = false;
            buttonAfiliadoYDireccion.Enabled = false;
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
        
        private void Actualizar(string frase)
        {
            ds_BuscarAfiliados.Clear();
            ds_BuscarAfiliados.EnforceConstraints = false;
            ds_BuscarAfiliados.Merge(new Service().GetBuscarAfiliados(frase, Program.Pin));
            ultraGrid.DisplayLayout.Bands[0].SortedColumns.Clear();
            ultraGrid.DisplayLayout.Bands[0].SortedColumns.Add("Nombre", false, false);
            ultraGrid.Rows[0].Activate();
            ultraGrid.ActiveRow = null;
        }

        private void ButtonDireccionClick(object sender, EventArgs e)
        {
            buttonDireccion.Enabled = false;
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

        private void FormBuscarAfiliadoDesdeTomaLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipalCabina) Owner;
            localidadesListaBindingSource.DataSource = _fp.dsLocalidadesLista;
            bindingSourceCalle.DataSource = _fp.dsCallesLista;
            ActiveControl = textBoxNombre;
            buttonSoloAfiliado.Enabled = false;
            buttonSoloDireccion.Enabled = false;
            buttonAfiliadoYDireccion.Enabled = false;
        }

        private void UltraComboCalleFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = ultraComboLocalidad.Value == null
                         ? new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals, 0)
                         : new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals,
                                               _fp.dsLocalidadesLista.LocalidadesLista.FindByidLocalidad(
                                                   (int) ultraComboLocalidad.Value).idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraComboLocalidadRowSelected(object sender, RowSelectedEventArgs e)
        {
            ultraComboCalle.DisplayLayout.RefreshFilters();
            ultraComboCalle.Value = null;
            buttonSoloAfiliado.Enabled = false;
            buttonSoloDireccion.Enabled = false;
            buttonAfiliadoYDireccion.Enabled = false;
            ds_BuscarAfiliados.Clear();
        }

        private void TextBoxNumeroEnter(object sender, EventArgs e)
        {
            textBoxNumero.Text = "";
            textBoxNumero.Update();
            buttonSoloAfiliado.Enabled = false;
            buttonSoloDireccion.Enabled = false;
            buttonAfiliadoYDireccion.Enabled = false;
            buttonDireccion.Enabled = true;
            AcceptButton = buttonDireccion;
        }

        private void UltraComboCalleRowSelected(object sender, RowSelectedEventArgs e)
        {
            buttonDireccion.Enabled = true;
            AcceptButton = buttonDireccion;
            ds_BuscarAfiliados.Clear();
            buttonSoloAfiliado.Enabled = false;
            buttonSoloDireccion.Enabled = false;
            buttonAfiliadoYDireccion.Enabled = false;
        }

        private void TextBoxNumeroLeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void TextBoxNumeroKeyUp(object sender, KeyEventArgs e)
        {
            buttonDireccion.Enabled = true;
            AcceptButton = buttonDireccion;
            ds_BuscarAfiliados.Clear();
            buttonSoloAfiliado.Enabled = false;
            buttonSoloDireccion.Enabled = false;
            buttonAfiliadoYDireccion.Enabled = false;
        }

        private void ButtonNingunClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSoloAfiliadoClick(object sender, EventArgs e)
        {
            Hide();
            Boton = "Datos del Afiliado";
        }

        private void ButtonSoloDireccionClick(object sender, EventArgs e)
        {
            Hide();
            Boton = "Datos de la Dirección";
        }

        private void ButtonAfiliadoYDireccionClick(object sender, EventArgs e)
        {
            Hide();
            Boton = "Datos del Afiliado y la Dirección";
        }

        private void ultraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
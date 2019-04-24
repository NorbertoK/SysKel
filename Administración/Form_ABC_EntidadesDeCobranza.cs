using System;
using System.Globalization;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormABCEntidadesDeCobranza : Form1
    {
        public FormABCEntidadesDeCobranza()
        {
            InitializeComponent();
        }

        private void FormABCEntidadesDeCobranzaLoad(object sender, EventArgs e)
        {
            ds_EntidadesDeCobranza.Merge(new Service().GetEntidadesDeCobranza(Program.Pin));
            dsEmpleadosLista.Merge(new Service().GetCajasBancos(Program.Pin));
        }

        private bool Verificar()
        {
            foreach (UltraGridRow renglon in entidadesDeCobranzaUltraGrid.DisplayLayout.Bands[0].GetRowEnumerator(GridRowType.DataRow))
                if (renglon.Cells["idBanco"].Value == DBNull.Value)
                {
                    MessageBox.Show("El Banco no puede estar en blanco.", "¡Atención!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            return true;
        }

        private bool Grabar()
        {
            Validate();
            entidadesDeCobranzaBindingSource.EndEdit();
            var aux = new Service().UpdateEntidadesDeCobranza(ds_EntidadesDeCobranza, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_EntidadesDeCobranza.Clear();
                ds_EntidadesDeCobranza.Merge(new Service().GetEntidadesDeCobranza(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_EntidadesDeCobranza.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_EntidadesDeCobranza);
            return true;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            if (!Verificar()) return;
            Grabar();
            buttonAplicar.Enabled = false;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (!Verificar()) return;
            if (buttonAplicar.Enabled)
            {
                if (Grabar())
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void EntidadesDeCobranzaUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void EntidadesDeCobranzaUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void EntidadesDeCobranzaUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            e.Row.Cells["MascaraTarjeta"].ToolTipText = @"Usar ""#"" y espacios.";
        }

        private void EntidadesDeCobranzaUltraGridKeyPress(object sender, KeyPressEventArgs e)
        {
            if (entidadesDeCobranzaUltraGrid.ActiveCell.Column.Key != "MascaraTarjeta") return;
            if ("# ".Contains(e.KeyChar.ToString(CultureInfo.InvariantCulture)) == false)
            {
                e.Handled = true;
            }
        }

        private void entidadesDeCobranzaUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                entidadesDeCobranzaUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
using System;
using System.ComponentModel;
using System.Transactions;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using ColumnStyle=Infragistics.Win.UltraWinGrid.ColumnStyle;

namespace Administración
{
    using System.Linq;
    using Properties;

    public partial class FormRemesaIngresoValores : Form1
    {
        private FormPrincipal _fp;
        public FormRemesaIngresoValores()
        {
            InitializeComponent();
        }

        private void FormRemesaAfiliadoMostradorLoad(object sender, EventArgs e)
        {
            /*Llena los combos*/
            _fp = (FormPrincipal)MdiParent;
            usuariosListaBindingSource.DataSource = _fp.dsUsuariosLista;
            empleadosListaBindingSource.DataSource = _fp.dsEmpleadosLista;
            dsTiposDeValores.Merge(new Service().GetTiposDeValores(Program.Pin));
            dsBancos.Merge(new Service().GetBancos(Program.Pin));
            remesasUltraGrid.DisplayLayout.Bands[0].AddNew();
            remesasUltraGrid.Rows[0].Update();
            remesasUltraGrid.Rows.ExpandAll(true);
            remesasUltraGrid.ActiveRow = null;
        }

        private void RemesasUltraGridAfterCellUpdate(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "idTipoDeValor") return;
            if (dsTiposDeValores.TiposDeValores.FindByidTipoDeValor((int) e.Cell.Value).RequiereBanco == false)
            {
                e.Cell.Row.Cells["idBanco"].Hidden = true;
                e.Cell.Row.Cells["NumeroDeCheque"].Hidden = true;
                e.Cell.Row.Cells["Vencimiento"].Hidden = true;
                e.Cell.Row.Cells["idBanco"].Value = DBNull.Value;
                e.Cell.Row.Cells["NumeroDeCheque"].Value = DBNull.Value;
                e.Cell.Row.Cells["Vencimiento"].Value = DBNull.Value;
            }
            else
            {
                e.Cell.Row.Cells["idBanco"].Hidden = false;
                e.Cell.Row.Cells["NumeroDeCheque"].Hidden = false;
                e.Cell.Row.Cells["Vencimiento"].Hidden = false;
            }
        }

        private void RemesasUltraGridSummaryValueChanged(object sender, SummaryValueChangedEventArgs e)
        {
            if (e.SummaryValue.Key == "SumValores")
            {
                dsRemesas.Remesas[0].Importe = (decimal) e.SummaryValue.Value;
            }
            buttonAceptar.Enabled = (decimal)e.SummaryValue.Value > 0;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if(remesasUltraGrid.Rows[0].Cells["Detalle"].Value==DBNull.Value)
            {
                MessageBox.Show("El Detalle es obligatorio", "¡Atención!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            using (var ts = new TransactionScope())
            {
                try
                {
                    buttonAceptar.Visible = false;
                    buttonCancelar.Visible = false;
                    ultraLabelMensaje.Visible = true;
                    Validate();
                    remesasBindingSource.EndEdit();
                    /*Updatea*/
                    var aux = new Service().UpdateRemesa(dsRemesas, Program.Pin);
                    if (aux == null)
                    {
                        MessageBox.Show(
                            "La operación fue rechazada por la Base de Datos." + Environment.NewLine +
                            Environment.NewLine + "Póngase en contacto con el Administrador del Sistema.",
                            "Operación Rechazada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dsRemesas.Merge(aux);
                        ManejoDatos.AplicarUpdate(dsRemesas);
                    }
                }
                catch
                {
                    MessageBox.Show("No se pudo realizar la operación.", "¡Atención!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    buttonAceptar.Visible = true;
                    buttonCancelar.Visible = true;
                    ts.Dispose();
                }
                ts.Complete();
            }
            /*Muestra el reporte*/
            var repo = new FormReporteRemesa
                           {
                               IdRemesa = ((int) remesasUltraGrid.DisplayLayout.Rows[0].Cells[0].Value),
                               StartPosition = FormStartPosition.CenterScreen
                           };
            repo.ShowDialog();
            Close();
        }

        private void RemesasUltraGridBeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            if (remesasUltraGrid.ActiveRow.Band.Key == "FK_ComprobantesRemesas_Remesas" &&
                remesasUltraGrid.ActiveRow.Cells[3].Text != remesasUltraGrid.ActiveRow.Cells[4].Text)
            {
                if (remesasUltraGrid.ActiveRow.Cells["Observaciones"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Escriba observaciones.", "Cobró menos", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            if (remesasUltraGrid.ActiveRow.Band.Key != "FK_Remesas_ValoresRemesas" ||
                !dsTiposDeValores.TiposDeValores.FindByidTipoDeValor(
                     (int) remesasUltraGrid.ActiveRow.Cells["idTipoDeValor"].Value).RequiereBanco) return;
            if (remesasUltraGrid.ActiveRow.Cells["idBanco"].Value == DBNull.Value)
            {
                e.Cancel = true;
                MessageBox.Show("Falta el Banco", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (remesasUltraGrid.ActiveRow.Cells["NumeroDeCheque"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show(this, "Falta el Número de Cheque", "¡Atención!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    if (remesasUltraGrid.ActiveRow.Cells["Vencimiento"].Value == DBNull.Value)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Falta el vencimiento", "¡Atención!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RemesasUltraGridAfterRowExpanded(object sender, RowEventArgs e)
        {
            foreach (var celda in e.Row.Cells.Cast<UltraGridCell>().Where(celda => celda.Column.Key != "Detalle"))
            {
                celda.Column.Style = ColumnStyle.Edit;
                celda.Column.CellActivation = Activation.NoEdit;
            }
        }

        private void RemesasUltraGridBeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            e.DisplayPromptMsg = false;
        }

        private void RemesasUltraGridInitializeTemplateAddRow(object sender, InitializeTemplateAddRowEventArgs e)
        {
            if (e.TemplateAddRow.Band.Key == "Remesas")
            {
                _fp = (FormPrincipal)MdiParent;
                e.TemplateAddRow.Cells["Fecha"].Value = new Service().HoraActual(Program.Pin);
                e.TemplateAddRow.Cells["idGrabador"].Value = Program.IdUsuario;
                e.TemplateAddRow.Cells["idReceptor"].Value =
                    _fp.dsUsuariosLista.UsuariosLista.FindByidUsuario(Program.IdUsuario).idEmpleado;
            }
            if (e.TemplateAddRow.Band.Key == "FK_Remesas_ValoresRemesas")
            {
                e.TemplateAddRow.Cells["idEmpleado"].Value = (int) remesasUltraGrid.Rows[0].Cells["idReceptor"].Value;
            }
        }

        private void UltraDropDownReceptorFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownReceptorBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownReceptor.DisplayLayout.RefreshFilters();
        }

        private void RemesasUltraGridBeforeRowExpanded(object sender, CancelableRowEventArgs e)
        {
            if (e.Row.Band.Key != "Remesas") return;
            if (e.Row.Cells["idReceptor"].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void ButtonCancelar1Click(object sender, EventArgs e)
        {
            Close();
        }

        private void remesasUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                remesasUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
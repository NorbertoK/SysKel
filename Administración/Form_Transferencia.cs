namespace Administración
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using WS;
    using Infragistics.Win;
    using Infragistics.Win.UltraWinGrid;
    using Resources = Properties.Resources;

    public partial class FormTransferencia : Form1
    {
        private FormPrincipal _fp;

        public FormTransferencia()
        {
            InitializeComponent();
        }

        private void FormTransferenciaLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal) MdiParent;
            dsBancos.Merge(new Service().GetBancos(Program.Pin));
            dsEmpleadosLista.Merge(new Service().GetEmpleadosLista(Program.Pin));
            dsTiposDeValores.Merge(new Service().GetTiposDeValores(Program.Pin));
            dsUsuariosLista1.Merge(new Service().GetUsuariosLista(Program.Pin));
            usuariosListaBindingSource.DataSource = _fp.dsUsuariosLista;
            transferenciasUltraGrid.DisplayLayout.Bands[0].Columns["Fecha"].DefaultCellValue =
                new Service().HoraActual(Program.Pin);
            transferenciasUltraGrid.DisplayLayout.Bands[0].Columns["idGrabador"].DefaultCellValue = Program.IdUsuario;
            if (_fp.dsUsuariosLista.UsuariosLista.FindByidUsuario(Program.IdUsuario).IsidEmpleadoNull())
            {
                MessageBox.Show("Su usuario no tiene asignado un empleado.", "No está autorizado");
                buttonAceptar.Enabled = false;
                return;
            }
            transferenciasUltraGrid.DisplayLayout.Bands[0].Columns["A"].DefaultCellValue =
                _fp.dsUsuariosLista.UsuariosLista.FindByidUsuario(Program.IdUsuario).idEmpleado;
        }

        private void ValoresTransferenciasUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if ((int) e.Row.Cells["idValorRemesa"].Value == 0)
            {
                e.Row.Cells["Transferido"].Hidden = true;
                e.Row.Cells["ImporteTransferido"].Activation = Activation.AllowEdit;
                e.Row.Cells["ImporteTransferido"].Column.CellClickAction = CellClickAction.EditAndSelectText;
                if (e.Row.Cells["Importe"].Value != DBNull.Value)
                {
                    e.Row.Cells["ImporteTransferido"].Column.MaxValue = (decimal) e.Row.Cells["Importe"].Value;
                }
            }
            else
            {
                e.Row.Cells["ImporteTransferido"].Activation = Activation.NoEdit;
            }
        }

        private void ValoresTransferenciasUltraGridCellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "Transferido") return;
            if ((decimal) e.Cell.Row.Cells["ImporteTransferido"].Value == 0)
            {
                e.Cell.Row.Cells["ImporteTransferido"].Value = (decimal) e.Cell.Row.Cells["Importe"].Value;
            }
            else
            {
                e.Cell.Row.Cells["ImporteTransferido"].Value = 0;
            }
        }

        private void TransferenciasUltraGridCellListSelect(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "De")
            {
                transferenciasUltraGrid.ActiveRow.Update();
                valoresTransferenciasUltraGrid.DisplayLayout.Bands[0].Override.AllowAddNew = AllowAddNew.Yes;
                valoresTransferenciasUltraGrid.DisplayLayout.Bands[0].Override.AllowDelete = DefaultableBoolean.True;
                dsEnCaja1.Clear();
                if (ultraDropDownDe.SelectedRow.Cells["idEmpleado"].Value != DBNull.Value)
                {
                    dsEnCaja1.Merge(
                        new Service().GetValoresEmpleado((int) ultraDropDownDe.SelectedRow.Cells["idEmpleado"].Value,
                                                         Program.Pin));
                }
                dsTransferencias.ValoresTransferencias.Clear();
                foreach (DataRow origen in dsEnCaja1.EnCaja.Rows)
                {
                    var destino = dsTransferencias.ValoresTransferencias.NewRow();
                    destino["Importe"] = origen["Importe"];
                    destino["NumeroDeCheque"] = origen["NumeroDeCheque"];
                    destino["Vencimiento"] = origen["Vencimiento"];
                    destino["Observaciones"] = origen["Observaciones"];
                    destino["Transferido"] = origen["Transferido"];
                    destino["ImporteTransferido"] = origen["ImporteTransferido"];
                    destino["idTipoDeValor"] = origen["idTipoDeValor"];
                    destino["idBanco"] = origen["idBanco"];
                    destino["idValorRemesa"] = origen["idValorRemesa"];
                    dsTransferencias.ValoresTransferencias.Rows.Add(destino);
                }
                valoresTransferenciasUltraGrid.Update();
                valoresTransferenciasUltraGrid.DisplayLayout.Bands[0].Override.AllowAddNew = AllowAddNew.No;
                valoresTransferenciasUltraGrid.DisplayLayout.Bands[0].Override.AllowDelete = DefaultableBoolean.False;
                if (e.Cell.Row.Cells["A"].Value != DBNull.Value)
                {
                    valoresTransferenciasUltraGrid.Visible = true;
                }
            }
            if (e.Cell.Column.Key != "A") return;
            if (e.Cell.Row.Cells["De"].Value != DBNull.Value)
            {
                valoresTransferenciasUltraGrid.Visible = true;
            }
        }

        //private void ValoresTransferenciasUltraGridSummaryValueChanged(object sender, SummaryValueChangedEventArgs e)
        //{
        //    if (dsTransferencias.Transferencias.Rows.Count <= 0) return;
        //    dsTransferencias.Transferencias.Rows[0]["Importe"] =
        //        (decimal) valoresTransferenciasUltraGrid.Rows.SummaryValues["Suma"].Value;
        //    transferenciasUltraGrid.Rows[0].Refresh();
        //}

        private bool Verificado()
        {
            if (transferenciasUltraGrid.Rows[0].Cells["A"].Value == DBNull.Value)
            {
                MessageBox.Show("Falta indicar a quién se le transfieren los valores.", "Falta dato",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (transferenciasUltraGrid.Rows[0].Cells["De"].Value == DBNull.Value)
            {
                MessageBox.Show("Falta indicar quién transfiere los valores.", "Falta dato",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((int)transferenciasUltraGrid.Rows[0].Cells["De"].Value == (int)transferenciasUltraGrid.Rows[0].Cells["A"].Value)
            {
                MessageBox.Show("El origen y el destino de la transferencia no pueden ser iguales.", "Falta dato",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool Grabado()
        {
            Validate();
            valoresTransferenciasBindingSource.EndEdit();
            valoresTransferenciasUltraGrid.Update();
            var aux2 = new Service().UpdateValoresTransferencia(dsTransferencias, Program.Pin);
            if (aux2 == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsTransferencias.Merge(aux2);
            Validate();
            transferenciasBindingSource.EndEdit();
            var aux = new Service().UpdateTransferencia(dsTransferencias, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsTransferencias.Merge(aux);
            ManejoDatos.AplicarUpdate(dsTransferencias);
            var idTransferencia = (int) dsTransferencias.Transferencias.Rows[0]["idTransferencia"];
            foreach (DataRow row in dsTransferencias.ValoresTransferencias.Rows)
            {
                row["idTransferencia"] = idTransferencia;
            }
            //valoresTransferenciasUltraGrid.Update();
            Validate();
            valoresTransferenciasBindingSource.EndEdit();
            var aux1 = new Service().UpdateValoresTransferencia(dsTransferencias, Program.Pin);
            if (aux1 == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsTransferencias.Merge(aux1);
            ManejoDatos.AplicarUpdate(dsTransferencias);
            new Service().ProcesarTransferencia(idTransferencia, Program.Pin);
            return true;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            if (Verificado())
            {
                if (Grabado())
                {
                    //new WS.Service().UpdateTransferencia(dsTransferencias, Program.Pin);
                    var f = new FormRepTransferencia
                                {
                                    IdTransferencia =
                                        ((int) transferenciasUltraGrid.Rows[0].Cells["idTransferencia"].Value),
                                    MdiParent = MdiParent,
                                    StartPosition = FormStartPosition.Manual,
                                    Location = new Point(0, 0)
                                };
                    f.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la transferencia.", "¡Atención!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    buttonAceptar.Enabled = true;
                    buttonCancelar.Enabled = true;
                }
            }
            else
            {
                buttonAceptar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
        }

        private void UltraDropDownDeFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownReceptorFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void ultraDropDownTiposDeValores_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraDropDownTiposDeValores.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
               PerformAutoSizeType.AllRowsInBand);
        }

        private void ultraDropDownBancos_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraDropDownBancos.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
               PerformAutoSizeType.AllRowsInBand);
        }

        private void ultraDropDownDe_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraDropDownDe.DisplayLayout.Bands[0].Columns["ApelNomb"].PerformAutoResize(
               PerformAutoSizeType.AllRowsInBand);
        }

        private void ultraDropDownReceptor_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraDropDownReceptor.DisplayLayout.Bands[0].Columns["ApelNomb"].PerformAutoResize(
               PerformAutoSizeType.AllRowsInBand);
        }

        private void valoresTransferenciasUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                valoresTransferenciasUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void valoresTransferenciasUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}
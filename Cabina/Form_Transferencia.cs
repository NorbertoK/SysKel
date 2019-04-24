using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Cabina.WS;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using Properties;

    public partial class FormTransferencia : Form1
    {
        public FormTransferencia()
        {
            InitializeComponent();
        }

        private void FormTransferenciaLoad(object sender, EventArgs e)
        {
            dsBancos.Merge(new Service().GetBancos(Program.Pin));
            dsEmpleadosLista.Merge(new Service().GetEmpleadosLista(Program.Pin));
            dsTiposDeValores.Merge(new Service().GetTiposDeValores(Program.Pin));
            dsUsuariosLista1.Merge(new Service().GetUsuariosLista(Program.Pin));
        }

        private void TransferenciasUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            e.Row.Cells["Fecha"].Value = new WS.Service().HoraActual(Program.Pin);
            e.Row.Cells["idGrabador"].Value = Program.IdUsuario;
            e.Row.Cells["Importe"].Value = 0;
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

                dsEnCaja1.Merge(
                    new Service().GetValoresEmpleado((int) ultraDropDownDe.SelectedRow.Cells["idEmpleado"].Value,
                                                     Program.Pin));

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

        private void ValoresTransferenciasUltraGridSummaryValueChanged(object sender, SummaryValueChangedEventArgs e)
        {
            if (dsTransferencias.Transferencias.Rows.Count <= 0) return;
            dsTransferencias.Transferencias.Rows[0]["Importe"] =
                (decimal) valoresTransferenciasUltraGrid.Rows.SummaryValues["Suma"].Value;
            transferenciasUltraGrid.Rows[0].Refresh();
        }

        private bool Verificado()
        {
            if (transferenciasUltraGrid.Rows[0].Cells["A"].Value == DBNull.Value)
            {
                MessageBox.Show("Falta indicar a qui�n se le transfieren los valores.", "Falta dato",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((decimal) transferenciasUltraGrid.Rows[0].Cells["Importe"].Value == 0)
            {
                MessageBox.Show("No est� transfiriendo ning�n valor.", "Faltan datos", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
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
                    "La operaci�n fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente est� intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la informaci�n", "Operaci�n Rechazada", MessageBoxButtons.OK,
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
                    "La operaci�n fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente est� intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la informaci�n", "Operaci�n Rechazada", MessageBoxButtons.OK,
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
                    "La operaci�n fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente est� intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la informaci�n", "Operaci�n Rechazada", MessageBoxButtons.OK,
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
                    MessageBox.Show("No se pudo realizar la transferencia.", "�Atenci�n!", MessageBoxButtons.OK,
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

        private void UltraDropDownReceptorFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Cargo"], FilterComparisionOperator.NotEquals,
                                         "Administrativo");
            var fc1 = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            if (e.Row.MeetsCriteria(fc) && e.Row.MeetsCriteria(fc1))
                e.RowFilteredOut = false;
            else
                e.RowFilteredOut = true;
        }

        private void transferenciasUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                transferenciasUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
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
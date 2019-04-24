using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Dirección.WS;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;

namespace Dirección
{
    using Properties;

    public partial class FormRetiro : Form1
    {
        private FormPrincipal _fp;
        public FormRetiro()
        {
            InitializeComponent();
        }

        private void FormTransferenciaLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal)MdiParent;
            usuariosListaBindingSource.DataSource = _fp.dsUsuariosLista;
            dsBancos.Merge(new Service().GetBancos(Program.Pin));
            dsEmpleadosLista.Merge(new Service().GetEmpleadosLista(Program.Pin));
            dsTiposDeValores.Merge(new Service().GetTiposDeValores(Program.Pin));
            retiroUltraGrid.DisplayLayout.Bands[0].Columns["Fecha"].DefaultCellValue =
                new Service().HoraActual(Program.Pin);
            retiroUltraGrid.DisplayLayout.Bands[0].Columns["idGrabador"].DefaultCellValue = Program.IdUsuario;
            retiroUltraGrid.DisplayLayout.Bands[0].Columns["Importe"].DefaultCellValue = 0;
        }

        private void ValoresRetiroUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
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

        private void ValoresRetiroUltraGridCellChange(object sender, CellEventArgs e)
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
            if (e.Cell.Column.Key != "De") return;
            retiroUltraGrid.ActiveRow.Update();
            valoresRetiroUltraGrid.DisplayLayout.Bands[0].Override.AllowAddNew = AllowAddNew.Yes;
            valoresRetiroUltraGrid.DisplayLayout.Bands[0].Override.AllowDelete = DefaultableBoolean.True;
            dsEnCaja1.Clear();
            if (ultraDropDownDe.SelectedRow.Cells["idEmpleado"].Value != DBNull.Value)
            {
                dsEnCaja1.Merge(
                    new Service().GetValoresEmpleado((int) ultraDropDownDe.SelectedRow.Cells["idEmpleado"].Value,
                                                     Program.Pin));
            }
            dsRetiros.ValoresRetiros.Clear();
            foreach (DataRow origen in dsEnCaja1.EnCaja.Rows)
            {
                var destino = dsRetiros.ValoresRetiros.NewRow();
                destino["Importe"] = origen["Importe"];
                destino["NumeroDeCheque"] = origen["NumeroDeCheque"];
                destino["Vencimiento"] = origen["Vencimiento"];
                destino["NumeroPropio"] = origen["NumeroPropio"];
                destino["Observaciones"] = origen["Observaciones"];
                destino["Transferido"] = origen["Transferido"];
                destino["ImporteTransferido"] = origen["ImporteTransferido"];
                destino["idTipoDeValor"] = origen["idTipoDeValor"];
                destino["idBanco"] = origen["idBanco"];
                destino["idValorRemesa"] = origen["idValorRemesa"];
                dsRetiros.ValoresRetiros.Rows.Add(destino);
            }
            valoresRetiroUltraGrid.Update();
            valoresRetiroUltraGrid.DisplayLayout.Bands[0].Override.AllowAddNew = AllowAddNew.No;
            valoresRetiroUltraGrid.DisplayLayout.Bands[0].Override.AllowDelete = DefaultableBoolean.False;
            valoresRetiroUltraGrid.Visible = true;
        }

        private void ValoresRetiroUltraGridSummaryValueChanged(object sender, SummaryValueChangedEventArgs e)
        {
            if (dsRetiros.Retiros.Rows.Count <= 0) return;
            dsRetiros.Retiros.Rows[0]["Importe"] =
                (decimal) valoresRetiroUltraGrid.Rows.SummaryValues["Suma"].Value;
            retiroUltraGrid.Rows[0].Refresh();
        }

        private bool Verificado()
        {
            if ((decimal) retiroUltraGrid.Rows[0].Cells["Importe"].Value == 0)
            {
                MessageBox.Show(Resources.FormTransferencia_Verificado_No_está_transfiriendo_ningún_valor_, Resources.FormTransferencia_Verificado_Faltan_datos, MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool Grabado()
        {
            Validate();
            valoresRetiroBindingSource.EndEdit();
            valoresRetiroUltraGrid.Update();
            var aux2 = new Service().UpdateValoresRetiro(dsRetiros, Program.Pin);
            if (aux2 == null)
            {
                MessageBox.Show(
                    Resources.Grabar_La_operación_fue_rechazada_por_la_Base_de_Datos_ + Environment.NewLine + Environment.NewLine +
                    Resources.Grabar_Probablemente_esté_intentando_eliminar_un_dato + Environment.NewLine +
                    Resources.Grabar_necesario_para_la_integridad_de_la_información, Resources.Grabar_Operación_Rechazada, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsRetiros.Merge(aux2);
            Validate();
            retirosBindingSource.EndEdit();
            var aux = new Service().UpdateRetiro(dsRetiros, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    Resources.Grabar_La_operación_fue_rechazada_por_la_Base_de_Datos_ + Environment.NewLine + Environment.NewLine +
                    Resources.Grabar_Probablemente_esté_intentando_eliminar_un_dato + Environment.NewLine +
                    Resources.Grabar_necesario_para_la_integridad_de_la_información, Resources.Grabar_Operación_Rechazada, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsRetiros.Merge(aux);
            ManejoDatos.AplicarUpdate(dsRetiros);
            var idRetiro = (int) dsRetiros.Retiros.Rows[0]["idRetiro"];
            foreach (DataRow row in dsRetiros.ValoresRetiros.Rows)
            {
                row["idRetiro"] = idRetiro;
            }
            //valoresTransferenciasUltraGrid.Update();
            Validate();
            valoresRetiroBindingSource.EndEdit();
            var aux1 = new Service().UpdateValoresRetiro(dsRetiros, Program.Pin);
            if (aux1 == null)
            {
                MessageBox.Show(
                    Resources.Grabar_La_operación_fue_rechazada_por_la_Base_de_Datos_ + Environment.NewLine + Environment.NewLine +
                    Resources.Grabar_Probablemente_esté_intentando_eliminar_un_dato + Environment.NewLine +
                    Resources.Grabar_necesario_para_la_integridad_de_la_información, Resources.Grabar_Operación_Rechazada, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsRetiros.Merge(aux1);
            ManejoDatos.AplicarUpdate(dsRetiros);
            new Service().ProcesarRetiro(idRetiro, Program.Pin);
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
                    var f = new FormRepRetiro
                                {
                                    IdRetiro = ((int) retiroUltraGrid.Rows[0].Cells["idRetiro"].Value),
                                    MdiParent = MdiParent,
                                    StartPosition = FormStartPosition.Manual,
                                    Location = new Point(0, 0)
                                };
                    f.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show(Resources.FormTransferencia_ButtonAceptarClick_No_se_pudo_realizar_la_transferencia_, Resources.Atención, MessageBoxButtons.OK,
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
    }
}
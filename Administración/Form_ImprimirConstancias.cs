using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormImprimirConstancias : Form
    {
        public FormImprimirConstancias()
        {
            InitializeComponent();
        }

        private void FormImprimirConstanciasLoad(object sender, EventArgs e)
        {
            ultraDateTimeEditorPeriodo.DateTime = new Service().HoraActual(Program.Pin);
            dsClientesConContratoActivoYPlan.Merge(new Service().GetClientesConContratoActivoYPlan(Program.Pin));
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void UltraComboClientesRowSelected(object sender, RowSelectedEventArgs e)
        {
            ultraComboContratos.Value = null;
            ultraComboPlanes.Value = null;
            dsClientesConContratoActivoYPlan.Contratos.Clear();
            dsClientesConContratoActivoYPlan.Planes.Clear();
            if (ultraComboClientes.SelectedRow.Cells["idCliente"].Value != DBNull.Value)
            {
                dsClientesConContratoActivoYPlan.Merge(
                    new Service().GetContratosActivosConPlan(
                        (int) ultraComboClientes.SelectedRow.Cells["idCliente"].Value, Program.Pin));
            }
            buttonAceptar.Enabled = ultraComboClientes.Text != "";
        }

        private void UltraComboContratosRowSelected(object sender, RowSelectedEventArgs e)
        {
            ultraComboPlanes.Value = null;
            dsClientesConContratoActivoYPlan.Planes.Clear();
            if (ultraComboContratos.SelectedRow.Cells["idContrato"].Value != DBNull.Value)
            {
                dsClientesConContratoActivoYPlan.Merge(
                    new Service().GetPlanesDeUnContrato(
                        (int) ultraComboContratos.SelectedRow.Cells["idContrato"].Value, Program.Pin));
            }
        }

        private void UltraComboContratosItemNotInList(object sender, ValidationErrorEventArgs e)
        {
            if (e.InvalidText == "")
            {
                e.RetainFocus = false;
            }
        }

        private void UltraComboPlanesItemNotInList(object sender, ValidationErrorEventArgs e)
        {
            if (e.InvalidText == "")
            {
                e.RetainFocus = false;
            }
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;
            ultraLabelMensaje.Visible = true;
            ultraLabelMensaje.Update();
            var frm = new FormRepConstanciasDeAfiliacion
                          {
                              MdiParent = MdiParent,
                              Periodo = ultraDateTimeEditorPeriodo.Value.ToString().Substring(3, 7)
                          };
            if (ultraComboClientes.Value == null)
            {
                frm.IdCliente = 0;
            }
            else
            {
                frm.IdCliente = (int) ultraComboClientes.Value;
            }
            if (ultraComboContratos.Value == null)
            {
                frm.IdContrato = 0;
            }
            else
            {
                frm.IdContrato = (int) ultraComboContratos.Value;
            }
            if (ultraComboPlanes.Value == null)
            {
                frm.IdPlan = 0;
            }
            else
            {
                frm.IdPlan = (int) ultraComboPlanes.Value;
            }
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
            Close();
        }

        private void UltraComboClientesItemNotInList(object sender, ValidationErrorEventArgs e)
        {
            if (e.InvalidText == "")
            {
                e.RetainFocus = false;
            }
        }
    }
}
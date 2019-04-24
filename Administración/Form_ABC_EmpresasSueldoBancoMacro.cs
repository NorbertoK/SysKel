using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormABCEmpresasSueldoBancoMacro : Form1
    {
        public FormABCEmpresasSueldoBancoMacro()
        {
            InitializeComponent();
        }

        private void FormABCEmpresasSueldoBancoMacroLoad(object sender, EventArgs e)
        {
            dsEmpresasSueldoBancoMacro.Merge(new Service().GetEmpresasSueldoBancoMacro(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            empresasSueldoBcoMacroBindingSource.EndEdit();
            var aux = new Service().UpdateEmpresasSueldoBancoMacro(dsEmpresasSueldoBancoMacro, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsEmpresasSueldoBancoMacro.Clear();
                dsEmpresasSueldoBancoMacro.Merge(new Service().GetBancos(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsEmpresasSueldoBancoMacro.Merge(aux);
            ManejoDatos.AplicarUpdate(dsEmpresasSueldoBancoMacro);
            return true;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            Grabar();
            buttonAplicar.Enabled = false;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
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

        private void BancosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void BancosUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void EmpresasSueldoBcoMacroUltraGridBeforeCellDeactivate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (empresasSueldoBcoMacroUltraGrid.ActiveCell.Column.Key != "idEmpresasSueldoBcoMacro") return;
            //empresasSueldoBcoMacroUltraGrid.ActiveRow.Update();
            var referencia = (int)empresasSueldoBcoMacroUltraGrid.ActiveCell.Value;
            if ((int)
                dsEmpresasSueldoBancoMacro.EmpresasSueldoBcoMacro.Compute("Count(idEmpresasSueldoBcoMacro)",
                                                                          "idEmpresasSueldoBcoMacro = " + referencia) < 1) return;
            MessageBox.Show("Ya está ingresado", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            empresasSueldoBcoMacroUltraGrid.BeforeRowsDeleted += EmpresasSueldoBcoMacroUltraGridBeforeRowsDeleted;
            empresasSueldoBcoMacroUltraGrid.ActiveRow.Delete();
            empresasSueldoBcoMacroUltraGrid.UpdateData();
            empresasSueldoBcoMacroUltraGrid.BeforeRowsDeleted -= EmpresasSueldoBcoMacroUltraGridBeforeRowsDeleted;
        }

        private void EmpresasSueldoBcoMacroUltraGridBeforeRowsDeleted(object sender,
                                                                      BeforeRowsDeletedEventArgs e)
        {
            e.DisplayPromptMsg = false;
        }

        private void empresasSueldoBcoMacroUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                empresasSueldoBcoMacroUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}

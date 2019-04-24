using System;
using System.ComponentModel;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormABCEmpleados : Form1
    {
        public FormABCEmpleados()
        {
            InitializeComponent();
        }

        private void FormABCEmpliadosLoad(object sender, EventArgs e)
        {
            ds_Empleados.Merge(new Service().GetEmpleados(Program.Pin));
            dsRubros.Merge(new Service().GetRubrosQueAdmitenValores(Program.Pin));
            dsBancos.Merge(new Service().GetBancos(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            empleadosBindingSource.EndEdit();
            cargosBindingSource.EndEdit();
            prestadoresBindingSource.EndEdit();
            var aux = new Service().UpdateEmpleados(ds_Empleados, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine +
                    Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información",
                    "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_Empleados.Clear();
                ds_Empleados.Merge(new Service().GetEmpleados(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_Empleados.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_Empleados);
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

        private void EmpleadosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void EmpleadosUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void FormABCEmpleadosActivated(object sender, EventArgs e)
        {
            ds_Prestadores.Merge(new Service().GetPrestadores(Program.Pin));
            ds_Cargos.Merge(new Service().GetCargos(Program.Pin));
        }

        private void UltraDropDownCargoFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Nombre"], FilterComparisionOperator.Equals, "Sistema");
            e.RowFilteredOut = e.Row.MeetsCriteria(fc);
        }

        #region BeforeDropDpown

        private void ultraDropDownRubros_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownRubros.DisplayLayout.Bands[0].Columns["NombreCompleto"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void ultraDropDownPrestador_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownPrestador.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void ultraDropDownCargo_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownCargo.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        #endregion

        private void empleadosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                empleadosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
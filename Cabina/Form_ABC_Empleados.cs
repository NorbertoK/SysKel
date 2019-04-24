using System;
using System.Windows.Forms;
using Cabina.WS;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using Properties;

    public partial class FormABCEmpleados : Form1
    {
        public FormABCEmpleados()
        {
            InitializeComponent();
        }

        private void FormABCEmpliadosLoad(object sender, EventArgs e)
        {
            dsEmpleados.Merge(new Service().GetEmpleados(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            empleadosBindingSource.EndEdit();
            var aux = new Service().UpdateEmpleados(dsEmpleados, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsEmpleados.Clear();
                dsEmpleados.Merge(new Service().GetEmpleados(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsEmpleados.Merge(aux);
            ManejoDatos.AplicarUpdate(dsEmpleados);
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
            dsPrestadores.Merge(new Service().GetPrestadores(Program.Pin));
            dsCargos.Merge(new Service().GetCargos(Program.Pin));
        }

        private void ultraDropDownCargo_FilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Nombre"], FilterComparisionOperator.Equals, "Sistema");
            e.RowFilteredOut = e.Row.MeetsCriteria(fc);
        }

        private void empleadosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                empleadosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
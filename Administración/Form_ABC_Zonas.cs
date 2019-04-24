using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using Properties;

    public partial class FormABCZonas : Form1
    {
        public FormABCZonas()
        {
            InitializeComponent();
        }

        private void FormABCZonasLoad(object sender, EventArgs e)
        {
            ds_Zonas.Merge(new Service().GetZonas(Program.Pin));
            ds_Localidades.Merge(new Service().GetLocalidades(Program.Pin));
            ds_PuntosDeVenta.Merge(new Service().GetPuntosDeVenta(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            zonasBindingSource.EndEdit();
            var aux = new Service().UpdateZonas(ds_Zonas, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_Zonas.Clear();
                ds_Zonas.Merge(new Service().GetZonas(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            ds_Zonas.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_Zonas);
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

        private void ZonasUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void ZonasUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void UltraDropDownCobradorFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void FormABCZonasActivated(object sender, EventArgs e)
        {
            ds_Localidades.Merge(new Service().GetLocalidades(Program.Pin));
            ds_PuntosDeVenta.Merge(new Service().GetPuntosDeVenta(Program.Pin));
            ds_EmpleadosLista1.Merge(new Service().GetCobradores(Program.Pin));
        }

        private void zonasUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                zonasUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
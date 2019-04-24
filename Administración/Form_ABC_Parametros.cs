using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormABCParametros : Form1
    {
        public FormABCParametros()
        {
            InitializeComponent();
        }

        private void FormABCParametrosLoad(object sender, EventArgs e)
        {
            ds_Parametros.Merge(new Service().GetParametros(Program.Pin));
            dsPorcentajeIVA.Merge(new Service().GetPorcentajeIVA(Program.Pin));
        }

        private void Grabar()
        {
            Validate();
            parametrosBindingSource.EndEdit();
            ds_Parametros.Merge(new Service().UpdateParametros(ds_Parametros, Program.Pin));
            ManejoDatos.AplicarUpdate(ds_Parametros);
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
                Grabar();
            }
            Close();
        }

        private void ParametrosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void parametrosUltraGrid_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                parametrosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
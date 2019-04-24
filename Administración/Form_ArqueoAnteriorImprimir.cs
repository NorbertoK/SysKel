using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using ColumnStyle = Infragistics.Win.UltraWinGrid.ColumnStyle;

namespace Administración
{
    public partial class FormArqueoAnteriorImprimir : Form1
    {
        public FormArqueoAnteriorImprimir()
        {
            InitializeComponent();
        }

        private void FormArqueoAnteriorImprimirLoad(object sender, EventArgs e)
        {
            dsArqueos.Merge(new Service().GetArqueos(Program.Pin));
            foreach (var banda in arqueosUltraGrid.DisplayLayout.Bands)
            {
                foreach (var columna in banda.Columns)
                {
                    columna.Style = ColumnStyle.Edit;
                }
            }
            arqueosUltraGrid.DisplayLayout.Override.AllowDelete = DefaultableBoolean.False;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            /*Muestra el reporte*/
            var repo = new FormReporteArqueo
                           {
                               IdArqueo = ((int) ultraNumericEditor1.Value),
                               MdiParent = MdiParent,
                               Left = 0,
                               Top = 0
                           };
            repo.Show();
            Close();
        }

        private void ArqueosUltraGridClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void UltraDropDownCobradoresFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void FormArqueoAnteriorImprimirActivated(object sender, EventArgs e)
        {
            dsEmpleadosLista1.Merge(new Service().GetCobradores(Program.Pin));
        }

        private void arqueosUltraGrid_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                arqueosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void arqueosUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}
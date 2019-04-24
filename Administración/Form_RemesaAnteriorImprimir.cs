using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormRemesaAnteriorImprimir : Form1
    {
        public FormRemesaAnteriorImprimir()
        {
            InitializeComponent();
        }

        private void FormRemesaAnteriorImprimirLoad(object sender, EventArgs e)
        {
            dsRemesasVista.Merge(new Service().GetRemesasVista(DateTime.Today,DateTime.Today, Program.Pin));
            view_RemesasUltraGrid.DisplayLayout.Bands[0].SortedColumns.Clear();
            view_RemesasUltraGrid.DisplayLayout.Bands[0].SortedColumns.Add("idRemesa", false, false);
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            /*Muestra el reporte*/
            var repo = new FormReporteRemesa
                           {
                               IdRemesa = ((int) ultraNumericEditorIdRemesa.Value),
                               MdiParent = MdiParent,
                               StartPosition = FormStartPosition.Manual,
                               Location = new Point(0, 0)
                           };
            repo.Show();
            Close();
        }

        private void ViewRemesasUltraGridClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void ButtonCargarClick(object sender, EventArgs e)
        {
            dsRemesasVista.Clear();
            dsRemesasVista.Merge(new Service().GetRemesasVista((DateTime)ultraDateTimeEditorDesde.Value,(DateTime)ultraDateTimeEditorHasta.Value,Program.Pin));
        }

        private void view_RemesasUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                view_RemesasUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
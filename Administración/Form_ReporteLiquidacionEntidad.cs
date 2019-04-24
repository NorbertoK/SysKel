using System;
using System.Drawing;
using System.Windows.Forms;

namespace Administración
{
    using WS;

    public partial class FormReporteLiquidacionEntidad : Form1
    {
        public FormReporteLiquidacionEntidad()
        {
            InitializeComponent();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var repo = new FormRepLiquidacionEntidad
            {
                IdLiquidacionEntidad =
                    (int)reportLiquidacionTercerizadaUltraGrid.ActiveRow.Cells["idLiquidacionTercerizada"].Value,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            repo.Show();
        }

        private void FormReporteLiquidacionEntidadLoad(object sender, EventArgs e)
        {
            dsReportLiquidacionEntidad.Merge(new Service().GetReportLiquidacionEntidadTodos(Program.Pin));
            reportLiquidacionTercerizadaUltraGrid.Rows[0].Activate();
            reportLiquidacionTercerizadaUltraGrid.ActiveRow = null;
        }

        private void ReportLiquidacionTercerizadaUltraGridClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void FormReporteLiquidacionEntidadActivated(object sender, EventArgs e)
        {
            buttonCancelar.Enabled = true;
        }

        private void reportLiquidacionTercerizadaUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}

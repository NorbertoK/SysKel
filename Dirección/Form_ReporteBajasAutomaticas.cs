using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dirección
{
    using WS;

    public partial class FormReporteBajasAutomaticas : Form1
    {
        public FormReporteBajasAutomaticas()
        {
            InitializeComponent();
        }

        private void FormReporteBajasAutomaticasLoad(object sender, EventArgs e)
        {
            dsFechasBajasAutomaticas.Merge(new Service().GetFechasBajasAutomaticas(Program.Pin));
            if (fechasBajasAutomaticasUltraGrid.Rows.Count == 0) return;
            fechasBajasAutomaticasUltraGrid.Rows[0].Activate();
            fechasBajasAutomaticasUltraGrid.ActiveRow = null;
        }

        private void FechasBajasAutomaticasUltraGridClick(object sender, EventArgs e)
        {
            if (fechasBajasAutomaticasUltraGrid.Rows.Count == 0) return;
            buttonAceptar.Enabled = true;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            var proceso = new Service().GetProceso(Program.Pin);
            var fecha = (DateTime)fechasBajasAutomaticasUltraGrid.ActiveRow.Cells["Fecha"].Value;
            var fechaEnString = fecha.ToString("yyyyMMdd HH:mm:ss");
            new Service().ReporteBajasAutomaticas(proceso,fechaEnString,Program.Pin);
            buttonAceptar.Enabled = false;
            var f = new FormRepBajasAutomaticas
            {
                Proceso = proceso,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            f.Show();
            Close();
        }
    }
}

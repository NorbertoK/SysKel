using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    public partial class FormReportTasaDeUsoAfYCli : Form1
    {
        public FormReportTasaDeUsoAfYCli()
        {
            InitializeComponent();
        }
        private void Form_Report_TasaDeUsoAfYCli_Load(object sender, EventArgs e)
        {
            var ahora = new Service().HoraActual(Program.Pin);
            ultraDateTimeEditorPeriodoDesde.Value = ahora.AddMonths(-12);
            ultraDateTimeEditorPeriodoHasta.Value = ahora.AddMonths(-1);
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            buttonCancelar.Enabled = false;
            buttonAceptar.Enabled = false;
            var f = new FormRepTasaDeUsoAfYCli()
            {
                PeriodoDesde = ultraDateTimeEditorPeriodoDesde.Text,
                PeriodoHasta = ultraDateTimeEditorPeriodoHasta.Text,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(1, 1)
            };
            f.Show();
            Close();
        }
    }
}

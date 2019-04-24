namespace Dirección
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using WS;
    using Properties;

    public partial class FormReporteEstadisticaCantidadDeAfiliados : Form1
    {
        private FormPrincipal _fp;

        public FormReporteEstadisticaCantidadDeAfiliados()
        {
            InitializeComponent();
        }

        private void FormReporteEstadisticaCantidadDeAfiliadosLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal) MdiParent;
            planesBindingSource.DataSource = _fp.dsPlanes;
            var ahora = new Service().HoraActual(Program.Pin);
            ultraDateTimeEditorPeriodoDesde.Value = ahora.AddMonths(-12);
            ultraDateTimeEditorPeriodoHasta.Value = ahora.AddMonths(-1);
        }

        private void UltraComboModoRowSelected(object sender, Infragistics.Win.UltraWinGrid.RowSelectedEventArgs e)
        {
            if (e.Row.Cells["Id"].Value.ToString() == "UnPlan")
            {
                buttonAceptar.Enabled = false;
                ultraLabelPlan.Enabled = true;
                ultraComboPlanes.Enabled = true;
            }
            else
            {
                buttonAceptar.Enabled = true;
                ultraComboPlanes.Value = DBNull.Value;
                ultraLabelPlan.Enabled = false;
                ultraComboPlanes.Enabled = false;
            }
        }

        private void UltraComboPlanesRowSelected(object sender, Infragistics.Win.UltraWinGrid.RowSelectedEventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonCancelar.Enabled = false;
            buttonAceptar.Enabled = false;
            var f = new FormRepEstadisticaCantidadDeAfiliados
                        {
                            PeriodoDesde = ultraDateTimeEditorPeriodoDesde.Text,
                            PeriodoHasta = ultraDateTimeEditorPeriodoHasta.Text,
                            Modo = ultraComboModo.Value.ToString(),
                            IdPlan = ultraComboPlanes.Value == null ? 0 : (int) ultraComboPlanes.Value,
                            Subtitulo =
                                (ultraComboModo.Text == Resources.FormReporteEstadisticaCantidadDeAfiliados_ButtonAceptarClick_Un_Plan
                                     ? "Plan " + ultraComboPlanes.Text
                                     : ultraComboModo.Text) + " " + ultraDateTimeEditorPeriodoDesde.Text + " - " +
                                ultraDateTimeEditorPeriodoHasta.Text,
                            MdiParent = MdiParent,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(1, 1)
                        };
            f.Show();
            Close();
        }
    }
}
namespace Administración
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using WS;

    public partial class FormReportDeudores : Form1
    {
        public FormReportDeudores()
        {
            InitializeComponent();
        }
        private void FormReportDeudores_Load(object sender, EventArgs e)
        {
            ultraCalendarCombo1.Value = new Service().HoraActual(Program.Pin);
        }
        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonCancelar.Visible = false;
            buttonAceptar.Visible = false;
            labelProcesando.Visible = true;
            checkBoxListado.Enabled = false;
            checkBoxResumen.Enabled = false;
            checkBoxExcel.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1DoWork(object sender, DoWorkEventArgs e)
        {
            var aux = new Service {Timeout = (60*60*1000)};
            var fecha = (DateTime)ultraCalendarCombo1.Value;
            dsDeudores1.Merge(aux.GetDeudores(fecha.ToString("yyyyMMdd"), Program.Pin));
        }

        private void ButtonAceptarEnabled()
        {
            if (checkBoxListado.Checked == false && checkBoxResumen.Checked == false && checkBoxExcel.Checked == false)
            {
                buttonAceptar.Enabled = false;
            }
            else
            {
                buttonAceptar.Enabled = true;
            }
        }

        private void CheckBoxListadoCheckStateChanged(object sender, EventArgs e)
        {
            ButtonAceptarEnabled();
        }

        private void CheckBoxResumenCheckStateChanged(object sender, EventArgs e)
        {
            ButtonAceptarEnabled();
        }

        private void CheckBoxExcelCheckStateChanged(object sender, EventArgs e)
        {
            ButtonAceptarEnabled();
        }

        private void BackgroundWorker1RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (checkBoxListado.Checked)
            {
                var f = new FormRepDeudores
                            {
                                Fecha = (DateTime) ultraCalendarCombo1.Value,
                                DsDeudoresTraidos = dsDeudores1,
                                MdiParent = MdiParent,
                                StartPosition = FormStartPosition.Manual,
                                Location = new Point(0, 0)
                            };
                f.Show();
            }
            if (checkBoxResumen.Checked)
            {
                var fr = new FormRepDeudoresResumen
                             {
                                 Fecha = (DateTime) ultraCalendarCombo1.Value,
                                 DsDeudoresTraidos = dsDeudores1,
                                 MdiParent = MdiParent,
                                 StartPosition = FormStartPosition.Manual,
                                 Location = new Point(20, 20)
                             };
                fr.Show();
            }
            if (checkBoxExcel.Checked)
            {
                var fe = new FormRepDeudoresExcel
                             {
                                 DsDeudoresTraidos = dsDeudores1,
                                 MdiParent = MdiParent,
                                 StartPosition = FormStartPosition.Manual,
                                 Location = new Point(40, 40)
                             };
                fe.Show();
            }
            Close();
        }
    }
}
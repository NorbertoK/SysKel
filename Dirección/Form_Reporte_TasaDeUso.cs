using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Dirección.WS;

namespace Dirección
{
    public partial class FormReporteTasaDeUso : Form1
    {
        private string _periodo;

        public FormReporteTasaDeUso()
        {
            InitializeComponent();
        }

        private void FormReporteTasaDeUsoLoad(object sender, EventArgs e)
        {
            DateTime ahora = new Service().HoraActual(Program.Pin);
            string mesDesde = ahora.AddMonths(-12).ToString("MMyyyy");
            string mesHasta = ahora.AddMonths(-1).ToString("MMyyyy");
            ultraComboEditorMesDesde.Value = mesDesde.Substring(0, 2);
            ultraComboEditorMesHasta.Value = mesHasta.Substring(0, 2);
            ultraNumericEditorAnyoDesde.Value = Convert.ToInt16(mesDesde.Substring(2, 4));
            ultraNumericEditorAnyoHasta.Value = Convert.ToInt16(mesHasta.Substring(2, 4));
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (ultraComboEditorMesDesde.Value + "/" + ultraNumericEditorAnyoDesde.Value ==
                ultraComboEditorMesHasta.Value + "/" + ultraNumericEditorAnyoHasta.Value)
            {
                _periodo = ultraComboEditorMesDesde.Value + "/" + ultraNumericEditorAnyoDesde.Value;
            }
            else
            {
                _periodo = ultraComboEditorMesDesde.Value + "/" + ultraNumericEditorAnyoDesde.Value + " - " +
                          ultraComboEditorMesHasta.Value + "/" + ultraNumericEditorAnyoHasta.Value;
            }
            buttonCancelar.Visible = false;
            buttonAceptar.Visible = false;
            ultraLabelMensaje.Visible = true;
            ultraLabelMensaje.Update();
            if (ultraComboModo.Value.ToString() == "RubroCliAlfa")
            {
                backgroundWorkerRubroCliAlfa.RunWorkerAsync();
            }
            if (ultraComboModo.Value.ToString() == "RubroCliNum")
            {
                backgroundWorkerRubroCliNum.RunWorkerAsync();
            }
            if (ultraComboModo.Value.ToString() == "CliAlfa")
            {
                backgroundWorkerCliAlfa.RunWorkerAsync();
            }
            if (ultraComboModo.Value.ToString() == "CliNum")
            {
                backgroundWorkerCliNum.RunWorkerAsync();
            }
        }

        private void BackgroundWorkerRubroCliAlfaDoWork(object sender, DoWorkEventArgs e)
        {
            var aux = new Service {Timeout = (60*60*1000)};
            dsRepTasaDeUso1.Merge(aux.GetTasaDeUso("RubroCli",
                                                   ultraComboEditorMesDesde.Value + "/" +
                                                   ultraNumericEditorAnyoDesde.Value,
                                                   ultraComboEditorMesHasta.Value + "/" +
                                                   ultraNumericEditorAnyoHasta.Value, Program.Pin));
        }

        private void BackgroundWorkerRubroCliAlfaRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var f = new FormRepTasaDeUsoRubroCliAlfa
                        {
                            Subtitulo = ultraComboModo.Text,
                            Periodo = _periodo,
                            Filtro = checkBoxCero.Checked ? -1 : 0,
                            DsRepTasaDeUso1 = dsRepTasaDeUso1,
                            MdiParent = MdiParent,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(1, 1)
                        };
            f.Show();
            ultraLabelMensaje.Visible = false;
            buttonCancelar.Visible = true;
            buttonAceptar.Visible = true;
        }

        #region EnableAceptar

        private bool EnableBotonAceptar()
        {
            if (ultraComboEditorMesDesde.Value == null || ultraComboEditorMesHasta.Value == null ||
                ultraComboModo.Value == null) return false;
            return Convert.ToInt32(ultraNumericEditorAnyoHasta.Value.ToString())*12 +
                   Convert.ToInt32(ultraComboEditorMesHasta.Value.ToString()) >=
                   Convert.ToInt32(ultraNumericEditorAnyoDesde.Value.ToString())*12 +
                   Convert.ToInt32(ultraComboEditorMesDesde.Value.ToString());
        }

        private void UltraComboEditorMesDesdeValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = EnableBotonAceptar();
        }

        private void UltraNumericEditorAnyoDesdeValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = EnableBotonAceptar();
        }

        private void UltraComboEditorMesHastaValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = EnableBotonAceptar();
        }

        private void UltraNumericEditorAnyoHastaValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = EnableBotonAceptar();
        }

        private void UltraComboModoValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = EnableBotonAceptar();
        }

        #endregion EnableAceptar

        private void BackgroundWorkerRubroCliNumDoWork(object sender, DoWorkEventArgs e)
        {
            var aux = new Service { Timeout = (60 * 60 * 1000) };
            dsRepTasaDeUso1.Merge(aux.GetTasaDeUso("RubroCli",
                                                   ultraComboEditorMesDesde.Value + "/" +
                                                   ultraNumericEditorAnyoDesde.Value,
                                                   ultraComboEditorMesHasta.Value + "/" +
                                                   ultraNumericEditorAnyoHasta.Value, Program.Pin));
        }

        private void BackgroundWorkerRubroCliNumRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var f = new FormRepTasaDeUsoRubroCliNum
            {
                Subtitulo = ultraComboModo.Text,
                Periodo = _periodo,
                Filtro = checkBoxCero.Checked ? -1 : 0,
                DsRepTasaDeUso1 = dsRepTasaDeUso1,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(1, 1)
            };
            f.Show();
            ultraLabelMensaje.Visible = false;
            buttonCancelar.Visible = true;
            buttonAceptar.Visible = true;
        }

        private void BackgroundWorkerCliAlfaDoWork(object sender, DoWorkEventArgs e)
        {
            var aux = new Service { Timeout = (60 * 60 * 1000) };
            dsRepTasaDeUso1.Merge(aux.GetTasaDeUso("RubroCli",
                                                   ultraComboEditorMesDesde.Value + "/" +
                                                   ultraNumericEditorAnyoDesde.Value,
                                                   ultraComboEditorMesHasta.Value + "/" +
                                                   ultraNumericEditorAnyoHasta.Value, Program.Pin));
        }

        private void BackgroundWorkerCliAlfaRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var f = new FormRepTasaDeUsoCliAlfa
            {
                Subtitulo = ultraComboModo.Text,
                Periodo = _periodo,
                Filtro = checkBoxCero.Checked ? -1 : 0,
                DsRepTasaDeUso1 = dsRepTasaDeUso1,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(1, 1)
            };
            f.Show();
            ultraLabelMensaje.Visible = false;
            buttonCancelar.Visible = true;
            buttonAceptar.Visible = true;
        }

        private void BackgroundWorkerCliNumDoWork(object sender, DoWorkEventArgs e)
        {
            var aux = new Service { Timeout = (60 * 60 * 1000) };
            dsRepTasaDeUso1.Merge(aux.GetTasaDeUso("RubroCli",
                                                   ultraComboEditorMesDesde.Value + "/" +
                                                   ultraNumericEditorAnyoDesde.Value,
                                                   ultraComboEditorMesHasta.Value + "/" +
                                                   ultraNumericEditorAnyoHasta.Value, Program.Pin));
        }

        private void BackgroundWorkerCliNumRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var f = new FormRepTasaDeUsoCliNum
            {
                Subtitulo = ultraComboModo.Text,
                Periodo = _periodo,
                Filtro = checkBoxCero.Checked ? -1 : 0,
                DsRepTasaDeUso1 = dsRepTasaDeUso1,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(1, 1)
            };
            f.Show();
            ultraLabelMensaje.Visible = false;
            buttonCancelar.Visible = true;
            buttonAceptar.Visible = true;
        }
    }
}
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Administración.Properties;
using Administración.WS;

namespace Administración
{
    public partial class FormReporteBancoMacro : Form1
    {
        public FormReporteBancoMacro()
        {
            InitializeComponent();
        }

        private void FormReporteBancoMacroLoad(object sender, EventArgs e)
        {
            var fecha = new Service().HoraActual(Program.Pin);
            ultraDateTimeEditorPeriodo.Value = (fecha.Month < 10 ? "0" : "") + fecha.Month + "/" + fecha.Year;
            ultraComboSecuencial.Value = 1;
            ultraComboRectificativa.Value = 0;
        }

        private void UltraComboJubiladoValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = ultraComboJubilado.Value != null;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            var dir = new DirectoryInfo("C:/BancoMacro");
            if (!dir.Exists)
            {
                dir.Create();
            }
            var secuencial = (int)ultraComboSecuencial.Value;
            var secuencialformateado = secuencial.ToString("00");
            var nombreArchivo = "C:\\BancoMacro\\D1067301" + secuencialformateado + "285.txt";
            
            if (File.Exists(nombreArchivo))
            {
                if (
                    MessageBox.Show("El archivo " + nombreArchivo + " ya existe."
                        + Environment.NewLine +
                        "¿Desea sobreescribirlo?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.No)
                {
                    Close();
                }
            }
            dsReporteMacro1.Merge(new Service().GetBancoMacroArchivo(ultraDateTimeEditorPeriodo.Text, (int)ultraComboJubilado.Value, (int)ultraComboSecuencial.Value, (int)ultraComboRectificativa.Value, Program.Pin));
            using (var sw = File.CreateText(nombreArchivo))
            {
                foreach (DataRow row in dsReporteMacro1.ReporteMacro)
                {
                    sw.WriteLine(row[0]);
                }
            }
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var f = new FormRepBancoMacro
                        {
                Periodo = ultraDateTimeEditorPeriodo.Text,
                Jubilado = (int)ultraComboJubilado.Value != 0,
                Titulo = "Banco Macro",
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            f.Show();
            Close();
        }
    }
}

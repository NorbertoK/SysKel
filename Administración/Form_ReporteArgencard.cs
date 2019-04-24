using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Administración.Properties;
using Administración.WS;

namespace Administración
{
    public partial class FormReporteArgencard : Form1
    {
        public FormReporteArgencard()
        {
            InitializeComponent();
        }

        private void FormReporteArgencardLoad(object sender, EventArgs e)
        {
            var fecha = new Service().HoraActual(Program.Pin);
            ultraDateTimeEditorPeriodo.Value = (fecha.Month < 10 ? "0" : "") + fecha.Month + "/" + fecha.Year;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            var dir = new DirectoryInfo("C:/Argencard");
            if (!dir.Exists)
            {
                dir.Create();
            }
            const string nombreArchivo = "C:\\Argencard\\DA168D.txt";

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
            dsReporteMacro1.Merge(new Service().GetArgencardArchivo(ultraDateTimeEditorPeriodo.Text, Program.Pin));
            using (var sw = File.CreateText(nombreArchivo))
            {
                foreach (var row in dsReporteMacro1.ReporteArgencard)
                {
                    sw.WriteLine(row[0]);
                }
            }
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var f = new FormRepBancoMacro
            {
                Periodo = ultraDateTimeEditorPeriodo.Text,
                Titulo = "Argencard",
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            f.Show();
            Close();
        }
    }
}

using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    using Properties;

    public partial class FormReporteVisa : Form
    {
        private string _periodo;

        public FormReporteVisa()
        {
            InitializeComponent();
        }

        private void FormReporteVisaLoad(object sender, EventArgs e)
        {
            var fechaActual = new Service().HoraActual(Program.Pin);
            var fecha = fechaActual.AddMonths(fechaActual.Day < 10 ? 0 : 1);
            _periodo = (fecha.Month < 10 ? "0" : "") + fecha.Month + "/" + fecha.Year;
            ultraLabelInforme.Text = "Se generará un archivo para enviar a VISA" + Environment.NewLine +
                                     "con las facturas de Afiliados y Clientes" + Environment.NewLine +
                                     "correspondientes a la cobertura " + _periodo + ".";
        }

        private bool VerSiFaltaAlgo(string periodo)
        {
            var falta = new Service().MensajeDebitoAutomatico(periodo, Program.Pin);
            if (falta != "Ninguno")
            {
                if (falta == "Afiliados")
                {
                    MessageBox.Show(
                        "No se pudo generar el archivo para enviar a VISA" + Environment.NewLine +
                        "con las facturas de Afiliados y Clientes" + Environment.NewLine +
                        "correspondientes a la cobertura " + periodo + "." + Environment.NewLine + Environment.NewLine +
                        "Falta la facturación de Afiliados de ese período.", "Archivo para VISA", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                if (falta == "Clientes")
                {
                    MessageBox.Show(
                        "No se pudo generar el archivo para enviar a VISA" + Environment.NewLine +
                        "con las facturas de Afiliados y Clientes" + Environment.NewLine +
                        "correspondientes a la cobertura " + periodo + "." + Environment.NewLine + Environment.NewLine +
                        "Falta la facturación de Clientes de ese período.", "Archivo para VISA", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                if (falta == "Ambos")
                {
                    MessageBox.Show(
                        "No se pudo generar el archivo para enviar a VISA" + Environment.NewLine +
                        "con las facturas de Afiliados y Clientes" + Environment.NewLine +
                        "correspondientes a la cobertura " + periodo + "." + Environment.NewLine + Environment.NewLine +
                        "Falta la facturación de Afiliados y Clientes de ese período.", "Archivo para VISA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return true;
            }
            return false;
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (VerSiFaltaAlgo(_periodo) == false)
            {
                var dir = new DirectoryInfo("C:/VISA");
                if (!dir.Exists)
                {
                    dir.Create();
                }
                const string nombreArchivo = "C:\\VISA\\DEBLIC.TXT";
                if (File.Exists(nombreArchivo))
                {
                    if (
                        MessageBox.Show(
                            "El archivo C:\\VISA\\DEBLIC.TXT ya existe." + Environment.NewLine +
                            "¿Desea sobreescribirlo?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.No)
                    {
                        Close();
                    }
                }
                dsReporteVISA1.Merge(new Service().GetReporteVISA(_periodo, Program.Pin));
                using (var sw = File.CreateText(nombreArchivo))
                {
                    var registros = "";
                    var total = "";
                    foreach (DataRow row in dsReporteVISA1.ReporteVISA)
                    {
                        sw.WriteLine(row[0]);
                        if (!row[0].ToString().StartsWith("9")) continue;
                        registros = Convert.ToInt32(row[0].ToString().Substring(41, 7)).ToString("###,###,###");
                        total = Convert.ToInt32(row[0].ToString().Substring(48, 13)).ToString("###,###,###") + "," +
                                row[0].ToString().Substring(61, 2);
                    }
                    sw.WriteLine(Convert.ToChar(13));
                    MessageBox.Show(
                        "Se ha creado el archivo C:\\VISA\\DEBLIC.TXT." + Environment.NewLine + Environment.NewLine +
                        registros + " registros      $ " + total, "Proceso terminado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                }
            }
            else
            {
                buttonAceptar.Text = "Reintentar";
            }
        }
    }
}
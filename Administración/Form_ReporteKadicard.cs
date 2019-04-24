using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    using Properties;

    public partial class FormReporteKadicard : Form
    {
        private string _periodo;

        public FormReporteKadicard()
        {
            InitializeComponent();
        }

        private void FormReporteVisaLoad(object sender, EventArgs e)
        {
            var fechaActual = new Service().HoraActual(Program.Pin);
            var fecha = fechaActual.AddMonths(fechaActual.Day < 10 ? 0 : 1);
            _periodo = (fecha.Month < 10 ? "0" : "") + fecha.Month + "/" + fecha.Year;
            ultraLabelInforme.Text = "Se generará un archivo para enviar a Kadicard" + Environment.NewLine +
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
                        "No se pudo generar el archivo para enviar a Kadicard" + Environment.NewLine +
                        "con las facturas de Afiliados y Clientes" + Environment.NewLine +
                        "correspondientes a la cobertura " + periodo + "." + Environment.NewLine + Environment.NewLine +
                        "Falta la facturación de Afiliados de ese período.", "Archivo para Kadicard",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (falta == "Clientes")
                {
                    MessageBox.Show(
                        "No se pudo generar el archivo para enviar a Kadicard" + Environment.NewLine +
                        "con las facturas de Afiliados y Clientes" + Environment.NewLine +
                        "correspondientes a la cobertura " + periodo + "." + Environment.NewLine + Environment.NewLine +
                        "Falta la facturación de Clientes de ese período.", "Archivo para Kadicard",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (falta == "Ambos")
                {
                    MessageBox.Show(
                        "No se pudo generar el archivo para enviar a Kadicard" + Environment.NewLine +
                        "con las facturas de Afiliados y Clientes" + Environment.NewLine +
                        "correspondientes a la cobertura " + periodo + "." + Environment.NewLine + Environment.NewLine +
                        "Falta la facturación de Afiliados y Clientes de ese período.", "Archivo para Kadicard",
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
                var dir = new DirectoryInfo("C:/Kadicard");
                if (!dir.Exists)
                {
                    dir.Create();
                }
                const string nombreArchivo = "C:\\Kadicard\\DEBLIC.TXT";
                if (File.Exists(nombreArchivo))
                {
                    if (
                        MessageBox.Show(
                            "El archivo C:\\Kadicard\\DEBLIC.TXT ya existe." + Environment.NewLine +
                            "¿Desea sobreescribirlo?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.No)
                    {
                        Close();
                    }
                }
                dsReporteKadicard1.Merge(new Service().GetReporteKadicard(_periodo, Program.Pin));
                using (var sw = File.CreateText(nombreArchivo))
                {
                    var registros = 0;
                    decimal total = 0;
                    foreach (DataRow row in dsReporteKadicard1.ReporteKADICARD)
                    {
                        sw.WriteLine(row[0]);
                        registros = registros + 1;
                        total = total + Convert.ToDecimal(row[0].ToString().Substring(22, 15));
                    }
                    total = total/100;
                    var sregistros = registros.ToString("###,###,###");
                    var stotal = total.ToString("###,###,###.00");
                    MessageBox.Show(
                        "Se ha creado el archivo C:\\Kadicard\\DEBLIC.TXT." + Environment.NewLine + Environment.NewLine +
                        sregistros + " registros      $ " + stotal, "Proceso terminado", MessageBoxButtons.OK,
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
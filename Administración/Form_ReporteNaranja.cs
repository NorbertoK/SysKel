using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    public partial class FormReporteNaranja : Form
    {
        public FormReporteNaranja()
        {
            InitializeComponent();
        }

        private void FormReporteVisaLoad(object sender, EventArgs e)
        {
            var fecha = new Service().HoraActual(Program.Pin);
            ultraDateTimeEditorPeriodo.Value = (fecha.Month < 10 ? "0" : "") + fecha.Month + "/" + fecha.Year;
        }

        private bool VerSiFaltaAlgo(
            //string periodo
            )
        {
            //var falta = new Service().MensajeDebitoAutomatico(periodo, Program.Pin);
            //if (falta != "Ninguno")
            //{
            //    if (falta == "Afiliados")
            //    {
            //        MessageBox.Show(
            //            Resources.FormReporteNaranja_VerSiFaltaAlgo_No_se_pudo_generar_el_archivo_para_enviar_a_Tarjeta_Naranja + Environment.NewLine +
            //            "con las facturas de Afiliados y Clientes" + Environment.NewLine +
            //            "correspondientes a la cobertura " + periodo + Resources.Punto + Environment.NewLine + Environment.NewLine +
            //            Resources.FormReporteVISA_VerSiFaltaAlgo_Falta_la_facturación_de_Afiliados_de_ese_período_, Resources.FormReporteNaranja_VerSiFaltaAlgo_Archivo_para_Tarjeta_Naranja,
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    if (falta == "Clientes")
            //    {
            //        MessageBox.Show(
            //            Resources.FormReporteNaranja_VerSiFaltaAlgo_No_se_pudo_generar_el_archivo_para_enviar_a_Tarjeta_Naranja + Environment.NewLine +
            //            "con las facturas de Afiliados y Clientes" + Environment.NewLine +
            //            "correspondientes a la cobertura " + periodo + Resources.Punto + Environment.NewLine + Environment.NewLine +
            //            Resources.FormReporteVISA_VerSiFaltaAlgo_Falta_la_facturación_de_Clientes_de_ese_período_, Resources.FormReporteNaranja_VerSiFaltaAlgo_Archivo_para_Tarjeta_Naranja,
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    if (falta == "Ambos")
            //    {
            //        MessageBox.Show(
            //            Resources.FormReporteNaranja_VerSiFaltaAlgo_No_se_pudo_generar_el_archivo_para_enviar_a_Tarjeta_Naranja + Environment.NewLine +
            //            "con las facturas de Afiliados y Clientes" + Environment.NewLine +
            //            "correspondientes a la cobertura " + periodo + Resources.Punto + Environment.NewLine + Environment.NewLine +
            //            Resources.FormReporteVISA_VerSiFaltaAlgo_Falta_la_facturación_de_Afiliados_y_Clientes_de_ese_período_, Resources.FormReporteNaranja_VerSiFaltaAlgo_Archivo_para_Tarjeta_Naranja,
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    return true;
            //}
            return false;
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (VerSiFaltaAlgo(
                //_periodo
                ) == false)
            {
                var dir = new DirectoryInfo("C:/Tarjeta Naranja");
                if (!dir.Exists)
                {
                    dir.Create();
                }
                const string nombreArchivo = "C:\\Tarjeta Naranja\\daf-201005689.txt";
                if (File.Exists(nombreArchivo))
                {
                    if (
                        MessageBox.Show(
                            "El archivo C:\\Naranja\\DEBLIC.TXT ya existe." + Environment.NewLine +
                            "¿Desea sobreescribirlo?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.No)
                    {
                        Close();
                    }
                }
                dsReporteNaranja.Merge(new Service().GetReporteNaranja(ultraDateTimeEditorPeriodo.Text, Program.Pin));
                using (var sw = File.CreateText(nombreArchivo))
                {
                    //var registros = "";
                    //var total = "";
                    foreach (DataRow row in dsReporteNaranja.ReporteNARANJA)
                    {
                        sw.WriteLine(row[0]);
                        //if (!row[0].ToString().StartsWith("P")) continue;
                        //registros = Convert.ToInt32(row[0].ToString().Substring(1, 6)).ToString("###,###,###");
                        //total = Convert.ToInt32(row[0].ToString().Substring(95, 10)).ToString("###,###,###") + "," +
                        //        row[0].ToString().Substring(105, 2);
                    }
                    //MessageBox.Show(
                    //    Resources.FormReporteNaranja_buttonAceptar_Click_Se_ha_creado_el_archivo_C__Naranja_DEBLIC_TXT_ + Environment.NewLine + Environment.NewLine +
                    //    registros + Resources.FormReporteVISA_ButtonAceptarClick_registros + total, Resources.FormReporteVISA_ButtonAceptarClick_Proceso_terminado, MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information);
                    buttonAceptar.Enabled = false;
                    buttonCancelar.Enabled = false;
                    var f = new FormRepBancoMacro
                    {
                        Periodo = ultraDateTimeEditorPeriodo.Text,
                        Titulo = "Tarjeta Naranja",
                        MdiParent = MdiParent,
                        StartPosition = FormStartPosition.Manual,
                        Location = new Point(0, 0)
                    };
                    f.Show();
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
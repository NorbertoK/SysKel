using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    using Properties;

    public partial class FormReporteFacturadoPorEntidad : Form
    {
        private string _periodo;

        public FormReporteFacturadoPorEntidad()
        {
            InitializeComponent();
        }

        private void FormReporteVisaLoad(object sender, EventArgs e)
        {
            var fechaActual = new Service().HoraActual(Program.Pin);
            var fechaPeriodo = fechaActual.AddMonths(fechaActual.Day < 10 ? 0 : 1);
            ultraDateTimeEditorPeriodo.Value = fechaPeriodo;
            _periodo = (fechaPeriodo.Month < 10 ? "0" : "") + fechaPeriodo.Month + "/" + fechaPeriodo.Year;
            dsEntidadesDeCobranza.Merge(new Service().GetEntidadesDeCobranza(Program.Pin));
        }

        private bool VerSiFaltaAlgo(string xPperiodo)
        {
            var falta = new Service().MensajeDebitoAutomatico(xPperiodo, Program.Pin);
            if (falta != "Ninguno")
            {
                if (falta == "Afiliados")
                {
                    MessageBox.Show(
                        "No se pudo generar el listado para enviar a " + ultraComboEntidades.Text + Environment.NewLine +
                        "con las facturas de Afiliados y Clientes" + Environment.NewLine +
                        "correspondientes a la cobertura " + xPperiodo + "." + Environment.NewLine + Environment.NewLine +
                        "Falta la facturación de Afiliados de ese período.", "¡Atención", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                if (falta == "Clientes")
                {
                    MessageBox.Show(
                        "No se pudo generar el listado para enviar a " + ultraComboEntidades.Text + Environment.NewLine +
                        "con las facturas de Afiliados y Clientes" + Environment.NewLine +
                        "correspondientes a la cobertura " + xPperiodo + "." + Environment.NewLine + Environment.NewLine +
                        "Falta la facturación de Clientes de ese período.", "¡Atención!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                if (falta == "Ambos")
                {
                    MessageBox.Show(
                        "No se pudo generar el listado para enviar a " + ultraComboEntidades.Text + Environment.NewLine +
                        "con las facturas de Afiliados y Clientes" + Environment.NewLine +
                        "correspondientes a la cobertura " + xPperiodo + "." + Environment.NewLine + Environment.NewLine +
                        "Falta la facturación de Afiliados y Clientes de ese período.", "¡Atención!",
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
                buttonAceptar.Enabled = false;
                buttonCancelar.Enabled = false;
                var f = new FormRepFacturadoPorEntidad
                            {
                                Periodo = _periodo,
                                IdEntidadDeCobranza = ((int) ultraComboEntidades.Value),
                                EntidadDeCobranza = ultraComboEntidades.Text,
                                MdiParent = MdiParent,
                                StartPosition = FormStartPosition.Manual,
                                Location = new Point(0, 0)
                            };
                f.Show();
                Close();
            }
            else
            {
                buttonAceptar.Text = "Reintentar";
            }
        }

        private void UltraDateTimeEditorPeriodoValueChanged(object sender, EventArgs e)
        {
            var fechaPeriodo = (DateTime) ultraDateTimeEditorPeriodo.Value;
            _periodo = (fechaPeriodo.Month < 10 ? "0" : "") + fechaPeriodo.Month + "/" + fechaPeriodo.Year;
        }

        private void UltraComboEntidadesValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
        }
    }
}
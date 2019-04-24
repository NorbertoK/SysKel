using System;
using Administración.WS;

namespace Administración
{
    using System.Drawing;
    using System.Windows.Forms;
    using Properties;

    public partial class FormBajasAutomaticas : Form1
    {
        public FormBajasAutomaticas()
        {
            InitializeComponent();
        }
        private void FormBajasAutomaticasLoad(object sender, EventArgs e)
        {
            ultraDateTimeEditorPeriodo.Value = new Service().HoraActual(Program.Pin);
            dsParametros1.Merge(new Service().GetParametros(Program.Pin));
            var meses = dsParametros1.Parametros.Rows[0]["MesesImpagosBaja"].ToString();
            ultraLabelMeses.Text = "Se dará de baja a los grupos que deban los últimos " + meses + " meses con Cobranza Propia.";
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;
            ultraLabelMensaje.Text = "Espere, por favor...";
            ultraLabelMensaje.Update();
            ultraDateTimeEditorPeriodo.Enabled = false;
            var periodo1 = ultraDateTimeEditorPeriodo.Value.ToString().Substring(3, 7);
            var proceso = new Service().GetProceso(Program.Pin);
            var aux = new Service { Timeout = (60 * 60 * 1000) };
            var cantidadBajas = aux.CantidadDeBajasAutomaticas(periodo1, Program.IdUsuario, proceso,Program.Pin);
            MostrarCantidadDeBajasAutomaticas(cantidadBajas);
            if (cantidadBajas <= 0) return;
            var f = new FormRepBajasAutomaticas
                        {
                            Proceso = proceso,
                            MdiParent = MdiParent,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(0, 0)
                        };
            f.Show();
        }

        private void MostrarCantidadDeBajasAutomaticas(int cantidadBajas)
        {
                switch (cantidadBajas)
                {
                    case 0:
                        ultraLabelMensaje.Text = " bajas.";
                        break;
                    case 1:
                        ultraLabelMensaje.Text = "Se dio 1 baja.";
                        break;
                    default:
                        ultraLabelMensaje.Text = "Se dieron " + cantidadBajas + " bajas.";
                        break;
                }
                buttonAplicar.Visible = true;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            // Es el botón Salir.
            Close();
        }
    }
}
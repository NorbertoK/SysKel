using System;
using System.Deployment.Application;
using System.Windows.Forms;

namespace Administración
{
    using Properties;

    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAboutLoad(object sender, EventArgs e)
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                labelVersion.Text = "Versión: " + ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
            else
            {
                labelVersion.Text = "Versión: A definir.";
            }
            if (!Program.TieneLicencia)
            {
                labelLicencia.Text = "Licencia inválida";
                labelLicencia.ForeColor = System.Drawing.Color.Red;
                timer1.Enabled = true;
            }
            else
            {
                if (Program.VigenciaLicencia.Year>=3000)
                {
                    labelLicencia.Text = "Licencia de Uso Ilimitada.";
                }
                else
                {
                    if (Program.VigenciaLicencia.Year <= 1947)
                    {
                        labelLicencia.Text = "Licencia inválida";
                        labelLicencia.ForeColor = System.Drawing.Color.Red;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        labelLicencia.Text = "Licencia de Uso hasta el " + Program.VigenciaLicencia.ToString("dd/MM/yyyy") +
                                            ".";
                        if ((Program.VigenciaLicencia - new WS.Service().HoraActual(Program.Pin)).Days < 11)
                        {
                            labelLicencia.ForeColor = System.Drawing.Color.Red;
                            timer1.Enabled = true;
                        }
                    }
                }
            }
        }

        private void ButtonCerrarClick(object sender, EventArgs e)
        {
            timer1.Stop();
            Close();
        }

        private void Timer1Tick(object sender, EventArgs e)
        {
            labelLicencia.Visible = !labelLicencia.Visible;
        }
    }
}
using System;
using System.Deployment.Application;
using System.Windows.Forms;

namespace Dirección
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
                labelVersion.Text = Resources.FormAbout_Form_About_Load_Versión__ + ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
            else
            {
                labelVersion.Text = Resources.FormAbout_Form_About_Load_Versión__A_definir_;
            }
            if (!Program.TieneLicencia)
            {
                labelLicencia.Text = Resources.FormAbout_FormAboutLoad_No_tiene_Licencia_de_Uso_;
                labelLicencia.ForeColor = System.Drawing.Color.Red;
                timer1.Enabled = true;
            }
            else
            {
                if (Program.VigenciaLicencia.Year>=3000)
                {
                    labelLicencia.Text = Resources.FormAbout_FormAboutLoad_Licencia_de_Uso_Ilimitada_;
                }
                else
                {
                    if (Program.VigenciaLicencia.Year <= 1947)
                    {
                        labelLicencia.Text = Resources.FormAbout_FormAboutLoad_Licencia_inválida;
                        labelLicencia.ForeColor = System.Drawing.Color.Red;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        labelLicencia.Text = Resources.FormAbout_FormAboutLoad_Licencia_de_Uso_hasta_el_ + Program.VigenciaLicencia.ToString("dd/MM/yyyy") +
                                            Resources.Punto;
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
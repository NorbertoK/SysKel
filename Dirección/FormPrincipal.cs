using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dirección.WS;
using Dirección.Properties;

namespace Dirección
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipalLoad(object sender, EventArgs e)
        {
            var empresa = Settings.Default.Empresa == "CEC" ? "C E C" : Settings.Default.Empresa;
            Text = Resources.FormPrincipal_FormPrincipalLoad_SysKel + Resources.FormPrincipal_FormPrincipal_Load_Guion +
                   empresa + Resources.FormLogin_FormLoginLoad_Dirección;
            if (Program.IdUsuario != 0)
            {
                var nombreUsuario = new Service().NombreDelUsuario(Program.IdUsuario, Program.Pin);
                if (nombreUsuario.Length != 0)
                {
                    Text = Text + Resources.FormPrincipal_FormPrincipal_Load_Guion + nombreUsuario;
                }
            }

            // Aquí empieza a cambiar el color del fondo.
            foreach (Control ctl in Controls)
            {
                try
                {
                    var ctlMdi = (MdiClient) ctl;
                    ctlMdi.BackColor = BackColor;
                }
                catch (InvalidCastException)
                {
                }
            }
            dsLicencia.Merge(new Service().GetLicencia(Settings.Default.Empresa, Program.Pin));
            if (dsLicencia.Licencias.Rows.Count == 0)
            {
                Program.TieneLicencia = false;
            }
            else
            {
                Program.TieneLicencia = true;
                Program.VigenciaLicencia = Encriptacion.FechaVigencia(dsLicencia.Licencias.Rows[0]["Licencia"].ToString());
            }
            backgroundWorker1.RunWorkerAsync();
            if (Program.TieneLicencia &&
                (Program.VigenciaLicencia - new Service().HoraActual(Program.Pin)).Days >= 11)
                return;
            var formAbout = new FormAbout { StartPosition = FormStartPosition.CenterScreen };
            formAbout.ShowDialog();
        }

        private void CrearFormularioHijo(Form f)
        {
            // a flag to store if the child form is opened or not
            var found = false;

            // get all of the MDI children in an array
            var charr = MdiChildren;

            if (charr.Length == 0) // no child form is opened
            {
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(0, 0);
                f.Show();
            }
            else // child forms are opened
            {
                foreach (var chform in charr)
                {
                    if (chform.Name != f.Name) continue;
                    chform.Activate();
                    found = true;
                    break; // exit loop
                    // false if the form is not found
                }

                if (found == false)
                {
                    f.MdiParent = this;
                    f.StartPosition = FormStartPosition.Manual;
                    f.Location = new Point(0, 0);
                    f.Show();
                }
                else f.Close();
            }
        }

        private void AyudaDeCentauroToolStripMenuItemClick(object sender, EventArgs e)
        {
            Process.Start(helpProvider1.HelpNamespace);
        }

        private void FormPrincipalFormClosing(object sender, FormClosingEventArgs e)
        {
            if (MdiChildren.Length <= 0) return;
            MessageBox.Show(Resources.FormPrincipal_FormPrincipal_FormClosing_Debe_cerrar_todas_las_ventanas, Resources.FormPrincipal_FormPrincipal_FormClosing_El_programa_no_puede_terminar, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            e.Cancel = true;
        }
        private void CambiarLaContraseñaToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormCambioDeClave());
        }

        private void EstadoDeLaCobranzaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportEstadoDeLaCobranza());
        }

        private void DeudoresToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportDeudores());
        }

        private void ListadoDeNotasDeCréditoToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteNdeC());
        }

        private void ComprobantesQueTieneUnCobradorToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteComprobantesQueTieneUnCobrador());
        }
 
        private void RetiroDeValoresToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRetiro());
        }

        private void ReintegroDeToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReintegro());
        }

 
        private void PlanillaDeCajaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormCaja());
        }

        private void ValoresExistentesEnCadaCajaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRepCajas());
        }

        private void BackgroundWorker1DoWork(object sender, DoWorkEventArgs e)
        {
            if (!Encriptacion.TieneLicenciaVigente()) return;
            dsBarrios.Merge(new Service().GetBarriosLista(Program.Pin));
            backgroundWorker1.ReportProgress(1);
            dsCallesLista.Merge(new Service().GetCallesLista(Program.Pin));
            backgroundWorker1.ReportProgress(2);
            dsCategoriasIVA.Merge(new Service().GetCategoriasIva(Program.Pin));
            backgroundWorker1.ReportProgress(3);
            dsCodigos.Merge(new Service().GetCodigos(Program.Pin));
            backgroundWorker1.ReportProgress(4);
            dscuitRepetibles.Merge(new Service().GetCUITRepetibles(Program.Pin));
            backgroundWorker1.ReportProgress(5);
            dsEntidadesDeCobranza.Merge(new Service().GetEntidadesDeCobranza(Program.Pin));
            backgroundWorker1.ReportProgress(6);
            dsLocalidadesLista.Merge(new Service().GetLocalidadesLista(Program.Pin));
            backgroundWorker1.ReportProgress(7);
            dsLugares.Merge(new Service().GetLugares(Program.Pin));
            backgroundWorker1.ReportProgress(8);
            dsMedicosDeCabecera.Merge(new Service().GetMedicosDeCabeceraLista(Program.Pin));
            backgroundWorker1.ReportProgress(9);
            dsMotivosDeBaja.Merge(new Service().GetMotivosDeBaja(Program.Pin));
            backgroundWorker1.ReportProgress(10);
            dsOcupaciones.Merge(new Service().GetOcupaciones(Program.Pin));
            backgroundWorker1.ReportProgress(11);
            dsPlanes.Merge(new Service().GetPlanes(Program.Pin));
            backgroundWorker1.ReportProgress(12);
            dsPrepagos.Merge(new Service().GetPrepagos(Program.Pin));
            backgroundWorker1.ReportProgress(13);
            dsSistemas.Merge(new Service().GetSistemas(Program.Pin));
            backgroundWorker1.ReportProgress(14);
            dsTandasDeFacturacion.Merge(new Service().GetTandasDeFacturacion(Program.Pin));
            backgroundWorker1.ReportProgress(15);
            dsTiposDeCliente.Merge(new Service().GetTiposDeCliente(Program.Pin));
            backgroundWorker1.ReportProgress(16);
            dsTiposDeCobranza.Merge(new Service().GetTiposDeCobranza(Program.Pin));
            backgroundWorker1.ReportProgress(17);
            dsTiposDeContrato.Merge(new Service().GetTiposDeContrato(Program.Pin));
            backgroundWorker1.ReportProgress(18);
            dsTiposDeDocumento.Merge(new Service().GetTiposDeDocumento(Program.Pin));
            backgroundWorker1.ReportProgress(19);
            dsEmpleadosLista.Merge(new Service().GetEmpleadosLista(Program.Pin));
            backgroundWorker1.ReportProgress(20);
            dsVendedores.Merge(new Service().GetVendedores(Program.Pin));
            backgroundWorker1.ReportProgress(21);
            dsZonas.Merge(new Service().GetZonas(Program.Pin));
            backgroundWorker1.ReportProgress(22);
            dsAutorizacionesDelUsuario.Merge(new Service().GetAutorizacionesDelUsuario(Program.Usu, Program.Pin));
            backgroundWorker1.ReportProgress(23);
            dsUsuariosLista.Merge(new Service().GetUsuariosLista(Program.Pin));
            backgroundWorker1.ReportProgress(24);
        }

        private void BackgroundWorker1ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker1RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Comienzan las autorizaciones a los menúes.
            if (Encriptacion.TieneLicenciaVigente())
            {
                if (Settings.Default.Empresa == "CEC")
                {
                    var cli1 =
                        (dsEmpleadosLista.EmpleadosLista.AsEnumerable().Where(n => n.Field<int>("idEmpleado") == 11)).
                            SingleOrDefault();
                    var cli2 =
                        (dsEmpleadosLista.EmpleadosLista.AsEnumerable().Where(n => n.Field<int>("idEmpleado") == 14)).
                            SingleOrDefault();
                    if (cli1 == null || !cli1.Field<string>("ApelNomb").StartsWith("Alm") || cli2 == null ||
                        !cli2.Field<string>("ApelNomb").StartsWith("Nin"))
                    {
                        var f = new FormSinLicencia {StartPosition = FormStartPosition.CenterParent};
                        f.ShowDialog();
                        Close();
                    }
                }
            }
            menuStrip1.Refresh();
            labelEspere.Visible = false;
            progressBar1.Visible = false;
            menuStrip1.Enabled = true;
        }


        private void BajasAutomáticasToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteBajasAutomaticas());
        }

        private void CantidadDeAfiliadosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteEstadisticaCantidadDeAfiliados());
        }

        private void ConstituciónDeLosPlanesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteEstadisticaPlanes());
        }

        private void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
        {
            var f = new FormAbout { StartPosition = FormStartPosition.CenterScreen };
            f.ShowDialog();
        }

        private void PrestacionesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormEstPrest());
        }

        private void TasaDeUsoToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTasaDeUso());
        }
    }
}
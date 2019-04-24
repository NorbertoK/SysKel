using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Cabina.Properties;
using Cabina.WS;

namespace Cabina
{
    public partial class FormPrincipalCabina : Form
    {
        public FormPrincipalCabina()
        {
            InitializeComponent();
        }

        private void FormPrincipalCabinaLoad(object sender, EventArgs e)
        {
            var empresa = Settings.Default.Empresa == "CEC" ? "C E C" : Settings.Default.Empresa;
            Text = "SysKel" + " - " + empresa +
                   " - Cabina";
            if (Program.IdUsuario != 0)
            {
                var nombreUsuario = new Service().NombreDelUsuario(Program.IdUsuario, Program.Pin);
                if (nombreUsuario.Length != 0)
                {
                    Text = Text + " - " + nombreUsuario;
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
            if (empresa == "activa")
                BackgroundImage = Resources.Fondo_activa;
            if (empresa == "SAE")
                BackgroundImage = Resources.Fondo_SAE;
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
            if (Program.TieneLicencia && (Program.VigenciaLicencia - new Service().HoraActual(Program.Pin)).Days >= 11)
                return;
            var formAbout = new FormAbout {StartPosition = FormStartPosition.CenterScreen};
            formAbout.ShowDialog();
        }

        private void FormPrincipalCabinaFormClosing(object sender, FormClosingEventArgs e)
        {
            if (MdiChildren.Length <= 0) return;
            MessageBox.Show("Debe cerrar todas las ventanas",
                            "El programa no puede terminar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            e.Cancel = true;
        }

        private void BackgroundWorker1DoWork(object sender, DoWorkEventArgs e)
        {
            //Esto lo comento para que Cabina funcione aunque no me paguen.
            //if (!Encriptacion.TieneLicenciaVigente()) return;

            #region Carga de Datasets

            dsAutorizacionesDelUsuario.Merge(new Service().GetAutorizacionesDelUsuario(Program.Usu, Program.Pin));
            dsBarrios.Merge(new Service().GetBarriosLista(Program.Pin));
            backgroundWorker1.ReportProgress(1);
            dsCallesLista.Merge(new Service().GetCallesLista(Program.Pin));
            backgroundWorker1.ReportProgress(2);
            dsClientesLista.Merge(new Service().GetClientesLista(Program.Pin));
            backgroundWorker1.ReportProgress(3);
            dsCoberturas.Merge(new Service().GetCoberturas(Program.Pin));
            backgroundWorker1.ReportProgress(4);
            dsCodigos.Merge(new Service().GetCodigos(Program.Pin));
            dsEmpleadosLista.Merge(new Service().GetEmpleadosLista(Program.Pin));
            backgroundWorker1.ReportProgress(5);
            dsContratosLista.Merge(new Service().GetContratosListaNoBaja(Program.Pin));
            dsEntidadesDeCobranza.Merge(new Service().GetEntidadesDeCobranza(Program.Pin));
            backgroundWorker1.ReportProgress(6);
            dsLocalidades1.Merge(new Service().GetLocalidades(Program.Pin));
            dsLocalidadesLista.Merge(new Service().GetLocalidadesLista(Program.Pin));
            backgroundWorker1.ReportProgress(7);
            dsLugares.Merge(new Service().GetLugares(Program.Pin));
            dsLugaresLista.Merge(new Service().GetLugaresLista(Program.Pin));
            backgroundWorker1.ReportProgress(8);
            dsMotivosDeCancelacionPrestacion.Merge(
                new Service().GetMotivosDeCancelacionPrestacion(Program.Pin));
            dsMedicosDeCabecera.Merge(new Service().GetMedicosDeCabeceraLista(Program.Pin));
            backgroundWorker1.ReportProgress(9);
            dsMotivosDeLlamado.Merge(new Service().GetMotivosDeLlamado(Program.Pin));
            dsMotivosDeBaja.Merge(new Service().GetMotivosDeBaja(Program.Pin));
            backgroundWorker1.ReportProgress(10);
            dsOcupaciones.Merge(new Service().GetOcupaciones(Program.Pin));
            dsPracticas.Merge(new Service().GetPracticas(Program.Pin));
            backgroundWorker1.ReportProgress(11);
            dsPrepagos.Merge(new Service().GetPrepagos(Program.Pin));
            dsProveedores1.Merge(new Service().GetProveedoresActivos(Program.Pin));
            backgroundWorker1.ReportProgress(12);
            dsSistemas.Merge(new Service().GetSistemas(Program.Pin));
            backgroundWorker1.ReportProgress(13);
            dsTiposDeCliente.Merge(new Service().GetTiposDeCliente(Program.Pin));
            backgroundWorker1.ReportProgress(14);
            dsTiposDeDestino.Merge(new Service().GetTiposDeDestino(Program.Pin));
            dsTiposDeDocumento.Merge(new Service().GetTiposDeDocumento(Program.Pin));
            dsTiposDeCobranza.Merge(new Service().GetTiposDeCobranza(Program.Pin));
            dsUsuariosLista.Merge(new Service().GetUsuariosLista(Program.Pin));
            dsVendedores.Merge(new Service().GetVendedores(Program.Pin));
            backgroundWorker1.ReportProgress(15);
            dsDiagnosticos.Merge(new Service().GetDiagnosticos(Program.Pin));
            backgroundWorker1.ReportProgress(16);
            dsMedicamentos.Merge(new Service().GetMedicamentos(Program.Pin));
            dsZonas.Merge(new Service().GetZonas(Program.Pin));
            backgroundWorker1.ReportProgress(17);

            #endregion
        }

        private void BackgroundWorker1RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //if (Encriptacion.TieneLicenciaVigente())
            {
                #region Autorizaciones

                dsAutorizacionesDelUsuario.Merge(new Service().GetAutorizacionesDelUsuario(Program.Usu, Program.Pin));
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0002") != null)
                {
                    accionesToolStripMenuItem.Visible = true;
                    tomarUnLlamadoToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0003") != null)
                {
                    accionesToolStripMenuItem.Visible = true;
                    prestacionesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0004") != null)
                {
                    accionesToolStripMenuItem.Visible = true;
                    recursosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0007") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    prácticasToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0009") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    motivosDeCancelaciónDePrestacionesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0010") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    motivosDeLlamadoToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0011") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    diagnósticosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0012") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    medicamentosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0013") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    tiposDeMóvilesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0014") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    móvilesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0015") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    empleadosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0016") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    lugaresToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0017") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    coberturasToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0018") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    prepagosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0019") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    tiposDeDestinoToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0020") != null)
                {
                    prestacionesAnterioresToolStripMenuItem.Visible = true;
                    verToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0021") != null)
                {
                    prestacionesAnterioresToolStripMenuItem.Visible = true;
                    modificarToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0022") != null)
                {
                    accionesToolStripMenuItem.Visible = true;
                    monitorizarElDespachoToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0023") != null)
                {
                    prestacionesAnterioresToolStripMenuItem.Visible = true;
                    listarToolStripMenuItem.Visible = true;
                    listarPrestacionesDeUnClienteToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0024") != null)
                {
                    accionesToolStripMenuItem.Visible = true;
                    cajaToolStripMenuItem.Visible = true;
                    proveedoresToolStripMenuItem.Visible = true;
                }
                //if (Program.Usu == "Administrador" ||
                //    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0025") != null)
                //{
                //    accionesToolStripMenuItem.Visible = true;
                //    cajaToolStripMenuItem.Visible = true;
                //    compraToolStripMenuItem.Visible = true;
                //}
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0026") != null)
                {
                    accionesToolStripMenuItem.Visible = true;
                    cajaToolStripMenuItem.Visible = true;
                    transferenciaDeValoresToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0027") != null)
                {
                    accionesToolStripMenuItem.Visible = true;
                    cajaToolStripMenuItem.Visible = true;
                    planillaDeCajaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0028") != null)
                {
                    prestacionesAnterioresToolStripMenuItem.Visible = true;
                    contarToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0029") != null)
                {
                    prestacionesAnterioresToolStripMenuItem.Visible = true;
                    completarDiagnósticosYMedicamentosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0030") != null)
                {
                    accionesToolStripMenuItem.Visible = true;
                    tomarProgramadoToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0031") != null)
                {
                    accionesToolStripMenuItem.Visible = true;
                    consultorioToolStripMenuItem.Visible = true;
                    feriadosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0032") != null)
                {
                    accionesToolStripMenuItem.Visible = true;
                    consultorioToolStripMenuItem.Visible = true;
                    moldesDeTurnosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0033") != null)
                {
                    accionesToolStripMenuItem.Visible = true;
                    consultorioToolStripMenuItem.Visible = true;
                    generarTurnosVacíosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0034") != null)
                {
                    accionesToolStripMenuItem.Visible = true;
                    consultorioToolStripMenuItem.Visible = true;
                    darTurnosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0035") != null)
                {
                    accionesToolStripMenuItem.Visible = true;
                    consultorioToolStripMenuItem.Visible = true;
                    recibirPacientesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0036") != null)
                {
                    accionesToolStripMenuItem.Visible = true;
                    consultorioToolStripMenuItem.Visible = true;
                    atenderPacientesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0037") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    consultorioToolStripMenuItem1.Visible = true;
                    turnosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MC-0038") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    reasignarEspecialidadesToolStripMenuItem.Visible = true;
                }
                #endregion
            }
            menuStrip1.Refresh();
            labelEspere.Visible = false;
            progressBar1.Visible = false;
            menuStrip1.Enabled = true;
        }

        private void BackgroundWorker1ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        #region Crear Formularios

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
                foreach (var chform in charr.Where(chform => chform.Name == f.Name))
                {
                    chform.Activate();
                    found = true;
                    break; // exit loop
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

        private void CrearFormularioHijo(Form f, string tag)
        {
            // a flag to store if the child form is opened or not
            var found = false;

            // get all of the MDI children in an array
            var charr = MdiChildren;

            if (charr.Length == 0) // no child form is opened
            {
                f.MdiParent = this;
                f.Tag = tag;
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(0, 0);
                f.Show();
            }
            else // child forms are opened
            {
                foreach (var chform in charr.Where(chform => chform.Name == f.Name))
                {
                    chform.Activate();
                    found = true;
                    break; // exit loop
                }

                if (found == false)
                {
                    f.MdiParent = this;
                    f.Tag = tag;
                    f.StartPosition = FormStartPosition.Manual;
                    f.Location = new Point(0, 0);
                    f.Show();
                }
                else f.Close();
            }
        }

        private void PrácticasToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCPracticas());
        }

        private void MotivosDeCancelaciónDePrestacionesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCMotivosDeCancelacionPrestacion());
        }

        private void MotivosDeLlamadoToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCMotivosDeLlamado());
        }

        private void DiagnósticosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCDiagnosticos());
        }

        private void MedicamentosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCMedicamentos());
        }

        private void TiposDeMóvilesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCTiposDeMovil());
        }

        private void MóvilesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCMoviles());
        }

        private void RecursosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCRecursos());
        }

        private void EmpleadosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCEmpleados());
        }

        private void LugaresToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCLugares());
        }

        private void CoberturasToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCCoberturas());
        }

        private void PrepagosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCPrepagos());
        }

        private void TiposDeDestinoToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCTiposDeDestino());
        }

        private void TomarUnLlamadoToolStripMenuItemClick(object sender, EventArgs e)
        {
            var formTomarLlamado = new FormTomarLlamado
                                       {
                                           MdiParent = this,
                                           StartPosition = FormStartPosition.Manual,
                                           Location = new Point(0, 0)
                                       };
            formTomarLlamado.Show();
        }

        private void PrestacionesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormDespacho());
        }

        private void CambiarLaContraseñaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormCambioDeClave());
        }

        private void VerToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormBuscarPrestaciones(), "V");
        }

        private void ModificarToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormBuscarPrestaciones(), "M");
        }

        private void MonitorizarElDespachoToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormDespacho(), "M");
        }

        private void AyudaCentauroToolStripMenuItemClick(object sender, EventArgs e)
        {
            Process.Start(helpProvider1.HelpNamespace);
        }

        private void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
        {
            //var charr = MdiChildren;
            //if (charr.Length != 0) return;
            var f = new FormAbout {StartPosition = FormStartPosition.CenterScreen};
            f.ShowDialog();
        }

        private void ListarToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormBuscarPrestaciones(), "L");
        }

        private void ContarToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormBuscarPrestaciones(), "C");
        }

        private void ProveedoresToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCProveedores());
        }

        private void CompraToolStripMenuItemClick(object sender, EventArgs e)
        {
            //CrearFormularioHijo(new FormCompra());
        }

        private void TransferenciaDeValoresToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormTransferencia());
        }

        private void PlanillaDeCajaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormCaja());
        }

        private void CompletarDiagnósticosYMedicamentosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormPacientesIncompletos());
        }

        private void TomarProgramadoToolStripMenuItemClick(object sender, EventArgs e)
        {
            var formTomarProgramado = new FormTomarProgramado
                                          {
                                              MdiParent = this,
                                              StartPosition = FormStartPosition.Manual,
                                              Location = new Point(0, 0)
                                          };
            formTomarProgramado.Show();
        }

        private void FeriadosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCFeriados());
        }

        private void MoldesDeTurnosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormMoldesDeTurnos());
        }

        private void GenerarTurnosVacíosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormGenerarTurnos());
        }

        private void DarTurnosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormDarTurnos());
        }

        private void RecibirPacientesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRecibirPacientes());
        }

        private void AtenderPacientesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormAtenderPacientes());
        }

        private void TurnosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportTurnosImprimir());
        }
        private void ReasignarEspecialidadesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReasignarEspecialidades());
        }
        private void listarPrestacionesDeUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormPrestacionesDeClientes());
        }
        #endregion
    }
}
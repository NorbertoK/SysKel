using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Administración.Properties;
using Administración.WS;

namespace Administración
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
            Text = "SysKel" + " - " +
                   empresa + " - Administración";
            if (Program.IdUsuario != 0)
            {
                var nombreUsuario = new Service().NombreDelUsuario(Program.IdUsuario, Program.Pin);
                if (nombreUsuario.Length != 0)
                    Text = Text + " - " + nombreUsuario;
            }

            // Aquí empieza a cambiar el color del fondo.
            foreach (Control ctl in Controls)
                try
                {
                    var ctlMdi = (MdiClient) ctl;
                    ctlMdi.BackColor = BackColor;
                }
                catch (InvalidCastException)
                {
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
                Program.VigenciaLicencia =
                    Encriptacion.FechaVigencia(dsLicencia.Licencias.Rows[0]["Licencia"].ToString());
            }
            backgroundWorker1.RunWorkerAsync();
            if (Program.TieneLicencia &&
                (Program.VigenciaLicencia - new Service().HoraActual(Program.Pin)).Days >= 11)
                return;
            var formAbout = new FormAbout {StartPosition = FormStartPosition.CenterScreen};
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
                else
                {
                    f.Close();
                }
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
                    f.Tag = tag;
                    f.StartPosition = FormStartPosition.Manual;
                    f.Location = new Point(0, 0);
                    f.Show();
                }
                else
                {
                    f.Close();
                }
            }
        }

        private void PrestadoresToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCPrestadores());
        }

        private void TerritoriosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCTerritorios());
        }

        private void TiposDeClienteToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCTiposDeCliente());
        }

        private void EntidadesDeCobranzaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCEntidadesDeCobranza());
        }

        private void CatgoríasDeIvaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCCategoriasIVA());
        }

        private void ZonasToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCZonas());
        }

        private void EmpleadosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCEmpleados());
        }

        private void MotivosDeBajaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCMotivosDeBaja());
        }

        private void PrepagosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCPrepagos());
        }

        private void LugaresToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCLugares());
        }

        private void PlanesPropiosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCPlanesPropios());
        }

        private void DeContratosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormPlanesContratos());
        }

        private void TiposDeComprobanteToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCTiposDeComprobante());
        }

        private void PuntosDeVentaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCPuntosDeVenta());
        }

        private void TiposDeValoresToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCTiposDeValores());
        }

        private void AfiliadosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCGrupos());
        }

        private void FacturaciónMensualToolStripMenuItemClick(object sender, EventArgs e)
        {
            var dr =
                MessageBox.Show(
                    "" +
                    Environment.NewLine +
                    "hay que hacerlo antes de facturar." +
                    Environment.NewLine + Environment.NewLine +
                    "¿Ya está en condiciones de facturar?",
                    "Recuerde", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                CrearFormularioHijo(new FormFacturacionMensualAfiliados());
        }

        private void RemesaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRemesa());
        }

        private void ParametrosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCParametros());
        }

        private void TiposDeDocumentoToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCTiposDeDocumento());
        }

        private void CódigosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCCodigos());
        }

        private void MotivosDeDevoluciónDeCobranzaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCMotivosDevolucionCobranza());
        }

        private void ArqueoToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormArqueo());
        }

        private void CambioDeGrupoToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormCambioDeGrupo());
        }

        private void AgregarNuevoUsuarioToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormNuevoUsuario());
        }

        private void TiposDeAutorizaciónToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCTiposDeAutorizacion());
        }

        private void AutorizacionesToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCAutorizaciones());
        }

        private void PuestosToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCPuestos());
        }

        private void AutorizacionesDelPuestoToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCAutorizacionesDelPuesto());
        }

        private void PuestosDeLoToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCPuestosDelUsuario());
        }

        private void UsuariosEmpleadoActivoToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCUsuarios());
        }

        private void CambiarLaContraseñaToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormCambioDeClave());
        }

        private void RestaurarContraseñaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRestaurarClave());
        }

        private void SistemasToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCSistemas());
        }

        private void BancosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCBancos());
        }

        private void MédicosDeCabeceraToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCMedicosDeCabecera());
        }

        private void OcupacionesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCOcupaciones());
        }

        private void DireccionesSinZonaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormProviDireccionesSinZona());
        }

        private void RenglonesAFacturarToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRepRenglonesAFacturar());
        }

        private void CantidadDeAfiliadosPorPlanToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportCantidadAfiliadosPorPlan());
        }

        private void InformeFacturasDeClientesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteFacturasDeClientes());
        }


        private void AfiliadosSinPlanToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormProviRepSinPlan());
        }

        private void PrestacionesToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormEstPrest());
        }

        private void PadrónDeAfiliadosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportePadron());
        }

        private void ListadoPorPlanToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteListadoPorPlan());
        }

        private void AfiliadosNoUnTitularToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRepAfiliadosNoUnTitular());
        }

        private void DarDeBajaAMorososToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormBajasAutomaticas());
        }

        private void CambioDeCobradorAComprobantesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormCambioDeCobrador());
        }

        private void CambiosDeCobradorAnterioresToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormCambioCobradorAnteriorImprimir());
        }

        private void TandasDeFacturaciónToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCTandasDeFacturacion());
        }

        private void AltasBajasModificacionesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCClientes());
        }

        private void FacturaciónMensualToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormFacturacionMensualClientes());
        }

        private void NotaDeCréditoToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormNdeCCliente {Tipo = "NdeC"});
        }
        private void NotaDeDébitoToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormNdeCCliente {Tipo = "NdeD"});
        }
        private void NotaDeCréditoToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormNdeCGrupo());
        }

        private void VaVentasAfiliadosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportIVAVentasAfiliados());
        }

        private void AyudaDeCentauroToolStripMenuItemClick(object sender, EventArgs e)
        {
            Process.Start(helpProvider1.HelpNamespace);
        }

        private void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
        {
            var f = new FormAbout {StartPosition = FormStartPosition.CenterScreen};
            f.ShowDialog();
        }

        private void FormPrincipalFormClosing(object sender, FormClosingEventArgs e)
        {
            if (MdiChildren.Length <= 0) return;
            MessageBox.Show("Debe cerrar todas las ventanas.",
                "El programa no puede terminar", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            e.Cancel = true;
        }

        private void CUiTsQueSePuedenRepetirToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormAbccuitRepetibles());
        }

        private void ArqueosAnterioresToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormArqueoAnteriorImprimir());
        }

        private void RendicionesAnterioresToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRemesaAnteriorImprimir());
        }

        private void AfiliadosPorEntidadDeCobranzaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportAfiliadosPorEntidadDeCobranza());
        }

        private void ASeToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormPadronAse());
        }

        private void MoldesDeFacturaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRenglonesFP());
        }

        private void SelecciónDeAfiliadosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportesAfiliados());
        }

        private void SelecciónDeClientesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportesClientes());
        }

        private void FacturacionesRealizadasToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormFacturaciones());
        }

        private void VIsaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteVisa());
        }

        private void FacturaciónManualToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormFacturacionManualAfiliados());
        }

        private void KadicardToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteKadicard());
        }

        private void TarjetaNaranjaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteNaranja());
        }

        private void VentasToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteInformeVentas());
        }

        private void ListadoDeLoFacturadoPorEntidadDeCobranzaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteFacturadoPorEntidad());
        }

        private void CobranzaDeAfiliadosEnMostradorToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormCobrarEnMostrador());
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

        private void CobranzaDeClientesEnMostradorToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormCobrarEnMostradorCli());
        }

        private void ProveedoresToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCProveedores());
        }

        private void CompraToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormCompra());
        }

        private void TransferenciaDeValoresToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormTransferencia());
        }

        private void RetiroDeValoresToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRetiro());
        }

        private void ReintegroDeToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReintegro());
        }

        private void AsignarCobradorToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormAsignarCobradorAPrestaciones());
        }

        private void NotaDeCréditoToolStripMenuItem2Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormNdeCPrestacion());
        }

        private void CobranzaDePrestacionesEnMostradorToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormCobrarEnMostradorPrest());
        }

        private void PlanillaDeCajaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormCaja());
        }

        private void ValoresExistentesEnCadaCajaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRepCajas());
        }

        private void PuestosAutorizadosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRepPuestosAutorizados());
        }

        private void FacturarPeríodosFuturosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormFacturacionManualClientes());
        }

        private void ProteccionesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCProtecciones());
        }
        private void BancosToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Bancos");
        }

        private void CódigosToolStripMenuItemClick1(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Códigos");
        }

        private void CUiTsRepetiblesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "CUITs Repetibles");
        }

        private void DiagnósticosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Diagnósticos");
        }

        private void EmpleadosToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Empleados");
        }

        private void EntidadesDeCobranzaToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Entidades de Cobranza");
        }

        private void LugaresToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Lugares");
        }

        private void MedicamentosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Medicamentos");
        }

        private void MédicosDeCabeceraToolStripMenuItemClick1(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Médicos de Cabecera");
        }

        private void MotivosDeCancelaciónDeLaPrestaciónToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Motivos de Cancelación de la Prestación");
        }

        private void MotivosDeBajaToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Motivos de Baja");
        }

        private void MotivosDeLlamadoToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Motivos de Llamado");
        }

        private void MóvilesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Móviles");
        }

        private void OcupacionesToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Ocupaciones");
        }

        private void PlanesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Planes");
        }

        private void PrácticasToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Prácticas");
        }

        private void PrepagosToolStripMenuItemClick1(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Prepagos");
        }

        private void PrestadoresToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Prestadores");
        }

        private void ProveedoresToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Proveedores");
        }

        private void PuestosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Puestos");
        }

        private void RubrosToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Rubros");
        }

        private void TerritoriosToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Territorios");
        }

        private void TiposDeDestinoToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Tipos de Destino");
        }

        private void TiposDeMóvilToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Tipos de Móvil");
        }

        private void TiposDeValoresToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Tipos de Valores");
        }

        private void UsuariosToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "_usuarios");
        }

        private void ZonasToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Zonas");
        }

        private void CoberturasToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteTabla(), "Coberturas");
        }

        private void EntregarFacturaciónToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormEntregarFacturacion());
        }

        private void BajasAutomáticasToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteBajasAutomaticas());
        }

        private void DatosDeLasPrestacionesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteDatosPrestaciones());
        }

        private void LiquidaciónDeEntidadesDeCobranzaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormLiquidacionEntidad());
        }

        private void LiquidacionesAnterioresDeEntidadesDeCobranzaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteLiquidacionEntidad());
        }

        private void CantidadDeAfiliadosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteEstadisticaCantidadDeAfiliados());
        }

        private void ConstituciónDeLosPlanesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteEstadisticaPlanes());
        }

        private void IngresoDeValoresACajaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRemesaIngresoValores());
        }

        private void EntidadesDeCobranzaSinLiquidarToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRepEntidadesSinLiquidar());
        }

        private void IngresarNuevaLicenciaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormLicencia());
        }

        private void ImportarPadrónToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormImportarPadron());
        }

        private void NotaDeDébitoToolStripMenuItemClick(object sender, EventArgs e)
        {
            //CrearFormularioHijo(new FormNdeDGrupo());
            MessageBox.Show(@"En proceso de programación.", @"Mensaje", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        private void NotaDeDébitoToolStripMenuItem2Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormNdeDPrestacion());
        }

        private void PrestacionesPorClienteToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportPrestacionesPorCliente());
        }

        private void RubrosToolStripMenuItem2Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCRubros());
        }

        private void NegociosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCNegocios());
        }

        private void PagarComprasToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormPagarCompras());
        }

        private void TotalesPorRubrosYNegociosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteRubrosYNegocios());
        }

        private void CopagosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCCopagos());
        }

        private void RenombrarYAnularFacturasToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormCambiarNumeroFacturas());
        }

        private void RenglonesDeFacturaToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportHistRenglonesMoldesFactutra());
        }

        private void PlanesToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportHistPlanes());
        }

        private void RecursosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportHistRecursos());
        }

        private void BancoMacroToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteBancoMacro());
        }

        private void FacturadoAClientesToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormEstadisticaFacturadoClientes());
        }

        private void FeriadosToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCFeriados());
        }

        private void EmpresasSueldoBancoMacroToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormABCEmpresasSueldoBancoMacro());
        }

        private void ArgencardToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReporteArgencard());
        }

        private void aClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormFacturaManual{Tipo = "Factura"});
        }

        private void aNoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormFacturaTotalmenteManual());
        }

        private void cuponesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormImprimirCupones());
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormImprimirCuponesClientes());
        }

        private void constanciasDeAfiliaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormImprimirConstancias());
        }

        private void facturadoAClientesPorNegocioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportFacturadoYCobrado());
        }

        private void facturaElectrónicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormFacturaElectronica());
        }

        private void listadoFacturasSinCAEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRepFacturasSinCAE());
        }

        private void exportarImpresiónDeFacturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormExportarFacturas());
        }

        private void deLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportTasaDeUsoClientes());
        }

        private void comparaciónClientesAfiliadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReportTasaDeUsoAfYCli());
        }

        private void aumentosAutomáticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormAumentoAClientes());
        }

        private void importarRespuestaSolicitudesDeCAEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormImportarRespuestaWilly());
        }
        private void BackgroundWorker1DoWork(object sender, DoWorkEventArgs e)
        {
            if (!Encriptacion.TieneLicenciaVigente()) return;
            dsBarrios.Merge(new Service().GetBarriosLista(Program.Pin));
            backgroundWorker1.ReportProgress(1);
            dsCallesLista.Merge(new Service().GetCallesLista(Program.Pin));
            dsEmpresasSueldoBancoMacro.Merge(new Service().GetEmpresasSueldoBancoMacro(Program.Pin));
            backgroundWorker1.ReportProgress(2);
            dsCategoriasIVA.Merge(new Service().GetCategoriasIva(Program.Pin));
            backgroundWorker1.ReportProgress(3);
            dsCodigos.Merge(new Service().GetCodigos(Program.Pin));
            backgroundWorker1.ReportProgress(4);
            dscuitRepetibles.Merge(new Service().GetCUITRepetibles(Program.Pin));
            dsClientesLista.Merge(new Service().GetClientesLista(Program.Pin));
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
            dsProveedores.Merge(new Service().GetProveedoresActivos(Program.Pin));
            dsRubros1.Merge(new Service().GetRubros(Program.Pin));
            dsNegocios1.Merge(new Service().GetNegocios(Program.Pin));
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
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0003") != null ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0001") != null ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0002") != null ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0005") != null ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0006") != null ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0008") != null ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0009") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    afiliadosToolStripMenuItem.Visible = true;
                    abmAfiliadosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0004") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    afiliadosToolStripMenuItem.Visible = true;
                    facturaciónMensualToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0005") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    imprimirComprobantesToolStripMenuItem.Visible = true;
                    cuponesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0006") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem1.Visible = true;
                    rendicionToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0007") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem1.Visible = true;
                    rendiciónToolStripMenuItem1.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0008") != null ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0003") != null ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0004") != null ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("TA-0007") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    clientesToolStripMenuItem.Visible = true;
                    altasBajasModificacionesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0010") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem.Visible = true;
                    rendicionesAnterioresToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0011") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem.Visible = true;
                    arqueosAnterioresToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0014") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    entidadesDeCobranzaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0015") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    rubrosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0017") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    codigosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0018") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    prestadoresToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0019") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    territoriosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0020") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    categoriasDeIVAToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0021") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    zonasToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0022") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    empleadosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0023") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    motivosDeBajaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0024") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    obrasSocialesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0025") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    lugaresToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0026") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    tablasPlanesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0027") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    tiposDeComprobanteToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0028") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    puntosDeVentaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0029") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    tiposDeValoresToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0030") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    tiposDeDocumentoToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0031") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    motivosDeDevoluciónDeCobranzaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0032") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    parametrosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" || Program.Usu == "NKelijman" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0033") != null)
                    usuariosYAutorizacionesToolStripMenuItem.Visible = true;
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0034") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    afiliadosToolStripMenuItem.Visible = true;
                    cambioDeGrupoToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0035") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    bancosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0036") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    medicosDeCabeceraToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0037") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    ocupacionesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0038") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    renglonesAFacturarToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0039") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    cantidadDeAfiliadosPorPlanToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0040") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    informeFacturasDeClientesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0041") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    imprimirComprobantesToolStripMenuItem.Visible = true;
                    constanciasDeAfiliaciónToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0042") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    estadisticaToolStripMenuItem.Visible = true;
                    prestacionesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0043") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    padrónDeAfiliadosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0044") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    integridadBaseDeDatosToolStripMenuItem.Visible = true;
                    afiliadosSinPlanToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0045") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    integridadBaseDeDatosToolStripMenuItem.Visible = true;
                    direccionesSinZonaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0046") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    listadoPorPlanToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0047") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    integridadBaseDeDatosToolStripMenuItem.Visible = true;
                    afiliadosNoUnTitularToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0048") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    afiliadosToolStripMenuItem.Visible = true;
                    darDeBajaAMorososToolStripMenuItem.Visible = true;
                }
                //if (Program.Usu == "Administrador" ||
                //    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0049") != null)
                //{
                //    reportesToolStripMenuItem.Visible = true;
                //    tesoreríaToolStripMenuItem1.Visible = true;
                //    cuentaCorrienteDeCobradoresToolStripMenuItem.Visible = true;
                //}
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0050") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem1.Visible = true;
                    cambioDeCobradorAComprobantesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0051") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem.Visible = true;
                    cambiosDeCobradorAnterioresToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0052") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    tandasDeFacturaciónToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0053") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    clientesToolStripMenuItem.Visible = true;
                    facturaciónMensualToolStripMenuItem1.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0054") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    imprimirComprobantesToolStripMenuItem.Visible = true;
                    facturasToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0055") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    clientesToolStripMenuItem.Visible = true;
                    facturaManualToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0056") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    clientesToolStripMenuItem.Visible = true;
                    notaDeCréditoToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0057") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    afiliadosToolStripMenuItem.Visible = true;
                    notaDeCréditoToolStripMenuItem1.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0058") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    iVaVentasAfiliadosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0059") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    cUiTsQueSePuedenRepetirToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0060") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    afiliadosPorEntidadDeCobranzaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0061") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    clientesToolStripMenuItem.Visible = true;
                    moldesDeFacturaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0062") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    selecciónDeAfiliadosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0063") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    selecciónDeClientesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0064") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    facturacionesRealizadasToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0065") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    débitosAutomáticosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0066") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    afiliadosToolStripMenuItem.Visible = true;
                    facturaciónManualToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0067") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    ventasToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0068") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    listadoDeLoFacturadoPorEntidadDeCobranzaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0069") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem1.Visible = true;
                    cobranzaDeAfiliadosEnMostradorToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0070") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem.Visible = true;
                    estadoDeLaCobranzaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0071") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    deudoresToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0072") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem.Visible = true;
                    listadoDeNotasDeCréditoToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0073") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem.Visible = true;
                    comprobantesQueTieneUnCobradorToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0074") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem1.Visible = true;
                    cobranzaDeClientesEnMostradorToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0075") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    comprasToolStripMenuItem.Visible = true;
                    proveedoresToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0076") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    comprasToolStripMenuItem.Visible = true;
                    compraToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0078") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem1.Visible = true;
                    transferenciaDeValoresToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0079") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    direcciónToolStripMenuItem.Visible = true;
                    retiroDeValoresToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0080") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    direcciónToolStripMenuItem.Visible = true;
                    reintegroDeToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0081") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    prestacionesToolStripMenuItem1.Visible = true;
                    asignarCobradorToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0082") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    prestacionesToolStripMenuItem1.Visible = true;
                    notaDeCréditoToolStripMenuItem2.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0083") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem1.Visible = true;
                    cobranzaDePrestacionesEnMostradorToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0084") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem.Visible = true;
                    planillaDeCajaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0085") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem.Visible = true;
                    valoresExistentesEnCadaCajaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0086") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    autorizacionesToolStripMenuItem2.Visible = true;
                    puestosAutorizadosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0087") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    clientesToolStripMenuItem.Visible = true;
                    facturarPeríodosFuturosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0088") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    proteccionesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0089") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    tablasToolStripMenuItem1.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0090") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem1.Visible = true;
                    entregarFacturaciónToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0091") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    bajasAutomáticasToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0092") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    estadisticaToolStripMenuItem.Visible = true;
                    datosDeLasPrestacionesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0093") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem1.Visible = true;
                    liquidaciónDeEntidadesDeCobranzaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0094") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem.Visible = true;
                    liquidacionesAnterioresDeEntidadesDeCobranzaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0095") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    estadisticaToolStripMenuItem.Visible = true;
                    cantidadDeAfiliadosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0096") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    estadisticaToolStripMenuItem.Visible = true;
                    constituciónDeLosPlanesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0098") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem1.Visible = true;
                    ingresoDeValoresACajaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0099") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    tesoreríaToolStripMenuItem.Visible = true;
                    entidadesDeCobranzaSinLiquidarToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0100") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    afiliadosToolStripMenuItem.Visible = true;
                    importarPadrónToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0101") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    afiliadosToolStripMenuItem.Visible = true;
                    notaDeDébitoToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0102") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    clientesToolStripMenuItem.Visible = true;
                    notaDeDébitoToolStripMenuItem1.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0103") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    prestacionesToolStripMenuItem1.Visible = true;
                    notaDeDébitoToolStripMenuItem2.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0104") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    estadisticaToolStripMenuItem.Visible = true;
                    prestacionesPorClienteToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0105") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    planDeCuentasToolStripMenuItem.Visible = true;
                    rubrosToolStripMenuItem2.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0106") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    planDeCuentasToolStripMenuItem.Visible = true;
                    negociosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0107") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    comprasToolStripMenuItem.Visible = true;
                    pagarComprasToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0108") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    totalesPorRubrosYNegociosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0109") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    copagosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0110") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem1.Visible = true;
                    exportarImpresiónDeFacturasToolStripMenuItem1.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0111") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem1.Visible = true;
                    renombrarYAnularFacturasToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0112") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    históricosToolStripMenuItem.Visible = true;
                    renglonesDeFacturaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0113") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    históricosToolStripMenuItem.Visible = true;
                    planesHistoricoToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0114") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem.Visible = true;
                    históricosToolStripMenuItem.Visible = true;
                    recursosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0115") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    estadisticaToolStripMenuItem.Visible = true;
                    facturadoAClientesToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0116") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    feriadosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0117") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    empresasSueldoBancoMacroToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0118") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    estadisticaToolStripMenuItem.Visible = true;
                    facturadoAClientesPorNegocioToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0119") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem1.Visible = true;
                    facturaElectrónicaToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-120") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    imprimirComprobantesToolStripMenuItem.Visible = true;
                    listadoFacturasSinCAEToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-121") != null)
                {
                    tablasToolStripMenuItem.Visible = true;
                    sistemasToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0122") != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                    estadisticaToolStripMenuItem.Visible = true;
                    tasaDeUsoToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0123") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    clientesToolStripMenuItem.Visible = true;
                    aumentosAutomáticosToolStripMenuItem.Visible = true;
                }
                if (Program.Usu == "Administrador" ||
                    dsAutorizacionesDelUsuario.AutorizacionesDelUsuario.FindByCodigo("MA-0124") != null)
                {
                    administracionToolStripMenuItem.Visible = true;
                    administraciónToolStripMenuItem1.Visible = true;
                    importarRespuestaSolicitudesDeCAEToolStripMenuItem.Visible = true;
                }
                if (Settings.Default.Empresa == "CEC")
                {
                    var cli1 =
                        dsEmpleadosLista.EmpleadosLista.AsEnumerable()
                            .SingleOrDefault(n => n.Field<int>("idEmpleado") == 11);
                    var cli2 =
                        dsEmpleadosLista.EmpleadosLista.AsEnumerable()
                            .SingleOrDefault(n => n.Field<int>("idEmpleado") == 14);
                    if (cli1 == null || !cli1.Field<string>("ApelNomb").StartsWith("Alm") || cli2 == null ||
                        !cli2.Field<string>("ApelNomb").StartsWith("Nin"))
                    {
                        var f = new FormSinLicencia {StartPosition = FormStartPosition.CenterParent};
                        f.ShowDialog();
                        Close();
                    }
                }
            }
            if (Program.Usu == "Administrador")
                ingresarNuevaLicenciaToolStripMenuItem.Visible = true;
            menuStrip1.Refresh();
            labelEspere.Visible = false;
            progressBar1.Visible = false;
            menuStrip1.Enabled = true;
        }
    }
}
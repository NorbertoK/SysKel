using System;
using Administración.WS;

namespace Administración
{
    public partial class FormReporteTabla : FormCR
    {
        public FormReporteTabla()
        {
            InitializeComponent();
        }

        private void FormReporteTablaLoad(object sender, EventArgs e)
        {
            Text = Tag.ToString();
            switch (Tag.ToString())
            {
                case "Bancos":
                    crystalReportViewer1.ReportSource = crTablasBancos;
                    dsBancos.Merge(new Service().GetBancos(Program.Pin));
                    crTablasBancos.SetDataSource(dsBancos);
                    break;
                case "Códigos":
                    crystalReportViewer1.ReportSource = crTablasCodigos;
                    dsCodigos.Merge(new Service().GetCodigos(Program.Pin));
                    crTablasCodigos.SetDataSource(dsCodigos);
                    break;
                case "Coberturas":
                    crystalReportViewer1.ReportSource = crTablasCoberturas;
                    dsCoberturas.Merge(new Service().GetCoberturas(Program.Pin));
                    crTablasCoberturas.SetDataSource(dsCoberturas);
                    break;
                case "CUITs Repetibles":
                    crystalReportViewer1.ReportSource = crTablasCuiTsRepetibles;
                    dscuitRepetibles.Merge(new Service().GetCUITRepetibles(Program.Pin));
                    crTablasCuiTsRepetibles.SetDataSource(dscuitRepetibles);
                    break;
                case "Diagnósticos":
                    crystalReportViewer1.ReportSource = crTablasDiagnosticos;
                    dsDiagnosticos.Merge(new Service().GetDiagnosticos(Program.Pin));
                    crTablasDiagnosticos.SetDataSource(dsDiagnosticos);
                    break;
                case "Empleados":
                    crystalReportViewer1.ReportSource = crTablasEmpleados;
                    dsEmpleadosLista.Merge(new Service().GetEmpleadosReporte(Program.Pin));
                    crTablasEmpleados.SetDataSource(dsEmpleadosLista);
                    break;
                case "Entidades de Cobranza":
                    crystalReportViewer1.ReportSource = crTablasEntidadesDeCobranza;
                    dsEntidadesDeCobranza.Merge(new Service().GetEntidadesDeCobranza(Program.Pin));
                    crTablasEntidadesDeCobranza.SetDataSource(dsEntidadesDeCobranza);
                    break;
                case "Lugares":
                    crystalReportViewer1.ReportSource = crTablasLugares;
                    dsLugaresLista.Merge(new Service().GetLugaresLista(Program.Pin));
                    crTablasLugares.SetDataSource(dsLugaresLista);
                    break;
                case "Medicamentos":
                    crystalReportViewer1.ReportSource = crTablasMedicamentos;
                    dsMedicamentos.Merge(new Service().GetMedicamentos(Program.Pin));
                    crTablasMedicamentos.SetDataSource(dsMedicamentos);
                    break;
                case "Médicos de Cabecera":
                    crystalReportViewer1.ReportSource = crTablasMedicosDeCabecera;
                    dsMedicosDeCabecera.Merge(new Service().GetMedicosDeCabecera(Program.Pin));
                    crTablasMedicosDeCabecera.SetDataSource(dsMedicosDeCabecera);
                    break;
                case "Motivos de Cancelación de la Prestación":
                    crystalReportViewer1.ReportSource = crTablasMotivosCancelacionPrestacion;
                    dsMotivosDeCancelacionPrestacion.Merge(new Service().GetMotivosDeCancelacionPrestacion(Program.Pin));
                    crTablasMotivosCancelacionPrestacion.SetDataSource(dsMotivosDeCancelacionPrestacion);
                    break;
                case "Motivos de Baja":
                    crystalReportViewer1.ReportSource = crTablasMotivosDeBaja;
                    dsMotivosDeBaja.Merge(new Service().GetMotivosDeBaja(Program.Pin));
                    crTablasMotivosDeBaja.SetDataSource(dsMotivosDeBaja);
                    break;
                case "Motivos de Llamado":
                    crystalReportViewer1.ReportSource = crTablasMotivosDeLlamado;
                    dsMotivosDeLlamado.Merge(new Service().GetMotivosDeLlamado(Program.Pin));
                    crTablasMotivosDeLlamado.SetDataSource(dsMotivosDeLlamado);
                    break;
                case "Móviles":
                    crystalReportViewer1.ReportSource = crTablasMoviles;
                    dsMovilesLista.Merge(new Service().GetMovilesListaRep(Program.Pin));
                    crTablasMoviles.SetDataSource(dsMovilesLista);
                    break;
                case "Ocupaciones":
                    crystalReportViewer1.ReportSource = crTablasOcupaciones;
                    dsOcupaciones.Merge(new Service().GetOcupaciones(Program.Pin));
                    crTablasOcupaciones.SetDataSource(dsOcupaciones);
                    break;
                case "Planes":
                    crystalReportViewer1.ReportSource = crTablasPlanes;
                    dsPlanesParaReporte.Merge(new Service().GetPlanesParaReporte(Program.Pin));
                    crTablasPlanes.SetDataSource(dsPlanesParaReporte);
                    break;
                case "Prácticas":
                    crystalReportViewer1.ReportSource = crTablasPracticas;
                    dsPracticas.Merge(new Service().GetPracticas(Program.Pin));
                    crTablasPracticas.SetDataSource(dsPracticas);
                    break;
                case "Prepagos":
                    crystalReportViewer1.ReportSource = crTablasPrepagos;
                    dsPrepagos.Merge(new Service().GetPrepagos(Program.Pin));
                    crTablasPrepagos.SetDataSource(dsPrepagos);
                    break;
                case "Prestadores":
                    crystalReportViewer1.ReportSource = crTablasPrestadores;
                    dsPrestadores.Merge(new Service().GetPrestadores(Program.Pin));
                    crTablasPrestadores.SetDataSource(dsPrestadores);
                    break;
                case "Proveedores":
                    crystalReportViewer1.ReportSource = crTablasProveedores;
                    dsProveedores.Merge(new Service().GetProveedores(Program.Pin));
                    crTablasProveedores.SetDataSource(dsProveedores);
                    break;
                case "Puestos":
                    crystalReportViewer1.ReportSource = crTablasPuestos;
                    dsPuestos.Merge(new Service().GetPuestos(Program.Pin));
                    crTablasPuestos.SetDataSource(dsPuestos);
                    break;
                case "Rubros":
                    crystalReportViewer1.ReportSource = crTablasRubros;
                    dsTiposDeCliente.Merge(new Service().GetTiposDeCliente(Program.Pin));
                    crTablasRubros.SetDataSource(dsTiposDeCliente);
                    break;
                case "Territorios":
                    crystalReportViewer1.ReportSource = crTablasTerritorios;
                    dsTerritorios.Merge(new Service().GetTerritorios(Program.Pin));
                    crTablasTerritorios.SetDataSource(dsTerritorios);
                    break;
                case "Tipos de Destino":
                    crystalReportViewer1.ReportSource = crTablasTiposDeDestino;
                    dsTiposDeDestino.Merge(new Service().GetTiposDeDestino(Program.Pin));
                    crTablasTiposDeDestino.SetDataSource(dsTiposDeDestino);
                    break;
                case "Tipos de Móvil":
                    crystalReportViewer1.ReportSource = crTablasTiposDeMovil;
                    dsTiposDeMovil.Merge(new Service().GetTiposDeMovil(Program.Pin));
                    crTablasTiposDeMovil.SetDataSource(dsTiposDeMovil);
                    break;
                case "Tipos de Valores":
                    crystalReportViewer1.ReportSource = crTablasTiposDeValores;
                    dsTiposDeValores.Merge(new Service().GetTiposDeValores(Program.Pin));
                    crTablasTiposDeValores.SetDataSource(dsTiposDeValores);
                    break;
                case "Usuarios":
                    crystalReportViewer1.ReportSource = crTablasUsuarios;
                    dsUsuarios.Merge(new Service().GetUsuarios(Program.Pin));
                    crTablasUsuarios.SetDataSource(dsUsuarios);
                    break;
                case "Zonas":
                    crystalReportViewer1.ReportSource = crTablasZonas;
                    dsZonasLista.Merge(new Service().GetZonasLista(Program.Pin));
                    crTablasZonas.SetDataSource(dsZonasLista);
                    break;
            }
        }
    }
}
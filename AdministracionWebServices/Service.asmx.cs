using System;
using System.ComponentModel;
using System.Threading;
using System.Web.Services;
using Administración;

namespace AdministracionWebServices
{
    /// <summary>
    ///     Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service : WebService
    {
        private static bool ValidarUsuario(string pin)
        {
            Thread.Sleep(100);
            return pin == "pipopescador";
        }

        [WebMethod]
        public int IntTipoDeDocumentoDesdeIniciales(string iniciales, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabConsultorios().IntTipoDeDocumentoDesdeIniciales(iniciales) : 0;
        }

        [WebMethod]
        public string SerieDelComprobante(int idComprobante, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabConsultorios().SerieDelComprobante(idComprobante) : "";
        }

        [WebMethod]
        public string GetFacturasExportadas(string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().GetFacturasExportadas() : "";
        }

        [WebMethod]
        public DsAntecedentesConsultorio GetDatosFiliatorios(string numeroDeDocumento, int idAfiliado, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpCabConsultorios().GetDatosFiliatorios(numeroDeDocumento, idAfiliado)
                : null;
        }

        [WebMethod]
        public DsAntecedentesConsultorio GetAtencionesAnterioresConsultorio(int idTurno, string numeroDeDocumento,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpCabConsultorios().GetAtencionesAnterioresConsultorio(idTurno, numeroDeDocumento)
                : null;
        }

        [WebMethod]
        public DsRepResumenPrestacionesPorCliente GetResumenPrestacionesPorCliente(string desde, string hasta,
            string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetResumenPrestacionesPorCliente(desde, hasta) : null;
        }

        [WebMethod]
        public DsRepResumenPrestacionesPorCliente GetResumenPrestacionesPorClienteSoloDomicilios(string desde,
            string hasta, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpCabPrestaciones().GetResumenPrestacionesPorClienteSoloDomicilios(desde, hasta)
                : null;
        }

        [WebMethod]
        public DsOrdenDePago GetOrdenesDePago(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().GetOrdenesDePago() : null;
        }

        [WebMethod]
        public DsOrdenDePago GetOrdenDePago(int idPago, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().GetOrdenDePago(idPago) : null;
        }

        [WebMethod]
        public DsOrdenDePago GetCompraDelPago(int idCompra, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().GetCompraDelPago(idCompra) : null;
        }

        [WebMethod]
        public DsOrdenDePago GetComprasDelPago(string proceso, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().GetComprasDelPago(proceso) : null;
        }

        [WebMethod]
        public DsOrdenDePago UpdateOrdenDePago(DsOrdenDePago ordenDePago, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().UpdateOrdenDePago(ordenDePago) : null;
        }

        [WebMethod]
        public DsImportarCAE UpdateImportarCAE(DsImportarCAE imp, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().UpdateImportarCae(imp) : null;
        }

        [WebMethod]
        public DsComprasImpagas GetComprasImpagas(int idProveedor, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().GetComprasImpagas(idProveedor) : null;
        }

        [WebMethod]
        public DsComprasImpagas UpdateComprobantesDePagoImpagos(DsComprasImpagas pago, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().UpdateComprobantesDePagoImpagos(pago) : null;
        }

        [WebMethod]
        public DsRubros GetRubros(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().GetRubros() : null;
        }

        [WebMethod]
        public DsRubros GetRubrosQueAdmitenValores(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().GetRubrosQueAdmitenValores() : null;
        }

        [WebMethod]
        public DsRubros UpdateRubros(DsRubros rub, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().UpdateRubros(rub) : null;
        }

        [WebMethod]
        public DsNegocios GetNegocios(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().GetNegocios() : null;
        }

        [WebMethod]
        public DsNegocios UpdateNegocios(DsNegocios neg, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().UpdateNegocios(neg) : null;
        }

        [WebMethod]
        public DsReportPago GetReportPago(int idPago, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().GetReportPago(idPago) : null;
        }

        [WebMethod]
        public DsImportarPadron UpdateImportarPadron(DsImportarPadron tabla, string pin)
        {
            return ValidarUsuario(pin) ? new CmpGrupos().UpdateImportarPadron(tabla) : null;
        }

        [WebMethod]
        public DsCuentaCorrienteProveedor GetCuentaCorrienteProveedor(int idProveedor, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().GetCuentaCorrienteProveedor(idProveedor) : null;
        }

        [WebMethod]
        public DsReporteRubrosNegocios GetReporteRubrosNegocios(string desde, string hasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().GetReporteRubrosNegocios(desde, hasta) : null;
        }

        [WebMethod]
        public DsCopagos GetCopagos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpClientes().GetCopagos() : null;
        }

        [WebMethod]
        public DsCopagos UpdateCopagos(DsCopagos cop, string pin)
        {
            return ValidarUsuario(pin) ? new CmpClientes().UpdateCopagos(cop) : null;
        }

        [WebMethod]
        public decimal SugerirCopago(int idContrato, int idPlan, int idTipoDeDestino, int idCodigo, int idPractica, int idTipoDeContrato,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpCabTomarLlamado().SugerirCopago(idContrato, idPlan, idTipoDeDestino, idCodigo, idPractica, idTipoDeContrato)
                : 0;
        }

        [WebMethod]
        public int ContratoDelPlan(int idPlan, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabTomarLlamado().ContratoDelPlan(idPlan) : 0;
        }

        [WebMethod]
        public string TelefonosDelAfiliado(int idAfiliado, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabTomarLlamado().TelefonosDelAfiliado(idAfiliado) : "";
        }

        [WebMethod]
        public DsExportarImpresionFacturas GetExportarImpresionFacturas(string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpFacturaciones().GetExportarImpresionFacturas()
                : null;
        }

        [WebMethod]
        public string MotivosDelPaciente(int idPaciente, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().MotivosDelPaciente(idPaciente) : "";
        }

        [WebMethod]
        public string DireccionCompletaDelDestino(int idDestino, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().DireccionCompletaDelDestino(idDestino) : "";
        }

        [WebMethod]
        public DsTurnosImprimir GetTurnosImprimir(DateTime dia, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabConsultorios().GetTurnosImprimir(dia) : null;
        }

        [WebMethod]
        public DsFacturaManual GetComprobantePorIdComprobante(int idComprobante, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().GetComprobantePorIdComprobante(idComprobante) : null;
        }

        [WebMethod]
        public DsTurnosImprimir GetTurnosPorFrase(string frase, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabConsultorios().GetTurnosPorFrase(frase) : null;
        }

        [WebMethod]
        public DsComprobantes GetComprobantes(int cantidad, string prefijo, string numeroInicial, string serie,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpFacturaciones().GetComprobantes(cantidad, prefijo, numeroInicial, serie)
                : null;
        }

        [WebMethod]
        public DsComprobantes UpdateComprobantes(DsComprobantes comp, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().UpdateComprobantes(comp) : null;
        }

        [WebMethod]
        public void GuardarCAE(int idComprobante, string cae, string vencimientoCAE, string pin)
        {
            if (!ValidarUsuario(pin)) return;
            new CmpFacturaciones().GuardarCAE(idComprobante, cae, vencimientoCAE);
        }

        [WebMethod]
        public void GuardarFacturaEnviada(int idComprobante, string pin)
        {
            if (!ValidarUsuario(pin)) return;
            new CmpFacturaciones().GuardarFacturaEnviada(idComprobante);
        }

        [WebMethod]
        public DsHist_RenglonesFacturaProforma GetHistorialRenglonesPorCliente(string cliente, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRenglonesFP().GetHistorialRenglonesPorCliente(cliente) : null;
        }

        [WebMethod]
        public string GetWsfEv1(int tipoCbte, string token, string sign, int tipoDoc, string cuit, int puntoVta,
            string nroDoc, long cbtDesde, long cbtHasta, string impTotal, string impTotConc, string impNeto,
            string impIVA, string impTrib, string impOpEx,
            string fechaCbte, string fechaVencPago, string fechaServDesde, string fechaServHasta, string baseImp3,
            string importeIVA3, string baseImp4, string importeIVA4, string baseImp5, string importeIVA5,
            string baseImp6, string importeIVA6, string baseImp8, string importeIVA8, string baseImp9,
            string importeIVA9, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpFacturaciones().GetWsfEv1(tipoCbte, token, sign, tipoDoc, cuit, puntoVta, nroDoc, cbtDesde,
                    cbtHasta, impTotal, impTotConc, impNeto, impIVA, impTrib, impOpEx, fechaCbte, fechaVencPago,
                    fechaServDesde, fechaServHasta, baseImp3, importeIVA3, baseImp4, importeIVA4, baseImp5, importeIVA5,
                    baseImp6, importeIVA6, baseImp8, importeIVA8, baseImp9, importeIVA9)
                : null;
        }

        [WebMethod]
        public DsHist_RenglonesFacturaProforma GetHistorialRenglonesPorFecha(DateTime fecha, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRenglonesFP().GetHistorialRenglonesPorFecha(fecha) : null;
        }

        [WebMethod]
        public DsHist_RenglonesFacturaProforma GetHistorialRenglonesSinActualizar(DateTime fecha, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRenglonesFP().GetHistorialRenglonesSinActualizar(fecha) : null;
        }

        [WebMethod]
        public DsHist_Planes GetHistorialPlanesPorFecha(DateTime fecha, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRenglonesFP().GetHistorialPlanesPorFecha(fecha) : null;
        }

        [WebMethod]
        public DsHist_Recursos GetHistorialRecursosPorFecha(DateTime desde, DateTime hasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRenglonesFP().GetHistorialRecursosPorFecha(desde, hasta) : null;
        }

        [WebMethod]
        public DsHist_Recursos GetHistorialRecursosPorFechaYChofer(DateTime desde, DateTime hasta, string chofer,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpRenglonesFP().GetHistorialRecursosPorFechaYChofer(desde, hasta, chofer)
                : null;
        }

        [WebMethod]
        public DsHist_Recursos GetHistorialRecursosPorFechaYMedico(DateTime desde, DateTime hasta, string medico,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpRenglonesFP().GetHistorialRecursosPorFechaYMedico(desde, hasta, medico)
                : null;
        }

        [WebMethod]
        public DsHist_Recursos GetHistorialRecursosPorFechaYMovil(DateTime desde, DateTime hasta, string movil,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpRenglonesFP().GetHistorialRecursosPorFechaYMovil(desde, hasta, movil)
                : null;
        }

        [WebMethod]
        public DsHist_Recursos GetHistorialRecursosPorFechaYParamedico(DateTime desde, DateTime hasta,
            string paramedico,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpRenglonesFP().GetHistorialRecursosPorFechaYParamedico(desde, hasta, paramedico)
                : null;
        }

        [WebMethod]
        public DsHist_Recursos GetHistorialRecursosPorFechaYRecurso(DateTime desde, DateTime hasta, string recurso,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpRenglonesFP().GetHistorialRecursosPorFechaYRecurso(desde, hasta, recurso)
                : null;
        }

        [WebMethod]
        public DsSolicitudesCAE GetSolicitudesCae(DateTime desde, DateTime hasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().GetSolicitudesCae(desde, hasta) : null;
        }

        [WebMethod]
        public DsSolicitudesCAE UpdatesolSolicitudesCae(DsSolicitudesCAE sol, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().UpdateSolicitudesCae(sol) : null;
        }

        [WebMethod]
        public DsFacturasSinCAE GetFacturasSinCAE(string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().GetFacturasSinCAE() : null;
        }

        [WebMethod]
        public DsFacturasSinCAE GetDetalleFacturaSinCAE(int idComprobante, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().GetDetalleFacturaSinCAE(idComprobante) : null;
        }

        [WebMethod]
        public DsFacturasSinCAE GetGenerarPDF(int idComprobante, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().GetGenerarPDF(idComprobante) : null;
        }

        [WebMethod]
        public DsFacturasSinCAE GetFacturaSinCAEParaReporte(string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().GetFacturasSinCAEParaReporte() : null;
        }

        [WebMethod]
        public DsRenglonesFacturaLista GetRenglonesDeFactura(int idCliente, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaManual().GetRenglonesDeFactura(idCliente) : null;
        }

        [WebMethod]
        public string GetPDF(string empresa, int tipoDoc, string nroDoc, int tipoCbte, int puntoVta, long cbtDesde,
            string impTotal, string impTotConc, string impNeto, string impIVA, string impTrib, string impOpEx,
            string fechaCbte, string fechaVencPago, string fechaServDesde, string fechaServHasta, string cae,
            string fechaVtoCae, string categoriaIVA, string nombreCliente, string direccionCliente,
            string observaciones, string localidadCliente, string provinciaCliente, string tipoReferencia,
            string prefijoReferencia, string numeroReferencia, string baseImp4, string importeIVA4, string baseImp5,
            string importeIVA5, int idComprobante, string tipoDeComprobante, string prefijo, string numeroDeComprobante,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpFacturaciones().GetPDF(empresa, tipoDoc, nroDoc, tipoCbte, puntoVta, cbtDesde, impTotal,
                    impTotConc, impNeto, impIVA, impTrib, impOpEx, fechaCbte, fechaVencPago, fechaServDesde,
                    fechaServHasta, cae, fechaVtoCae, categoriaIVA, nombreCliente, direccionCliente, observaciones,
                    localidadCliente, provinciaCliente, tipoReferencia, prefijoReferencia, numeroReferencia, baseImp4,
                    importeIVA4, baseImp5, importeIVA5, idComprobante, tipoDeComprobante, prefijo, numeroDeComprobante)
                : "No";
        }

        [WebMethod]
        public bool EsBanco(int idEmpleado, string pin)
        {
            return ValidarUsuario(pin) && new CmpCompra().EsBanco(idEmpleado);
        }

        [WebMethod]
        public bool EnviarFactura(string empresa, string destinatario, string nombreArchivo, string pin)
        {
            return ValidarUsuario(pin) && new CmpFacturaciones().EnviarFactura(empresa, destinatario, nombreArchivo);
        }

        [WebMethod]
        public int AumentosAutomaticos(decimal aumento, string frase, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().AumentosAutomaticos(aumento, frase) : 0;
        }

        [WebMethod]
        public DsLocalidades GetLocalidadesConMarca(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTerritorios().GetLocalidadesConMarca() : null;
        }

        [WebMethod]
        public DsLocalidades UpdateLocalidadesConMarca(DsLocalidades loc, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTerritorios().UpdateLocalidadesConMarca(loc) : null;
        }

        #region "Service"

        [WebMethod]
        public DsTerritorios GetTerritorios(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTerritorios().GetTerritorios() : null;
        }

        [WebMethod]
        public DsTerritorios UpdateTerritorios(DsTerritorios dsTerritorios, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTerritorios().UpdateTerritorios(dsTerritorios) : null;
        }

        [WebMethod]
        public DsAfiliados GetGrupo(int grupo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpGrupos().GetGrupo(grupo) : null;
        }

        [WebMethod]
        public DsAfiliados UpdateGrupo(DsAfiliados grupo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpGrupos().UpdateGrupo(grupo) : null;
        }

        [WebMethod]
        public DsCallesLista GetCallesLista(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTerritorios().GetCallesLista() : null;
        }

        [WebMethod]
        public DsCallesLista GetCallesListaPorLocalidad(int loca, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTerritorios().GetCallesListaPorLocalidad(loca) : null;
        }

        [WebMethod]
        public string GetAfiliadoMismoDNI(int idTipoDeDocumento, string dNi, int idAfiliado, string pin)
        {
            return ValidarUsuario(pin) ? new CmpGrupos().NombreAfiliado(idTipoDeDocumento, dNi, idAfiliado) : null;
        }

        [WebMethod]
        public DsCategoriasIVA GetCategoriasIva(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCCategoriasIva().GetCategoriasIVA() : null;
        }

        [WebMethod]
        public DsCategoriasIVA UpdateCategoriasIVA(DsCategoriasIVA cat, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCCategoriasIva().UpdateCategoriasIva(cat) : null;
        }

        [WebMethod]
        public DsCodigos GetCodigos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCCodigos().GetCodigos() : null;
        }

        [WebMethod]
        public DsCodigos UpdateCodigos(DsCodigos cod, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCCodigos().UpdateCodigos(cod) : null;
        }

        [WebMethod]
        public DsEntidadesDeCobranza GetEntidadesDeCobranza(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEntidadesDeCobranza().GetEntidadesDeCobranza() : null;
        }

        [WebMethod]
        public DsEntidadesDeCobranza UpdateEntidadesDeCobranza(DsEntidadesDeCobranza ent, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEntidadesDeCobranza().UpdateEntidadesDeCobranza(ent) : null;
        }

        [WebMethod]
        public DsMotivosDeBaja GetMotivosDeBaja(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCMotivosDeBaja().GetMotivosDeBaja() : null;
        }

        [WebMethod]
        public DsMotivosDeBaja UpdateMotgivosDeBaja(DsMotivosDeBaja moti, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCMotivosDeBaja().UpdateMotivosDeBaja(moti) : null;
        }

        [WebMethod]
        public DsPlanesPropios GetPlanesPropios(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPlanesPropios().GetPlanesPropios() : null;
        }

        [WebMethod]
        public DsPlanesPropios UpdatePlanesPropios(DsPlanesPropios pla, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPlanesPropios().UpdatePlanesPropios(pla) : null;
        }

        [WebMethod]
        public DsPlanes GetPlanesContratos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPlanesPropios().GetPlanesContratos() : null;
        }

        [WebMethod]
        public DsPlanes UpdatePlanesContratos(DsPlanes pla, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPlanesPropios().UpdatePlanesContratos(pla) : null;
        }

        [WebMethod]
        public DsPrepagos GetPrepagos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPrepagos().GetPrepagos() : null;
        }

        [WebMethod]
        public DsPrepagos UpdatePrepagos(DsPrepagos prep, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPrepagos().UpdatePrepagos(prep) : null;
        }

        [WebMethod]
        public DsPrestadores GetPrestadores(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPrestadores().GetPrestadores() : null;
        }

        [WebMethod]
        public DsPrestadores UpdatePrestadores(DsPrestadores prest, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPrestadores().UpdatePrestadores(prest) : null;
        }

        [WebMethod]
        public DsPuntosDeVenta GetPuntosDeVenta(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPuntosDeVenta().GetPuntosDeVenta() : null;
        }

        [WebMethod]
        public DsPuntosDeVenta UpdatePuntosDeVenta(DsPuntosDeVenta puntos, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPuntosDeVenta().UpdatePuntosDeVenta(puntos) : null;
        }

        [WebMethod]
        public DsTiposDeCliente GetTiposDeCliente(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTiposDeCliente().GetTiposDeCliente() : null;
        }

        [WebMethod]
        public DsTiposDeCliente UpdateTiposDeCliente(DsTiposDeCliente tipos, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTiposDeCliente().UpdateTiposDeCliente(tipos) : null;
        }

        [WebMethod]
        public DsTiposDeCobranza GetTiposDeCobranza(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTiposDeCobranza().GetTiposDeCobranza() : null;
        }

        [WebMethod]
        public DsTiposDeCobranza UpdateTiposDeCobranza(DsTiposDeCobranza tipos, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTiposDeCobranza().UpdateTiposDeCobranza(tipos) : null;
        }

        [WebMethod]
        public DsTiposDeComprobante GetTiposDeComprobante(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTiposDeComprobante().GetTiposDeComprobante() : null;
        }

        [WebMethod]
        public DsTiposDeComprobante UpdateTiposDeComprobante(DsTiposDeComprobante tipos, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTiposDeComprobante().UpdateTiposDeComprobante(tipos) : null;
        }

        [WebMethod]
        public DsTiposDeContrato GetTiposDeContrato(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTiposDeContrato().GetTiposDeContrato() : null;
        }

        [WebMethod]
        public DsTiposDeContrato UpdateTiposDeContrato(DsTiposDeContrato tipos, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTiposDeContrato().UpdateTiposDecontrato(tipos) : null;
        }

        [WebMethod]
        public DsTiposDeDocumento GetTiposDeDocumento(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTiposDeDocumento().GetTiposDeDocumento() : null;
        }

        [WebMethod]
        public DsTiposDeDocumento UpdateTiposDeDocumento(DsTiposDeDocumento tipos, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTiposDeDocumento().UpdateTiposDeDocumento(tipos) : null;
        }

        [WebMethod]
        public DsTiposDeValores GetTiposDeValores(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTiposDeValores().GetTiposDeValores() : null;
        }

        [WebMethod]
        public DsTiposDeValores UpdateTiposDeValores(DsTiposDeValores tipos, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTiposDeValores().UpdateTiposDeValores(tipos) : null;
        }

        [WebMethod]
        public DsEmpleados GetEmpleados(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEmpleados().GetEmpleados() : null;
        }

        [WebMethod]
        public DsEmpleados UpdateEmpleados(DsEmpleados emp, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEmpleados().UpdateEmpleados(emp) : null;
        }

        [WebMethod]
        public DsLugares GetLugares(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCLugares().GetLugares() : null;
        }

        [WebMethod]
        public DsLugares UpdateLugares(DsLugares lugares, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCLugares().UpdateLugares(lugares) : null;
        }

        [WebMethod]
        public DsBuscarClientes GetBuscarClientes(string frase, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCClientes().GetBuscarClientes(frase) : null;
        }

        [WebMethod]
        public DsBuscarPlanContrato GetBuscarPlanContrato(string frase, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCClientes().GetBuscarPlanContrato(frase) : null;
        }

        [WebMethod]
        public DsCargos GetCargos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEmpleados().GetCargos() : null;
        }

        [WebMethod]
        public DsBuscarAfiliados GetBuscarAfiliados(string frase, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCGrupos().GetBuscarAfiliados(frase) : null;
        }

        [WebMethod]
        public DsBuscarAfiliados GetBuscarAfiliadosPropios(string frase, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCGrupos().GetBuscarAfiliadosPropios(frase) : null;
        }

        [WebMethod]
        public DsBuscarAfiliadosActivos GetBuscarAfiliadosActivos(string frase, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCGrupos().GetBuscarAfiliadosActivos(frase) : null;
        }

        [WebMethod]
        public DsParametros GetParametros(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCParametros().GetParametros() : null;
        }

        [WebMethod]
        public DsParametros UpdateParametros(DsParametros param, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCParametros().UpdateParametros(param) : null;
        }

        [WebMethod]
        public DsZonas GetZonas(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCZonas().GetZonas() : null;
        }

        [WebMethod]
        public DsZonas UpdateZonas(DsZonas zon, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCZonas().UpdateZonas(zon) : null;
        }

        [WebMethod]
        public DsLocalidades GetLocalidades(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCZonas().GetLocalidades() : null;
        }

        [WebMethod]
        public DsPlanes GetPlanes(string pin)
        {
            return ValidarUsuario(pin) ? new CmpGrupos().GetPlanes() : null;
        }

        [WebMethod]
        public DsPlanesAfiliado GetPlanesAfiliados(int idAfiliado, DateTime fecha, string pin)
        {
            return ValidarUsuario(pin) ? new CmpGrupos().GetPlanesAfiliado(idAfiliado, fecha) : null;
        }

        [WebMethod]
        public int DefaultDNI(string pin)
        {
            return ValidarUsuario(pin) ? new CmpGrupos().DefaultDNI() : 0;
        }

        [WebMethod]
        public DsClientes GetCliente(int cliente, string pin)
        {
            return ValidarUsuario(pin) ? new CmpClientes().GetCliente(cliente) : null;
        }

        [WebMethod]
        public DsClientes GetClientes(string pin)
        {
            return ValidarUsuario(pin) ? new CmpClientes().GetClientes() : null;
        }

        [WebMethod]
        public DsClientes UpdateCliente(DsClientes cli, string pin)
        {
            return ValidarUsuario(pin) ? new CmpClientes().UpdateCliente(cli) : null;
        }

        [WebMethod]
        public string NombreCuitIngresado(string cuit, int idCliente, string pin)
        {
            return ValidarUsuario(pin) ? new CmpClientes().NombreCuitIngresado(cuit, idCliente) : null;
        }

        [WebMethod]
        public string NombreCuitIngresadoProveedor(string cuit, int idProveedor, string pin)
        {
            return ValidarUsuario(pin) ? new CmpClientes().NombreCuitIngresadoProveedor(cuit, idProveedor) : null;
        }

        [WebMethod]
        public string NombreProveedorCuitIngresado(string cuit, int idProveedor, string pin)
        {
            return ValidarUsuario(pin) ? new CmpClientes().NombreProveedorCuitIngresado(cuit, idProveedor) : null;
        }

        [WebMethod]
        public DsRemesas GetRemesas(string pin)
        {
            return ValidarUsuario(pin) ? new CmpRemesa().GetRemesas() : null;
        }

        [WebMethod]
        public DsRemesas UpdateRemesa(DsRemesas remesa, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRemesa().UpdateRemesa(remesa) : null;
        }

        [WebMethod]
        public string MensajeRemesa(int idComprobante, int idCobradorOrig, int idEntidadOrig, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpRemesa().MensajeRemesa(idComprobante, idCobradorOrig, idEntidadOrig)
                : null;
        }

        [WebMethod]
        public string MensajeCambioDeCobrador(int idComprobante, int idCobradorOrig, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRemesa().MensajeCambioDeCobrador(idComprobante, idCobradorOrig) : null;
        }

        [WebMethod]
        public string MensajeLiquidacionEntidad(int idComprobante, int idEntidadOrig, string periodo, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpRemesa().MensajeLiquidacionTercerizada(idComprobante, idEntidadOrig, periodo)
                : null;
        }

        [WebMethod]
        public string PrimerPeriodoSinLiquidar(int idEntidadDeCobranza, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRemesa().PrimerPeriodoSinLiquidar(idEntidadDeCobranza) : null;
        }

        [WebMethod]
        public double ImporteComprobanteRemesa(int idComprobante, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRemesa().ImporteComprobanteRemesa(idComprobante) : 0;
        }

        [WebMethod]
        public int HacerRecibosRemesa(int idremesa, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRemesa().HacerRecibosRemesa(idremesa) : 0;
        }

        [WebMethod]
        public int HacerRecibosLiquidacionEntidad(int idLiquidacionEntidad, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRemesa().HacerRecibosLiquidacionEntidad(idLiquidacionEntidad) : 0;
        }

        [WebMethod]
        public int CantidadDeComprobantesDeFacturasRealizados(int idTandaDeFacturacion, string fecha, string periodo,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpFacturacionMensualAfiliados().CantidadDeComprobantesDeFacturasRealizados(idTandaDeFacturacion,
                    fecha,
                    periodo)
                : 0;
        }

        [WebMethod]
        public int CantidadDeComprobantesFacturasPorFacturaProforma(int idFacturaProforma, string periodo, string fecha,
            string proceso,
            bool ponerCobrador, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpFacturacionMensualAfiliados().CantidadDeComprobantesFacturasPorFacturaProforma(
                    idFacturaProforma, periodo,
                    fecha, proceso, ponerCobrador)
                : 0;
        }

        [WebMethod]
        public int CantidadDeComprobantesRealizados(string periodo1, int idTipoDeCobranza1, int idEntidadDeCobranza1,
            int jubilado1,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpFacturacionMensualAfiliados().CantidadDeComprobantesRealizados(periodo1, idTipoDeCobranza1,
                    idEntidadDeCobranza1, jubilado1)
                : 0;
        }

        [WebMethod]
        public int CantidadDeComprobantesManualesRealizados(int idGrupo, string periodo, string fecha, string proceso,
            bool ponerCobrador,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpFacturacionMensualAfiliados().CantidadDeComprobantesManualesRealizados(idGrupo, periodo, fecha,
                    proceso,
                    ponerCobrador)
                : 0;
        }

        [WebMethod]
        public int CantidadDeBajasAutomaticas(string periodo1, int idGrabador1, string proceso1, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpFacturacionMensualAfiliados().CantidadDeBajasAutomaticas(periodo1, idGrabador1, proceso1)
                : 0;
        }

        [WebMethod]
        public DsReportComprobantes GetReportComprobantes(string periodo,
            int idTipoDeCobranza,
            int idEntidadDeCobranza,
            int idCobrador,
            string prefijo,
            int idZona,
            string desde,
            string hasta,
            string desdeFecha,
            string hastaFecha,
            string todosOPendientes,
            string tipoComprobantes,
            string pin
        )
        {
            return ValidarUsuario(pin)
                ? new CmpReporteCupones().GetReportComprobantes(periodo,
                    idTipoDeCobranza,
                    idEntidadDeCobranza,
                    idCobrador,
                    prefijo,
                    idZona,
                    desde,
                    hasta,
                    desdeFecha,
                    hastaFecha,
                    todosOPendientes,
                    tipoComprobantes)
                : null;
        }

        [WebMethod]
        public DsReportComprobantes GetReportComprobantesPorProceso(string proceso, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteCupones().GetReportComprobantesPorProceso(proceso) : null;
        }

        [WebMethod]
        public DsReportRemesa GetReporteRemesa(int idRemesa, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteRemesa().GetReporteRemesa(idRemesa) : null;
        }

        [WebMethod]
        public DsMotivosDevolucionCobranza GetMotivosDevolucionCobranza(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCMotivosDevolucionCobranza().GetMotivosDevolucionCobranza() : null;
        }

        [WebMethod]
        public DsMotivosDevolucionCobranza UpdateMotivosDevolucionCobranza(DsMotivosDevolucionCobranza moti, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpABCMotivosDevolucionCobranza().UpdateMotivosDevolucionCobranza(moti)
                : null;
        }

        [WebMethod]
        public DsArqueos GetArqueos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpArqueo().GetArqueos() : null;
        }

        [WebMethod]
        public DsArqueos UpdateArqueos(DsArqueos arq, string pin)
        {
            return ValidarUsuario(pin) ? new CmpArqueo().UpdateArqueos(arq) : null;
        }

        public DsArqueos GetComprobantesArqueos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpArqueo().GetComprobantesArqueos() : null;
        }

        [WebMethod]
        public DsArqueos UpdateComprobantesArqueos(DsArqueos arq, string pin)
        {
            return ValidarUsuario(pin) ? new CmpArqueo().UpdateComprobantesArqueos(arq) : null;
        }

        [WebMethod]
        public string RetirarONoComprobanteArqueo(int idComprobante, string pin)
        {
            return ValidarUsuario(pin) ? new CmpArqueo().RetirarONoComprobanteArqueo(idComprobante) : null;
        }

        [WebMethod]
        public int? GetIdTipoDeComprobante(string tipo, int idReferencia, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().GetIdTipoDeComprobante(tipo,idReferencia) : null;
        }

        [WebMethod]
        public decimal TotalARendir(int idCobrador, string pin)
        {
            return ValidarUsuario(pin) ? new CmpArqueo().TotalARendir(idCobrador) : 0;
        }

        [WebMethod]
        public void ComprobantesFaltantesArqueo(int idArqueo, string pin)
        {
            if (!ValidarUsuario(pin)) return;
            new CmpArqueo().ComprobantesFaltantesArqueo(idArqueo);
        }

        [WebMethod]
        public void ComprobantesRetenidosPorBajaPasanACobradorBajas(int idArqueo, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpArqueo().ComprobantesRetenidosPorBajaPasanACobradorBajas(idArqueo);
        }

        [WebMethod]
        public DsReportArqueo ObtenerDatosArqueo(int idArqueo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteArqueo().ObtenerDatosArqueo(idArqueo) : null;
        }

        [WebMethod]
        public DsPrueba Prueba(string pin)
        {
            return ValidarUsuario(pin) ? new cmp_prueba().prueba() : null;
        }

        [WebMethod]
        public DsBarrios GetBarriosLista(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTerritorios().GetBarriosLista() : null;
        }

        [WebMethod]
        public DsBarrios GetBarriosListaPorLocalidad(int idLocalidad, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTerritorios().GetBarriosListaPorLocalidad(idLocalidad) : null;
        }

        [WebMethod]
        public DsReportExtensionDeCobertura GetReportExtensionDeCobertura(int idGrupo, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpReporteExtensionDeCobertura().GetReportExtensionDeCobertura(idGrupo)
                : null;
        }

        [WebMethod]
        public string FraseCambioGrupo(int idGrupo, int idAfiliado, string pin)
        {
            return ValidarUsuario(pin) ? new cmp_CambioDeGrupo().FraseCambioGrupo(idGrupo, idAfiliado) : null;
        }

        [WebMethod]
        public int NuevoNumeroDeGrupo(int idAfiliado, int idGrupo, string pin)
        {
            return ValidarUsuario(pin) ? new cmp_CambioDeGrupo().NuevoNumeroDeGrupo(idAfiliado, idGrupo) : 0;
        }

        [WebMethod]
        public void CambioDeGrupo(int idAfiliado, int idGrupo, string pin)
        {
            if (ValidarUsuario(pin)) new cmp_CambioDeGrupo().CambioDeGrupo(idAfiliado, idGrupo);
        }

        [WebMethod]
        public DsEstadoActualDelGrupo GetEstadoActualDelGrupo(int idGrupo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpEstadoActualDelGrupo().GetEstadoActualDelGrupo(idGrupo) : null;
        }

        [WebMethod]
        public string MensajeCantidadDeTitulares(int idGrupo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpGrupos().MensajeCantidadDeTitulares(idGrupo) : null;
        }

        [WebMethod]
        public int HayAlgunAfiliadoActivo(int idGrupo, DateTime fecha, string pin)
        {
            return ValidarUsuario(pin) ? new CmpGrupos().HayAfiliadosPropiosActivos(idGrupo, fecha) : 0;
        }

        [WebMethod]
        public bool ExisteUsuario(string usuario, string pin)
        {
            return ValidarUsuario(pin) && new cmp_NuevoUsuario().existeUsuario(usuario);
        }

        [WebMethod]
        public void AgregarUsuario(string usuario, string clave, string pin)
        {
            if (ValidarUsuario(pin))
                new cmp_NuevoUsuario().agregarUsuario(usuario, clave);
        }

        [WebMethod]
        public DsTiposDeAutorizacion GetTiposDeAutorizacion(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTiposDeAutorizacion().GetTiposDeAutorizacion() : null;
        }

        [WebMethod]
        public DsTiposDeAutorizacion UpdateTiposDeAutorizacion(DsTiposDeAutorizacion tipos, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTiposDeAutorizacion().UpdateTiposDeAutorizacion(tipos) : null;
        }

        [WebMethod]
        public DsAutorizaciones GetAutorizaciones(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCAutorizaciones().GetAutorizaciones() : null;
        }

        [WebMethod]
        public DsAutorizaciones UpdateAutorizaciones(DsAutorizaciones auto, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCAutorizaciones().UpdateAutorizaciones(auto) : null;
        }

        [WebMethod]
        public DsPuestos GetPuestos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPuestos().GetPuestos() : null;
        }

        [WebMethod]
        public DsPuestos UpdatePuestos(DsPuestos puestos, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPuestos().UpdatePuestos(puestos) : null;
        }

        [WebMethod]
        public DsAutorizacionesDelPuesto GetAutorizacionesDelPuesto(string pin)
        {
            return ValidarUsuario(pin) ? new CmpAutorizacionesDelPuesto().GetAutorizacionesDelPuesto() : null;
        }

        [WebMethod]
        public DsAutorizacionesDelPuesto UpdateAutorizacionesDelPuesto(DsAutorizacionesDelPuesto auto, string pin)
        {
            return ValidarUsuario(pin) ? new CmpAutorizacionesDelPuesto().UpdateAutorizacionesDelPuesto(auto) : null;
        }

        [WebMethod]
        public DsPuestosDelUsuario GetPuestosDelUsuario(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPuestosDelUsuario().GetPuestosDelUsuario() : null;
        }

        [WebMethod]
        public DsPuestosDelUsuario UpdatePuestosDelUsuario(DsPuestosDelUsuario usu, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPuestosDelUsuario().UpdatePuestosDelUsuario(usu) : null;
        }

        [WebMethod]
        public DsUsuarios GetUsuarios(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPuestosDelUsuario().GetUsuarios() : null;
        }

        [WebMethod]
        public DsUsuariosLista GetUsuariosLista(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPuestosDelUsuario().GetUsuariosLista() : null;
        }

        [WebMethod]
        public DsUsuarios UpdateUsuarios(DsUsuarios usu, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPuestosDelUsuario().UpdateUsuarios(usu) : null;
        }

        [WebMethod]
        public int ValidarLogin(string usuario, string clave, string pin)
        {
            return ValidarUsuario(pin) ? new CmpLogin().ValidarLogin(usuario, clave, pin) : 0;
        }

        [WebMethod]
        public int ValidarLoginDirector(string usuario, string clave, string pin)
        {
            return ValidarUsuario(pin) ? new CmpLogin().ValidarLoginDirector(usuario, clave, pin) : 0;
        }

        [WebMethod]
        public DsAutorizacionesDelUsuario GetAutorizacionesDelUsuario(string usuario, string pin)
        {
            return ValidarUsuario(pin) ? new CmpPrincipal().GetAutorizacionesDelUsuario(usuario) : null;
        }

        [WebMethod]
        public string NombreDelUsuario(int idUsuario, string pin)
        {
            return ValidarUsuario(pin) ? new CmpLogin().NombreDelUsuario(idUsuario) : null;
        }

        [WebMethod]
        public bool ComprobarClave(int idUsuario, string clave, string pin)
        {
            return ValidarUsuario(pin) && new CmpCambioDeClave().ComprobarClave(idUsuario, clave);
        }

        [WebMethod]
        public void CambiarClave(int idUsuario, string clave, string pin)
        {
            if (ValidarUsuario(pin)) new CmpCambioDeClave().CambiarClave(idUsuario, clave);
        }

        [WebMethod]
        public DsSistemas GetSistemas(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCSistemas().GetSistemas() : null;
        }

        [WebMethod]
        public DsSistemas UpdateSistemas(DsSistemas sis, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCSistemas().UpdateSistemas(sis) : null;
        }

        [WebMethod]
        public DsBancos GetBancos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCBancos().GetBancos() : null;
        }

        [WebMethod]
        public DsBancos UpdateBancos(DsBancos ban, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCBancos().UpdateBancos(ban) : null;
        }

        [WebMethod]
        public DsMedicosDeCabecera GetMedicosDeCabecera(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCMedicosDeCabecera().GetMedicosDeCabecera() : null;
        }

        [WebMethod]
        public DsMedicosDeCabecera UpdateMedicosDeCabecera(DsMedicosDeCabecera med, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCMedicosDeCabecera().UpdateMedicosDeCabecera(med) : null;
        }

        [WebMethod]
        public DsOcupaciones GetOcupaciones(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCOcupaciones().GetOcupaciones() : null;
        }

        [WebMethod]
        public DsOcupaciones UpdateOcupaciones(DsOcupaciones ocu, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCOcupaciones().UpdateOcupaciones(ocu) : null;
        }

        [WebMethod]
        public DsEmpleadosLista GetEmpleadosLista(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEmpleados().GetEmpleadosLista() : null;
        }

        [WebMethod]
        public DsEmpleadosLista GetEmpleadosReporte(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEmpleados().GetEmpleadosReporte() : null;
        }

        [WebMethod]
        public DsEmpleadosLista GetAdministrativos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEmpleados().GetAdministrativos() : null;
        }

        [WebMethod]
        public DsEmpleadosLista GetCajasBancos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEmpleados().GetCajasBancos() : null;
        }

        [WebMethod]
        public DsEmpleadosLista GetNoAdministrativos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEmpleados().GetNoAdministrativos() : null;
        }

        [WebMethod]
        public DsEmpleadosLista GetAdministrativosYBancos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEmpleados().GetAdministrativosYBancos() : null;
        }

        [WebMethod]
        public DsEmpleadosLista GetCajasConSaldoOBanco(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEmpleados().GetCajasConSaldoOBanco() : null;
        }

        [WebMethod]
        public DsEmpleadosLista GetMedicos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEmpleados().GetMedicos() : null;
        }

        [WebMethod]
        public DsEmpleadosLista GetParamedicos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEmpleados().GetParamedicos() : null;
        }

        [WebMethod]
        public DsEmpleadosLista GetChoferes(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEmpleados().GetChoferes() : null;
        }

        [WebMethod]
        public DsEmpleadosLista GetVendedores(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEmpleados().GetVendedores() : null;
        }

        [WebMethod]
        public DsEmpleadosLista GetCobradores(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCEmpleados().GetCobradores() : null;
        }

        [WebMethod]
        public DsMedicosDeCabecera GetMedicosDeCabeceraLista(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCMedicosDeCabecera().GetMedicosDeCabederaLista() : null;
        }

        [WebMethod]
        public DsContratosLista GetContratosRenglonFactura(int idCliente, string pin)
        {
            return ValidarUsuario(pin) ? new CmpClientes().GetContratosRenglonFactura(idCliente) : null;
        }

        [WebMethod]
        public DsContratosLista GetPlanesRenglonFactura(int idCliente, string pin)
        {
            return ValidarUsuario(pin) ? new CmpClientes().GetPlanesRenglonFactura(idCliente) : null;
        }

        [WebMethod]
        public DsContratosLista GetContratosRenglonFacturaTodos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpClientes().GetContratosRenglonFacturaTodos() : null;
        }

        [WebMethod]
        public DsClientesLista GetClientesLista(string pin)
        {
            return ValidarUsuario(pin) ? new CmpClientes().GetClientesLista() : null;
        }

        [WebMethod]
        public DsClientesLista GetClientesListaPorTipo(int tipo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpClientes().GetClientesListaPorTipo(tipo) : null;
        }

        [WebMethod]
        public DsCambiosDeCobrador GetCambiosDeCobrador(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCambiosDeCobrador().GetCambiosDeCobrador() : null;
        }

        [WebMethod]
        public DsCambiosDeCobrador UpdateCambioDeCobrador(DsCambiosDeCobrador cambio, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCambiosDeCobrador().UpdateCambioDeCobrador(cambio) : null;
        }

        [WebMethod]
        public void CambiarDeCobrador(int idCambioDeCobrador, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpRemesa().CambiarCobrador(idCambioDeCobrador);
        }

        [WebMethod]
        public DsTandasDeFacturacion GetTandasDeFacturacion(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTandasDeFacturacion().GetTandasDeFacturacion() : null;
        }

        [WebMethod]
        public DsTandasDeFacturacion UpdateTandasDeFacturacion(DsTandasDeFacturacion tandas, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTandasDeFacturacion().UpdateTandasDeFacturacion(tandas) : null;
        }

        [WebMethod]
        public DsComprobantesDeFacturas GetComprobantesDeFacturas(string desde, string hasta, string comprobantes,
            string prefijo,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpReporteCupones().GetComprobantesDeFacturas(desde, hasta, comprobantes, prefijo)
                : null;
        }

        [WebMethod]
        public DsComprobantesDeFacturas GetComprobantesDeFacturasPorProceso(string proceso, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteCupones().GetComprobantesDeFacturasPorProceso(proceso) : null;
        }

        [WebMethod]
        public DsFacturaManual UpdateFacturaManual(DsFacturaManual fac, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaManual().UpdateFacturaManual(fac) : null;
        }

        [WebMethod]
        public DsComprobantesDeFacturas GetComprobanteDeFactura(int idComprobante, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteCupones().GetComprobanteDeFactura(idComprobante) : null;
        }

        [WebMethod]
        public void HacerComprobanteDeFacturaManual(int idComprobante, bool ponerCobrador, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpFacturaManual().HacerComprobanteFacturaManual(idComprobante, ponerCobrador);
        }

        [WebMethod]
        public DsComprobantesImpagosCliente GetComprobantesImpagosCliente(int idCliente, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaManual().GetComprobantesImpagosCliente(idCliente) : null;
        }

        [WebMethod]
        public DsComprobantesImpagosCliente GetComprobantesImpagosGrupo(int idGrupo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaManual().GetComprobantesImpagosGrupo(idGrupo) : null;
        }

        [WebMethod]
        public DsComprobantesImpagosCliente GetComprobantesSaldoNegCliente(int idCliente, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaManual().GetComprobantesSaldoNegCliente(idCliente) : null;
        }

        [WebMethod]
        public DsComprobantesImpagosCliente GetComprobantesSaldoNegGrupo(int idGrupo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaManual().GetComprobantesSaldoNegGrupo(idGrupo) : null;
        }

        [WebMethod]
        public DsLocalidadesLista GetLocalidadesLista(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCTerritorios().GetLocalidadesLista() : null;
        }

        [WebMethod]
        public DsCUITRepetibles GetCUITRepetibles(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCCUITRepetibles().GetCUITRepetibles() : null;
        }

        [WebMethod]
        public DsCUITRepetibles UpdateCUITRepetibles(DsCUITRepetibles repe, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCCUITRepetibles().UpdateCUITRepetibles(repe) : null;
        }

        [WebMethod]
        public DsBajasOCambios GetAfiliadosPlanesDelGrupo(int idGrupo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpBajasOCambios().GetAfiliadosPlanesDelGrupo(idGrupo) : null;
        }

        [WebMethod]
        public DsBajasOCambios UpdateBajasOCambios(DsBajasOCambios boc, string pin)
        {
            return ValidarUsuario(pin) ? new CmpBajasOCambios().UpdateBajasOCambios(boc) : null;
        }

        [WebMethod]
        public DsBajasOCambios GetAfiliadosDelGrupo(int idGrupo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpBajasOCambios().GetAfiliadosDelGrupo(idGrupo) : null;
        }

        [WebMethod]
        public void BajasOCambios(int idBajaOCambio, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpBajasOCambios().BajasOCambios(idBajaOCambio);
        }

        [WebMethod]
        public DsRenglonesDeFactura GetRenglonesFP(string pin)
        {
            return ValidarUsuario(pin) ? new CmpRenglonesFP().GetRenglonesFP() : null;
        }

        [WebMethod]
        public DsRenglonesDeFactura UpdateRenglonesFP(DsRenglonesDeFactura rfp, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRenglonesFP().UpdateRenglonesFP(rfp) : null;
        }

        [WebMethod]
        public DsContratosLista GetContratosListaFP(string pin)
        {
            return ValidarUsuario(pin) ? new CmpRenglonesFP().GetContratosListaFP() : null;
        }

        [WebMethod]
        public void InsertarEnCobranzas(int idComprobante, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpFacturaManual().InsertarEnCobranzas(idComprobante);
        }

        [WebMethod]
        public DsFacturaciones GetFacturaciones(string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().GetFacturaciones() : null;
        }

        [WebMethod]
        public DsFacturaciones GetFacturacionesNoEntregadas(string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().GetFacturacionesNoEntregadas() : null;
        }

        [WebMethod]
        public DsFacturaciones GetFacturacionesPorProceso(string proceso, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().GetFacturacionesPorProceso(proceso) : null;
        }

        [WebMethod]
        public string PrimerPeriodoSinFacturarGrupo(int idGrupo, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpFacturacionMensualAfiliados().PrimerPeriodoSinFacturarGrupo(idGrupo)
                : "";
        }

        [WebMethod]
        public string PrimerPeriodoSinFacturarFacturaProforma(int idFacturaProforma, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpFacturacionMensualAfiliados().PrimerPeriodoSinFacturarFacturaProforma(idFacturaProforma)
                : "";
        }

        [WebMethod]
        public DsTipoDeCobranzaDelGrupo GetTipoDeCobranzaDelGrupo(int idGrupo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturacionMensualAfiliados().GetTipoDeCobranzaDelGrupo(idGrupo) : null;
        }

        [WebMethod]
        public string GetProceso(string pin)
        {
            return ValidarUsuario(pin) ? new CmpRemesa().GetProceso() : "";
        }

        [WebMethod]
        public void EliminarProceso(string proceso, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpRemesa().EliminarProceso(proceso);
        }

        [WebMethod]
        public void InsertarId(string proceso, int id, int id2, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpRemesa().InsertarId(proceso, id, id2);
        }

        [WebMethod]
        public DsIds GetIds(string proceso, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRemesa().GetIds(proceso) : null;
        }

        [WebMethod]
        public string PeriodoDelComprobante(int idComprobante, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRemesa().PeriodoDelComprobante(idComprobante) : "";
        }

        [WebMethod]
        public double SaldoComprobante(int idComprobante, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRemesa().SaldoComprobante(idComprobante) : 0;
        }

        [WebMethod]
        public DsProveedores GetProveedores(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCProveedores().GetProveedores() : null;
        }

        [WebMethod]
        public DsProveedores UpdateProveedores(DsProveedores prov, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCProveedores().UpdateProveedores(prov) : null;
        }

        [WebMethod]
        public DsProveedores GetProveedoresActivos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCProveedores().GetProveedoresActivos() : null;
        }

        [WebMethod]
        public DsProveedores GetProveedor(int idProveedor, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCProveedores().GetProveedor(idProveedor) : null;
        }

        [WebMethod]
        public DsBuscarProveedores GetBuscarProveedores(string frase, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCProveedores().GetBuscarProveedores(frase) : null;
        }

        [WebMethod]
        public DsCompra UpdateCompra(DsCompra compra, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCompra().UpdateCompra(compra) : null;
        }

        [WebMethod]
        public decimal EfectivoEnCaja(int idEmpleado, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCaja().GetEfectivoEnCaja(idEmpleado) : 0;
        }

        [WebMethod]
        public DsEnCaja GetValoresEmpleado(int idEmpleado, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCaja().GetValoresEmpleado(idEmpleado) : null;
        }

        [WebMethod]
        public DsTransferencias UpdateTransferencia(DsTransferencias trans, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCaja().UpdateTransferencia(trans) : null;
        }

        [WebMethod]
        public DsTransferencias UpdateValoresTransferencia(DsTransferencias trans, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCaja().UpdateValoresTransferencia(trans) : null;
        }

        [WebMethod]
        public string ProcesarTransferencia(int idTransferencia, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCaja().ProcesarTransferencia(idTransferencia) : "No";
        }

        [WebMethod]
        public DsReporteTransferencia GetReporteTransferencia(int idTransferencia, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCaja().GetReporteTransferencia(idTransferencia) : null;
        }

        [WebMethod]
        public DsRetiros UpdateRetiro(DsRetiros ret, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCaja().UpdateRetiro(ret) : null;
        }

        [WebMethod]
        public DsRetiros UpdateValoresRetiro(DsRetiros ret, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCaja().UpdateValoresRetiro(ret) : null;
        }

        [WebMethod]
        public string ProcesarRetiro(int idRetiro, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCaja().ProcesarRetiro(idRetiro) : "No";
        }

        [WebMethod]
        public DsReporteRetiro GetReporteRetiro(int idRetiro, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCaja().GetReporteRetiro(idRetiro) : null;
        }

        [WebMethod]
        public DsReintegros UpdateReintegro(DsReintegros ret, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCaja().UpdateRintegro(ret) : null;
        }

        [WebMethod]
        public string ProcesarReintegro(int idReintegro, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCaja().ProcesarReintegro(idReintegro) : "No";
        }

        [WebMethod]
        public DsReporteReintegro GetReporteReintegro(int idReintegro, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCaja().GetReporteReintegro(idReintegro) : null;
        }

        [WebMethod]
        public DsPrestacionesSinCobrador GetPrestacionesSinCobrador(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetPrestacionesSinCobrador() : null;
        }

        [WebMethod]
        public DsPrestacionesSinCobrador UpdatePrestacionesSinCobrador(DsPrestacionesSinCobrador prest, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().UpdatePrestacionesSinCobrador(prest) : null;
        }

        [WebMethod]
        public void AsignarCobradorAPrestaciones(string proceso, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpCabPrestaciones().AsignarCobradorAPrestaciones(proceso);
        }

        [WebMethod]
        public DsPrestacionesConSaldo GetPrestacionesConSaldo(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetPrestacionesConSaldo() : null;
        }

        [WebMethod]
        public DsPrestacionesConSaldo GetPrestacionesConSaldoNeg(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetPrestacionesConSaldoNeg() : null;
        }

        [WebMethod]
        public DsFacturasProFormaDelCliente GetFacturasProformaDelCliente(int idCliente, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaManual().GetFacturasProformaDelCliente(idCliente) : null;
        }

        [WebMethod]
        public DsProtecciones GetProtecciones(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPlanesPropios().GetProtecciones() : null;
        }

        [WebMethod]
        public DsProtecciones UpdateProtecciones(DsProtecciones prot, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPlanesPropios().UpdateProtecciones(prot) : null;
        }

        [WebMethod]
        public void FacturacionComprobantesManuales(string proceso, string afiliadoOCliente, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpFacturacionMensualAfiliados().FacturacionComprobantesManuales(proceso, afiliadoOCliente);
        }

        [WebMethod]
        public DsRemesasVista GetRemesasVista(DateTime desde, DateTime hasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRemesa().GetRemesasVista(desde, hasta) : null;
        }

        [WebMethod]
        public void ImportarDatosCAE(string proceso, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpFacturaciones().ImportarDatosCAE(proceso);
        }

        [WebMethod]
        public void EntregarFacturacion(int idFacturacion, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpFacturaciones().EntregarFacturacion(idFacturacion);
        }

        [WebMethod]
        public void ActualizarClienteActivo(int idCliente, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpGrupos().ActualizarClienteActivo(idCliente);
        }

        [WebMethod]
        public void ActualizarGrupoActivo(int idGrupo, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpGrupos().ActualizarGrupoActivo(idGrupo);
        }

        [WebMethod]
        public DsLiquidacionEntidad UpdateLiquidacionEntidad(DsLiquidacionEntidad liquidacion, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRemesa().UpdateLiquidacionEntidad(liquidacion) : null;
        }

        [WebMethod]
        public DsDescuentosGrupoNumeroso GetDescuentosGrupoNumeroso(string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturacionMensualAfiliados().GetDescuentosGrupoNumeroso() : null;
        }

        [WebMethod]
        public DsDescuentosGrupoNumeroso UpdateDescuentosGrupoNumeroso(DsDescuentosGrupoNumeroso desc, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpFacturacionMensualAfiliados().UpdateDescuentosGrupoNumeroso(desc)
                : null;
        }

        [WebMethod]
        public DsLicencia GetLicencia(string empresa, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCSistemas().GetLicencia(empresa) : null;
        }

        [WebMethod]
        public DsLicencia UpdateLicencia(DsLicencia lic, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCSistemas().UpdateLicencia(lic) : null;
        }

        [WebMethod]
        public int ImportarPadron(string proceso, int idPlan, string fechaSolicitudes, int idGrabador, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpABCGrupos().ImportarPadron(proceso, idPlan, fechaSolicitudes, idGrabador)
                : 0;
        }

        [WebMethod]
        public DsPorcentajeIVA GetPorcentajeIVA(string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().GetPorcentajeIVA() : null;
        }

        #endregion

        #region "Cabina"

        [WebMethod]
        public DsCabBuscarTelefono GetRefTelefono(string telefono, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabTomarLlamado().GetRefTelefono(telefono) : null;
        }

        [WebMethod]
        public DsCabBuscarTelefono GetRefDireccion(int idCalle, string numero, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabTomarLlamado().GetRefDireccion(idCalle, numero) : null;
        }

        [WebMethod]
        public DsCabBuscarTelefono GetRefDireccionCalle(int idCalle, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabTomarLlamado().GetRefDireccionCalle(idCalle) : null;
        }

        [WebMethod]
        public DsCabBuscarTelefono GetRefDireccionLocalidad(int idLocalidad, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabTomarLlamado().GetRefDireccionLocalidad(idLocalidad) : null;
        }

        [WebMethod]
        public DsCabBuscarTelefono GetRefAfiliado(int idAfiliado, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabTomarLlamado().GetRefAfiliado(idAfiliado) : null;
        }

        [WebMethod]
        public DsPracticas GetPracticas(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCPracticas().GetPracticas() : null;
        }

        [WebMethod]
        public DsPracticas UpdatePracticas(DsPracticas practi, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCPracticas().UpdatePracticas(practi) : null;
        }

        [WebMethod]
        public DsMotivosDeCancelacionPrestacion GetMotivosDeCancelacionPrestacion(string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpCabABCMotivosDeCancelacionPrestacion().GetMotivosDeCancelacionPrestacion()
                : null;
        }

        [WebMethod]
        public DsMotivosDeCancelacionPrestacion UpdateMotivosDeCancelacionPrestacion(
            DsMotivosDeCancelacionPrestacion moti, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpCabABCMotivosDeCancelacionPrestacion().UpdateMotivosDeCancelacionPrestacion(moti)
                : null;
        }

        [WebMethod]
        public DsMotivosDeLlamado GetMotivosDeLlamado(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCMotivosDeLlamado().GetMotivosDeLlamado() : null;
        }

        [WebMethod]
        public DsMotivosDeLlamado UpdateMotivosDeLlamado(DsMotivosDeLlamado moti, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCMotivosDeLlamado().UpdateMotivosDeLlamado(moti) : null;
        }

        [WebMethod]
        public DsDiagnosticos GetDiagnosticos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCDiagnosticos().GetDiagnosticos() : null;
        }

        [WebMethod]
        public DsDiagnosticos UpdateDiagnosticos(DsDiagnosticos diag, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCDiagnosticos().UpdateDiagnosticos(diag) : null;
        }

        [WebMethod]
        public DsMedicamentos GetMedicamentos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCMedicamentos().GetMedicamentos() : null;
        }

        [WebMethod]
        public DsMedicamentos UpdateMedicamentos(DsMedicamentos medi, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCMedicamentos().UpdateMedicamentos(medi) : null;
        }

        [WebMethod]
        public DsTiposDeMovil GetTiposDeMovil(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCTiposDeMovil().GetTiposDeMovil() : null;
        }

        [WebMethod]
        public DsTiposDeMovil UpdateTiposDeMovil(DsTiposDeMovil tdem, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCTiposDeMovil().UpdateTiposDeMovil(tdem) : null;
        }

        [WebMethod]
        public DsMoviles GetMoviles(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCMoviles().GetMoviles() : null;
        }

        [WebMethod]
        public DsMoviles UpdateMoviles(DsMoviles movi, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCMoviles().UpdateMoviles(movi) : null;
        }

        [WebMethod]
        public DsRecursos GetRecursos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCRecursos().GetRecutsos() : null;
        }

        [WebMethod]
        public DsRecursos UpdateRecursos(DsRecursos recu, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCRecursos().UpdateRecursos(recu) : null;
        }

        [WebMethod]
        public DsRecursos GetMovilesLista(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCRecursos().GetMovilesLista() : null;
        }

        [WebMethod]
        public DsRecursos GetMedicosLista(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCRecursos().GetMedicosLista() : null;
        }

        [WebMethod]
        public DsRecursos GetParamedicosLista(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCRecursos().GetParamedicosLista() : null;
        }

        [WebMethod]
        public DsRecursos GetChoferesLista(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCRecursos().GetChoferesLista() : null;
        }

        [WebMethod]
        public DsPrestacion GetPrestacion(int idPrestacion, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetPrestacion(idPrestacion) : null;
        }

        [WebMethod]
        public DsPrestacion UpdatePrestacion(DsPrestacion prest, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().UpdatePrestacion(prest) : null;
        }

        [WebMethod]
        public int CrearPrestacion(string fechaYHora,
            string telefono,
            int idLocalidad,
            int idCalle,
            string numero,
            string piso,
            string departamento,
            int idEntreCalle1,
            int idEntreCalle2,
            string observacionesDireccion,
            int idBarrio,
            int idTipoDeDestino,
            int idMotivoDeLlamado1,
            string observacionesMotivo1,
            int idMotivoDeLlamado2,
            string observacionesMotivo2,
            int idMotivoDeLlamado3,
            string observacionesMotivo3,
            int idMotivoDeLlamado4,
            string observacionesMotivo4,
            int idAfiliado,
            string apelNomb,
            int idTipoDeDocumento,
            string numeroDeDocumento,
            int edad,
            string edadEn,
            string sexo,
            int idPrepago,
            string numeroPrepago,
            decimal importe,
            string antecedentes,
            int idCodigo,
            int idCobertura,
            int idPractica,
            string observacionesPrestacion,
            int idContrato,
            int idTomador,
            bool terminada,
            int idMotivoDeCancelacion,
            string incidenteExterno,
            bool extraCobertura,
            decimal copagoSugerido,
            string pin
        )
        {
            return ValidarUsuario(pin)
                ? new CmpCabTomarLlamado().CrearPrestacion(fechaYHora, telefono, idLocalidad, idCalle, numero, piso,
                    departamento, idEntreCalle1, idEntreCalle2,
                    observacionesDireccion, idBarrio, idTipoDeDestino,
                    idMotivoDeLlamado1, observacionesMotivo1,
                    idMotivoDeLlamado2, observacionesMotivo2,
                    idMotivoDeLlamado3, observacionesMotivo3,
                    idMotivoDeLlamado4, observacionesMotivo4, idAfiliado,
                    apelNomb, idTipoDeDocumento, numeroDeDocumento, edad,
                    edadEn, sexo, idPrepago, numeroPrepago,
                    importe, antecedentes, idCodigo, idCobertura, idPractica,
                    observacionesPrestacion, idContrato, idTomador,
                    terminada, idMotivoDeCancelacion,
                    incidenteExterno, extraCobertura, copagoSugerido)
                : 0;
        }

        [WebMethod]
        public int CrearPrestacionProgramada(string prestacionesString
            , string fechaYHora
            , string telefono
            , int idLocalidad1
            , int idCalle1
            , string numero1
            , string piso1
            , string departamento1
            , int idEntreCalle11
            , int idEntreCalle21
            , string observacionesDireccion1
            , int idBarrio1
            , int idLocalidad2
            , int idCalle2
            , string numero2
            , string piso2
            , string departamento2
            , int idEntreCalle12
            , int idEntreCalle22
            , string observacionesDireccion2
            , int idBarrio2
            , bool haySegundaDirección
            , bool esperaYRetorno
            , int idAfiliado
            , string apelNomb
            , int idTipoDeDocumento
            , string numeroDeDocumento
            , int edad
            , string edadEn
            , string sexo
            , int idPrepago
            , string numeroPrepago
            , decimal importe
            , string antecedentes
            , int idCobertura
            , int idPractica
            , int idContrato
            , int idTomador
            , bool extraCobertura
            , decimal copagoSugerido
            , string pin
        )
        {
            return ValidarUsuario(pin)
                ? new CmpCabTomarLlamado().CrearPrestacionProgramada(prestacionesString, fechaYHora, telefono,
                    idLocalidad1,
                    idCalle1, numero1, piso1, departamento1,
                    idEntreCalle11, idEntreCalle21,
                    observacionesDireccion1, idBarrio1, idLocalidad2,
                    idCalle2, numero2, piso2, departamento2,
                    idEntreCalle12, idEntreCalle22,
                    observacionesDireccion2, idBarrio2,
                    haySegundaDirección, esperaYRetorno, idAfiliado,
                    apelNomb, idTipoDeDocumento, numeroDeDocumento,
                    edad, edadEn, sexo, idPrepago,
                    numeroPrepago, importe, antecedentes,
                    idCobertura, idPractica,
                    idContrato, idTomador,
                    extraCobertura, copagoSugerido)
                : 0;
        }

        [WebMethod]
        public DsDireccionLugar GetDireccionLugar(int idLugar, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetDireccionLugar(idLugar) : null;
        }

        [WebMethod]
        public DsRecursos GetRecursosActivos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetRecursosActivos() : null;
        }

        [WebMethod]
        public DsCoberturas GetCoberturas(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCCoberturas().GetCoberturas() : null;
        }

        [WebMethod]
        public DsCoberturas UpdateCoberturas(DsCoberturas cob, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCCoberturas().UpdateCoberturas(cob) : null;
        }

        [WebMethod]
        public DsTiposDeDestino GetTiposDeDestino(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCTiposDeDestino().GetTiposDeDestino() : null;
        }

        [WebMethod]
        public DsTiposDeDestino UpdateTiposDeDestino(DsTiposDeDestino tipos, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCTiposDeDestino().UpdateTiposDeDestino(tipos) : null;
        }

        [WebMethod]
        public DsPrestacionesResumen GetPrestacionesResumen(string agendada, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetPrestacionesResumen(agendada) : null;
        }

        [WebMethod]
        public DsBuscarTelefono GetAfiliadoDelTelefono(int idAfiliado, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabTomarLlamado().GetAfiliadoDelTelefono(idAfiliado) : null;
        }

        [WebMethod]
        public DsBuscarTelefono GetDireccionDelTelefono(int idDireccion, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabTomarLlamado().GetDireccionDelTelefono(idDireccion) : null;
        }

        [WebMethod]
        public DateTime HoraActual(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().HoraActual() : new DateTime(1947, 1, 1, 7, 0, 0);
        }

        [WebMethod]
        public DateTime Hoy(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().Hoy() : new DateTime(1947, 1, 1, 7, 0, 0);
        }

        [WebMethod]
        public DsContratosLista GetContratosLista(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabTomarLlamado().GetContratosLista() : null;
        }

        [WebMethod]
        public DsContratosLista GetContratosListaNoBaja(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabTomarLlamado().GetContratosListaNoBaja() : null;
        }

        [WebMethod]
        public DsBuscarContrato BuscarContrato(string frase, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabTomarLlamado().BuscarContrato(frase) : null;
        }

        [WebMethod]
        public void MarcarPrestacionComoVista(int idPrestacion, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpCabPrestaciones().MarcarPrestacionComoVista(idPrestacion);
        }

        [WebMethod]
        public DsPrestacionesResumen GetPrestacionesAModificar(string periodo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetPrestacionesAModificar(periodo) : null;
        }

        [WebMethod]
        public string GetProcesoPrestaciones(string desde,
            string hasta,
            string desdeHora,
            string hastaHora,
            string nroPrestacion,
            int idCobertura,
            int idTipoDeDestino,
            int idCliente,
            int idContrato,
            int idRubro,
            int idCodigo,
            int idEntidadDeCobranza,
            string paciente,
            string hC,
            int idLocalidad,
            int idCalle,
            string telefono,
            int idMovil,
            int tiempoDeLlegada,
            int idMedico,
            int idParamedico,
            int idChofer,
            int idMotivo,
            int idDiagnostico,
            int idMedicamento,
            int internacion,
            int idLugar,
            int idTomador,
            int idDespachador,
            int verCanceladas,
            int cuentaPacientes,
            string pin
        )
        {
            return ValidarUsuario(pin)
                ? new CmpCabPrestaciones().GetProcesoPrestaciones(desde, hasta, desdeHora, hastaHora, nroPrestacion,
                    idCobertura, idTipoDeDestino,
                    idCliente, idContrato, idRubro, idCodigo,
                    idEntidadDeCobranza, paciente,
                    hC, idLocalidad, idCalle, telefono, idMovil,
                    tiempoDeLlegada, idMedico, idParamedico, idChofer,
                    idMotivo, idDiagnostico, idMedicamento,
                    internacion, idLugar, idTomador, idDespachador, verCanceladas,
                    cuentaPacientes)
                : null;
        }

        [WebMethod]
        public string GetProcesoPrestacionesCliente(string desde,
            string hasta,
            int idCliente,
            string pin
        )
        {
            return ValidarUsuario(pin)
                ? new CmpCabPrestaciones().GetProcesoPrestacionesCliente(desde, hasta,
                    idCliente)
                : null;
        }

        [WebMethod]
        public DsDestinos GetDestinos(int idPrestacion, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetDestinos(idPrestacion) : null;
        }

        [WebMethod]
        public DsDestinos UpdateDestinos(DsDestinos dest, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().UpdateDestinos(dest) : null;
        }

        [WebMethod]
        public DsFeriados GetFeriados(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabConsultorios().GetFeriados() : null;
        }

        [WebMethod]
        public DsFeriados UpdateFeriados(DsFeriados fer, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabConsultorios().UpdateFeriados(fer) : null;
        }

        [WebMethod]
        public DsMoldesDeTurnos GetMoldesDeTurnos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabConsultorios().GetMoldesDeTurnos() : null;
        }

        [WebMethod]
        public DsMoldesDeTurnos UpdateMoldesDeTurnos(DsMoldesDeTurnos mol, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabConsultorios().UpdateMoldesDeTurnos(mol) : null;
        }

        [WebMethod]
        public DsTurnos GetTurnos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabConsultorios().GetTurnos() : null;
        }

        [WebMethod]
        public DsTurnos UpdateTurnos(DsTurnos tur, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabConsultorios().UpdateTurnos(tur) : null;
        }

        [WebMethod]
        public DsTurnos GetTurnosFuturos(int idMedico, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabConsultorios().GetTurnosFuturos(idMedico) : null;
        }

        [WebMethod]
        public DsTurnos GetTurnosHoy(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabConsultorios().GetTurnosHoy() : null;
        }

        [WebMethod]
        public DsTurnos GetTurnosHoyPorMedico(string pin, int idMedico)
        {
            return ValidarUsuario(pin) ? new CmpCabConsultorios().GetTurnosHoyPorMedico(idMedico) : null;
        }

        [WebMethod]
        public DsPacientesPrestacion GetPacientes(int idPrestacion, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetPacientes(idPrestacion) : null;
        }

        [WebMethod]
        public DsPacientesPrestacion UpdatePacientes(DsPacientesPrestacion pac, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().UpdatePacientes(pac) : null;
        }

        [WebMethod]
        public DsAtencionesAnteriores GetAtencionesAnteriores(int idAfiliado, string telefono, int idPrestacion,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpCabTomarLlamado().GetAtencionesAnteriores(idAfiliado, telefono, idPrestacion)
                : null;
        }

        [WebMethod]
        public DsBuscarPacientes GetPacientesPorNombre(string frase, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetPacientesPorNombre(frase) : null;
        }

        [WebMethod]
        public DsImprimirPrestacion GetImprimirPrestacion(int idPrestacion, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabImprimirPrestacion().GetImprimirPrestacion(idPrestacion) : null;
        }

        [WebMethod]
        public DsImprimirPrestacion GetImprimirPrestaciones(string proceso, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabImprimirPrestacion().GetImprimirPrestaciones(proceso) : null;
        }

        [WebMethod]
        public DsRecursosLista GetRecursosLista(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCRecursos().GetRecursosLista() : null;
        }

        [WebMethod]
        public void HacerComprobantePrestacion(int idPrestacion, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpCabPrestaciones().HacerComprobantePrestacion(idPrestacion);
        }

        [WebMethod]
        public DsComprobantePrestacion GetComprobantePrestacion(int idPrestacion, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetComprobantePrestacion(idPrestacion) : null;
        }

        [WebMethod]
        public DsPersonalPrestacion GetPersonalPrestacion(int idPrestacion, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetPersonalPrestacion(idPrestacion) : null;
        }

        [WebMethod]
        public int PrestacionDelDestinoRecurso(int idDestinoRecurso, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().PrestacionDelDestinoRecurso(idDestinoRecurso) : 0;
        }

        [WebMethod]
        public DsPacientesIncompletos GetPacientesIncompletos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetPacientesIncompletos() : null;
        }

        [WebMethod]
        public DsPacientesPrestacion GetPaciente(int idPaciente, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().GetPaciente(idPaciente) : null;
        }

        #endregion

        #region Reportes

        [WebMethod]
        public DsProviDireccionesSinZona GetDireciconesSinZona(string pin)
        {
            return ValidarUsuario(pin) ? new CmpProviDireccionesSinZona().GetDireccionesSinZona() : null;
        }

        [WebMethod]
        public DsProviSinPlan GetProviSinPlan(string pin)
        {
            return ValidarUsuario(pin) ? new CmpProviDireccionesSinZona().GetProviSinPlan() : null;
        }

        [WebMethod]
        public DsRepRenglonesAFacturar GetRenglonesAFacturar(string pin)
        {
            return ValidarUsuario(pin) ? new CmpRepRenglonesAFacturar().GetRenglonesAFacturar() : null;
        }

        [WebMethod]
        public DsRepCantidadAfiliadosPlan GetCantidadAfiliadosPlan(string fecha, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRepCantidadAfiliadosPlan().GetCantidadAfiliadosPorPlan(fecha) : null;
        }

        [WebMethod]
        public DsRepFacturasDeClientes GetFacturasDeClientes(string periodo, int idPuntoDeVenta, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpRepFacturasDeClientes().GetFacturasDeClientes(periodo, idPuntoDeVenta)
                : null;
        }

        [WebMethod]
        public DsClientesConContratoActivoYPlan GetClientesConContratoActivoYPlan(string pin)
        {
            return ValidarUsuario(pin) ? new CmpConstanciasDeAfiliacion().GetClientesConContratoActivoYPlan() : null;
        }

        [WebMethod]
        public DsClientesConContratoActivoYPlan GetContratosActivosConPlan(int idCliente, string pin)
        {
            return ValidarUsuario(pin) ? new CmpConstanciasDeAfiliacion().GetContratosActivosConPlan(idCliente) : null;
        }

        [WebMethod]
        public DsClientesConContratoActivoYPlan GetPlanesDeUnContrato(int idContrato, string pin)
        {
            return ValidarUsuario(pin) ? new CmpConstanciasDeAfiliacion().GetPlanesDeUnContrato(idContrato) : null;
        }

        [WebMethod]
        public DsRepConstanciasAfiliacion GetConstanciasAfiliacion(string periodo, int idCliente, int idContrato,
            int idPlan, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpConstanciasDeAfiliacion().GetConstanciasAfiliacion(periodo, idCliente, idContrato, idPlan)
                : null;
        }

        [WebMethod]
        public DsRepPrestCodigoLocalidad GetPrestacionesCodigoLocalidad(string desde, string hasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRepEstPrest().GetPrestCodigoLocalidad(desde, hasta) : null;
        }

        [WebMethod]
        public DsRepPadron GetPadron(DateTime fecha, int idZona, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRepPadron().GetPadron(fecha, idZona) : null;
        }

        [WebMethod]
        public DsRepListadoPorPlan GetListadoPorPlan(int idPlan, string fecha, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRepCantidadAfiliadosPlan().GetListadoPorPlan(idPlan, fecha) : null;
        }

        [WebMethod]
        public DsRepNoUnTitular GetAfiliadosNoUnTitular(string pin)
        {
            return ValidarUsuario(pin) ? new CmpProviDireccionesSinZona().GetAfiliadosNoUnTitular() : null;
        }

        [WebMethod]
        public DsRepCambioDeCobrador GetRepCambioDeCobrador(int idCambioDeCobrador, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCambiosDeCobrador().GetRepCambioDeCobrador(idCambioDeCobrador) : null;
        }

        [WebMethod]
        public DsCuentaCorriente GetCuentaCorriente(string grupoOCliente, int id, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRepCuentaCorriente().GetCuentaCorriente(grupoOCliente, id) : null;
        }

        [WebMethod]
        public DsRepIVAVentasAfiliados GetIVAVentasAfiliados(string desde, string hasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteCupones().GetIVAVentasAfiliados(desde, hasta) : null;
        }

        [WebMethod]
        public DsDetalleFacturasCliente GetDetalleFacturasCliente(int idCliente, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteCupones().GetDetalleFacturasCliente(idCliente) : null;
        }

        [WebMethod]
        public DsRepAfiliadosPorEntidadDeCobranza GetAfiliadosPorEntidadDeCobranza(int id, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpRepAfiliadosPorEntidadDeCobranza().GetAfiliadosPorEntidadDeCobranza(id)
                : null;
        }

        [WebMethod]
        public string GetProcesoAfiliados(string altaBajaTodos,
            string soloTitulares,
            int idEntidadDeCobranza,
            string pin
        )
        {
            return ValidarUsuario(pin)
                ? new CmpReportesAfiliados().GetProcesoAfiliados(altaBajaTodos, soloTitulares, idEntidadDeCobranza)
                : null;
        }

        [WebMethod]
        public string GetProcesoClientes(string altaBajaTodos,
            int idEntidadDeCobranza,
            int idTipoDeCliente,
            string pin
        )
        {
            return ValidarUsuario(pin)
                ? new CmpReportesAfiliados().GetProcesoClientes(altaBajaTodos, idEntidadDeCobranza, idTipoDeCliente)
                : null;
        }

        [WebMethod]
        public DsListaCorreo GetListaCorreo(string afiliadosOClientes,
            string tipoDeDireccion,
            string proceso,
            string pin
        )
        {
            return ValidarUsuario(pin)
                ? new CmpReportesAfiliados().GetListaCorreo(afiliadosOClientes, tipoDeDireccion, proceso)
                : null;
        }

        [WebMethod]
        public DsReporteVISA GetReporteVISA(string periodo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteVISA().GetReporteVISA(periodo) : null;
        }

        [WebMethod]
        public DsReporteKadicard GetReporteKadicard(string periodo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteVISA().GetReporteKadicard(periodo) : null;
        }

        [WebMethod]
        public DsReporteNaranja GetReporteNaranja(string periodo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteVISA().GetReporteNaranja(periodo) : null;
        }

        [WebMethod]
        public DsReporteNaranja GetReporteNaranjaInforme(string periodo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteVISA().GetReporteNaranjaInforme(periodo) : null;
        }

        [WebMethod]
        public DsReporteMacro GetReporteMacro(bool jubilado, string periodo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteVISA().GetReporteMacro(jubilado, periodo) : null;
        }

        [WebMethod]
        public DsReporteMacro GetBancoMacroArchivo(string periodo, int jubilado, int secuencial, int rectificativa,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpReporteVISA().GetBancoMacroArchivo(periodo, jubilado, secuencial, rectificativa)
                : null;
        }

        [WebMethod]
        public DsReporteMacro GetReporteArgencard(string periodo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteVISA().GetReporteArgencard(periodo) : null;
        }

        [WebMethod]
        public DsReporteMacro GetArgencardArchivo(string periodo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteVISA().GetArgencardArchivo(periodo) : null;
        }

        [WebMethod]
        public string MensajeDebitoAutomatico(string periodo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteVISA().MensajeDebitoAutomatico(periodo) : null;
        }

        [WebMethod]
        public DsInformeVentas GetInformeVentas(string desde, string hasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteCupones().GetInformeVentas(desde, hasta) : null;
        }

        [WebMethod]
        public DsRepListadoFacturadoPorEntidad GetListadoFacturadoPorEntidad(int idEntidadDeCobranza, string periodo,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpRepAfiliadosPorEntidadDeCobranza().GetListadoFacturadoPorEntidad(idEntidadDeCobranza, periodo)
                : null;
        }

        [WebMethod]
        public DsEstadoDeLaCobranza GetEstadoDeLaCobranza(int idCobrador, string fecha, int meses, string mostrarFuturo,
            string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpEstadoDeLaCobranza().GetEstadoDeLaCobranza(idCobrador, fecha, meses, mostrarFuturo)
                : null;
        }

        [WebMethod]
        public DsRepNdeC GetRepNdeC(string desde, string hasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteNdeC().GetRepNdeC(desde, hasta) : null;
        }

        [WebMethod]
        public string GetComprobantesQueTieneElCobrador(int idCobrador, string pin)
        {
            return ValidarUsuario(pin) ? new CmpReporteCupones().GetComprobantesQueTieneElCobrador(idCobrador) : "";
        }

        [WebMethod]
        public DsCaja GetCaja(int idEmpleado, string desde, string hasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCaja().GetCaja(idEmpleado, desde, hasta) : null;
        }

        [WebMethod]
        public DsCajas GetCajas(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCaja().GetCajas() : null;
        }

        [WebMethod]
        public DsRepPuestosAutorizados GetPuestosAutorizados(string pin)
        {
            return ValidarUsuario(pin) ? new CmpAutorizacionesDelPuesto().GetPuestosAutorizados() : null;
        }

        [WebMethod]
        public int ContarPrestaciones(string proceso, string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabPrestaciones().ContarPrestaciones(proceso) : 0;
        }

        [WebMethod]
        public DsLugaresLista GetLugaresLista(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCLugares().GetLugaresLista() : null;
        }

        [WebMethod]
        public DsPlanesParaReporte GetPlanesParaReporte(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPlanesPropios().GetPlanesParaReporte() : null;
        }

        [WebMethod]
        public DsZonasLista GetZonasLista(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCZonas().GetZonasLista() : null;
        }

        [WebMethod]
        public DsDeudores GetDeudores(string hasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpDeudores().GetDeudores(hasta) : null;
        }

        [WebMethod]
        public void ProcesarDeudores(string pin)
        {
            if (ValidarUsuario(pin))
                new CmpDeudores().ProcesarDeudores();
        }

        [WebMethod]
        public void GenerarTurnos(int mes, int anyo, string pin)
        {
            if (ValidarUsuario(pin))
                new CmpCabConsultorios().GenerarTurnos(mes, anyo);
        }

        [WebMethod]
        public DsRepBajasAutomaticas GetListadoBajasAutomaticas(string proceso, string pin)
        {
            return ValidarUsuario(pin) ? new CmpGrupos().GetListadoBajasAutomaticas(proceso) : null;
        }

        [WebMethod]
        public DsFechasBajasAutomaticas GetFechasBajasAutomaticas(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCGrupos().GetFechasBajasAutomaticas() : null;
        }

        [WebMethod]
        public void ReporteBajasAutomaticas(string proceso, string fecha, string pin)
        {
            if (!ValidarUsuario(pin)) return;
            new CmpABCGrupos().ReporteBajasAutomaticas(proceso, fecha);
        }

        [WebMethod]
        public DsListaCambiosDeCobrador GetListaCambiosCobrador(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCambiosDeCobrador().GetListaCambiosDeCobrador() : null;
        }

        [WebMethod]
        public DsDatosPrestaciones GetDatosPrestaciones(string desde, string hasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRepEstPrest().GetDatosPrestaciones(desde, hasta) : null;
        }

        [WebMethod]
        public string NombApelTitular(int idGrupo, string pin)
        {
            return ValidarUsuario(pin) ? new CmpGrupos().NombApelTitular(idGrupo) : null;
        }

        [WebMethod]
        public DsRepPrestLocalidadMotivoCodigo GetRepPrestLocalidadMotivoCodigo(string desde, string hasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRepEstPrest().GetPrestLocalidadMotivoCodigo(desde, hasta) : null;
        }

        [WebMethod]
        public DsRepPrestMedicamentosUtilizados GetRepPrestMedicamentosUtilizados(string desde, string hasta,
            string pin)
        {
            return ValidarUsuario(pin) ? new CmpRepEstPrest().GetRepPrestMedicamentosUtilizados(desde, hasta) : null;
        }

        [WebMethod]
        public DsReportLiquidacionEntidad GetReportLiquidacionEntidad(int idLiquidacionEntidad, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRemesa().GetReportLiquidacionEntidad(idLiquidacionEntidad) : null;
        }

        [WebMethod]
        public DsReportLiquidacionEntidad GetReportLiquidacionEntidadTodos(string pin)
        {
            return ValidarUsuario(pin) ? new CmpRemesa().GetReportLiquidacionEntidadTodos() : null;
        }

        [WebMethod]
        public DsEstadisticaCantidadDeAfiliados GetEstadisticaCantidadDeAfiliados(string periodoDesde,
            string periodoHasta, string modo,
            int idPlan, string contar, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpRepCantidadAfiliadosPlan().GetEstadisticaCantidadDeAfiliados(periodoDesde, periodoHasta, modo,
                    idPlan, contar)
                : null;
        }

        [WebMethod]
        public DsEstadisticaPlanes GetEstadisticaPlanes(string fecha, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCPlanesPropios().GetEstadisticaPlanes(fecha) : null;
        }

        [WebMethod]
        public DsEntidadesSinLiquidar GetEntidadesSinLiquidar(string pin)
        {
            return ValidarUsuario(pin) ? new CmpEstadoDeLaCobranza().GetEntidadesSinLiquidar() : null;
        }

        [WebMethod]
        public DsRepTasaDeUso GetTasaDeUso(string modo, string periodoDesde, string periodoHasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRepEstPrest().GetTasaDeUso(modo, periodoDesde, periodoHasta) : null;
        }

        [WebMethod]
        public DsTasaDeUsoClientes GetTasaDeUsoClientes(string periodoDesde, string periodoHasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRepEstPrest().GetTasaDeUsoClientes(periodoDesde, periodoHasta) : null;
        }

        [WebMethod]
        public DsTasaDeUsoAfYCli GetTasaDeUsoAfYCli(string periodoDesde, string periodoHasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpRepEstPrest().GetTasaDeUsoAfYCli(periodoDesde, periodoHasta) : null;
        }

        [WebMethod]
        public DsMovilesLista GetMovilesListaRep(string pin)
        {
            return ValidarUsuario(pin) ? new CmpCabABCMoviles().GetMovilesLista() : null;
        }

        [WebMethod]
        public DsFacturadoClientes GetFacturadoClientes(string periodoDesde, string periodoHasta, string pin)
        {
            return ValidarUsuario(pin)
                ? new CmpRepCantidadAfiliadosPlan().GetFacturadoClientes(periodoDesde, periodoHasta)
                : null;
        }

        [WebMethod]
        public DsEmpresasSueldoBancoMacro GetEmpresasSueldoBancoMacro(string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCBancos().GetEmpresasSueldoBancoMacro() : null;
        }

        [WebMethod]
        public DsEmpresasSueldoBancoMacro UpdateEmpresasSueldoBancoMacro(DsEmpresasSueldoBancoMacro emp, string pin)
        {
            return ValidarUsuario(pin) ? new CmpABCBancos().UpdateEmpresasSueldoBancoMacro(emp) : null;
        }

        [WebMethod]
        public DsFacturadoYCobrado GetFacturadoYCobrado(string desde, string hasta, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().GetFacturadoYCobrado(desde, hasta) : null;
        }
        [WebMethod]
        public DsRepAumentosAuto GetRepAumentosAuto(int idAumento, string pin)
        {
            return ValidarUsuario(pin) ? new CmpFacturaciones().GetRepAumentosAuto(idAumento) : null;
        }
        #endregion
    }
}
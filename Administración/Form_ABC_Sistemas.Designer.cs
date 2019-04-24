using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    partial class FormABCSistemas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Sistemas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Recibo", -1, "ultraDropDownRecibo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NotaDeCredito", -1, "ultraDropDownNdeC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ComprobanteFactCuotaAfiliados", -1, "ultraDropDownFactura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ComprobanteFactPrestaciones", -1, "ultraDropDownFactura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DNI", -1, "ultraDropDownDNI");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoDevolucionCobranza_SaldoCero", -1, "ultraDropDownMotiDevCobSaldoCero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoDevolucionCobranza_Baja", -1, "ultraDropDownMotiDevCobBaja");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CoberturaAfiliado", -1, "ultraDropDownCoberturas");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CoberturaContrato", -1, "ultraDropDownCoberturas");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Consulta", -1, "ultraDropDownCodigos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Internacion", -1, "ultraDropDownTiposDeDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MaxCantDetallesPorComprobante");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoDeBaja_Automatica", -1, "ultraDropDownMotivosDeBaja");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Empleado_Sistema", -1, "ultraDropDownEmpleados");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TandaDebitoAutomatico", -1, "ultraDropDownTandasDeFacturacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PuntoDeVentaPrestaciones", -1, "ultraDropDownPuntoDeVenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoDevolucionCobranza_ComprobanteFaltante", -1, "ultraDropDownMotiDevCobSaldoCero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SinMedicamentos", -1, "ultraDropDownMedicamentos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idSistema");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CobradorBajas", -1, "ultraDropDownEmpleados");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CobradorMorosos", -1, "ultraDropDownEmpleados");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("VendedorAfiliadosContrato", -1, "ultraDropDownEmpleados");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NotaDeDebito", -1, "ultraDropDownNdeC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoPrestacionProgramada", -1, "ultraDropDownCodigos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDeDestinoPrestacionProgramada", -1, "ultraDropDownTiposDeDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreEmpresa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FacturaDeCompra", -1, "ultraDropDownRecibo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Pago", -1, "ultraDropDownRecibo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Caja_Despachador", -1, "ultraDropDownEmpleados");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanConsultorio", -1, "ultraDropDownPlanes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteVarios", -1, "ultraDropDownClientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NegocioAfiliados", -1, "ultraDropDownNegocios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUITEmpresa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IVACompras", -1, "ultraDropDownRubros");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PagosEfectivo", -1, "ultraDropDownRubros");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PagosConValores", -1, "ultraDropDownRubros");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance195 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeDocumento", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.Appearance appearance196 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance197 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance198 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance199 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance200 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance201 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance202 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance203 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance204 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeComprobante", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteNegativo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DiscriminaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsFactura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TablaAFIP");
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance155 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance156 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeComprobante", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteNegativo", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DiscriminaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsFactura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TablaAFIP");
            Infragistics.Win.Appearance appearance157 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance158 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance159 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance160 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance161 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance162 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance163 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance164 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeComprobante", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteNegativo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DiscriminaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsFactura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TablaAFIP");
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDevolucionCobranza", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDevolucionCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDevolucionCobranza", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDevolucionCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance212 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance213 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance214 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance215 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance216 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance217 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance218 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance219 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance220 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance221 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDevolucionCobranza", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn75 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDevolucionCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn76 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDevolucionCobranza", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn77 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDevolucionCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn78 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance84 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance86 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand10 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Coberturas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn79 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobertura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn80 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance95 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance96 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance97 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance98 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance99 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance100 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance101 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance102 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand11 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Codigos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn81 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCodigo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn82 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn83 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Color");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn84 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jerarquia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn85 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TiempoDeLlegada");
            Infragistics.Win.Appearance appearance103 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance142 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance143 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance144 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance175 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance176 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance177 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance178 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance179 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance180 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand12 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeDestino", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn86 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn87 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn88 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ConPacienteABordo");
            Infragistics.Win.Appearance appearance181 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance114 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance115 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance116 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance117 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance118 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance119 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance120 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance121 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance122 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand13 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDeBaja", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn89 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeBaja");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn90 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance123 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance124 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance125 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance126 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance127 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance128 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance129 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance130 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance131 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance145 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand14 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn91 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn92 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn93 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn94 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn95 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn96 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn97 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance146 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance147 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance148 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance149 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance150 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance151 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance152 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance153 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance154 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance132 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand15 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TandasDeFacturacion", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn98 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTandaDeFacturacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn99 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn100 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance133 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance134 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance135 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance136 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance137 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance138 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance139 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance140 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance141 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand16 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PuntosDeVenta", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn101 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPuntoDeVenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn102 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Prefijo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn103 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn104 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn105 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn106 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn107 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Verdadero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn108 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn109 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn110 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn111 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn112 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SolicitaCAE");
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand17 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Medicamentos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn113 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn114 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn115 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn116 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamentoCategoria");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn117 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidades");
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance109 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance184 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand18 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Planes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn118 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn119 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn120 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn121 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn122 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PadronExterno");
            Infragistics.Win.Appearance appearance185 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance186 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance187 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance188 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance189 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance190 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance191 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance192 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance193 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand19 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ClientesLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn123 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn124 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn125 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIva");
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance165 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand20 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Negocios", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance166 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance167 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance168 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance169 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance170 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance171 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance172 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance173 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance174 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand21 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Rubros", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn126 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn127 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn128 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AdmiteValores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn129 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn130 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo");
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            this.parametrosUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.sistemasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistemas = new Administración.WS.DsSistemas();
            this.ultraDropDownDNI = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeDocumento = new Administración.WS.DsTiposDeDocumento();
            this.ultraDropDownFactura = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeComprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeComprobante = new Administración.WS.DsTiposDeComprobante();
            this.ultraDropDownNdeC = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownRecibo = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownMotiDevCobCobro = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.motivosDevolucionCobranzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMotivosDevolucionCobranza = new Administración.WS.DsMotivosDevolucionCobranza();
            this.ultraDropDownMotiDevCobSaldoCero = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownMotiDevCobBaja = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownCoberturas = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.coberturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCoberturas = new Administración.WS.DsCoberturas();
            this.ultraDropDownCodigos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.codigosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCodigos = new Administración.WS.DsCodigos();
            this.ultraDropDownTiposDeDestino = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeDestinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeDestino = new Administración.WS.DsTiposDeDestino();
            this.ultraDropDownMotivosDeBaja = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.motivosDeBajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMotivosDeBaja = new Administración.WS.DsMotivosDeBaja();
            this.ultraDropDownEmpleados = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.empleadosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmpleadosLista = new Administración.WS.DsEmpleadosLista();
            this.ultraDropDownTandasDeFacturacion = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tandasDeFacturacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTandasDeFacturacion = new Administración.WS.DsTandasDeFacturacion();
            this.ultraDropDownPuntoDeVenta = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.puntosDeVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPuntosDeVenta = new Administración.WS.DsPuntosDeVenta();
            this.ultraDropDownMedicamentos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.medicamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMedicamentos = new Administración.WS.DsMedicamentos();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPlanes = new Administración.WS.DsPlanes();
            this.ultraDropDownPlanes = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsClientesLista = new Administración.WS.DsClientesLista();
            this.clientesListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownClientes = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.negociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNegocios = new Administración.WS.DsNegocios();
            this.ultraDropDownNegocios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsRubros = new Administración.WS.DsRubros();
            this.rubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownRubros = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parametrosUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNdeC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRecibo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotiDevCobCobro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDevolucionCobranzaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDevolucionCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotiDevCobSaldoCero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotiDevCobBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotiDevCobCambioPeriodoCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCoberturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coberturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoberturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDestinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivosDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeBajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTandasDeFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tandasDeFacturacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTandasDeFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPuntoDeVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntosDeVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRubros)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(451, 15);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(340, 15);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(5);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 594);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(568, 57);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(232, 15);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // parametrosUltraGrid
            // 
            this.parametrosUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parametrosUltraGrid.DataSource = this.sistemasBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.parametrosUltraGrid.DisplayLayout.Appearance = appearance1;
            this.parametrosUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.CardSettings.AutoFit = true;
            ultraGridBand1.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand1.CardSettings.ShowCaption = false;
            ultraGridBand1.CardView = true;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn7.Header.Caption = "Comprobante Factura Cuota Afiliados";
            ultraGridColumn7.Header.VisiblePosition = 1;
            ultraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn8.Header.Caption = "Comprobante Factura Prestaciones";
            ultraGridColumn8.Header.VisiblePosition = 2;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn9.Header.VisiblePosition = 7;
            ultraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList;
            ultraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn10.Header.Caption = "Motivo Devolución Cobranza - Saldo cero";
            ultraGridColumn10.Header.VisiblePosition = 8;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn11.Header.Caption = "Motivo Devolución Cobranza - Baja";
            ultraGridColumn11.Header.VisiblePosition = 9;
            ultraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn12.Header.Caption = "Cobertura - Afiliado";
            ultraGridColumn12.Header.VisiblePosition = 10;
            ultraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn13.Header.Caption = "Cobertura - Contrato";
            ultraGridColumn13.Header.VisiblePosition = 11;
            ultraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn14.Header.VisiblePosition = 12;
            ultraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn15.Header.Caption = "Internación";
            ultraGridColumn15.Header.VisiblePosition = 13;
            ultraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance2.TextHAlignAsString = "Right";
            ultraGridColumn16.CellAppearance = appearance2;
            ultraGridColumn16.Header.Caption = "Máxima Cantidad de Detalles por Comprobante";
            ultraGridColumn16.Header.VisiblePosition = 14;
            ultraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn17.Header.VisiblePosition = 15;
            ultraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn18.Header.VisiblePosition = 16;
            ultraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn19.Header.VisiblePosition = 17;
            ultraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn20.Header.Caption = "Punto de Venta Prestaciones";
            ultraGridColumn20.Header.VisiblePosition = 3;
            ultraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn21.Header.VisiblePosition = 18;
            ultraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn22.Header.VisiblePosition = 19;
            ultraGridColumn22.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn23.Header.VisiblePosition = 0;
            ultraGridColumn23.Hidden = true;
            ultraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn24.Header.Caption = "Cobrador de Bajas";
            ultraGridColumn24.Header.VisiblePosition = 20;
            ultraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn25.Header.Caption = "Cobrador de Morosos";
            ultraGridColumn25.Header.VisiblePosition = 21;
            ultraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn26.Header.VisiblePosition = 22;
            ultraGridColumn26.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn27.Header.VisiblePosition = 6;
            ultraGridColumn27.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn28.Header.VisiblePosition = 23;
            ultraGridColumn28.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn29.Header.VisiblePosition = 24;
            ultraGridColumn29.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn30.Header.VisiblePosition = 25;
            ultraGridColumn31.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn31.Header.VisiblePosition = 26;
            ultraGridColumn31.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn32.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn32.Header.VisiblePosition = 28;
            ultraGridColumn32.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn33.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn33.Header.VisiblePosition = 29;
            ultraGridColumn33.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn34.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn34.Header.VisiblePosition = 30;
            ultraGridColumn34.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn35.Header.VisiblePosition = 27;
            ultraGridColumn36.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn36.Header.Caption = "Negocio Afiliados";
            ultraGridColumn36.Header.VisiblePosition = 31;
            ultraGridColumn36.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn37.Header.VisiblePosition = 32;
            ultraGridColumn37.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn37.MaskInput = "##-##,###,###-#";
            ultraGridColumn38.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn38.Header.VisiblePosition = 33;
            ultraGridColumn38.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn39.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn39.Header.Caption = "Caja";
            ultraGridColumn39.Header.VisiblePosition = 34;
            ultraGridColumn39.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn40.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn40.Header.Caption = "ValoresEnCartera";
            ultraGridColumn40.Header.VisiblePosition = 35;
            ultraGridColumn40.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25,
            ultraGridColumn26,
            ultraGridColumn27,
            ultraGridColumn28,
            ultraGridColumn29,
            ultraGridColumn30,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34,
            ultraGridColumn35,
            ultraGridColumn36,
            ultraGridColumn37,
            ultraGridColumn38,
            ultraGridColumn39,
            ultraGridColumn40});
            appearance3.TextHAlignAsString = "Left";
            ultraGridBand1.Header.Appearance = appearance3;
            ultraGridBand1.MaxRows = 1;
            this.parametrosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.parametrosUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.parametrosUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.parametrosUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            this.parametrosUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.parametrosUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.parametrosUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.parametrosUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.parametrosUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.parametrosUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.parametrosUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.parametrosUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.parametrosUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance7.BackColor = System.Drawing.Color.Transparent;
            this.parametrosUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BackColor = System.Drawing.SystemColors.Control;
            appearance8.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.parametrosUltraGrid.DisplayLayout.Override.CellAppearance = appearance8;
            this.parametrosUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance9.TextHAlignAsString = "Right";
            appearance9.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.parametrosUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance9;
            this.parametrosUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance10.ForeColor = System.Drawing.Color.Red;
            this.parametrosUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance10;
            this.parametrosUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.parametrosUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance11;
            appearance12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance12.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.parametrosUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance13.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.parametrosUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance13;
            this.parametrosUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.parametrosUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.parametrosUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.parametrosUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.parametrosUltraGrid.Location = new System.Drawing.Point(-4, 1);
            this.parametrosUltraGrid.Margin = new System.Windows.Forms.Padding(4);
            this.parametrosUltraGrid.Name = "parametrosUltraGrid";
            this.parametrosUltraGrid.Size = new System.Drawing.Size(568, 601);
            this.parametrosUltraGrid.TabIndex = 2;
            this.parametrosUltraGrid.AfterEnterEditMode += new System.EventHandler(this.ParametrosUltraGridAfterEnterEditMode);
            this.parametrosUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.parametrosUltraGrid_KeyDown);
            // 
            // sistemasBindingSource
            // 
            this.sistemasBindingSource.DataMember = "Sistemas";
            this.sistemasBindingSource.DataSource = this.dsSistemas;
            // 
            // dsSistemas
            // 
            this.dsSistemas.DataSetName = "DsSistemas";
            this.dsSistemas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownDNI
            // 
            this.ultraDropDownDNI.DataSource = this.tiposDeDocumentoBindingSource;
            appearance195.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance195.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance195.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownDNI.DisplayLayout.Appearance = appearance195;
            ultraGridBand2.ColHeadersVisible = false;
            ultraGridColumn41.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn41.Header.VisiblePosition = 0;
            ultraGridColumn41.Hidden = true;
            ultraGridColumn41.Width = 37;
            ultraGridColumn42.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn42.Header.VisiblePosition = 1;
            ultraGridColumn42.Width = 101;
            ultraGridColumn43.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn43.Header.VisiblePosition = 2;
            ultraGridColumn43.Hidden = true;
            ultraGridColumn43.Width = 32;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn41,
            ultraGridColumn42,
            ultraGridColumn43});
            this.ultraDropDownDNI.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraDropDownDNI.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownDNI.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownDNI.DisplayLayout.MaxBandDepth = 5;
            appearance196.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownDNI.DisplayLayout.Override.ActiveCellAppearance = appearance196;
            appearance197.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance197.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance197.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance197.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownDNI.DisplayLayout.Override.ActiveRowAppearance = appearance197;
            this.ultraDropDownDNI.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownDNI.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownDNI.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownDNI.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownDNI.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownDNI.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownDNI.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance198.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownDNI.DisplayLayout.Override.CardAreaAppearance = appearance198;
            appearance199.BackColor = System.Drawing.SystemColors.Control;
            appearance199.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance199.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownDNI.DisplayLayout.Override.CellAppearance = appearance199;
            this.ultraDropDownDNI.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance200.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance200.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance200.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance200.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance200.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownDNI.DisplayLayout.Override.HeaderAppearance = appearance200;
            this.ultraDropDownDNI.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance201.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownDNI.DisplayLayout.Override.RowSelectorAppearance = appearance201;
            this.ultraDropDownDNI.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance202.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownDNI.DisplayLayout.Override.SelectedCellAppearance = appearance202;
            appearance203.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance203.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance203.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownDNI.DisplayLayout.Override.SelectedRowAppearance = appearance203;
            appearance204.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance204.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownDNI.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance204;
            this.ultraDropDownDNI.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownDNI.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownDNI.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownDNI.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownDNI.DisplayMember = "Iniciales";
            this.ultraDropDownDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownDNI.Location = new System.Drawing.Point(279, 15);
            this.ultraDropDownDNI.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownDNI.Name = "ultraDropDownDNI";
            this.ultraDropDownDNI.Size = new System.Drawing.Size(251, 39);
            this.ultraDropDownDNI.TabIndex = 11;
            this.ultraDropDownDNI.ValueMember = "idTipoDeDocumento";
            this.ultraDropDownDNI.Visible = false;
            this.ultraDropDownDNI.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownDNIBeforeDropDown);
            // 
            // tiposDeDocumentoBindingSource
            // 
            this.tiposDeDocumentoBindingSource.DataMember = "TiposDeDocumento";
            this.tiposDeDocumentoBindingSource.DataSource = this.dsTiposDeDocumento;
            // 
            // dsTiposDeDocumento
            // 
            this.dsTiposDeDocumento.DataSetName = "DsTiposDeDocumento";
            this.dsTiposDeDocumento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownFactura
            // 
            this.ultraDropDownFactura.DataSource = this.tiposDeComprobanteBindingSource;
            appearance24.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance24.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownFactura.DisplayLayout.Appearance = appearance24;
            ultraGridBand3.ColHeadersVisible = false;
            ultraGridColumn44.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn44.Header.VisiblePosition = 0;
            ultraGridColumn44.Hidden = true;
            ultraGridColumn44.Width = 23;
            ultraGridColumn45.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn45.Header.VisiblePosition = 1;
            ultraGridColumn45.Width = 101;
            ultraGridColumn46.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn46.Header.VisiblePosition = 2;
            ultraGridColumn46.Hidden = true;
            ultraGridColumn46.Width = 20;
            ultraGridColumn47.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn47.Header.VisiblePosition = 3;
            ultraGridColumn47.Hidden = true;
            ultraGridColumn47.Width = 20;
            ultraGridColumn48.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn48.Header.VisiblePosition = 4;
            ultraGridColumn48.Hidden = true;
            ultraGridColumn48.Width = 18;
            ultraGridColumn49.Header.VisiblePosition = 5;
            ultraGridColumn49.Hidden = true;
            ultraGridColumn50.Header.VisiblePosition = 6;
            ultraGridColumn50.Hidden = true;
            ultraGridColumn51.Header.VisiblePosition = 7;
            ultraGridColumn51.Hidden = true;
            ultraGridColumn52.Header.VisiblePosition = 8;
            ultraGridColumn52.Hidden = true;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn44,
            ultraGridColumn45,
            ultraGridColumn46,
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49,
            ultraGridColumn50,
            ultraGridColumn51,
            ultraGridColumn52});
            this.ultraDropDownFactura.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownFactura.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownFactura.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownFactura.DisplayLayout.MaxBandDepth = 5;
            this.ultraDropDownFactura.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownFactura.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownFactura.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownFactura.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownFactura.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownFactura.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownFactura.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance25.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownFactura.DisplayLayout.Override.CardAreaAppearance = appearance25;
            appearance26.BackColor = System.Drawing.SystemColors.Control;
            appearance26.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownFactura.DisplayLayout.Override.CellAppearance = appearance26;
            this.ultraDropDownFactura.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance27.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance27.BackColor2 = System.Drawing.SystemColors.Control;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance27.FontData.BoldAsString = "False";
            appearance27.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownFactura.DisplayLayout.Override.HeaderAppearance = appearance27;
            this.ultraDropDownFactura.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance28.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ultraDropDownFactura.DisplayLayout.Override.RowSelectorAppearance = appearance28;
            this.ultraDropDownFactura.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownFactura.DisplayLayout.Override.SelectedCellAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance30.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownFactura.DisplayLayout.Override.SelectedRowAppearance = appearance30;
            appearance155.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance155.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownFactura.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance155;
            this.ultraDropDownFactura.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownFactura.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownFactura.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownFactura.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownFactura.DisplayMember = "Nombre";
            this.ultraDropDownFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownFactura.Location = new System.Drawing.Point(279, 108);
            this.ultraDropDownFactura.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownFactura.Name = "ultraDropDownFactura";
            this.ultraDropDownFactura.Size = new System.Drawing.Size(251, 39);
            this.ultraDropDownFactura.TabIndex = 12;
            this.ultraDropDownFactura.ValueMember = "idTipoDeComprobante";
            this.ultraDropDownFactura.Visible = false;
            this.ultraDropDownFactura.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownFacturaBeforeDropDown);
            // 
            // tiposDeComprobanteBindingSource
            // 
            this.tiposDeComprobanteBindingSource.DataMember = "TiposDeComprobante";
            this.tiposDeComprobanteBindingSource.DataSource = this.dsTiposDeComprobante;
            // 
            // dsTiposDeComprobante
            // 
            this.dsTiposDeComprobante.DataSetName = "DsTiposDeComprobante";
            this.dsTiposDeComprobante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownNdeC
            // 
            this.ultraDropDownNdeC.DataSource = this.tiposDeComprobanteBindingSource;
            appearance156.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance156.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance156.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownNdeC.DisplayLayout.Appearance = appearance156;
            ultraGridBand4.ColHeadersVisible = false;
            ultraGridColumn53.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn53.Header.VisiblePosition = 0;
            ultraGridColumn53.Hidden = true;
            ultraGridColumn53.Width = 23;
            ultraGridColumn54.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn54.Header.VisiblePosition = 1;
            ultraGridColumn54.Width = 101;
            ultraGridColumn55.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn55.Header.VisiblePosition = 2;
            ultraGridColumn55.Hidden = true;
            ultraGridColumn55.Width = 20;
            ultraGridColumn56.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn56.Header.VisiblePosition = 3;
            ultraGridColumn56.Hidden = true;
            ultraGridColumn56.Width = 20;
            ultraGridColumn57.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn57.Header.VisiblePosition = 4;
            ultraGridColumn57.Hidden = true;
            ultraGridColumn57.Width = 18;
            ultraGridColumn58.Header.VisiblePosition = 5;
            ultraGridColumn58.Hidden = true;
            ultraGridColumn59.Header.VisiblePosition = 6;
            ultraGridColumn59.Hidden = true;
            ultraGridColumn60.Header.VisiblePosition = 7;
            ultraGridColumn60.Hidden = true;
            ultraGridColumn61.Header.VisiblePosition = 8;
            ultraGridColumn61.Hidden = true;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn53,
            ultraGridColumn54,
            ultraGridColumn55,
            ultraGridColumn56,
            ultraGridColumn57,
            ultraGridColumn58,
            ultraGridColumn59,
            ultraGridColumn60,
            ultraGridColumn61});
            this.ultraDropDownNdeC.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownNdeC.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownNdeC.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownNdeC.DisplayLayout.MaxBandDepth = 5;
            appearance157.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownNdeC.DisplayLayout.Override.ActiveCellAppearance = appearance157;
            appearance158.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance158.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance158.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance158.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownNdeC.DisplayLayout.Override.ActiveRowAppearance = appearance158;
            this.ultraDropDownNdeC.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownNdeC.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownNdeC.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNdeC.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownNdeC.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNdeC.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownNdeC.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance159.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownNdeC.DisplayLayout.Override.CardAreaAppearance = appearance159;
            appearance160.BackColor = System.Drawing.SystemColors.Control;
            appearance160.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance160.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNdeC.DisplayLayout.Override.CellAppearance = appearance160;
            this.ultraDropDownNdeC.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance161.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance161.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance161.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance161.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance161.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownNdeC.DisplayLayout.Override.HeaderAppearance = appearance161;
            this.ultraDropDownNdeC.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance162.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownNdeC.DisplayLayout.Override.RowSelectorAppearance = appearance162;
            this.ultraDropDownNdeC.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance163.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownNdeC.DisplayLayout.Override.SelectedCellAppearance = appearance163;
            appearance164.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance164.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance164.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNdeC.DisplayLayout.Override.SelectedRowAppearance = appearance164;
            appearance41.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance41.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownNdeC.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance41;
            this.ultraDropDownNdeC.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownNdeC.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownNdeC.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownNdeC.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownNdeC.DisplayMember = "Nombre";
            this.ultraDropDownNdeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownNdeC.Location = new System.Drawing.Point(20, 249);
            this.ultraDropDownNdeC.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownNdeC.Name = "ultraDropDownNdeC";
            this.ultraDropDownNdeC.Size = new System.Drawing.Size(251, 42);
            this.ultraDropDownNdeC.TabIndex = 13;
            this.ultraDropDownNdeC.ValueMember = "idTipoDeComprobante";
            this.ultraDropDownNdeC.Visible = false;
            this.ultraDropDownNdeC.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownNdeCBeforeDropDown);
            // 
            // ultraDropDownRecibo
            // 
            this.ultraDropDownRecibo.DataSource = this.tiposDeComprobanteBindingSource;
            appearance42.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance42.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownRecibo.DisplayLayout.Appearance = appearance42;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn62.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn62.Header.VisiblePosition = 0;
            ultraGridColumn62.Hidden = true;
            ultraGridColumn62.Width = 23;
            ultraGridColumn63.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn63.Header.VisiblePosition = 1;
            ultraGridColumn63.Width = 101;
            ultraGridColumn64.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn64.Header.VisiblePosition = 2;
            ultraGridColumn64.Hidden = true;
            ultraGridColumn64.Width = 20;
            ultraGridColumn65.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn65.Header.VisiblePosition = 3;
            ultraGridColumn65.Hidden = true;
            ultraGridColumn65.Width = 20;
            ultraGridColumn66.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn66.Header.VisiblePosition = 4;
            ultraGridColumn66.Hidden = true;
            ultraGridColumn66.Width = 18;
            ultraGridColumn67.Header.VisiblePosition = 5;
            ultraGridColumn67.Hidden = true;
            ultraGridColumn68.Header.VisiblePosition = 6;
            ultraGridColumn68.Hidden = true;
            ultraGridColumn69.Header.VisiblePosition = 7;
            ultraGridColumn69.Hidden = true;
            ultraGridColumn70.Header.VisiblePosition = 8;
            ultraGridColumn70.Hidden = true;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn62,
            ultraGridColumn63,
            ultraGridColumn64,
            ultraGridColumn65,
            ultraGridColumn66,
            ultraGridColumn67,
            ultraGridColumn68,
            ultraGridColumn69,
            ultraGridColumn70});
            this.ultraDropDownRecibo.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.ultraDropDownRecibo.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownRecibo.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownRecibo.DisplayLayout.MaxBandDepth = 5;
            appearance43.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownRecibo.DisplayLayout.Override.ActiveCellAppearance = appearance43;
            appearance44.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance44.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance44.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownRecibo.DisplayLayout.Override.ActiveRowAppearance = appearance44;
            this.ultraDropDownRecibo.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownRecibo.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownRecibo.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRecibo.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownRecibo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRecibo.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownRecibo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance45.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownRecibo.DisplayLayout.Override.CardAreaAppearance = appearance45;
            appearance46.BackColor = System.Drawing.SystemColors.Control;
            appearance46.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRecibo.DisplayLayout.Override.CellAppearance = appearance46;
            this.ultraDropDownRecibo.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance47.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance47.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance47.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance47.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownRecibo.DisplayLayout.Override.HeaderAppearance = appearance47;
            this.ultraDropDownRecibo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance48.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownRecibo.DisplayLayout.Override.RowSelectorAppearance = appearance48;
            this.ultraDropDownRecibo.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownRecibo.DisplayLayout.Override.SelectedCellAppearance = appearance49;
            appearance50.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance50.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRecibo.DisplayLayout.Override.SelectedRowAppearance = appearance50;
            appearance51.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance51.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownRecibo.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance51;
            this.ultraDropDownRecibo.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownRecibo.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownRecibo.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownRecibo.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownRecibo.DisplayMember = "Nombre";
            this.ultraDropDownRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownRecibo.Location = new System.Drawing.Point(279, 202);
            this.ultraDropDownRecibo.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownRecibo.Name = "ultraDropDownRecibo";
            this.ultraDropDownRecibo.Size = new System.Drawing.Size(251, 39);
            this.ultraDropDownRecibo.TabIndex = 14;
            this.ultraDropDownRecibo.ValueMember = "idTipoDeComprobante";
            this.ultraDropDownRecibo.Visible = false;
            this.ultraDropDownRecibo.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownReciboBeforeDropDown);
            // 
            // ultraDropDownMotiDevCobCobro
            // 
            this.ultraDropDownMotiDevCobCobro.DataSource = this.motivosDevolucionCobranzaBindingSource;
            appearance52.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance52.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Appearance = appearance52;
            ultraGridBand6.ColHeadersVisible = false;
            ultraGridColumn71.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn71.Header.VisiblePosition = 0;
            ultraGridColumn71.Hidden = true;
            ultraGridColumn71.Width = 62;
            ultraGridColumn72.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn72.Header.VisiblePosition = 1;
            ultraGridColumn72.Width = 101;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn71,
            ultraGridColumn72});
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.MaxBandDepth = 5;
            appearance53.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.ActiveCellAppearance = appearance53;
            appearance54.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance54.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance54.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.ActiveRowAppearance = appearance54;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance55.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.CardAreaAppearance = appearance55;
            appearance56.BackColor = System.Drawing.SystemColors.Control;
            appearance56.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.CellAppearance = appearance56;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance57.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance57.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance57.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance57.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.HeaderAppearance = appearance57;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance58.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.RowSelectorAppearance = appearance58;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.SelectedCellAppearance = appearance59;
            appearance60.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance60.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.SelectedRowAppearance = appearance60;
            appearance61.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance61.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance61;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMotiDevCobCobro.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMotiDevCobCobro.DisplayMember = "Nombre";
            this.ultraDropDownMotiDevCobCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMotiDevCobCobro.Location = new System.Drawing.Point(20, 15);
            this.ultraDropDownMotiDevCobCobro.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownMotiDevCobCobro.Name = "ultraDropDownMotiDevCobCobro";
            this.ultraDropDownMotiDevCobCobro.Size = new System.Drawing.Size(251, 39);
            this.ultraDropDownMotiDevCobCobro.TabIndex = 15;
            this.ultraDropDownMotiDevCobCobro.ValueMember = "idMotivoDevolucionCobranza";
            this.ultraDropDownMotiDevCobCobro.Visible = false;
            this.ultraDropDownMotiDevCobCobro.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownMotiDevCobCobroBeforeDropDown);
            // 
            // motivosDevolucionCobranzaBindingSource
            // 
            this.motivosDevolucionCobranzaBindingSource.DataMember = "MotivosDevolucionCobranza";
            this.motivosDevolucionCobranzaBindingSource.DataSource = this.dsMotivosDevolucionCobranza;
            // 
            // dsMotivosDevolucionCobranza
            // 
            this.dsMotivosDevolucionCobranza.DataSetName = "DsMotivosDevolucionCobranza";
            this.dsMotivosDevolucionCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownMotiDevCobSaldoCero
            // 
            this.ultraDropDownMotiDevCobSaldoCero.DataSource = this.motivosDevolucionCobranzaBindingSource;
            appearance62.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance62.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Appearance = appearance62;
            ultraGridBand7.ColHeadersVisible = false;
            ultraGridColumn73.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn73.Header.VisiblePosition = 0;
            ultraGridColumn73.Hidden = true;
            ultraGridColumn73.Width = 62;
            ultraGridColumn74.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn74.Header.VisiblePosition = 1;
            ultraGridColumn74.Width = 101;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn73,
            ultraGridColumn74});
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.MaxBandDepth = 5;
            appearance212.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.ActiveCellAppearance = appearance212;
            appearance213.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance213.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance213.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance213.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.ActiveRowAppearance = appearance213;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance214.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.CardAreaAppearance = appearance214;
            appearance215.BackColor = System.Drawing.SystemColors.Control;
            appearance215.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance215.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.CellAppearance = appearance215;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance216.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance216.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance216.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance216.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance216.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.HeaderAppearance = appearance216;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance217.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.RowSelectorAppearance = appearance217;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance218.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.SelectedCellAppearance = appearance218;
            appearance219.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance219.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance219.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.SelectedRowAppearance = appearance219;
            appearance220.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance220.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance220;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMotiDevCobSaldoCero.DisplayMember = "Nombre";
            this.ultraDropDownMotiDevCobSaldoCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMotiDevCobSaldoCero.Location = new System.Drawing.Point(279, 62);
            this.ultraDropDownMotiDevCobSaldoCero.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownMotiDevCobSaldoCero.Name = "ultraDropDownMotiDevCobSaldoCero";
            this.ultraDropDownMotiDevCobSaldoCero.Size = new System.Drawing.Size(251, 39);
            this.ultraDropDownMotiDevCobSaldoCero.TabIndex = 16;
            this.ultraDropDownMotiDevCobSaldoCero.ValueMember = "idMotivoDevolucionCobranza";
            this.ultraDropDownMotiDevCobSaldoCero.Visible = false;
            this.ultraDropDownMotiDevCobSaldoCero.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownMotiDevCobSaldoCeroBeforeDropDown);
            // 
            // ultraDropDownMotiDevCobBaja
            // 
            this.ultraDropDownMotiDevCobBaja.DataSource = this.motivosDevolucionCobranzaBindingSource;
            appearance221.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance221.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance221.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Appearance = appearance221;
            ultraGridBand8.ColHeadersVisible = false;
            ultraGridColumn75.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn75.Header.VisiblePosition = 0;
            ultraGridColumn75.Hidden = true;
            ultraGridColumn75.Width = 62;
            ultraGridColumn76.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn76.Header.VisiblePosition = 1;
            ultraGridColumn76.Width = 101;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn75,
            ultraGridColumn76});
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.MaxBandDepth = 5;
            appearance73.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.ActiveCellAppearance = appearance73;
            appearance74.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance74.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance74.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.ActiveRowAppearance = appearance74;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance75.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.CardAreaAppearance = appearance75;
            appearance76.BackColor = System.Drawing.SystemColors.Control;
            appearance76.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance76.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.CellAppearance = appearance76;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance77.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance77.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance77.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance77.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance77.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.HeaderAppearance = appearance77;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance78.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.RowSelectorAppearance = appearance78;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance79.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.SelectedCellAppearance = appearance79;
            appearance80.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance80.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance80.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.SelectedRowAppearance = appearance80;
            appearance81.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance81.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance81;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMotiDevCobBaja.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMotiDevCobBaja.DisplayMember = "Nombre";
            this.ultraDropDownMotiDevCobBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMotiDevCobBaja.Location = new System.Drawing.Point(20, 108);
            this.ultraDropDownMotiDevCobBaja.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownMotiDevCobBaja.Name = "ultraDropDownMotiDevCobBaja";
            this.ultraDropDownMotiDevCobBaja.Size = new System.Drawing.Size(251, 39);
            this.ultraDropDownMotiDevCobBaja.TabIndex = 17;
            this.ultraDropDownMotiDevCobBaja.ValueMember = "idMotivoDevolucionCobranza";
            this.ultraDropDownMotiDevCobBaja.Visible = false;
            this.ultraDropDownMotiDevCobBaja.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownMotiDevCobBajaBeforeDropDown);
            // 
            // ultraDropDownMotiDevCobCambioPeriodoCobranza
            // 
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DataSource = this.motivosDevolucionCobranzaBindingSource;
            appearance82.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance82.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance82.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Appearance = appearance82;
            ultraGridBand9.ColHeadersVisible = false;
            ultraGridColumn77.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn77.Header.VisiblePosition = 0;
            ultraGridColumn77.Hidden = true;
            ultraGridColumn77.Width = 62;
            ultraGridColumn78.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn78.Header.VisiblePosition = 1;
            ultraGridColumn78.Width = 101;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn77,
            ultraGridColumn78});
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.MaxBandDepth = 5;
            appearance83.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.ActiveCellAppearance = appearance83;
            appearance84.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance84.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance84.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.ActiveRowAppearance = appearance84;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance85.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.CardAreaAppearance = appearance85;
            appearance86.BackColor = System.Drawing.SystemColors.Control;
            appearance86.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance86.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.CellAppearance = appearance86;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance87.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance87.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance87.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance87.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.HeaderAppearance = appearance87;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance88.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.RowSelectorAppearance = appearance88;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance89.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.SelectedCellAppearance = appearance89;
            appearance90.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance90.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance90.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.SelectedRowAppearance = appearance90;
            appearance91.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance91.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance91;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayMember = "Nombre";
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.Location = new System.Drawing.Point(20, 62);
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.Name = "ultraDropDownMotiDevCobCambioPeriodoCobranza";
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.Size = new System.Drawing.Size(251, 39);
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.TabIndex = 18;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.ValueMember = "idMotivoDevolucionCobranza";
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.Visible = false;
            this.ultraDropDownMotiDevCobCambioPeriodoCobranza.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownMotiDevCobCambioPeriodoCobranzaBeforeDropDown);
            // 
            // ultraDropDownCoberturas
            // 
            this.ultraDropDownCoberturas.DataSource = this.coberturasBindingSource;
            appearance92.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance92.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance92.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCoberturas.DisplayLayout.Appearance = appearance92;
            ultraGridBand10.ColHeadersVisible = false;
            ultraGridColumn79.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn79.Header.VisiblePosition = 0;
            ultraGridColumn79.Hidden = true;
            ultraGridColumn79.Width = 43;
            ultraGridColumn80.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn80.Header.VisiblePosition = 1;
            ultraGridColumn80.Width = 101;
            ultraGridBand10.Columns.AddRange(new object[] {
            ultraGridColumn79,
            ultraGridColumn80});
            this.ultraDropDownCoberturas.DisplayLayout.BandsSerializer.Add(ultraGridBand10);
            this.ultraDropDownCoberturas.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCoberturas.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCoberturas.DisplayLayout.MaxBandDepth = 5;
            appearance93.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCoberturas.DisplayLayout.Override.ActiveCellAppearance = appearance93;
            appearance94.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance94.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance94.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance94.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCoberturas.DisplayLayout.Override.ActiveRowAppearance = appearance94;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance95.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCoberturas.DisplayLayout.Override.CardAreaAppearance = appearance95;
            appearance96.BackColor = System.Drawing.SystemColors.Control;
            appearance96.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance96.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCoberturas.DisplayLayout.Override.CellAppearance = appearance96;
            this.ultraDropDownCoberturas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance97.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance97.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance97.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance97.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance97.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCoberturas.DisplayLayout.Override.HeaderAppearance = appearance97;
            this.ultraDropDownCoberturas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance98.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCoberturas.DisplayLayout.Override.RowSelectorAppearance = appearance98;
            this.ultraDropDownCoberturas.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance99.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCoberturas.DisplayLayout.Override.SelectedCellAppearance = appearance99;
            appearance100.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance100.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance100.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCoberturas.DisplayLayout.Override.SelectedRowAppearance = appearance100;
            appearance101.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance101.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCoberturas.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance101;
            this.ultraDropDownCoberturas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCoberturas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCoberturas.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCoberturas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCoberturas.DisplayMember = "Nombre";
            this.ultraDropDownCoberturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCoberturas.Location = new System.Drawing.Point(20, 155);
            this.ultraDropDownCoberturas.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownCoberturas.Name = "ultraDropDownCoberturas";
            this.ultraDropDownCoberturas.Size = new System.Drawing.Size(251, 39);
            this.ultraDropDownCoberturas.TabIndex = 19;
            this.ultraDropDownCoberturas.ValueMember = "idCobertura";
            this.ultraDropDownCoberturas.Visible = false;
            this.ultraDropDownCoberturas.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCoberturasBeforeDropDown);
            // 
            // coberturasBindingSource
            // 
            this.coberturasBindingSource.DataMember = "Coberturas";
            this.coberturasBindingSource.DataSource = this.dsCoberturas;
            // 
            // dsCoberturas
            // 
            this.dsCoberturas.DataSetName = "DsCoberturas";
            this.dsCoberturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownCodigos
            // 
            this.ultraDropDownCodigos.DataSource = this.codigosBindingSource;
            appearance102.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance102.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance102.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCodigos.DisplayLayout.Appearance = appearance102;
            ultraGridBand11.ColHeadersVisible = false;
            ultraGridColumn81.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn81.Header.VisiblePosition = 0;
            ultraGridColumn81.Hidden = true;
            ultraGridColumn81.Width = 8;
            ultraGridColumn82.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn82.Header.VisiblePosition = 1;
            ultraGridColumn82.Width = 101;
            ultraGridColumn83.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn83.Header.VisiblePosition = 2;
            ultraGridColumn83.Hidden = true;
            ultraGridColumn83.Width = 16;
            ultraGridColumn84.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn84.Header.VisiblePosition = 3;
            ultraGridColumn84.Hidden = true;
            ultraGridColumn84.Width = 10;
            ultraGridColumn85.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn85.Header.VisiblePosition = 4;
            ultraGridColumn85.Hidden = true;
            ultraGridColumn85.Width = 53;
            ultraGridBand11.Columns.AddRange(new object[] {
            ultraGridColumn81,
            ultraGridColumn82,
            ultraGridColumn83,
            ultraGridColumn84,
            ultraGridColumn85});
            this.ultraDropDownCodigos.DisplayLayout.BandsSerializer.Add(ultraGridBand11);
            this.ultraDropDownCodigos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCodigos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCodigos.DisplayLayout.MaxBandDepth = 5;
            appearance103.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCodigos.DisplayLayout.Override.ActiveCellAppearance = appearance103;
            appearance142.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance142.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance142.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance142.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCodigos.DisplayLayout.Override.ActiveRowAppearance = appearance142;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance143.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCodigos.DisplayLayout.Override.CardAreaAppearance = appearance143;
            appearance144.BackColor = System.Drawing.SystemColors.Control;
            appearance144.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance144.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCodigos.DisplayLayout.Override.CellAppearance = appearance144;
            this.ultraDropDownCodigos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance175.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance175.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance175.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance175.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance175.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCodigos.DisplayLayout.Override.HeaderAppearance = appearance175;
            this.ultraDropDownCodigos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance176.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCodigos.DisplayLayout.Override.RowSelectorAppearance = appearance176;
            this.ultraDropDownCodigos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance177.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCodigos.DisplayLayout.Override.SelectedCellAppearance = appearance177;
            appearance178.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance178.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance178.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCodigos.DisplayLayout.Override.SelectedRowAppearance = appearance178;
            appearance179.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance179.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCodigos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance179;
            this.ultraDropDownCodigos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCodigos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCodigos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCodigos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCodigos.DisplayMember = "Nombre";
            this.ultraDropDownCodigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCodigos.Location = new System.Drawing.Point(279, 155);
            this.ultraDropDownCodigos.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownCodigos.Name = "ultraDropDownCodigos";
            this.ultraDropDownCodigos.Size = new System.Drawing.Size(251, 39);
            this.ultraDropDownCodigos.TabIndex = 20;
            this.ultraDropDownCodigos.ValueMember = "idCodigo";
            this.ultraDropDownCodigos.Visible = false;
            this.ultraDropDownCodigos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCodigosBeforeDropDown);
            // 
            // codigosBindingSource
            // 
            this.codigosBindingSource.DataMember = "Codigos";
            this.codigosBindingSource.DataSource = this.dsCodigos;
            // 
            // dsCodigos
            // 
            this.dsCodigos.DataSetName = "DsCodigos";
            this.dsCodigos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTiposDeDestino
            // 
            this.ultraDropDownTiposDeDestino.DataSource = this.tiposDeDestinoBindingSource;
            appearance180.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance180.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance180.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Appearance = appearance180;
            ultraGridBand12.ColHeadersVisible = false;
            ultraGridColumn86.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn86.Header.VisiblePosition = 0;
            ultraGridColumn86.Hidden = true;
            ultraGridColumn86.Width = 31;
            ultraGridColumn87.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn87.Header.VisiblePosition = 1;
            ultraGridColumn87.Width = 101;
            ultraGridColumn88.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn88.Header.VisiblePosition = 2;
            ultraGridColumn88.Hidden = true;
            ultraGridColumn88.Width = 38;
            ultraGridBand12.Columns.AddRange(new object[] {
            ultraGridColumn86,
            ultraGridColumn87,
            ultraGridColumn88});
            this.ultraDropDownTiposDeDestino.DisplayLayout.BandsSerializer.Add(ultraGridBand12);
            this.ultraDropDownTiposDeDestino.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeDestino.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeDestino.DisplayLayout.MaxBandDepth = 5;
            appearance181.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.ActiveCellAppearance = appearance181;
            appearance114.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance114.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance114.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance114.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.ActiveRowAppearance = appearance114;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance115.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.CardAreaAppearance = appearance115;
            appearance116.BackColor = System.Drawing.SystemColors.Control;
            appearance116.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance116.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.CellAppearance = appearance116;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance117.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance117.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance117.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance117.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance117.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.HeaderAppearance = appearance117;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance118.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.RowSelectorAppearance = appearance118;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance119.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.SelectedCellAppearance = appearance119;
            appearance120.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance120.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance120.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.SelectedRowAppearance = appearance120;
            appearance121.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance121.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance121;
            this.ultraDropDownTiposDeDestino.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeDestino.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeDestino.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeDestino.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeDestino.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTiposDeDestino.Location = new System.Drawing.Point(20, 202);
            this.ultraDropDownTiposDeDestino.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownTiposDeDestino.Name = "ultraDropDownTiposDeDestino";
            this.ultraDropDownTiposDeDestino.Size = new System.Drawing.Size(251, 39);
            this.ultraDropDownTiposDeDestino.TabIndex = 21;
            this.ultraDropDownTiposDeDestino.ValueMember = "idTipoDeDestino";
            this.ultraDropDownTiposDeDestino.Visible = false;
            this.ultraDropDownTiposDeDestino.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTiposDeDestinoBeforeDropDown);
            // 
            // tiposDeDestinoBindingSource
            // 
            this.tiposDeDestinoBindingSource.DataMember = "TiposDeDestino";
            this.tiposDeDestinoBindingSource.DataSource = this.dsTiposDeDestino;
            // 
            // dsTiposDeDestino
            // 
            this.dsTiposDeDestino.DataSetName = "DsTiposDeDestino";
            this.dsTiposDeDestino.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownMotivosDeBaja
            // 
            this.ultraDropDownMotivosDeBaja.DataSource = this.motivosDeBajaBindingSource;
            appearance122.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance122.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance122.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Appearance = appearance122;
            ultraGridBand13.ColHeadersVisible = false;
            ultraGridColumn89.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn89.Header.VisiblePosition = 0;
            ultraGridColumn89.Hidden = true;
            ultraGridColumn89.Width = 49;
            ultraGridColumn90.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn90.Header.VisiblePosition = 1;
            ultraGridColumn90.Width = 101;
            ultraGridBand13.Columns.AddRange(new object[] {
            ultraGridColumn89,
            ultraGridColumn90});
            this.ultraDropDownMotivosDeBaja.DisplayLayout.BandsSerializer.Add(ultraGridBand13);
            this.ultraDropDownMotivosDeBaja.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.MaxBandDepth = 5;
            appearance123.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.ActiveCellAppearance = appearance123;
            appearance124.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance124.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance124.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance124.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.ActiveRowAppearance = appearance124;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance125.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.CardAreaAppearance = appearance125;
            appearance126.BackColor = System.Drawing.SystemColors.Control;
            appearance126.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance126.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.CellAppearance = appearance126;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance127.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance127.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance127.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance127.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance127.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.HeaderAppearance = appearance127;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance128.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.RowSelectorAppearance = appearance128;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance129.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.SelectedCellAppearance = appearance129;
            appearance130.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance130.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance130.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.SelectedRowAppearance = appearance130;
            appearance131.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance131.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance131;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMotivosDeBaja.DisplayMember = "Nombre";
            this.ultraDropDownMotivosDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMotivosDeBaja.Location = new System.Drawing.Point(279, 251);
            this.ultraDropDownMotivosDeBaja.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownMotivosDeBaja.Name = "ultraDropDownMotivosDeBaja";
            this.ultraDropDownMotivosDeBaja.Size = new System.Drawing.Size(251, 39);
            this.ultraDropDownMotivosDeBaja.TabIndex = 22;
            this.ultraDropDownMotivosDeBaja.ValueMember = "idMotivoDeBaja";
            this.ultraDropDownMotivosDeBaja.Visible = false;
            this.ultraDropDownMotivosDeBaja.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownMotivosDeBajaBeforeDropDown);
            // 
            // motivosDeBajaBindingSource
            // 
            this.motivosDeBajaBindingSource.DataMember = "MotivosDeBaja";
            this.motivosDeBajaBindingSource.DataSource = this.dsMotivosDeBaja;
            // 
            // dsMotivosDeBaja
            // 
            this.dsMotivosDeBaja.DataSetName = "DsMotivosDeBaja";
            this.dsMotivosDeBaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownEmpleados
            // 
            this.ultraDropDownEmpleados.DataSource = this.empleadosListaBindingSource;
            appearance145.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance145.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance145.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownEmpleados.DisplayLayout.Appearance = appearance145;
            ultraGridBand14.ColHeadersVisible = false;
            ultraGridColumn91.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn91.Header.VisiblePosition = 0;
            ultraGridColumn91.Hidden = true;
            ultraGridColumn91.Width = 8;
            ultraGridColumn92.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn92.Header.VisiblePosition = 2;
            ultraGridColumn92.Hidden = true;
            ultraGridColumn92.Width = 17;
            ultraGridColumn93.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn93.Header.VisiblePosition = 3;
            ultraGridColumn93.Hidden = true;
            ultraGridColumn93.Width = 20;
            ultraGridColumn94.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn94.Header.VisiblePosition = 4;
            ultraGridColumn94.Hidden = true;
            ultraGridColumn94.Width = 20;
            ultraGridColumn95.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn95.Header.VisiblePosition = 1;
            ultraGridColumn95.Width = 101;
            ultraGridColumn96.Header.VisiblePosition = 5;
            ultraGridColumn96.Hidden = true;
            ultraGridColumn97.Header.VisiblePosition = 6;
            ultraGridColumn97.Hidden = true;
            ultraGridBand14.Columns.AddRange(new object[] {
            ultraGridColumn91,
            ultraGridColumn92,
            ultraGridColumn93,
            ultraGridColumn94,
            ultraGridColumn95,
            ultraGridColumn96,
            ultraGridColumn97});
            this.ultraDropDownEmpleados.DisplayLayout.BandsSerializer.Add(ultraGridBand14);
            this.ultraDropDownEmpleados.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownEmpleados.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownEmpleados.DisplayLayout.MaxBandDepth = 5;
            appearance146.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownEmpleados.DisplayLayout.Override.ActiveCellAppearance = appearance146;
            appearance147.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance147.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance147.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance147.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownEmpleados.DisplayLayout.Override.ActiveRowAppearance = appearance147;
            this.ultraDropDownEmpleados.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownEmpleados.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownEmpleados.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEmpleados.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownEmpleados.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEmpleados.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownEmpleados.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance148.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownEmpleados.DisplayLayout.Override.CardAreaAppearance = appearance148;
            appearance149.BackColor = System.Drawing.SystemColors.Control;
            appearance149.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance149.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEmpleados.DisplayLayout.Override.CellAppearance = appearance149;
            this.ultraDropDownEmpleados.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance150.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance150.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance150.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance150.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance150.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownEmpleados.DisplayLayout.Override.HeaderAppearance = appearance150;
            this.ultraDropDownEmpleados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance151.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownEmpleados.DisplayLayout.Override.RowSelectorAppearance = appearance151;
            this.ultraDropDownEmpleados.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance152.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownEmpleados.DisplayLayout.Override.SelectedCellAppearance = appearance152;
            appearance153.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance153.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance153.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEmpleados.DisplayLayout.Override.SelectedRowAppearance = appearance153;
            appearance154.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance154.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownEmpleados.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance154;
            this.ultraDropDownEmpleados.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownEmpleados.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownEmpleados.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownEmpleados.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownEmpleados.DisplayMember = "NombApel";
            this.ultraDropDownEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownEmpleados.Location = new System.Drawing.Point(20, 298);
            this.ultraDropDownEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownEmpleados.Name = "ultraDropDownEmpleados";
            this.ultraDropDownEmpleados.Size = new System.Drawing.Size(251, 39);
            this.ultraDropDownEmpleados.TabIndex = 23;
            this.ultraDropDownEmpleados.ValueMember = "idEmpleado";
            this.ultraDropDownEmpleados.Visible = false;
            this.ultraDropDownEmpleados.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownEmpleadosBeforeDropDown);
            // 
            // empleadosListaBindingSource
            // 
            this.empleadosListaBindingSource.DataMember = "EmpleadosLista";
            this.empleadosListaBindingSource.DataSource = this.dsEmpleadosLista;
            // 
            // dsEmpleadosLista
            // 
            this.dsEmpleadosLista.DataSetName = "DsEmpleadosLista";
            this.dsEmpleadosLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTandasDeFacturacion
            // 
            this.ultraDropDownTandasDeFacturacion.DataSource = this.tandasDeFacturacionBindingSource;
            appearance132.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance132.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance132.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Appearance = appearance132;
            ultraGridBand15.ColHeadersVisible = false;
            ultraGridColumn98.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn98.Header.VisiblePosition = 0;
            ultraGridColumn98.Hidden = true;
            ultraGridColumn99.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn99.Header.VisiblePosition = 1;
            ultraGridColumn100.Header.VisiblePosition = 2;
            ultraGridColumn100.Hidden = true;
            ultraGridBand15.Columns.AddRange(new object[] {
            ultraGridColumn98,
            ultraGridColumn99,
            ultraGridColumn100});
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.BandsSerializer.Add(ultraGridBand15);
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.MaxBandDepth = 5;
            appearance133.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.ActiveCellAppearance = appearance133;
            appearance134.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance134.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance134.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance134.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.ActiveRowAppearance = appearance134;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance135.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.CardAreaAppearance = appearance135;
            appearance136.BackColor = System.Drawing.SystemColors.Control;
            appearance136.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance136.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.CellAppearance = appearance136;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance137.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance137.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance137.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance137.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance137.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.HeaderAppearance = appearance137;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance138.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.RowSelectorAppearance = appearance138;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance139.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.SelectedCellAppearance = appearance139;
            appearance140.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance140.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance140.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.SelectedRowAppearance = appearance140;
            appearance141.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance141.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance141;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTandasDeFacturacion.DisplayMember = "Nombre";
            this.ultraDropDownTandasDeFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTandasDeFacturacion.Location = new System.Drawing.Point(279, 298);
            this.ultraDropDownTandasDeFacturacion.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownTandasDeFacturacion.Name = "ultraDropDownTandasDeFacturacion";
            this.ultraDropDownTandasDeFacturacion.Size = new System.Drawing.Size(251, 39);
            this.ultraDropDownTandasDeFacturacion.TabIndex = 25;
            this.ultraDropDownTandasDeFacturacion.ValueMember = "idTandaDeFacturacion";
            this.ultraDropDownTandasDeFacturacion.Visible = false;
            this.ultraDropDownTandasDeFacturacion.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTandasDeFacturacionBeforeDropDown);
            // 
            // tandasDeFacturacionBindingSource
            // 
            this.tandasDeFacturacionBindingSource.DataMember = "TandasDeFacturacion";
            this.tandasDeFacturacionBindingSource.DataSource = this.dsTandasDeFacturacion;
            // 
            // dsTandasDeFacturacion
            // 
            this.dsTandasDeFacturacion.DataSetName = "DsTandasDeFacturacion";
            this.dsTandasDeFacturacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownPuntoDeVenta
            // 
            this.ultraDropDownPuntoDeVenta.DataSource = this.puntosDeVentaBindingSource;
            appearance31.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Appearance = appearance31;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn101.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn101.Header.VisiblePosition = 0;
            ultraGridColumn101.Hidden = true;
            ultraGridColumn102.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn102.Header.VisiblePosition = 1;
            ultraGridColumn102.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn102.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn102.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(56, 0);
            ultraGridColumn102.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn102.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn103.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn103.Header.VisiblePosition = 2;
            ultraGridColumn103.RowLayoutColumnInfo.OriginX = 1;
            ultraGridColumn103.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn103.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn103.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn104.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn104.Header.VisiblePosition = 3;
            ultraGridColumn104.Hidden = true;
            ultraGridColumn105.Header.VisiblePosition = 4;
            ultraGridColumn105.Hidden = true;
            ultraGridColumn106.Header.VisiblePosition = 5;
            ultraGridColumn106.Hidden = true;
            ultraGridColumn107.Header.VisiblePosition = 6;
            ultraGridColumn107.Hidden = true;
            ultraGridColumn108.Header.VisiblePosition = 7;
            ultraGridColumn108.Hidden = true;
            ultraGridColumn109.Header.VisiblePosition = 8;
            ultraGridColumn109.Hidden = true;
            ultraGridColumn110.Header.VisiblePosition = 9;
            ultraGridColumn110.Hidden = true;
            ultraGridColumn111.Header.VisiblePosition = 10;
            ultraGridColumn111.Hidden = true;
            ultraGridColumn112.Header.VisiblePosition = 11;
            ultraGridColumn112.Hidden = true;
            ultraGridBand16.Columns.AddRange(new object[] {
            ultraGridColumn101,
            ultraGridColumn102,
            ultraGridColumn103,
            ultraGridColumn104,
            ultraGridColumn105,
            ultraGridColumn106,
            ultraGridColumn107,
            ultraGridColumn108,
            ultraGridColumn109,
            ultraGridColumn110,
            ultraGridColumn111,
            ultraGridColumn112});
            ultraGridBand16.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal;
            ultraGridBand16.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand16.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.BandsSerializer.Add(ultraGridBand16);
            this.ultraDropDownPuntoDeVenta.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.MaxBandDepth = 5;
            appearance32.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.ActiveCellAppearance = appearance32;
            appearance33.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance33.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance33.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.ActiveRowAppearance = appearance33;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance34.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.CardAreaAppearance = appearance34;
            appearance35.BackColor = System.Drawing.SystemColors.Control;
            appearance35.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.CellAppearance = appearance35;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance36.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance36.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance36.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance36.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.HeaderAppearance = appearance36;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance37.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.RowSelectorAppearance = appearance37;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.SelectedCellAppearance = appearance38;
            appearance39.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance39.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.SelectedRowAppearance = appearance39;
            appearance40.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance40.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance40;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPuntoDeVenta.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPuntoDeVenta.DisplayMember = "Observaciones";
            this.ultraDropDownPuntoDeVenta.DropDownWidth = 0;
            this.ultraDropDownPuntoDeVenta.Location = new System.Drawing.Point(20, 345);
            this.ultraDropDownPuntoDeVenta.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownPuntoDeVenta.Name = "ultraDropDownPuntoDeVenta";
            this.ultraDropDownPuntoDeVenta.Size = new System.Drawing.Size(251, 43);
            this.ultraDropDownPuntoDeVenta.TabIndex = 26;
            this.ultraDropDownPuntoDeVenta.ValueMember = "idPuntoDeVenta";
            this.ultraDropDownPuntoDeVenta.Visible = false;
            // 
            // puntosDeVentaBindingSource
            // 
            this.puntosDeVentaBindingSource.DataMember = "PuntosDeVenta";
            this.puntosDeVentaBindingSource.DataSource = this.dsPuntosDeVenta;
            // 
            // dsPuntosDeVenta
            // 
            this.dsPuntosDeVenta.DataSetName = "DsPuntosDeVenta";
            this.dsPuntosDeVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownMedicamentos
            // 
            this.ultraDropDownMedicamentos.DataSource = this.medicamentosBindingSource;
            appearance104.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance104.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMedicamentos.DisplayLayout.Appearance = appearance104;
            ultraGridBand17.ColHeadersVisible = false;
            ultraGridColumn113.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn113.Header.VisiblePosition = 0;
            ultraGridColumn113.Hidden = true;
            ultraGridColumn114.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn114.Header.VisiblePosition = 1;
            ultraGridColumn115.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn115.Header.VisiblePosition = 2;
            ultraGridColumn115.Hidden = true;
            ultraGridColumn116.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn116.Header.VisiblePosition = 3;
            ultraGridColumn116.Hidden = true;
            ultraGridColumn117.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn117.Header.VisiblePosition = 4;
            ultraGridColumn117.Hidden = true;
            ultraGridBand17.Columns.AddRange(new object[] {
            ultraGridColumn113,
            ultraGridColumn114,
            ultraGridColumn115,
            ultraGridColumn116,
            ultraGridColumn117});
            this.ultraDropDownMedicamentos.DisplayLayout.BandsSerializer.Add(ultraGridBand17);
            this.ultraDropDownMedicamentos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMedicamentos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMedicamentos.DisplayLayout.MaxBandDepth = 5;
            appearance105.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.ActiveCellAppearance = appearance105;
            appearance106.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance106.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance106.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.ActiveRowAppearance = appearance106;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance107.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.CardAreaAppearance = appearance107;
            appearance108.BackColor = System.Drawing.SystemColors.Control;
            appearance108.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance108.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.CellAppearance = appearance108;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance109.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance109.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance109.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance109.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance109.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.HeaderAppearance = appearance109;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance110.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.RowSelectorAppearance = appearance110;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance111.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.SelectedCellAppearance = appearance111;
            appearance112.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance112.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance112.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.SelectedRowAppearance = appearance112;
            appearance113.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance113.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance113;
            this.ultraDropDownMedicamentos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMedicamentos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMedicamentos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMedicamentos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMedicamentos.DisplayMember = "Nombre";
            this.ultraDropDownMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMedicamentos.Location = new System.Drawing.Point(20, 395);
            this.ultraDropDownMedicamentos.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownMedicamentos.Name = "ultraDropDownMedicamentos";
            this.ultraDropDownMedicamentos.Size = new System.Drawing.Size(251, 39);
            this.ultraDropDownMedicamentos.TabIndex = 44;
            this.ultraDropDownMedicamentos.ValueMember = "idMedicamento";
            this.ultraDropDownMedicamentos.Visible = false;
            // 
            // medicamentosBindingSource
            // 
            this.medicamentosBindingSource.DataMember = "Medicamentos";
            this.medicamentosBindingSource.DataSource = this.dsMedicamentos;
            // 
            // dsMedicamentos
            // 
            this.dsMedicamentos.DataSetName = "DsMedicamentos";
            this.dsMedicamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "Planes";
            this.planesBindingSource.DataSource = this.dsPlanes;
            // 
            // dsPlanes
            // 
            this.dsPlanes.DataSetName = "DsPlanes";
            this.dsPlanes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownPlanes
            // 
            this.ultraDropDownPlanes.DataSource = this.planesBindingSource;
            appearance184.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance184.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance184.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPlanes.DisplayLayout.Appearance = appearance184;
            this.ultraDropDownPlanes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand18.ColHeadersVisible = false;
            ultraGridColumn118.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn118.Header.VisiblePosition = 0;
            ultraGridColumn118.Hidden = true;
            ultraGridColumn118.Width = 64;
            ultraGridColumn119.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn119.Header.VisiblePosition = 1;
            ultraGridColumn119.Width = 294;
            ultraGridColumn120.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn120.Header.VisiblePosition = 2;
            ultraGridColumn120.Hidden = true;
            ultraGridColumn120.Width = 49;
            ultraGridColumn121.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn121.Header.VisiblePosition = 3;
            ultraGridColumn121.Hidden = true;
            ultraGridColumn121.Width = 37;
            ultraGridColumn122.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn122.Header.VisiblePosition = 4;
            ultraGridColumn122.Hidden = true;
            ultraGridColumn122.Width = 65;
            ultraGridBand18.Columns.AddRange(new object[] {
            ultraGridColumn118,
            ultraGridColumn119,
            ultraGridColumn120,
            ultraGridColumn121,
            ultraGridColumn122});
            this.ultraDropDownPlanes.DisplayLayout.BandsSerializer.Add(ultraGridBand18);
            this.ultraDropDownPlanes.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPlanes.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPlanes.DisplayLayout.MaxBandDepth = 5;
            appearance185.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPlanes.DisplayLayout.Override.ActiveCellAppearance = appearance185;
            appearance186.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance186.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance186.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance186.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPlanes.DisplayLayout.Override.ActiveRowAppearance = appearance186;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance187.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPlanes.DisplayLayout.Override.CardAreaAppearance = appearance187;
            appearance188.BackColor = System.Drawing.SystemColors.Control;
            appearance188.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance188.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPlanes.DisplayLayout.Override.CellAppearance = appearance188;
            this.ultraDropDownPlanes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance189.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance189.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance189.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance189.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance189.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPlanes.DisplayLayout.Override.HeaderAppearance = appearance189;
            this.ultraDropDownPlanes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance190.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPlanes.DisplayLayout.Override.RowSelectorAppearance = appearance190;
            this.ultraDropDownPlanes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance191.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPlanes.DisplayLayout.Override.SelectedCellAppearance = appearance191;
            appearance192.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance192.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance192.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPlanes.DisplayLayout.Override.SelectedRowAppearance = appearance192;
            appearance193.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance193.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPlanes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance193;
            this.ultraDropDownPlanes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPlanes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPlanes.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPlanes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPlanes.DisplayMember = "Nombre";
            this.ultraDropDownPlanes.Location = new System.Drawing.Point(279, 395);
            this.ultraDropDownPlanes.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownPlanes.Name = "ultraDropDownPlanes";
            this.ultraDropDownPlanes.Size = new System.Drawing.Size(317, 43);
            this.ultraDropDownPlanes.TabIndex = 45;
            this.ultraDropDownPlanes.ValueMember = "idPlan";
            this.ultraDropDownPlanes.Visible = false;
            // 
            // dsClientesLista
            // 
            this.dsClientesLista.DataSetName = "DsClientesLista";
            this.dsClientesLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesListaBindingSource
            // 
            this.clientesListaBindingSource.DataMember = "ClientesLista";
            this.clientesListaBindingSource.DataSource = this.dsClientesLista;
            // 
            // ultraDropDownClientes
            // 
            this.ultraDropDownClientes.DataSource = this.clientesListaBindingSource;
            appearance14.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownClientes.DisplayLayout.Appearance = appearance14;
            ultraGridBand19.ColHeadersVisible = false;
            ultraGridColumn123.Header.VisiblePosition = 0;
            ultraGridColumn123.Hidden = true;
            ultraGridColumn124.Header.VisiblePosition = 1;
            ultraGridColumn125.Header.VisiblePosition = 2;
            ultraGridBand19.Columns.AddRange(new object[] {
            ultraGridColumn123,
            ultraGridColumn124,
            ultraGridColumn125});
            this.ultraDropDownClientes.DisplayLayout.BandsSerializer.Add(ultraGridBand19);
            this.ultraDropDownClientes.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownClientes.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownClientes.DisplayLayout.MaxBandDepth = 5;
            appearance15.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownClientes.DisplayLayout.Override.ActiveCellAppearance = appearance15;
            appearance16.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance16.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownClientes.DisplayLayout.Override.ActiveRowAppearance = appearance16;
            this.ultraDropDownClientes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownClientes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownClientes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownClientes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownClientes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownClientes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownClientes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance17.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownClientes.DisplayLayout.Override.CardAreaAppearance = appearance17;
            appearance18.BackColor = System.Drawing.SystemColors.Control;
            appearance18.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownClientes.DisplayLayout.Override.CellAppearance = appearance18;
            this.ultraDropDownClientes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance19.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownClientes.DisplayLayout.Override.HeaderAppearance = appearance19;
            this.ultraDropDownClientes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance20.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownClientes.DisplayLayout.Override.RowSelectorAppearance = appearance20;
            this.ultraDropDownClientes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownClientes.DisplayLayout.Override.SelectedCellAppearance = appearance21;
            appearance22.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance22.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownClientes.DisplayLayout.Override.SelectedRowAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance23.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownClientes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance23;
            this.ultraDropDownClientes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownClientes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownClientes.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownClientes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownClientes.DisplayMember = "NombreCompleto";
            this.ultraDropDownClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownClientes.Location = new System.Drawing.Point(537, 15);
            this.ultraDropDownClientes.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownClientes.Name = "ultraDropDownClientes";
            this.ultraDropDownClientes.Size = new System.Drawing.Size(251, 39);
            this.ultraDropDownClientes.TabIndex = 46;
            this.ultraDropDownClientes.ValueMember = "idCliente";
            this.ultraDropDownClientes.Visible = false;
            // 
            // negociosBindingSource
            // 
            this.negociosBindingSource.DataMember = "Negocios";
            this.negociosBindingSource.DataSource = this.dsNegocios;
            // 
            // dsNegocios
            // 
            this.dsNegocios.DataSetName = "DsNegocios";
            this.dsNegocios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownNegocios
            // 
            this.ultraDropDownNegocios.DataSource = this.negociosBindingSource;
            appearance165.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance165.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance165.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownNegocios.DisplayLayout.Appearance = appearance165;
            this.ultraDropDownNegocios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Hidden = true;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Hidden = true;
            ultraGridBand20.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4});
            ultraGridBand20.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal;
            ultraGridBand20.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand20.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownNegocios.DisplayLayout.BandsSerializer.Add(ultraGridBand20);
            this.ultraDropDownNegocios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownNegocios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownNegocios.DisplayLayout.MaxBandDepth = 5;
            appearance166.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveCellAppearance = appearance166;
            appearance167.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance167.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance167.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance167.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveRowAppearance = appearance167;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance168.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.CardAreaAppearance = appearance168;
            appearance169.BackColor = System.Drawing.SystemColors.Control;
            appearance169.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance169.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.CellAppearance = appearance169;
            this.ultraDropDownNegocios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance170.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance170.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance170.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance170.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance170.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderAppearance = appearance170;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance171.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSelectorAppearance = appearance171;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance172.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedCellAppearance = appearance172;
            appearance173.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance173.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance173.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedRowAppearance = appearance173;
            appearance174.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance174.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownNegocios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance174;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownNegocios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownNegocios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownNegocios.DisplayMember = "Nombre";
            this.ultraDropDownNegocios.DropDownWidth = 0;
            this.ultraDropDownNegocios.Location = new System.Drawing.Point(20, 442);
            this.ultraDropDownNegocios.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownNegocios.Name = "ultraDropDownNegocios";
            this.ultraDropDownNegocios.Size = new System.Drawing.Size(251, 43);
            this.ultraDropDownNegocios.TabIndex = 47;
            this.ultraDropDownNegocios.ValueMember = "idNegocio";
            this.ultraDropDownNegocios.Visible = false;
            // 
            // dsRubros
            // 
            this.dsRubros.DataSetName = "DsRubros";
            this.dsRubros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubrosBindingSource
            // 
            this.rubrosBindingSource.DataMember = "Rubros";
            this.rubrosBindingSource.DataSource = this.dsRubros;
            // 
            // ultraDropDownRubros
            // 
            this.ultraDropDownRubros.DataSource = this.rubrosBindingSource;
            appearance63.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance63.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownRubros.DisplayLayout.Appearance = appearance63;
            ultraGridBand21.ColHeadersVisible = false;
            ultraGridColumn126.Header.VisiblePosition = 0;
            ultraGridColumn126.Hidden = true;
            ultraGridColumn127.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn127.Header.VisiblePosition = 1;
            ultraGridColumn127.Hidden = true;
            ultraGridColumn128.Header.VisiblePosition = 2;
            ultraGridColumn128.Hidden = true;
            ultraGridColumn129.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn129.Header.VisiblePosition = 3;
            ultraGridColumn130.Header.VisiblePosition = 4;
            ultraGridColumn130.Hidden = true;
            ultraGridBand21.Columns.AddRange(new object[] {
            ultraGridColumn126,
            ultraGridColumn127,
            ultraGridColumn128,
            ultraGridColumn129,
            ultraGridColumn130});
            ultraGridBand21.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridBand21.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand21.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownRubros.DisplayLayout.BandsSerializer.Add(ultraGridBand21);
            this.ultraDropDownRubros.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownRubros.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownRubros.DisplayLayout.MaxBandDepth = 5;
            appearance64.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownRubros.DisplayLayout.Override.ActiveCellAppearance = appearance64;
            appearance65.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance65.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance65.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance65.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownRubros.DisplayLayout.Override.ActiveRowAppearance = appearance65;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance66.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownRubros.DisplayLayout.Override.CardAreaAppearance = appearance66;
            appearance67.BackColor = System.Drawing.SystemColors.Control;
            appearance67.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance67.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRubros.DisplayLayout.Override.CellAppearance = appearance67;
            this.ultraDropDownRubros.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance68.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance68.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance68.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance68.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownRubros.DisplayLayout.Override.HeaderAppearance = appearance68;
            this.ultraDropDownRubros.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance69.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownRubros.DisplayLayout.Override.RowSelectorAppearance = appearance69;
            this.ultraDropDownRubros.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance70.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownRubros.DisplayLayout.Override.SelectedCellAppearance = appearance70;
            appearance71.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance71.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRubros.DisplayLayout.Override.SelectedRowAppearance = appearance71;
            appearance72.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance72.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownRubros.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance72;
            this.ultraDropDownRubros.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownRubros.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownRubros.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownRubros.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownRubros.DisplayMember = "NombreCompleto";
            this.ultraDropDownRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownRubros.Location = new System.Drawing.Point(20, 492);
            this.ultraDropDownRubros.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownRubros.Name = "ultraDropDownRubros";
            this.ultraDropDownRubros.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownRubros.TabIndex = 48;
            this.ultraDropDownRubros.ValueMember = "idRubro";
            this.ultraDropDownRubros.Visible = false;
            this.ultraDropDownRubros.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownRubros_BeforeDropDown);
            // 
            // FormABCSistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(567, 649);
            this.Controls.Add(this.parametrosUltraGrid);
            this.Controls.Add(this.ultraDropDownNegocios);
            this.Controls.Add(this.ultraDropDownClientes);
            this.Controls.Add(this.ultraDropDownPlanes);
            this.Controls.Add(this.ultraDropDownMedicamentos);
            this.Controls.Add(this.ultraDropDownPuntoDeVenta);
            this.Controls.Add(this.ultraDropDownTandasDeFacturacion);
            this.Controls.Add(this.ultraDropDownEmpleados);
            this.Controls.Add(this.ultraDropDownMotivosDeBaja);
            this.Controls.Add(this.ultraDropDownTiposDeDestino);
            this.Controls.Add(this.ultraDropDownCodigos);
            this.Controls.Add(this.ultraDropDownCoberturas);
            this.Controls.Add(this.ultraDropDownMotiDevCobCambioPeriodoCobranza);
            this.Controls.Add(this.ultraDropDownMotiDevCobBaja);
            this.Controls.Add(this.ultraDropDownMotiDevCobSaldoCero);
            this.Controls.Add(this.ultraDropDownFactura);
            this.Controls.Add(this.ultraDropDownMotiDevCobCobro);
            this.Controls.Add(this.ultraDropDownRecibo);
            this.Controls.Add(this.ultraDropDownNdeC);
            this.Controls.Add(this.ultraDropDownDNI);
            this.Controls.Add(this.ultraDropDownRubros);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(471, 230);
            this.Name = "FormABCSistemas";
            this.Text = "Sistemas";
            this.Load += new System.EventHandler(this.FormABCSistemasLoad);
            this.Controls.SetChildIndex(this.ultraDropDownRubros, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownDNI, 0);
            this.Controls.SetChildIndex(this.ultraDropDownNdeC, 0);
            this.Controls.SetChildIndex(this.ultraDropDownRecibo, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMotiDevCobCobro, 0);
            this.Controls.SetChildIndex(this.ultraDropDownFactura, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMotiDevCobSaldoCero, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMotiDevCobBaja, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMotiDevCobCambioPeriodoCobranza, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCoberturas, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCodigos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeDestino, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMotivosDeBaja, 0);
            this.Controls.SetChildIndex(this.ultraDropDownEmpleados, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTandasDeFacturacion, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPuntoDeVenta, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMedicamentos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPlanes, 0);
            this.Controls.SetChildIndex(this.ultraDropDownClientes, 0);
            this.Controls.SetChildIndex(this.ultraDropDownNegocios, 0);
            this.Controls.SetChildIndex(this.parametrosUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parametrosUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNdeC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRecibo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotiDevCobCobro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDevolucionCobranzaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDevolucionCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotiDevCobSaldoCero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotiDevCobBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotiDevCobCambioPeriodoCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCoberturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coberturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoberturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDestinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivosDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeBajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTandasDeFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tandasDeFacturacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTandasDeFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPuntoDeVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntosDeVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRubros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid parametrosUltraGrid;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownDNI;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownFactura;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownNdeC;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownRecibo;
        private System.Windows.Forms.BindingSource tiposDeComprobanteBindingSource;
        private WS.DsTiposDeComprobante dsTiposDeComprobante;
        private System.Windows.Forms.BindingSource tiposDeDocumentoBindingSource;
        private WS.DsTiposDeDocumento dsTiposDeDocumento;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMotiDevCobCobro;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMotiDevCobSaldoCero;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMotiDevCobBaja;
        private System.Windows.Forms.BindingSource motivosDevolucionCobranzaBindingSource;
        private WS.DsMotivosDevolucionCobranza dsMotivosDevolucionCobranza;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMotiDevCobCambioPeriodoCobranza;
        private System.Windows.Forms.BindingSource sistemasBindingSource;
        private WS.DsSistemas dsSistemas;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCoberturas;
        private System.Windows.Forms.BindingSource coberturasBindingSource;
        private WS.DsCoberturas dsCoberturas;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCodigos;
        private System.Windows.Forms.BindingSource codigosBindingSource;
        private WS.DsCodigos dsCodigos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeDestino;
        private System.Windows.Forms.BindingSource tiposDeDestinoBindingSource;
        private WS.DsTiposDeDestino dsTiposDeDestino;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMotivosDeBaja;
        private System.Windows.Forms.BindingSource motivosDeBajaBindingSource;
        private WS.DsMotivosDeBaja dsMotivosDeBaja;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownEmpleados;
        private System.Windows.Forms.BindingSource empleadosListaBindingSource;
        private WS.DsEmpleadosLista dsEmpleadosLista;
        private WS.DsTandasDeFacturacion dsTandasDeFacturacion;
        private System.Windows.Forms.BindingSource tandasDeFacturacionBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTandasDeFacturacion;
        private WS.DsPuntosDeVenta dsPuntosDeVenta;
        private System.Windows.Forms.BindingSource puntosDeVentaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPuntoDeVenta;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMedicamentos;
        private Administración.WS.DsMedicamentos dsMedicamentos;
        private System.Windows.Forms.BindingSource medicamentosBindingSource;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private WS.DsPlanes dsPlanes;
        private UltraDropDown ultraDropDownPlanes;
        private WS.DsClientesLista dsClientesLista;
        private System.Windows.Forms.BindingSource clientesListaBindingSource;
        private UltraDropDown ultraDropDownClientes;
        private System.Windows.Forms.BindingSource negociosBindingSource;
        private WS.DsNegocios dsNegocios;
        private UltraDropDown ultraDropDownNegocios;
        private WS.DsRubros dsRubros;
        private System.Windows.Forms.BindingSource rubrosBindingSource;
        private UltraDropDown ultraDropDownRubros;
    }
}

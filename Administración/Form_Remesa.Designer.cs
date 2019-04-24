using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    partial class FormRemesa
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
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Remesas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobrador", -1, "ultraDropDownCobradores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Caja");
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idReceptor", -1, "ultraDropDownReceptor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrabador", -1, "ultraDropDownGrabador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Detalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntidadDeCobranza", -1, "ultraDropDownEntidadesDeCobranza", 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_ComprobantesRemesas_Remesas");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Remesas_ValoresRemesas");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_ComprobantesRemesas_Remesas", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobanteRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idReferencia");
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteReferencia");
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteCobrado");
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("HacerNdeC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestacion");
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings1 = new Infragistics.Win.UltraWinGrid.SummarySettings("CountComprobante", Infragistics.Win.UltraWinGrid.SummaryType.Count, null, "idReferencia", 2, true, "FK_ComprobantesRemesas_Remesas", 1, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "idReferencia", 2, true);
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings2 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumComprobantes", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "ImporteCobrado", 4, true, "FK_ComprobantesRemesas_Remesas", 1, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "ImporteCobrado", 4, true);
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Remesas_ValoresRemesas", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idValorRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeValor", -1, "ultraDropDownTiposDeValores", 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco", -1, "ultraDropDownBancos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeCheque");
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencimiento");
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings3 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumValores", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Importe", 3, true, "FK_Remesas_ValoresRemesas", 2, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Importe", 3, true);
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Bancos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance84 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance86 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance245 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("UsuariosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idUsuario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.Appearance appearance246 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance247 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance248 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance249 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance250 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance251 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance252 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance253 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance254 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance99 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EntidadesDeCobranza", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntidadDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MascaraTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereNumero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereVencimiento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereNombreTitular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereDocTitular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereTelTitular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereConvenio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereSucursal");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereEmpresa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereJubilado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance100 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance101 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance102 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance103 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeValores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeValor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereBanco");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsEfectivo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SePagaCon");
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            this.remesasUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraCalcManager1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.remesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRemesas = new Administración.WS.DsRemesas();
            this.ultraCurrencyEditorSumComprobantes = new Infragistics.Win.UltraWinEditors.UltraCurrencyEditor();
            this.ultraCurrencyEditorSumValores = new Infragistics.Win.UltraWinEditors.UltraCurrencyEditor();
            this.ultraLabelMensaje = new Infragistics.Win.Misc.UltraLabel();
            this.ultraDropDownCobradores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.cobradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCobradores = new Administración.WS.DsEmpleadosLista();
            this.tiposDeValoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeValores = new Administración.WS.DsTiposDeValores();
            this.ultraDropDownBancos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.bancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBancos = new Administración.WS.DsBancos();
            this.empleadosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmpleadosLista = new Administración.WS.DsEmpleadosLista();
            this.ultraDropDownReceptor = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.usuariosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUsuariosLista1 = new Administración.WS.DsUsuariosLista();
            this.ultraDropDownGrabador = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsEntidadesDeCobranza = new Administración.WS.DsEntidadesDeCobranza();
            this.entidadesDeCobranzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownEntidadesDeCobranza = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownTiposDeValores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remesasUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remesasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditorSumComprobantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditorSumValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCobradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCobradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeValoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownReceptor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesDeCobranzaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEntidadesDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeValores)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(656, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(575, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ultraLabelMensaje);
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Size = new System.Drawing.Size(746, 50);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.panel1.Controls.SetChildIndex(this.ultraLabelMensaje, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(575, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // remesasUltraGrid
            // 
            this.remesasUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remesasUltraGrid.CalcManager = this.ultraCalcManager1;
            this.remesasUltraGrid.DataSource = this.remesasBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.remesasUltraGrid.DisplayLayout.Appearance = appearance11;
            ultraGridColumn43.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn43.Header.VisiblePosition = 0;
            ultraGridColumn43.Hidden = true;
            ultraGridColumn44.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn44.Header.Caption = "Cobrador";
            ultraGridColumn44.Header.VisiblePosition = 1;
            ultraGridColumn44.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn44.Width = 175;
            ultraGridColumn45.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn45.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance12.TextHAlignAsString = "Center";
            ultraGridColumn45.CellAppearance = appearance12;
            ultraGridColumn45.Header.VisiblePosition = 2;
            ultraGridColumn45.Hidden = true;
            ultraGridColumn45.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn45.MaskInput = "dd/mm/yyyy";
            ultraGridColumn45.Width = 91;
            ultraGridColumn46.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance13.TextHAlignAsString = "Center";
            ultraGridColumn46.CellAppearance = appearance13;
            ultraGridColumn46.Header.VisiblePosition = 3;
            ultraGridColumn46.Hidden = true;
            ultraGridColumn46.NullText = "Automático";
            ultraGridColumn46.Width = 98;
            ultraGridColumn47.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn47.Header.Caption = "Recibe los Valores";
            ultraGridColumn47.Header.VisiblePosition = 5;
            ultraGridColumn47.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn47.Width = 174;
            ultraGridColumn48.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn48.Header.Caption = "Grabador";
            ultraGridColumn48.Header.VisiblePosition = 6;
            ultraGridColumn48.Hidden = true;
            ultraGridColumn48.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn48.Width = 232;
            ultraGridColumn49.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            appearance14.TextHAlignAsString = "Right";
            ultraGridColumn49.CellAppearance = appearance14;
            ultraGridColumn49.Header.VisiblePosition = 7;
            ultraGridColumn49.Hidden = true;
            ultraGridColumn49.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn49.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn49.Width = 87;
            ultraGridColumn50.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn50.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn50.DefaultCellValue = "\"Cobrador\"";
            ultraGridColumn50.Header.VisiblePosition = 8;
            ultraGridColumn50.Hidden = true;
            ultraGridColumn50.Width = 92;
            ultraGridColumn51.Header.VisiblePosition = 9;
            ultraGridColumn51.Hidden = true;
            ultraGridColumn51.Width = 352;
            ultraGridColumn52.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn52.Header.Caption = "Entidad de Cobranza";
            ultraGridColumn52.Header.VisiblePosition = 4;
            ultraGridColumn52.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn52.Width = 153;
            ultraGridColumn53.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn53.Header.VisiblePosition = 10;
            ultraGridColumn54.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn54.Header.VisiblePosition = 11;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn43,
            ultraGridColumn44,
            ultraGridColumn45,
            ultraGridColumn46,
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49,
            ultraGridColumn50,
            ultraGridColumn51,
            ultraGridColumn52,
            ultraGridColumn53,
            ultraGridColumn54});
            ultraGridBand7.MaxRows = 1;
            ultraGridColumn55.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn55.Header.VisiblePosition = 0;
            ultraGridColumn55.Hidden = true;
            ultraGridColumn56.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn56.Header.VisiblePosition = 1;
            ultraGridColumn56.Hidden = true;
            ultraGridColumn57.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance15.TextHAlignAsString = "Right";
            ultraGridColumn57.CellAppearance = appearance15;
            ultraGridColumn57.Header.Caption = "Referencia";
            ultraGridColumn57.Header.VisiblePosition = 2;
            ultraGridColumn57.MaskInput = "nnnnnnnnn";
            ultraGridColumn57.Width = 95;
            ultraGridColumn58.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn58.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance16.TextHAlignAsString = "Right";
            ultraGridColumn58.CellAppearance = appearance16;
            ultraGridColumn58.Header.Caption = "Importe";
            ultraGridColumn58.Header.VisiblePosition = 3;
            ultraGridColumn58.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn58.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn58.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(84, 0);
            ultraGridColumn58.Width = 101;
            ultraGridColumn59.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance17.TextHAlignAsString = "Right";
            ultraGridColumn59.CellAppearance = appearance17;
            ultraGridColumn59.Header.Caption = "Cobrado";
            ultraGridColumn59.Header.VisiblePosition = 4;
            ultraGridColumn59.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn59.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn59.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(83, 0);
            ultraGridColumn59.Width = 88;
            ultraGridColumn60.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn60.Header.VisiblePosition = 6;
            ultraGridColumn60.Width = 332;
            ultraGridColumn61.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn61.DefaultCellValue = "False";
            ultraGridColumn61.Header.Caption = "Hacer NdeC/D";
            ultraGridColumn61.Header.VisiblePosition = 5;
            ultraGridColumn61.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(85, 0);
            ultraGridColumn61.Width = 71;
            ultraGridColumn62.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn62.Header.VisiblePosition = 7;
            ultraGridColumn62.Hidden = true;
            ultraGridColumn62.Width = 71;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn55,
            ultraGridColumn56,
            ultraGridColumn57,
            ultraGridColumn58,
            ultraGridColumn59,
            ultraGridColumn60,
            ultraGridColumn61,
            ultraGridColumn62});
            appearance18.FontData.BoldAsString = "True";
            appearance18.FontData.SizeInPoints = 11F;
            appearance18.TextHAlignAsString = "Left";
            ultraGridBand8.Header.Appearance = appearance18;
            ultraGridBand8.Header.Caption = "Comprobantes";
            ultraGridBand8.HeaderVisible = true;
            ultraGridBand8.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance19.FontData.BoldAsString = "True";
            appearance19.TextHAlignAsString = "Right";
            ultraGridBand8.Override.SummaryValueAppearance = appearance19;
            ultraGridBand8.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            summarySettings1.DisplayFormat = "Cantidad: {0:#####}";
            summarySettings1.GroupBySummaryValueAppearance = appearance20;
            summarySettings2.DisplayFormat = "{0:c}";
            summarySettings2.GroupBySummaryValueAppearance = appearance41;
            ultraGridBand8.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings1,
            summarySettings2});
            ultraGridBand8.SummaryFooterCaption = "";
            ultraGridColumn63.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn63.Header.VisiblePosition = 0;
            ultraGridColumn63.Hidden = true;
            ultraGridColumn63.Width = 70;
            ultraGridColumn64.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn64.Header.VisiblePosition = 1;
            ultraGridColumn64.Hidden = true;
            ultraGridColumn64.Width = 54;
            ultraGridColumn65.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn65.Header.Caption = "Tipo de Valor";
            ultraGridColumn65.Header.VisiblePosition = 2;
            ultraGridColumn65.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn65.Width = 110;
            ultraGridColumn66.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance42.TextHAlignAsString = "Right";
            ultraGridColumn66.CellAppearance = appearance42;
            ultraGridColumn66.Header.VisiblePosition = 3;
            ultraGridColumn66.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn66.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn66.Width = 73;
            ultraGridColumn67.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn67.Header.VisiblePosition = 7;
            ultraGridColumn67.Width = 182;
            ultraGridColumn68.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn68.Header.Caption = "Banco";
            ultraGridColumn68.Header.VisiblePosition = 4;
            ultraGridColumn68.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn68.Width = 80;
            ultraGridColumn69.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance43.TextHAlignAsString = "Right";
            ultraGridColumn69.CellAppearance = appearance43;
            ultraGridColumn69.Header.Caption = "Cheque Nº";
            ultraGridColumn69.Header.VisiblePosition = 5;
            ultraGridColumn69.Width = 78;
            ultraGridColumn70.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance44.TextHAlignAsString = "Center";
            ultraGridColumn70.CellAppearance = appearance44;
            ultraGridColumn70.Header.Caption = "Fecha";
            ultraGridColumn70.Header.VisiblePosition = 6;
            ultraGridColumn70.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn70.MaskInput = "dd/mm/yyyy";
            ultraGridColumn70.Width = 76;
            ultraGridColumn71.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn71.Header.VisiblePosition = 8;
            ultraGridColumn71.Hidden = true;
            ultraGridColumn71.Width = 61;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn63,
            ultraGridColumn64,
            ultraGridColumn65,
            ultraGridColumn66,
            ultraGridColumn67,
            ultraGridColumn68,
            ultraGridColumn69,
            ultraGridColumn70,
            ultraGridColumn71});
            appearance45.FontData.BoldAsString = "True";
            appearance45.FontData.SizeInPoints = 11F;
            appearance45.TextHAlignAsString = "Left";
            ultraGridBand9.Header.Appearance = appearance45;
            ultraGridBand9.Header.Caption = "Valores";
            ultraGridBand9.HeaderVisible = true;
            ultraGridBand9.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand9.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            appearance46.FontData.BoldAsString = "True";
            appearance46.TextHAlignAsString = "Right";
            summarySettings3.Appearance = appearance46;
            summarySettings3.DisplayFormat = "{0:c}";
            summarySettings3.GroupBySummaryValueAppearance = appearance47;
            ultraGridBand9.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings3});
            ultraGridBand9.SummaryFooterCaption = "";
            this.remesasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.remesasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.remesasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.remesasUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.remesasUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.remesasUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance76.BackColor = System.Drawing.SystemColors.Window;
            this.remesasUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance76;
            appearance77.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance77.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance77.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance77.ForeColor = System.Drawing.SystemColors.WindowText;
            this.remesasUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance77;
            this.remesasUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.remesasUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.remesasUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.remesasUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.remesasUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.remesasUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.remesasUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance78.BackColor = System.Drawing.Color.Transparent;
            this.remesasUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance78;
            appearance79.BackColor = System.Drawing.SystemColors.Control;
            appearance79.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance79.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.remesasUltraGrid.DisplayLayout.Override.CellAppearance = appearance79;
            this.remesasUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance80.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance80.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance80.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance80.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance80.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.remesasUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance80;
            this.remesasUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance81.ForeColor = System.Drawing.Color.Red;
            this.remesasUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance81;
            this.remesasUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance82.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.remesasUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance82;
            appearance83.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance83.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance83.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.remesasUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance83;
            appearance94.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance94.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.remesasUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance94;
            this.remesasUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.remesasUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.remesasUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.remesasUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.remesasUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remesasUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.remesasUltraGrid.Name = "remesasUltraGrid";
            this.remesasUltraGrid.Size = new System.Drawing.Size(746, 450);
            this.remesasUltraGrid.TabIndex = 2;
            this.remesasUltraGrid.AfterCellUpdate += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.RemesasUltraGridAfterCellUpdate);
            this.remesasUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.RemesasUltraGridInitializeRow);
            this.remesasUltraGrid.InitializeTemplateAddRow += new Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventHandler(this.RemesasUltraGridInitializeTemplateAddRow);
            this.remesasUltraGrid.AfterEnterEditMode += new System.EventHandler(this.RemesasUltraGridAfterEnterEditMode);
            this.remesasUltraGrid.AfterRowActivate += new System.EventHandler(this.RemesasUltraGridAfterRowActivate);
            this.remesasUltraGrid.AfterRowExpanded += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.RemesasUltraGridAfterRowExpanded);
            this.remesasUltraGrid.BeforeRowExpanded += new Infragistics.Win.UltraWinGrid.CancelableRowEventHandler(this.RemesasUltraGridBeforeRowExpanded);
            this.remesasUltraGrid.CellListSelect += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.RemesasUltraGridCellListSelect);
            this.remesasUltraGrid.BeforeCellDeactivate += new System.ComponentModel.CancelEventHandler(this.RemesasUltraGridBeforeCellDeactivate);
            this.remesasUltraGrid.BeforeRowDeactivate += new System.ComponentModel.CancelEventHandler(this.RemesasUltraGridBeforeRowDeactivate);
            this.remesasUltraGrid.SummaryValueChanged += new Infragistics.Win.UltraWinGrid.SummaryValueChangedEventHandler(this.RemesasUltraGridSummaryValueChanged);
            this.remesasUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.remesasUltraGrid_KeyDown);
            // 
            // ultraCalcManager1
            // 
            this.ultraCalcManager1.ContainingControl = this;
            // 
            // remesasBindingSource
            // 
            this.remesasBindingSource.DataMember = "Remesas";
            this.remesasBindingSource.DataSource = this.dsRemesas;
            // 
            // dsRemesas
            // 
            this.dsRemesas.DataSetName = "DsRemesas";
            this.dsRemesas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraCurrencyEditorSumComprobantes
            // 
            this.ultraCurrencyEditorSumComprobantes.Location = new System.Drawing.Point(132, 223);
            this.ultraCurrencyEditorSumComprobantes.Name = "ultraCurrencyEditorSumComprobantes";
            this.ultraCurrencyEditorSumComprobantes.Size = new System.Drawing.Size(100, 21);
            this.ultraCurrencyEditorSumComprobantes.TabIndex = 3;
            this.ultraCurrencyEditorSumComprobantes.Visible = false;
            // 
            // ultraCurrencyEditorSumValores
            // 
            this.ultraCurrencyEditorSumValores.Location = new System.Drawing.Point(132, 250);
            this.ultraCurrencyEditorSumValores.Name = "ultraCurrencyEditorSumValores";
            this.ultraCurrencyEditorSumValores.Size = new System.Drawing.Size(100, 21);
            this.ultraCurrencyEditorSumValores.TabIndex = 4;
            this.ultraCurrencyEditorSumValores.Visible = false;
            // 
            // ultraLabelMensaje
            // 
            this.ultraLabelMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ultraLabelMensaje.Location = new System.Drawing.Point(184, 18);
            this.ultraLabelMensaje.Name = "ultraLabelMensaje";
            this.ultraLabelMensaje.Size = new System.Drawing.Size(51, 14);
            this.ultraLabelMensaje.TabIndex = 4;
            this.ultraLabelMensaje.Text = "Espere...";
            this.ultraLabelMensaje.Visible = false;
            // 
            // ultraDropDownCobradores
            // 
            this.ultraDropDownCobradores.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCobradores.DataSource = this.cobradoresBindingSource;
            appearance21.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCobradores.DisplayLayout.Appearance = appearance21;
            this.ultraDropDownCobradores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand6.ColHeadersVisible = false;
            ultraGridColumn36.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn36.Header.VisiblePosition = 0;
            ultraGridColumn36.Hidden = true;
            ultraGridColumn37.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn37.Header.VisiblePosition = 1;
            ultraGridColumn37.Hidden = true;
            ultraGridColumn38.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn38.Header.VisiblePosition = 2;
            ultraGridColumn38.Hidden = true;
            ultraGridColumn39.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn39.Header.VisiblePosition = 3;
            ultraGridColumn39.Hidden = true;
            ultraGridColumn40.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn40.Header.VisiblePosition = 4;
            ultraGridColumn41.Header.VisiblePosition = 5;
            ultraGridColumn41.Hidden = true;
            ultraGridColumn42.Header.VisiblePosition = 6;
            ultraGridColumn42.Hidden = true;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn36,
            ultraGridColumn37,
            ultraGridColumn38,
            ultraGridColumn39,
            ultraGridColumn40,
            ultraGridColumn41,
            ultraGridColumn42});
            ultraGridBand6.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand6.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCobradores.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraDropDownCobradores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCobradores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCobradores.DisplayLayout.MaxBandDepth = 5;
            appearance22.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCobradores.DisplayLayout.Override.ActiveCellAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance23.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance23.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCobradores.DisplayLayout.Override.ActiveRowAppearance = appearance23;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance24.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCobradores.DisplayLayout.Override.CardAreaAppearance = appearance24;
            appearance25.BackColor = System.Drawing.SystemColors.Control;
            appearance25.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCobradores.DisplayLayout.Override.CellAppearance = appearance25;
            this.ultraDropDownCobradores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance26.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance26.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance26.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCobradores.DisplayLayout.Override.HeaderAppearance = appearance26;
            this.ultraDropDownCobradores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance27.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCobradores.DisplayLayout.Override.RowSelectorAppearance = appearance27;
            this.ultraDropDownCobradores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCobradores.DisplayLayout.Override.SelectedCellAppearance = appearance28;
            appearance29.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance29.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCobradores.DisplayLayout.Override.SelectedRowAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCobradores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance30;
            this.ultraDropDownCobradores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCobradores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCobradores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCobradores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCobradores.DisplayMember = "ApelNomb";
            this.ultraDropDownCobradores.Location = new System.Drawing.Point(12, 77);
            this.ultraDropDownCobradores.Name = "ultraDropDownCobradores";
            this.ultraDropDownCobradores.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownCobradores.TabIndex = 20;
            this.ultraDropDownCobradores.ValueMember = "idEmpleado";
            this.ultraDropDownCobradores.Visible = false;
            this.ultraDropDownCobradores.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCobradoresBeforeDropDown);
            this.ultraDropDownCobradores.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownCobradoresFilterRow);
            // 
            // cobradoresBindingSource
            // 
            this.cobradoresBindingSource.DataMember = "EmpleadosLista";
            this.cobradoresBindingSource.DataSource = this.dsCobradores;
            // 
            // dsCobradores
            // 
            this.dsCobradores.DataSetName = "DsEmpleadosLista";
            this.dsCobradores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposDeValoresBindingSource
            // 
            this.tiposDeValoresBindingSource.DataMember = "TiposDeValores";
            this.tiposDeValoresBindingSource.DataSource = this.dsTiposDeValores;
            // 
            // dsTiposDeValores
            // 
            this.dsTiposDeValores.DataSetName = "DsTiposDeValores";
            this.dsTiposDeValores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownBancos
            // 
            this.ultraDropDownBancos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownBancos.DataSource = this.bancosBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBancos.DisplayLayout.Appearance = appearance1;
            this.ultraDropDownBancos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn34.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn34.Header.VisiblePosition = 0;
            ultraGridColumn34.Hidden = true;
            ultraGridColumn35.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn35.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn35.Header.VisiblePosition = 1;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn34,
            ultraGridColumn35});
            ultraGridBand5.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand5.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownBancos.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.ultraDropDownBancos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownBancos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownBancos.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownBancos.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownBancos.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownBancos.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBancos.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraDropDownBancos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownBancos.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ultraDropDownBancos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownBancos.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ultraDropDownBancos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownBancos.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBancos.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownBancos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ultraDropDownBancos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownBancos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownBancos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownBancos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownBancos.DisplayMember = "Nombre";
            this.ultraDropDownBancos.Location = new System.Drawing.Point(253, 279);
            this.ultraDropDownBancos.Name = "ultraDropDownBancos";
            this.ultraDropDownBancos.Size = new System.Drawing.Size(241, 34);
            this.ultraDropDownBancos.TabIndex = 22;
            this.ultraDropDownBancos.ValueMember = "idBanco";
            this.ultraDropDownBancos.Visible = false;
            // 
            // bancosBindingSource
            // 
            this.bancosBindingSource.DataMember = "Bancos";
            this.bancosBindingSource.DataSource = this.dsBancos;
            // 
            // dsBancos
            // 
            this.dsBancos.DataSetName = "DsBancos";
            this.dsBancos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ultraDropDownReceptor
            // 
            this.ultraDropDownReceptor.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownReceptor.DataSource = this.empleadosListaBindingSource;
            appearance84.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance84.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownReceptor.DisplayLayout.Appearance = appearance84;
            this.ultraDropDownReceptor.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand4.ColHeadersVisible = false;
            ultraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn27.Header.VisiblePosition = 0;
            ultraGridColumn27.Hidden = true;
            ultraGridColumn27.Width = 30;
            ultraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn28.Header.VisiblePosition = 1;
            ultraGridColumn28.Hidden = true;
            ultraGridColumn28.Width = 21;
            ultraGridColumn29.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn29.Header.VisiblePosition = 2;
            ultraGridColumn29.Hidden = true;
            ultraGridColumn29.Width = 45;
            ultraGridColumn30.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn30.Header.VisiblePosition = 3;
            ultraGridColumn30.Width = 219;
            ultraGridColumn31.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn31.Header.VisiblePosition = 4;
            ultraGridColumn31.Hidden = true;
            ultraGridColumn31.Width = 194;
            ultraGridColumn32.Header.VisiblePosition = 5;
            ultraGridColumn32.Hidden = true;
            ultraGridColumn32.Width = 47;
            ultraGridColumn33.Header.VisiblePosition = 6;
            ultraGridColumn33.Hidden = true;
            ultraGridColumn33.Width = 47;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn27,
            ultraGridColumn28,
            ultraGridColumn29,
            ultraGridColumn30,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33});
            this.ultraDropDownReceptor.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownReceptor.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownReceptor.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownReceptor.DisplayLayout.MaxBandDepth = 5;
            appearance85.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownReceptor.DisplayLayout.Override.ActiveCellAppearance = appearance85;
            appearance86.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance86.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance86.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance86.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownReceptor.DisplayLayout.Override.ActiveRowAppearance = appearance86;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance87.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownReceptor.DisplayLayout.Override.CardAreaAppearance = appearance87;
            appearance88.BackColor = System.Drawing.SystemColors.Control;
            appearance88.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance88.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownReceptor.DisplayLayout.Override.CellAppearance = appearance88;
            this.ultraDropDownReceptor.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance89.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance89.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance89.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance89.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance89.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownReceptor.DisplayLayout.Override.HeaderAppearance = appearance89;
            this.ultraDropDownReceptor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance90.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownReceptor.DisplayLayout.Override.RowSelectorAppearance = appearance90;
            this.ultraDropDownReceptor.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownReceptor.DisplayLayout.Override.SelectedCellAppearance = appearance91;
            appearance92.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance92.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance92.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownReceptor.DisplayLayout.Override.SelectedRowAppearance = appearance92;
            appearance93.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance93.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownReceptor.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance93;
            this.ultraDropDownReceptor.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownReceptor.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownReceptor.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownReceptor.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownReceptor.DisplayMember = "NombApel";
            this.ultraDropDownReceptor.Location = new System.Drawing.Point(256, 77);
            this.ultraDropDownReceptor.Name = "ultraDropDownReceptor";
            this.ultraDropDownReceptor.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownReceptor.TabIndex = 23;
            this.ultraDropDownReceptor.ValueMember = "idEmpleado";
            this.ultraDropDownReceptor.Visible = false;
            this.ultraDropDownReceptor.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownReceptorBeforeDropDown);
            this.ultraDropDownReceptor.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownReceptorFilterRow);
            // 
            // usuariosListaBindingSource
            // 
            this.usuariosListaBindingSource.DataMember = "UsuariosLista";
            this.usuariosListaBindingSource.DataSource = this.dsUsuariosLista1;
            // 
            // dsUsuariosLista1
            // 
            this.dsUsuariosLista1.DataSetName = "DsUsuariosLista";
            this.dsUsuariosLista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownGrabador
            // 
            this.ultraDropDownGrabador.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownGrabador.DataSource = this.usuariosListaBindingSource;
            appearance245.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance245.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance245.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownGrabador.DisplayLayout.Appearance = appearance245;
            ultraGridBand3.ColHeadersVisible = false;
            ultraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn21.Header.VisiblePosition = 0;
            ultraGridColumn21.Hidden = true;
            ultraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn22.Header.VisiblePosition = 1;
            ultraGridColumn22.Hidden = true;
            ultraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn23.Header.VisiblePosition = 2;
            ultraGridColumn23.Hidden = true;
            ultraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn24.Header.VisiblePosition = 3;
            ultraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn25.Header.VisiblePosition = 4;
            ultraGridColumn25.Hidden = true;
            ultraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn26.Header.VisiblePosition = 5;
            ultraGridColumn26.Hidden = true;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25,
            ultraGridColumn26});
            this.ultraDropDownGrabador.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownGrabador.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownGrabador.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownGrabador.DisplayLayout.MaxBandDepth = 5;
            appearance246.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownGrabador.DisplayLayout.Override.ActiveCellAppearance = appearance246;
            appearance247.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance247.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance247.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance247.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownGrabador.DisplayLayout.Override.ActiveRowAppearance = appearance247;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance248.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownGrabador.DisplayLayout.Override.CardAreaAppearance = appearance248;
            appearance249.BackColor = System.Drawing.SystemColors.Control;
            appearance249.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance249.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownGrabador.DisplayLayout.Override.CellAppearance = appearance249;
            this.ultraDropDownGrabador.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance250.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance250.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance250.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance250.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance250.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownGrabador.DisplayLayout.Override.HeaderAppearance = appearance250;
            this.ultraDropDownGrabador.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance251.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownGrabador.DisplayLayout.Override.RowSelectorAppearance = appearance251;
            this.ultraDropDownGrabador.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance252.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownGrabador.DisplayLayout.Override.SelectedCellAppearance = appearance252;
            appearance253.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance253.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance253.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownGrabador.DisplayLayout.Override.SelectedRowAppearance = appearance253;
            appearance254.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance254.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownGrabador.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance254;
            this.ultraDropDownGrabador.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownGrabador.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownGrabador.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownGrabador.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownGrabador.DisplayMember = "NombApel";
            this.ultraDropDownGrabador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownGrabador.Location = new System.Drawing.Point(256, 118);
            this.ultraDropDownGrabador.Name = "ultraDropDownGrabador";
            this.ultraDropDownGrabador.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownGrabador.TabIndex = 50;
            this.ultraDropDownGrabador.ValueMember = "idUsuario";
            this.ultraDropDownGrabador.Visible = false;
            // 
            // dsEntidadesDeCobranza
            // 
            this.dsEntidadesDeCobranza.DataSetName = "DsEntidadesDeCobranza";
            this.dsEntidadesDeCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entidadesDeCobranzaBindingSource
            // 
            this.entidadesDeCobranzaBindingSource.DataMember = "EntidadesDeCobranza";
            this.entidadesDeCobranzaBindingSource.DataSource = this.dsEntidadesDeCobranza;
            // 
            // ultraDropDownEntidadesDeCobranza
            // 
            this.ultraDropDownEntidadesDeCobranza.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownEntidadesDeCobranza.DataSource = this.entidadesDeCobranzaBindingSource;
            appearance99.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance99.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance99.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Appearance = appearance99;
            ultraGridBand2.ColHeadersVisible = false;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn6.Header.VisiblePosition = 0;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn7.Header.VisiblePosition = 1;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn8.Header.VisiblePosition = 3;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn9.Header.VisiblePosition = 2;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn10.Header.VisiblePosition = 4;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn11.Header.VisiblePosition = 5;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn12.Header.VisiblePosition = 6;
            ultraGridColumn12.Hidden = true;
            ultraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn13.Header.VisiblePosition = 7;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn14.Header.VisiblePosition = 8;
            ultraGridColumn14.Hidden = true;
            ultraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn15.Header.VisiblePosition = 9;
            ultraGridColumn15.Hidden = true;
            ultraGridColumn16.Header.VisiblePosition = 10;
            ultraGridColumn16.Hidden = true;
            ultraGridColumn17.Header.VisiblePosition = 11;
            ultraGridColumn17.Hidden = true;
            ultraGridColumn18.Header.VisiblePosition = 12;
            ultraGridColumn18.Hidden = true;
            ultraGridColumn19.Header.VisiblePosition = 13;
            ultraGridColumn19.Hidden = true;
            ultraGridColumn20.Header.VisiblePosition = 14;
            ultraGridColumn20.Hidden = true;
            ultraGridBand2.Columns.AddRange(new object[] {
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
            ultraGridColumn20});
            ultraGridBand2.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.MaxBandDepth = 5;
            appearance100.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.ActiveCellAppearance = appearance100;
            appearance101.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance101.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance101.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance101.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.ActiveRowAppearance = appearance101;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance102.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.CardAreaAppearance = appearance102;
            appearance103.BackColor = System.Drawing.SystemColors.Control;
            appearance103.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance103.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.CellAppearance = appearance103;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance104.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance104.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance104.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance104.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.HeaderAppearance = appearance104;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance105.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.RowSelectorAppearance = appearance105;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.SelectedCellAppearance = appearance106;
            appearance107.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance107.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance107.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.SelectedRowAppearance = appearance107;
            appearance108.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance108.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance108;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownEntidadesDeCobranza.DisplayMember = "Nombre";
            this.ultraDropDownEntidadesDeCobranza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownEntidadesDeCobranza.Location = new System.Drawing.Point(256, 156);
            this.ultraDropDownEntidadesDeCobranza.Name = "ultraDropDownEntidadesDeCobranza";
            this.ultraDropDownEntidadesDeCobranza.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownEntidadesDeCobranza.TabIndex = 51;
            this.ultraDropDownEntidadesDeCobranza.ValueMember = "idEntidadDeCobranza";
            this.ultraDropDownEntidadesDeCobranza.Visible = false;
            this.ultraDropDownEntidadesDeCobranza.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownEntidadesDeCobranza_BeforeDropDown);
            // 
            // ultraDropDownTiposDeValores
            // 
            this.ultraDropDownTiposDeValores.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeValores.DataSource = this.tiposDeValoresBindingSource;
            appearance31.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeValores.DisplayLayout.Appearance = appearance31;
            this.ultraDropDownTiposDeValores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Hidden = true;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5});
            ultraGridBand1.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeValores.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraDropDownTiposDeValores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeValores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeValores.DisplayLayout.MaxBandDepth = 5;
            appearance32.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.ActiveCellAppearance = appearance32;
            appearance33.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance33.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance33.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.ActiveRowAppearance = appearance33;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance34.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.CardAreaAppearance = appearance34;
            appearance35.BackColor = System.Drawing.SystemColors.Control;
            appearance35.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.CellAppearance = appearance35;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance36.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance36.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance36.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance36.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.HeaderAppearance = appearance36;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance37.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.RowSelectorAppearance = appearance37;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.SelectedCellAppearance = appearance38;
            appearance39.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance39.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.SelectedRowAppearance = appearance39;
            appearance40.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance40.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance40;
            this.ultraDropDownTiposDeValores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeValores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeValores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeValores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeValores.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeValores.Location = new System.Drawing.Point(253, 227);
            this.ultraDropDownTiposDeValores.Name = "ultraDropDownTiposDeValores";
            this.ultraDropDownTiposDeValores.Size = new System.Drawing.Size(241, 34);
            this.ultraDropDownTiposDeValores.TabIndex = 52;
            this.ultraDropDownTiposDeValores.ValueMember = "idTipoDeValor";
            this.ultraDropDownTiposDeValores.Visible = false;
            this.ultraDropDownTiposDeValores.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownTiposDeValores_BeforeDropDown);
            this.ultraDropDownTiposDeValores.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.ultraDropDownTiposDeValores_FilterRow);
            // 
            // FormRemesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(745, 488);
            this.Controls.Add(this.remesasUltraGrid);
            this.Controls.Add(this.ultraDropDownTiposDeValores);
            this.Controls.Add(this.ultraDropDownEntidadesDeCobranza);
            this.Controls.Add(this.ultraDropDownGrabador);
            this.Controls.Add(this.ultraDropDownReceptor);
            this.Controls.Add(this.ultraDropDownBancos);
            this.Controls.Add(this.ultraDropDownCobradores);
            this.Controls.Add(this.ultraCurrencyEditorSumValores);
            this.Controls.Add(this.ultraCurrencyEditorSumComprobantes);
            this.MinimumSize = new System.Drawing.Size(753, 522);
            this.Name = "FormRemesa";
            this.Text = "Rendición";
            this.Activated += new System.EventHandler(this.FormRemesaActivated);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraCurrencyEditorSumComprobantes, 0);
            this.Controls.SetChildIndex(this.ultraCurrencyEditorSumValores, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCobradores, 0);
            this.Controls.SetChildIndex(this.ultraDropDownBancos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownReceptor, 0);
            this.Controls.SetChildIndex(this.ultraDropDownGrabador, 0);
            this.Controls.SetChildIndex(this.ultraDropDownEntidadesDeCobranza, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeValores, 0);
            this.Controls.SetChildIndex(this.remesasUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.remesasUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remesasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditorSumComprobantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditorSumValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCobradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCobradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeValoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownReceptor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesDeCobranzaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEntidadesDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeValores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid remesasUltraGrid;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalcManager1;
        private Infragistics.Win.UltraWinEditors.UltraCurrencyEditor ultraCurrencyEditorSumComprobantes;
        private Infragistics.Win.UltraWinEditors.UltraCurrencyEditor ultraCurrencyEditorSumValores;
        private Infragistics.Win.Misc.UltraLabel ultraLabelMensaje;
        private System.Windows.Forms.BindingSource remesasBindingSource;
        private WS.DsRemesas dsRemesas;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCobradores;
        private System.Windows.Forms.BindingSource tiposDeValoresBindingSource;
        private WS.DsTiposDeValores dsTiposDeValores;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownBancos;
        private System.Windows.Forms.BindingSource bancosBindingSource;
        private WS.DsBancos dsBancos;
        private System.Windows.Forms.BindingSource cobradoresBindingSource;
        private WS.DsEmpleadosLista dsCobradores;
        private System.Windows.Forms.BindingSource empleadosListaBindingSource;
        private WS.DsEmpleadosLista dsEmpleadosLista;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownReceptor;
        private System.Windows.Forms.BindingSource usuariosListaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownGrabador;
        private WS.DsUsuariosLista dsUsuariosLista1;
        private WS.DsEntidadesDeCobranza dsEntidadesDeCobranza;
        private System.Windows.Forms.BindingSource entidadesDeCobranzaBindingSource;
        private UltraDropDown ultraDropDownEntidadesDeCobranza;
        private UltraDropDown ultraDropDownTiposDeValores;
    }
}

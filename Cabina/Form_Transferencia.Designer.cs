using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    partial class FormTransferencia
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
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Transferencias", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("De", -1, "ultraDropDownDe");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("A", -1, "ultraDropDownReceptor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTransferencia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrabador", -1, "ultraDropDownGrabador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__ValoresTr__idTra__6B3AC472");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__ValoresTr__idTra__6B3AC472", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idValorTransferencia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTransferencia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeCheque");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencimiento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Transferido");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteTransferido");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeValor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idValorRemesa");
            Infragistics.Win.UltraWinGrid.ColScrollRegion colScrollRegion1 = new Infragistics.Win.UltraWinGrid.ColScrollRegion(922);
            Infragistics.Win.UltraWinGrid.ColScrollRegion colScrollRegion2 = new Infragistics.Win.UltraWinGrid.ColScrollRegion(922);
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance245 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("UsuariosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idUsuario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.Appearance appearance246 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance247 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance248 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance249 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance250 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance251 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance252 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance253 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance254 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Bancos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeValores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeValor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereBanco");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsEfectivo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SePagaCon");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ValoresTransferencias", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idValorTransferencia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTransferencia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeCheque");
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencimiento");
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Transferido");
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteTransferido", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeValor", -1, "ultraDropDownTiposDeValores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco", -1, "ultraDropDownBancos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idValorRemesa");
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings1 = new Infragistics.Win.UltraWinGrid.SummarySettings("Suma", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "ImporteTransferido", 7, true, "ValoresTransferencias", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "ImporteTransferido", 7, true);
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            this.transferenciasUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.transferenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransferencias = new Cabina.WS.DsTransferencias();
            this.ultraDropDownGrabador = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.usuariosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUsuariosLista1 = new Cabina.WS.DsUsuariosLista();
            this.ultraDropDownReceptor = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.empleadosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmpleadosLista = new Cabina.WS.DsEmpleadosLista();
            this.ultraDropDownBancos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.bancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBancos = new Cabina.WS.DsBancos();
            this.ultraDropDownTiposDeValores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeValoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeValores = new Cabina.WS.DsTiposDeValores();
            this.valoresTransferenciasUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.valoresTransferenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEnCaja1 = new Cabina.WS.DsEnCaja();
            this.ultraDropDownDe = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transferenciasUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownReceptor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeValoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valoresTransferenciasUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valoresTransferenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEnCaja1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownDe)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(834, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(753, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 217);
            this.panel1.Size = new System.Drawing.Size(924, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(753, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // transferenciasUltraGrid
            // 
            this.transferenciasUltraGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.transferenciasUltraGrid.DataSource = this.transferenciasBindingSource;
            appearance21.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.transferenciasUltraGrid.DisplayLayout.Appearance = appearance21;
            this.transferenciasUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance22.TextHAlignAsString = "Center";
            ultraGridColumn1.CellAppearance = appearance22;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Width = 110;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn2.Width = 224;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn3.Width = 219;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance23.TextHAlignAsString = "Right";
            ultraGridColumn4.CellAppearance = appearance23;
            ultraGridColumn4.Header.VisiblePosition = 4;
            ultraGridColumn4.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn4.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn4.Width = 127;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn5.Header.VisiblePosition = 5;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn6.Header.Caption = "Grabador";
            ultraGridColumn6.Header.VisiblePosition = 3;
            ultraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn6.Width = 187;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7});
            ultraGridBand1.MaxRows = 1;
            ultraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            ultraGridColumn8.Header.VisiblePosition = 0;
            ultraGridColumn8.Width = 96;
            ultraGridColumn9.Header.VisiblePosition = 1;
            ultraGridColumn9.Width = 78;
            ultraGridColumn10.Header.VisiblePosition = 2;
            ultraGridColumn10.Width = 68;
            ultraGridColumn11.Header.VisiblePosition = 3;
            ultraGridColumn11.Width = 92;
            ultraGridColumn12.Header.VisiblePosition = 4;
            ultraGridColumn12.Width = 76;
            ultraGridColumn13.Header.VisiblePosition = 5;
            ultraGridColumn13.Width = 83;
            ultraGridColumn14.Header.VisiblePosition = 6;
            ultraGridColumn14.Width = 62;
            ultraGridColumn15.Header.VisiblePosition = 7;
            ultraGridColumn15.Width = 93;
            ultraGridColumn16.Header.VisiblePosition = 8;
            ultraGridColumn16.Width = 73;
            ultraGridColumn17.Header.VisiblePosition = 9;
            ultraGridColumn17.Width = 49;
            ultraGridColumn18.Header.VisiblePosition = 10;
            ultraGridColumn18.Width = 78;
            ultraGridBand2.Columns.AddRange(new object[] {
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
            ultraGridColumn18});
            this.transferenciasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.transferenciasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.transferenciasUltraGrid.DisplayLayout.ColScrollRegions.Add(colScrollRegion1);
            this.transferenciasUltraGrid.DisplayLayout.ColScrollRegions.Add(colScrollRegion2);
            this.transferenciasUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.transferenciasUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.transferenciasUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance26.BackColor = System.Drawing.SystemColors.Window;
            this.transferenciasUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance26;
            appearance27.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance27.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance27.ForeColor = System.Drawing.SystemColors.WindowText;
            this.transferenciasUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance27;
            this.transferenciasUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.transferenciasUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.transferenciasUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.transferenciasUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.transferenciasUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.transferenciasUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.transferenciasUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance28.BackColor = System.Drawing.Color.Transparent;
            this.transferenciasUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance28;
            appearance29.BackColor = System.Drawing.SystemColors.Control;
            appearance29.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.transferenciasUltraGrid.DisplayLayout.Override.CellAppearance = appearance29;
            this.transferenciasUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance30.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance30.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance30.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.transferenciasUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance30;
            this.transferenciasUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance31.ForeColor = System.Drawing.Color.Red;
            this.transferenciasUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance31;
            this.transferenciasUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.transferenciasUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance32;
            appearance34.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance34.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.transferenciasUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance34;
            appearance35.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance35.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.transferenciasUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance35;
            this.transferenciasUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.transferenciasUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.transferenciasUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.transferenciasUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.transferenciasUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferenciasUltraGrid.Location = new System.Drawing.Point(0, -1);
            this.transferenciasUltraGrid.Name = "transferenciasUltraGrid";
            this.transferenciasUltraGrid.Size = new System.Drawing.Size(924, 44);
            this.transferenciasUltraGrid.TabIndex = 2;
            this.transferenciasUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.TransferenciasUltraGridInitializeRow);
            this.transferenciasUltraGrid.CellListSelect += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.TransferenciasUltraGridCellListSelect);
            this.transferenciasUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.transferenciasUltraGrid_KeyDown);
            // 
            // transferenciasBindingSource
            // 
            this.transferenciasBindingSource.DataMember = "Transferencias";
            this.transferenciasBindingSource.DataSource = this.dsTransferencias;
            // 
            // dsTransferencias
            // 
            this.dsTransferencias.DataSetName = "DsTransferencias";
            this.dsTransferencias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownGrabador
            // 
            this.ultraDropDownGrabador.DataSource = this.usuariosListaBindingSource;
            appearance245.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance245.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance245.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownGrabador.DisplayLayout.Appearance = appearance245;
            ultraGridBand3.ColHeadersVisible = false;
            ultraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn19.Header.VisiblePosition = 0;
            ultraGridColumn19.Hidden = true;
            ultraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn20.Header.VisiblePosition = 1;
            ultraGridColumn20.Hidden = true;
            ultraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn21.Header.VisiblePosition = 2;
            ultraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn22.Header.VisiblePosition = 3;
            ultraGridColumn22.Hidden = true;
            ultraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn23.Header.VisiblePosition = 4;
            ultraGridColumn23.Hidden = true;
            ultraGridColumn24.Header.VisiblePosition = 5;
            ultraGridColumn24.Hidden = true;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn19,
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24});
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
            this.ultraDropDownGrabador.Location = new System.Drawing.Point(454, 188);
            this.ultraDropDownGrabador.Name = "ultraDropDownGrabador";
            this.ultraDropDownGrabador.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownGrabador.TabIndex = 54;
            this.ultraDropDownGrabador.ValueMember = "idUsuario";
            this.ultraDropDownGrabador.Visible = false;
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
            // ultraDropDownReceptor
            // 
            this.ultraDropDownReceptor.DataSource = this.empleadosListaBindingSource;
            appearance36.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance36.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownReceptor.DisplayLayout.Appearance = appearance36;
            this.ultraDropDownReceptor.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand4.ColHeadersVisible = false;
            ultraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn25.Header.VisiblePosition = 0;
            ultraGridColumn25.Hidden = true;
            ultraGridColumn25.Width = 30;
            ultraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn26.Header.VisiblePosition = 1;
            ultraGridColumn26.Hidden = true;
            ultraGridColumn26.Width = 21;
            ultraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn27.Header.VisiblePosition = 2;
            ultraGridColumn27.Hidden = true;
            ultraGridColumn27.Width = 45;
            ultraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn28.Header.VisiblePosition = 3;
            ultraGridColumn28.Hidden = true;
            ultraGridColumn28.Width = 45;
            ultraGridColumn29.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn29.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn29.Header.VisiblePosition = 4;
            ultraGridColumn29.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(144, 0);
            ultraGridColumn29.Width = 182;
            ultraGridColumn30.Header.VisiblePosition = 5;
            ultraGridColumn30.Hidden = true;
            ultraGridColumn31.Header.VisiblePosition = 6;
            ultraGridColumn31.Hidden = true;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn25,
            ultraGridColumn26,
            ultraGridColumn27,
            ultraGridColumn28,
            ultraGridColumn29,
            ultraGridColumn30,
            ultraGridColumn31});
            ultraGridBand4.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            this.ultraDropDownReceptor.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownReceptor.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownReceptor.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownReceptor.DisplayLayout.MaxBandDepth = 5;
            appearance47.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownReceptor.DisplayLayout.Override.ActiveCellAppearance = appearance47;
            appearance48.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance48.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance48.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownReceptor.DisplayLayout.Override.ActiveRowAppearance = appearance48;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance49.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownReceptor.DisplayLayout.Override.CardAreaAppearance = appearance49;
            appearance59.BackColor = System.Drawing.SystemColors.Control;
            appearance59.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownReceptor.DisplayLayout.Override.CellAppearance = appearance59;
            this.ultraDropDownReceptor.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance60.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance60.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance60.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance60.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownReceptor.DisplayLayout.Override.HeaderAppearance = appearance60;
            this.ultraDropDownReceptor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance69.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownReceptor.DisplayLayout.Override.RowSelectorAppearance = appearance69;
            this.ultraDropDownReceptor.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance70.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownReceptor.DisplayLayout.Override.SelectedCellAppearance = appearance70;
            appearance79.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance79.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance79.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownReceptor.DisplayLayout.Override.SelectedRowAppearance = appearance79;
            appearance80.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance80.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownReceptor.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance80;
            this.ultraDropDownReceptor.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownReceptor.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownReceptor.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownReceptor.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownReceptor.DisplayMember = "ApelNomb";
            this.ultraDropDownReceptor.Location = new System.Drawing.Point(454, 147);
            this.ultraDropDownReceptor.Name = "ultraDropDownReceptor";
            this.ultraDropDownReceptor.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownReceptor.TabIndex = 53;
            this.ultraDropDownReceptor.ValueMember = "idEmpleado";
            this.ultraDropDownReceptor.Visible = false;
            this.ultraDropDownReceptor.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownReceptorFilterRow);
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
            // ultraDropDownBancos
            // 
            this.ultraDropDownBancos.DataSource = this.bancosBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBancos.DisplayLayout.Appearance = appearance1;
            this.ultraDropDownBancos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn32.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn32.Header.VisiblePosition = 0;
            ultraGridColumn32.Hidden = true;
            ultraGridColumn33.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn33.Header.VisiblePosition = 1;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn32,
            ultraGridColumn33});
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
            this.ultraDropDownBancos.DropDownWidth = 250;
            this.ultraDropDownBancos.Location = new System.Drawing.Point(210, 187);
            this.ultraDropDownBancos.Name = "ultraDropDownBancos";
            this.ultraDropDownBancos.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownBancos.TabIndex = 52;
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
            // ultraDropDownTiposDeValores
            // 
            this.ultraDropDownTiposDeValores.DataSource = this.tiposDeValoresBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeValores.DisplayLayout.Appearance = appearance11;
            this.ultraDropDownTiposDeValores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand6.ColHeadersVisible = false;
            ultraGridColumn34.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn34.Header.VisiblePosition = 0;
            ultraGridColumn34.Hidden = true;
            ultraGridColumn35.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn35.Header.VisiblePosition = 1;
            ultraGridColumn36.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn36.Header.VisiblePosition = 2;
            ultraGridColumn36.Hidden = true;
            ultraGridColumn37.Header.VisiblePosition = 3;
            ultraGridColumn37.Hidden = true;
            ultraGridColumn38.Header.VisiblePosition = 4;
            ultraGridColumn38.Hidden = true;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn34,
            ultraGridColumn35,
            ultraGridColumn36,
            ultraGridColumn37,
            ultraGridColumn38});
            ultraGridBand6.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand6.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeValores.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraDropDownTiposDeValores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeValores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeValores.DisplayLayout.MaxBandDepth = 5;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.ActiveRowAppearance = appearance13;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.CellAppearance = appearance15;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.SelectedCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance20;
            this.ultraDropDownTiposDeValores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeValores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeValores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeValores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeValores.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeValores.DropDownWidth = 250;
            this.ultraDropDownTiposDeValores.Location = new System.Drawing.Point(210, 147);
            this.ultraDropDownTiposDeValores.Name = "ultraDropDownTiposDeValores";
            this.ultraDropDownTiposDeValores.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeValores.TabIndex = 51;
            this.ultraDropDownTiposDeValores.ValueMember = "idTipoDeValor";
            this.ultraDropDownTiposDeValores.Visible = false;
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
            // valoresTransferenciasUltraGrid
            // 
            this.valoresTransferenciasUltraGrid.DataSource = this.valoresTransferenciasBindingSource;
            appearance33.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Appearance = appearance33;
            this.valoresTransferenciasUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn39.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn39.Header.VisiblePosition = 0;
            ultraGridColumn39.Hidden = true;
            ultraGridColumn39.Width = 93;
            ultraGridColumn40.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn40.Header.VisiblePosition = 1;
            ultraGridColumn40.Hidden = true;
            ultraGridColumn40.Width = 77;
            ultraGridColumn41.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance24.TextHAlignAsString = "Right";
            ultraGridColumn41.CellAppearance = appearance24;
            ultraGridColumn41.Header.VisiblePosition = 7;
            ultraGridColumn41.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn41.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn41.Width = 91;
            ultraGridColumn42.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance25.TextHAlignAsString = "Right";
            ultraGridColumn42.CellAppearance = appearance25;
            ultraGridColumn42.Header.Caption = "Numero de Cheque";
            ultraGridColumn42.Header.VisiblePosition = 4;
            ultraGridColumn42.Width = 77;
            ultraGridColumn43.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn43.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance61.TextHAlignAsString = "Center";
            ultraGridColumn43.CellAppearance = appearance61;
            ultraGridColumn43.Header.VisiblePosition = 5;
            ultraGridColumn43.Width = 88;
            ultraGridColumn44.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn44.Header.VisiblePosition = 6;
            ultraGridColumn44.Width = 275;
            ultraGridColumn45.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance62.TextHAlignAsString = "Center";
            ultraGridColumn45.CellAppearance = appearance62;
            ultraGridColumn45.Header.VisiblePosition = 8;
            ultraGridColumn45.Width = 73;
            ultraGridColumn46.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance63.TextHAlignAsString = "Right";
            ultraGridColumn46.CellAppearance = appearance63;
            ultraGridColumn46.Header.Caption = "Importe Transferido";
            ultraGridColumn46.Header.VisiblePosition = 9;
            ultraGridColumn46.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn46.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn46.Width = 103;
            ultraGridColumn47.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn47.Header.Caption = "Tipo de Valor";
            ultraGridColumn47.Header.VisiblePosition = 2;
            ultraGridColumn47.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn47.Width = 73;
            ultraGridColumn48.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn48.Header.Caption = "Banco";
            ultraGridColumn48.Header.VisiblePosition = 3;
            ultraGridColumn48.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn48.Width = 123;
            ultraGridColumn49.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn49.Header.VisiblePosition = 10;
            ultraGridColumn49.Hidden = true;
            ultraGridColumn49.Width = 94;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn39,
            ultraGridColumn40,
            ultraGridColumn41,
            ultraGridColumn42,
            ultraGridColumn43,
            ultraGridColumn44,
            ultraGridColumn45,
            ultraGridColumn46,
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49});
            ultraGridBand7.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand7.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.True;
            appearance64.FontData.BoldAsString = "True";
            appearance64.TextHAlignAsString = "Right";
            summarySettings1.Appearance = appearance64;
            summarySettings1.DisplayFormat = "{0:c}";
            summarySettings1.GroupBySummaryValueAppearance = appearance65;
            ultraGridBand7.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings1});
            this.valoresTransferenciasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.valoresTransferenciasUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.valoresTransferenciasUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.valoresTransferenciasUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance50.BackColor = System.Drawing.SystemColors.Window;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance50;
            appearance51.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance51.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance51.ForeColor = System.Drawing.SystemColors.WindowText;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance51;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance52.BackColor = System.Drawing.Color.Transparent;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance52;
            appearance53.BackColor = System.Drawing.SystemColors.Control;
            appearance53.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.CellAppearance = appearance53;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance54.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance54.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance54.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance54.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance54;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance55.ForeColor = System.Drawing.Color.Red;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance55;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance56;
            appearance57.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance57.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance57;
            appearance58.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance58.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.valoresTransferenciasUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance58;
            this.valoresTransferenciasUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.valoresTransferenciasUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.valoresTransferenciasUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.valoresTransferenciasUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.valoresTransferenciasUltraGrid.Location = new System.Drawing.Point(0, 40);
            this.valoresTransferenciasUltraGrid.Name = "valoresTransferenciasUltraGrid";
            this.valoresTransferenciasUltraGrid.Size = new System.Drawing.Size(924, 187);
            this.valoresTransferenciasUltraGrid.TabIndex = 55;
            this.valoresTransferenciasUltraGrid.Visible = false;
            this.valoresTransferenciasUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.ValoresTransferenciasUltraGridInitializeRow);
            this.valoresTransferenciasUltraGrid.AfterEnterEditMode += new System.EventHandler(this.valoresTransferenciasUltraGrid_AfterEnterEditMode);
            this.valoresTransferenciasUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ValoresTransferenciasUltraGridCellChange);
            this.valoresTransferenciasUltraGrid.SummaryValueChanged += new Infragistics.Win.UltraWinGrid.SummaryValueChangedEventHandler(this.ValoresTransferenciasUltraGridSummaryValueChanged);
            this.valoresTransferenciasUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valoresTransferenciasUltraGrid_KeyDown);
            // 
            // valoresTransferenciasBindingSource
            // 
            this.valoresTransferenciasBindingSource.DataMember = "ValoresTransferencias";
            this.valoresTransferenciasBindingSource.DataSource = this.dsTransferencias;
            // 
            // dsEnCaja1
            // 
            this.dsEnCaja1.DataSetName = "DsEnCaja";
            this.dsEnCaja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownDe
            // 
            this.ultraDropDownDe.DataSource = this.empleadosListaBindingSource;
            appearance37.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance37.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownDe.DisplayLayout.Appearance = appearance37;
            this.ultraDropDownDe.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand8.ColHeadersVisible = false;
            ultraGridColumn50.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn50.Header.VisiblePosition = 0;
            ultraGridColumn50.Hidden = true;
            ultraGridColumn50.Width = 30;
            ultraGridColumn51.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn51.Header.VisiblePosition = 1;
            ultraGridColumn51.Hidden = true;
            ultraGridColumn51.Width = 21;
            ultraGridColumn52.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn52.Header.VisiblePosition = 2;
            ultraGridColumn52.Hidden = true;
            ultraGridColumn52.Width = 45;
            ultraGridColumn53.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn53.Header.VisiblePosition = 3;
            ultraGridColumn53.Hidden = true;
            ultraGridColumn53.Width = 45;
            ultraGridColumn54.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn54.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn54.Header.VisiblePosition = 4;
            ultraGridColumn54.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(146, 0);
            ultraGridColumn54.Width = 182;
            ultraGridColumn55.Header.VisiblePosition = 5;
            ultraGridColumn55.Hidden = true;
            ultraGridColumn56.Header.VisiblePosition = 6;
            ultraGridColumn56.Hidden = true;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn50,
            ultraGridColumn51,
            ultraGridColumn52,
            ultraGridColumn53,
            ultraGridColumn54,
            ultraGridColumn55,
            ultraGridColumn56});
            ultraGridBand8.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            this.ultraDropDownDe.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.ultraDropDownDe.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownDe.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownDe.DisplayLayout.MaxBandDepth = 5;
            appearance38.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownDe.DisplayLayout.Override.ActiveCellAppearance = appearance38;
            appearance39.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance39.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance39.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownDe.DisplayLayout.Override.ActiveRowAppearance = appearance39;
            this.ultraDropDownDe.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownDe.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownDe.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownDe.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownDe.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownDe.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownDe.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance40.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownDe.DisplayLayout.Override.CardAreaAppearance = appearance40;
            appearance41.BackColor = System.Drawing.SystemColors.Control;
            appearance41.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownDe.DisplayLayout.Override.CellAppearance = appearance41;
            this.ultraDropDownDe.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance42.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance42.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance42.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance42.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownDe.DisplayLayout.Override.HeaderAppearance = appearance42;
            this.ultraDropDownDe.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance43.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownDe.DisplayLayout.Override.RowSelectorAppearance = appearance43;
            this.ultraDropDownDe.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownDe.DisplayLayout.Override.SelectedCellAppearance = appearance44;
            appearance45.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance45.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownDe.DisplayLayout.Override.SelectedRowAppearance = appearance45;
            appearance46.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance46.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownDe.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance46;
            this.ultraDropDownDe.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownDe.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownDe.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownDe.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownDe.DisplayMember = "ApelNomb";
            this.ultraDropDownDe.Location = new System.Drawing.Point(454, 106);
            this.ultraDropDownDe.Name = "ultraDropDownDe";
            this.ultraDropDownDe.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownDe.TabIndex = 56;
            this.ultraDropDownDe.ValueMember = "idEmpleado";
            this.ultraDropDownDe.Visible = false;
            this.ultraDropDownDe.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownReceptorFilterRow);
            // 
            // FormTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(923, 265);
            this.Controls.Add(this.valoresTransferenciasUltraGrid);
            this.Controls.Add(this.ultraDropDownDe);
            this.Controls.Add(this.transferenciasUltraGrid);
            this.Controls.Add(this.ultraDropDownGrabador);
            this.Controls.Add(this.ultraDropDownReceptor);
            this.Controls.Add(this.ultraDropDownBancos);
            this.Controls.Add(this.ultraDropDownTiposDeValores);
            this.Name = "FormTransferencia";
            this.Text = "Transferencia de Valores";
            this.Load += new System.EventHandler(this.FormTransferenciaLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeValores, 0);
            this.Controls.SetChildIndex(this.ultraDropDownBancos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownReceptor, 0);
            this.Controls.SetChildIndex(this.ultraDropDownGrabador, 0);
            this.Controls.SetChildIndex(this.transferenciasUltraGrid, 0);
            this.Controls.SetChildIndex(this.ultraDropDownDe, 0);
            this.Controls.SetChildIndex(this.valoresTransferenciasUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transferenciasUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownReceptor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeValoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valoresTransferenciasUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valoresTransferenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEnCaja1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownDe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsTransferencias dsTransferencias;
        private System.Windows.Forms.BindingSource transferenciasBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid transferenciasUltraGrid;
        private WS.DsTiposDeValores dsTiposDeValores;
        private System.Windows.Forms.BindingSource tiposDeValoresBindingSource;
        private WS.DsBancos dsBancos;
        private System.Windows.Forms.BindingSource bancosBindingSource;
        private System.Windows.Forms.BindingSource empleadosListaBindingSource;
        private WS.DsEmpleadosLista dsEmpleadosLista;
        private System.Windows.Forms.BindingSource usuariosListaBindingSource;
        private WS.DsUsuariosLista dsUsuariosLista1;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownGrabador;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownReceptor;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownBancos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeValores;
        private System.Windows.Forms.BindingSource valoresTransferenciasBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid valoresTransferenciasUltraGrid;
        private WS.DsEnCaja dsEnCaja1;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownDe;
    }
}

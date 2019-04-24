namespace Administración
{
    partial class FormCambiarNumeroFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Comprobantes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobante");
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante", -1, "ultraDropDownTiposDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo");
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Anulado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Vinculados");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Prefijo", -1, "ultraDropDownPrefijos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Apellido");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Direccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Entre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Barrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ObservacionesDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Telefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CAE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ServicioDesde");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ServicioHasta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__DetallesC__idCom__07AC1A97");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PDF", 0);
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__DetallesC__idCom__07AC1A97", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDetalleComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Detalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn119 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn120 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn121 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn122 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA");
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PuntosDeVenta", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPuntoDeVenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Prefijo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Verdadero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SolicitaCAE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoM");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCM");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDM");
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn123 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad");
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeComprobante", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn124 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn125 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn126 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn127 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteNegativo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn128 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DiscriminaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn129 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsFactura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn130 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn131 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn132 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TablaAFIP");
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn133 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PuntosDeVenta", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn134 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPuntoDeVenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn135 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Prefijo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn136 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn137 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn138 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn139 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn140 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Verdadero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn141 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn142 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn143 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn144 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn145 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SolicitaCAE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn146 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoM");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn147 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCM");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn148 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDM");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.comprobantesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.comprobantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsComprobantes = new Administración.WS.DsComprobantes();
            this.puntosDeVentaUltraCombo = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.puntosDeVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPuntosDeVenta = new Administración.WS.DsPuntosDeVenta();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraMaskedEditDesde = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraLabelDesde = new Infragistics.Win.Misc.UltraLabel();
            this.ultraDataSourceCantidad = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraComboCantidad = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraButtonBuscar = new Infragistics.Win.Misc.UltraButton();
            this.ultraDropDownTiposDeComprobante = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeComprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeComprobante = new Administración.WS.DsTiposDeComprobante();
            this.ultraDataSourceSeries = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.tiposDeComprobanteUltraCombo = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.ultraDropDownPrefijos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsFacturasSinCAE = new Administración.DsFacturasSinCAE();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprobantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaUltraCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntosDeVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteUltraCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrefijos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasSinCAE)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(907, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(826, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Size = new System.Drawing.Size(997, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(745, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // comprobantesUltraGrid
            // 
            this.comprobantesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprobantesUltraGrid.DataSource = this.comprobantesBindingSource;
            appearance16.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.comprobantesUltraGrid.DisplayLayout.Appearance = appearance16;
            this.comprobantesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            appearance11.TextHAlignAsString = "Right";
            ultraGridColumn46.CellAppearance = appearance11;
            ultraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn46.Header.VisiblePosition = 0;
            ultraGridColumn46.Hidden = true;
            ultraGridColumn46.Width = 61;
            ultraGridColumn47.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn47.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn47.Header.Caption = "Tipo";
            ultraGridColumn47.Header.VisiblePosition = 1;
            ultraGridColumn47.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn47.Width = 51;
            ultraGridColumn48.Header.Caption = "Número";
            ultraGridColumn48.Header.VisiblePosition = 3;
            ultraGridColumn48.Width = 84;
            appearance12.TextHAlignAsString = "Center";
            ultraGridColumn49.CellAppearance = appearance12;
            ultraGridColumn49.Header.VisiblePosition = 4;
            ultraGridColumn49.Width = 66;
            appearance13.TextHAlignAsString = "Center";
            ultraGridColumn50.CellAppearance = appearance13;
            ultraGridColumn50.Header.Caption = "Período";
            ultraGridColumn50.Header.VisiblePosition = 5;
            ultraGridColumn50.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn50.MaskInput = "mm/yyyy";
            ultraGridColumn50.Width = 69;
            appearance26.TextHAlignAsString = "Right";
            ultraGridColumn51.CellAppearance = appearance26;
            ultraGridColumn51.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn51.Header.VisiblePosition = 7;
            ultraGridColumn51.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn51.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn51.Width = 62;
            ultraGridColumn52.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn52.Header.Caption = "Nombre";
            ultraGridColumn52.Header.VisiblePosition = 6;
            ultraGridColumn52.Width = 149;
            ultraGridColumn53.Header.Caption = "Anulada";
            ultraGridColumn53.Header.VisiblePosition = 8;
            ultraGridColumn53.Width = 42;
            ultraGridColumn54.Header.VisiblePosition = 9;
            ultraGridColumn54.Hidden = true;
            ultraGridColumn54.Width = 60;
            ultraGridColumn55.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn55.Header.VisiblePosition = 2;
            ultraGridColumn55.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn55.Width = 80;
            ultraGridColumn56.Header.VisiblePosition = 10;
            ultraGridColumn56.Hidden = true;
            ultraGridColumn56.Width = 34;
            ultraGridColumn57.Header.VisiblePosition = 11;
            ultraGridColumn57.Hidden = true;
            ultraGridColumn57.Width = 34;
            ultraGridColumn58.Header.VisiblePosition = 12;
            ultraGridColumn58.Hidden = true;
            ultraGridColumn58.Width = 34;
            ultraGridColumn59.Header.VisiblePosition = 13;
            ultraGridColumn59.Hidden = true;
            ultraGridColumn59.Width = 34;
            ultraGridColumn60.Header.VisiblePosition = 14;
            ultraGridColumn60.Hidden = true;
            ultraGridColumn60.Width = 34;
            ultraGridColumn61.Header.VisiblePosition = 15;
            ultraGridColumn61.Hidden = true;
            ultraGridColumn61.Width = 34;
            ultraGridColumn62.Header.VisiblePosition = 16;
            ultraGridColumn62.Hidden = true;
            ultraGridColumn62.Width = 48;
            ultraGridColumn63.Header.VisiblePosition = 17;
            ultraGridColumn63.Hidden = true;
            ultraGridColumn63.Width = 34;
            ultraGridColumn64.Header.VisiblePosition = 18;
            ultraGridColumn64.Hidden = true;
            ultraGridColumn64.Width = 31;
            ultraGridColumn65.Header.VisiblePosition = 19;
            ultraGridColumn65.Width = 84;
            ultraGridColumn66.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn66.Header.VisiblePosition = 20;
            ultraGridColumn66.Width = 84;
            ultraGridColumn67.Header.VisiblePosition = 21;
            ultraGridColumn67.Width = 62;
            ultraGridColumn68.Header.VisiblePosition = 22;
            ultraGridColumn68.Width = 64;
            ultraGridColumn69.Header.VisiblePosition = 24;
            appearance28.TextHAlignAsString = "Center";
            ultraGridColumn70.CellAppearance = appearance28;
            ultraGridColumn70.Header.VisiblePosition = 23;
            ultraGridColumn70.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridColumn70.Width = 76;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn46,
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49,
            ultraGridColumn50,
            ultraGridColumn51,
            ultraGridColumn52,
            ultraGridColumn53,
            ultraGridColumn54,
            ultraGridColumn55,
            ultraGridColumn56,
            ultraGridColumn57,
            ultraGridColumn58,
            ultraGridColumn59,
            ultraGridColumn60,
            ultraGridColumn61,
            ultraGridColumn62,
            ultraGridColumn63,
            ultraGridColumn64,
            ultraGridColumn65,
            ultraGridColumn66,
            ultraGridColumn67,
            ultraGridColumn68,
            ultraGridColumn69,
            ultraGridColumn70});
            ultraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            ultraGridColumn71.Header.VisiblePosition = 0;
            ultraGridColumn71.Width = 119;
            ultraGridColumn72.Header.VisiblePosition = 1;
            ultraGridColumn72.Width = 120;
            ultraGridColumn73.Header.VisiblePosition = 2;
            ultraGridColumn73.Width = 60;
            ultraGridColumn74.Header.VisiblePosition = 3;
            ultraGridColumn74.Width = 102;
            ultraGridColumn119.Header.VisiblePosition = 4;
            ultraGridColumn119.Width = 90;
            ultraGridColumn120.Header.VisiblePosition = 5;
            ultraGridColumn120.Width = 92;
            ultraGridColumn121.Header.VisiblePosition = 6;
            ultraGridColumn121.Width = 60;
            ultraGridColumn122.Header.VisiblePosition = 7;
            ultraGridColumn122.Width = 106;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn71,
            ultraGridColumn72,
            ultraGridColumn73,
            ultraGridColumn74,
            ultraGridColumn119,
            ultraGridColumn120,
            ultraGridColumn121,
            ultraGridColumn122});
            ultraGridBand2.Hidden = true;
            this.comprobantesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.comprobantesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.comprobantesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.comprobantesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.comprobantesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance17.BackColor = System.Drawing.SystemColors.Window;
            this.comprobantesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance17;
            appearance14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance14.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comprobantesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance14;
            this.comprobantesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.comprobantesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.comprobantesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.comprobantesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.comprobantesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.comprobantesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.comprobantesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance18.BackColor = System.Drawing.Color.Transparent;
            this.comprobantesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.Control;
            appearance19.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.comprobantesUltraGrid.DisplayLayout.Override.CellAppearance = appearance19;
            this.comprobantesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance20.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance20.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.comprobantesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance20;
            this.comprobantesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance21.ForeColor = System.Drawing.Color.Red;
            this.comprobantesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance21;
            this.comprobantesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.comprobantesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance23.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.comprobantesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance23;
            appearance24.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance24.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.comprobantesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance24;
            this.comprobantesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comprobantesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.comprobantesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.comprobantesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.comprobantesUltraGrid.Location = new System.Drawing.Point(0, 37);
            this.comprobantesUltraGrid.Name = "comprobantesUltraGrid";
            this.comprobantesUltraGrid.Size = new System.Drawing.Size(994, 395);
            this.comprobantesUltraGrid.TabIndex = 2;
            this.comprobantesUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.ComprobantesUltraGridInitializeRow);
            this.comprobantesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.ComprobantesUltraGridAfterEnterEditMode);
            this.comprobantesUltraGrid.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.comprobantesUltraGrid_ClickCellButton);
            this.comprobantesUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comprobantesUltraGrid_KeyDown);
            // 
            // comprobantesBindingSource
            // 
            this.comprobantesBindingSource.DataMember = "Comprobantes";
            this.comprobantesBindingSource.DataSource = this.dsComprobantes;
            // 
            // dsComprobantes
            // 
            this.dsComprobantes.DataSetName = "DsComprobantes";
            this.dsComprobantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // puntosDeVentaUltraCombo
            // 
            this.puntosDeVentaUltraCombo.AllowNull = Infragistics.Win.DefaultableBoolean.True;
            this.puntosDeVentaUltraCombo.DataSource = this.puntosDeVentaBindingSource;
            this.puntosDeVentaUltraCombo.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand3.ColHeadersVisible = false;
            ultraGridColumn31.Header.VisiblePosition = 0;
            ultraGridColumn31.Hidden = true;
            ultraGridColumn32.Header.VisiblePosition = 1;
            ultraGridColumn32.Width = 8;
            ultraGridColumn33.Header.VisiblePosition = 2;
            ultraGridColumn33.Hidden = true;
            ultraGridColumn34.Header.VisiblePosition = 3;
            ultraGridColumn34.Hidden = true;
            ultraGridColumn35.Header.VisiblePosition = 4;
            ultraGridColumn35.Hidden = true;
            ultraGridColumn36.Header.VisiblePosition = 5;
            ultraGridColumn36.Hidden = true;
            ultraGridColumn37.Header.VisiblePosition = 6;
            ultraGridColumn37.Hidden = true;
            ultraGridColumn37.Width = 27;
            ultraGridColumn38.Header.VisiblePosition = 7;
            ultraGridColumn38.Hidden = true;
            ultraGridColumn38.Width = 8;
            ultraGridColumn39.Header.VisiblePosition = 8;
            ultraGridColumn39.Hidden = true;
            ultraGridColumn39.Width = 8;
            ultraGridColumn40.Header.VisiblePosition = 9;
            ultraGridColumn40.Hidden = true;
            ultraGridColumn40.Width = 8;
            ultraGridColumn41.Header.VisiblePosition = 10;
            ultraGridColumn41.Hidden = true;
            ultraGridColumn41.Width = 8;
            ultraGridColumn42.Header.VisiblePosition = 11;
            ultraGridColumn42.Hidden = true;
            ultraGridColumn42.Width = 17;
            ultraGridColumn43.Header.VisiblePosition = 12;
            ultraGridColumn43.Hidden = true;
            ultraGridColumn43.Width = 8;
            ultraGridColumn44.Header.VisiblePosition = 13;
            ultraGridColumn44.Hidden = true;
            ultraGridColumn44.Width = 13;
            ultraGridColumn45.Header.VisiblePosition = 14;
            ultraGridColumn45.Hidden = true;
            ultraGridColumn45.Width = 15;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34,
            ultraGridColumn35,
            ultraGridColumn36,
            ultraGridColumn37,
            ultraGridColumn38,
            ultraGridColumn39,
            ultraGridColumn40,
            ultraGridColumn41,
            ultraGridColumn42,
            ultraGridColumn43,
            ultraGridColumn44,
            ultraGridColumn45});
            this.puntosDeVentaUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.puntosDeVentaUltraCombo.DisplayMember = "Prefijo";
            this.puntosDeVentaUltraCombo.DropDownWidth = 0;
            this.puntosDeVentaUltraCombo.LimitToList = true;
            this.puntosDeVentaUltraCombo.Location = new System.Drawing.Point(152, 9);
            this.puntosDeVentaUltraCombo.Name = "puntosDeVentaUltraCombo";
            this.puntosDeVentaUltraCombo.Size = new System.Drawing.Size(63, 22);
            this.puntosDeVentaUltraCombo.TabIndex = 2;
            this.puntosDeVentaUltraCombo.ValueMember = "Prefijo";
            this.puntosDeVentaUltraCombo.ValueChanged += new System.EventHandler(this.PuntosDeVentaUltraComboValueChanged);
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
            // ultraLabel1
            // 
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(110, 13);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(36, 14);
            this.ultraLabel1.TabIndex = 3;
            this.ultraLabel1.Text = "Prefijo";
            // 
            // ultraMaskedEditDesde
            // 
            this.ultraMaskedEditDesde.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEditDesde.InputMask = "########";
            this.ultraMaskedEditDesde.Location = new System.Drawing.Point(288, 10);
            this.ultraMaskedEditDesde.Name = "ultraMaskedEditDesde";
            this.ultraMaskedEditDesde.Nullable = false;
            this.ultraMaskedEditDesde.Size = new System.Drawing.Size(56, 20);
            this.ultraMaskedEditDesde.TabIndex = 16;
            this.ultraMaskedEditDesde.Text = "00000000";
            this.toolTip1.SetToolTip(this.ultraMaskedEditDesde, "Se puede modificar");
            // 
            // ultraLabelDesde
            // 
            appearance15.TextHAlignAsString = "Right";
            this.ultraLabelDesde.Appearance = appearance15;
            this.ultraLabelDesde.AutoSize = true;
            this.ultraLabelDesde.Location = new System.Drawing.Point(230, 13);
            this.ultraLabelDesde.Name = "ultraLabelDesde";
            this.ultraLabelDesde.Size = new System.Drawing.Size(52, 14);
            this.ultraLabelDesde.TabIndex = 15;
            this.ultraLabelDesde.Text = "Desde Nº";
            // 
            // ultraDataSourceCantidad
            // 
            this.ultraDataSourceCantidad.Band.AllowAdd = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDataSourceCantidad.Band.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            ultraDataColumn1.DataType = typeof(int);
            this.ultraDataSourceCantidad.Band.Columns.AddRange(new object[] {
            ultraDataColumn1});
            this.ultraDataSourceCantidad.Rows.AddRange(new object[] {
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Cantidad")),
                        ((object)(5))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Cantidad")),
                        ((object)(20))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Cantidad")),
                        ((object)(100))})});
            // 
            // ultraComboCantidad
            // 
            this.ultraComboCantidad.DataSource = this.ultraDataSourceCantidad;
            this.ultraComboCantidad.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn123.Header.VisiblePosition = 0;
            ultraGridColumn123.Width = 31;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn123});
            this.ultraComboCantidad.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraComboCantidad.DisplayMember = "Cantidad";
            this.ultraComboCantidad.DropDownWidth = 0;
            this.ultraComboCantidad.LimitToList = true;
            this.ultraComboCantidad.Location = new System.Drawing.Point(431, 9);
            this.ultraComboCantidad.Name = "ultraComboCantidad";
            this.ultraComboCantidad.Size = new System.Drawing.Size(50, 22);
            this.ultraComboCantidad.TabIndex = 17;
            this.ultraComboCantidad.ValueMember = "Cantidad";
            this.ultraComboCantidad.ValueChanged += new System.EventHandler(this.UltraComboCantidadValueChanged);
            // 
            // ultraLabel2
            // 
            appearance25.TextHAlignAsString = "Right";
            this.ultraLabel2.Appearance = appearance25;
            this.ultraLabel2.AutoSize = true;
            this.ultraLabel2.Location = new System.Drawing.Point(375, 13);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(50, 14);
            this.ultraLabel2.TabIndex = 18;
            this.ultraLabel2.Text = "Cantidad";
            // 
            // ultraButtonBuscar
            // 
            this.ultraButtonBuscar.Enabled = false;
            this.ultraButtonBuscar.Location = new System.Drawing.Point(505, 8);
            this.ultraButtonBuscar.Name = "ultraButtonBuscar";
            this.ultraButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonBuscar.TabIndex = 19;
            this.ultraButtonBuscar.Text = "Buscar";
            this.ultraButtonBuscar.Click += new System.EventHandler(this.UltraButtonBuscarClick);
            // 
            // ultraDropDownTiposDeComprobante
            // 
            this.ultraDropDownTiposDeComprobante.DataSource = this.tiposDeComprobanteBindingSource;
            appearance32.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Appearance = appearance32;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn124.Header.VisiblePosition = 0;
            ultraGridColumn124.Hidden = true;
            ultraGridColumn124.Width = 21;
            ultraGridColumn125.Header.VisiblePosition = 1;
            ultraGridColumn125.Width = 219;
            ultraGridColumn126.Header.VisiblePosition = 2;
            ultraGridColumn126.Hidden = true;
            ultraGridColumn126.Width = 20;
            ultraGridColumn127.Header.VisiblePosition = 3;
            ultraGridColumn127.Hidden = true;
            ultraGridColumn127.Width = 19;
            ultraGridColumn128.Header.VisiblePosition = 4;
            ultraGridColumn128.Hidden = true;
            ultraGridColumn128.Width = 18;
            ultraGridColumn129.Header.VisiblePosition = 5;
            ultraGridColumn129.Hidden = true;
            ultraGridColumn129.Width = 31;
            ultraGridColumn130.Header.VisiblePosition = 6;
            ultraGridColumn130.Hidden = true;
            ultraGridColumn130.Width = 45;
            ultraGridColumn131.Header.VisiblePosition = 7;
            ultraGridColumn131.Hidden = true;
            ultraGridColumn131.Width = 219;
            ultraGridColumn132.Header.VisiblePosition = 8;
            ultraGridColumn132.Hidden = true;
            ultraGridColumn132.Width = 69;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn124,
            ultraGridColumn125,
            ultraGridColumn126,
            ultraGridColumn127,
            ultraGridColumn128,
            ultraGridColumn129,
            ultraGridColumn130,
            ultraGridColumn131,
            ultraGridColumn132});
            this.ultraDropDownTiposDeComprobante.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.ultraDropDownTiposDeComprobante.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.MaxBandDepth = 5;
            appearance33.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.ActiveCellAppearance = appearance33;
            appearance34.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance34.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance34.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.ActiveRowAppearance = appearance34;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance35.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.CardAreaAppearance = appearance35;
            appearance36.BackColor = System.Drawing.SystemColors.Control;
            appearance36.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.CellAppearance = appearance36;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance37.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance37.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance37.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.HeaderAppearance = appearance37;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance38.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.RowSelectorAppearance = appearance38;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.SelectedCellAppearance = appearance39;
            appearance40.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance40.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.SelectedRowAppearance = appearance40;
            appearance41.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance41.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance41;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeComprobante.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeComprobante.Location = new System.Drawing.Point(210, 207);
            this.ultraDropDownTiposDeComprobante.Name = "ultraDropDownTiposDeComprobante";
            this.ultraDropDownTiposDeComprobante.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeComprobante.TabIndex = 32;
            this.ultraDropDownTiposDeComprobante.ValueMember = "idTipoDeComprobante";
            this.ultraDropDownTiposDeComprobante.Visible = false;
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
            // ultraDataSourceSeries
            // 
            this.ultraDataSourceSeries.Band.Columns.AddRange(new object[] {
            ultraDataColumn2});
            this.ultraDataSourceSeries.Rows.AddRange(new object[] {
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Serie")),
                        ((object)("A"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Serie")),
                        ((object)("B"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Serie")),
                        ((object)("M"))})});
            // 
            // ultraLabel3
            // 
            appearance3.TextHAlignAsString = "Right";
            this.ultraLabel3.Appearance = appearance3;
            this.ultraLabel3.AutoSize = true;
            this.ultraLabel3.Location = new System.Drawing.Point(9, 13);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(31, 14);
            this.ultraLabel3.TabIndex = 34;
            this.ultraLabel3.Text = "Serie";
            // 
            // tiposDeComprobanteUltraCombo
            // 
            this.tiposDeComprobanteUltraCombo.AllowNull = Infragistics.Win.DefaultableBoolean.True;
            this.tiposDeComprobanteUltraCombo.DataSource = this.ultraDataSourceSeries;
            this.tiposDeComprobanteUltraCombo.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand6.ColHeadersVisible = false;
            ultraGridColumn133.Header.VisiblePosition = 0;
            ultraGridColumn133.Width = 27;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn133});
            this.tiposDeComprobanteUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.tiposDeComprobanteUltraCombo.DisplayMember = "Serie";
            this.tiposDeComprobanteUltraCombo.DropDownWidth = 0;
            this.tiposDeComprobanteUltraCombo.Location = new System.Drawing.Point(46, 9);
            this.tiposDeComprobanteUltraCombo.Name = "tiposDeComprobanteUltraCombo";
            this.tiposDeComprobanteUltraCombo.Size = new System.Drawing.Size(46, 22);
            this.tiposDeComprobanteUltraCombo.TabIndex = 33;
            this.tiposDeComprobanteUltraCombo.ValueMember = "Serie";
            this.tiposDeComprobanteUltraCombo.ValueChanged += new System.EventHandler(this.TiposDeComprobanteUltraComboValueChanged);
            // 
            // ultraDropDownPrefijos
            // 
            this.ultraDropDownPrefijos.DataSource = this.puntosDeVentaBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPrefijos.DisplayLayout.Appearance = appearance1;
            this.ultraDropDownPrefijos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand7.ColHeadersVisible = false;
            ultraGridColumn134.Header.VisiblePosition = 0;
            ultraGridColumn134.Hidden = true;
            ultraGridColumn134.Width = 25;
            ultraGridColumn135.Header.VisiblePosition = 1;
            ultraGridColumn135.Width = 219;
            ultraGridColumn136.Header.VisiblePosition = 2;
            ultraGridColumn136.Hidden = true;
            ultraGridColumn136.Width = 28;
            ultraGridColumn137.Header.VisiblePosition = 3;
            ultraGridColumn137.Hidden = true;
            ultraGridColumn137.Width = 38;
            ultraGridColumn138.Header.VisiblePosition = 4;
            ultraGridColumn138.Hidden = true;
            ultraGridColumn138.Width = 40;
            ultraGridColumn139.Header.VisiblePosition = 5;
            ultraGridColumn139.Hidden = true;
            ultraGridColumn139.Width = 40;
            ultraGridColumn140.Header.VisiblePosition = 6;
            ultraGridColumn140.Hidden = true;
            ultraGridColumn140.Width = 20;
            ultraGridColumn141.Header.VisiblePosition = 7;
            ultraGridColumn141.Hidden = true;
            ultraGridColumn141.Width = 39;
            ultraGridColumn142.Header.VisiblePosition = 8;
            ultraGridColumn142.Hidden = true;
            ultraGridColumn142.Width = 39;
            ultraGridColumn143.Header.VisiblePosition = 9;
            ultraGridColumn143.Hidden = true;
            ultraGridColumn143.Width = 39;
            ultraGridColumn144.Header.VisiblePosition = 10;
            ultraGridColumn144.Hidden = true;
            ultraGridColumn144.Width = 39;
            ultraGridColumn145.Header.VisiblePosition = 11;
            ultraGridColumn145.Hidden = true;
            ultraGridColumn145.Width = 17;
            ultraGridColumn146.Header.VisiblePosition = 12;
            ultraGridColumn146.Hidden = true;
            ultraGridColumn147.Header.VisiblePosition = 13;
            ultraGridColumn147.Hidden = true;
            ultraGridColumn148.Header.VisiblePosition = 14;
            ultraGridColumn148.Hidden = true;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn134,
            ultraGridColumn135,
            ultraGridColumn136,
            ultraGridColumn137,
            ultraGridColumn138,
            ultraGridColumn139,
            ultraGridColumn140,
            ultraGridColumn141,
            ultraGridColumn142,
            ultraGridColumn143,
            ultraGridColumn144,
            ultraGridColumn145,
            ultraGridColumn146,
            ultraGridColumn147,
            ultraGridColumn148});
            ultraGridBand7.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            this.ultraDropDownPrefijos.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.ultraDropDownPrefijos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPrefijos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPrefijos.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPrefijos.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance27.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance27.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance27.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPrefijos.DisplayLayout.Override.ActiveRowAppearance = appearance27;
            this.ultraDropDownPrefijos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPrefijos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPrefijos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrefijos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPrefijos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrefijos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPrefijos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPrefijos.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrefijos.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraDropDownPrefijos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPrefijos.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ultraDropDownPrefijos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPrefijos.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ultraDropDownPrefijos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPrefijos.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrefijos.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPrefijos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ultraDropDownPrefijos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPrefijos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPrefijos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPrefijos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPrefijos.DisplayMember = "Prefijo";
            this.ultraDropDownPrefijos.Location = new System.Drawing.Point(210, 247);
            this.ultraDropDownPrefijos.Name = "ultraDropDownPrefijos";
            this.ultraDropDownPrefijos.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownPrefijos.TabIndex = 35;
            this.ultraDropDownPrefijos.ValueMember = "Prefijo";
            this.ultraDropDownPrefijos.Visible = false;
            this.ultraDropDownPrefijos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownPrefijos_BeforeDropDown);
            // 
            // dsFacturasSinCAE
            // 
            this.dsFacturasSinCAE.DataSetName = "DsFacturasSinCAE";
            this.dsFacturasSinCAE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormCambiarNumeroFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(996, 470);
            this.Controls.Add(this.comprobantesUltraGrid);
            this.Controls.Add(this.ultraDropDownPrefijos);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.tiposDeComprobanteUltraCombo);
            this.Controls.Add(this.ultraButtonBuscar);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraComboCantidad);
            this.Controls.Add(this.ultraMaskedEditDesde);
            this.Controls.Add(this.ultraLabelDesde);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.puntosDeVentaUltraCombo);
            this.Controls.Add(this.ultraDropDownTiposDeComprobante);
            this.Name = "FormCambiarNumeroFacturas";
            this.Text = "Cambiar el número a Facturas, Notas a Crédito y de Débito";
            this.Load += new System.EventHandler(this.FormCambiarNumeroFacturasLoad);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeComprobante, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.puntosDeVentaUltraCombo, 0);
            this.Controls.SetChildIndex(this.ultraLabel1, 0);
            this.Controls.SetChildIndex(this.ultraLabelDesde, 0);
            this.Controls.SetChildIndex(this.ultraMaskedEditDesde, 0);
            this.Controls.SetChildIndex(this.ultraComboCantidad, 0);
            this.Controls.SetChildIndex(this.ultraLabel2, 0);
            this.Controls.SetChildIndex(this.ultraButtonBuscar, 0);
            this.Controls.SetChildIndex(this.tiposDeComprobanteUltraCombo, 0);
            this.Controls.SetChildIndex(this.ultraLabel3, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPrefijos, 0);
            this.Controls.SetChildIndex(this.comprobantesUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprobantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaUltraCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntosDeVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteUltraCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrefijos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasSinCAE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WS.DsComprobantes dsComprobantes;
        private System.Windows.Forms.BindingSource comprobantesBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid comprobantesUltraGrid;
        private WS.DsPuntosDeVenta dsPuntosDeVenta;
        private System.Windows.Forms.BindingSource puntosDeVentaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraCombo puntosDeVentaUltraCombo;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEditDesde;
        private Infragistics.Win.Misc.UltraLabel ultraLabelDesde;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceCantidad;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboCantidad;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraButton ultraButtonBuscar;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeComprobante;
        private System.Windows.Forms.BindingSource tiposDeComprobanteBindingSource;
        private WS.DsTiposDeComprobante dsTiposDeComprobante;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceSeries;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.UltraWinGrid.UltraCombo tiposDeComprobanteUltraCombo;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPrefijos;
        private DsFacturasSinCAE dsFacturasSinCAE;
    }
}

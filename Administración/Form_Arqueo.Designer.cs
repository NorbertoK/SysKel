using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    partial class FormArqueo
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Arqueos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idArqueo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobrador", -1, "ultraDropDownCobradores", 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo");
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CierreDelPeriodo");
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Total");
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Faltante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_ComprobantesArqueos_Arqueos");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_ComprobantesArqueos_Arqueos", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobanteArqueo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idArqueo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobante", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Faltante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDevolucionCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Mensaje", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe", 1);
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings1 = new Infragistics.Win.UltraWinGrid.SummarySettings("TotalComprobantes", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Importe", 1, false, "FK_ComprobantesArqueos_Arqueos", 1, Infragistics.Win.UltraWinGrid.SummaryPosition.Right, "Importe", 1, false);
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.arqueosUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraCalcManager1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.arqueosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsArqueos = new Administración.WS.DsArqueos();
            this.ultraDropDownCobradores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.cobradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmpleadosLista1 = new Administración.WS.DsEmpleadosLista();
            this.ultraCurrencyEditorTotalComprobantes = new Infragistics.Win.UltraWinEditors.UltraCurrencyEditor();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arqueosUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arqueosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArqueos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCobradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditorTotalComprobantes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(313, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(232, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 478);
            this.panel1.Size = new System.Drawing.Size(403, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(232, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // arqueosUltraGrid
            // 
            this.arqueosUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arqueosUltraGrid.CalcManager = this.ultraCalcManager1;
            this.arqueosUltraGrid.DataSource = this.arqueosBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.arqueosUltraGrid.DisplayLayout.Appearance = appearance11;
            this.arqueosUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn8.Header.VisiblePosition = 0;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn9.Header.Caption = "Cobrador";
            ultraGridColumn9.Header.VisiblePosition = 1;
            ultraGridColumn9.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn9.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(103, 0);
            ultraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(103, 0);
            ultraGridColumn9.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn9.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn9.Width = 110;
            ultraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance12.TextHAlignAsString = "Center";
            ultraGridColumn10.CellAppearance = appearance12;
            ultraGridColumn10.Header.VisiblePosition = 2;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn10.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn10.MaskInput = "dd/mm/yyyy";
            ultraGridColumn10.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn10.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(88, 0);
            ultraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(88, 0);
            ultraGridColumn10.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn10.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn10.Width = 54;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance13.TextHAlignAsString = "Center";
            ultraGridColumn11.CellAppearance = appearance13;
            ultraGridColumn11.Header.Caption = "Período";
            ultraGridColumn11.Header.VisiblePosition = 3;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn11.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn11.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn11.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn11.MaskInput = "##/####";
            ultraGridColumn11.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn11.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(83, 0);
            ultraGridColumn11.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(83, 0);
            ultraGridColumn11.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn11.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn11.Width = 48;
            ultraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance14.TextHAlignAsString = "Center";
            ultraGridColumn12.CellAppearance = appearance14;
            ultraGridColumn12.Header.Caption = "Cierra Período";
            ultraGridColumn12.Header.VisiblePosition = 4;
            ultraGridColumn12.Hidden = true;
            ultraGridColumn12.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn12.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(71, 0);
            ultraGridColumn12.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(71, 0);
            ultraGridColumn12.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn12.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn12.Width = 79;
            ultraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            appearance15.FontData.BoldAsString = "True";
            appearance15.TextHAlignAsString = "Right";
            ultraGridColumn13.CellAppearance = appearance15;
            ultraGridColumn13.Header.Caption = "Total a Rendir";
            ultraGridColumn13.Header.VisiblePosition = 5;
            ultraGridColumn13.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn13.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn13.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn13.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(60, 0);
            ultraGridColumn13.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(60, 0);
            ultraGridColumn13.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn13.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn14.DefaultCellValue = "0";
            ultraGridColumn14.Header.VisiblePosition = 6;
            ultraGridColumn14.Hidden = true;
            ultraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn15.Header.VisiblePosition = 7;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15});
            ultraGridBand2.MaxRows = 1;
            ultraGridBand2.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn16.Header.VisiblePosition = 0;
            ultraGridColumn16.Hidden = true;
            ultraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn17.Header.VisiblePosition = 1;
            ultraGridColumn17.Hidden = true;
            ultraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance16.TextHAlignAsString = "Right";
            ultraGridColumn18.CellAppearance = appearance16;
            ultraGridColumn18.Header.Caption = "Comprobante";
            ultraGridColumn18.Header.VisiblePosition = 2;
            ultraGridColumn18.Width = 63;
            ultraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn19.Header.VisiblePosition = 3;
            ultraGridColumn19.Hidden = true;
            ultraGridColumn19.Width = 48;
            ultraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn20.Header.VisiblePosition = 4;
            ultraGridColumn20.Hidden = true;
            ultraGridColumn20.Width = 106;
            ultraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn21.Header.VisiblePosition = 5;
            ultraGridColumn21.Width = 191;
            ultraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance17.TextHAlignAsString = "Right";
            ultraGridColumn22.CellAppearance = appearance17;
            ultraGridColumn22.DataType = typeof(decimal);
            ultraGridColumn22.Header.VisiblePosition = 6;
            ultraGridColumn22.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn22.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn22.Width = 90;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22});
            ultraGridBand3.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance18.FontData.BoldAsString = "True";
            appearance18.TextHAlignAsString = "Right";
            ultraGridBand3.Override.SummaryValueAppearance = appearance18;
            summarySettings1.DisplayFormat = "Total: {0:c}";
            summarySettings1.GroupBySummaryValueAppearance = appearance19;
            ultraGridBand3.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings1});
            ultraGridBand3.SummaryFooterCaption = "";
            this.arqueosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.arqueosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.arqueosUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.arqueosUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.arqueosUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance20.BackColor = System.Drawing.SystemColors.Window;
            this.arqueosUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance20;
            appearance21.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance21.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance21.ForeColor = System.Drawing.SystemColors.WindowText;
            this.arqueosUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance21;
            this.arqueosUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.arqueosUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.arqueosUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.arqueosUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.arqueosUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.arqueosUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.arqueosUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance22.BackColor = System.Drawing.Color.Transparent;
            this.arqueosUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.Control;
            appearance23.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.arqueosUltraGrid.DisplayLayout.Override.CellAppearance = appearance23;
            this.arqueosUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance24.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance24.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance24.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.arqueosUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance24;
            this.arqueosUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance25.ForeColor = System.Drawing.Color.Red;
            this.arqueosUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance25;
            this.arqueosUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.arqueosUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance26;
            appearance27.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance27.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.arqueosUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance27;
            appearance28.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance28.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.arqueosUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance28;
            this.arqueosUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.arqueosUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.arqueosUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.arqueosUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.arqueosUltraGrid.Location = new System.Drawing.Point(0, 1);
            this.arqueosUltraGrid.Name = "arqueosUltraGrid";
            this.arqueosUltraGrid.Size = new System.Drawing.Size(403, 487);
            this.arqueosUltraGrid.TabIndex = 2;
            this.arqueosUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.ArqueosUltraGridInitializeRow);
            this.arqueosUltraGrid.AfterEnterEditMode += new System.EventHandler(this.arqueosUltraGrid_AfterEnterEditMode);
            this.arqueosUltraGrid.AfterRowExpanded += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.ArqueosUltraGridAfterRowExpanded);
            this.arqueosUltraGrid.BeforeCellDeactivate += new System.ComponentModel.CancelEventHandler(this.ArqueosUltraGridBeforeCellDeactivate);
            this.arqueosUltraGrid.SummaryValueChanged += new Infragistics.Win.UltraWinGrid.SummaryValueChangedEventHandler(this.ArqueosUltraGridSummaryValueChanged);
            this.arqueosUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.arqueosUltraGrid_KeyDown);
            // 
            // ultraCalcManager1
            // 
            this.ultraCalcManager1.ContainingControl = this;
            // 
            // arqueosBindingSource
            // 
            this.arqueosBindingSource.DataMember = "Arqueos";
            this.arqueosBindingSource.DataSource = this.dsArqueos;
            // 
            // dsArqueos
            // 
            this.dsArqueos.DataSetName = "DsArqueos";
            this.dsArqueos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownCobradores
            // 
            this.ultraDropDownCobradores.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCobradores.DataSource = this.cobradoresBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCobradores.DisplayLayout.Appearance = appearance1;
            this.ultraDropDownCobradores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Hidden = true;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn6.Header.VisiblePosition = 6;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn7.Header.VisiblePosition = 5;
            ultraGridColumn7.Hidden = true;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7});
            ultraGridBand1.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCobradores.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraDropDownCobradores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCobradores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCobradores.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCobradores.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCobradores.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCobradores.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCobradores.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraDropDownCobradores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCobradores.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ultraDropDownCobradores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCobradores.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ultraDropDownCobradores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCobradores.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCobradores.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCobradores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ultraDropDownCobradores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCobradores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCobradores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCobradores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCobradores.DisplayMember = "ApelNomb";
            this.ultraDropDownCobradores.DropDownWidth = 250;
            this.ultraDropDownCobradores.Location = new System.Drawing.Point(12, 412);
            this.ultraDropDownCobradores.Name = "ultraDropDownCobradores";
            this.ultraDropDownCobradores.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownCobradores.TabIndex = 21;
            this.ultraDropDownCobradores.ValueMember = "idEmpleado";
            this.ultraDropDownCobradores.Visible = false;
            this.ultraDropDownCobradores.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownCobradoresFilterRow);
            // 
            // cobradoresBindingSource
            // 
            this.cobradoresBindingSource.DataMember = "EmpleadosLista";
            this.cobradoresBindingSource.DataSource = this.dsEmpleadosLista1;
            // 
            // dsEmpleadosLista1
            // 
            this.dsEmpleadosLista1.DataSetName = "DsEmpleadosLista";
            this.dsEmpleadosLista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraCurrencyEditorTotalComprobantes
            // 
            this.ultraCurrencyEditorTotalComprobantes.Location = new System.Drawing.Point(139, 305);
            this.ultraCurrencyEditorTotalComprobantes.Name = "ultraCurrencyEditorTotalComprobantes";
            this.ultraCurrencyEditorTotalComprobantes.Size = new System.Drawing.Size(100, 21);
            this.ultraCurrencyEditorTotalComprobantes.TabIndex = 23;
            this.ultraCurrencyEditorTotalComprobantes.Visible = false;
            // 
            // FormArqueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(402, 526);
            this.Controls.Add(this.arqueosUltraGrid);
            this.Controls.Add(this.ultraCurrencyEditorTotalComprobantes);
            this.Controls.Add(this.ultraDropDownCobradores);
            this.Name = "FormArqueo";
            this.Text = "Arqueo";
            this.Activated += new System.EventHandler(this.FormArqueoActivated);
            this.Load += new System.EventHandler(this.FormArqueoLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCobradores, 0);
            this.Controls.SetChildIndex(this.ultraCurrencyEditorTotalComprobantes, 0);
            this.Controls.SetChildIndex(this.arqueosUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.arqueosUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arqueosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArqueos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCobradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditorTotalComprobantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WS.DsArqueos dsArqueos;
        private System.Windows.Forms.BindingSource arqueosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid arqueosUltraGrid;
        private System.Windows.Forms.BindingSource cobradoresBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCobradores;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalcManager1;
        private Infragistics.Win.UltraWinEditors.UltraCurrencyEditor ultraCurrencyEditorTotalComprobantes;
        private WS.DsEmpleadosLista dsEmpleadosLista1;
    }
}

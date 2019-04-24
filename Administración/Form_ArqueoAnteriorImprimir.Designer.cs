using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    partial class FormArqueoAnteriorImprimir
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
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Arqueos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idArqueo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobrador", -1, "ultraDropDownCobradores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CierreDelPeriodo");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Total");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Faltante");
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_ComprobantesArqueos_Arqueos");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_ComprobantesArqueos_Arqueos", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobanteArqueo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idArqueo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Faltante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDevolucionCobranza");
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
            this.dsArqueos = new Administración.WS.DsArqueos();
            this.arqueosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arqueosUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraNumericEditor1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.cobradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmpleadosLista1 = new Administración.WS.DsEmpleadosLista();
            this.ultraDropDownCobradores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsArqueos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arqueosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arqueosUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCobradores)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(390, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(309, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 423);
            this.panel1.Size = new System.Drawing.Size(480, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(309, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsArqueos
            // 
            this.dsArqueos.DataSetName = "DsArqueos";
            this.dsArqueos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arqueosBindingSource
            // 
            this.arqueosBindingSource.DataMember = "Arqueos";
            this.arqueosBindingSource.DataSource = this.dsArqueos;
            // 
            // arqueosUltraGrid
            // 
            this.arqueosUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arqueosUltraGrid.DataSource = this.arqueosBindingSource;
            appearance51.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance51.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.arqueosUltraGrid.DisplayLayout.Appearance = appearance51;
            this.arqueosUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 45;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.Header.Caption = "Cobrador";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 124;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance1.TextHAlignAsString = "Center";
            ultraGridColumn3.CellAppearance = appearance1;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 61;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance2.TextHAlignAsString = "Center";
            ultraGridColumn4.CellAppearance = appearance2;
            ultraGridColumn4.Header.Caption = "Período";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Width = 61;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance3.TextHAlignAsString = "Center";
            ultraGridColumn5.CellAppearance = appearance3;
            ultraGridColumn5.Header.Caption = "Cierre";
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Width = 45;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance4.TextHAlignAsString = "Right";
            ultraGridColumn6.CellAppearance = appearance4;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn6.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn6.Width = 81;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance5.TextHAlignAsString = "Right";
            ultraGridColumn7.CellAppearance = appearance5;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn7.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn7.Width = 87;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8});
            ultraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn9.Header.VisiblePosition = 0;
            ultraGridColumn9.Width = 121;
            ultraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn10.Header.VisiblePosition = 1;
            ultraGridColumn10.Width = 59;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn11.Header.VisiblePosition = 2;
            ultraGridColumn11.Width = 90;
            ultraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn12.Header.VisiblePosition = 3;
            ultraGridColumn12.Width = 55;
            ultraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn13.Header.VisiblePosition = 4;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13});
            ultraGridBand2.Hidden = true;
            this.arqueosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.arqueosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.arqueosUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.arqueosUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.arqueosUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance57.BackColor = System.Drawing.SystemColors.Window;
            this.arqueosUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance57;
            appearance58.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance58.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance58.ForeColor = System.Drawing.SystemColors.WindowText;
            this.arqueosUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance58;
            this.arqueosUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.arqueosUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.arqueosUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.arqueosUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.arqueosUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.arqueosUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.arqueosUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance59.BackColor = System.Drawing.Color.Transparent;
            this.arqueosUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance59;
            appearance60.BackColor = System.Drawing.SystemColors.Control;
            appearance60.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.arqueosUltraGrid.DisplayLayout.Override.CellAppearance = appearance60;
            this.arqueosUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance61.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance61.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance61.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance61.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.arqueosUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance61;
            this.arqueosUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance62.ForeColor = System.Drawing.Color.Red;
            this.arqueosUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance62;
            this.arqueosUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.arqueosUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance63;
            appearance64.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance64.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.arqueosUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance64;
            appearance65.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance65.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.arqueosUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance65;
            this.arqueosUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.arqueosUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.arqueosUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.arqueosUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.arqueosUltraGrid.Location = new System.Drawing.Point(0, -2);
            this.arqueosUltraGrid.Name = "arqueosUltraGrid";
            this.arqueosUltraGrid.Size = new System.Drawing.Size(480, 435);
            this.arqueosUltraGrid.TabIndex = 2;
            this.arqueosUltraGrid.AfterEnterEditMode += new System.EventHandler(this.arqueosUltraGrid_AfterEnterEditMode);
            this.arqueosUltraGrid.Click += new System.EventHandler(this.ArqueosUltraGridClick);
            this.arqueosUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.arqueosUltraGrid_KeyDown);
            // 
            // ultraNumericEditor1
            // 
            this.ultraNumericEditor1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.arqueosBindingSource, "idArqueo", true));
            this.ultraNumericEditor1.Location = new System.Drawing.Point(22, 87);
            this.ultraNumericEditor1.Name = "ultraNumericEditor1";
            this.ultraNumericEditor1.Size = new System.Drawing.Size(100, 21);
            this.ultraNumericEditor1.TabIndex = 3;
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
            // ultraDropDownCobradores
            // 
            this.ultraDropDownCobradores.DataSource = this.cobradoresBindingSource;
            appearance66.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance66.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCobradores.DisplayLayout.Appearance = appearance66;
            this.ultraDropDownCobradores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn14.Header.VisiblePosition = 0;
            ultraGridColumn14.Hidden = true;
            ultraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn15.Header.VisiblePosition = 1;
            ultraGridColumn15.Hidden = true;
            ultraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn16.Header.VisiblePosition = 2;
            ultraGridColumn16.Hidden = true;
            ultraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn17.Header.VisiblePosition = 3;
            ultraGridColumn17.Hidden = true;
            ultraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn18.Header.VisiblePosition = 4;
            ultraGridColumn19.Header.VisiblePosition = 6;
            ultraGridColumn19.Hidden = true;
            ultraGridColumn20.Header.VisiblePosition = 5;
            ultraGridColumn20.Hidden = true;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20});
            ultraGridBand3.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCobradores.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownCobradores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCobradores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCobradores.DisplayLayout.MaxBandDepth = 5;
            appearance67.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCobradores.DisplayLayout.Override.ActiveCellAppearance = appearance67;
            appearance68.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance68.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance68.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCobradores.DisplayLayout.Override.ActiveRowAppearance = appearance68;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance69.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCobradores.DisplayLayout.Override.CardAreaAppearance = appearance69;
            appearance70.BackColor = System.Drawing.SystemColors.Control;
            appearance70.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance70.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCobradores.DisplayLayout.Override.CellAppearance = appearance70;
            this.ultraDropDownCobradores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance71.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance71.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance71.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance71.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCobradores.DisplayLayout.Override.HeaderAppearance = appearance71;
            this.ultraDropDownCobradores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance72.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCobradores.DisplayLayout.Override.RowSelectorAppearance = appearance72;
            this.ultraDropDownCobradores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance73.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCobradores.DisplayLayout.Override.SelectedCellAppearance = appearance73;
            appearance74.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance74.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCobradores.DisplayLayout.Override.SelectedRowAppearance = appearance74;
            appearance75.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance75.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCobradores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance75;
            this.ultraDropDownCobradores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCobradores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCobradores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCobradores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCobradores.DisplayMember = "NombApel";
            this.ultraDropDownCobradores.DropDownWidth = 250;
            this.ultraDropDownCobradores.Location = new System.Drawing.Point(80, 180);
            this.ultraDropDownCobradores.Name = "ultraDropDownCobradores";
            this.ultraDropDownCobradores.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownCobradores.TabIndex = 22;
            this.ultraDropDownCobradores.ValueMember = "idEmpleado";
            this.ultraDropDownCobradores.Visible = false;
            this.ultraDropDownCobradores.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownCobradoresFilterRow);
            // 
            // FormArqueoAnteriorImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(479, 471);
            this.Controls.Add(this.arqueosUltraGrid);
            this.Controls.Add(this.ultraDropDownCobradores);
            this.Controls.Add(this.ultraNumericEditor1);
            this.Name = "FormArqueoAnteriorImprimir";
            this.Text = "Arqueos";
            this.Activated += new System.EventHandler(this.FormArqueoAnteriorImprimirActivated);
            this.Load += new System.EventHandler(this.FormArqueoAnteriorImprimirLoad);
            this.Controls.SetChildIndex(this.ultraNumericEditor1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCobradores, 0);
            this.Controls.SetChildIndex(this.arqueosUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsArqueos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arqueosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arqueosUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCobradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WS.DsArqueos dsArqueos;
        private System.Windows.Forms.BindingSource arqueosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid arqueosUltraGrid;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditor1;
        private System.Windows.Forms.BindingSource cobradoresBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCobradores;
        private WS.DsEmpleadosLista dsEmpleadosLista1;
    }
}

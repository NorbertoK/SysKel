namespace Dirección
{
    partial class FormReporteEstadisticaCantidadDeAfiliados
    {

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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Id");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Texto");
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Texto");
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Planes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PadronExterno");
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.ultraDateTimeEditorPeriodoDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraDateTimeEditorPeriodoHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraLabelPeriodoDesde = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelPeriodoHasta = new Infragistics.Win.Misc.UltraLabel();
            this.ultraComboModo = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.ultraDataSourceModo = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraLabelModo = new Infragistics.Win.Misc.UltraLabel();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPlanes = new Dirección.WS.DsPlanes();
            this.ultraComboPlanes = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.ultraLabelPlan = new Infragistics.Win.Misc.UltraLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodoDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodoHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboModo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceModo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(11, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 112);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(95, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ultraDateTimeEditorPeriodoDesde
            // 
            this.ultraDateTimeEditorPeriodoDesde.DateTime = new System.DateTime(2010, 1, 27, 0, 0, 0, 0);
            this.ultraDateTimeEditorPeriodoDesde.FormatString = "";
            this.ultraDateTimeEditorPeriodoDesde.Location = new System.Drawing.Point(95, 12);
            this.ultraDateTimeEditorPeriodoDesde.MaskInput = "{LOC}mm/yyyy";
            this.ultraDateTimeEditorPeriodoDesde.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.ultraDateTimeEditorPeriodoDesde.MinDate = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            this.ultraDateTimeEditorPeriodoDesde.Name = "ultraDateTimeEditorPeriodoDesde";
            this.ultraDateTimeEditorPeriodoDesde.Size = new System.Drawing.Size(77, 21);
            this.ultraDateTimeEditorPeriodoDesde.TabIndex = 12;
            this.ultraDateTimeEditorPeriodoDesde.Value = new System.DateTime(2010, 1, 27, 0, 0, 0, 0);
            // 
            // ultraDateTimeEditorPeriodoHasta
            // 
            this.ultraDateTimeEditorPeriodoHasta.DateTime = new System.DateTime(2010, 1, 27, 0, 0, 0, 0);
            this.ultraDateTimeEditorPeriodoHasta.FormatString = "";
            this.ultraDateTimeEditorPeriodoHasta.Location = new System.Drawing.Point(95, 39);
            this.ultraDateTimeEditorPeriodoHasta.MaskInput = "{LOC}mm/yyyy";
            this.ultraDateTimeEditorPeriodoHasta.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.ultraDateTimeEditorPeriodoHasta.MinDate = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            this.ultraDateTimeEditorPeriodoHasta.Name = "ultraDateTimeEditorPeriodoHasta";
            this.ultraDateTimeEditorPeriodoHasta.Size = new System.Drawing.Size(77, 21);
            this.ultraDateTimeEditorPeriodoHasta.TabIndex = 13;
            this.ultraDateTimeEditorPeriodoHasta.Value = new System.DateTime(2010, 1, 27, 0, 0, 0, 0);
            // 
            // ultraLabelPeriodoDesde
            // 
            appearance2.TextHAlignAsString = "Right";
            this.ultraLabelPeriodoDesde.Appearance = appearance2;
            this.ultraLabelPeriodoDesde.AutoSize = true;
            this.ultraLabelPeriodoDesde.Location = new System.Drawing.Point(10, 16);
            this.ultraLabelPeriodoDesde.Name = "ultraLabelPeriodoDesde";
            this.ultraLabelPeriodoDesde.Size = new System.Drawing.Size(79, 14);
            this.ultraLabelPeriodoDesde.TabIndex = 14;
            this.ultraLabelPeriodoDesde.Text = "Período Desde";
            // 
            // ultraLabelPeriodoHasta
            // 
            appearance31.TextHAlignAsString = "Right";
            this.ultraLabelPeriodoHasta.Appearance = appearance31;
            this.ultraLabelPeriodoHasta.AutoSize = true;
            this.ultraLabelPeriodoHasta.Location = new System.Drawing.Point(13, 43);
            this.ultraLabelPeriodoHasta.Name = "ultraLabelPeriodoHasta";
            this.ultraLabelPeriodoHasta.Size = new System.Drawing.Size(76, 14);
            this.ultraLabelPeriodoHasta.TabIndex = 15;
            this.ultraLabelPeriodoHasta.Text = "Período Hasta";
            // 
            // ultraComboModo
            // 
            this.ultraComboModo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ultraComboModo.DataSource = this.ultraDataSourceModo;
            appearance27.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance27.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboModo.DisplayLayout.Appearance = appearance27;
            this.ultraComboModo.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 565;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 125;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2});
            this.ultraComboModo.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraComboModo.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboModo.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance28.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance28.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance28.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboModo.DisplayLayout.GroupByBox.Appearance = appearance28;
            appearance29.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboModo.DisplayLayout.GroupByBox.BandLabelAppearance = appearance29;
            this.ultraComboModo.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboModo.DisplayLayout.GroupByBox.Hidden = true;
            appearance30.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance30.BackColor2 = System.Drawing.SystemColors.Control;
            appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance30.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboModo.DisplayLayout.GroupByBox.PromptAppearance = appearance30;
            this.ultraComboModo.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboModo.DisplayLayout.MaxBandDepth = 5;
            this.ultraComboModo.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraComboModo.DisplayLayout.MaxRowScrollRegions = 1;
            appearance15.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboModo.DisplayLayout.Override.ActiveCellAppearance = appearance15;
            appearance16.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance16.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboModo.DisplayLayout.Override.ActiveRowAppearance = appearance16;
            this.ultraComboModo.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ultraComboModo.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboModo.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboModo.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboModo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboModo.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboModo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboModo.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraComboModo.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance17.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboModo.DisplayLayout.Override.CardAreaAppearance = appearance17;
            appearance18.BackColor = System.Drawing.SystemColors.Control;
            appearance18.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboModo.DisplayLayout.Override.CellAppearance = appearance18;
            this.ultraComboModo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraComboModo.DisplayLayout.Override.CellPadding = 0;
            this.ultraComboModo.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance19.BackColor = System.Drawing.SystemColors.Control;
            appearance19.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance19.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance19.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboModo.DisplayLayout.Override.GroupByRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance20.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance20.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboModo.DisplayLayout.Override.HeaderAppearance = appearance20;
            this.ultraComboModo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraComboModo.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance21.BackColor = System.Drawing.SystemColors.Window;
            appearance21.BorderColor = System.Drawing.Color.Silver;
            this.ultraComboModo.DisplayLayout.Override.RowAppearance = appearance21;
            appearance22.ForeColor = System.Drawing.Color.Red;
            this.ultraComboModo.DisplayLayout.Override.RowSelectorAppearance = appearance22;
            this.ultraComboModo.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboModo.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboModo.DisplayLayout.Override.SelectedCellAppearance = appearance23;
            appearance24.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance24.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboModo.DisplayLayout.Override.SelectedRowAppearance = appearance24;
            appearance25.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraComboModo.DisplayLayout.Override.TemplateAddRowAppearance = appearance25;
            appearance26.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboModo.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance26;
            this.ultraComboModo.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboModo.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboModo.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraComboModo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraComboModo.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboModo.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboModo.DisplayMember = "Texto";
            this.ultraComboModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ultraComboModo.Location = new System.Drawing.Point(95, 66);
            this.ultraComboModo.Name = "ultraComboModo";
            this.ultraComboModo.Size = new System.Drawing.Size(144, 22);
            this.ultraComboModo.TabIndex = 16;
            this.ultraComboModo.ValueMember = "Id";
            this.ultraComboModo.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraComboModoRowSelected);
            // 
            // ultraDataSourceModo
            // 
            this.ultraDataSourceModo.AllowAdd = false;
            this.ultraDataSourceModo.AllowDelete = false;
            this.ultraDataSourceModo.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2});
            this.ultraDataSourceModo.Rows.AddRange(new object[] {
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("Todos")),
                        ((object)("Texto")),
                        ((object)("Todos los Afiliados"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("Propios")),
                        ((object)("Texto")),
                        ((object)("Afiliados Propios"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("Contrato")),
                        ((object)("Texto")),
                        ((object)("Afiliados por Contrato"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("UnPlan")),
                        ((object)("Texto")),
                        ((object)("Un Plan"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("Planes")),
                        ((object)("Texto")),
                        ((object)("Todos los Planes"))})});
            // 
            // ultraLabelModo
            // 
            appearance48.TextHAlignAsString = "Right";
            this.ultraLabelModo.Appearance = appearance48;
            this.ultraLabelModo.AutoSize = true;
            this.ultraLabelModo.Location = new System.Drawing.Point(56, 70);
            this.ultraLabelModo.Name = "ultraLabelModo";
            this.ultraLabelModo.Size = new System.Drawing.Size(33, 14);
            this.ultraLabelModo.TabIndex = 17;
            this.ultraLabelModo.Text = "Modo";
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
            // ultraComboPlanes
            // 
            this.ultraComboPlanes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ultraComboPlanes.DataSource = this.planesBindingSource;
            appearance44.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance44.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboPlanes.DisplayLayout.Appearance = appearance44;
            this.ultraComboPlanes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand2.ColHeadersVisible = false;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn3.Header.VisiblePosition = 0;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn3.Width = 174;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn4.Header.VisiblePosition = 1;
            ultraGridColumn4.Width = 125;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn5.Header.VisiblePosition = 2;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn5.Width = 187;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn6.Header.VisiblePosition = 3;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn6.Width = 258;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn7.Header.VisiblePosition = 4;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn7.Width = 342;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7});
            this.ultraComboPlanes.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraComboPlanes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboPlanes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance45.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance45.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboPlanes.DisplayLayout.GroupByBox.Appearance = appearance45;
            appearance46.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboPlanes.DisplayLayout.GroupByBox.BandLabelAppearance = appearance46;
            this.ultraComboPlanes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboPlanes.DisplayLayout.GroupByBox.Hidden = true;
            appearance47.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance47.BackColor2 = System.Drawing.SystemColors.Control;
            appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance47.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboPlanes.DisplayLayout.GroupByBox.PromptAppearance = appearance47;
            this.ultraComboPlanes.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboPlanes.DisplayLayout.MaxBandDepth = 5;
            this.ultraComboPlanes.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraComboPlanes.DisplayLayout.MaxRowScrollRegions = 1;
            appearance32.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboPlanes.DisplayLayout.Override.ActiveCellAppearance = appearance32;
            appearance33.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance33.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance33.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboPlanes.DisplayLayout.Override.ActiveRowAppearance = appearance33;
            this.ultraComboPlanes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ultraComboPlanes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboPlanes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboPlanes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboPlanes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboPlanes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboPlanes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboPlanes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraComboPlanes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance34.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboPlanes.DisplayLayout.Override.CardAreaAppearance = appearance34;
            appearance35.BackColor = System.Drawing.SystemColors.Control;
            appearance35.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboPlanes.DisplayLayout.Override.CellAppearance = appearance35;
            this.ultraComboPlanes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraComboPlanes.DisplayLayout.Override.CellPadding = 0;
            this.ultraComboPlanes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance36.BackColor = System.Drawing.SystemColors.Control;
            appearance36.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance36.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance36.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboPlanes.DisplayLayout.Override.GroupByRowAppearance = appearance36;
            appearance37.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance37.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance37.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboPlanes.DisplayLayout.Override.HeaderAppearance = appearance37;
            this.ultraComboPlanes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraComboPlanes.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance38.BackColor = System.Drawing.SystemColors.Window;
            appearance38.BorderColor = System.Drawing.Color.Silver;
            this.ultraComboPlanes.DisplayLayout.Override.RowAppearance = appearance38;
            appearance39.ForeColor = System.Drawing.Color.Red;
            this.ultraComboPlanes.DisplayLayout.Override.RowSelectorAppearance = appearance39;
            this.ultraComboPlanes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboPlanes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboPlanes.DisplayLayout.Override.SelectedCellAppearance = appearance40;
            appearance41.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance41.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboPlanes.DisplayLayout.Override.SelectedRowAppearance = appearance41;
            appearance42.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraComboPlanes.DisplayLayout.Override.TemplateAddRowAppearance = appearance42;
            appearance43.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance43.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboPlanes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance43;
            this.ultraComboPlanes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboPlanes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboPlanes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraComboPlanes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraComboPlanes.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboPlanes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboPlanes.DisplayMember = "Nombre";
            this.ultraComboPlanes.Enabled = false;
            this.ultraComboPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ultraComboPlanes.Location = new System.Drawing.Point(95, 94);
            this.ultraComboPlanes.Name = "ultraComboPlanes";
            this.ultraComboPlanes.Size = new System.Drawing.Size(144, 22);
            this.ultraComboPlanes.TabIndex = 18;
            this.ultraComboPlanes.ValueMember = "idPlan";
            this.ultraComboPlanes.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraComboPlanesRowSelected);
            // 
            // ultraLabelPlan
            // 
            appearance1.TextHAlignAsString = "Right";
            this.ultraLabelPlan.Appearance = appearance1;
            this.ultraLabelPlan.AutoSize = true;
            this.ultraLabelPlan.Enabled = false;
            this.ultraLabelPlan.Location = new System.Drawing.Point(62, 97);
            this.ultraLabelPlan.Name = "ultraLabelPlan";
            this.ultraLabelPlan.Size = new System.Drawing.Size(27, 14);
            this.ultraLabelPlan.TabIndex = 19;
            this.ultraLabelPlan.Text = "Plan";
            // 
            // FormReporteEstadisticaCantidadDeAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(265, 160);
            this.Controls.Add(this.ultraLabelPlan);
            this.Controls.Add(this.ultraComboPlanes);
            this.Controls.Add(this.ultraLabelModo);
            this.Controls.Add(this.ultraComboModo);
            this.Controls.Add(this.ultraLabelPeriodoHasta);
            this.Controls.Add(this.ultraLabelPeriodoDesde);
            this.Controls.Add(this.ultraDateTimeEditorPeriodoHasta);
            this.Controls.Add(this.ultraDateTimeEditorPeriodoDesde);
            this.MaximumSize = new System.Drawing.Size(273, 194);
            this.MinimumSize = new System.Drawing.Size(273, 194);
            this.Name = "FormReporteEstadisticaCantidadDeAfiliados";
            this.Text = "Estadística Cantidad de Afiliados";
            this.Load += new System.EventHandler(this.FormReporteEstadisticaCantidadDeAfiliadosLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDateTimeEditorPeriodoDesde, 0);
            this.Controls.SetChildIndex(this.ultraDateTimeEditorPeriodoHasta, 0);
            this.Controls.SetChildIndex(this.ultraLabelPeriodoDesde, 0);
            this.Controls.SetChildIndex(this.ultraLabelPeriodoHasta, 0);
            this.Controls.SetChildIndex(this.ultraComboModo, 0);
            this.Controls.SetChildIndex(this.ultraLabelModo, 0);
            this.Controls.SetChildIndex(this.ultraComboPlanes, 0);
            this.Controls.SetChildIndex(this.ultraLabelPlan, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodoDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodoHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboModo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceModo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorPeriodoDesde;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorPeriodoHasta;
        private Infragistics.Win.Misc.UltraLabel ultraLabelPeriodoDesde;
        private Infragistics.Win.Misc.UltraLabel ultraLabelPeriodoHasta;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboModo;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceModo;
        private System.ComponentModel.IContainer components;
        private Infragistics.Win.Misc.UltraLabel ultraLabelModo;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private Dirección.WS.DsPlanes dsPlanes;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboPlanes;
        private Infragistics.Win.Misc.UltraLabel ultraLabelPlan;
    }
}

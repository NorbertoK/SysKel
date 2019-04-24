using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    partial class FormABCMoviles
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Moviles", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMovil");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeMovil", -1, "ultraDropDownTiposDeMovil");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestador", -1, "ultraDropDownPrestadores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Prestadores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeMovil", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeMovil");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            this.dsMoviles = new Cabina.WS.DsMoviles();
            this.movilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movilesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDropDownPrestadores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.prestadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrestadores = new Cabina.WS.DsPrestadores();
            this.ultraDropDownTiposDeMovil = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeMovilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeMovil = new Cabina.WS.DsTiposDeMovil();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoviles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movilesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrestadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrestadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeMovilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeMovil)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(300, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(219, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Size = new System.Drawing.Size(390, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(138, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsMoviles
            // 
            this.dsMoviles.DataSetName = "DsMoviles";
            this.dsMoviles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movilesBindingSource
            // 
            this.movilesBindingSource.DataMember = "Moviles";
            this.movilesBindingSource.DataSource = this.dsMoviles;
            // 
            // movilesUltraGrid
            // 
            this.movilesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movilesUltraGrid.DataSource = this.movilesBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.movilesUltraGrid.DisplayLayout.Appearance = appearance1;
            this.movilesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 69;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.Header.VisiblePosition = 3;
            ultraGridColumn2.Width = 119;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn3.Header.Caption = "Tipo de Móvil";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn3.Width = 106;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn4.Header.Caption = "Prestador";
            ultraGridColumn4.Header.VisiblePosition = 1;
            ultraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn4.Width = 102;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn5.DefaultCellValue = "True";
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Width = 42;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5});
            this.movilesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.movilesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.movilesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.movilesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.movilesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.movilesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.movilesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.movilesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.movilesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.movilesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.movilesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.movilesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.movilesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.movilesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.movilesUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.movilesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.movilesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.movilesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.movilesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.movilesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.movilesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.movilesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.movilesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.movilesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.movilesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.movilesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.movilesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.movilesUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.movilesUltraGrid.Name = "movilesUltraGrid";
            this.movilesUltraGrid.Size = new System.Drawing.Size(390, 290);
            this.movilesUltraGrid.TabIndex = 2;
            this.movilesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.MovilesUltraGridAfterEnterEditMode);
            this.movilesUltraGrid.AfterRowsDeleted += new System.EventHandler(this.MovilesUltraGridAfterRowsDeleted);
            this.movilesUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.movilesUltraGrid_KeyDown);
            // 
            // ultraDropDownPrestadores
            // 
            this.ultraDropDownPrestadores.DataSource = this.prestadoresBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPrestadores.DisplayLayout.Appearance = appearance11;
            this.ultraDropDownPrestadores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn6.Header.VisiblePosition = 0;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn7.Header.VisiblePosition = 1;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn6,
            ultraGridColumn7});
            ultraGridBand2.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownPrestadores.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraDropDownPrestadores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPrestadores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPrestadores.DisplayLayout.MaxBandDepth = 5;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPrestadores.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPrestadores.DisplayLayout.Override.ActiveRowAppearance = appearance13;
            this.ultraDropDownPrestadores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPrestadores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPrestadores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrestadores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPrestadores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrestadores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPrestadores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPrestadores.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrestadores.DisplayLayout.Override.CellAppearance = appearance15;
            this.ultraDropDownPrestadores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPrestadores.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.ultraDropDownPrestadores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPrestadores.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraDropDownPrestadores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPrestadores.DisplayLayout.Override.SelectedCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrestadores.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPrestadores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance20;
            this.ultraDropDownPrestadores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPrestadores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPrestadores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPrestadores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPrestadores.DisplayMember = "Nombre";
            this.ultraDropDownPrestadores.DropDownWidth = 250;
            this.ultraDropDownPrestadores.Location = new System.Drawing.Point(12, 99);
            this.ultraDropDownPrestadores.Name = "ultraDropDownPrestadores";
            this.ultraDropDownPrestadores.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownPrestadores.TabIndex = 12;
            this.ultraDropDownPrestadores.ValueMember = "idPrestador";
            this.ultraDropDownPrestadores.Visible = false;
            // 
            // prestadoresBindingSource
            // 
            this.prestadoresBindingSource.DataMember = "Prestadores";
            this.prestadoresBindingSource.DataSource = this.dsPrestadores;
            // 
            // dsPrestadores
            // 
            this.dsPrestadores.DataSetName = "DsPrestadores";
            this.dsPrestadores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTiposDeMovil
            // 
            this.ultraDropDownTiposDeMovil.DataSource = this.tiposDeMovilBindingSource;
            appearance21.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Appearance = appearance21;
            this.ultraDropDownTiposDeMovil.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn8.Header.VisiblePosition = 0;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn9.Header.VisiblePosition = 1;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn8,
            ultraGridColumn9});
            ultraGridBand3.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeMovil.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownTiposDeMovil.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeMovil.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeMovil.DisplayLayout.MaxBandDepth = 5;
            appearance22.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.ActiveCellAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance23.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance23.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.ActiveRowAppearance = appearance23;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance24.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.CardAreaAppearance = appearance24;
            appearance25.BackColor = System.Drawing.SystemColors.Control;
            appearance25.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.CellAppearance = appearance25;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance26.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance26.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance26.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.HeaderAppearance = appearance26;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance27.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.RowSelectorAppearance = appearance27;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.SelectedCellAppearance = appearance28;
            appearance29.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance29.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.SelectedRowAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeMovil.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance30;
            this.ultraDropDownTiposDeMovil.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeMovil.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeMovil.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeMovil.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeMovil.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeMovil.DropDownWidth = 250;
            this.ultraDropDownTiposDeMovil.Location = new System.Drawing.Point(12, 138);
            this.ultraDropDownTiposDeMovil.Name = "ultraDropDownTiposDeMovil";
            this.ultraDropDownTiposDeMovil.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownTiposDeMovil.TabIndex = 13;
            this.ultraDropDownTiposDeMovil.ValueMember = "idTipoDeMovil";
            this.ultraDropDownTiposDeMovil.Visible = false;
            // 
            // tiposDeMovilBindingSource
            // 
            this.tiposDeMovilBindingSource.DataMember = "TiposDeMovil";
            this.tiposDeMovilBindingSource.DataSource = this.dsTiposDeMovil;
            // 
            // dsTiposDeMovil
            // 
            this.dsTiposDeMovil.DataSetName = "DsTiposDeMovil";
            this.dsTiposDeMovil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormABCMoviles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(389, 328);
            this.Controls.Add(this.movilesUltraGrid);
            this.Controls.Add(this.ultraDropDownTiposDeMovil);
            this.Controls.Add(this.ultraDropDownPrestadores);
            this.Name = "FormABCMoviles";
            this.Text = "Móviles";
            this.Activated += new System.EventHandler(this.FormABCMovilesActivated);
            this.Load += new System.EventHandler(this.FormABCMovilesLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPrestadores, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeMovil, 0);
            this.Controls.SetChildIndex(this.movilesUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsMoviles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movilesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrestadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrestadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeMovilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeMovil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsMoviles dsMoviles;
        private System.Windows.Forms.BindingSource movilesBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid movilesUltraGrid;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPrestadores;
        private System.Windows.Forms.BindingSource prestadoresBindingSource;
        private WS.DsPrestadores dsPrestadores;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeMovil;
        private System.Windows.Forms.BindingSource tiposDeMovilBindingSource;
        private WS.DsTiposDeMovil dsTiposDeMovil;
    }
}

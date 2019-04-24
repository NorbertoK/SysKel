using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    partial class FormABCAutorizacionesDelPuesto
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("AutorizacionesDelPuesto", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAutorizacionDelPuesto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAutorizacion", -1, "ultraDropDownAutorizaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPuesto", -1, "ultraDropDownPuestos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeAutorizacion", -1, "ultraDropDownTiposDeAutorizacion");
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Puestos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPuesto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeAutorizacion", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeAutorizacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Autorizaciones", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAutorizacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeAutorizacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo");
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            this.dsAutorizacionesDelPuesto = new Administración.WS.DsAutorizacionesDelPuesto();
            this.autorizacionesDelPuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorizacionesDelPuestoUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDropDownPuestos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.puestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPuestos = new Administración.WS.DsPuestos();
            this.ultraDropDownTiposDeAutorizacion = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeAutorizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeAutorizacion = new Administración.WS.DsTiposDeAutorizacion();
            this.ultraDropDownAutorizaciones = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.autorizacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAutorizaciones = new Administración.WS.DsAutorizaciones();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutorizacionesDelPuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesDelPuestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesDelPuestoUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeAutorizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeAutorizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeAutorizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownAutorizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutorizaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(725, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(644, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 499);
            this.panel1.Size = new System.Drawing.Size(815, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(563, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsAutorizacionesDelPuesto
            // 
            this.dsAutorizacionesDelPuesto.DataSetName = "DsAutorizacionesDelPuesto";
            this.dsAutorizacionesDelPuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autorizacionesDelPuestoBindingSource
            // 
            this.autorizacionesDelPuestoBindingSource.DataMember = "AutorizacionesDelPuesto";
            this.autorizacionesDelPuestoBindingSource.DataSource = this.dsAutorizacionesDelPuesto;
            // 
            // autorizacionesDelPuestoUltraGrid
            // 
            this.autorizacionesDelPuestoUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autorizacionesDelPuestoUltraGrid.DataSource = this.autorizacionesDelPuestoBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Appearance = appearance1;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn2.Header.Caption = "Autorización";
            ultraGridColumn2.Header.VisiblePosition = 3;
            ultraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn2.Width = 483;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn3.Header.Caption = "Puesto";
            ultraGridColumn3.Header.VisiblePosition = 1;
            ultraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn3.Width = 151;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn4.Header.Caption = "Tipo de Autorización";
            ultraGridColumn4.Header.VisiblePosition = 2;
            ultraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn4.Width = 160;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4});
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.autorizacionesDelPuestoUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.autorizacionesDelPuestoUltraGrid.Location = new System.Drawing.Point(0, -1);
            this.autorizacionesDelPuestoUltraGrid.Name = "autorizacionesDelPuestoUltraGrid";
            this.autorizacionesDelPuestoUltraGrid.Size = new System.Drawing.Size(815, 510);
            this.autorizacionesDelPuestoUltraGrid.TabIndex = 2;
            this.autorizacionesDelPuestoUltraGrid.AfterEnterEditMode += new System.EventHandler(this.AutorizacionesDelPuestoUltraGridAfterEnterEditMode);
            this.autorizacionesDelPuestoUltraGrid.AfterRowsDeleted += new System.EventHandler(this.AutorizacionesDelPuestoUltraGridAfterRowsDeleted);
            this.autorizacionesDelPuestoUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.autorizacionesDelPuestoUltraGrid_KeyDown);
            // 
            // ultraDropDownPuestos
            // 
            this.ultraDropDownPuestos.DataSource = this.puestosBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPuestos.DisplayLayout.Appearance = appearance11;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn5.Header.VisiblePosition = 0;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn6.Header.VisiblePosition = 1;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn5,
            ultraGridColumn6});
            ultraGridBand2.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownPuestos.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraDropDownPuestos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPuestos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPuestos.DisplayLayout.MaxBandDepth = 5;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPuestos.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPuestos.DisplayLayout.Override.ActiveRowAppearance = appearance13;
            this.ultraDropDownPuestos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPuestos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPuestos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPuestos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPuestos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPuestos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPuestos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPuestos.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPuestos.DisplayLayout.Override.CellAppearance = appearance15;
            this.ultraDropDownPuestos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPuestos.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.ultraDropDownPuestos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPuestos.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraDropDownPuestos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPuestos.DisplayLayout.Override.SelectedCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPuestos.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPuestos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance20;
            this.ultraDropDownPuestos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPuestos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPuestos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPuestos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPuestos.DisplayMember = "Nombre";
            this.ultraDropDownPuestos.Location = new System.Drawing.Point(12, 137);
            this.ultraDropDownPuestos.Name = "ultraDropDownPuestos";
            this.ultraDropDownPuestos.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownPuestos.TabIndex = 4;
            this.ultraDropDownPuestos.ValueMember = "idPuesto";
            this.ultraDropDownPuestos.Visible = false;
            this.ultraDropDownPuestos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownPuestosBeforeDropDown);
            // 
            // puestosBindingSource
            // 
            this.puestosBindingSource.DataMember = "Puestos";
            this.puestosBindingSource.DataSource = this.dsPuestos;
            // 
            // dsPuestos
            // 
            this.dsPuestos.DataSetName = "DsPuestos";
            this.dsPuestos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTiposDeAutorizacion
            // 
            this.ultraDropDownTiposDeAutorizacion.DataSource = this.tiposDeAutorizacionBindingSource;
            appearance21.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Appearance = appearance21;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn7.Header.VisiblePosition = 0;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn8.Header.VisiblePosition = 1;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn7,
            ultraGridColumn8});
            ultraGridBand3.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.MaxBandDepth = 5;
            appearance22.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.ActiveCellAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance23.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance23.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.ActiveRowAppearance = appearance23;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance24.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.CardAreaAppearance = appearance24;
            appearance25.BackColor = System.Drawing.SystemColors.Control;
            appearance25.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.CellAppearance = appearance25;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance26.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance26.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance26.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.HeaderAppearance = appearance26;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance27.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.RowSelectorAppearance = appearance27;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.SelectedCellAppearance = appearance28;
            appearance29.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance29.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.SelectedRowAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance30;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeAutorizacion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeAutorizacion.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeAutorizacion.Location = new System.Drawing.Point(12, 177);
            this.ultraDropDownTiposDeAutorizacion.Name = "ultraDropDownTiposDeAutorizacion";
            this.ultraDropDownTiposDeAutorizacion.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeAutorizacion.TabIndex = 5;
            this.ultraDropDownTiposDeAutorizacion.ValueMember = "idTipoDeAutorizacion";
            this.ultraDropDownTiposDeAutorizacion.Visible = false;
            this.ultraDropDownTiposDeAutorizacion.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTiposDeAutorizacionBeforeDropDown);
            this.ultraDropDownTiposDeAutorizacion.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownTiposDeAutorizacionRowSelected);
            // 
            // tiposDeAutorizacionBindingSource
            // 
            this.tiposDeAutorizacionBindingSource.DataMember = "TiposDeAutorizacion";
            this.tiposDeAutorizacionBindingSource.DataSource = this.dsTiposDeAutorizacion;
            // 
            // dsTiposDeAutorizacion
            // 
            this.dsTiposDeAutorizacion.DataSetName = "DsTiposDeAutorizacion";
            this.dsTiposDeAutorizacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownAutorizaciones
            // 
            this.ultraDropDownAutorizaciones.DataSource = this.autorizacionesBindingSource;
            appearance31.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownAutorizaciones.DisplayLayout.Appearance = appearance31;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn9.Header.VisiblePosition = 0;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn10.Header.VisiblePosition = 1;
            ultraGridColumn10.Width = 100;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn11.Header.VisiblePosition = 2;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn12.Header.VisiblePosition = 3;
            ultraGridColumn12.Hidden = true;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12});
            ultraGridBand4.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand4.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownAutorizaciones.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownAutorizaciones.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownAutorizaciones.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownAutorizaciones.DisplayLayout.MaxBandDepth = 5;
            appearance32.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.ActiveCellAppearance = appearance32;
            appearance33.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance33.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance33.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.ActiveRowAppearance = appearance33;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance34.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.CardAreaAppearance = appearance34;
            appearance35.BackColor = System.Drawing.SystemColors.Control;
            appearance35.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.CellAppearance = appearance35;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance36.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance36.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance36.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance36.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.HeaderAppearance = appearance36;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance37.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.RowSelectorAppearance = appearance37;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.SelectedCellAppearance = appearance38;
            appearance39.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance39.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.SelectedRowAppearance = appearance39;
            appearance40.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance40.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownAutorizaciones.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance40;
            this.ultraDropDownAutorizaciones.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownAutorizaciones.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownAutorizaciones.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownAutorizaciones.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownAutorizaciones.DisplayMember = "Descripcion";
            this.ultraDropDownAutorizaciones.Location = new System.Drawing.Point(12, 217);
            this.ultraDropDownAutorizaciones.Name = "ultraDropDownAutorizaciones";
            this.ultraDropDownAutorizaciones.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownAutorizaciones.TabIndex = 6;
            this.ultraDropDownAutorizaciones.ValueMember = "idAutorizacion";
            this.ultraDropDownAutorizaciones.Visible = false;
            this.ultraDropDownAutorizaciones.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownAutorizacionesBeforeDropDown);
            this.ultraDropDownAutorizaciones.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownAutorizacionesFilterRow);
            // 
            // autorizacionesBindingSource
            // 
            this.autorizacionesBindingSource.DataMember = "Autorizaciones";
            this.autorizacionesBindingSource.DataSource = this.dsAutorizaciones;
            // 
            // dsAutorizaciones
            // 
            this.dsAutorizaciones.DataSetName = "DsAutorizaciones";
            this.dsAutorizaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormABCAutorizacionesDelPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(814, 547);
            this.Controls.Add(this.autorizacionesDelPuestoUltraGrid);
            this.Controls.Add(this.ultraDropDownAutorizaciones);
            this.Controls.Add(this.ultraDropDownTiposDeAutorizacion);
            this.Controls.Add(this.ultraDropDownPuestos);
            this.Name = "FormABCAutorizacionesDelPuesto";
            this.Text = "Autorizaciones del Puesto";
            this.Activated += new System.EventHandler(this.FormABCAutorizacionesDelPuestoActivated);
            this.Load += new System.EventHandler(this.FormABCAutorizacionesDelPuestoLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPuestos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeAutorizacion, 0);
            this.Controls.SetChildIndex(this.ultraDropDownAutorizaciones, 0);
            this.Controls.SetChildIndex(this.autorizacionesDelPuestoUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsAutorizacionesDelPuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesDelPuestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesDelPuestoUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeAutorizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeAutorizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeAutorizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownAutorizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutorizaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsAutorizacionesDelPuesto dsAutorizacionesDelPuesto;
        private System.Windows.Forms.BindingSource autorizacionesDelPuestoBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid autorizacionesDelPuestoUltraGrid;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPuestos;
        private System.Windows.Forms.BindingSource puestosBindingSource;
        private WS.DsPuestos dsPuestos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeAutorizacion;
        private System.Windows.Forms.BindingSource tiposDeAutorizacionBindingSource;
        private WS.DsTiposDeAutorizacion dsTiposDeAutorizacion;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownAutorizaciones;
        private System.Windows.Forms.BindingSource autorizacionesBindingSource;
        private WS.DsAutorizaciones dsAutorizaciones;
    }
}

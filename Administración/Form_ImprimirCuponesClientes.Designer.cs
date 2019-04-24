using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    partial class FormImprimirCuponesClientes
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
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre");
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PuntosDeVenta", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPuntoDeVenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Prefijo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Verdadero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SolicitaCAE");
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.ultraLabelDesde = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelHasta = new Infragistics.Win.Misc.UltraLabel();
            this.ultraMaskedEditDesde = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraMaskedEditHasta = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraPopupControlContainer1 = new Infragistics.Win.Misc.UltraPopupControlContainer(this.components);
            this.listBoxImprimir = new System.Windows.Forms.ListBox();
            this.ultraDataSourceComprobantes = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraComboComprobantes = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.ultraComboPuntosDeVenta = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.puntosDeVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_PuntosDeVenta = new Administración.WS.DsPuntosDeVenta();
            this.ultraLabelPuntoDeVenta = new Infragistics.Win.Misc.UltraLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceComprobantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboComprobantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboPuntosDeVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_PuntosDeVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(256, 16);
            this.buttonAceptar.Size = new System.Drawing.Size(74, 23);
            this.buttonAceptar.Text = "Imprimir...";
            this.toolTip1.SetToolTip(this.buttonAceptar, "Imprimir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(24, 15);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxImprimir);
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Size = new System.Drawing.Size(343, 50);
            this.panel1.Controls.SetChildIndex(this.listBoxImprimir, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ultraLabelDesde
            // 
            appearance59.TextHAlignAsString = "Right";
            this.ultraLabelDesde.Appearance = appearance59;
            this.ultraLabelDesde.Location = new System.Drawing.Point(12, 71);
            this.ultraLabelDesde.Name = "ultraLabelDesde";
            this.ultraLabelDesde.Size = new System.Drawing.Size(120, 14);
            this.ultraLabelDesde.TabIndex = 8;
            this.ultraLabelDesde.Text = "Desde Nº";
            // 
            // ultraLabelHasta
            // 
            appearance3.TextHAlignAsString = "Right";
            this.ultraLabelHasta.Appearance = appearance3;
            this.ultraLabelHasta.Location = new System.Drawing.Point(12, 97);
            this.ultraLabelHasta.Name = "ultraLabelHasta";
            this.ultraLabelHasta.Size = new System.Drawing.Size(120, 14);
            this.ultraLabelHasta.TabIndex = 9;
            this.ultraLabelHasta.Text = "Hasta Nº";
            // 
            // ultraMaskedEditDesde
            // 
            this.ultraMaskedEditDesde.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEditDesde.InputMask = "########";
            this.ultraMaskedEditDesde.Location = new System.Drawing.Point(138, 68);
            this.ultraMaskedEditDesde.Name = "ultraMaskedEditDesde";
            this.ultraMaskedEditDesde.Nullable = false;
            this.ultraMaskedEditDesde.Size = new System.Drawing.Size(56, 20);
            this.ultraMaskedEditDesde.TabIndex = 14;
            this.ultraMaskedEditDesde.Text = "00000000";
            this.toolTip1.SetToolTip(this.ultraMaskedEditDesde, "Se puede modificar");
            // 
            // ultraMaskedEditHasta
            // 
            this.ultraMaskedEditHasta.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEditHasta.InputMask = "########";
            this.ultraMaskedEditHasta.Location = new System.Drawing.Point(138, 94);
            this.ultraMaskedEditHasta.Name = "ultraMaskedEditHasta";
            this.ultraMaskedEditHasta.Nullable = false;
            this.ultraMaskedEditHasta.Size = new System.Drawing.Size(56, 20);
            this.ultraMaskedEditHasta.TabIndex = 15;
            this.ultraMaskedEditHasta.Text = "99999999";
            this.toolTip1.SetToolTip(this.ultraMaskedEditHasta, "Se puede modificar");
            // 
            // ultraPopupControlContainer1
            // 
            this.ultraPopupControlContainer1.PopupControl = this.listBoxImprimir;
            // 
            // listBoxImprimir
            // 
            this.listBoxImprimir.FormattingEnabled = true;
            this.listBoxImprimir.Items.AddRange(new object[] {
            "Comprobantes",
            "Comprobantes y Listado",
            "Listado"});
            this.listBoxImprimir.Location = new System.Drawing.Point(115, 0);
            this.listBoxImprimir.Name = "listBoxImprimir";
            this.listBoxImprimir.Size = new System.Drawing.Size(121, 43);
            this.listBoxImprimir.TabIndex = 31;
            this.listBoxImprimir.Visible = false;
            this.listBoxImprimir.Click += new System.EventHandler(this.ListBoxImprimirClick);
            this.listBoxImprimir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListBoxImprimirMouseMove);
            // 
            // ultraDataSourceComprobantes
            // 
            this.ultraDataSourceComprobantes.AllowAdd = false;
            this.ultraDataSourceComprobantes.AllowDelete = false;
            this.ultraDataSourceComprobantes.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2});
            this.ultraDataSourceComprobantes.Rows.AddRange(new object[] {
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Codigo")),
                        ((object)("A")),
                        ((object)("Nombre")),
                        ((object)("Facturas A"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Codigo")),
                        ((object)("B")),
                        ((object)("Nombre")),
                        ((object)("Facturas B"))})});
            // 
            // ultraLabel5
            // 
            appearance5.TextHAlignAsString = "Right";
            this.ultraLabel5.Appearance = appearance5;
            this.ultraLabel5.AutoSize = true;
            this.ultraLabel5.Location = new System.Drawing.Point(54, 16);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(78, 14);
            this.ultraLabel5.TabIndex = 41;
            this.ultraLabel5.Text = "Comprobantes";
            // 
            // ultraComboComprobantes
            // 
            this.ultraComboComprobantes.AllowNull = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboComprobantes.DataSource = this.ultraDataSourceComprobantes;
            appearance21.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboComprobantes.DisplayLayout.Appearance = appearance21;
            this.ultraComboComprobantes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn15.Header.VisiblePosition = 0;
            ultraGridColumn15.Hidden = true;
            ultraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn16.Header.VisiblePosition = 1;
            ultraGridColumn16.NullText = "";
            ultraGridColumn16.Width = 157;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn15,
            ultraGridColumn16});
            ultraGridBand1.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraComboComprobantes.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraComboComprobantes.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraComboComprobantes.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboComprobantes.DisplayLayout.MaxBandDepth = 5;
            appearance22.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboComprobantes.DisplayLayout.Override.ActiveCellAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance23.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance23.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboComprobantes.DisplayLayout.Override.ActiveRowAppearance = appearance23;
            this.ultraComboComprobantes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboComprobantes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboComprobantes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboComprobantes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboComprobantes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboComprobantes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboComprobantes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance24.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboComprobantes.DisplayLayout.Override.CardAreaAppearance = appearance24;
            appearance25.BackColor = System.Drawing.SystemColors.Control;
            appearance25.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboComprobantes.DisplayLayout.Override.CellAppearance = appearance25;
            this.ultraComboComprobantes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance26.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance26.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance26.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboComprobantes.DisplayLayout.Override.HeaderAppearance = appearance26;
            this.ultraComboComprobantes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance27.ForeColor = System.Drawing.Color.Red;
            this.ultraComboComprobantes.DisplayLayout.Override.RowSelectorAppearance = appearance27;
            this.ultraComboComprobantes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboComprobantes.DisplayLayout.Override.SelectedCellAppearance = appearance28;
            appearance29.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance29.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboComprobantes.DisplayLayout.Override.SelectedRowAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboComprobantes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance30;
            this.ultraComboComprobantes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboComprobantes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboComprobantes.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboComprobantes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboComprobantes.DisplayMember = "Nombre";
            this.ultraComboComprobantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraComboComprobantes.LimitToList = true;
            this.ultraComboComprobantes.Location = new System.Drawing.Point(138, 12);
            this.ultraComboComprobantes.Name = "ultraComboComprobantes";
            this.ultraComboComprobantes.Size = new System.Drawing.Size(176, 22);
            this.ultraComboComprobantes.TabIndex = 40;
            this.ultraComboComprobantes.ValueMember = "Codigo";
            // 
            // ultraComboPuntosDeVenta
            // 
            this.ultraComboPuntosDeVenta.AllowNull = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboPuntosDeVenta.DataSource = this.puntosDeVentaBindingSource;
            appearance41.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance41.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboPuntosDeVenta.DisplayLayout.Appearance = appearance41;
            this.ultraComboPuntosDeVenta.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn3.Header.VisiblePosition = 0;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn3.Width = 11;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn4.Header.VisiblePosition = 1;
            ultraGridColumn4.Width = 58;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn5.Header.VisiblePosition = 2;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn5.Width = 14;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn6.Header.VisiblePosition = 3;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn6.Width = 19;
            ultraGridColumn7.Header.VisiblePosition = 4;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn8.Header.VisiblePosition = 5;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn9.Header.VisiblePosition = 6;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn10.Header.VisiblePosition = 7;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn11.Header.VisiblePosition = 8;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn12.Header.VisiblePosition = 9;
            ultraGridColumn12.Hidden = true;
            ultraGridColumn13.Header.VisiblePosition = 10;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn14.Header.VisiblePosition = 11;
            ultraGridColumn14.Hidden = true;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14});
            ultraGridBand2.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraComboPuntosDeVenta.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraComboPuntosDeVenta.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraComboPuntosDeVenta.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboPuntosDeVenta.DisplayLayout.MaxBandDepth = 5;
            appearance42.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.ActiveCellAppearance = appearance42;
            appearance43.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance43.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance43.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.ActiveRowAppearance = appearance43;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance44.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.CardAreaAppearance = appearance44;
            appearance45.BackColor = System.Drawing.SystemColors.Control;
            appearance45.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.CellAppearance = appearance45;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance46.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance46.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance46.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance46.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.HeaderAppearance = appearance46;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance47.ForeColor = System.Drawing.Color.Red;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.RowSelectorAppearance = appearance47;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.SelectedCellAppearance = appearance48;
            appearance49.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance49.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.SelectedRowAppearance = appearance49;
            appearance50.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboPuntosDeVenta.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance50;
            this.ultraComboPuntosDeVenta.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboPuntosDeVenta.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboPuntosDeVenta.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboPuntosDeVenta.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboPuntosDeVenta.DisplayMember = "Prefijo";
            this.ultraComboPuntosDeVenta.LimitToList = true;
            this.ultraComboPuntosDeVenta.Location = new System.Drawing.Point(138, 40);
            this.ultraComboPuntosDeVenta.Name = "ultraComboPuntosDeVenta";
            this.ultraComboPuntosDeVenta.Size = new System.Drawing.Size(77, 22);
            this.ultraComboPuntosDeVenta.TabIndex = 42;
            this.ultraComboPuntosDeVenta.ValueMember = "idPuntoDeVenta";
            // 
            // puntosDeVentaBindingSource
            // 
            this.puntosDeVentaBindingSource.DataMember = "PuntosDeVenta";
            this.puntosDeVentaBindingSource.DataSource = this.ds_PuntosDeVenta;
            // 
            // ds_PuntosDeVenta
            // 
            this.ds_PuntosDeVenta.DataSetName = "DsPuntosDeVenta";
            this.ds_PuntosDeVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraLabelPuntoDeVenta
            // 
            appearance2.TextHAlignAsString = "Right";
            this.ultraLabelPuntoDeVenta.Appearance = appearance2;
            this.ultraLabelPuntoDeVenta.Location = new System.Drawing.Point(12, 44);
            this.ultraLabelPuntoDeVenta.Name = "ultraLabelPuntoDeVenta";
            this.ultraLabelPuntoDeVenta.Size = new System.Drawing.Size(120, 14);
            this.ultraLabelPuntoDeVenta.TabIndex = 43;
            this.ultraLabelPuntoDeVenta.Text = "Punto de Venta";
            // 
            // FormImprimirCuponesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(334, 158);
            this.Controls.Add(this.ultraComboPuntosDeVenta);
            this.Controls.Add(this.ultraLabelPuntoDeVenta);
            this.Controls.Add(this.ultraLabel5);
            this.Controls.Add(this.ultraComboComprobantes);
            this.Controls.Add(this.ultraMaskedEditHasta);
            this.Controls.Add(this.ultraMaskedEditDesde);
            this.Controls.Add(this.ultraLabelHasta);
            this.Controls.Add(this.ultraLabelDesde);
            this.MaximumSize = new System.Drawing.Size(350, 196);
            this.MinimumSize = new System.Drawing.Size(350, 196);
            this.Name = "FormImprimirCuponesClientes";
            this.Text = "Impresión de Comprobantes Clientes y sus Listados";
            this.Load += new System.EventHandler(this.FormImprimirCuponesLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraLabelDesde, 0);
            this.Controls.SetChildIndex(this.ultraLabelHasta, 0);
            this.Controls.SetChildIndex(this.ultraMaskedEditDesde, 0);
            this.Controls.SetChildIndex(this.ultraMaskedEditHasta, 0);
            this.Controls.SetChildIndex(this.ultraComboComprobantes, 0);
            this.Controls.SetChildIndex(this.ultraLabel5, 0);
            this.Controls.SetChildIndex(this.ultraLabelPuntoDeVenta, 0);
            this.Controls.SetChildIndex(this.ultraComboPuntosDeVenta, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceComprobantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboComprobantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboPuntosDeVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_PuntosDeVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabelDesde;
        private Infragistics.Win.Misc.UltraLabel ultraLabelHasta;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEditDesde;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEditHasta;
        private Infragistics.Win.Misc.UltraPopupControlContainer ultraPopupControlContainer1;
        private System.Windows.Forms.ListBox listBoxImprimir;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceComprobantes;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private UltraCombo ultraComboComprobantes;
        private System.Windows.Forms.BindingSource puntosDeVentaBindingSource;
        private WS.DsPuntosDeVenta ds_PuntosDeVenta;
        private UltraCombo ultraComboPuntosDeVenta;
        private Infragistics.Win.Misc.UltraLabel ultraLabelPuntoDeVenta;
    }
}

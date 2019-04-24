namespace Administración
{
    partial class FormNdeCCliente
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BuscarClientes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RazonSocial");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreFantasia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ComprobantesImpagosCliente", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Prefijo");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeComprobante");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo");
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCUIT = new System.Windows.Forms.Button();
            this.maskedTextBoxCUIT = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRazon = new System.Windows.Forms.Button();
            this.textBoxRazon = new System.Windows.Forms.TextBox();
            this.ultraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.buscarClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBuscarClientes = new Administración.WS.DsBuscarClientes();
            this.ultraNumericEditorIdCliente = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraGridImpagos = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.comprobantesImpagosClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsComprobantesImpagosCliente = new Administración.WS.DsComprobantesImpagosCliente();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditorIdCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridImpagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesImpagosClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprobantesImpagosCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(508, 18);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Modificar el registro seleccionado.");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(325, 18);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Ver los detalles sin posibilidad de modificarlos.");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 434);
            this.panel1.Size = new System.Drawing.Size(595, 52);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(427, 18);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir.");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCUIT);
            this.groupBox2.Controls.Add(this.maskedTextBoxCUIT);
            this.groupBox2.Location = new System.Drawing.Point(76, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 45);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por CUIT";
            // 
            // buttonCUIT
            // 
            this.buttonCUIT.Enabled = false;
            this.buttonCUIT.Location = new System.Drawing.Point(101, 16);
            this.buttonCUIT.Name = "buttonCUIT";
            this.buttonCUIT.Size = new System.Drawing.Size(48, 23);
            this.buttonCUIT.TabIndex = 1;
            this.buttonCUIT.Text = "Buscar";
            this.buttonCUIT.UseVisualStyleBackColor = true;
            this.buttonCUIT.Click += new System.EventHandler(this.ButtonCUITClick);
            // 
            // maskedTextBoxCUIT
            // 
            this.maskedTextBoxCUIT.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxCUIT.Location = new System.Drawing.Point(7, 17);
            this.maskedTextBoxCUIT.Mask = "##-##.###.###-#";
            this.maskedTextBoxCUIT.Name = "maskedTextBoxCUIT";
            this.maskedTextBoxCUIT.Size = new System.Drawing.Size(88, 20);
            this.maskedTextBoxCUIT.TabIndex = 0;
            this.maskedTextBoxCUIT.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxCUIT.Click += new System.EventHandler(this.MaskedTextBoxCUITClick);
            this.maskedTextBoxCUIT.Enter += new System.EventHandler(this.MaskedTextBoxCUITEnter);
            this.maskedTextBoxCUIT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MaskedTextBoxCUITKeyUp);
            this.maskedTextBoxCUIT.Leave += new System.EventHandler(this.MaskedTextBoxCUITLeave);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonRazon);
            this.groupBox3.Controls.Add(this.textBoxRazon);
            this.groupBox3.Location = new System.Drawing.Point(239, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 45);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por Razón Social o Nombre Fantasía";
            // 
            // buttonRazon
            // 
            this.buttonRazon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRazon.Enabled = false;
            this.buttonRazon.Location = new System.Drawing.Point(227, 16);
            this.buttonRazon.Name = "buttonRazon";
            this.buttonRazon.Size = new System.Drawing.Size(50, 23);
            this.buttonRazon.TabIndex = 1;
            this.buttonRazon.Text = "Buscar";
            this.buttonRazon.UseVisualStyleBackColor = true;
            this.buttonRazon.Click += new System.EventHandler(this.ButtonRazonClick);
            // 
            // textBoxRazon
            // 
            this.textBoxRazon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRazon.Location = new System.Drawing.Point(6, 17);
            this.textBoxRazon.Name = "textBoxRazon";
            this.textBoxRazon.Size = new System.Drawing.Size(215, 20);
            this.textBoxRazon.TabIndex = 0;
            this.textBoxRazon.Enter += new System.EventHandler(this.TextBoxRazonEnter);
            this.textBoxRazon.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxRazonKeyUp);
            this.textBoxRazon.Leave += new System.EventHandler(this.TextBoxRazonLeave);
            // 
            // ultraGrid
            // 
            this.ultraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraGrid.DataSource = this.buscarClientesBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGrid.DisplayLayout.Appearance = appearance1;
            this.ultraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Width = 53;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 101;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 99;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Width = 99;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Width = 99;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Width = 99;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6});
            this.ultraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraGrid.DisplayLayout.InterBandSpacing = 10;
            this.ultraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.ultraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ultraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance7.BackColor = System.Drawing.Color.Transparent;
            this.ultraGrid.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BackColor = System.Drawing.SystemColors.Control;
            appearance8.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGrid.DisplayLayout.Override.CellAppearance = appearance8;
            this.ultraGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ultraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance9.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGrid.DisplayLayout.Override.HeaderAppearance = appearance9;
            this.ultraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance10.ForeColor = System.Drawing.Color.Red;
            this.ultraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance10;
            this.ultraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance11;
            appearance12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance12.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance13.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance13;
            this.ultraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraGrid.DisplayLayout.UseFixedHeaders = true;
            this.ultraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGrid.Location = new System.Drawing.Point(12, 63);
            this.ultraGrid.Name = "ultraGrid";
            this.ultraGrid.Size = new System.Drawing.Size(571, 197);
            this.ultraGrid.TabIndex = 2;
            this.ultraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.UltraGridInitializeRow);
            this.ultraGrid.AfterSelectChange += new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(this.UltraGridAfterSelectChange);
            this.ultraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ultraGrid_KeyDown);
            // 
            // buscarClientesBindingSource
            // 
            this.buscarClientesBindingSource.DataMember = "BuscarClientes";
            this.buscarClientesBindingSource.DataSource = this.dsBuscarClientes;
            // 
            // dsBuscarClientes
            // 
            this.dsBuscarClientes.DataSetName = "DsBuscarClientes";
            this.dsBuscarClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraNumericEditorIdCliente
            // 
            this.ultraNumericEditorIdCliente.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.buscarClientesBindingSource, "idCliente", true));
            this.ultraNumericEditorIdCliente.Location = new System.Drawing.Point(245, 163);
            this.ultraNumericEditorIdCliente.Name = "ultraNumericEditorIdCliente";
            this.ultraNumericEditorIdCliente.Size = new System.Drawing.Size(100, 21);
            this.ultraNumericEditorIdCliente.TabIndex = 3;
            // 
            // ultraGridImpagos
            // 
            this.ultraGridImpagos.DataSource = this.comprobantesImpagosClienteBindingSource;
            appearance14.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGridImpagos.DisplayLayout.Appearance = appearance14;
            this.ultraGridImpagos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn7.Header.VisiblePosition = 0;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn7.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always;
            ultraGridColumn7.Width = 72;
            appearance2.TextHAlignAsString = "Center";
            ultraGridColumn8.CellAppearance = appearance2;
            ultraGridColumn8.Header.VisiblePosition = 1;
            ultraGridColumn8.Width = 90;
            appearance3.TextHAlignAsString = "Center";
            ultraGridColumn9.CellAppearance = appearance3;
            ultraGridColumn9.Header.Caption = "Nº  Comprobante";
            ultraGridColumn9.Header.VisiblePosition = 2;
            ultraGridColumn9.Width = 118;
            appearance4.TextHAlignAsString = "Center";
            ultraGridColumn10.CellAppearance = appearance4;
            ultraGridColumn10.Header.VisiblePosition = 3;
            ultraGridColumn10.MaskInput = "dd/mm/yyyy";
            ultraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn10.Width = 73;
            appearance15.TextHAlignAsString = "Center";
            ultraGridColumn11.CellAppearance = appearance15;
            ultraGridColumn11.Header.Caption = "Período";
            ultraGridColumn11.Header.VisiblePosition = 4;
            ultraGridColumn11.Width = 80;
            appearance16.TextHAlignAsString = "Right";
            ultraGridColumn12.CellAppearance = appearance16;
            ultraGridColumn12.Header.VisiblePosition = 5;
            ultraGridColumn12.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn12.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn12.Width = 95;
            appearance17.TextHAlignAsString = "Right";
            ultraGridColumn13.CellAppearance = appearance17;
            ultraGridColumn13.Header.VisiblePosition = 6;
            ultraGridColumn13.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn13.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn13.Width = 94;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13});
            ultraGridBand2.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand2.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridImpagos.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraGridImpagos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraGridImpagos.DisplayLayout.InterBandSpacing = 10;
            this.ultraGridImpagos.DisplayLayout.MaxBandDepth = 5;
            appearance21.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGridImpagos.DisplayLayout.Override.ActiveCellAppearance = appearance21;
            appearance22.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance22.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance22.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraGridImpagos.DisplayLayout.Override.ActiveRowAppearance = appearance22;
            this.ultraGridImpagos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraGridImpagos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGridImpagos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridImpagos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraGridImpagos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridImpagos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraGridImpagos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance23.BackColor = System.Drawing.Color.Transparent;
            this.ultraGridImpagos.DisplayLayout.Override.CardAreaAppearance = appearance23;
            appearance24.BackColor = System.Drawing.SystemColors.Control;
            appearance24.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGridImpagos.DisplayLayout.Override.CellAppearance = appearance24;
            this.ultraGridImpagos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ultraGridImpagos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance25.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance25.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance25.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGridImpagos.DisplayLayout.Override.HeaderAppearance = appearance25;
            this.ultraGridImpagos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance26.ForeColor = System.Drawing.Color.Red;
            this.ultraGridImpagos.DisplayLayout.Override.RowSelectorAppearance = appearance26;
            this.ultraGridImpagos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraGridImpagos.DisplayLayout.Override.SelectedCellAppearance = appearance27;
            appearance28.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance28.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGridImpagos.DisplayLayout.Override.SelectedRowAppearance = appearance28;
            appearance29.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance29.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraGridImpagos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance29;
            this.ultraGridImpagos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraGridImpagos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraGridImpagos.DisplayLayout.UseFixedHeaders = true;
            this.ultraGridImpagos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGridImpagos.Enabled = false;
            this.ultraGridImpagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGridImpagos.Location = new System.Drawing.Point(12, 263);
            this.ultraGridImpagos.Name = "ultraGridImpagos";
            this.ultraGridImpagos.Size = new System.Drawing.Size(571, 183);
            this.ultraGridImpagos.TabIndex = 5;
            this.ultraGridImpagos.AfterSelectChange += new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(this.UltraGridImpagosAfterSelectChange);
            this.ultraGridImpagos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ultraGridImpagos_KeyDown);
            // 
            // comprobantesImpagosClienteBindingSource
            // 
            this.comprobantesImpagosClienteBindingSource.DataMember = "ComprobantesImpagosCliente";
            this.comprobantesImpagosClienteBindingSource.DataSource = this.dsComprobantesImpagosCliente;
            // 
            // dsComprobantesImpagosCliente
            // 
            this.dsComprobantesImpagosCliente.DataSetName = "DsComprobantesImpagosCliente";
            this.dsComprobantesImpagosCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.ForeColor = System.Drawing.Color.Red;
            this.labelMensaje.Location = new System.Drawing.Point(12, 247);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(193, 13);
            this.labelMensaje.TabIndex = 6;
            this.labelMensaje.Text = "No hay comprobantes con saldo.";
            this.labelMensaje.Visible = false;
            // 
            // FormNdeCCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(594, 486);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.ultraGridImpagos);
            this.Controls.Add(this.ultraGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ultraNumericEditorIdCliente);
            this.MaximumSize = new System.Drawing.Size(781, 582);
            this.MinimumSize = new System.Drawing.Size(581, 382);
            this.Name = "FormNdeCCliente";
            this.Text = "Nota de Crédito a un Cliente";
            this.Load += new System.EventHandler(this.FormNdeCCliente_Load);
            this.Enter += new System.EventHandler(this.FormABCClientesEnter);
            this.Controls.SetChildIndex(this.ultraNumericEditorIdCliente, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.ultraGrid, 0);
            this.Controls.SetChildIndex(this.ultraGridImpagos, 0);
            this.Controls.SetChildIndex(this.labelMensaje, 0);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditorIdCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridImpagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesImpagosClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprobantesImpagosCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCUIT;
        private System.Windows.Forms.Button buttonCUIT;
        private System.Windows.Forms.Button buttonRazon;
        private System.Windows.Forms.TextBox textBoxRazon;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditorIdCliente;
        private System.Windows.Forms.BindingSource buscarClientesBindingSource;
        private WS.DsBuscarClientes dsBuscarClientes;
        private WS.DsComprobantesImpagosCliente dsComprobantesImpagosCliente;
        private System.Windows.Forms.BindingSource comprobantesImpagosClienteBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridImpagos;
        private System.Windows.Forms.Label labelMensaje;
    }
}

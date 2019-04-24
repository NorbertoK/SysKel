namespace Administración
{
    partial class FormCobrarEnMostradorCli
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ComprobantesImpagosCliente", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Prefijo");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeComprobante", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo");
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo");
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca", 0);
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BuscarClientes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RazonSocial");
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreFantasia");
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            this.ultraNumericEditorIdCliente = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.buscarClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBuscarClientes = new Administración.WS.DsBuscarClientes();
            this.ultraGridImpagos = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.comprobantesImpagosClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsComprobantesImpagosCliente = new Administración.WS.DsComprobantesImpagosCliente();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.ultraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCUIT = new System.Windows.Forms.Button();
            this.maskedTextBoxCUIT = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRazon = new System.Windows.Forms.Button();
            this.textBoxRazon = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditorIdCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridImpagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesImpagosClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprobantesImpagosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(497, 16);
            this.buttonAceptar.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonAceptar, "Modificar el registro seleccionado.");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(176, 14);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Ver los detalles sin posibilidad de modificarlos.");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 396);
            this.panel1.Size = new System.Drawing.Size(587, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(416, 16);
            this.buttonCancelar.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir.");
            // 
            // ultraNumericEditorIdCliente
            // 
            this.ultraNumericEditorIdCliente.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.buscarClientesBindingSource, "idCliente", true));
            this.ultraNumericEditorIdCliente.Location = new System.Drawing.Point(236, 164);
            this.ultraNumericEditorIdCliente.Name = "ultraNumericEditorIdCliente";
            this.ultraNumericEditorIdCliente.Size = new System.Drawing.Size(100, 21);
            this.ultraNumericEditorIdCliente.TabIndex = 6;
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
            // ultraGridImpagos
            // 
            this.ultraGridImpagos.DataSource = this.comprobantesImpagosClienteBindingSource;
            appearance51.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance51.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGridImpagos.DisplayLayout.Appearance = appearance51;
            this.ultraGridImpagos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always;
            ultraGridColumn1.Width = 72;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            appearance2.TextHAlignAsString = "Center";
            ultraGridColumn2.CellAppearance = appearance2;
            ultraGridColumn2.Header.VisiblePosition = 2;
            ultraGridColumn2.Width = 76;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            appearance3.TextHAlignAsString = "Center";
            ultraGridColumn3.CellAppearance = appearance3;
            ultraGridColumn3.Header.Caption = "Nº  Comprobante";
            ultraGridColumn3.Header.VisiblePosition = 3;
            ultraGridColumn3.Width = 104;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            appearance4.TextHAlignAsString = "Center";
            ultraGridColumn4.CellAppearance = appearance4;
            ultraGridColumn4.Header.VisiblePosition = 4;
            ultraGridColumn4.MaskInput = "dd/mm/yyyy";
            ultraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn4.Width = 73;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            appearance14.TextHAlignAsString = "Center";
            ultraGridColumn5.CellAppearance = appearance14;
            ultraGridColumn5.Header.Caption = "Período";
            ultraGridColumn5.Header.VisiblePosition = 5;
            ultraGridColumn5.Width = 82;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            appearance15.TextHAlignAsString = "Right";
            ultraGridColumn6.CellAppearance = appearance15;
            ultraGridColumn6.Header.VisiblePosition = 6;
            ultraGridColumn6.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn6.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn6.Width = 88;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            appearance16.TextHAlignAsString = "Right";
            ultraGridColumn7.CellAppearance = appearance16;
            ultraGridColumn7.Header.VisiblePosition = 7;
            ultraGridColumn7.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn7.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn7.Width = 90;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit;
            ultraGridColumn8.DataType = typeof(bool);
            ultraGridColumn8.DefaultCellValue = false;
            ultraGridColumn8.Header.VisiblePosition = 1;
            ultraGridColumn8.Width = 28;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8});
            ultraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridImpagos.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGridImpagos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraGridImpagos.DisplayLayout.InterBandSpacing = 10;
            this.ultraGridImpagos.DisplayLayout.MaxBandDepth = 5;
            appearance58.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGridImpagos.DisplayLayout.Override.ActiveCellAppearance = appearance58;
            appearance59.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance59.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance59.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraGridImpagos.DisplayLayout.Override.ActiveRowAppearance = appearance59;
            this.ultraGridImpagos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraGridImpagos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGridImpagos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridImpagos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraGridImpagos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridImpagos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraGridImpagos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance60.BackColor = System.Drawing.Color.Transparent;
            this.ultraGridImpagos.DisplayLayout.Override.CardAreaAppearance = appearance60;
            appearance61.BackColor = System.Drawing.SystemColors.Control;
            appearance61.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGridImpagos.DisplayLayout.Override.CellAppearance = appearance61;
            this.ultraGridImpagos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ultraGridImpagos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance62.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance62.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance62.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance62.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGridImpagos.DisplayLayout.Override.HeaderAppearance = appearance62;
            this.ultraGridImpagos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance63.ForeColor = System.Drawing.Color.Red;
            this.ultraGridImpagos.DisplayLayout.Override.RowSelectorAppearance = appearance63;
            this.ultraGridImpagos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraGridImpagos.DisplayLayout.Override.SelectedCellAppearance = appearance64;
            appearance65.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance65.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance65.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGridImpagos.DisplayLayout.Override.SelectedRowAppearance = appearance65;
            this.ultraGridImpagos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.None;
            appearance66.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance66.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraGridImpagos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance66;
            this.ultraGridImpagos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraGridImpagos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraGridImpagos.DisplayLayout.UseFixedHeaders = true;
            this.ultraGridImpagos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGridImpagos.Enabled = false;
            this.ultraGridImpagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGridImpagos.Location = new System.Drawing.Point(12, 265);
            this.ultraGridImpagos.Name = "ultraGridImpagos";
            this.ultraGridImpagos.Size = new System.Drawing.Size(562, 139);
            this.ultraGridImpagos.TabIndex = 3;
            this.ultraGridImpagos.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.UltraGridImpagosCellChange);
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
            this.labelMensaje.Location = new System.Drawing.Point(15, 250);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(193, 13);
            this.labelMensaje.TabIndex = 8;
            this.labelMensaje.Text = "No hay comprobantes con saldo.";
            this.labelMensaje.Visible = false;
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
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn9.Header.VisiblePosition = 0;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn10.Header.Caption = "Razón Social";
            ultraGridColumn10.Header.VisiblePosition = 1;
            appearance17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            appearance17.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            ultraGridColumn10.MergedCellAppearance = appearance17;
            ultraGridColumn10.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always;
            ultraGridColumn10.Width = 118;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn11.Header.Caption = "Nombre Fantasía";
            ultraGridColumn11.Header.VisiblePosition = 2;
            appearance18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            appearance18.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            ultraGridColumn11.MergedCellAppearance = appearance18;
            ultraGridColumn11.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always;
            ultraGridColumn11.Width = 124;
            ultraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn12.Header.VisiblePosition = 3;
            ultraGridColumn12.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn12.MaskInput = "##-##.###.###-#";
            appearance19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            appearance19.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            ultraGridColumn12.MergedCellAppearance = appearance19;
            ultraGridColumn12.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always;
            ultraGridColumn12.Width = 98;
            ultraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn13.Header.VisiblePosition = 4;
            ultraGridColumn13.Width = 115;
            ultraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn14.Header.VisiblePosition = 5;
            ultraGridColumn14.Width = 86;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14});
            this.ultraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
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
            this.ultraGrid.Size = new System.Drawing.Size(562, 184);
            this.ultraGrid.TabIndex = 2;
            this.ultraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.UltraGridInitializeRow);
            this.ultraGrid.AfterSelectChange += new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(this.UltraGridAfterSelectChange);
            this.ultraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ultraGrid_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCUIT);
            this.groupBox2.Controls.Add(this.maskedTextBoxCUIT);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 45);
            this.groupBox2.TabIndex = 11;
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
            this.buttonCUIT.TabStop = false;
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
            this.groupBox3.Location = new System.Drawing.Point(175, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 45);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por Razón Social o Nombre Fantasía";
            // 
            // buttonRazon
            // 
            this.buttonRazon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRazon.Enabled = false;
            this.buttonRazon.Location = new System.Drawing.Point(342, 16);
            this.buttonRazon.Name = "buttonRazon";
            this.buttonRazon.Size = new System.Drawing.Size(50, 23);
            this.buttonRazon.TabIndex = 1;
            this.buttonRazon.TabStop = false;
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
            this.textBoxRazon.Size = new System.Drawing.Size(330, 20);
            this.textBoxRazon.TabIndex = 1;
            this.textBoxRazon.Enter += new System.EventHandler(this.TextBoxRazonEnter);
            this.textBoxRazon.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxRazonKeyUp);
            this.textBoxRazon.Leave += new System.EventHandler(this.TextBoxRazonLeave);
            // 
            // FormCobrarEnMostradorCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(588, 445);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ultraGrid);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.ultraGridImpagos);
            this.Controls.Add(this.ultraNumericEditorIdCliente);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "FormCobrarEnMostradorCli";
            this.Text = "Cobranza de Clientes por Mostrador";
            this.Load += new System.EventHandler(this.FormCobrarEnMostradorCliLoad);
            this.Enter += new System.EventHandler(this.FormCobrarEnMostradorCliEnter);
            this.Controls.SetChildIndex(this.ultraNumericEditorIdCliente, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraGridImpagos, 0);
            this.Controls.SetChildIndex(this.labelMensaje, 0);
            this.Controls.SetChildIndex(this.ultraGrid, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditorIdCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridImpagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesImpagosClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprobantesImpagosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditorIdCliente;
        private WS.DsComprobantesImpagosCliente dsComprobantesImpagosCliente;
        private System.Windows.Forms.BindingSource comprobantesImpagosClienteBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridImpagos;
        private System.Windows.Forms.Label labelMensaje;
        private WS.DsBuscarClientes dsBuscarClientes;
        private System.Windows.Forms.BindingSource buscarClientesBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCUIT;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCUIT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonRazon;
        private System.Windows.Forms.TextBox textBoxRazon;

    }
}

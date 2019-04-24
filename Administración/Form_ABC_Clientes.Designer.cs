namespace Administración
{
    partial class FormABCClientes
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
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RazonSocial");
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreFantasia");
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            this.groupBoxClienteNuevo = new System.Windows.Forms.GroupBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCUIT = new System.Windows.Forms.Button();
            this.maskedTextBoxCUIT = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRazon = new System.Windows.Forms.Button();
            this.textBoxRazon = new System.Windows.Forms.TextBox();
            this.ultraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.buscarClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBuscarClientes = new Administración.WS.DsBuscarClientes();
            this.ultraNumericEditor1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.dsAutorizacionesDelUsuario = new Administración.WS.DsAutorizacionesDelUsuario();
            this.buttonCuentaCorriente = new System.Windows.Forms.Button();
            this.buttonFacturas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxClienteNuevo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutorizacionesDelUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(484, 18);
            this.buttonAceptar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.buttonAceptar, "Modificar el registro seleccionado.");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(403, 18);
            this.buttonAplicar.Text = "Ver";
            this.toolTip1.SetToolTip(this.buttonAplicar, "Ver los detalles sin posibilidad de modificarlos.");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonFacturas);
            this.panel1.Controls.Add(this.buttonCuentaCorriente);
            this.panel1.Location = new System.Drawing.Point(0, 303);
            this.panel1.Size = new System.Drawing.Size(574, 52);
            this.panel1.Controls.SetChildIndex(this.buttonCuentaCorriente, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonFacturas, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(322, 18);
            this.buttonCancelar.Text = "Salir";
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir.");
            // 
            // groupBoxClienteNuevo
            // 
            this.groupBoxClienteNuevo.Controls.Add(this.buttonAgregar);
            this.groupBoxClienteNuevo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxClienteNuevo.Name = "groupBoxClienteNuevo";
            this.groupBoxClienteNuevo.Size = new System.Drawing.Size(119, 45);
            this.groupBoxClienteNuevo.TabIndex = 1;
            this.groupBoxClienteNuevo.TabStop = false;
            this.groupBoxClienteNuevo.Text = "Cliente Nuevo";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(6, 16);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(105, 23);
            this.buttonAgregar.TabIndex = 0;
            this.buttonAgregar.Text = "Agregar un Cliente";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.ButtonAgregarClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCUIT);
            this.groupBox2.Controls.Add(this.maskedTextBoxCUIT);
            this.groupBox2.Location = new System.Drawing.Point(137, 12);
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
            this.groupBox3.Location = new System.Drawing.Point(300, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 45);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por Razón Social o Nombre Fantasía";
            // 
            // buttonRazon
            // 
            this.buttonRazon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRazon.Enabled = false;
            this.buttonRazon.Location = new System.Drawing.Point(206, 16);
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
            this.textBoxRazon.Size = new System.Drawing.Size(194, 20);
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
            ultraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn13.Header.VisiblePosition = 0;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn14.Header.Caption = "Razón Social";
            ultraGridColumn14.Header.VisiblePosition = 1;
            appearance17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            appearance17.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            ultraGridColumn14.MergedCellAppearance = appearance17;
            ultraGridColumn14.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always;
            ultraGridColumn14.Width = 109;
            ultraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn15.Header.Caption = "Nombre Fantasía";
            ultraGridColumn15.Header.VisiblePosition = 2;
            appearance18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            appearance18.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            ultraGridColumn15.MergedCellAppearance = appearance18;
            ultraGridColumn15.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always;
            ultraGridColumn15.Width = 129;
            ultraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn16.Header.VisiblePosition = 3;
            ultraGridColumn16.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn16.MaskInput = "##-##.###.###-#";
            appearance19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            appearance19.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            ultraGridColumn16.MergedCellAppearance = appearance19;
            ultraGridColumn16.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always;
            ultraGridColumn16.Width = 94;
            ultraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn17.Header.VisiblePosition = 4;
            ultraGridColumn17.Width = 112;
            ultraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn18.Header.VisiblePosition = 5;
            ultraGridColumn18.MaxLength = 20;
            ultraGridColumn18.Width = 85;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18});
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
            this.ultraGrid.Size = new System.Drawing.Size(550, 252);
            this.ultraGrid.TabIndex = 2;
            this.ultraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.UltraGridInitializeRow);
            this.ultraGrid.Click += new System.EventHandler(this.UltraGridClick);
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
            // ultraNumericEditor1
            // 
            this.ultraNumericEditor1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.buscarClientesBindingSource, "idCliente", true));
            this.ultraNumericEditor1.Location = new System.Drawing.Point(238, 241);
            this.ultraNumericEditor1.Name = "ultraNumericEditor1";
            this.ultraNumericEditor1.Size = new System.Drawing.Size(100, 21);
            this.ultraNumericEditor1.TabIndex = 3;
            // 
            // dsAutorizacionesDelUsuario
            // 
            this.dsAutorizacionesDelUsuario.DataSetName = "DsAutorizacionesDelUsuario";
            this.dsAutorizacionesDelUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonCuentaCorriente
            // 
            this.buttonCuentaCorriente.Enabled = false;
            this.buttonCuentaCorriente.Location = new System.Drawing.Point(12, 18);
            this.buttonCuentaCorriente.Name = "buttonCuentaCorriente";
            this.buttonCuentaCorriente.Size = new System.Drawing.Size(96, 23);
            this.buttonCuentaCorriente.TabIndex = 3;
            this.buttonCuentaCorriente.Text = "Cuenta Corriente";
            this.buttonCuentaCorriente.UseVisualStyleBackColor = true;
            this.buttonCuentaCorriente.Click += new System.EventHandler(this.ButtonCuentaCorrienteClick);
            // 
            // buttonFacturas
            // 
            this.buttonFacturas.Enabled = false;
            this.buttonFacturas.Location = new System.Drawing.Point(114, 17);
            this.buttonFacturas.Name = "buttonFacturas";
            this.buttonFacturas.Size = new System.Drawing.Size(75, 23);
            this.buttonFacturas.TabIndex = 4;
            this.buttonFacturas.Text = "Facturas";
            this.buttonFacturas.UseVisualStyleBackColor = true;
            this.buttonFacturas.Click += new System.EventHandler(this.buttonFacturas_Click);
            // 
            // FormABCClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(573, 355);
            this.Controls.Add(this.ultraGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxClienteNuevo);
            this.Controls.Add(this.ultraNumericEditor1);
            this.MinimumSize = new System.Drawing.Size(581, 382);
            this.Name = "FormABCClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormABCClientesLoad);
            this.Enter += new System.EventHandler(this.FormABCClientesEnter);
            this.Controls.SetChildIndex(this.ultraNumericEditor1, 0);
            this.Controls.SetChildIndex(this.groupBoxClienteNuevo, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.ultraGrid, 0);
            this.panel1.ResumeLayout(false);
            this.groupBoxClienteNuevo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutorizacionesDelUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClienteNuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCUIT;
        private System.Windows.Forms.Button buttonCUIT;
        private System.Windows.Forms.Button buttonRazon;
        private System.Windows.Forms.TextBox textBoxRazon;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditor1;
        private System.Windows.Forms.BindingSource buscarClientesBindingSource;
        private WS.DsBuscarClientes dsBuscarClientes;
        private WS.DsAutorizacionesDelUsuario dsAutorizacionesDelUsuario;
        private System.Windows.Forms.Button buttonCuentaCorriente;
        private System.Windows.Forms.Button buttonFacturas;
    }
}

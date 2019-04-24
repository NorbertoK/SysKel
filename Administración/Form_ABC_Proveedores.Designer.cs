namespace Administración
{
    partial class FormABCProveedores
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BuscarProveedores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RazonSocial");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreFantasia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.groupBoxClienteNuevo = new System.Windows.Forms.GroupBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCUIT = new System.Windows.Forms.Button();
            this.maskedTextBoxCUIT = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRazon = new System.Windows.Forms.Button();
            this.textBoxRazon = new System.Windows.Forms.TextBox();
            this.ultraNumericEditor1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.buscarProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBuscarProveedores = new Administración.WS.DsBuscarProveedores();
            this.buttonCuentaCorriente = new System.Windows.Forms.Button();
            this.ultraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            this.groupBoxClienteNuevo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(526, 18);
            this.buttonAceptar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.buttonAceptar, "Modificar el registro seleccionado.");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(445, 18);
            this.buttonAplicar.Text = "Ver";
            this.toolTip1.SetToolTip(this.buttonAplicar, "Ver los detalles sin posibilidad de modificarlos.");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCuentaCorriente);
            this.panel1.Location = new System.Drawing.Point(0, 343);
            this.panel1.Size = new System.Drawing.Size(616, 52);
            this.panel1.Controls.SetChildIndex(this.buttonCuentaCorriente, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(364, 18);
            this.buttonCancelar.Text = "Salir";
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir.");
            // 
            // groupBoxClienteNuevo
            // 
            this.groupBoxClienteNuevo.Controls.Add(this.buttonAgregar);
            this.groupBoxClienteNuevo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxClienteNuevo.Name = "groupBoxClienteNuevo";
            this.groupBoxClienteNuevo.Size = new System.Drawing.Size(135, 45);
            this.groupBoxClienteNuevo.TabIndex = 1;
            this.groupBoxClienteNuevo.TabStop = false;
            this.groupBoxClienteNuevo.Text = "Proveedor Nuevo";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(6, 16);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(123, 23);
            this.buttonAgregar.TabIndex = 0;
            this.buttonAgregar.Text = "Agregar un Proveedor";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.ButtonAgregarClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCUIT);
            this.groupBox2.Controls.Add(this.maskedTextBoxCUIT);
            this.groupBox2.Location = new System.Drawing.Point(153, 12);
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
            this.groupBox3.Location = new System.Drawing.Point(319, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 45);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por Razón Social o Nombre Fantasía";
            // 
            // buttonRazon
            // 
            this.buttonRazon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRazon.Enabled = false;
            this.buttonRazon.Location = new System.Drawing.Point(229, 16);
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
            this.textBoxRazon.Size = new System.Drawing.Size(217, 20);
            this.textBoxRazon.TabIndex = 0;
            this.textBoxRazon.Enter += new System.EventHandler(this.TextBoxRazonEnter);
            this.textBoxRazon.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxRazonKeyUp);
            this.textBoxRazon.Leave += new System.EventHandler(this.TextBoxRazonLeave);
            // 
            // ultraNumericEditor1
            // 
            this.ultraNumericEditor1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.buscarProveedoresBindingSource, "idProveedor", true));
            this.ultraNumericEditor1.Location = new System.Drawing.Point(238, 241);
            this.ultraNumericEditor1.Name = "ultraNumericEditor1";
            this.ultraNumericEditor1.Size = new System.Drawing.Size(100, 21);
            this.ultraNumericEditor1.TabIndex = 3;
            // 
            // buscarProveedoresBindingSource
            // 
            this.buscarProveedoresBindingSource.DataMember = "BuscarProveedores";
            this.buscarProveedoresBindingSource.DataSource = this.dsBuscarProveedores;
            // 
            // dsBuscarProveedores
            // 
            this.dsBuscarProveedores.DataSetName = "DsBuscarProveedores";
            this.dsBuscarProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ultraGrid
            // 
            this.ultraGrid.DataSource = this.buscarProveedoresBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGrid.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn2.Header.Caption = "Razón Social";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 254;
            ultraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn3.Header.Caption = "Nombre Fantasia";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 197;
            ultraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Width = 120;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4});
            ultraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraGrid.DisplayLayout.InterBandSpacing = 10;
            this.ultraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ultraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ultraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ultraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ultraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ultraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraGrid.DisplayLayout.UseFixedHeaders = true;
            this.ultraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ultraGrid.Location = new System.Drawing.Point(12, 63);
            this.ultraGrid.Name = "ultraGrid";
            this.ultraGrid.Size = new System.Drawing.Size(592, 291);
            this.ultraGrid.TabIndex = 5;
            this.ultraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.UltraGridInitializeRow);
            this.ultraGrid.AfterEnterEditMode += new System.EventHandler(this.ultraGrid_AfterEnterEditMode);
            this.ultraGrid.Click += new System.EventHandler(this.UltraGridClick);
            this.ultraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ultraGrid_KeyDown);
            // 
            // FormABCProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(615, 395);
            this.Controls.Add(this.ultraGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxClienteNuevo);
            this.Controls.Add(this.ultraNumericEditor1);
            this.MinimumSize = new System.Drawing.Size(581, 382);
            this.Name = "FormABCProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FormABCProveedoresLoad);
            this.Enter += new System.EventHandler(this.FormABCProveedoresEnter);
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
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid)).EndInit();
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
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditor1;
        private System.Windows.Forms.Button buttonCuentaCorriente;
        private WS.DsBuscarProveedores dsBuscarProveedores;
        private System.Windows.Forms.BindingSource buscarProveedoresBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid;
    }
}

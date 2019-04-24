namespace Cabina
{
    partial class FormBuscarContrato
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BuscarClientesYDireccion", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionCliente");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRazon = new System.Windows.Forms.Button();
            this.textBoxRazon = new System.Windows.Forms.TextBox();
            this.ultraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.buscarClientesYDireccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBuscarContrato = new Cabina.WS.DsBuscarContrato();
            this.ultraNumericEditor1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.buttonContrato = new System.Windows.Forms.Button();
            this.buttonCongtratoYDireccion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarClientesYDireccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(12, 17);
            this.buttonAceptar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.buttonAceptar, "Modificar el registro seleccionado.");
            this.buttonAceptar.Visible = false;
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(12, 18);
            this.buttonAplicar.Text = "Ver";
            this.toolTip1.SetToolTip(this.buttonAplicar, "Ver los detalles sin posibilidad de modificarlos.");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCongtratoYDireccion);
            this.panel1.Controls.Add(this.buttonContrato);
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Size = new System.Drawing.Size(893, 52);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonContrato, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCongtratoYDireccion, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(506, 18);
            this.buttonCancelar.Text = "Salir";
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir.");
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonRazon);
            this.groupBox3.Controls.Add(this.textBoxRazon);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 45);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por Razón Social,  Nombre Fantasía y/o Nombre del Contrato";
            // 
            // buttonRazon
            // 
            this.buttonRazon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRazon.Enabled = false;
            this.buttonRazon.Location = new System.Drawing.Point(412, 16);
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
            this.textBoxRazon.Size = new System.Drawing.Size(400, 20);
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
            this.ultraGrid.DataSource = this.buscarClientesYDireccionBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGrid.DisplayLayout.Appearance = appearance1;
            this.ultraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 83;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Hidden = true;
            ultraGridColumn2.Width = 86;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 388;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Width = 87;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn5.Header.Caption = "Dirección";
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Width = 373;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5});
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
            this.ultraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ultraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
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
            this.ultraGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
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
            this.ultraGrid.Location = new System.Drawing.Point(12, 63);
            this.ultraGrid.Name = "ultraGrid";
            this.ultraGrid.Size = new System.Drawing.Size(869, 373);
            this.ultraGrid.TabIndex = 2;
            this.ultraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.UltraGridInitializeRow);
            this.ultraGrid.Click += new System.EventHandler(this.UltraGridClick);
            this.ultraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ultraGrid_KeyDown);
            // 
            // buscarClientesYDireccionBindingSource
            // 
            this.buscarClientesYDireccionBindingSource.DataMember = "BuscarClientesYDireccion";
            this.buscarClientesYDireccionBindingSource.DataSource = this.dsBuscarContrato;
            // 
            // dsBuscarContrato
            // 
            this.dsBuscarContrato.DataSetName = "DsBuscarContrato";
            this.dsBuscarContrato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraNumericEditor1
            // 
            this.ultraNumericEditor1.Location = new System.Drawing.Point(238, 241);
            this.ultraNumericEditor1.Name = "ultraNumericEditor1";
            this.ultraNumericEditor1.Size = new System.Drawing.Size(100, 21);
            this.ultraNumericEditor1.TabIndex = 3;
            // 
            // buttonContrato
            // 
            this.buttonContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonContrato.Enabled = false;
            this.buttonContrato.Location = new System.Drawing.Point(587, 18);
            this.buttonContrato.Name = "buttonContrato";
            this.buttonContrato.Size = new System.Drawing.Size(144, 23);
            this.buttonContrato.TabIndex = 3;
            this.buttonContrato.Text = "Sólo el Contrato";
            this.buttonContrato.UseVisualStyleBackColor = true;
            this.buttonContrato.Click += new System.EventHandler(this.ButtonContratoClick);
            // 
            // buttonCongtratoYDireccion
            // 
            this.buttonCongtratoYDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCongtratoYDireccion.Enabled = false;
            this.buttonCongtratoYDireccion.Location = new System.Drawing.Point(737, 18);
            this.buttonCongtratoYDireccion.Name = "buttonCongtratoYDireccion";
            this.buttonCongtratoYDireccion.Size = new System.Drawing.Size(144, 23);
            this.buttonCongtratoYDireccion.TabIndex = 4;
            this.buttonCongtratoYDireccion.Text = "Contrato y Dirección";
            this.buttonCongtratoYDireccion.UseVisualStyleBackColor = true;
            this.buttonCongtratoYDireccion.Click += new System.EventHandler(this.ButtonCongtratoYDireccionClick);
            // 
            // FormBuscarContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(892, 476);
            this.Controls.Add(this.ultraGrid);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ultraNumericEditor1);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "FormBuscarContrato";
            this.Text = "Contratos";
            this.Enter += new System.EventHandler(this.FormABCClientesEnter);
            this.Controls.SetChildIndex(this.ultraNumericEditor1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraGrid, 0);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarClientesYDireccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonRazon;
        private System.Windows.Forms.TextBox textBoxRazon;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditor1;
        private System.Windows.Forms.BindingSource buscarClientesYDireccionBindingSource;
        private WS.DsBuscarContrato dsBuscarContrato;
        private System.Windows.Forms.Button buttonCongtratoYDireccion;
        private System.Windows.Forms.Button buttonContrato;
    }
}

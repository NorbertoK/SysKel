namespace Administración
{
    partial class FormFacturacionMensualClientes
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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TandasDeFacturacion", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTandaDeFacturacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            this.ultraDateTimeEditorPeriodo = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraLabelPeriodo = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelTandaDeFacturacion = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelMensaje = new Infragistics.Win.Misc.UltraLabel();
            this.dsTandasDeFacturacion = new Administración.WS.DsTandasDeFacturacion();
            this.tandasDeFacturacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraComboTandasDeFacturacion = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTandasDeFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tandasDeFacturacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboTandasDeFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(253, 19);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Enabled = true;
            this.buttonAplicar.Location = new System.Drawing.Point(253, 19);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAplicar.Text = "Salir";
            this.toolTip1.SetToolTip(this.buttonAplicar, "Cerrar esta ventana.");
            this.buttonAplicar.Visible = false;
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Size = new System.Drawing.Size(343, 53);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(172, 19);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ultraDateTimeEditorPeriodo
            // 
            this.ultraDateTimeEditorPeriodo.DateTime = new System.DateTime(2018, 2, 27, 13, 16, 38, 0);
            this.ultraDateTimeEditorPeriodo.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.OnMouseEnter;
            this.ultraDateTimeEditorPeriodo.FormatProvider = new System.Globalization.CultureInfo("es-AR");
            this.ultraDateTimeEditorPeriodo.Location = new System.Drawing.Point(146, 14);
            this.ultraDateTimeEditorPeriodo.MaskInput = "{LOC}mm/yyyy";
            this.ultraDateTimeEditorPeriodo.Name = "ultraDateTimeEditorPeriodo";
            this.ultraDateTimeEditorPeriodo.Size = new System.Drawing.Size(71, 21);
            this.ultraDateTimeEditorPeriodo.TabIndex = 1;
            this.ultraDateTimeEditorPeriodo.Value = new System.DateTime(2018, 2, 27, 13, 16, 38, 0);
            // 
            // ultraLabelPeriodo
            // 
            appearance1.TextHAlignAsString = "Left";
            this.ultraLabelPeriodo.Appearance = appearance1;
            this.ultraLabelPeriodo.Location = new System.Drawing.Point(42, 18);
            this.ultraLabelPeriodo.Name = "ultraLabelPeriodo";
            this.ultraLabelPeriodo.Size = new System.Drawing.Size(98, 14);
            this.ultraLabelPeriodo.TabIndex = 2;
            this.ultraLabelPeriodo.Text = "Período a Facturar";
            // 
            // ultraLabelTandaDeFacturacion
            // 
            appearance2.TextHAlignAsString = "Left";
            this.ultraLabelTandaDeFacturacion.Appearance = appearance2;
            this.ultraLabelTandaDeFacturacion.Location = new System.Drawing.Point(26, 45);
            this.ultraLabelTandaDeFacturacion.Name = "ultraLabelTandaDeFacturacion";
            this.ultraLabelTandaDeFacturacion.Size = new System.Drawing.Size(114, 14);
            this.ultraLabelTandaDeFacturacion.TabIndex = 8;
            this.ultraLabelTandaDeFacturacion.Text = "Tanda de Facturación";
            // 
            // ultraLabelMensaje
            // 
            appearance3.TextHAlignAsString = "Center";
            this.ultraLabelMensaje.Appearance = appearance3;
            this.ultraLabelMensaje.Location = new System.Drawing.Point(26, 69);
            this.ultraLabelMensaje.Name = "ultraLabelMensaje";
            this.ultraLabelMensaje.Size = new System.Drawing.Size(279, 22);
            this.ultraLabelMensaje.TabIndex = 12;
            // 
            // dsTandasDeFacturacion
            // 
            this.dsTandasDeFacturacion.DataSetName = "DsTandasDeFacturacion";
            this.dsTandasDeFacturacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tandasDeFacturacionBindingSource
            // 
            this.tandasDeFacturacionBindingSource.DataMember = "TandasDeFacturacion";
            this.tandasDeFacturacionBindingSource.DataSource = this.dsTandasDeFacturacion;
            // 
            // ultraComboTandasDeFacturacion
            // 
            this.ultraComboTandasDeFacturacion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.ultraComboTandasDeFacturacion.DataSource = this.tandasDeFacturacionBindingSource;
            appearance5.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Appearance = appearance5;
            this.ultraComboTandasDeFacturacion.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 92;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 163;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn3.Width = 44;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3});
            this.ultraComboTandasDeFacturacion.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraComboTandasDeFacturacion.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraComboTandasDeFacturacion.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboTandasDeFacturacion.DisplayLayout.MaxBandDepth = 5;
            appearance6.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.ActiveCellAppearance = appearance6;
            appearance7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance7.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.ActiveRowAppearance = appearance7;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance8.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.CardAreaAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.CellAppearance = appearance9;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance10.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance10.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance11.ForeColor = System.Drawing.Color.Red;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.RowSelectorAppearance = appearance11;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.SelectedCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.SelectedRowAppearance = appearance13;
            appearance14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboTandasDeFacturacion.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance14;
            this.ultraComboTandasDeFacturacion.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboTandasDeFacturacion.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboTandasDeFacturacion.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboTandasDeFacturacion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboTandasDeFacturacion.DisplayMember = "Nombre";
            this.ultraComboTandasDeFacturacion.LimitToList = true;
            this.ultraComboTandasDeFacturacion.Location = new System.Drawing.Point(146, 41);
            this.ultraComboTandasDeFacturacion.Name = "ultraComboTandasDeFacturacion";
            this.ultraComboTandasDeFacturacion.Size = new System.Drawing.Size(182, 22);
            this.ultraComboTandasDeFacturacion.TabIndex = 15;
            this.ultraComboTandasDeFacturacion.ValueMember = "idTandaDeFacturacion";
            this.ultraComboTandasDeFacturacion.ValueChanged += new System.EventHandler(this.UltraComboTandasDeFacturacionValueChanged);
            // 
            // FormFacturacionMensualClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(334, 119);
            this.Controls.Add(this.ultraLabelMensaje);
            this.Controls.Add(this.ultraComboTandasDeFacturacion);
            this.Controls.Add(this.ultraDateTimeEditorPeriodo);
            this.Controls.Add(this.ultraLabelTandaDeFacturacion);
            this.Controls.Add(this.ultraLabelPeriodo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(350, 158);
            this.MinimumSize = new System.Drawing.Size(350, 158);
            this.Name = "FormFacturacionMensualClientes";
            this.Text = "Facturación Mensual de Clientes";
            this.Load += new System.EventHandler(this.FormFacturacionMensualAfiliadosLoad);
            this.Controls.SetChildIndex(this.ultraLabelPeriodo, 0);
            this.Controls.SetChildIndex(this.ultraLabelTandaDeFacturacion, 0);
            this.Controls.SetChildIndex(this.ultraDateTimeEditorPeriodo, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraComboTandasDeFacturacion, 0);
            this.Controls.SetChildIndex(this.ultraLabelMensaje, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTandasDeFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tandasDeFacturacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboTandasDeFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorPeriodo;
        private Infragistics.Win.Misc.UltraLabel ultraLabelPeriodo;
        private Infragistics.Win.Misc.UltraLabel ultraLabelTandaDeFacturacion;
        private Infragistics.Win.Misc.UltraLabel ultraLabelMensaje;
        private WS.DsTandasDeFacturacion dsTandasDeFacturacion;
        private System.Windows.Forms.BindingSource tandasDeFacturacionBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboTandasDeFacturacion;
    }
}

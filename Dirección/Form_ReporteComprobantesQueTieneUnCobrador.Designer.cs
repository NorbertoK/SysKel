namespace Dirección
{
    partial class FormReporteComprobantesQueTieneUnCobrador
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
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cargo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            this.dsEmpleadosLista = new Dirección.WS.DsEmpleadosLista();
            this.empleadosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraComboCobradores = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboCobradores)).BeginInit();
            this.SuspendLayout();
            // 
            // dsEmpleadosLista
            // 
            this.dsEmpleadosLista.DataSetName = "DsEmpleadosLista";
            this.dsEmpleadosLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosListaBindingSource
            // 
            this.empleadosListaBindingSource.DataMember = "EmpleadosLista";
            this.empleadosListaBindingSource.DataSource = this.dsEmpleadosLista;
            // 
            // ultraComboCobradores
            // 
            this.ultraComboCobradores.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ultraComboCobradores.DataSource = this.empleadosListaBindingSource;
            appearance10.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboCobradores.DisplayLayout.Appearance = appearance10;
            this.ultraComboCobradores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 21;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Hidden = true;
            ultraGridColumn2.Width = 33;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn3.Width = 17;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn4.Width = 33;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn5.Width = 33;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Width = 170;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6});
            this.ultraComboCobradores.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraComboCobradores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraComboCobradores.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboCobradores.DisplayLayout.MaxBandDepth = 5;
            appearance6.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboCobradores.DisplayLayout.Override.ActiveCellAppearance = appearance6;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboCobradores.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ultraComboCobradores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboCobradores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboCobradores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboCobradores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboCobradores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboCobradores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboCobradores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboCobradores.DisplayLayout.Override.CardAreaAppearance = appearance2;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboCobradores.DisplayLayout.Override.CellAppearance = appearance9;
            this.ultraComboCobradores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance5.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboCobradores.DisplayLayout.Override.HeaderAppearance = appearance5;
            this.ultraComboCobradores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance4.ForeColor = System.Drawing.Color.Red;
            this.ultraComboCobradores.DisplayLayout.Override.RowSelectorAppearance = appearance4;
            this.ultraComboCobradores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboCobradores.DisplayLayout.Override.SelectedCellAppearance = appearance1;
            appearance8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance8.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboCobradores.DisplayLayout.Override.SelectedRowAppearance = appearance8;
            appearance7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboCobradores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance7;
            this.ultraComboCobradores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboCobradores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboCobradores.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboCobradores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboCobradores.DisplayMember = "ApelNomb";
            this.ultraComboCobradores.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Default;
            this.ultraComboCobradores.Location = new System.Drawing.Point(67, 12);
            this.ultraComboCobradores.Name = "ultraComboCobradores";
            this.ultraComboCobradores.Size = new System.Drawing.Size(189, 22);
            this.ultraComboCobradores.TabIndex = 0;
            this.ultraComboCobradores.ValueMember = "idEmpleado";
            this.ultraComboCobradores.ItemNotInList += new Infragistics.Win.UltraWinGrid.ItemNotInListEventHandler(UltraComboCobradoresItemNotInList);
            this.ultraComboCobradores.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(UltraComboCobradoresFilterRow);
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(13, 14);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(51, 14);
            this.ultraLabel1.TabIndex = 1;
            this.ultraLabel1.Text = "Cobrador";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(100, 45);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelarClick);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(181, 45);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 3;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // FormReporteComprobantesQueTieneUnCobrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 80);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.ultraComboCobradores);
            this.Name = "FormReporteComprobantesQueTieneUnCobrador";
            this.Text = "Comprobantes que tiene el cobrador";
            this.Load += new System.EventHandler(this.FormReporteComprobantesQueTieneUnCobradorLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboCobradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WS.DsEmpleadosLista dsEmpleadosLista;
        private System.Windows.Forms.BindingSource empleadosListaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboCobradores;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
    }
}
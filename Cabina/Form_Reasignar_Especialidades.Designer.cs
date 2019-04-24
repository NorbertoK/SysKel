namespace Cabina
{
    partial class FormReasignarEspecialidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Diagnosticos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnostico");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnosticoCategoria", -1, "ultraDropDownEspecialidades");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("DiagnosticosCategoria", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnosticoCategoria");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Diagnosticos_DiagnosticosCategoria");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Diagnosticos_DiagnosticosCategoria", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnostico");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnosticoCategoria");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            this.dsDiagnosticos = new Cabina.WS.DsDiagnosticos();
            this.diagnosticosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticosCategoriaUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDropDownEspecialidades = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.diagnosticosCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiagnosticos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosCategoriaUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEspecialidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosCategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(473, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(392, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 527);
            this.panel1.Size = new System.Drawing.Size(563, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(311, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsDiagnosticos
            // 
            this.dsDiagnosticos.DataSetName = "DsDiagnosticos";
            this.dsDiagnosticos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnosticosBindingSource
            // 
            this.diagnosticosBindingSource.DataMember = "Diagnosticos";
            this.diagnosticosBindingSource.DataSource = this.dsDiagnosticos;
            // 
            // diagnosticosCategoriaUltraGrid
            // 
            this.diagnosticosCategoriaUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diagnosticosCategoriaUltraGrid.DataSource = this.diagnosticosBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Appearance = appearance1;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 73;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn2.Header.Caption = "Especialidad";
            ultraGridColumn2.Header.VisiblePosition = 2;
            ultraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn2.Width = 184;
            ultraGridColumn3.Header.Caption = "Diagnóstico";
            ultraGridColumn3.Header.VisiblePosition = 1;
            ultraGridColumn3.Width = 358;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3});
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.diagnosticosCategoriaUltraGrid.Location = new System.Drawing.Point(0, 1);
            this.diagnosticosCategoriaUltraGrid.Name = "diagnosticosCategoriaUltraGrid";
            this.diagnosticosCategoriaUltraGrid.Size = new System.Drawing.Size(563, 536);
            this.diagnosticosCategoriaUltraGrid.TabIndex = 2;
            this.diagnosticosCategoriaUltraGrid.AfterEnterEditMode += new System.EventHandler(this.DiagnosticosCategoriaUltraGridAfterEnterEditMode);
            this.diagnosticosCategoriaUltraGrid.AfterRowsDeleted += new System.EventHandler(this.DiagnosticosCategoriaUltraGridAfterRowsDeleted);
            // 
            // ultraDropDownEspecialidades
            // 
            this.ultraDropDownEspecialidades.DataSource = this.diagnosticosCategoriaBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownEspecialidades.DisplayLayout.Appearance = appearance11;
            this.ultraDropDownEspecialidades.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn4.Header.VisiblePosition = 0;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn5.Header.VisiblePosition = 1;
            ultraGridColumn6.Header.VisiblePosition = 2;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6});
            ultraGridBand2.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn7.Header.VisiblePosition = 0;
            ultraGridColumn8.Header.VisiblePosition = 1;
            ultraGridColumn9.Header.VisiblePosition = 2;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9});
            this.ultraDropDownEspecialidades.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraDropDownEspecialidades.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownEspecialidades.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownEspecialidades.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownEspecialidades.DisplayLayout.MaxBandDepth = 5;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.ActiveRowAppearance = appearance13;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.CellAppearance = appearance15;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.SelectedCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownEspecialidades.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance20;
            this.ultraDropDownEspecialidades.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownEspecialidades.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownEspecialidades.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownEspecialidades.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownEspecialidades.DisplayMember = "Nombre";
            this.ultraDropDownEspecialidades.DropDownWidth = 250;
            this.ultraDropDownEspecialidades.Location = new System.Drawing.Point(71, 141);
            this.ultraDropDownEspecialidades.Name = "ultraDropDownEspecialidades";
            this.ultraDropDownEspecialidades.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownEspecialidades.TabIndex = 13;
            this.ultraDropDownEspecialidades.ValueMember = "idDiagnosticoCategoria";
            this.ultraDropDownEspecialidades.Visible = false;
            // 
            // diagnosticosCategoriaBindingSource
            // 
            this.diagnosticosCategoriaBindingSource.DataMember = "DiagnosticosCategoria";
            this.diagnosticosCategoriaBindingSource.DataSource = this.dsDiagnosticos;
            // 
            // FormReasignarEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(562, 575);
            this.Controls.Add(this.diagnosticosCategoriaUltraGrid);
            this.Controls.Add(this.ultraDropDownEspecialidades);
            this.Name = "FormReasignarEspecialidades";
            this.Text = "Reasignar Especialidades";
            this.Load += new System.EventHandler(this.FormReasignarEspecialidadesLoad);
            this.Controls.SetChildIndex(this.ultraDropDownEspecialidades, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.diagnosticosCategoriaUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsDiagnosticos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosCategoriaUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEspecialidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosCategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsDiagnosticos dsDiagnosticos;
        private System.Windows.Forms.BindingSource diagnosticosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid diagnosticosCategoriaUltraGrid;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownEspecialidades;
        private System.Windows.Forms.BindingSource diagnosticosCategoriaBindingSource;
    }
}

namespace Cabina
{
    partial class FormABCDiagnosticos
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("DiagnosticosCategoria", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnosticoCategoria");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Diagnosticos_DiagnosticosCategoria");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Diagnosticos_DiagnosticosCategoria", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnostico");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnosticoCategoria");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.dsDiagnosticos = new Cabina.WS.DsDiagnosticos();
            this.diagnosticosCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticosCategoriaUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiagnosticos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosCategoriaUltraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(221, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(140, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Size = new System.Drawing.Size(311, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(59, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsDiagnosticos
            // 
            this.dsDiagnosticos.DataSetName = "DsDiagnosticos";
            this.dsDiagnosticos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnosticosCategoriaBindingSource
            // 
            this.diagnosticosCategoriaBindingSource.DataMember = "DiagnosticosCategoria";
            this.diagnosticosCategoriaBindingSource.DataSource = this.dsDiagnosticos;
            // 
            // diagnosticosCategoriaUltraGrid
            // 
            this.diagnosticosCategoriaUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diagnosticosCategoriaUltraGrid.DataSource = this.diagnosticosCategoriaBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Appearance = appearance1;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 156;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 271;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3});
            appearance2.FontData.BoldAsString = "True";
            appearance2.FontData.SizeInPoints = 11F;
            appearance2.TextHAlignAsString = "Left";
            ultraGridBand1.Header.Appearance = appearance2;
            ultraGridBand1.Header.Caption = "Especialidades";
            ultraGridBand1.HeaderVisible = true;
            ultraGridBand2.ColHeadersVisible = false;
            ultraGridColumn4.Header.VisiblePosition = 0;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn4.Width = 65;
            ultraGridColumn5.Header.VisiblePosition = 1;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn5.Width = 107;
            ultraGridColumn6.Header.VisiblePosition = 2;
            ultraGridColumn6.Width = 252;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6});
            appearance3.FontData.BoldAsString = "True";
            appearance3.FontData.SizeInPoints = 11F;
            appearance3.TextHAlignAsString = "Left";
            ultraGridBand2.Header.Appearance = appearance3;
            ultraGridBand2.Header.Caption = "Diagnósticos";
            ultraGridBand2.HeaderVisible = true;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance4.BackColor = System.Drawing.SystemColors.Window;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance5.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance5;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance6.BackColor = System.Drawing.Color.Transparent;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance6;
            appearance7.BackColor = System.Drawing.SystemColors.Control;
            appearance7.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.CellAppearance = appearance7;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance8.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance8.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance8;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance9.ForeColor = System.Drawing.Color.Red;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance9;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance10;
            appearance11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance11.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance11;
            appearance12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance12;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.diagnosticosCategoriaUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.diagnosticosCategoriaUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.diagnosticosCategoriaUltraGrid.Name = "diagnosticosCategoriaUltraGrid";
            this.diagnosticosCategoriaUltraGrid.Size = new System.Drawing.Size(311, 426);
            this.diagnosticosCategoriaUltraGrid.TabIndex = 2;
            this.diagnosticosCategoriaUltraGrid.AfterEnterEditMode += new System.EventHandler(this.DiagnosticosCategoriaUltraGridAfterEnterEditMode);
            this.diagnosticosCategoriaUltraGrid.AfterRowsDeleted += new System.EventHandler(this.DiagnosticosCategoriaUltraGridAfterRowsDeleted);
            this.diagnosticosCategoriaUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.diagnosticosCategoriaUltraGrid_KeyDown);
            // 
            // FormABCDiagnosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(310, 464);
            this.Controls.Add(this.diagnosticosCategoriaUltraGrid);
            this.Name = "FormABCDiagnosticos";
            this.Text = "Diagnósticos";
            this.Load += new System.EventHandler(this.FormABCDiagnosticosLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.diagnosticosCategoriaUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsDiagnosticos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosCategoriaUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsDiagnosticos dsDiagnosticos;
        private System.Windows.Forms.BindingSource diagnosticosCategoriaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid diagnosticosCategoriaUltraGrid;
    }
}

namespace Administración
{
    partial class FormReporteBajasAutomaticas
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FechasBajasAutomaticas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.dsFechasBajasAutomaticas = new Administración.WS.DsFechasBajasAutomaticas();
            this.fechasBajasAutomaticasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechasBajasAutomaticasUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFechasBajasAutomaticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechasBajasAutomaticasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechasBajasAutomaticasUltraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(165, 16);
            this.buttonAceptar.Size = new System.Drawing.Size(86, 23);
            this.buttonAceptar.Text = "Ver el Reporte";
            this.toolTip1.SetToolTip(this.buttonAceptar, "Ver el Reporte");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(84, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 280);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(84, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsFechasBajasAutomaticas
            // 
            this.dsFechasBajasAutomaticas.DataSetName = "DsFechasBajasAutomaticas";
            this.dsFechasBajasAutomaticas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fechasBajasAutomaticasBindingSource
            // 
            this.fechasBajasAutomaticasBindingSource.DataMember = "FechasBajasAutomaticas";
            this.fechasBajasAutomaticasBindingSource.DataSource = this.dsFechasBajasAutomaticas;
            // 
            // fechasBajasAutomaticasUltraGrid
            // 
            this.fechasBajasAutomaticasUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fechasBajasAutomaticasUltraGrid.DataSource = this.fechasBajasAutomaticasBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Appearance = appearance1;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance11.TextHAlignAsString = "Center";
            ultraGridColumn1.CellAppearance = appearance11;
            ultraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.MaskInput = "dd/mm/yyyy hh:mm";
            ultraGridColumn1.Width = 245;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1});
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.fechasBajasAutomaticasUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.fechasBajasAutomaticasUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fechasBajasAutomaticasUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.fechasBajasAutomaticasUltraGrid.Name = "fechasBajasAutomaticasUltraGrid";
            this.fechasBajasAutomaticasUltraGrid.Size = new System.Drawing.Size(266, 290);
            this.fechasBajasAutomaticasUltraGrid.TabIndex = 2;
            this.fechasBajasAutomaticasUltraGrid.Click += new System.EventHandler(this.FechasBajasAutomaticasUltraGridClick);
            // 
            // FormReporteBajasAutomaticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(265, 328);
            this.Controls.Add(this.fechasBajasAutomaticasUltraGrid);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "FormReporteBajasAutomaticas";
            this.Text = "Bajas Automáticas";
            this.Load += new System.EventHandler(this.FormReporteBajasAutomaticasLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.fechasBajasAutomaticasUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsFechasBajasAutomaticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechasBajasAutomaticasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechasBajasAutomaticasUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Administración.WS.DsFechasBajasAutomaticas dsFechasBajasAutomaticas;
        private System.Windows.Forms.BindingSource fechasBajasAutomaticasBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid fechasBajasAutomaticasUltraGrid;
    }
}

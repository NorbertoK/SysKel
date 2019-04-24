namespace Administración
{
    partial class FormReporteLiquidacionEntidad
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ReportLiquidacionTercerizada", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLiquidacionTercerizada");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Entidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Grabador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ComprobantesCobrados");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ComprobantesRechazados");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteCobrado");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteRechazado");
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
            this.dsReportLiquidacionEntidad = new Administración.WS.DsReportLiquidacionEntidad();
            this.reportLiquidacionTercerizadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportLiquidacionTercerizadaUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportLiquidacionEntidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportLiquidacionTercerizadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportLiquidacionTercerizadaUltraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(659, 16);
            this.buttonAceptar.Size = new System.Drawing.Size(105, 23);
            this.buttonAceptar.Text = "Ver el Reporte";
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(33, 13);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Size = new System.Drawing.Size(779, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(578, 16);
            this.buttonCancelar.Text = "Salir";
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsReportLiquidacionEntidad
            // 
            this.dsReportLiquidacionEntidad.DataSetName = "DsReportLiquidacionEntidad";
            this.dsReportLiquidacionEntidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportLiquidacionTercerizadaBindingSource
            // 
            this.reportLiquidacionTercerizadaBindingSource.DataMember = "ReportLiquidacionTercerizada";
            this.reportLiquidacionTercerizadaBindingSource.DataSource = this.dsReportLiquidacionEntidad;
            // 
            // reportLiquidacionTercerizadaUltraGrid
            // 
            this.reportLiquidacionTercerizadaUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportLiquidacionTercerizadaUltraGrid.DataSource = this.reportLiquidacionTercerizadaBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Appearance = appearance1;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 35;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn2.MaskInput = "dd/mm/yyyy  hh:mm";
            ultraGridColumn2.Width = 97;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 172;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Width = 75;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Width = 137;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance2.TextHAlignAsString = "Right";
            ultraGridColumn6.CellAppearance = appearance2;
            ultraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn6.Header.Caption = "Cobrados";
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Width = 64;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance3.TextHAlignAsString = "Right";
            ultraGridColumn7.CellAppearance = appearance3;
            ultraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn7.Header.Caption = "Rechazados";
            ultraGridColumn7.Header.VisiblePosition = 7;
            ultraGridColumn7.Width = 73;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance4.TextHAlignAsString = "Right";
            ultraGridColumn8.CellAppearance = appearance4;
            ultraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn8.Header.Caption = "Cobrado";
            ultraGridColumn8.Header.VisiblePosition = 6;
            ultraGridColumn8.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn8.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn8.Width = 66;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance5.TextHAlignAsString = "Right";
            ultraGridColumn9.CellAppearance = appearance5;
            ultraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn9.Header.Caption = "Rechazado";
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn9.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn9.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn9.Width = 74;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9});
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance6.BackColor = System.Drawing.SystemColors.Window;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance6;
            appearance7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance7.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance7;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            appearance8.BackColor = System.Drawing.Color.Transparent;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.CellAppearance = appearance9;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance10.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance10.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance11.ForeColor = System.Drawing.Color.Red;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance11;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance13;
            appearance14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance14;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.reportLiquidacionTercerizadaUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.reportLiquidacionTercerizadaUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.reportLiquidacionTercerizadaUltraGrid.Location = new System.Drawing.Point(0, -2);
            this.reportLiquidacionTercerizadaUltraGrid.Name = "reportLiquidacionTercerizadaUltraGrid";
            this.reportLiquidacionTercerizadaUltraGrid.Size = new System.Drawing.Size(779, 409);
            this.reportLiquidacionTercerizadaUltraGrid.TabIndex = 2;
            this.reportLiquidacionTercerizadaUltraGrid.AfterEnterEditMode += new System.EventHandler(this.reportLiquidacionTercerizadaUltraGrid_AfterEnterEditMode);
            this.reportLiquidacionTercerizadaUltraGrid.Click += new System.EventHandler(this.ReportLiquidacionTercerizadaUltraGridClick);
            // 
            // FormReporteLiquidacionEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(778, 448);
            this.Controls.Add(this.reportLiquidacionTercerizadaUltraGrid);
            this.Name = "FormReporteLiquidacionEntidad";
            this.Text = "Liquidaciones de Entidades de Cobranza";
            this.Activated += new System.EventHandler(this.FormReporteLiquidacionEntidadActivated);
            this.Load += new System.EventHandler(this.FormReporteLiquidacionEntidadLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.reportLiquidacionTercerizadaUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsReportLiquidacionEntidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportLiquidacionTercerizadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportLiquidacionTercerizadaUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsReportLiquidacionEntidad dsReportLiquidacionEntidad;
        private System.Windows.Forms.BindingSource reportLiquidacionTercerizadaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid reportLiquidacionTercerizadaUltraGrid;
    }
}

namespace Cabina
{
    partial class FormABCTiposDeDestino
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeDestino", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ConPacienteABordo");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.dsTiposDeDestino = new Cabina.WS.DsTiposDeDestino();
            this.tiposDeDestinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposDeDestinoUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDestinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDestinoUltraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(203, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(122, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Size = new System.Drawing.Size(293, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(41, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsTiposDeDestino
            // 
            this.dsTiposDeDestino.DataSetName = "DsTiposDeDestino";
            this.dsTiposDeDestino.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposDeDestinoBindingSource
            // 
            this.tiposDeDestinoBindingSource.DataMember = "TiposDeDestino";
            this.tiposDeDestinoBindingSource.DataSource = this.dsTiposDeDestino;
            // 
            // tiposDeDestinoUltraGrid
            // 
            this.tiposDeDestinoUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tiposDeDestinoUltraGrid.DataSource = this.tiposDeDestinoBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Appearance = appearance1;
            this.tiposDeDestinoUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 140;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 147;
            ultraGridColumn3.DefaultCellValue = "False";
            ultraGridColumn3.Header.Caption = "Con paciente a bordo";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 125;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3});
            this.tiposDeDestinoUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.tiposDeDestinoUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.tiposDeDestinoUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.tiposDeDestinoUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.tiposDeDestinoUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.tiposDeDestinoUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tiposDeDestinoUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.tiposDeDestinoUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.tiposDeDestinoUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.tiposDeDestinoUltraGrid.Location = new System.Drawing.Point(0, -2);
            this.tiposDeDestinoUltraGrid.Name = "tiposDeDestinoUltraGrid";
            this.tiposDeDestinoUltraGrid.Size = new System.Drawing.Size(293, 292);
            this.tiposDeDestinoUltraGrid.TabIndex = 2;
            this.tiposDeDestinoUltraGrid.AfterEnterEditMode += new System.EventHandler(this.TiposDeDestinoUltraGridAfterEnterEditMode);
            this.tiposDeDestinoUltraGrid.AfterRowsDeleted += new System.EventHandler(this.TiposDeDestinoUltraGridAfterRowsDeleted);
            this.tiposDeDestinoUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tiposDeDestinoUltraGrid_KeyDown);
            // 
            // FormABCTiposDeDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(292, 328);
            this.Controls.Add(this.tiposDeDestinoUltraGrid);
            this.Name = "FormABCTiposDeDestino";
            this.Text = "Tipos de Destino";
            this.Load += new System.EventHandler(this.FormABCTiposDeDestinoLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tiposDeDestinoUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDestinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDestinoUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsTiposDeDestino dsTiposDeDestino;
        private System.Windows.Forms.BindingSource tiposDeDestinoBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid tiposDeDestinoUltraGrid;
    }
}

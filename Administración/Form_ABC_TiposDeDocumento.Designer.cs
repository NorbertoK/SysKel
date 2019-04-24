namespace Administración
{
    partial class FormABCTiposDeDocumento
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeDocumento", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.tiposDeDocumentoUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.tiposDeDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_TiposDeDocumento = new Administración.WS.DsTiposDeDocumento();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDocumentoUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_TiposDeDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(237, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(156, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Size = new System.Drawing.Size(327, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(75, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // tiposDeDocumentoUltraGrid
            // 
            this.tiposDeDocumentoUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tiposDeDocumentoUltraGrid.DataSource = this.tiposDeDocumentoBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Appearance = appearance1;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 199;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 107;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3});
            this.tiposDeDocumentoUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.tiposDeDocumentoUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.tiposDeDocumentoUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.tiposDeDocumentoUltraGrid.Location = new System.Drawing.Point(0, 1);
            this.tiposDeDocumentoUltraGrid.Name = "tiposDeDocumentoUltraGrid";
            this.tiposDeDocumentoUltraGrid.Size = new System.Drawing.Size(327, 289);
            this.tiposDeDocumentoUltraGrid.TabIndex = 2;
            this.tiposDeDocumentoUltraGrid.AfterEnterEditMode += new System.EventHandler(this.TiposDeDocumentoUltraGridAfterEnterEditMode);
            this.tiposDeDocumentoUltraGrid.AfterRowsDeleted += new System.EventHandler(this.TiposDeDocumentoUltraGridAfterRowsDeleted);
            this.tiposDeDocumentoUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tiposDeDocumentoUltraGrid_KeyDown);
            // 
            // tiposDeDocumentoBindingSource
            // 
            this.tiposDeDocumentoBindingSource.DataMember = "TiposDeDocumento";
            this.tiposDeDocumentoBindingSource.DataSource = this.ds_TiposDeDocumento;
            // 
            // ds_TiposDeDocumento
            // 
            this.ds_TiposDeDocumento.DataSetName = "DsTiposDeDocumento";
            this.ds_TiposDeDocumento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormABCTiposDeDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(326, 328);
            this.Controls.Add(this.tiposDeDocumentoUltraGrid);
            this.Name = "FormABCTiposDeDocumento";
            this.Text = "Tipos de Documento";
            this.Load += new System.EventHandler(this.FormABCTiposDeDocumentoLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tiposDeDocumentoUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDocumentoUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_TiposDeDocumento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid tiposDeDocumentoUltraGrid;
        private System.Windows.Forms.BindingSource tiposDeDocumentoBindingSource;
        private Administración.WS.DsTiposDeDocumento ds_TiposDeDocumento;
    }
}

namespace Administración
{
    partial class FormABCTandasDeFacturacion
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TandasDeFacturacion", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTandaDeFacturacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.ds_TandasDeFacturacion = new Administración.WS.DsTandasDeFacturacion();
            this.tandasDeFacturacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tandasDeFacturacionUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_TandasDeFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tandasDeFacturacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tandasDeFacturacionUltraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 280);
            // 
            // buttonCancelar
            // 
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ds_TandasDeFacturacion
            // 
            this.ds_TandasDeFacturacion.DataSetName = "DsTandasDeFacturacion";
            this.ds_TandasDeFacturacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tandasDeFacturacionBindingSource
            // 
            this.tandasDeFacturacionBindingSource.DataMember = "TandasDeFacturacion";
            this.tandasDeFacturacionBindingSource.DataSource = this.ds_TandasDeFacturacion;
            // 
            // tandasDeFacturacionUltraGrid
            // 
            this.tandasDeFacturacionUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tandasDeFacturacionUltraGrid.DataSource = this.tandasDeFacturacionBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Appearance = appearance1;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 159;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 245;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2});
            this.tandasDeFacturacionUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.tandasDeFacturacionUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.tandasDeFacturacionUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.tandasDeFacturacionUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.tandasDeFacturacionUltraGrid.Name = "tandasDeFacturacionUltraGrid";
            this.tandasDeFacturacionUltraGrid.Size = new System.Drawing.Size(266, 290);
            this.tandasDeFacturacionUltraGrid.TabIndex = 2;
            this.tandasDeFacturacionUltraGrid.AfterEnterEditMode += new System.EventHandler(this.TandasDeFacturacionUltraGridAfterEnterEditMode);
            this.tandasDeFacturacionUltraGrid.AfterRowsDeleted += new System.EventHandler(this.TandasDeFacturacionUltraGridAfterRowsDeleted);
            this.tandasDeFacturacionUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tandasDeFacturacionUltraGrid_KeyDown);
            // 
            // FormABCTandasDeFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(265, 328);
            this.Controls.Add(this.tandasDeFacturacionUltraGrid);
            this.Name = "FormABCTandasDeFacturacion";
            this.Text = "Tandas de Facturación";
            this.Load += new System.EventHandler(this.FormABCTandasDeFacturacionLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tandasDeFacturacionUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_TandasDeFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tandasDeFacturacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tandasDeFacturacionUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Administración.WS.DsTandasDeFacturacion ds_TandasDeFacturacion;
        private System.Windows.Forms.BindingSource tandasDeFacturacionBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid tandasDeFacturacionUltraGrid;
    }
}

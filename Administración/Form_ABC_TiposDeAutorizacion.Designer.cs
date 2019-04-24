namespace Administración
{
    partial class FormABCTiposDeAutorizacion
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeAutorizacion", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeAutorizacion");
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
            this.ds_TiposDeAutorizacion = new Administración.WS.DsTiposDeAutorizacion();
            this.tiposDeAutorizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposDeAutorizacionUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_TiposDeAutorizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeAutorizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeAutorizacionUltraGrid)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 234);
            // 
            // buttonCancelar
            // 
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ds_TiposDeAutorizacion
            // 
            this.ds_TiposDeAutorizacion.DataSetName = "DsTiposDeAutorizacion";
            this.ds_TiposDeAutorizacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposDeAutorizacionBindingSource
            // 
            this.tiposDeAutorizacionBindingSource.DataMember = "TiposDeAutorizacion";
            this.tiposDeAutorizacionBindingSource.DataSource = this.ds_TiposDeAutorizacion;
            // 
            // tiposDeAutorizacionUltraGrid
            // 
            this.tiposDeAutorizacionUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tiposDeAutorizacionUltraGrid.DataSource = this.tiposDeAutorizacionBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Appearance = appearance1;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 136;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 245;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2});
            ultraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.tiposDeAutorizacionUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.tiposDeAutorizacionUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.tiposDeAutorizacionUltraGrid.Name = "tiposDeAutorizacionUltraGrid";
            this.tiposDeAutorizacionUltraGrid.Size = new System.Drawing.Size(266, 244);
            this.tiposDeAutorizacionUltraGrid.TabIndex = 2;
            this.tiposDeAutorizacionUltraGrid.AfterEnterEditMode += new System.EventHandler(this.TiposDeAutorizacionUltraGridAfterEnterEditMode);
            this.tiposDeAutorizacionUltraGrid.AfterRowsDeleted += new System.EventHandler(this.TiposDeAutorizacionUltraGridAfterRowsDeleted);
            this.tiposDeAutorizacionUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tiposDeAutorizacionUltraGrid_KeyDown);
            // 
            // FormABCTiposDeAutorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(265, 282);
            this.Controls.Add(this.tiposDeAutorizacionUltraGrid);
            this.Name = "FormABCTiposDeAutorizacion";
            this.Text = "Tipos de Autorización";
            this.Load += new System.EventHandler(this.FormABCTiposDeAutorizacionLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tiposDeAutorizacionUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_TiposDeAutorizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeAutorizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeAutorizacionUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Administración.WS.DsTiposDeAutorizacion ds_TiposDeAutorizacion;
        private System.Windows.Forms.BindingSource tiposDeAutorizacionBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid tiposDeAutorizacionUltraGrid;
    }
}

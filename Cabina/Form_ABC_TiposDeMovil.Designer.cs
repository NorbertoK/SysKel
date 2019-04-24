namespace Cabina
{
    partial class FormABCTiposDeMovil
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeMovil", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeMovil");
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
            this.dsTiposDeMovil = new Cabina.WS.DsTiposDeMovil();
            this.tiposDeMovilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposDeMovilUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeMovilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeMovilUltraGrid)).BeginInit();
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
            // dsTiposDeMovil
            // 
            this.dsTiposDeMovil.DataSetName = "DsTiposDeMovil";
            this.dsTiposDeMovil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposDeMovilBindingSource
            // 
            this.tiposDeMovilBindingSource.DataMember = "TiposDeMovil";
            this.tiposDeMovilBindingSource.DataSource = this.dsTiposDeMovil;
            // 
            // tiposDeMovilUltraGrid
            // 
            this.tiposDeMovilUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tiposDeMovilUltraGrid.DataSource = this.tiposDeMovilBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.tiposDeMovilUltraGrid.DisplayLayout.Appearance = appearance1;
            this.tiposDeMovilUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 115;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 245;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2});
            this.tiposDeMovilUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.tiposDeMovilUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.tiposDeMovilUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.tiposDeMovilUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.tiposDeMovilUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.tiposDeMovilUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tiposDeMovilUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.tiposDeMovilUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.tiposDeMovilUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.tiposDeMovilUltraGrid.Location = new System.Drawing.Point(0, -1);
            this.tiposDeMovilUltraGrid.Name = "tiposDeMovilUltraGrid";
            this.tiposDeMovilUltraGrid.Size = new System.Drawing.Size(266, 291);
            this.tiposDeMovilUltraGrid.TabIndex = 2;
            this.tiposDeMovilUltraGrid.AfterEnterEditMode += new System.EventHandler(this.TiposDeMovilUltraGridAfterEnterEditMode);
            this.tiposDeMovilUltraGrid.BeforeRowsDeleted += new Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventHandler(this.TiposDeMovilUltraGridBeforeRowsDeleted);
            this.tiposDeMovilUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tiposDeMovilUltraGrid_KeyDown);
            // 
            // FormABCTiposDeMovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(265, 328);
            this.Controls.Add(this.tiposDeMovilUltraGrid);
            this.Name = "FormABCTiposDeMovil";
            this.Text = "Tipos de Móvil";
            this.Load += new System.EventHandler(this.FormABCTiposDeMovilLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tiposDeMovilUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeMovilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeMovilUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsTiposDeMovil dsTiposDeMovil;
        private System.Windows.Forms.BindingSource tiposDeMovilBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid tiposDeMovilUltraGrid;
    }
}

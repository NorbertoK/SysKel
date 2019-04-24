namespace Administración
{
    partial class FormABCOcupaciones
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Ocupaciones", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idOcupacion");
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
            this.ds_Ocupaciones = new Administración.WS.DsOcupaciones();
            this.ocupacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocupacionesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Ocupaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocupacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocupacionesUltraGrid)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 330);
            // 
            // buttonCancelar
            // 
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ds_Ocupaciones
            // 
            this.ds_Ocupaciones.DataSetName = "DsOcupaciones";
            this.ds_Ocupaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ocupacionesBindingSource
            // 
            this.ocupacionesBindingSource.DataMember = "Ocupaciones";
            this.ocupacionesBindingSource.DataSource = this.ds_Ocupaciones;
            // 
            // ocupacionesUltraGrid
            // 
            this.ocupacionesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ocupacionesUltraGrid.DataSource = this.ocupacionesBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ocupacionesUltraGrid.DisplayLayout.Appearance = appearance1;
            this.ocupacionesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 75;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 245;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2});
            this.ocupacionesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ocupacionesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.ocupacionesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.ocupacionesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ocupacionesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ocupacionesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ocupacionesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ocupacionesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ocupacionesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ocupacionesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ocupacionesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ocupacionesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ocupacionesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ocupacionesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ocupacionesUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.ocupacionesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ocupacionesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ocupacionesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ocupacionesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ocupacionesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ocupacionesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ocupacionesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ocupacionesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ocupacionesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ocupacionesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ocupacionesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.ocupacionesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ocupacionesUltraGrid.Location = new System.Drawing.Point(0, 2);
            this.ocupacionesUltraGrid.Name = "ocupacionesUltraGrid";
            this.ocupacionesUltraGrid.Size = new System.Drawing.Size(266, 338);
            this.ocupacionesUltraGrid.TabIndex = 2;
            this.ocupacionesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.OcupacionesUltraGridAfterEnterEditMode);
            this.ocupacionesUltraGrid.AfterRowsDeleted += new System.EventHandler(this.OcupacionesUltraGridAfterRowsDeleted);
            this.ocupacionesUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ocupacionesUltraGrid_KeyDown);
            // 
            // FormABCOcupaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(265, 378);
            this.Controls.Add(this.ocupacionesUltraGrid);
            this.Name = "FormABCOcupaciones";
            this.Text = "Ocupaciones";
            this.Load += new System.EventHandler(this.FormABCOcupacionesLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ocupacionesUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_Ocupaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocupacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocupacionesUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Administración.WS.DsOcupaciones ds_Ocupaciones;
        private System.Windows.Forms.BindingSource ocupacionesBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid ocupacionesUltraGrid;
    }
}

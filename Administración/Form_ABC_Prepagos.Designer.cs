namespace Administración
{
    partial class FormABCPrepagos
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Prepagos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.prepagosUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.prepagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Prepagos = new Administración.WS.DsPrepagos();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Prepagos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(269, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(188, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 366);
            this.panel1.Size = new System.Drawing.Size(359, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(107, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // prepagosUltraGrid
            // 
            this.prepagosUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prepagosUltraGrid.DataSource = this.prepagosBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.prepagosUltraGrid.DisplayLayout.Appearance = appearance1;
            this.prepagosUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn4.Header.VisiblePosition = 0;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn4.Width = 77;
            ultraGridColumn5.Header.VisiblePosition = 1;
            ultraGridColumn5.Width = 262;
            ultraGridColumn6.Header.VisiblePosition = 2;
            ultraGridColumn6.Width = 75;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6});
            this.prepagosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.prepagosUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.prepagosUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.prepagosUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.prepagosUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.prepagosUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.prepagosUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.prepagosUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.prepagosUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.prepagosUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.prepagosUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.prepagosUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.prepagosUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.prepagosUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.prepagosUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.prepagosUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.prepagosUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.prepagosUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.prepagosUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.prepagosUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.prepagosUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.prepagosUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.prepagosUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.prepagosUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prepagosUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.prepagosUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.prepagosUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.prepagosUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.prepagosUltraGrid.Name = "prepagosUltraGrid";
            this.prepagosUltraGrid.Size = new System.Drawing.Size(358, 376);
            this.prepagosUltraGrid.TabIndex = 2;
            this.prepagosUltraGrid.AfterEnterEditMode += new System.EventHandler(this.PrepagosUltraGridAfterEnterEditMode);
            this.prepagosUltraGrid.AfterRowsDeleted += new System.EventHandler(this.PrepagosUltraGridAfterRowsDeleted);
            this.prepagosUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.prepagosUltraGrid_KeyDown);
            // 
            // prepagosBindingSource
            // 
            this.prepagosBindingSource.DataMember = "Prepagos";
            this.prepagosBindingSource.DataSource = this.ds_Prepagos;
            // 
            // ds_Prepagos
            // 
            this.ds_Prepagos.DataSetName = "DsPrepagos";
            this.ds_Prepagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormABCPrepagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(358, 418);
            this.Controls.Add(this.prepagosUltraGrid);
            this.Name = "FormABCPrepagos";
            this.Text = "Obras Sociales";
            this.Load += new System.EventHandler(this.FormABCPrepagosLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.prepagosUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prepagosUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Prepagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid prepagosUltraGrid;
        private System.Windows.Forms.BindingSource prepagosBindingSource;
        private Administración.WS.DsPrepagos ds_Prepagos;
    }
}

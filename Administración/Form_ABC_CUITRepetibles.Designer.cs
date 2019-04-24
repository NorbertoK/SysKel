namespace Administración
{
    partial class FormAbccuitRepetibles
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CUITRepetibles", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCUITRepetible");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.ds_CUITRepetibles = new Administración.WS.DsCUITRepetibles();
            this.cUITRepetiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUITRepetiblesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CUITRepetibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUITRepetiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUITRepetiblesUltraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(516, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(435, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 281);
            this.panel1.Size = new System.Drawing.Size(606, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(354, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ds_CUITRepetibles
            // 
            this.ds_CUITRepetibles.DataSetName = "DsCUITRepetibles";
            this.ds_CUITRepetibles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUITRepetiblesBindingSource
            // 
            this.cUITRepetiblesBindingSource.DataMember = "CUITRepetibles";
            this.cUITRepetiblesBindingSource.DataSource = this.ds_CUITRepetibles;
            // 
            // cUITRepetiblesUltraGrid
            // 
            this.cUITRepetiblesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cUITRepetiblesUltraGrid.DataSource = this.cUITRepetiblesBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Appearance = appearance1;
            this.cUITRepetiblesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 91;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn2.MaskInput = "##-##,###,###-#";
            ultraGridColumn2.Width = 91;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 494;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3});
            this.cUITRepetiblesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.cUITRepetiblesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.cUITRepetiblesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.cUITRepetiblesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.cUITRepetiblesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.cUITRepetiblesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cUITRepetiblesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.cUITRepetiblesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.cUITRepetiblesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.cUITRepetiblesUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.cUITRepetiblesUltraGrid.Name = "cUITRepetiblesUltraGrid";
            this.cUITRepetiblesUltraGrid.Size = new System.Drawing.Size(606, 291);
            this.cUITRepetiblesUltraGrid.TabIndex = 2;
            this.cUITRepetiblesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.CUitRepetiblesUltraGridAfterEnterEditMode);
            this.cUITRepetiblesUltraGrid.AfterRowsDeleted += new System.EventHandler(this.CUitRepetiblesUltraGridAfterRowsDeleted);
            this.cUITRepetiblesUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cUITRepetiblesUltraGrid_KeyDown);
            // 
            // FormAbccuitRepetibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(605, 329);
            this.Controls.Add(this.cUITRepetiblesUltraGrid);
            this.Name = "FormAbccuitRepetibles";
            this.Text = "CUITs que se pueden repetir";
            this.Load += new System.EventHandler(this.FormAbccuitRepetiblesLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.cUITRepetiblesUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_CUITRepetibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUITRepetiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUITRepetiblesUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Administración.WS.DsCUITRepetibles ds_CUITRepetibles;
        private System.Windows.Forms.BindingSource cUITRepetiblesBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid cUITRepetiblesUltraGrid;
    }
}

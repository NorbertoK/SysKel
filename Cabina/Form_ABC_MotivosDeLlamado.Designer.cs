namespace Cabina
{
    partial class FormABCMotivosDeLlamado
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDeLlamado", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeLlamado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FichaDespacho");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FichaMasInfo");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.dsMotivosDeLlamado = new Cabina.WS.DsMotivosDeLlamado();
            this.motivosDeLlamadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motivosDeLlamadoUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeLlamado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeLlamadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeLlamadoUltraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(304, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(223, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 411);
            this.panel1.Size = new System.Drawing.Size(394, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(142, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsMotivosDeLlamado
            // 
            this.dsMotivosDeLlamado.DataSetName = "DsMotivosDeLlamado";
            this.dsMotivosDeLlamado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motivosDeLlamadoBindingSource
            // 
            this.motivosDeLlamadoBindingSource.DataMember = "MotivosDeLlamado";
            this.motivosDeLlamadoBindingSource.DataSource = this.dsMotivosDeLlamado;
            // 
            // motivosDeLlamadoUltraGrid
            // 
            this.motivosDeLlamadoUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.motivosDeLlamadoUltraGrid.DataSource = this.motivosDeLlamadoBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Appearance = appearance1;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 101;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 193;
            appearance2.TextHAlignAsString = "Center";
            ultraGridColumn3.CellAppearance = appearance2;
            ultraGridColumn3.Header.Caption = "Ficha Despacho";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 92;
            appearance3.TextHAlignAsString = "Center";
            ultraGridColumn4.CellAppearance = appearance3;
            ultraGridColumn4.Header.Caption = "Ficha Más Info";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Width = 88;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4});
            this.motivosDeLlamadoUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.motivosDeLlamadoUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance4.BackColor = System.Drawing.SystemColors.Window;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance5.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance5;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance6.BackColor = System.Drawing.Color.Transparent;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance6;
            appearance7.BackColor = System.Drawing.SystemColors.Control;
            appearance7.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.CellAppearance = appearance7;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance8.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance8.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance8;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance9.ForeColor = System.Drawing.Color.Red;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance9;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance10;
            appearance11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance11.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance11;
            appearance12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance12;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.motivosDeLlamadoUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.motivosDeLlamadoUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.motivosDeLlamadoUltraGrid.Name = "motivosDeLlamadoUltraGrid";
            this.motivosDeLlamadoUltraGrid.Size = new System.Drawing.Size(394, 421);
            this.motivosDeLlamadoUltraGrid.TabIndex = 2;
            this.motivosDeLlamadoUltraGrid.AfterEnterEditMode += new System.EventHandler(this.MotivosDeLlamadoUltraGridAfterEnterEditMode);
            this.motivosDeLlamadoUltraGrid.AfterRowsDeleted += new System.EventHandler(this.MotivosDeLlamadoUltraGridAfterRowsDeleted);
            this.motivosDeLlamadoUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.motivosDeLlamadoUltraGrid_KeyDown);
            // 
            // FormABCMotivosDeLlamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(393, 459);
            this.Controls.Add(this.motivosDeLlamadoUltraGrid);
            this.Name = "FormABCMotivosDeLlamado";
            this.Text = "Motivos de Llamado";
            this.Load += new System.EventHandler(this.FormABCMotivosDeLlamadoLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.motivosDeLlamadoUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeLlamado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeLlamadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeLlamadoUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsMotivosDeLlamado dsMotivosDeLlamado;
        private System.Windows.Forms.BindingSource motivosDeLlamadoBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid motivosDeLlamadoUltraGrid;
    }
}

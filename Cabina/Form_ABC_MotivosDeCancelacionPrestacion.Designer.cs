namespace Cabina
{
    partial class FormABCMotivosDeCancelacionPrestacion
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDeCancelacionPrestacion", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeCancelacionPrestacion");
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
            this.dsMotivosDeCancelacionPrestacion = new Cabina.WS.DsMotivosDeCancelacionPrestacion();
            this.motivosDeCancelacionPrestacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motivosDeCancelacionPrestacionUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeCancelacionPrestacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeCancelacionPrestacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeCancelacionPrestacionUltraGrid)).BeginInit();
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
            // dsMotivosDeCancelacionPrestacion
            // 
            this.dsMotivosDeCancelacionPrestacion.DataSetName = "DsMotivosDeCancelacionPrestacion";
            this.dsMotivosDeCancelacionPrestacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motivosDeCancelacionPrestacionBindingSource
            // 
            this.motivosDeCancelacionPrestacionBindingSource.DataMember = "MotivosDeCancelacionPrestacion";
            this.motivosDeCancelacionPrestacionBindingSource.DataSource = this.dsMotivosDeCancelacionPrestacion;
            // 
            // motivosDeCancelacionPrestacionUltraGrid
            // 
            this.motivosDeCancelacionPrestacionUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.motivosDeCancelacionPrestacionUltraGrid.DataSource = this.motivosDeCancelacionPrestacionBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Appearance = appearance1;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 245;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2});
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.motivosDeCancelacionPrestacionUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.motivosDeCancelacionPrestacionUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.motivosDeCancelacionPrestacionUltraGrid.Name = "motivosDeCancelacionPrestacionUltraGrid";
            this.motivosDeCancelacionPrestacionUltraGrid.Size = new System.Drawing.Size(266, 290);
            this.motivosDeCancelacionPrestacionUltraGrid.TabIndex = 2;
            this.motivosDeCancelacionPrestacionUltraGrid.AfterEnterEditMode += new System.EventHandler(this.MotivosDeCancelacionPrestacionUltraGridAfterEnterEditMode);
            this.motivosDeCancelacionPrestacionUltraGrid.AfterRowsDeleted += new System.EventHandler(this.MotivosDeCancelacionPrestacionUltraGridAfterRowsDeleted);
            this.motivosDeCancelacionPrestacionUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.motivosDeCancelacionPrestacionUltraGrid_KeyDown);
            // 
            // FormABCMotivosDeCancelacionPrestacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(265, 328);
            this.Controls.Add(this.motivosDeCancelacionPrestacionUltraGrid);
            this.Name = "FormABCMotivosDeCancelacionPrestacion";
            this.Text = "Motivos de Cancelación de Prestaciones";
            this.Load += new System.EventHandler(this.FormABCMotivosDeCancelacionPrestacionLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.motivosDeCancelacionPrestacionUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeCancelacionPrestacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeCancelacionPrestacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeCancelacionPrestacionUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsMotivosDeCancelacionPrestacion dsMotivosDeCancelacionPrestacion;
        private System.Windows.Forms.BindingSource motivosDeCancelacionPrestacionBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid motivosDeCancelacionPrestacionUltraGrid;
    }
}

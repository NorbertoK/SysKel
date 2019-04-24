namespace Administración
{
    partial class FormABCMedicosDeCabecera
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MedicosDeCabecera", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicoDeCabecera");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Apellido");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.ds_MedicosDeCabecera = new Administración.WS.DsMedicosDeCabecera();
            this.medicosDeCabeceraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosDeCabeceraUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_MedicosDeCabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosDeCabeceraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosDeCabeceraUltraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(239, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(158, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Size = new System.Drawing.Size(329, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(77, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ds_MedicosDeCabecera
            // 
            this.ds_MedicosDeCabecera.DataSetName = "DsMedicosDeCabecera";
            this.ds_MedicosDeCabecera.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicosDeCabeceraBindingSource
            // 
            this.medicosDeCabeceraBindingSource.DataMember = "MedicosDeCabecera";
            this.medicosDeCabeceraBindingSource.DataSource = this.ds_MedicosDeCabecera;
            // 
            // medicosDeCabeceraUltraGrid
            // 
            this.medicosDeCabeceraUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medicosDeCabeceraUltraGrid.DataSource = this.medicosDeCabeceraBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Appearance = appearance1;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 72;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 153;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 155;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3});
            this.medicosDeCabeceraUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.medicosDeCabeceraUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.medicosDeCabeceraUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.medicosDeCabeceraUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.medicosDeCabeceraUltraGrid.Name = "medicosDeCabeceraUltraGrid";
            this.medicosDeCabeceraUltraGrid.Size = new System.Drawing.Size(329, 417);
            this.medicosDeCabeceraUltraGrid.TabIndex = 2;
            this.medicosDeCabeceraUltraGrid.AfterEnterEditMode += new System.EventHandler(this.MedicosDeCabeceraUltraGridAfterEnterEditMode);
            this.medicosDeCabeceraUltraGrid.AfterRowsDeleted += new System.EventHandler(this.MedicosDeCabeceraUltraGridAfterRowsDeleted);
            this.medicosDeCabeceraUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.medicosDeCabeceraUltraGrid_KeyDown);
            // 
            // FormABCMedicosDeCabecera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(328, 455);
            this.Controls.Add(this.medicosDeCabeceraUltraGrid);
            this.Name = "FormABCMedicosDeCabecera";
            this.Text = "Médicos de Cabecera";
            this.Load += new System.EventHandler(this.FormABCMedicosDeCabeceraLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.medicosDeCabeceraUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_MedicosDeCabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosDeCabeceraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosDeCabeceraUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Administración.WS.DsMedicosDeCabecera ds_MedicosDeCabecera;
        private System.Windows.Forms.BindingSource medicosDeCabeceraBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid medicosDeCabeceraUltraGrid;
    }
}

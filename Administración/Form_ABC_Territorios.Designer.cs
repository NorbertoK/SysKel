namespace Administración
{
    partial class FormABCTerritorios
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Paises", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPais");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Provincias_Países");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Provincias_Países", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProvincia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPais");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Municipios_Provincias");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Municipios_Provincias", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMunicipio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProvincia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Localidades_Municipios");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Localidades_Municipios", 2);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMunicipio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoPostal");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Calles_Localidades");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Barrios_Localidades");
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Calles_Localidades", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Barrios_Localidades", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            this.paisesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.paisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTerritorios1 = new Administración.WS.DsTerritorios();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paisesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTerritorios1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(490, 18);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(409, 18);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-108, 396);
            this.panel1.Size = new System.Drawing.Size(580, 52);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(328, 18);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // paisesUltraGrid
            // 
            this.paisesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paisesUltraGrid.DataSource = this.paisesBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.paisesUltraGrid.DisplayLayout.Appearance = appearance1;
            this.paisesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 154;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 295;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 136;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4});
            appearance2.FontData.BoldAsString = "True";
            appearance2.FontData.SizeInPoints = 11F;
            appearance2.TextHAlignAsString = "Left";
            ultraGridBand1.Header.Appearance = appearance2;
            ultraGridBand1.Header.Caption = "Países";
            ultraGridBand1.HeaderVisible = true;
            ultraGridColumn5.Header.VisiblePosition = 0;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn5.Width = 149;
            ultraGridColumn6.Header.VisiblePosition = 1;
            ultraGridColumn6.Width = 276;
            ultraGridColumn7.Header.VisiblePosition = 2;
            ultraGridColumn7.Width = 136;
            ultraGridColumn8.Header.VisiblePosition = 3;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn8.Width = 156;
            ultraGridColumn9.Header.VisiblePosition = 4;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9});
            appearance3.FontData.BoldAsString = "True";
            appearance3.FontData.SizeInPoints = 11F;
            appearance3.TextHAlignAsString = "Left";
            ultraGridBand2.Header.Appearance = appearance3;
            ultraGridBand2.Header.Caption = "Provincias";
            ultraGridBand2.HeaderVisible = true;
            ultraGridColumn10.Header.VisiblePosition = 0;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn10.Width = 146;
            ultraGridColumn11.Header.VisiblePosition = 1;
            ultraGridColumn11.Width = 257;
            ultraGridColumn12.Header.VisiblePosition = 2;
            ultraGridColumn12.Width = 136;
            ultraGridColumn13.Header.VisiblePosition = 3;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn13.Width = 180;
            ultraGridColumn14.Header.VisiblePosition = 4;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14});
            appearance4.FontData.BoldAsString = "True";
            appearance4.FontData.SizeInPoints = 11F;
            appearance4.TextHAlignAsString = "Left";
            ultraGridBand3.Header.Appearance = appearance4;
            ultraGridBand3.Header.Caption = "Departamentos / Partidos";
            ultraGridBand3.HeaderVisible = true;
            ultraGridColumn15.Header.VisiblePosition = 0;
            ultraGridColumn15.Hidden = true;
            ultraGridColumn15.Width = 151;
            ultraGridColumn16.Header.VisiblePosition = 1;
            ultraGridColumn16.Width = 196;
            ultraGridColumn17.Header.VisiblePosition = 2;
            ultraGridColumn17.Width = 80;
            ultraGridColumn18.Header.VisiblePosition = 3;
            ultraGridColumn18.Hidden = true;
            ultraGridColumn18.Width = 188;
            ultraGridColumn19.Header.Caption = "Código Postal";
            ultraGridColumn19.Header.VisiblePosition = 4;
            ultraGridColumn19.MaxLength = 4;
            ultraGridColumn19.Width = 98;
            ultraGridColumn20.Header.VisiblePosition = 5;
            ultraGridColumn21.Header.VisiblePosition = 6;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20,
            ultraGridColumn21});
            appearance5.FontData.BoldAsString = "True";
            appearance5.FontData.SizeInPoints = 11F;
            appearance5.TextHAlignAsString = "Left";
            ultraGridBand4.Header.Appearance = appearance5;
            ultraGridBand4.Header.Caption = "Localidades";
            ultraGridBand4.HeaderVisible = true;
            ultraGridColumn22.Header.VisiblePosition = 0;
            ultraGridColumn22.Hidden = true;
            ultraGridColumn22.Width = 123;
            ultraGridColumn23.Header.VisiblePosition = 1;
            ultraGridColumn23.Width = 355;
            ultraGridColumn24.Header.VisiblePosition = 2;
            ultraGridColumn24.Hidden = true;
            ultraGridColumn24.Width = 183;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24});
            appearance6.FontData.BoldAsString = "True";
            appearance6.FontData.SizeInPoints = 11F;
            appearance6.TextHAlignAsString = "Left";
            ultraGridBand5.Header.Appearance = appearance6;
            ultraGridBand5.Header.Caption = "Calles";
            ultraGridBand5.HeaderVisible = true;
            ultraGridColumn25.Header.VisiblePosition = 0;
            ultraGridColumn25.Hidden = true;
            ultraGridColumn25.Width = 86;
            ultraGridColumn26.Header.VisiblePosition = 1;
            ultraGridColumn26.Hidden = true;
            ultraGridColumn26.Width = 144;
            ultraGridColumn27.Header.VisiblePosition = 2;
            ultraGridColumn27.Width = 355;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn25,
            ultraGridColumn26,
            ultraGridColumn27});
            appearance7.FontData.BoldAsString = "True";
            appearance7.FontData.SizeInPoints = 11F;
            appearance7.TextHAlignAsString = "Left";
            ultraGridBand6.Header.Appearance = appearance7;
            ultraGridBand6.Header.Caption = "Barrios";
            ultraGridBand6.HeaderVisible = true;
            this.paisesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.paisesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.paisesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.paisesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.paisesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.paisesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.paisesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.paisesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.paisesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance8.BackColor = System.Drawing.SystemColors.Window;
            this.paisesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.paisesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance9;
            this.paisesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.paisesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.paisesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.paisesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.paisesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.paisesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.paisesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance10.BackColor = System.Drawing.Color.Transparent;
            this.paisesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance10;
            appearance11.BackColor = System.Drawing.SystemColors.Control;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.paisesUltraGrid.DisplayLayout.Override.CellAppearance = appearance11;
            this.paisesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance12.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance12.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.paisesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance12;
            this.paisesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance13.ForeColor = System.Drawing.Color.Red;
            this.paisesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance13;
            this.paisesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.paisesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance15.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.paisesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance15;
            appearance16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.paisesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance16;
            this.paisesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paisesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.paisesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.paisesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.paisesUltraGrid.Location = new System.Drawing.Point(1, 1);
            this.paisesUltraGrid.Name = "paisesUltraGrid";
            this.paisesUltraGrid.Size = new System.Drawing.Size(471, 404);
            this.paisesUltraGrid.TabIndex = 2;
            this.paisesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.PaisesUltraGridAfterEnterEditMode);
            this.paisesUltraGrid.AfterRowsDeleted += new System.EventHandler(this.PaisesUltraGridAfterRowsDeleted);
            this.paisesUltraGrid.BeforeRowsDeleted += new Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventHandler(this.PaisesUltraGridBeforeRowsDeleted);
            this.paisesUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.paisesUltraGrid_KeyDown);
            // 
            // paisesBindingSource
            // 
            this.paisesBindingSource.DataMember = "Paises";
            this.paisesBindingSource.DataSource = this.dsTerritorios1;
            // 
            // dsTerritorios1
            // 
            this.dsTerritorios1.DataSetName = "DsTerritorios";
            this.dsTerritorios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormABCTerritorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(471, 445);
            this.Controls.Add(this.paisesUltraGrid);
            this.Name = "FormABCTerritorios";
            this.Text = "Territorios";
            this.Load += new System.EventHandler(this.FormABCTerritoriosLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.paisesUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paisesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTerritorios1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource paisesBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid paisesUltraGrid;
        private WS.DsTerritorios dsTerritorios1;
    }
}

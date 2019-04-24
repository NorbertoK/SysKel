namespace Cabina
{
    partial class FormABCMedicamentos
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MedicamentosCategorias", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamentosCategorias");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Medicamentos_MedicamentosCategorias");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Medicamentos_MedicamentosCategorias", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamentoCategoria");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidades");
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
            this.dsMedicamentos = new Cabina.WS.DsMedicamentos();
            this.medicamentosCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentosCategoriasUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosCategoriasUltraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(282, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(201, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Size = new System.Drawing.Size(372, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(120, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsMedicamentos
            // 
            this.dsMedicamentos.DataSetName = "DsMedicamentos";
            this.dsMedicamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentosCategoriasBindingSource
            // 
            this.medicamentosCategoriasBindingSource.DataMember = "MedicamentosCategorias";
            this.medicamentosCategoriasBindingSource.DataSource = this.dsMedicamentos;
            // 
            // medicamentosCategoriasUltraGrid
            // 
            this.medicamentosCategoriasUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medicamentosCategoriasUltraGrid.DataSource = this.medicamentosCategoriasBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Appearance = appearance1;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 172;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 332;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3});
            appearance2.FontData.BoldAsString = "True";
            appearance2.FontData.SizeInPoints = 11F;
            appearance2.TextHAlignAsString = "Left";
            ultraGridBand1.Header.Appearance = appearance2;
            ultraGridBand1.Header.Caption = "Categorías";
            ultraGridBand1.HeaderVisible = true;
            ultraGridColumn4.Header.VisiblePosition = 0;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn4.Width = 43;
            ultraGridColumn5.Header.VisiblePosition = 1;
            ultraGridColumn5.Width = 155;
            ultraGridColumn6.Header.VisiblePosition = 2;
            ultraGridColumn6.Width = 79;
            ultraGridColumn7.Header.VisiblePosition = 3;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn7.Width = 71;
            ultraGridColumn8.Header.VisiblePosition = 4;
            ultraGridColumn8.Width = 79;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8});
            appearance3.FontData.BoldAsString = "True";
            appearance3.FontData.SizeInPoints = 11F;
            appearance3.TextHAlignAsString = "Left";
            ultraGridBand2.Header.Appearance = appearance3;
            ultraGridBand2.Header.Caption = "Medicamentos y Material Descartable";
            ultraGridBand2.HeaderVisible = true;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.medicamentosCategoriasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.medicamentosCategoriasUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance4.BackColor = System.Drawing.SystemColors.Window;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance5.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance5;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance6.BackColor = System.Drawing.Color.Transparent;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance6;
            appearance7.BackColor = System.Drawing.SystemColors.Control;
            appearance7.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.CellAppearance = appearance7;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance8.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance8.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance8;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance9.ForeColor = System.Drawing.Color.Red;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance9;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance10;
            appearance11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance11.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance11;
            appearance12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance12;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.medicamentosCategoriasUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.medicamentosCategoriasUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.medicamentosCategoriasUltraGrid.Name = "medicamentosCategoriasUltraGrid";
            this.medicamentosCategoriasUltraGrid.Size = new System.Drawing.Size(372, 430);
            this.medicamentosCategoriasUltraGrid.TabIndex = 2;
            this.medicamentosCategoriasUltraGrid.AfterEnterEditMode += new System.EventHandler(this.MedicamentosCategoriasUltraGridAfterEnterEditMode);
            this.medicamentosCategoriasUltraGrid.AfterRowsDeleted += new System.EventHandler(this.MedicamentosCategoriasUltraGridAfterRowsDeleted);
            this.medicamentosCategoriasUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.medicamentosCategoriasUltraGrid_KeyDown);
            // 
            // FormABCMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(371, 468);
            this.Controls.Add(this.medicamentosCategoriasUltraGrid);
            this.Name = "FormABCMedicamentos";
            this.Text = "Medicamentos y Material Descartable";
            this.Load += new System.EventHandler(this.FormABCMedicamentosLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.medicamentosCategoriasUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosCategoriasUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsMedicamentos dsMedicamentos;
        private System.Windows.Forms.BindingSource medicamentosCategoriasBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid medicamentosCategoriasUltraGrid;
    }
}

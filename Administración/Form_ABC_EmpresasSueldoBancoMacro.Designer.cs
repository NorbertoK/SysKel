namespace Administración
{
    partial class FormABCEmpresasSueldoBancoMacro
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpresasSueldoBcoMacro", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpresasSueldoBcoMacro");
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
            this.dsEmpresasSueldoBancoMacro = new Administración.WS.DsEmpresasSueldoBancoMacro();
            this.empresasSueldoBcoMacroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasSueldoBcoMacroUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresasSueldoBancoMacro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasSueldoBcoMacroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasSueldoBcoMacroUltraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(238, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(157, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Size = new System.Drawing.Size(328, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(76, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsEmpresasSueldoBancoMacro
            // 
            this.dsEmpresasSueldoBancoMacro.DataSetName = "DsEmpresasSueldoBancoMacro";
            this.dsEmpresasSueldoBancoMacro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresasSueldoBcoMacroBindingSource
            // 
            this.empresasSueldoBcoMacroBindingSource.DataMember = "EmpresasSueldoBcoMacro";
            this.empresasSueldoBcoMacroBindingSource.DataSource = this.dsEmpresasSueldoBancoMacro;
            // 
            // empresasSueldoBcoMacroUltraGrid
            // 
            this.empresasSueldoBcoMacroUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empresasSueldoBcoMacroUltraGrid.DataSource = this.empresasSueldoBcoMacroBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Appearance = appearance1;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.Caption = "Código";
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Width = 77;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 230;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2});
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.empresasSueldoBcoMacroUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.empresasSueldoBcoMacroUltraGrid.Location = new System.Drawing.Point(0, -2);
            this.empresasSueldoBcoMacroUltraGrid.Name = "empresasSueldoBcoMacroUltraGrid";
            this.empresasSueldoBcoMacroUltraGrid.Size = new System.Drawing.Size(328, 406);
            this.empresasSueldoBcoMacroUltraGrid.TabIndex = 2;
            this.empresasSueldoBcoMacroUltraGrid.AfterEnterEditMode += new System.EventHandler(this.BancosUltraGridAfterEnterEditMode);
            this.empresasSueldoBcoMacroUltraGrid.AfterRowsDeleted += new System.EventHandler(this.BancosUltraGridAfterRowsDeleted);
            this.empresasSueldoBcoMacroUltraGrid.BeforeCellDeactivate += new System.ComponentModel.CancelEventHandler(this.EmpresasSueldoBcoMacroUltraGridBeforeCellDeactivate);
            this.empresasSueldoBcoMacroUltraGrid.BeforeRowsDeleted += new Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventHandler(this.EmpresasSueldoBcoMacroUltraGridBeforeRowsDeleted);
            this.empresasSueldoBcoMacroUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.empresasSueldoBcoMacroUltraGrid_KeyDown);
            // 
            // FormABCEmpresasSueldoBancoMacro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(327, 442);
            this.Controls.Add(this.empresasSueldoBcoMacroUltraGrid);
            this.Name = "FormABCEmpresasSueldoBancoMacro";
            this.Text = "Empresas Sueldo Banco Macro";
            this.Load += new System.EventHandler(this.FormABCEmpresasSueldoBancoMacroLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.empresasSueldoBcoMacroUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresasSueldoBancoMacro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasSueldoBcoMacroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasSueldoBcoMacroUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsEmpresasSueldoBancoMacro dsEmpresasSueldoBancoMacro;
        private System.Windows.Forms.BindingSource empresasSueldoBcoMacroBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid empresasSueldoBcoMacroUltraGrid;
    }
}

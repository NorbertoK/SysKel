namespace Administración
{
    partial class FormABCCodigos
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
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Codigos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCodigo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Color");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jerarquia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TiempoDeLlegada");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            this.codigosUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.codigosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Codigos = new Administración.WS.DsCodigos();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigosUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Codigos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(343, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(262, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Size = new System.Drawing.Size(433, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(181, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // codigosUltraGrid
            // 
            this.codigosUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigosUltraGrid.DataSource = this.codigosBindingSource;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.codigosUltraGrid.DisplayLayout.Appearance = appearance12;
            this.codigosUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 55;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 105;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 124;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Width = 65;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance1.TextHAlignAsString = "Center";
            ultraGridColumn5.CellAppearance = appearance1;
            ultraGridColumn5.Header.Caption = "Tiempo de Llegada";
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn5.MaskInput = "{LOC}hh:mm";
            ultraGridColumn5.NullText = "hh:mm";
            ultraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time;
            ultraGridColumn5.Width = 118;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5});
            ultraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.codigosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.codigosUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.codigosUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.codigosUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance14.BackColor = System.Drawing.SystemColors.Window;
            this.codigosUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance15.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance15.ForeColor = System.Drawing.SystemColors.WindowText;
            this.codigosUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance15;
            this.codigosUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.codigosUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.codigosUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.codigosUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.codigosUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.codigosUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.codigosUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance16.BackColor = System.Drawing.Color.Transparent;
            this.codigosUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance16;
            appearance17.BackColor = System.Drawing.SystemColors.Control;
            appearance17.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.codigosUltraGrid.DisplayLayout.Override.CellAppearance = appearance17;
            this.codigosUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance18.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance18.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.codigosUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance18;
            this.codigosUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance19.ForeColor = System.Drawing.Color.Red;
            this.codigosUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance19;
            this.codigosUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.codigosUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance20;
            appearance21.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance21.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.codigosUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance21;
            appearance22.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.codigosUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance22;
            this.codigosUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.codigosUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.codigosUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.codigosUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.codigosUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigosUltraGrid.Location = new System.Drawing.Point(0, 1);
            this.codigosUltraGrid.Name = "codigosUltraGrid";
            this.codigosUltraGrid.Size = new System.Drawing.Size(433, 289);
            this.codigosUltraGrid.TabIndex = 2;
            this.toolTip1.SetToolTip(this.codigosUltraGrid, "Tiempo de Llegada, en minutos.");
            this.codigosUltraGrid.AfterEnterEditMode += new System.EventHandler(this.CodigosUltraGridAfterEnterEditMode);
            this.codigosUltraGrid.AfterRowsDeleted += new System.EventHandler(this.CodigosUltraGridAfterRowsDeleted);
            this.codigosUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codigosUltraGrid_KeyDown);
            // 
            // codigosBindingSource
            // 
            this.codigosBindingSource.DataMember = "Codigos";
            this.codigosBindingSource.DataSource = this.ds_Codigos;
            // 
            // ds_Codigos
            // 
            this.ds_Codigos.DataSetName = "DsCodigos";
            this.ds_Codigos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormABCCodigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(432, 328);
            this.Controls.Add(this.codigosUltraGrid);
            this.Name = "FormABCCodigos";
            this.Text = "Códigos";
            this.Load += new System.EventHandler(this.Form2Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.codigosUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.codigosUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Codigos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Administración.WS.DsCodigos ds_Codigos;
        private System.Windows.Forms.BindingSource codigosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid codigosUltraGrid;
    }
}

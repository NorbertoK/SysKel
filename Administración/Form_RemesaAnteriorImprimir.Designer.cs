namespace Administración
{
    partial class FormRemesaAnteriorImprimir
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
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("View_Remesas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobrador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Caja");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Receptor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Grabador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo");
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            this.dsRemesasVista = new Administración.WS.DsRemesasVista();
            this.view_RemesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_RemesasUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraNumericEditorIdRemesa = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.ultraDateTimeEditorDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraDateTimeEditorHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemesasVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_RemesasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_RemesasUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditorIdRemesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(740, 16);
            this.buttonAceptar.Text = "Ver Reporte";
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(172, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Size = new System.Drawing.Size(828, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(659, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsRemesasVista
            // 
            this.dsRemesasVista.DataSetName = "DsRemesasVista";
            this.dsRemesasVista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_RemesasBindingSource
            // 
            this.view_RemesasBindingSource.DataMember = "View_Remesas";
            this.view_RemesasBindingSource.DataSource = this.dsRemesasVista;
            // 
            // view_RemesasUltraGrid
            // 
            this.view_RemesasUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.view_RemesasUltraGrid.DataSource = this.view_RemesasBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.view_RemesasUltraGrid.DisplayLayout.Appearance = appearance11;
            this.view_RemesasUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn9.Header.VisiblePosition = 0;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn9.Width = 25;
            ultraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn10.Header.VisiblePosition = 2;
            ultraGridColumn10.Width = 169;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn11.Header.VisiblePosition = 1;
            ultraGridColumn11.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn11.MaskInput = "dd/mm/yyyy hh:mm";
            ultraGridColumn11.Width = 96;
            ultraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance3.TextHAlignAsString = "Right";
            ultraGridColumn12.CellAppearance = appearance3;
            ultraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn12.Header.VisiblePosition = 3;
            ultraGridColumn12.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn12.MaskInput = "{LOC}nn,nnn,nnn";
            ultraGridColumn12.Width = 74;
            ultraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn13.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn13.Header.VisiblePosition = 4;
            ultraGridColumn13.Width = 146;
            ultraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn14.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn14.Header.VisiblePosition = 5;
            ultraGridColumn14.Width = 148;
            ultraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance4.TextHAlignAsString = "Right";
            ultraGridColumn15.CellAppearance = appearance4;
            ultraGridColumn15.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn15.Header.VisiblePosition = 6;
            ultraGridColumn15.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn15.MaskInput = "{LOC}-n,nnn,nnn.nn";
            ultraGridColumn15.Width = 82;
            ultraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn16.Header.VisiblePosition = 7;
            ultraGridColumn16.Width = 92;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16});
            ultraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            this.view_RemesasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.view_RemesasUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.view_RemesasUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.view_RemesasUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance13.BackColor = System.Drawing.SystemColors.Window;
            this.view_RemesasUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance13;
            appearance14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance14.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.view_RemesasUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance14;
            this.view_RemesasUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.view_RemesasUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.view_RemesasUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.view_RemesasUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.view_RemesasUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.view_RemesasUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.view_RemesasUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            appearance15.BackColor = System.Drawing.Color.Transparent;
            this.view_RemesasUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance15;
            appearance16.BackColor = System.Drawing.SystemColors.Control;
            appearance16.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.view_RemesasUltraGrid.DisplayLayout.Override.CellAppearance = appearance16;
            this.view_RemesasUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance17.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance17.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.view_RemesasUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance17;
            this.view_RemesasUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance18.ForeColor = System.Drawing.Color.Red;
            this.view_RemesasUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance18;
            this.view_RemesasUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.view_RemesasUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance20.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.view_RemesasUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance20;
            appearance21.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.view_RemesasUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance21;
            this.view_RemesasUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.view_RemesasUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.view_RemesasUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.view_RemesasUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.view_RemesasUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.view_RemesasUltraGrid.Location = new System.Drawing.Point(0, 25);
            this.view_RemesasUltraGrid.Name = "view_RemesasUltraGrid";
            this.view_RemesasUltraGrid.Size = new System.Drawing.Size(828, 409);
            this.view_RemesasUltraGrid.TabIndex = 2;
            this.view_RemesasUltraGrid.Click += new System.EventHandler(this.ViewRemesasUltraGridClick);
            this.view_RemesasUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.view_RemesasUltraGrid_KeyDown);
            // 
            // ultraNumericEditorIdRemesa
            // 
            this.ultraNumericEditorIdRemesa.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.view_RemesasBindingSource, "idRemesa", true));
            this.ultraNumericEditorIdRemesa.Location = new System.Drawing.Point(300, 149);
            this.ultraNumericEditorIdRemesa.Name = "ultraNumericEditorIdRemesa";
            this.ultraNumericEditorIdRemesa.Size = new System.Drawing.Size(100, 21);
            this.ultraNumericEditorIdRemesa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde";
            // 
            // ultraDateTimeEditorDesde
            // 
            this.ultraDateTimeEditorDesde.Location = new System.Drawing.Point(57, 2);
            this.ultraDateTimeEditorDesde.MaskInput = "dd/mm/yyyy";
            this.ultraDateTimeEditorDesde.Name = "ultraDateTimeEditorDesde";
            this.ultraDateTimeEditorDesde.Size = new System.Drawing.Size(101, 21);
            this.ultraDateTimeEditorDesde.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.ultraDateTimeEditorDesde.TabIndex = 5;
            // 
            // ultraDateTimeEditorHasta
            // 
            this.ultraDateTimeEditorHasta.Location = new System.Drawing.Point(217, 2);
            this.ultraDateTimeEditorHasta.MaskInput = "dd/mm/yyyy";
            this.ultraDateTimeEditorHasta.Name = "ultraDateTimeEditorHasta";
            this.ultraDateTimeEditorHasta.Size = new System.Drawing.Size(101, 21);
            this.ultraDateTimeEditorHasta.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.ultraDateTimeEditorHasta.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "inclusive.";
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(377, 1);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(75, 23);
            this.buttonCargar.TabIndex = 9;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.ButtonCargarClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Si está conectado por Internet no ponga un intervalo muy grande.";
            // 
            // FormRemesaAnteriorImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 472);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ultraDateTimeEditorHasta);
            this.Controls.Add(this.ultraDateTimeEditorDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.view_RemesasUltraGrid);
            this.Controls.Add(this.ultraNumericEditorIdRemesa);
            this.Name = "FormRemesaAnteriorImprimir";
            this.Text = "Remesas Anteriores";
            this.Load += new System.EventHandler(this.FormRemesaAnteriorImprimirLoad);
            this.Controls.SetChildIndex(this.ultraNumericEditorIdRemesa, 0);
            this.Controls.SetChildIndex(this.view_RemesasUltraGrid, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ultraDateTimeEditorDesde, 0);
            this.Controls.SetChildIndex(this.ultraDateTimeEditorHasta, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.buttonCargar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsRemesasVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_RemesasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_RemesasUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditorIdRemesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Administración.WS.DsRemesasVista dsRemesasVista;
        private System.Windows.Forms.BindingSource view_RemesasBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid view_RemesasUltraGrid;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditorIdRemesa;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorDesde;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Label label4;

    }
}
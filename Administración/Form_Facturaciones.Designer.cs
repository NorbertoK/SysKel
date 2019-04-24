namespace Administración
{
    partial class FormFacturaciones
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
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Facturaciones", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idFacturacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AfiliadosOClientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TandaDeFacturacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EntregadaAlCobrador", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EntidadDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobrador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Comprobantes");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Entregar");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            this.facturacionesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.facturacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFacturaciones = new Administración.WS.DsFacturaciones();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(678, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Visible = false;
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(678, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Size = new System.Drawing.Size(849, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(761, 16);
            this.buttonCancelar.Text = "Salir";
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // facturacionesUltraGrid
            // 
            this.facturacionesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.facturacionesUltraGrid.DataSource = this.facturacionesBindingSource;
            appearance21.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.facturacionesUltraGrid.DisplayLayout.Appearance = appearance21;
            this.facturacionesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 1;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 81;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn2.Header.Caption = "Período";
            ultraGridColumn2.Header.VisiblePosition = 2;
            ultraGridColumn2.Width = 53;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn3.Header.Caption = "Tipo";
            ultraGridColumn3.Header.VisiblePosition = 3;
            ultraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn3.Width = 61;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn4.Header.Caption = "Tanda";
            ultraGridColumn4.Header.VisiblePosition = 4;
            ultraGridColumn4.Width = 92;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn5.Header.Caption = "Cobranza";
            ultraGridColumn5.Header.VisiblePosition = 5;
            ultraGridColumn5.Width = 66;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn6.Header.VisiblePosition = 0;
            ultraGridColumn6.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn6.MaskInput = "dd/mm/yyyy  hh:mm";
            ultraGridColumn6.Width = 81;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn7.Header.Caption = "Entregada";
            ultraGridColumn7.Header.VisiblePosition = 10;
            ultraGridColumn7.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn7.MaskInput = "dd/mm/yyyy  hh:mm";
            ultraGridColumn7.Width = 104;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn8.Header.Caption = "Entidad";
            ultraGridColumn8.Header.VisiblePosition = 6;
            ultraGridColumn8.Width = 98;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn9.Header.VisiblePosition = 7;
            ultraGridColumn9.Width = 117;
            ultraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance1.TextHAlignAsString = "Right";
            ultraGridColumn10.CellAppearance = appearance1;
            ultraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn10.Header.VisiblePosition = 8;
            ultraGridColumn10.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn10.MaskInput = "{LOC}nn,nnn,nnn";
            ultraGridColumn10.Width = 84;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance2.TextHAlignAsString = "Right";
            ultraGridColumn11.CellAppearance = appearance2;
            ultraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn11.Header.VisiblePosition = 9;
            ultraGridColumn11.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn11.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn11.Width = 72;
            ultraGridColumn12.Header.VisiblePosition = 11;
            ultraGridColumn12.Hidden = true;
            ultraGridColumn12.Width = 56;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12});
            this.facturacionesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.facturacionesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.facturacionesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.facturacionesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance22.BackColor = System.Drawing.SystemColors.Window;
            this.facturacionesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance23.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance23.ForeColor = System.Drawing.SystemColors.WindowText;
            this.facturacionesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance23;
            this.facturacionesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.facturacionesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.facturacionesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.facturacionesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.facturacionesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.facturacionesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.facturacionesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            appearance24.BackColor = System.Drawing.Color.Transparent;
            this.facturacionesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance24;
            appearance25.BackColor = System.Drawing.SystemColors.Control;
            appearance25.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.facturacionesUltraGrid.DisplayLayout.Override.CellAppearance = appearance25;
            this.facturacionesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance26.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance26.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance26.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.facturacionesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance26;
            this.facturacionesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance27.ForeColor = System.Drawing.Color.Red;
            this.facturacionesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance27;
            this.facturacionesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.facturacionesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance28;
            appearance29.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance29.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.facturacionesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.facturacionesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance30;
            this.facturacionesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.facturacionesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.facturacionesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.facturacionesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.facturacionesUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturacionesUltraGrid.Location = new System.Drawing.Point(0, -1);
            this.facturacionesUltraGrid.Name = "facturacionesUltraGrid";
            this.facturacionesUltraGrid.Size = new System.Drawing.Size(849, 439);
            this.facturacionesUltraGrid.TabIndex = 2;
            this.facturacionesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.facturacionesUltraGrid_AfterEnterEditMode);
            this.facturacionesUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.facturacionesUltraGrid_KeyDown);
            // 
            // facturacionesBindingSource
            // 
            this.facturacionesBindingSource.DataMember = "Facturaciones";
            this.facturacionesBindingSource.DataSource = this.dsFacturaciones;
            // 
            // dsFacturaciones
            // 
            this.dsFacturaciones.DataSetName = "DsFacturaciones";
            this.dsFacturaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormFacturaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(848, 476);
            this.Controls.Add(this.facturacionesUltraGrid);
            this.Name = "FormFacturaciones";
            this.Text = "Facturaciones";
            this.Load += new System.EventHandler(this.FormFacturacionesLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.facturacionesUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facturacionesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsFacturaciones dsFacturaciones;
        private System.Windows.Forms.BindingSource facturacionesBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid facturacionesUltraGrid;
    }
}

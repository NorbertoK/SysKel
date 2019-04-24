namespace Administración
{
    partial class FormReportHistRenglonesMoldesFactutra
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Clave");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
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
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Clave");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre");
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ClientesLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIva");
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraCombo1 = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.ultraDataSource1 = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraCalendarCombo1 = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.clientesListaUltraCombo = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.clientesListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClientesLista = new Administración.WS.DsClientesLista();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCombo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarCombo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesListaUltraCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientesLista)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(330, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(249, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Size = new System.Drawing.Size(420, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(249, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.ultraCombo1);
            this.ultraGroupBox1.Location = new System.Drawing.Point(13, 13);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(238, 55);
            this.ultraGroupBox1.TabIndex = 1;
            this.ultraGroupBox1.Text = "Todas las modificaciones";
            // 
            // ultraCombo1
            // 
            this.ultraCombo1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.ultraCombo1.DataSource = this.ultraDataSource1;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraCombo1.DisplayLayout.Appearance = appearance1;
            this.ultraCombo1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn5.Header.VisiblePosition = 0;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn5.Width = 465;
            ultraGridColumn6.Header.VisiblePosition = 1;
            ultraGridColumn6.Width = 192;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn5,
            ultraGridColumn6});
            this.ultraCombo1.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraCombo1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraCombo1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraCombo1.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraCombo1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.ultraCombo1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraCombo1.DisplayLayout.GroupByBox.Hidden = true;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraCombo1.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.ultraCombo1.DisplayLayout.InterBandSpacing = 10;
            this.ultraCombo1.DisplayLayout.MaxBandDepth = 5;
            this.ultraCombo1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraCombo1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            this.ultraCombo1.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraCombo1.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.ultraCombo1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraCombo1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraCombo1.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraCombo1.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraCombo1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraCombo1.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraCombo1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            this.ultraCombo1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraCombo1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.Color.Transparent;
            this.ultraCombo1.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BackColor = System.Drawing.SystemColors.Control;
            appearance8.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraCombo1.DisplayLayout.Override.CellAppearance = appearance8;
            this.ultraCombo1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraCombo1.DisplayLayout.Override.CellPadding = 0;
            this.ultraCombo1.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraCombo1.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance10.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance10.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraCombo1.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.ultraCombo1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraCombo1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.ultraCombo1.DisplayLayout.Override.RowAppearance = appearance11;
            appearance12.ForeColor = System.Drawing.Color.Red;
            this.ultraCombo1.DisplayLayout.Override.RowSelectorAppearance = appearance12;
            this.ultraCombo1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ultraCombo1.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraCombo1.DisplayLayout.Override.SelectedCellAppearance = appearance13;
            appearance14.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance14.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraCombo1.DisplayLayout.Override.SelectedRowAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraCombo1.DisplayLayout.Override.TemplateAddRowAppearance = appearance15;
            appearance16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraCombo1.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance16;
            this.ultraCombo1.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraCombo1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraCombo1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraCombo1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraCombo1.DisplayLayout.UseFixedHeaders = true;
            this.ultraCombo1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraCombo1.DisplayMember = "Nombre";
            this.ultraCombo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraCombo1.LimitToList = true;
            this.ultraCombo1.Location = new System.Drawing.Point(13, 19);
            this.ultraCombo1.Name = "ultraCombo1";
            this.ultraCombo1.Size = new System.Drawing.Size(211, 22);
            this.ultraCombo1.TabIndex = 0;
            this.ultraCombo1.ValueMember = "Clave";
            this.ultraCombo1.ValueChanged += new System.EventHandler(this.UltraCombo1ValueChanged);
            // 
            // ultraDataSource1
            // 
            this.ultraDataSource1.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2});
            this.ultraDataSource1.Rows.AddRange(new object[] {
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Clave")),
                        ((object)("Cliente")),
                        ((object)("Nombre")),
                        ((object)("De un cliente"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Clave")),
                        ((object)("Fecha")),
                        ((object)("Nombre")),
                        ((object)("A partir de una fecha"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Clave")),
                        ((object)("SinActualizar")),
                        ((object)("Nombre")),
                        ((object)("Sin Actualizar desde"))})});
            // 
            // ultraCalendarCombo1
            // 
            this.ultraCalendarCombo1.DateButtons.Add(dateButton1);
            this.ultraCalendarCombo1.Location = new System.Drawing.Point(26, 75);
            this.ultraCalendarCombo1.Name = "ultraCalendarCombo1";
            this.ultraCalendarCombo1.NonAutoSizeHeight = 21;
            this.ultraCalendarCombo1.Size = new System.Drawing.Size(88, 21);
            this.ultraCalendarCombo1.TabIndex = 2;
            this.ultraCalendarCombo1.Value = new System.DateTime(2014, 3, 14, 0, 0, 0, 0);
            this.ultraCalendarCombo1.Visible = false;
            // 
            // clientesListaUltraCombo
            // 
            this.clientesListaUltraCombo.AllowNull = Infragistics.Win.DefaultableBoolean.True;
            this.clientesListaUltraCombo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.clientesListaUltraCombo.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
            this.clientesListaUltraCombo.DataSource = this.clientesListaBindingSource;
            ultraGridBand2.ColHeadersVisible = false;
            ultraGridColumn8.Header.VisiblePosition = 0;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn9.Header.VisiblePosition = 1;
            ultraGridColumn9.MinLength = 300;
            ultraGridColumn9.MinWidth = 300;
            ultraGridColumn10.Header.VisiblePosition = 2;
            ultraGridColumn10.Hidden = true;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10});
            ultraGridBand2.GroupHeadersVisible = false;
            this.clientesListaUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.clientesListaUltraCombo.DisplayMember = "NombreCompleto";
            this.clientesListaUltraCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesListaUltraCombo.Location = new System.Drawing.Point(26, 75);
            this.clientesListaUltraCombo.Name = "clientesListaUltraCombo";
            this.clientesListaUltraCombo.Size = new System.Drawing.Size(383, 22);
            this.clientesListaUltraCombo.TabIndex = 4;
            this.clientesListaUltraCombo.ValueMember = "idCliente";
            this.clientesListaUltraCombo.Visible = false;
            this.clientesListaUltraCombo.ValueChanged += new System.EventHandler(this.ClientesListaUltraComboValueChanged);
            // 
            // clientesListaBindingSource
            // 
            this.clientesListaBindingSource.DataMember = "ClientesLista";
            this.clientesListaBindingSource.DataSource = this.dsClientesLista;
            // 
            // dsClientesLista
            // 
            this.dsClientesLista.DataSetName = "DsClientesLista";
            this.dsClientesLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormReportHistRenglonesMoldesFactutra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(419, 162);
            this.Controls.Add(this.clientesListaUltraCombo);
            this.Controls.Add(this.ultraCalendarCombo1);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "FormReportHistRenglonesMoldesFactutra";
            this.Text = "Histórico de Renglones de Moldes de Factura";
            this.Load += new System.EventHandler(this.FormReportHistRenglonesMoldesFactutraLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraGroupBox1, 0);
            this.Controls.SetChildIndex(this.ultraCalendarCombo1, 0);
            this.Controls.SetChildIndex(this.clientesListaUltraCombo, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCombo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarCombo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesListaUltraCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientesLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraCombo1;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource1;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarCombo1;
        private WS.DsClientesLista dsClientesLista;
        private System.Windows.Forms.BindingSource clientesListaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraCombo clientesListaUltraCombo;

    }
}

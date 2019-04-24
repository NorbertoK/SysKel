namespace Dirección
{
    partial class FormEstPrest
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idReporte");
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
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idReporte");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre");
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            this.ultraComboReportes = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.ultraDataSourceReportes = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraCalendarComboDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraCalendarComboHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraLabelDesde = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelHasta = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelInclusive = new Infragistics.Win.Misc.UltraLabel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraComboReportes
            // 
            this.ultraComboReportes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ultraComboReportes.DataSource = this.ultraDataSourceReportes;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboReportes.DisplayLayout.Appearance = appearance1;
            this.ultraComboReportes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 622;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 302;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2});
            this.ultraComboReportes.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraComboReportes.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraComboReportes.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboReportes.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboReportes.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboReportes.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ultraComboReportes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboReportes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboReportes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboReportes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboReportes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboReportes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboReportes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboReportes.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboReportes.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraComboReportes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboReportes.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ultraComboReportes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ultraComboReportes.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ultraComboReportes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboReportes.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboReportes.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboReportes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ultraComboReportes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboReportes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboReportes.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboReportes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboReportes.DisplayMember = "Nombre";
            this.ultraComboReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraComboReportes.LimitToList = true;
            this.ultraComboReportes.Location = new System.Drawing.Point(12, 12);
            this.ultraComboReportes.Name = "ultraComboReportes";
            this.ultraComboReportes.Size = new System.Drawing.Size(321, 22);
            this.ultraComboReportes.TabIndex = 0;
            this.ultraComboReportes.Text = "Elija el reporte...";
            this.ultraComboReportes.ValueMember = "idReporte";
            this.ultraComboReportes.ItemNotInList += new Infragistics.Win.UltraWinGrid.ItemNotInListEventHandler(UltraComboReportesItemNotInList);
            this.ultraComboReportes.ValueChanged += new System.EventHandler(this.UltraComboReportesValueChanged);
            // 
            // ultraDataSourceReportes
            // 
            this.ultraDataSourceReportes.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2});
            this.ultraDataSourceReportes.Rows.AddRange(new object[] {
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("idReporte")),
                        ((object)("LocCod")),
                        ((object)("Nombre")),
                        ((object)("Por Localidad y Código"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("idReporte")),
                        ((object)("CodLoc")),
                        ((object)("Nombre")),
                        ((object)("Por Código y Localidad"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("idReporte")),
                        ((object)("LocMotCod")),
                        ((object)("Nombre")),
                        ((object)("Por Localidad, Motivo de Llamado y Código"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("idReporte")),
                        ((object)("MedicUtil")),
                        ((object)("Nombre")),
                        ((object)("Medicamentos Utilizados (para Excel)"))})});
            // 
            // ultraCalendarComboDesde
            // 
            this.ultraCalendarComboDesde.BackColor = System.Drawing.SystemColors.Window;
            dateButton1.Caption = "Hoy";
            this.ultraCalendarComboDesde.DateButtons.Add(dateButton1);
            this.ultraCalendarComboDesde.Location = new System.Drawing.Point(130, 40);
            this.ultraCalendarComboDesde.Name = "ultraCalendarComboDesde";
            this.ultraCalendarComboDesde.NonAutoSizeHeight = 21;
            this.ultraCalendarComboDesde.Size = new System.Drawing.Size(87, 21);
            this.ultraCalendarComboDesde.TabIndex = 1;
            // 
            // ultraCalendarComboHasta
            // 
            this.ultraCalendarComboHasta.BackColor = System.Drawing.SystemColors.Window;
            dateButton2.Caption = "Hoy";
            this.ultraCalendarComboHasta.DateButtons.Add(dateButton2);
            this.ultraCalendarComboHasta.Location = new System.Drawing.Point(130, 67);
            this.ultraCalendarComboHasta.Name = "ultraCalendarComboHasta";
            this.ultraCalendarComboHasta.NonAutoSizeHeight = 21;
            this.ultraCalendarComboHasta.Size = new System.Drawing.Size(87, 21);
            this.ultraCalendarComboHasta.TabIndex = 2;
            // 
            // ultraLabelDesde
            // 
            this.ultraLabelDesde.Location = new System.Drawing.Point(87, 43);
            this.ultraLabelDesde.Name = "ultraLabelDesde";
            this.ultraLabelDesde.Size = new System.Drawing.Size(37, 14);
            this.ultraLabelDesde.TabIndex = 3;
            this.ultraLabelDesde.Text = "Desde";
            // 
            // ultraLabelHasta
            // 
            this.ultraLabelHasta.Location = new System.Drawing.Point(90, 70);
            this.ultraLabelHasta.Name = "ultraLabelHasta";
            this.ultraLabelHasta.Size = new System.Drawing.Size(34, 14);
            this.ultraLabelHasta.TabIndex = 4;
            this.ultraLabelHasta.Text = "Hasta";
            // 
            // ultraLabelInclusive
            // 
            this.ultraLabelInclusive.Location = new System.Drawing.Point(223, 70);
            this.ultraLabelInclusive.Name = "ultraLabelInclusive";
            this.ultraLabelInclusive.Size = new System.Drawing.Size(48, 14);
            this.ultraLabelInclusive.TabIndex = 5;
            this.ultraLabelInclusive.Text = "inclusive";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(177, 105);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelarClick);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = false;
            this.buttonAceptar.Location = new System.Drawing.Point(258, 106);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 7;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // FormEstPrest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 140);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.ultraLabelInclusive);
            this.Controls.Add(this.ultraLabelHasta);
            this.Controls.Add(this.ultraLabelDesde);
            this.Controls.Add(this.ultraCalendarComboHasta);
            this.Controls.Add(this.ultraCalendarComboDesde);
            this.Controls.Add(this.ultraComboReportes);
            this.Name = "FormEstPrest";
            this.Text = "Estadística de Prestaciones";
            this.Load += new System.EventHandler(this.FormEstPrestLoad);
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboReportes;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceReportes;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarComboDesde;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarComboHasta;
        private Infragistics.Win.Misc.UltraLabel ultraLabelDesde;
        private Infragistics.Win.Misc.UltraLabel ultraLabelHasta;
        private Infragistics.Win.Misc.UltraLabel ultraLabelInclusive;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
    }
}
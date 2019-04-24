namespace Dirección
{
    partial class FormReportEstadoDeLaCobranza
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cargo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluidoEnTodosLosCobradores");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.ultraCalendarComboFecha = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraCheckEditorInactivos = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.empleadosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmpleadosLista = new Dirección.WS.DsEmpleadosLista();
            this.ultraComboCobradores = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraNumericEditorMeses = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraCheckEditorMostrarFuturo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboCobradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditorMeses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(118, 205);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelarClick);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(199, 205);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 9;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // ultraCalendarComboFecha
            // 
            this.ultraCalendarComboFecha.BackColor = System.Drawing.SystemColors.Window;
            this.ultraCalendarComboFecha.DateButtons.Add(dateButton1);
            this.ultraCalendarComboFecha.Location = new System.Drawing.Point(146, 12);
            this.ultraCalendarComboFecha.Name = "ultraCalendarComboFecha";
            this.ultraCalendarComboFecha.NonAutoSizeHeight = 21;
            this.ultraCalendarComboFecha.Size = new System.Drawing.Size(105, 21);
            this.ultraCalendarComboFecha.SpinButtonsVisible = true;
            this.ultraCalendarComboFecha.TabIndex = 10;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(12, 15);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(128, 14);
            this.ultraLabel1.TabIndex = 11;
            this.ultraLabel1.Text = "Estado de la cobranza al";
            // 
            // ultraCheckEditorInactivos
            // 
            this.ultraCheckEditorInactivos.Location = new System.Drawing.Point(6, 19);
            this.ultraCheckEditorInactivos.Name = "ultraCheckEditorInactivos";
            this.ultraCheckEditorInactivos.Size = new System.Drawing.Size(237, 20);
            this.ultraCheckEditorInactivos.TabIndex = 13;
            this.ultraCheckEditorInactivos.Text = "Mostrar también los cobradores inactivos.";
            // 
            // empleadosListaBindingSource
            // 
            this.empleadosListaBindingSource.DataMember = "EmpleadosLista";
            this.empleadosListaBindingSource.DataSource = this.dsEmpleadosLista;
            // 
            // dsEmpleadosLista
            // 
            this.dsEmpleadosLista.DataSetName = "DsEmpleadosLista";
            this.dsEmpleadosLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraComboCobradores
            // 
            this.ultraComboCobradores.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ultraComboCobradores.DataSource = this.empleadosListaBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboCobradores.DisplayLayout.Appearance = appearance1;
            this.ultraComboCobradores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 63;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Hidden = true;
            ultraGridColumn2.Width = 31;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn3.Width = 17;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn4.Width = 33;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn5.Width = 33;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Width = 75;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn7.Width = 85;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7});
            this.ultraComboCobradores.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraComboCobradores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraComboCobradores.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboCobradores.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboCobradores.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboCobradores.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ultraComboCobradores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboCobradores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboCobradores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboCobradores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboCobradores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboCobradores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboCobradores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboCobradores.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboCobradores.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraComboCobradores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboCobradores.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ultraComboCobradores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ultraComboCobradores.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ultraComboCobradores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboCobradores.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboCobradores.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboCobradores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ultraComboCobradores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboCobradores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboCobradores.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboCobradores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboCobradores.DisplayMember = "NombApel";
            this.ultraComboCobradores.LimitToList = true;
            this.ultraComboCobradores.Location = new System.Drawing.Point(45, 45);
            this.ultraComboCobradores.Name = "ultraComboCobradores";
            this.ultraComboCobradores.NullText = "Todos";
            this.ultraComboCobradores.Size = new System.Drawing.Size(179, 22);
            this.ultraComboCobradores.TabIndex = 16;
            this.ultraComboCobradores.Text = "Todos";
            this.ultraComboCobradores.ValueMember = "idEmpleado";
            this.ultraComboCobradores.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraComboCobradoresRowSelected);
            this.ultraComboCobradores.ItemNotInList += new Infragistics.Win.UltraWinGrid.ItemNotInListEventHandler(UltraComboCobradoresItemNotInList);
            this.ultraComboCobradores.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraComboCobradoresBeforeDropDown);
            this.ultraComboCobradores.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraComboCobradoresFilterRow);
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.AutoSize = true;
            this.ultraLabel2.Location = new System.Drawing.Point(4, 20);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(110, 14);
            this.ultraLabel2.TabIndex = 18;
            this.ultraLabel2.Text = "La cobertura actual y";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.AutoSize = true;
            this.ultraLabel3.Location = new System.Drawing.Point(163, 20);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(99, 14);
            this.ultraLabel3.TabIndex = 19;
            this.ultraLabel3.Text = "meses hacia atrás.";
            // 
            // ultraNumericEditorMeses
            // 
            this.ultraNumericEditorMeses.Location = new System.Drawing.Point(113, 16);
            this.ultraNumericEditorMeses.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw;
            this.ultraNumericEditorMeses.MaskInput = "nnnnnnnnn";
            this.ultraNumericEditorMeses.Name = "ultraNumericEditorMeses";
            this.ultraNumericEditorMeses.Size = new System.Drawing.Size(44, 21);
            this.ultraNumericEditorMeses.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.ultraNumericEditorMeses.TabIndex = 20;
            // 
            // ultraCheckEditorMostrarFuturo
            // 
            this.ultraCheckEditorMostrarFuturo.Location = new System.Drawing.Point(6, 45);
            this.ultraCheckEditorMostrarFuturo.Name = "ultraCheckEditorMostrarFuturo";
            this.ultraCheckEditorMostrarFuturo.Size = new System.Drawing.Size(237, 20);
            this.ultraCheckEditorMostrarFuturo.TabIndex = 21;
            this.ultraCheckEditorMostrarFuturo.Text = "Mostrar períodos futuros.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ultraCheckEditorInactivos);
            this.groupBox1.Controls.Add(this.ultraComboCobradores);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 76);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cobrador";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ultraLabel3);
            this.groupBox2.Controls.Add(this.ultraLabel2);
            this.groupBox2.Controls.Add(this.ultraCheckEditorMostrarFuturo);
            this.groupBox2.Controls.Add(this.ultraNumericEditorMeses);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 74);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informe";
            // 
            // FormReportEstadoDeLaCobranza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 236);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.ultraCalendarComboFecha);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Name = "FormReportEstadoDeLaCobranza";
            this.Text = "Estado de la Cobranza";
            this.Load += new System.EventHandler(this.FormReportEstadoDeLaCobranzaLoad);
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboCobradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditorMeses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarComboFecha;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditorInactivos;
        private System.Windows.Forms.BindingSource empleadosListaBindingSource;
        private System.ComponentModel.IContainer components;
        private Dirección.WS.DsEmpleadosLista dsEmpleadosLista;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboCobradores;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditorMeses;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditorMostrarFuturo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
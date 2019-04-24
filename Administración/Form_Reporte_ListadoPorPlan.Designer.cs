namespace Administración
{
    partial class FormReporteListadoPorPlan
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
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Planes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PadronExterno");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.ultraCalendarCombo1 = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraComboPlanes = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPlanes = new Administración.WS.DsPlanes();
            this.ultraLabelFecha = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelMensaje = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelPlan = new Infragistics.Win.Misc.UltraLabel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarCombo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraCalendarCombo1
            // 
            this.ultraCalendarCombo1.BackColor = System.Drawing.SystemColors.Window;
            dateButton1.Caption = "Hoy";
            this.ultraCalendarCombo1.DateButtons.Add(dateButton1);
            this.ultraCalendarCombo1.Location = new System.Drawing.Point(68, 12);
            this.ultraCalendarCombo1.Name = "ultraCalendarCombo1";
            this.ultraCalendarCombo1.NonAutoSizeHeight = 21;
            this.ultraCalendarCombo1.Size = new System.Drawing.Size(88, 21);
            this.ultraCalendarCombo1.TabIndex = 0;
            this.ultraCalendarCombo1.Value = new System.DateTime(2007, 7, 15, 0, 0, 0, 0);
            // 
            // ultraComboPlanes
            // 
            this.ultraComboPlanes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ultraComboPlanes.DataSource = this.planesBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboPlanes.DisplayLayout.Appearance = appearance1;
            this.ultraComboPlanes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 54;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 192;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn3.Width = 24;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn4.Width = 34;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn5.Width = 46;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5});
            this.ultraComboPlanes.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraComboPlanes.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraComboPlanes.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboPlanes.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboPlanes.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboPlanes.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ultraComboPlanes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboPlanes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboPlanes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboPlanes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboPlanes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboPlanes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboPlanes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboPlanes.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboPlanes.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraComboPlanes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboPlanes.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ultraComboPlanes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ultraComboPlanes.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ultraComboPlanes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboPlanes.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboPlanes.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboPlanes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ultraComboPlanes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboPlanes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboPlanes.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboPlanes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboPlanes.DisplayMember = "Nombre";
            this.ultraComboPlanes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Default;
            this.ultraComboPlanes.LimitToList = true;
            this.ultraComboPlanes.Location = new System.Drawing.Point(68, 39);
            this.ultraComboPlanes.Name = "ultraComboPlanes";
            this.ultraComboPlanes.Size = new System.Drawing.Size(211, 22);
            this.ultraComboPlanes.TabIndex = 1;
            this.ultraComboPlanes.ValueMember = "idPlan";
            this.ultraComboPlanes.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraComboPlanesRowSelected);
            this.ultraComboPlanes.ItemNotInList += new Infragistics.Win.UltraWinGrid.ItemNotInListEventHandler(UltraComboPlanesItemNotInList);
            this.ultraComboPlanes.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(UltraComboPlanesFilterRow);
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataSource = this.dsPlanes;
            this.planesBindingSource.Position = 0;
            // 
            // dsPlanes
            // 
            this.dsPlanes.DataSetName = "DsPlanes";
            this.dsPlanes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraLabelFecha
            // 
            this.ultraLabelFecha.Location = new System.Drawing.Point(9, 15);
            this.ultraLabelFecha.Name = "ultraLabelFecha";
            this.ultraLabelFecha.Size = new System.Drawing.Size(53, 14);
            this.ultraLabelFecha.TabIndex = 2;
            this.ultraLabelFecha.Text = "Listado al";
            // 
            // ultraLabelMensaje
            // 
            this.ultraLabelMensaje.Location = new System.Drawing.Point(73, 72);
            this.ultraLabelMensaje.Name = "ultraLabelMensaje";
            this.ultraLabelMensaje.Size = new System.Drawing.Size(97, 14);
            this.ultraLabelMensaje.TabIndex = 3;
            this.ultraLabelMensaje.Text = "Espere por favor...";
            this.ultraLabelMensaje.Visible = false;
            // 
            // ultraLabelPlan
            // 
            this.ultraLabelPlan.Location = new System.Drawing.Point(35, 43);
            this.ultraLabelPlan.Name = "ultraLabelPlan";
            this.ultraLabelPlan.Size = new System.Drawing.Size(27, 14);
            this.ultraLabelPlan.TabIndex = 4;
            this.ultraLabelPlan.Text = "Plan";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(123, 67);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelarClick);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = false;
            this.buttonAceptar.Location = new System.Drawing.Point(204, 67);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // FormReporteListadoPorPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 97);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.ultraLabelPlan);
            this.Controls.Add(this.ultraLabelMensaje);
            this.Controls.Add(this.ultraLabelFecha);
            this.Controls.Add(this.ultraComboPlanes);
            this.Controls.Add(this.ultraCalendarCombo1);
            this.Name = "FormReporteListadoPorPlan";
            this.Text = "Listado por Plan";
            this.Load += new System.EventHandler(this.FormReporteListadoPorPlanLoad);
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarCombo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarCombo1;
        private WS.DsPlanes dsPlanes;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboPlanes;
        private Infragistics.Win.Misc.UltraLabel ultraLabelFecha;
        private Infragistics.Win.Misc.UltraLabel ultraLabelMensaje;
        private Infragistics.Win.Misc.UltraLabel ultraLabelPlan;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
    }
}
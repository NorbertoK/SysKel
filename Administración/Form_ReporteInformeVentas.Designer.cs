namespace Administración
{
    partial class FormReporteInformeVentas
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton3 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton4 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem3 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem5 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem6 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem7 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem8 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem9 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem10 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem11 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem12 = new Infragistics.Win.ValueListItem();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panelFechas = new System.Windows.Forms.Panel();
            this.ultraCalendarComboHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraCalendarComboDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.radioButtonMes = new System.Windows.Forms.RadioButton();
            this.radioButtonFechas = new System.Windows.Forms.RadioButton();
            this.panelMes = new System.Windows.Forms.Panel();
            this.ultraComboEditorMes = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraNumericEditorAnyo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.panelFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboDesde)).BeginInit();
            this.panelMes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditorMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditorAnyo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(165, 165);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(84, 165);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelarClick);
            // 
            // panelFechas
            // 
            this.panelFechas.Controls.Add(this.ultraCalendarComboHasta);
            this.panelFechas.Controls.Add(this.ultraLabel3);
            this.panelFechas.Controls.Add(this.ultraLabel2);
            this.panelFechas.Controls.Add(this.ultraLabel1);
            this.panelFechas.Controls.Add(this.ultraCalendarComboDesde);
            this.panelFechas.Enabled = false;
            this.panelFechas.Location = new System.Drawing.Point(37, 95);
            this.panelFechas.Name = "panelFechas";
            this.panelFechas.Size = new System.Drawing.Size(203, 56);
            this.panelFechas.TabIndex = 7;
            // 
            // ultraCalendarComboHasta
            // 
            this.ultraCalendarComboHasta.AllowMonthSelection = true;
            this.ultraCalendarComboHasta.AllowNull = false;
            appearance1.TextHAlignAsString = "Center";
            this.ultraCalendarComboHasta.Appearance = appearance1;
            this.ultraCalendarComboHasta.BackColor = System.Drawing.SystemColors.Window;
            this.ultraCalendarComboHasta.DateButtons.Add(dateButton3);
            this.ultraCalendarComboHasta.Format = "dd/MM/yyyy";
            this.ultraCalendarComboHasta.Location = new System.Drawing.Point(45, 29);
            this.ultraCalendarComboHasta.Name = "ultraCalendarComboHasta";
            this.ultraCalendarComboHasta.NonAutoSizeHeight = 21;
            this.ultraCalendarComboHasta.Size = new System.Drawing.Size(101, 21);
            this.ultraCalendarComboHasta.SpinButtonIncrement = Infragistics.Win.UltraWinSchedule.SpinIncrementUnit.Months;
            this.ultraCalendarComboHasta.SpinButtonsVisible = true;
            this.ultraCalendarComboHasta.TabIndex = 11;
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.AutoSize = true;
            this.ultraLabel3.Location = new System.Drawing.Point(5, 32);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(34, 14);
            this.ultraLabel3.TabIndex = 10;
            this.ultraLabel3.Text = "Hasta";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.AutoSize = true;
            this.ultraLabel2.Location = new System.Drawing.Point(147, 32);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(51, 14);
            this.ultraLabel2.TabIndex = 9;
            this.ultraLabel2.Text = "inclusive.";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(2, 5);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(37, 14);
            this.ultraLabel1.TabIndex = 8;
            this.ultraLabel1.Text = "Desde";
            // 
            // ultraCalendarComboDesde
            // 
            this.ultraCalendarComboDesde.AllowMonthSelection = true;
            this.ultraCalendarComboDesde.AllowNull = false;
            appearance2.TextHAlignAsString = "Center";
            this.ultraCalendarComboDesde.Appearance = appearance2;
            this.ultraCalendarComboDesde.BackColor = System.Drawing.SystemColors.Window;
            this.ultraCalendarComboDesde.DateButtons.Add(dateButton4);
            this.ultraCalendarComboDesde.Format = "dd/MM/yyyy";
            this.ultraCalendarComboDesde.Location = new System.Drawing.Point(45, 2);
            this.ultraCalendarComboDesde.Name = "ultraCalendarComboDesde";
            this.ultraCalendarComboDesde.NonAutoSizeHeight = 21;
            this.ultraCalendarComboDesde.Size = new System.Drawing.Size(101, 21);
            this.ultraCalendarComboDesde.SpinButtonIncrement = Infragistics.Win.UltraWinSchedule.SpinIncrementUnit.Months;
            this.ultraCalendarComboDesde.SpinButtonsVisible = true;
            this.ultraCalendarComboDesde.TabIndex = 7;
            // 
            // radioButtonMes
            // 
            this.radioButtonMes.AutoSize = true;
            this.radioButtonMes.Checked = true;
            this.radioButtonMes.Location = new System.Drawing.Point(12, 12);
            this.radioButtonMes.Name = "radioButtonMes";
            this.radioButtonMes.Size = new System.Drawing.Size(76, 17);
            this.radioButtonMes.TabIndex = 8;
            this.radioButtonMes.TabStop = true;
            this.radioButtonMes.Text = "De un mes";
            this.radioButtonMes.UseVisualStyleBackColor = true;
            // 
            // radioButtonFechas
            // 
            this.radioButtonFechas.AutoSize = true;
            this.radioButtonFechas.Location = new System.Drawing.Point(12, 72);
            this.radioButtonFechas.Name = "radioButtonFechas";
            this.radioButtonFechas.Size = new System.Drawing.Size(85, 17);
            this.radioButtonFechas.TabIndex = 9;
            this.radioButtonFechas.Text = "Entre fechas";
            this.radioButtonFechas.UseVisualStyleBackColor = true;
            this.radioButtonFechas.CheckedChanged += new System.EventHandler(this.RadioButtonFechasCheckedChanged);
            // 
            // panelMes
            // 
            this.panelMes.Controls.Add(this.ultraLabel4);
            this.panelMes.Controls.Add(this.ultraNumericEditorAnyo);
            this.panelMes.Controls.Add(this.ultraComboEditorMes);
            this.panelMes.Location = new System.Drawing.Point(37, 31);
            this.panelMes.Name = "panelMes";
            this.panelMes.Size = new System.Drawing.Size(203, 30);
            this.panelMes.TabIndex = 10;
            // 
            // ultraComboEditorMes
            // 
            valueListItem1.DataValue = "01";
            valueListItem1.DisplayText = "Enero";
            valueListItem2.DataValue = "02";
            valueListItem2.DisplayText = "Febrero";
            valueListItem3.DataValue = "03";
            valueListItem3.DisplayText = "Marzo";
            valueListItem4.DataValue = "04";
            valueListItem4.DisplayText = "Abril";
            valueListItem5.DataValue = "05";
            valueListItem5.DisplayText = "Mayo";
            valueListItem6.DataValue = "06";
            valueListItem6.DisplayText = "Junio";
            valueListItem7.DataValue = "07";
            valueListItem7.DisplayText = "Julio";
            valueListItem8.DataValue = "08";
            valueListItem8.DisplayText = "Agosto";
            valueListItem9.DataValue = "09";
            valueListItem9.DisplayText = "Septiembre";
            valueListItem10.DataValue = "10";
            valueListItem10.DisplayText = "Octubre";
            valueListItem11.DataValue = "11";
            valueListItem11.DisplayText = "Noviembre";
            valueListItem12.DataValue = "12";
            valueListItem12.DisplayText = "Diciembre";
            this.ultraComboEditorMes.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1,
            valueListItem2,
            valueListItem3,
            valueListItem4,
            valueListItem5,
            valueListItem6,
            valueListItem7,
            valueListItem8,
            valueListItem9,
            valueListItem10,
            valueListItem11,
            valueListItem12});
            this.ultraComboEditorMes.Location = new System.Drawing.Point(2, 3);
            this.ultraComboEditorMes.Name = "ultraComboEditorMes";
            this.ultraComboEditorMes.Size = new System.Drawing.Size(86, 21);
            this.ultraComboEditorMes.TabIndex = 0;
            // 
            // ultraNumericEditorAnyo
            // 
            this.ultraNumericEditorAnyo.Location = new System.Drawing.Point(107, 3);
            this.ultraNumericEditorAnyo.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw;
            this.ultraNumericEditorAnyo.MaxValue = 2999;
            this.ultraNumericEditorAnyo.MinValue = 2000;
            this.ultraNumericEditorAnyo.Name = "ultraNumericEditorAnyo";
            this.ultraNumericEditorAnyo.Size = new System.Drawing.Size(52, 21);
            this.ultraNumericEditorAnyo.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.ultraNumericEditorAnyo.TabIndex = 1;
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.AutoSize = true;
            this.ultraLabel4.Location = new System.Drawing.Point(89, 7);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(17, 14);
            this.ultraLabel4.TabIndex = 2;
            this.ultraLabel4.Text = "de";
            // 
            // FormReporteInformeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 200);
            this.Controls.Add(this.panelMes);
            this.Controls.Add(this.radioButtonFechas);
            this.Controls.Add(this.radioButtonMes);
            this.Controls.Add(this.panelFechas);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Name = "FormReporteInformeVentas";
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.FormSolicitarPeriodoLoad);
            this.panelFechas.ResumeLayout(false);
            this.panelFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboDesde)).EndInit();
            this.panelMes.ResumeLayout(false);
            this.panelMes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditorMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditorAnyo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Panel panelFechas;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarComboHasta;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarComboDesde;
        private System.Windows.Forms.RadioButton radioButtonMes;
        private System.Windows.Forms.RadioButton radioButtonFechas;
        private System.Windows.Forms.Panel panelMes;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor ultraComboEditorMes;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditorAnyo;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
    }
}
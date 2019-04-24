namespace Administración
{
    partial class FormReportDeudores
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportDeudores));
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            this.dsDeudores1 = new Administración.DsDeudores();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBoxListado = new System.Windows.Forms.CheckBox();
            this.checkBoxResumen = new System.Windows.Forms.CheckBox();
            this.checkBoxExcel = new System.Windows.Forms.CheckBox();
            this.ultraFormattedLinkLabel1 = new Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel();
            this.labelProcesando = new System.Windows.Forms.Label();
            this.ultraLabelFecha = new Infragistics.Win.Misc.UltraLabel();
            this.ultraCalendarCombo1 = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeudores1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarCombo1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(393, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(312, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelProcesando);
            this.panel1.Location = new System.Drawing.Point(0, 322);
            this.panel1.Size = new System.Drawing.Size(483, 50);
            this.panel1.Controls.SetChildIndex(this.labelProcesando, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(312, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsDeudores1
            // 
            this.dsDeudores1.DataSetName = "DsDeudores";
            this.dsDeudores1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1RunWorkerCompleted);
            // 
            // checkBoxListado
            // 
            this.checkBoxListado.AutoSize = true;
            this.checkBoxListado.Checked = true;
            this.checkBoxListado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxListado.Location = new System.Drawing.Point(213, 12);
            this.checkBoxListado.Name = "checkBoxListado";
            this.checkBoxListado.Size = new System.Drawing.Size(60, 17);
            this.checkBoxListado.TabIndex = 1;
            this.checkBoxListado.Text = "Listado";
            this.checkBoxListado.UseVisualStyleBackColor = true;
            this.checkBoxListado.CheckStateChanged += new System.EventHandler(this.CheckBoxListadoCheckStateChanged);
            // 
            // checkBoxResumen
            // 
            this.checkBoxResumen.AutoSize = true;
            this.checkBoxResumen.Checked = true;
            this.checkBoxResumen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxResumen.Location = new System.Drawing.Point(279, 12);
            this.checkBoxResumen.Name = "checkBoxResumen";
            this.checkBoxResumen.Size = new System.Drawing.Size(71, 17);
            this.checkBoxResumen.TabIndex = 2;
            this.checkBoxResumen.Text = "Resumen";
            this.checkBoxResumen.UseVisualStyleBackColor = true;
            this.checkBoxResumen.CheckStateChanged += new System.EventHandler(this.CheckBoxResumenCheckStateChanged);
            // 
            // checkBoxExcel
            // 
            this.checkBoxExcel.AutoSize = true;
            this.checkBoxExcel.Checked = true;
            this.checkBoxExcel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExcel.Location = new System.Drawing.Point(356, 12);
            this.checkBoxExcel.Name = "checkBoxExcel";
            this.checkBoxExcel.Size = new System.Drawing.Size(52, 17);
            this.checkBoxExcel.TabIndex = 3;
            this.checkBoxExcel.Text = "Excel";
            this.checkBoxExcel.UseVisualStyleBackColor = true;
            this.checkBoxExcel.CheckStateChanged += new System.EventHandler(this.CheckBoxExcelCheckStateChanged);
            // 
            // ultraFormattedLinkLabel1
            // 
            this.ultraFormattedLinkLabel1.Location = new System.Drawing.Point(12, 38);
            this.ultraFormattedLinkLabel1.Name = "ultraFormattedLinkLabel1";
            this.ultraFormattedLinkLabel1.Size = new System.Drawing.Size(455, 288);
            this.ultraFormattedLinkLabel1.TabIndex = 4;
            this.ultraFormattedLinkLabel1.TabStop = true;
            this.ultraFormattedLinkLabel1.Value = resources.GetString("ultraFormattedLinkLabel1.Value");
            // 
            // labelProcesando
            // 
            this.labelProcesando.AutoSize = true;
            this.labelProcesando.Location = new System.Drawing.Point(126, 16);
            this.labelProcesando.Name = "labelProcesando";
            this.labelProcesando.Size = new System.Drawing.Size(220, 13);
            this.labelProcesando.TabIndex = 3;
            this.labelProcesando.Text = "Procesando... Puede seguir con otras tareas.";
            this.labelProcesando.Visible = false;
            // 
            // ultraLabelFecha
            // 
            this.ultraLabelFecha.AutoSize = true;
            this.ultraLabelFecha.Location = new System.Drawing.Point(12, 15);
            this.ultraLabelFecha.Name = "ultraLabelFecha";
            this.ultraLabelFecha.Size = new System.Drawing.Size(65, 14);
            this.ultraLabelFecha.TabIndex = 6;
            this.ultraLabelFecha.Text = "Deudores al";
            // 
            // ultraCalendarCombo1
            // 
            dateButton2.Caption = "Hoy";
            this.ultraCalendarCombo1.DateButtons.Add(dateButton2);
            this.ultraCalendarCombo1.Location = new System.Drawing.Point(78, 10);
            this.ultraCalendarCombo1.Name = "ultraCalendarCombo1";
            this.ultraCalendarCombo1.NonAutoSizeHeight = 21;
            this.ultraCalendarCombo1.Size = new System.Drawing.Size(85, 21);
            this.ultraCalendarCombo1.TabIndex = 5;
            this.ultraCalendarCombo1.Value = new System.DateTime(2007, 7, 15, 0, 0, 0, 0);
            // 
            // FormReportDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(482, 370);
            this.Controls.Add(this.ultraLabelFecha);
            this.Controls.Add(this.ultraCalendarCombo1);
            this.Controls.Add(this.checkBoxListado);
            this.Controls.Add(this.checkBoxResumen);
            this.Controls.Add(this.checkBoxExcel);
            this.Controls.Add(this.ultraFormattedLinkLabel1);
            this.Name = "FormReportDeudores";
            this.Text = "Deudores";
            this.Load += new System.EventHandler(this.FormReportDeudores_Load);
            this.Controls.SetChildIndex(this.ultraFormattedLinkLabel1, 0);
            this.Controls.SetChildIndex(this.checkBoxExcel, 0);
            this.Controls.SetChildIndex(this.checkBoxResumen, 0);
            this.Controls.SetChildIndex(this.checkBoxListado, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraCalendarCombo1, 0);
            this.Controls.SetChildIndex(this.ultraLabelFecha, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeudores1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarCombo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DsDeudores dsDeudores1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkBoxListado;
        private System.Windows.Forms.CheckBox checkBoxResumen;
        private System.Windows.Forms.CheckBox checkBoxExcel;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel ultraFormattedLinkLabel1;
        private System.Windows.Forms.Label labelProcesando;
        private Infragistics.Win.Misc.UltraLabel ultraLabelFecha;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarCombo1;

    }
}

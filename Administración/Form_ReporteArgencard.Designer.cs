namespace Administración
{
    partial class FormReporteArgencard
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
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.ultraDateTimeEditorPeriodo = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraLabelPeriodo = new Infragistics.Win.Misc.UltraLabel();
            this.dsReporteMacro1 = new Administración.DsReporteMacro();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteMacro1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 82);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(95, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ultraDateTimeEditorPeriodo
            // 
            this.ultraDateTimeEditorPeriodo.DataBindings.Add(new System.Windows.Forms.Binding("Nullable", global::Administración.Properties.Settings.Default, "NoNullable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ultraDateTimeEditorPeriodo.Location = new System.Drawing.Point(143, 23);
            this.ultraDateTimeEditorPeriodo.MaskInput = "{LOC}mm/yyyy";
            this.ultraDateTimeEditorPeriodo.Name = "ultraDateTimeEditorPeriodo";
            this.ultraDateTimeEditorPeriodo.Nullable = global::Administración.Properties.Settings.Default.NoNullable;
            this.ultraDateTimeEditorPeriodo.Size = new System.Drawing.Size(77, 21);
            this.ultraDateTimeEditorPeriodo.TabIndex = 21;
            // 
            // ultraLabelPeriodo
            // 
            appearance3.TextHAlignAsString = "Left";
            this.ultraLabelPeriodo.Appearance = appearance3;
            this.ultraLabelPeriodo.AutoSize = true;
            this.ultraLabelPeriodo.Location = new System.Drawing.Point(39, 27);
            this.ultraLabelPeriodo.Name = "ultraLabelPeriodo";
            this.ultraLabelPeriodo.Size = new System.Drawing.Size(98, 14);
            this.ultraLabelPeriodo.TabIndex = 22;
            this.ultraLabelPeriodo.Text = "Período a Informar";
            // 
            // dsReporteMacro1
            // 
            this.dsReporteMacro1.DataSetName = "DsReporteMacro";
            this.dsReporteMacro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormReporteArgencard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(265, 130);
            this.Controls.Add(this.ultraDateTimeEditorPeriodo);
            this.Controls.Add(this.ultraLabelPeriodo);
            this.Name = "FormReporteArgencard";
            this.Text = "Reporte para Argencard";
            this.Load += new System.EventHandler(this.FormReporteArgencardLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraLabelPeriodo, 0);
            this.Controls.SetChildIndex(this.ultraDateTimeEditorPeriodo, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteMacro1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorPeriodo;
        private Infragistics.Win.Misc.UltraLabel ultraLabelPeriodo;
        private DsReporteMacro dsReporteMacro1;
    }
}

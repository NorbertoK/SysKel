namespace Administración
{
    partial class FormReporteNaranja
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.dsReporteNaranja = new Administración.WS.DsReporteNaranja();
            this.ultraDateTimeEditorPeriodo = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraLabelPeriodo = new Infragistics.Win.Misc.UltraLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteNaranja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Location = new System.Drawing.Point(105, 69);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 0;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelarClick);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAceptar.Location = new System.Drawing.Point(186, 69);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 1;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // dsReporteNaranja
            // 
            this.dsReporteNaranja.DataSetName = "DsReporteNaranja";
            this.dsReporteNaranja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDateTimeEditorPeriodo
            // 
            this.ultraDateTimeEditorPeriodo.DataBindings.Add(new System.Windows.Forms.Binding("Nullable", global::Administración.Properties.Settings.Default, "NoNullable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ultraDateTimeEditorPeriodo.Location = new System.Drawing.Point(151, 25);
            this.ultraDateTimeEditorPeriodo.MaskInput = "{LOC}mm/yyyy";
            this.ultraDateTimeEditorPeriodo.Name = "ultraDateTimeEditorPeriodo";
            this.ultraDateTimeEditorPeriodo.Nullable = global::Administración.Properties.Settings.Default.NoNullable;
            this.ultraDateTimeEditorPeriodo.Size = new System.Drawing.Size(77, 21);
            this.ultraDateTimeEditorPeriodo.TabIndex = 23;
            // 
            // ultraLabelPeriodo
            // 
            appearance3.TextHAlignAsString = "Left";
            this.ultraLabelPeriodo.Appearance = appearance3;
            this.ultraLabelPeriodo.AutoSize = true;
            this.ultraLabelPeriodo.Location = new System.Drawing.Point(47, 29);
            this.ultraLabelPeriodo.Name = "ultraLabelPeriodo";
            this.ultraLabelPeriodo.Size = new System.Drawing.Size(98, 14);
            this.ultraLabelPeriodo.TabIndex = 24;
            this.ultraLabelPeriodo.Text = "Período a Informar";
            // 
            // FormReporteNaranja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 104);
            this.ControlBox = false;
            this.Controls.Add(this.ultraDateTimeEditorPeriodo);
            this.Controls.Add(this.ultraLabelPeriodo);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Name = "FormReporteNaranja";
            this.Text = "Reporte para Tarjeta Naranja";
            this.Load += new System.EventHandler(this.FormReporteVisaLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteNaranja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private WS.DsReporteNaranja dsReporteNaranja;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorPeriodo;
        private Infragistics.Win.Misc.UltraLabel ultraLabelPeriodo;
    }
}
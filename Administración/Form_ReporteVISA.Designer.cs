namespace Administración
{
    partial class FormReporteVisa
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dsReporteVISA1 = new Administración.WS.DsReporteVISA();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.ultraLabelInforme = new Infragistics.Win.Misc.UltraLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteVISA1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsReporteVISA1
            // 
            this.dsReporteVISA1.DataSetName = "DsReporteVISA";
            this.dsReporteVISA1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Location = new System.Drawing.Point(101, 69);
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
            this.buttonAceptar.Location = new System.Drawing.Point(182, 69);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 1;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // ultraLabelInforme
            // 
            this.ultraLabelInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ultraLabelInforme.Location = new System.Drawing.Point(12, 12);
            this.ultraLabelInforme.Name = "ultraLabelInforme";
            this.ultraLabelInforme.Size = new System.Drawing.Size(245, 58);
            this.ultraLabelInforme.TabIndex = 2;
            this.ultraLabelInforme.Text = "ultraLabel1";
            // 
            // FormReporteVISA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 104);
            this.ControlBox = false;
            this.Controls.Add(this.ultraLabelInforme);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Name = "FormReporteVisa";
            this.Text = "Reporte para VISA";
            this.Load += new System.EventHandler(this.FormReporteVisaLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteVISA1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsReporteVISA dsReporteVISA1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private Infragistics.Win.Misc.UltraLabel ultraLabelInforme;
    }
}
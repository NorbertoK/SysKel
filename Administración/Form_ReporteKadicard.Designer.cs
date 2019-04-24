namespace Administración
{
    partial class FormReporteKadicard
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.ultraLabelInforme = new Infragistics.Win.Misc.UltraLabel();
            this.dsReporteKadicard1 = new Administración.WS.DsReporteKadicard();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteKadicard1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Location = new System.Drawing.Point(134, 69);
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
            this.buttonAceptar.Location = new System.Drawing.Point(215, 69);
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
            this.ultraLabelInforme.Size = new System.Drawing.Size(278, 58);
            this.ultraLabelInforme.TabIndex = 2;
            this.ultraLabelInforme.Text = "ultraLabel1";
            // 
            // dsReporteKadicard1
            // 
            this.dsReporteKadicard1.DataSetName = "DsReporteKadicard";
            this.dsReporteKadicard1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormReporteKadicard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 104);
            this.ControlBox = false;
            this.Controls.Add(this.ultraLabelInforme);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Name = "FormReporteKadicard";
            this.Text = "Reporte para Kadicard";
            this.Load += new System.EventHandler(this.FormReporteVisaLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteKadicard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private Infragistics.Win.Misc.UltraLabel ultraLabelInforme;
        private WS.DsReporteKadicard dsReporteKadicard1;
    }
}
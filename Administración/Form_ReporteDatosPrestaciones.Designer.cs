namespace Administración
{
    partial class FormReporteDatosPrestaciones
    {
 
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ultraDateTimeEditorDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraDateTimeEditorHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEspere = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(168, 16);
            this.buttonAceptar.Size = new System.Drawing.Size(85, 23);
            this.buttonAceptar.Text = "Ver el Reporte";
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(12, 13);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 86);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(87, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ultraDateTimeEditorDesde
            // 
            this.ultraDateTimeEditorDesde.Location = new System.Drawing.Point(56, 5);
            this.ultraDateTimeEditorDesde.MaskInput = "{LOC}dd/mm/yyyy";
            this.ultraDateTimeEditorDesde.Name = "ultraDateTimeEditorDesde";
            this.ultraDateTimeEditorDesde.Size = new System.Drawing.Size(102, 21);
            this.ultraDateTimeEditorDesde.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.ultraDateTimeEditorDesde.TabIndex = 1;
            // 
            // ultraDateTimeEditorHasta
            // 
            this.ultraDateTimeEditorHasta.Location = new System.Drawing.Point(56, 32);
            this.ultraDateTimeEditorHasta.MaskInput = "{LOC}dd/mm/yyyy";
            this.ultraDateTimeEditorHasta.Name = "ultraDateTimeEditorHasta";
            this.ultraDateTimeEditorHasta.Size = new System.Drawing.Size(102, 21);
            this.ultraDateTimeEditorHasta.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.ultraDateTimeEditorHasta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "inclusive.";
            // 
            // labelEspere
            // 
            this.labelEspere.AutoSize = true;
            this.labelEspere.Location = new System.Drawing.Point(84, 64);
            this.labelEspere.Name = "labelEspere";
            this.labelEspere.Size = new System.Drawing.Size(91, 13);
            this.labelEspere.TabIndex = 6;
            this.labelEspere.Text = "Espere, por favor.";
            this.labelEspere.Visible = false;
            // 
            // FormReporteDatosPrestaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(265, 134);
            this.Controls.Add(this.labelEspere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ultraDateTimeEditorHasta);
            this.Controls.Add(this.ultraDateTimeEditorDesde);
            this.Name = "FormReporteDatosPrestaciones";
            this.Text = "Datos de las Prestaciones";
            this.Controls.SetChildIndex(this.ultraDateTimeEditorDesde, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDateTimeEditorHasta, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.labelEspere, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorDesde;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEspere;
    }
}

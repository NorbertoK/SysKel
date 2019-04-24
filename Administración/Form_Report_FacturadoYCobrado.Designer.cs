namespace Administración
{
    partial class FormReportFacturadoYCobrado
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
            this.ultraDateTimeEditorHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraDateTimeEditorDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorDesde)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(168, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(87, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Size = new System.Drawing.Size(258, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(87, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ultraDateTimeEditorHasta
            // 
            this.ultraDateTimeEditorHasta.Location = new System.Drawing.Point(78, 44);
            this.ultraDateTimeEditorHasta.MaskInput = "dd/mm/yyyy";
            this.ultraDateTimeEditorHasta.Name = "ultraDateTimeEditorHasta";
            this.ultraDateTimeEditorHasta.Size = new System.Drawing.Size(88, 21);
            this.ultraDateTimeEditorHasta.TabIndex = 14;
            // 
            // ultraDateTimeEditorDesde
            // 
            this.ultraDateTimeEditorDesde.Location = new System.Drawing.Point(78, 17);
            this.ultraDateTimeEditorDesde.MaskInput = "dd/mm/yyyy";
            this.ultraDateTimeEditorDesde.Name = "ultraDateTimeEditorDesde";
            this.ultraDateTimeEditorDesde.Size = new System.Drawing.Size(88, 21);
            this.ultraDateTimeEditorDesde.TabIndex = 13;
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.AutoSize = true;
            this.ultraLabel4.Location = new System.Drawing.Point(35, 21);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(37, 14);
            this.ultraLabel4.TabIndex = 12;
            this.ultraLabel4.Text = "Desde";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.AutoSize = true;
            this.ultraLabel3.Location = new System.Drawing.Point(38, 48);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(34, 14);
            this.ultraLabel3.TabIndex = 11;
            this.ultraLabel3.Text = "Hasta";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.AutoSize = true;
            this.ultraLabel2.Location = new System.Drawing.Point(172, 48);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(51, 14);
            this.ultraLabel2.TabIndex = 10;
            this.ultraLabel2.Text = "inclusive.";
            // 
            // FormReportFacturadoYCobrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(257, 129);
            this.Controls.Add(this.ultraDateTimeEditorHasta);
            this.Controls.Add(this.ultraDateTimeEditorDesde);
            this.Controls.Add(this.ultraLabel4);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.ultraLabel2);
            this.Name = "FormReportFacturadoYCobrado";
            this.Text = "Facturado y Cobrado por Cliente y Negocio";
            this.Load += new System.EventHandler(this.Form_Report_FacturadoYCobrado_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraLabel2, 0);
            this.Controls.SetChildIndex(this.ultraLabel3, 0);
            this.Controls.SetChildIndex(this.ultraLabel4, 0);
            this.Controls.SetChildIndex(this.ultraDateTimeEditorDesde, 0);
            this.Controls.SetChildIndex(this.ultraDateTimeEditorHasta, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorDesde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorHasta;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorDesde;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
    }
}

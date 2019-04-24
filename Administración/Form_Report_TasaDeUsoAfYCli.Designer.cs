namespace Administración
{
    partial class FormReportTasaDeUsoAfYCli
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
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.ultraLabelPeriodoHasta = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelPeriodoDesde = new Infragistics.Win.Misc.UltraLabel();
            this.ultraDateTimeEditorPeriodoHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraDateTimeEditorPeriodoDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodoHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodoDesde)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonAplicar
            // 
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 86);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(95, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ultraLabelPeriodoHasta
            // 
            appearance31.TextHAlignAsString = "Right";
            this.ultraLabelPeriodoHasta.Appearance = appearance31;
            this.ultraLabelPeriodoHasta.AutoSize = true;
            this.ultraLabelPeriodoHasta.Location = new System.Drawing.Point(40, 53);
            this.ultraLabelPeriodoHasta.Name = "ultraLabelPeriodoHasta";
            this.ultraLabelPeriodoHasta.Size = new System.Drawing.Size(76, 14);
            this.ultraLabelPeriodoHasta.TabIndex = 23;
            this.ultraLabelPeriodoHasta.Text = "Período Hasta";
            // 
            // ultraLabelPeriodoDesde
            // 
            appearance2.TextHAlignAsString = "Right";
            this.ultraLabelPeriodoDesde.Appearance = appearance2;
            this.ultraLabelPeriodoDesde.AutoSize = true;
            this.ultraLabelPeriodoDesde.Location = new System.Drawing.Point(37, 26);
            this.ultraLabelPeriodoDesde.Name = "ultraLabelPeriodoDesde";
            this.ultraLabelPeriodoDesde.Size = new System.Drawing.Size(79, 14);
            this.ultraLabelPeriodoDesde.TabIndex = 22;
            this.ultraLabelPeriodoDesde.Text = "Período Desde";
            // 
            // ultraDateTimeEditorPeriodoHasta
            // 
            this.ultraDateTimeEditorPeriodoHasta.DateTime = new System.DateTime(2010, 1, 27, 0, 0, 0, 0);
            this.ultraDateTimeEditorPeriodoHasta.FormatString = "";
            this.ultraDateTimeEditorPeriodoHasta.Location = new System.Drawing.Point(122, 49);
            this.ultraDateTimeEditorPeriodoHasta.MaskInput = "{LOC}mm/yyyy";
            this.ultraDateTimeEditorPeriodoHasta.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.ultraDateTimeEditorPeriodoHasta.MinDate = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            this.ultraDateTimeEditorPeriodoHasta.Name = "ultraDateTimeEditorPeriodoHasta";
            this.ultraDateTimeEditorPeriodoHasta.Size = new System.Drawing.Size(77, 21);
            this.ultraDateTimeEditorPeriodoHasta.TabIndex = 21;
            this.ultraDateTimeEditorPeriodoHasta.Value = new System.DateTime(2010, 1, 27, 0, 0, 0, 0);
            // 
            // ultraDateTimeEditorPeriodoDesde
            // 
            this.ultraDateTimeEditorPeriodoDesde.DateTime = new System.DateTime(2010, 1, 27, 0, 0, 0, 0);
            this.ultraDateTimeEditorPeriodoDesde.FormatString = "";
            this.ultraDateTimeEditorPeriodoDesde.Location = new System.Drawing.Point(122, 22);
            this.ultraDateTimeEditorPeriodoDesde.MaskInput = "{LOC}mm/yyyy";
            this.ultraDateTimeEditorPeriodoDesde.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.ultraDateTimeEditorPeriodoDesde.MinDate = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            this.ultraDateTimeEditorPeriodoDesde.Name = "ultraDateTimeEditorPeriodoDesde";
            this.ultraDateTimeEditorPeriodoDesde.Size = new System.Drawing.Size(77, 21);
            this.ultraDateTimeEditorPeriodoDesde.TabIndex = 20;
            this.ultraDateTimeEditorPeriodoDesde.Value = new System.DateTime(2010, 1, 27, 0, 0, 0, 0);
            // 
            // Form_Report_TasaDeUsoAfYCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(265, 134);
            this.Controls.Add(this.ultraLabelPeriodoHasta);
            this.Controls.Add(this.ultraLabelPeriodoDesde);
            this.Controls.Add(this.ultraDateTimeEditorPeriodoHasta);
            this.Controls.Add(this.ultraDateTimeEditorPeriodoDesde);
            this.Name = "FormReportTasaDeUsoAfYCli";
            this.Text = "Tasa de Uso Afiliados y Clientes";
            this.Load += new System.EventHandler(this.Form_Report_TasaDeUsoAfYCli_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDateTimeEditorPeriodoDesde, 0);
            this.Controls.SetChildIndex(this.ultraDateTimeEditorPeriodoHasta, 0);
            this.Controls.SetChildIndex(this.ultraLabelPeriodoDesde, 0);
            this.Controls.SetChildIndex(this.ultraLabelPeriodoHasta, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodoHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodoDesde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabelPeriodoHasta;
        private Infragistics.Win.Misc.UltraLabel ultraLabelPeriodoDesde;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorPeriodoHasta;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorPeriodoDesde;
    }
}

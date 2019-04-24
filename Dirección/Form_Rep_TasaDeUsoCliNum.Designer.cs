namespace Dirección
{
    partial class FormRepTasaDeUsoCliNum
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
            this.CR_TasaDeUsoCliNum1 = new Dirección.CR_TasaDeUsoCliNum();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.crystalReportViewer1.ReportSource = this.CR_TasaDeUsoCliNum1;
            // 
            // FormRepTasaDeUsoCliNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepTasaDeUsoCliNum";
            this.Text = "Tasa de Uso";
            this.Load += new System.EventHandler(this.FormRepTasaDeUsoLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private CR_TasaDeUsoCliNum CR_TasaDeUsoCliNum1;


    }
}
